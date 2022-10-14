using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class StudentModel
    {
        public int student_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public double cgpa { get; set; }
        public string department { get; set; }
        public System.DateTime dob { get; set; }
    }
}
