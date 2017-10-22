using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace halloween.Model
{
    public class Greetings
    {
        [DisplayName("To")] //Label
        [Display(Prompt = "recipient")] //Field Name
        [Required(ErrorMessage = "Required")]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "You must enter between 3 to 70 characters")]
        public string recipient { get; set; }


        [DisplayName("Recipient's Email")]
        [Display(Prompt = "recipientName@domain.com")]
        [Required(ErrorMessage = "Required")]
        public string recipEmail { get; set; }

        [DisplayName("Subject")]
        [Required(ErrorMessage = "Required")]
        public string subject { get; set; }

        [DisplayName("Message")]
        [Required(ErrorMessage = "Required")]
        public string message { get; set; }

        [DisplayName("From")]
        [Required(ErrorMessage = "Required")]
        public string senderName { get; set; }

        [DisplayName("Your Email")]
        [Required(ErrorMessage = "Required")]
        public string senderEmail { get; set; }


    }
}
