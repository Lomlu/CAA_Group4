using System;
using System.IO;
using System.Text;

namespace CookingAdvisorApplication_Group4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

            filePath = Directory.GetParent(Directory.GetParent(Directory.GetParent(filePath).FullName).FullName).FullName;

            string subFolder_1 = filePath + @"\Receipts";

            string subFolder_2 = subFolder_1 + @"\Salad";

            string textFile = subFolder_2 + @"\Fruit Salad.txt";
            */
            /*
            var sb = new StringBuilder();

            sb.AppendLine("Calories:");
            sb.AppendLine("100 Calories");
            sb.AppendLine("Time:");
            sb.AppendLine("1 Hour");
            sb.AppendLine("Ingrediants:");
            sb.AppendLine("1. Apple");
            sb.AppendLine("2. Lettuce");
            sb.AppendLine("Cooking Directions:");
            sb.AppendLine("Slice the apple");
            sb.AppendLine("Slice the lettuce");
            sb.AppendLine("Mix them");

            using var reader = new StringReader(sb.ToString());

            string receiptDirection = reader.ReadToEnd();

            
            File.WriteAllText(textFile, receiptDirection);

            string readText = File.ReadAllText(textFile);
            
            Console.WriteLine(readText);
           */

            SaladReceipts saladReceipts = new SaladReceipts();
            saladReceipts.addNewReceipt();
        }
    }
}
