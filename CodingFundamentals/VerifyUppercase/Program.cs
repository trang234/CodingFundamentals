using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifyUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            var strList = new List<string> { "1", "2", "c", "d", "5", "6" };
            strList = Swap(strList);
            Console.WriteLine("The list after swap: {0}", PrintList(strList));
            Console.WriteLine("Please press enter to exit");
            Console.ReadLine();
        }

        private static string PrintList(List<string> strList)
        {
            string formatList = "{";
            for (int i = 0; i < (strList.Count) - 1; i++)
                formatList += " " + strList[i] + ",";
            formatList += " " + strList[strList.Count - 1] + "}";
            return formatList;
        }

        private static List<string> Swap(List<string> strList)
        {
            string a = "3", b = "4";
            for (int i = 0; i < strList.Count; i++)
            {
                switch (strList[i])
                {
                    case "c":
                        strList[i] = a;
                        break;
                    case "d":
                        strList[i] = b;
                        break;
                }
            }
            return strList;
        }
    }
}
