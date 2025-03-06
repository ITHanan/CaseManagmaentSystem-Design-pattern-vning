

namespace CaseManagmaentSystem.classes.Observer
{
    public class NotificationService
    {
        private List<IObserver> observers = new List<IObserver>();
        private string message;

        public void AddNewObserverToTheList(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserverobserverFromTheList(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string message)
        {
            //Go Through All Observers And Send a Messamge To Them
            foreach (var observer in observers)
            {
                observer.Update(message);

            }

        }

        public void SetMeaasge(string newMessage)
        {
            message = newMessage;
            Console.WriteLine($" You have reciave a new message{ message}");
            Notify(newMessage);
        }
    }
}