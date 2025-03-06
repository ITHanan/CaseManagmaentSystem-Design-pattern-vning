

namespace CaseManagmaentSystem.classes.Observer
{
    public class UserNotifier : IObserver
    {
        private string _name;
        public UserNotifier(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {

            Console.WriteLine($"{_name} receivse notification {message}");

        }
    }
}
