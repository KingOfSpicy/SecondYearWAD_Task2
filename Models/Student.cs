using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheWei_WAD_Task_S2.Models
{
    public class Student
    {
        public Student()
        {
            this.Enrollments = new HashSet<Enrollment>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Familyname { get; set; }
        public System.DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}
