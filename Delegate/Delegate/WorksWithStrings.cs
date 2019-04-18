using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class WorksWithStrings
    {
        public event Func<string, string> Trimed;

        public event Action<string> Uppercase; //событие
        public void Uppercased(string str)
        {
            string str1;
            str1 = str.ToUpper();
            string error = "Error";
            if (Uppercase != null)
            {
                Uppercase(str1);
            }
            else
            {
                if (Uppercase != null)
                {
                    Uppercase(error);
                }
            }
        }



        public void Trims(string str)
        {
            string MyString;
            char[] MyChar = { '+', '.', '/', ' ' };

            MyString = str.TrimEnd(MyChar);
            string MyString1;
            MyString1 = MyString.TrimStart(MyChar);
            string error = "Error";

            if (Trimed != null)
            {
                Trimed(MyString1);
            }
            else
            {
                if (Trimed != null)
                {
                    Trimed(error);
                }
            }


        }


    }
}
