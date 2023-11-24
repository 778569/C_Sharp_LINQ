using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Zip_Method
{
    public class Example01
    {
        public void Test()
        {
            int[] numbersSequence = new int[] { 10, 20, 30, 40, 50 };

            string[] wordsSequence = new string[] { "Ten", "Twenty", "Thirty", "Fourty" };

            var resultSequence = numbersSequence.Zip(wordsSequence,(first,second)=> first + " - "+ second);

            foreach (var item in resultSequence)
            {
                Console.WriteLine(item);
            }
        }

        public void Test2()
        {
            var keys = new List<string> { "ID", "Name", "Email", "Mobile" };

            var values = new List<string> { "1", "Pranaya", "Pranaya@example.com", "1234567890" };

            var dictionary = keys.Zip(values, (k, v) => new
            {
                k,
                v
            }).ToDictionary(x => x.k, x => x.v);

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
