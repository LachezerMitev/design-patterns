using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverVariation
{
    public class SensorListener : IObserver
    {
        private string _name;
        private IObservable _subscribedTo;

        public SensorListener(string name)
        {
            
        }
        public void NotifyObserver()
        {
            if (_subscribedTo == null)
            {
                Console.WriteLine($"{_name} has no sensors set");
                return;
            }

            string newData = _subscribedTo.GetUpdate();
            Console.WriteLine($"{_name} recieved an update: {newData}");
        }

        public void SetTopic(IObservable topic)
        {
            _subscribedTo = topic;
        }
    }
}
