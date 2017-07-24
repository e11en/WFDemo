using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NestedServices
{
    public class StringLibrary
    {
        public static String ReverseString(string StringToReverse)
        {
            char[] charArray = StringToReverse.ToCharArray();
            Array.Reverse(charArray);
            return new String(charArray);
        }

        public static String UpperCaseString(string StringToUpperCase)
        {
            return StringToUpperCase.ToUpper();
        }
    }
}