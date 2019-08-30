using System;

namespace lab_87_serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    [Serializable]
    class SendMeAcrossTheInternet
    {
        [NonSerialized]
        private object DontSendMe;

        public string SendMe { get; set; }

    }
}
