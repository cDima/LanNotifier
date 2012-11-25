# Lan Notificator
## Notifier of newly connected and disconnected devices 

Notifies of new MACs connecting and disconnecting onto the same LAN network as machine's subnet domain.

Eample code:

        var networkWatcher = new MacWatcher();
        networkWatcher.MacConnected += new EventHandler<KeyValuePair<string,string>>(networkWatcher_MacConnected);
        networkWatcher.MacDisconnected += new EventHandler<KeyValuePair<string, string>>(networkWatcher_MacDisconnected);
        networkWatcher.WatchNetwork();

## Under the covers


Example, my machine has IP 10.0.1.5. The iPhone connects to the same LAN and router assignes DHCP dynamically.
The IP Range  10.0.1.1-127 will be pinged and arp -a command will be launched every second to see changes.

![lan notifier](https://raw.github.com/cDima/WifiNotificator/master/screenshot-lan-notifier.png)
