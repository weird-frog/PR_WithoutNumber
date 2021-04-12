using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_с_несколькими_проектами_в_рамках_одного_решения
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webclient = new WebClient();
            try
            {
                Console.WriteLine("Скачивание архива .rar");
                webclient.DownloadFile("https://caph.workupload.com/download/zMR4vIPW", "sample.rar");

                Console.WriteLine("Скачивание файла .pdf");
                webclient.DownloadFile("http://www.africau.edu/images/default/sample.pdf", "sample.pdf");

                Console.WriteLine("Скачивание страницы Google\n");
                Console.WriteLine(webclient.DownloadString("https://google.com"));
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
            
        }
    }
}
