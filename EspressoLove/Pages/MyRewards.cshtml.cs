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
