using System;
using System.Collections.Generic;
using System.Text;

namespace ObservePattern
{
    public class Subscriber : IObserver
    {
        public List<string> WatchHistory = new();
        public List<ISubject> ChannelsSubscribed = new();

        public void Subscribe(ISubject sub)
        {
            ChannelsSubscribed.Add(sub);
            sub.AddObserver(this);
            Console.WriteLine("You subscribed to channel");
        }
        public void UnSubscribe(ISubject sub)
        {
            ChannelsSubscribed.Remove(sub);
            sub.RemoveObserver(this);
            Console.WriteLine("You unsubscribe the channel");
        }

        public void Update(string newVideo)
        {
            WatchHistory.Add(newVideo);
        }


        public void Display()
        {
            for (int i = 0; i < WatchHistory.Count; i++)
            {
                Console.WriteLine("Title = {0}", WatchHistory[i]);
            }
        }
    }

}
