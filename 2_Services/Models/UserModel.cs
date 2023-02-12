using _3_Repositories.Entities;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace _2_Services.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string HMO { get; set; }
        public virtual ICollection<Child> Children { get; set; }
    }
}
