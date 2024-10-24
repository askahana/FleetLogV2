using FleetLogV2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FleetLogV2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Driver>().HasData(new Driver
            {
                DriverId = 1,
                DriverName = "Bengt Andersson",
                CarReg = "ABC123",
                EmployeeId = 1,
            });
            modelBuilder.Entity<Driver>().HasData(new Driver
            {
                DriverId = 2,
                DriverName = "Sven Eriksson",
                CarReg = "CDE234",
                EmployeeId = 1,
            });
            modelBuilder.Entity<Driver>().HasData(new Driver
            {
                DriverId = 3,
                DriverName = "Karin Larsson",
                CarReg = "CAL234",
                EmployeeId = 2,
            });
            modelBuilder.Entity<Driver>().HasData(new Driver
            {
                DriverId = 4,
                DriverName = "Tove Jansson",
                CarReg = "MUM234",
                EmployeeId = 2,
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                EmployeeName = "Felicia Jahansson",
                Email = "feli@mail.se",
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                EmployeeName = "Jack Black",
                Email = "jack@mail.se",
            });

            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 1,
                EventType = EventType.StartShift,
                TimeStamp = new DateTime(2024, 9, 10, 10, 30, 50),
                AmountIn = 0,
                AmountOut = 0,
                DriverId = 1,
            });
            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 2,
                EventType = EventType.EndShift,
                TimeStamp = new DateTime(2024, 9, 10, 15, 30, 50),
                AmountIn = 400,
                AmountOut = 0,
                DriverId = 1,
            });
            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 3,
                EventType = EventType.StartShift,
                TimeStamp = new DateTime(2024, 9, 10, 05, 30, 50),
                AmountIn = 0,
                AmountOut = 0,
                DriverId = 2,
            });
            modelBuilder.Entity<Event>().HasData(new Event
            {
                EventId = 4,
                EventType = EventType.EndShift,
                TimeStamp = new DateTime(2024, 9, 10, 05, 30, 50),
                AmountIn = 1000,
                AmountOut = 0,
                DriverId = 2,
            });
        }
    }
}
