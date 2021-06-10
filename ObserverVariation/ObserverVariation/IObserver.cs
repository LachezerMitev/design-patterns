using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverVariation
{
	public interface IObserver
	{
		void NotifyObserver();
		void SetTopic(IObservable topic);
	}
}
