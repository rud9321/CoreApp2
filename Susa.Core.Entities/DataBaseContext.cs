using Microsoft.EntityFrameworkCore;
using Susa.Core.Entities.Models;

namespace Susa.Core.Entities
{
    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        public DbSet<Broadcast> Broadcasts { get; set; }
        public DbSet<Classification_Type> Classification_Types { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Survey_Case> Survey_Cases { get; set; }
        public DbSet<Survey_Case_Status> Survey_Case_Status { get; set; }
        public DbSet<Survey_Case_Vehicle_Detail> Survey_Case_Vehicle_Details { get; set; }
        public DbSet<Survey_Tracking> Survey_Trackings { get; set; }
        public DbSet<Surveyor> Surveyors { get; set; }
        public DbSet<Surveyor_Expertise_Type> Surveyor_Expertise_Types { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_Type> User_Types { get; set; }
        public DbSet<Vehicle_Type> Vehicle_Types { get; set; }
        public DbSet<WorkShop> WorkShops { get; set; }

        
    }
}
