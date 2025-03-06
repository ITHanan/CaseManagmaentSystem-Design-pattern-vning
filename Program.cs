using CaseManagmaentSystem.classes;
using CaseManagmaentSystem.classes.Factory_Method;
using CaseManagmaentSystem.classes.Observer;
using CaseManagmaentSystem.classes.Singleton;

namespace CaseManagmaentSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Singeltom 
            LogManager.Instance.log("Application Started ");

            // Factory Method 

            User user1 = UserFactory.CreatUser("Admin");
            user1.GetRole();

            User user2 = UserFactory.CreatUser("Regular User");
            user2.GetRole();

            User user3 = UserFactory.CreatUser("Handleader");
            user3.GetRole();

            // Observer 

            NotificationService service = new NotificationService();
            UserNotifier userA = new UserNotifier("Hanan");
            UserNotifier userB = new UserNotifier("Mira");

            service.AddNewObserverToTheList(userA);
            service.AddNewObserverToTheList(userB);

            service.Notify("New case has  been assigned!");

            LogManager.Instance.log("Application Finished");


        }
    }
}
