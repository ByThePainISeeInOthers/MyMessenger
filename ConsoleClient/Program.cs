using System;
using Newtonsoft.Json;

namespace MyMessenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("define", "Privet", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
            //{ "UserName":"define","MessageText":"Privet","TimeStamp":"2022-11-22T17:32:56.4338551Z"}
            //define < 22.11.2022 17:32:56 >: Privet
        }
    }
}
