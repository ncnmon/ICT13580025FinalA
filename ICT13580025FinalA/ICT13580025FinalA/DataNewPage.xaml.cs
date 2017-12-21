using ICT13580025FinalA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICT13580025FinalA
{
   
    public partial class DataNewPage : ContentPage
    {
        Data data;
        public DataNewPage(Data data=null)
        {
            InitializeComponent();

            this.data = data;
            saveButton.Clicked += SaveButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked ;

            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");

            departmentPicker.Items.Add("บัญชี");
            departmentPicker.Items.Add("การตลาด");
            departmentPicker.Items.Add("ไอที");

           
            if (data != null)
            {
                nameEntry.Text = data.Name;
                surNameEntry.Text = data.Surname;
                ageEntry.Text = data.Age.ToString();
                genderPicker.SelectedItem = data.Sex;
                departmentPicker.SelectedItem = data.Department;
                telEntry.Text = data.Tel.ToString();
                mailEntry.Text = data.Email;
                addressEditor.Text = data.Address;
                



                
            }





        }

     
        private void CancelButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

       async private void SaveButton_Clicked(object sender, EventArgs e)
        {
            var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่","ไม่");
            if (isOk)
            {
                if (data == null)
                {
                    data.Name = nameEntry.Text;
                    data.Surname = surNameEntry.Text;
                    data.Age = int.Parse(ageEntry.Text);
                    data.Sex = genderPicker.SelectedItem.ToString();
                    data.Department = departmentPicker.SelectedItem.ToString();
                    data.Tel = telEntry.Text;
                    data.Address = addressEditor.Text;
                    data.Number = int.Parse(childEntry.Text);
                    data.Salary = decimal.Parse(salaryEntry.Text);

                    var id = App.DbHelper.AddData(data);
                    await DisplayAlert("บันทึกสำเร็จ", "แก้ไขข้อมูลเรียบร้อย" + id, "ตกลง");


                }
                else
                {
                    data.Name = nameEntry.Text;
                    data.Surname = surNameEntry.Text;
                    data.Age = int.Parse(ageEntry.Text);
                    data.Sex = genderPicker.SelectedItem.ToString();
                    data.Department = departmentPicker.SelectedItem.ToString();
                    data.Tel = telEntry.Text;
                    data.Address = addressEditor.Text;
                    data.Number = int.Parse(childEntry.Text);
                    data.Salary = decimal.Parse(salaryEntry.Text);

                    var id = App.DbHelper.AddData(data);
                    await DisplayAlert("บันทึกสำเร็จ", "แก้ไขข้อมูลเรียบร้อย" , "ตกลง");

                }
                await Navigation.PopModalAsync();
            }
        }
    }
}