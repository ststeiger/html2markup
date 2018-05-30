
namespace TestApplicationCore
{


    class Program
    {


        static void Main(string[] args)
        {
            string html = System.IO.File.ReadAllText("example.htm");

            string textile = HTML2Markup.MarkupConverter.HTML2Textile(html);
            System.Console.WriteLine(textile);

            System.Console.WriteLine(System.Environment.NewLine);
            System.Console.WriteLine(" --- Press any key to continue --- ");
            System.Console.ReadKey();
        }


    }


}
