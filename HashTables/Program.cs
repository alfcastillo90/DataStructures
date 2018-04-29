using System;
using System.Collections;
namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hashtable openWith = new Hashtable();
            openWith.Add("txt","nodepad.exe");
            openWith.Add(".cs","Visual Studio");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");
            try{
                openWith.Add("txt","nodepad.exe");
                 Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);
                openWith["rtf"] = "winword.exe";
                 Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);
                if(!openWith.ContainsKey("ht")){
                    openWith.Add("ht","htProgram.exe");
                    Console.WriteLine("Value added for key = \"ht\": {0}", openWith["ht"]);
                }
               Console.WriteLine();
                foreach( DictionaryEntry de in openWith )
                {
                    Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
                }
            }
            catch{
                Console.WriteLine("An element with Key = txt already exists");
            }
        }
    }
}
