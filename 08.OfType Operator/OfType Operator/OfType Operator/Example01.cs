using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfType_Operator
{
    public class Example01
    {

        public void Test()
        {

            List<object> dataSource = new List<object>() 
            {
             "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"

            };

            // OFType With where 
            

            var OFTypeWithWhere = dataSource.OfType<int>().Where(x=>x >30).ToList();
            
            var QuerrySyntaxWithWhere =  (from item in dataSource.OfType<int>()
                                         where item > 30 
                                         select item ).ToList();



            //Check int and number > 30


            var QuerrySyntaxWithWhere2 = (from item in dataSource
                                          where item is int && Convert.ToInt16(item) > 30
                                          select item).ToList();

            //Use casting defferent
            var QuerrySyntaxWithWhere3 = (from item in dataSource
                                          where item is int && (int)item > 30
                                          select item).ToList();


            foreach (var item in QuerrySyntaxWithWhere3)
            {
                Console.Write(item + " ");
            }

            // Result - Fetching the Integer Numbers which are greater than 30

            //var intData = dataSource.OfType<int>().Where(x=>x > 30).ToList();

            //foreach (var item in intData)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();

            //var stringData =  (from item in dataSource
            //                  where item is string && item.ToString().Length>3
            //                  select item).ToList();


            //foreach (var item in stringData)
            //{
            //    Console.Write(item + " ");
            //}



            ////Using Querry Syntax
            ////Get integer value
            //var QueeryIntList = (from intItem in dataSource.OfType<int>() select intItem).ToList();

            //foreach (var item in QueeryIntList)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //// Get string value
            //var QuerryStringList =  (from StringItem in dataSource
            //                        where StringItem is string
            //                        select StringItem).ToList();


            //foreach (var item in QuerryStringList)
            //{
            //    Console.Write(item + " ");
            //}







            //List<int> intList =  dataSource.OfType<int>().ToList();

            //foreach (var item in intList)
            //{
            //    Console.Write(item + " ");
            //}



        }
    }
}
