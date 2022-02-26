using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheWei_WAD_Task_S2.Models
{
    public class Course
    {
        public Course()
        {
            this.Enrollments = new HashSet<Enrollment>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}
