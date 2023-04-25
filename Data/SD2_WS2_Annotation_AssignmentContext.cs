using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SD2_WS2_Annotation_Assignment.Models;

namespace SD2_WS2_Annotation_Assignment.Data
{
    public class SD2_WS2_Annotation_AssignmentContext : DbContext
    {
        public SD2_WS2_Annotation_AssignmentContext (DbContextOptions<SD2_WS2_Annotation_AssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<SD2_WS2_Annotation_Assignment.Models.User> User { get; set; } = default!;
    }
}
