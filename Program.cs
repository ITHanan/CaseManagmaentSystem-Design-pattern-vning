using CaseManagmaentSystem.algoritmer_1;
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


            UserAuthentication auth = new UserAuthentication();
            auth.RegisterUser("Admin", "secure123");

            Console.WriteLine(auth.Authenticate("admin", "secure123") ? "Login successful!" : "Login failed.");

            Console.WriteLine();


            int[] caseIds = { 1001, 1005, 1010, 1020, 1030 }; // Sorterad lista
            int targetId = 1010;

            CaseSearch search = new CaseSearch();   


            int result = search.BinarySearch(caseIds, targetId);
            Console.WriteLine(result != -1 ? $"Case found at index {result}" : "Case not found");

            Console.WriteLine();

            CaseManager caseManager = new CaseManager();

            caseManager.AddCase("Case1", 2);
            caseManager.AddCase("Case2", 5);
            caseManager.AddCase("Case3", 1);

            caseManager.ProcessNextCase(); // Behandlar Case2 (högst prioritet)
            caseManager.ProcessNextCase(); // Behandlar Case1

            Console.WriteLine();


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
