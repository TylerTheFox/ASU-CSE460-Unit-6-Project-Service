using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BMI_App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();



        protected void soap_button_click(object sender, EventArgs e)
        {
            try
            {
                Console.Write("Hi! 1");
            }
            catch (Exception ex)
            {
                Exception E = ex;
            }
        }

        protected void rest_button_click(object sender, EventArgs e)
        {
            try
            {
                Console.Write("Hi! 2");
            }
            catch (Exception ex)
            {
                Exception E = ex;
            }
        }
    }
}
