using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverVariation
{
    public class Sensor : IObservable
    {
        private List<IObserver> _sensorListeners;

        private string _data;

        public Sensor()
        {
            _sensorListeners = new List<IObserver>();
        }
        public string GetUpdate()
        {
            return _data;
        }

        public void NotifyObservers()
        {
            foreach (var sensor in _sensorListeners)
                sensor.NotifyObserver();
        }

        public void Subscribe(IObserver obs)
        {
            _sensorListeners.Add(obs);
            obs.SetTopic(this);
        }

        public void Unsubscribe(IObserver obs)
        {
            _sensorListeners.Remove(obs);
            obs.SetTopic(null);
        }
        public void SetTopic(string topic)
        {
            _data = topic;
            NotifyObservers();
        }
    }
}
