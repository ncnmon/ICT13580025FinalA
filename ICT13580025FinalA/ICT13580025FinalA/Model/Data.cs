using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT13580025FinalA.Model
{
    public class Data
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Department { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public int Number { get; set; }
        public decimal Salary { get; set; }
    }
}
