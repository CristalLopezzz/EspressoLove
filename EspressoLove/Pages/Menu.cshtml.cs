using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class MenuModel : PageModel
    {
        public List<MenuItem> MenuItems { get;set; }

        public void OnGet()
        {
            MenuItems = new List<MenuItem>
            {
                //List of menu items
                new MenuItem
                {
                    Name = "Espresso Love Special",
                    Description = "A coffee drink made with a shot of espresso, milk, caramel drizzle, and vanilla sweet cold foam.",
                    Size = "Size: Regular",
                    Style = "Only iced",
                    Price = "$5.00",
                    Image = "/images/EspressoLoveSpecial.jpg",
                },
                new MenuItem
                {
                    Name = "Latte",
                    Description = "A coffee drink made with a shot of espresso and milk.",
                    Size = "Size: Regular",
                    Style = "Iced or Hot",
                    Price = "$3.00",
                    Image = "/images/latte.jpg",
                },
                new MenuItem
                {
                    Name = "Cappuccino",
                    Description = "A coffee drink made with espresso, steamed milk, and milk foam.",
                    Size = "Size: Regular",
                    Style = "Iced or Hot",
                    Price = "$3.00",
                    Image = "/images/cappuccino.jpg",

                },
                new MenuItem
                {
                    Name = "Dalgona",
                    Description = "A coffee drink made with whipped frothy coffee served over milk.",
                    Size = "Size: Regular",
                    Style = "Iced or Hot",
                    Price = "$3.00",
                    Image = "/images/dalgona.jpg",

                },
            };
        }
        } //I would've added an "add to cart" feature-->
        public class MenuItem
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Size { get; set; }
            public string Style { get; set; }
            public string Price { get; set; }
            public string Image { get; set; }

        }
    }

