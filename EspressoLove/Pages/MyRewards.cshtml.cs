using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class MyRewardsModel : PageModel
    {
        [BindProperty]
        public string? PhoneNumber { get; set; }
        public int Points { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            //If else condition to allow for preview of how it would work in real life
            if (PhoneNumber == "1234567890")
            {
                Points = 100;

            }
            else 
            {
                Points = 0;
            }
        }
    }
}
