using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UCBContext:DbContext
    {
        public UCBContext() : base("name=UCBDBConnectionString")
        {
            
          
        }


       

        public DbSet<ParkingSlot> ParkingSlots { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ReleasedSlot> ReleasedSlots { get; set; }
        public DbSet<RequestSlot> RequestSlots { get; set; }
        public DbSet<SlotAllocation> SlotAllocations { get; set; }

    }
}
