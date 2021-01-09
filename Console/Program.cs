using System;
using System.Threading.Tasks;
using ConsoleApp1.Properties;
using IO.Swagger.Model;
using Pd.Ratmon;

namespace RatmonApp
{
    class Program
    {
        public static GetToken token;
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start...");
            string txtusername = Resources.username;
            string txtpassword = Resources.password;
            try
            {
                token = await Request.PostRequestAuth(txtusername, txtpassword);
            }
            catch
            {
                Console.WriteLine("Connection OK!");
            }
            Console.WriteLine(token);
            int ch = 12; 
            Console.Write("Select Channel /default=12/: ");
            try
            {
                ch = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                ch = 12;
            }
            finally
            {
                Console.WriteLine($"Selected Channel: {ch}");
            }
            //
            var allcircut = await Request.GetRequestAllCircuits(token);
            Console.WriteLine(allcircut.Count);
            //
            var resp_chanel = await Request.GetRequestSelectedChanel(ch, token);
            Console.WriteLine("Channel:12");
            Console.WriteLine(resp_chanel);
            Console.ReadKey();
        }
    }
}
