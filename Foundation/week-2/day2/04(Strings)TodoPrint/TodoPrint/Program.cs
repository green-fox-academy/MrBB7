using System;
using System.Text;

namespace TodoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";

            StringBuilder todoListpartOneBuilder = new StringBuilder();

            todoListpartOneBuilder
                .Append("My todo:" + Environment.NewLine)
                .Append(todoText)
                .Append(" - Download games" + Environment.NewLine)
                .Append("   - Diablo");
            Console.WriteLine(todoListpartOneBuilder);
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            Console.ReadLine();
        }
    }
}
