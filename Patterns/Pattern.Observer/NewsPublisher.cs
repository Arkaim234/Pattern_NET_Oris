using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Observer
{
    public class NewsPublisher : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _latestNews;

        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);

        public void Notify()
        {
            foreach (var observer in _observers)
                observer.Update(_latestNews);
        }

        public void PublishNews(string news)
        {
            _latestNews = news;
            Notify();
        }
    }
}
