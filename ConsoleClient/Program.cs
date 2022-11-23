using System;
using Newtonsoft.Json;

namespace MyMessenger
{
    class Program
    {
        public static int MessageID;
        private static string Username;
        private static MessengerClientAPI API = new MessengerClientAPI();
        private static void GetNewMessages()
        {
            Message msg = API.GetMessage(MessageID);
            while (msg != null)
            {
                Console.WriteLine(msg);
                MessageID++;
                msg = API.GetMessage(MessageID);
            }
        }
        static void Main(string[] args)
        {
            //Message msg = new Message("define", "Privet", DateTime.UtcNow);
            //string output = JsonConvert.SerializeObject(msg);
            //Console.WriteLine(output);
            //Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            //Console.WriteLine(deserializedMsg);
            //{ "UserName":"define","MessageText":"Privet","TimeStamp":"2022-11-22T17:32:56.4338551Z"}
            //define < 22.11.2022 17:32:56 >: Privet

            MessageID = 1;
            Console.WriteLine("Введите Ваше имя:");
            Username = Console.ReadLine();
            string MessageText = "";
            while (MessageText != "exit")
            {
                MessageText = Console.ReadLine();
                
                if (MessageText.Length > 0)
                {
                    Message SendMSG = new Message(Username, MessageText, DateTime.Now);
                    API.SendMessage(SendMSG);
                }
                GetNewMessages();
            }
        }
    }
}
