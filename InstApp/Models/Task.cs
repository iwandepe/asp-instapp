using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstApp.Models
{
    public partial class Task : BaseModel
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int title { get; set; }
        public string Description { get; set; } = null!;
        public string? Category { get; set; }
        public bool IsComplete { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
