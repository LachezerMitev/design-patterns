using System;

namespace ObserverVariation
{
    class Program
    {
        static void Main(string[] args)
        {
			Sensor sensor = new Sensor();

			IObserver sl1 = new SensorListener("listener1");
			IObserver sl2 = new SensorListener("listener2");
			IObserver sl3 = new SensorListener("listener3");

			sensor.Subscribe(sl1);
			sensor.Subscribe(sl2);
			sensor.Subscribe(sl3);

			sensor.SetTopic("TEST");
			sensor.SetTopic("TEST1");

			sensor.Unsubscribe(sl3);

			sensor.SetTopic("TEST3");
		}
    }
}
