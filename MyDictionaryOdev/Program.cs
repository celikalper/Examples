using System;
using System.Collections.Generic;

namespace MyDictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            
             MyDictionary<int, string> AdYas = new MyDictionary<int, string>();

             AdYas.Add(32,"Alper");
             AdYas.Add(5, "Rana");
             AdYas.Add(2, "Elif");

             for (int i = 0; i < AdYas.value.Length; i++)
             {
                 Console.WriteLine(AdYas.value[i] + " yaşı : " + AdYas.key[i]);
             }
            
        }
    }
}
