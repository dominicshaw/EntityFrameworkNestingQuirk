using System.ComponentModel.DataAnnotations;

namespace Appraiser.Data.Models
{
    public class Contact
    {
        public Contact()
        {

        }

        public Contact(EmergencyContacts from)
        {
            EmergencyContactsId = from.Id;
        }

        [Key]
        public int Id { get; set; }

        public int EmergencyContactsId { get; set; }
        public EmergencyContacts EmergencyContacts { get; set; }

        [MaxLength(20)]
        public string Title { get; set; }
        [MaxLength(100)]
        public string Firstname { get; set; }
        [MaxLength(100)]
        public string Middlename { get; set; }
        [MaxLength(100)]
        public string Surname { get; set; }
        [MaxLength(100)]
        public string Relationship { get; set; }
        [MaxLength(100)]
        public string DayPhone { get; set; }
        [MaxLength(100)]
        public string EveningPhone { get; set; }
        [MaxLength(100)]
        public string Address1 { get; set; }
        [MaxLength(100)]
        public string Address2 { get; set; }
        [MaxLength(100)]
        public string Address3 { get; set; }
        [MaxLength(100)]
        public string Town { get; set; }
        [MaxLength(100)]
        public string County { get; set; }
        [MaxLength(100)]
        public string Postcode { get; set; }
    }
}