using System.ComponentModel.DataAnnotations;

namespace ContactBook.Core
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public NationalityType Nationality { get; set; }
    }
}
