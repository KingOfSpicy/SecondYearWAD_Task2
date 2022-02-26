using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CheWei_WAD_Task_S2.Models;

namespace CheWei_WAD_Task_S2.Data
{
    public class CheWei_WAD_Task_S2Context : DbContext
    {
        public CheWei_WAD_Task_S2Context (DbContextOptions<CheWei_WAD_Task_S2Context> options)
            : base(options)
        {
        }

        public DbSet<CheWei_WAD_Task_S2.Models.Course> Course { get; set; }

        public DbSet<CheWei_WAD_Task_S2.Models.Enrollment> Enrollment { get; set; }

        public DbSet<CheWei_WAD_Task_S2.Models.Student> Student { get; set; }
    }
}
