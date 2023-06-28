using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JSanchez_GH_Api.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        //[Index("Identification", IsUnique = true)]
        [MaxLength(20)]
        [Required]
        public string Identification { get; set; }

        [Required]
        public string First_Name { get; set; }

        public string Second_Name { get; set; }

        [Required]
        public string First_Last_Name { get; set; }

        [Required]
        public string Second_Last_Name { get; set; }

        [Required]
        public string Place_Of_Birth { get; set; }

        [Required]
        public DateTime Date_Of_Birth { get; set; }


        [Required]
        public string Nationality { get; set; }


        [Required]
        public string Sexo { get; set; }


        [Required]
        public string Marital_Status { get; set; }


        [MaxLength(5000)]
        public string Photo { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

    }
}
