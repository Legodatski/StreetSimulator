using Microsoft.EntityFrameworkCore;

namespace Context
{
    public class StreetSimulatorContext : DbContext
    {
        public StreetSimulatorContext()
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-HI2ES57;Database=CarDealer;Trusted_Connection=True;");
            }
        }
    }
}