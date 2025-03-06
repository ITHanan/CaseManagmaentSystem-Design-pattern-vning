
namespace CaseManagmaentSystem.classes.Observer
{

    // Observer Pattern - for Notification system its used when diffirant objects will have an uppdating when something happens 
    public interface IObserver
    {
        void Update(string message);
        
    }
}
