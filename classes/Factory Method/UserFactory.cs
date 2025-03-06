

using CaseManagmaentSystem.classes.NewFolder;

namespace CaseManagmaentSystem.classes.Factory_Method
{
    public class UserFactory
    {
        public static User CreatUser(string type) 
        {
            return type switch 
            {
              "Admin"=> new Admin(),
              "Handleader" => new Handleader(),
              
                _ => new RegularUser(),
            };
        
        }
    }
}
