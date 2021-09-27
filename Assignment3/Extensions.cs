using System;
using System.Collections.Generic;

namespace Assignment3
{
    public static class Extensions
    {

        public static void Print<T>(this IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static bool isSecure(this Uri uri){
            return uri.Scheme == Uri.UriSchemeHttps;   
        }

        public static int wordCount(this string s) {
            var num = s.Split(' ').Length;
            return num;
        }
    }
}
