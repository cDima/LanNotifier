namespace NetworkMacExample
{
    using System;
    using System.Collections.Generic;
    using LanNotifier;

    class Program
    {
        static void Main(string[] args)
        {
            var networkWatcher = new MacWatcher();
            networkWatcher.MacConnected += new EventHandler<KeyValuePair<string,string>>(networkWatcher_MacConnected);
            networkWatcher.MacDisconnected += new EventHandler<KeyValuePair<string, string>>(networkWatcher_MacDisconnected);
            networkWatcher.WatchNetwork();
            Console.ReadKey();
        }

        static void networkWatcher_MacConnected(object sender, KeyValuePair<string, string> mac)
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString() + " mac newly connected: " + mac.Value);
        }

        static void networkWatcher_MacDisconnected(object sender, KeyValuePair<string, string> mac)
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString() + "mac disconnected: " + mac.Value);
        }
    }
}
