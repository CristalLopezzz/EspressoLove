using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class HomepageModel : PageModel
    {
        public string DealofTheDay { get; set;}
        public string BusinessHours { get; set;}
        public void OnGet()
        {
            //Didn't have time to add a randomized list that would change each day for the "Deal of the Day"
            DealofTheDay = "Buy 1 Espresso Love drink and get one 50% off";
            BusinessHours = "Monday to Sunday 6:00AM-3:00pm";
        }
    }
}
