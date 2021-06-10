using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverVariation
{
	public interface IObservable
	{
		void Subscribe(IObserver obs);
		void Unsubscribe(IObserver obs);

		void NotifyObservers();

		string GetUpdate();
	}
}
