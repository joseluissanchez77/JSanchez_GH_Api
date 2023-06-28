using JSanchez_GH_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace JSanchez_GH_Api.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person()
                {
                    Id = 1,
                    Identification = "0931147284",
                    First_Name = "Jose",
                    Second_Name = "Luis",
                    First_Last_Name = "Sanchez",
                    Second_Last_Name = "Baque",
                    Place_Of_Birth = "Guayas",
                    Date_Of_Birth = DateTime.Now.Date,
                    Nationality = "Ecuatoriana",
                    Sexo = "Masculino",
                    Marital_Status = "Soltero",
                    Photo = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Person()
                {
                    Id = 2,
                    Identification = "0931147597",
                    First_Name = "Karen",
                    Second_Name = "Anais",
                    First_Last_Name = "Ososrio",
                    Second_Last_Name = "Jimenes",
                    Place_Of_Birth = "Guayas",
                    Date_Of_Birth = DateTime.Now.Date,
                    Nationality = "Ecuatoriana",
                    Sexo = "Femenimo",
                    Marital_Status = "Soltero",
                    Photo = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
            );
        }
    }
}
