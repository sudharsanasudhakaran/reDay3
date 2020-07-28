using System;
using System.Collections.Generic;
using System.Text;
using Linq;

namespace Day3
{
    class UserRepository : IUserRepository
    {
        public List<User> users = new List<User>();
        public UserRepository()
        {
            Console.WriteLine("Enter USer Data");
            int NumberOfUsers = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= NumberOfUsers; i++)
            {
                bool active = (i % 2 == 0) ? true : false;
                users.Add(new User() { Id = i, Name = "Kunal" + i, Email = "kunal" + i + "@gmail.com", Location = "Vellore" + i, Address = "TamilNadu" + i, IsActive = active });
            }

        }
        public List<User> Users()
        {
            return users;
        }


        public List<User> DeleteUser(int id)
        {
            foreach (User person in users)
            {
                if (person.Id == id)
                {
                    users.Remove(person);
                    break;
                }

            }
            return users;
        }

        public List<User> ActiveUser = new List<User>();
        public List<User> ActiveUsers()
        {
            foreach (User person in users)
            {
                if (person.IsActive)
                {
                    ActiveUser.Add(person);
                }

            }
            return ActiveUser;
        }
        User getuser = new User();
        public User GetUser(int id)
        {
            foreach (User person in users)
            {
                if (person.Id == id)
                {
                    getuser = person;
                }
            }
            return getuser;
        }

        public List<User> AddUser(User user)
        {
            users.Add(user);
            return users;
        }



    }
}