using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LilArtist.CA.DAL.Entities
{
    public class Lot
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
