

namespace CaseManagmaentSystem.classes.Observer
{
    public  interface ISubject
    {
        void AddNewObserverToTheList(IObserver observer);
        void RemoveObserverobserverFromTheList(IObserver observer);

        void Notify(string message);
    }
}
