using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplication
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //application.enablevisualstyles();
            //application.setcompatibletextrenderingdefault(false);
            //application.run(new form1());
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Console.WriteLine(connectionString);

            Console.Read();


        }
    }
}
