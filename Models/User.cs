using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SD2_WS2_Annotation_Assignment.Models
{
    public class User
    {
        public int Id { get; set; }


        public string FirstName { get; set; }


        public string LastName { get; set; }


        public DateTime Birthdate { get; set; }


        public string Email { get; set; }


        public string PhoneNumber { get; set; }


        public string Password { get; set; }

        
        public string ConfirmPassword { get; set; }



        public string IPv4Address { get; set; }
    }
}
