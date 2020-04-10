using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your full name: ");
            var fullName = Console.ReadLine();
            bool flag = VerifyUppercase(fullName);
            Console.WriteLine(Message(flag));
            Console.WriteLine("Press the enter to exit");
            Console.Read();
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
