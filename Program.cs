using System;
using System.Collections.Generic;
using System.Linq;
using Linq;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository obj = new UserRepository();
            List<User> user = new List<User>();

            Console.WriteLine("Listing the Users without su");
            user = obj.Users();
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (User users in user)
            {
                Console.WriteLine(users.Id + "\t" + users.Name + "\t" + users.Email + "\t" + users.Location + "\t" + users.Address + "\t  " + users.IsActive);
            }
            Console.WriteLine();



        // Get user details by id by calling function
            Console.WriteLine("Enter the User Id");

            int User1 = Convert.ToInt32(Console.ReadLine());

            User getUser = new User();

            getUser = obj.GetUser(User1);

            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");

            Console.WriteLine(getUser.Id + "\t" + getUser.Name + "\t" + getUser.Email + "\t" + getUser.Location + "\t" + getUser.Address + "\t  " + getUser.IsActive);

            // Deleting the id entered by  users from List
            Console.WriteLine("Enter the id for User you want to Delete");
            int User2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Deleting Users without LinQ");

            List<User> listafterDeletion = new List<User>();
            listafterDeletion = obj.DeleteUser(User2);
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (User users in listafterDeletion)
            {
                Console.WriteLine(users.Id + "\t" + users.Name + "\t" + users.Email + "\t" + users.Location + "\t" + users.Address + "\t  " + users.IsActive);
            }


            // Function to get the list of Active Users
            List<User> activeUser = new List<User>();

            activeUser = obj.ActiveUsers();
            Console.WriteLine();


            Console.WriteLine("List of Active Users without using LINQ");
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (User users in activeUser)
            {
                Console.WriteLine(users.Id + "\t" + users.Name + "\t" + users.Email + "\t" + users.Location + "\t" + users.Address + "\t  " + users.IsActive);
            }

            // Manual addition of a new user

            User obj2 = new User();
            obj2.Id = 2;
            obj2.Name = "Name2";
            obj2.Email = "name2@gmail.com";
            obj2.Location = "Location2";
            obj2.Address = "Address2";
            obj2.IsActive = true;
            Console.WriteLine("After addition of new user in List");
            obj.AddUser(obj2);
            user = obj.Users();
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (User users in user)
            {
                Console.WriteLine(users.Id + "\t" + users.Name + "\t" + users.Email + "\t" + users.Location + "\t" + users.Address + "\t  " + users.IsActive);
            }
           
            // Using Linq
            var getUserDetails = from users in user select users;
            foreach (User users in getUserDetails)
                Console.WriteLine("Id:\t" + users.Id + "Name:\t" + users.Name + "Email:\t" + users.Email + "Location:\t" + users.Location + "Address:\t" + users.Address + "Active Status:\t" + users.IsActive);

            //Gettin USer data With Linq
            Console.WriteLine("Enter User Id to get details");
            int User3 = Convert.ToInt32(Console.ReadLine());
            var getIdUser = user.Where(users => users.Id == User3);
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (User users in getIdUser)
                Console.WriteLine("Id:\t" + users.Id + "Name:\t" + users.Name + "Email:\t" + users.Email + "Location:\t" + users.Location + "Address:\t" + users.Address + "Active Status:\t" + users.IsActive);


            // Delete with Linq
            Console.WriteLine("Enter the id for User you want to Delete");

            int delUser = Convert.ToInt32(Console.ReadLine());

            user.RemoveAll(x => x.Id == delUser);

            Console.WriteLine("List of Users after Deleting User with ID =" + delUser + " using LINQ");
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (User users in user)
                Console.WriteLine("Id:\t" + users.Id + "Name:\t" + users.Name + "Email:\t" + users.Email + "Location:\t" + users.Location + "Address:\t" + users.Address + "Active Status:\t" + users.IsActive);

            // ACTIVE USER LIST
            var ActiveUsersLinq = user.Where(users => users.IsActive == true);
            Console.WriteLine();
            Console.WriteLine("List of Active Users using LINQ");

            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");

            foreach (User users in ActiveUsersLinq)
                Console.WriteLine("Id:\t" + users.Id + "Name:\t" + users.Name + "Email:\t" + users.Email + "Location:\t" + users.Location + "Address:\t" + users.Address + "Active Status:\t" + users.IsActive);

            User newObject = new User();
            // Enter User Details
            Console.WriteLine("Enter Users Details");

            Console.WriteLine("Enter User Id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter User Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter User Email");
            string email = Console.ReadLine() + "\t";

            Console.WriteLine("Enter User Location");
            string location = Console.ReadLine() + "\t";

            Console.WriteLine("Enter User Address");
            string address = Console.ReadLine() + "\t";

            Console.WriteLine("Enter User Activity Status");
            bool activity = Convert.ToBoolean(Console.ReadLine());

            user.Add(new User() { Id = id, Name = name, Email = email, Location = location, Address = address, IsActive = activity });

            Console.WriteLine("After addition of new user in List");

            Console.WriteLine("Id:\t" + users.Id + "Name:\t" + users.Name + "Email:\t" + users.Email + "Location:\t" + users.Location + "Address:\t" + users.Address + "Active Status:\t" + users.IsActive);



        }

    }
}