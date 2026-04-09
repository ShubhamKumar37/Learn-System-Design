using System;
using System.Collections.Generic;
using System.Text;

namespace ObservePattern
{
    public class Channel : ISubject
    {
        public List<IObserver> Observers;
        public int Subscribers { get; set; } = 0;
        public List<string> NewVideo = new();

        public Channel()
        {
            Observers = new();
        }
        public void AddObserver(IObserver obs)
        {
            if(Observers.Find((i) => i == obs) == null) Observers.Add(obs);
            else Console.WriteLine("You already subscribed to channel");
        }

        public void RemoveObserver(IObserver obs)
        {
            Observers.Remove(obs);
        }

        public void NotifyObserver()
        {
            for (int i = 0; i < Observers.Count; i++) Observers[i].Update(NewVideo.Last());
        }

        public void AddNewVideo(string name)
        {
            NewVideo.Add(name);
            NotifyObserver();
        }
    }
}
