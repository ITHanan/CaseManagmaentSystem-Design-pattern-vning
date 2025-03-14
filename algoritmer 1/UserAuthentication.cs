

namespace CaseManagmaentSystem.algoritmer_1
{
    public class UserAuthentication
    {
        private Dictionary<string, string> userDatabase = new Dictionary<string, string>();

        public void RegisterUser(string username, string password)
        {
            string hashedPassword = HashPassword(password);
            userDatabase[username] = hashedPassword;
            Console.WriteLine($"User {username} registered successfully.");
        }

        public bool Authenticate(string username, string password)
        {
            if (userDatabase.TryGetValue(username, out string storedHash))
            {
                return storedHash == HashPassword(password);
            }
            return false;
        }

        private string HashPassword(string password)
        {
            return password.GetHashCode().ToString(); // Simpel hashing (för demonstration)
        }
    }
}
