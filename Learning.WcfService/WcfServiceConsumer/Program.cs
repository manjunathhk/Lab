using System;
using Learning.WcfService.Consumer.ProductServiceReference;
using Learning.WcfService.Consumer.UserServiceReference;
using Learning.WcfService.Models;

namespace Learning.WcfService.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("User Information");
                UserServiceClient userServiceClient = new UserServiceClient();
                userServiceClient.SaveUser(new User { Username = "Username from UI", Password = "Password from UI" });


                User user = userServiceClient.GetUserInformation();
                userServiceClient.Close();
                Console.WriteLine(user.Username);
                Console.WriteLine(user.Password);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error in User service");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

            try
            {
                Console.WriteLine("Product Information");
                ProductServiceClient productServiceClient = new ProductServiceClient();

                productServiceClient.Save(new Product {Name = "Product Name"});
                Product product = productServiceClient.GetAll();
                productServiceClient.Close();
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Name);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error in Product service");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
