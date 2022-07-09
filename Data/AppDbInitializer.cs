using ShoppingCart.Models;

namespace ShoppingCart.Data
{
    public class AppDbInitializer
    {
        public static void Seed (IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ShoppingCartDbContext>();

                if (!context.Pages.Any())
                {
                    context.Pages.AddRange(new Page()
                    {
                        Title="Home",
                        Slug ="home",
                        Content="home page",
                        Sorting= 0



                    },
                    new Page()
                    {
                        Title = "About Us",
                        Slug = "about-us",
                        Content = "aboutus page",
                        Sorting = 100


                     },
                    new Page() 
                    {
                        Title = "Services",
                        Slug = "services",
                        Content = "services page",
                        Sorting = 100


                    },

                       new Page()
                       {
                           Title = "Contact",
                           Slug = "contact",
                           Content = "contact page",
                           Sorting = 200


                       }

                    );
                    context.SaveChanges();  
                }
            }
        }
    }
}
