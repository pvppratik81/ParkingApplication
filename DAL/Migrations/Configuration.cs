namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.UCBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.UCBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Roles.AddOrUpdate(x => x.Id,
     new Role() { Id = 1, RoleName = "SO" },
     new Role() { Id = 2, RoleName = "HQ" },
     new Role() { Id = 3, RoleName = "AD" }
     );

            context.ParkingSlots.AddOrUpdate(x => x.Id,
                    new ParkingSlot() { Id = 1, SlotName = "A1", IsAssigned = true },
                    new ParkingSlot() { Id = 2, SlotName = "A2", IsAssigned = true },
                    new ParkingSlot() { Id = 3, SlotName = "A3", IsAssigned = true },
                    new ParkingSlot() { Id = 4, SlotName = "A4", IsAssigned = true },
                    new ParkingSlot() { Id = 5, SlotName = "A5", IsAssigned = true },
                    new ParkingSlot() { Id = 6, SlotName = "A6", IsAssigned = false },
                    new ParkingSlot() { Id = 7, SlotName = "A7", IsAssigned = false },
                    new ParkingSlot() { Id = 8, SlotName = "A8", IsAssigned = false },
                    new ParkingSlot() { Id = 9, SlotName = "A9", IsAssigned = false },
                    new ParkingSlot() { Id = 10, SlotName = "A10", IsAssigned = false },
                    new ParkingSlot() { Id = 11, SlotName = "B1", IsAssigned = false },
                    new ParkingSlot() { Id = 12, SlotName = "B2", IsAssigned = false },
                    new ParkingSlot() { Id = 13, SlotName = "B3", IsAssigned = false },
                    new ParkingSlot() { Id = 14, SlotName = "B4", IsAssigned = false },
                    new ParkingSlot() { Id = 15, SlotName = "B5", IsAssigned = false },
                    new ParkingSlot() { Id = 16, SlotName = "B6", IsAssigned = false },
                    new ParkingSlot() { Id = 17, SlotName = "B7", IsAssigned = false },
                    new ParkingSlot() { Id = 18, SlotName = "B8", IsAssigned = false },
                    new ParkingSlot() { Id = 19, SlotName = "B9", IsAssigned = false },
                    new ParkingSlot() { Id = 20, SlotName = "B10", IsAssigned = false });

            context.Employees.AddOrUpdate(x => x.Id,
new Employee() { Id = 1, FirstName = "User1", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = 1, RoleId = 1, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 2, FirstName = "User2", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = 2, RoleId = 1, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 3, FirstName = "User3", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = 3, RoleId = 1, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 4, FirstName = "User4", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = 4, RoleId = 1, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 5, FirstName = "User5", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = 5, RoleId = 1, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 6, FirstName = "User6", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 7, FirstName = "User7", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 8, FirstName = "User8", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 9, FirstName = "User9", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 10, FirstName = "User10", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 11, FirstName = "User11", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 12, FirstName = "User12", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 13, FirstName = "User13", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 14, FirstName = "User14", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 15, FirstName = "User15", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 16, FirstName = "User16", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 17, FirstName = "User17", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 18, FirstName = "User18", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 19, FirstName = "User19", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 20, FirstName = "User20", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 21, FirstName = "User21", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 22, FirstName = "User22", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 23, FirstName = "User23", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 24, FirstName = "User24", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 25, FirstName = "User25", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 26, FirstName = "User26", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 27, FirstName = "User27", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 28, FirstName = "User28", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 29, FirstName = "User29", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 30, FirstName = "User30", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 31, FirstName = "User31", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 32, FirstName = "User32", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 33, FirstName = "User33", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 34, FirstName = "User34", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null },
new Employee() { Id = 35, FirstName = "User35", LastName = "", MiddleName = "", Email = "1@com", Phone = "123456789", ParkingSlotId = null, RoleId = 2, CreatedBy = "Admin", CreatedDate = DateTime.Today, ModifiedBy = "", ModifiedDate = null });
        }
    }
}
