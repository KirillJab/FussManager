using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuetaManager.Classes
{
    class UserManager
    {
        public List<User> Users { get;  set; }
        internal User CurrentUser { get => Users[CurUserIndex]; }
        public bool RememberMe { get; set; }
        public int CurUserIndex { get; set; }

        public delegate void UserChangedHandler();
        public static event UserChangedHandler OnUserChanged;
        public UserManager()
        {

        }

        public bool UserExists(string name)
        {
            foreach (var user in Users)
            {
                if(user.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        public User FindUser(string name)
        {
            foreach (var user in Users)
            {
                if (user.Name == name)
                {
                    return user;
                }
            }
            throw new NullReferenceException();
        }
        private int UserIndex(string name)
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Name == name)
                {
                    return i;
                }
            }
            return -1;
        }
        public void SetCurrentUser(string name)
        {
            if(UserExists(name))
            {
                CurUserIndex = UserIndex(name);
                OnUserChanged();
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public void AddUser(string name, string password, bool isPremium, string emailAddress)
        {
            User newUser;
            if (isPremium)
            {
                newUser = new PremiumUser(name, password, emailAddress);
            }
            else
            {
                newUser = new NonPremiumUser(name, password, emailAddress);
            }

            newUser.AddNewSchedule("Default Schedule");
            Users.Add(newUser);
            SetCurrentUser(name);
        }
        public void AddDefault()
        {
            if(Users == null)
            {
                Users = new List<User>();
            }
            User user = new PremiumUser("Kirill", "12345", "blackshark564@gmail.com");
            user.AddNewSchedule("Default Schedule");
            Users.Add(user);
            RememberMe = true;
        }
    }
}