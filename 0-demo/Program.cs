using System;

namespace _0_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = new String("abc");
            string s2 = "abc";
            Foo<string,string>(s2);



        }

        static U Foo<T,U>(T s)
        {
            s+="s";
            return ;
        }

    }
}
