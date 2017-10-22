using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace halloween.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        //[BindProperty]
        //public string to_name { get; set; }
        //[BindProperty]
        //public string to_email { get; set; }

        //public void OnGet()
        //{
       
        //}

        //public void OnPost()
        //{
        //    Message = "Hello, Anna!!!";
        //}
    }
}
