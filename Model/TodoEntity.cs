using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAPI.Model
{
    [Table("Tdod", Schema = "dbo")]
    public class TodoEntity
    {
            [Display(Name = "TodoId")]
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int TodoId { get; set; }

            [Required]
            [Column(TypeName = "varchar(50)")]
            [Display(Name = "Title")]
            public string Title { get; set; }

            [Required]
            [Column(TypeName = "bit")]
            [Display(Name = "Completed")]
            public bool Completed { get; set; }
    }
}
