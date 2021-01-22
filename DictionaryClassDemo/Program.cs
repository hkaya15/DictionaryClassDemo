using System;

namespace DictionaryClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, dynamic> users = new MyDictionary<string, dynamic>();
            users.Add("Ad", "Hüseyin");
            users.Add("Id", 123);

            foreach (var item in users.Keys)
            {
                Console.WriteLine("Key: "+item);
            }
            foreach (var item in users.Values)
            {
                Console.WriteLine("Value: "+item);
            }

            users.Dict();
        }
    }
}
