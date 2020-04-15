using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VerifyUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            string option;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Swaping characteres");
                Console.WriteLine("2. Verify Uppercase");
                Console.WriteLine("0. Exit");
                Console.Write("Please choose the options as above: ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        do
                        {
                            var strList = new List<string> { "1", "2", "c", "d", "5", "6" };
                            string a = "3", b = "4";
                            string c = "c", d = "d";

                            Console.WriteLine();
                            Console.WriteLine("\tSwaping Characters options");
                            Console.WriteLine("\t1.1 Passing Reference Types By Value");
                            Console.WriteLine("\t1.2 Passing Reference Types By Value");
                            Console.WriteLine("\t0.0 Exit");
                            Console.Write("\tPlease choose the options as above: ");
                            option = Console.ReadLine();

                            switch (option)
                            {
                                case "1.1":
                                    // Passing Reference Types By Value
                                    Replace_PassRefTypeByVal(strList, c, a);
                                    Replace_PassRefTypeByVal(strList, d, b);
                                    Console.WriteLine("The list after replace: {0}", PrintList(strList));
                                    break;
                                case "1.2":
                                    // Passing Reference Types By Reference
                                    Replace_PassRefTypeByRef(ref strList, c, a);
                                    Replace_PassRefTypeByRef(ref strList, d, b);
                                    Console.WriteLine("The list after replace: {0}", PrintList(strList));
                                    break;
                            }

                        } while (option != "0.0");
                        break;

                    case "2":
                        Console.Write("Please enter your full name: ");
                        var fullName = Console.ReadLine();
                        bool flag = VerifyUppercase(fullName);
                        Console.WriteLine(Message(flag));
                        break;
                }
            } while (option != "0");
        }

        private static void Replace_PassRefTypeByVal(List<string> strList, string value, string replaceValue)
        {
            for (int i = 0; i < strList.Count; i++)
            {
                if (strList[i].CompareTo(value) == 0)
                    strList[i] = replaceValue;
            }
        }

        private static void Replace_PassRefTypeByRef(ref List<string> strList, string value, string replaceValue)
        {
            var newList = new List<string>();

            for (int i = 0; i < strList.Count; i++)
            {
                if (strList[i].CompareTo(value) == 0)
                    strList[i] = replaceValue;
                newList.Add(strList[i]);
            }

            strList = new List<string>(newList);
        }

        private static string PrintList(List<string> strList)
        {
            string formatList = "{";
            for (int i = 0; i < (strList.Count) - 1; i++)
                formatList += " " + strList[i] + ",";
            formatList += " " + strList[strList.Count - 1] + "}";
            return formatList;
        }

        private static bool VerifyUppercase(string strContent)
        {
            string content = IgnoreWhileSpace(strContent);
            bool flag = IsUppercase(content);
            return flag;
        }

        private static string IgnoreWhileSpace(string strContent)
        {
            return strContent.Replace(" ", "");
        }

        private static bool IsUppercase(string content)
        {
            bool flag = false;

            for (int i = 0; i < content.Length; i++)
            {
                string strTemp = content[i].ToString();
                if (strTemp.CompareTo(strTemp.ToUpper()) == 0)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        private static string Message(bool flag)
        {
            if (flag)
                return "The string contains uppercase";
            return "The string does not contain uppercase";
        }
    }
}
