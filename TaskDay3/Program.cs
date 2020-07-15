using System;
using System.Collections.Generic;
namespace TaskDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            //To Get all User information
            UserRepository repository = new UserRepository();
            List<User> userlist = repository.Users();
            Console.WriteLine("UserDetails\n");
            Console.WriteLine("ID\t UserName\t UserEmail\t UserLocation\t UserAddress\t isActive");
            foreach (User user in userlist)
            { 
                Console.WriteLine(user.Id + "\t" + user.Name + "\t" + user.Email + "\t" + user.Location + "\t" + user.Address + "\t\t" + user.IsActive);
            }

            //To find particular user based on id
            Console.WriteLine("\nEnter the id to find information");
            int id=int.Parse(Console.ReadLine());
            User findUser = repository.GetUser(id);
            
            if(findUser!=null)
            {
                Console.WriteLine("ID\t UserName\t UserEmail\t UserLocation\t UserAddress\t isActive");
                Console.WriteLine(findUser.Id + "\t" + findUser.Name + "\t" + findUser.Email + "\t" + findUser.Location + "\t" + findUser.Address + "\t" + findUser.IsActive);
            }
            else
            {
                Console.WriteLine("\nNo User found at specified id: " + id);
            }
            
            
            //To delete user based on id
            Console.WriteLine("\n Enter the id to delete the user");
            int deleteId = int.Parse(Console.ReadLine());
            List<User> userList1 = repository.DeleteUser(deleteId);
            Console.WriteLine("\nUser list information");
            Console.WriteLine("ID\t UserName\t UserEmail\t UserLocation\t UserAddress\t isActive");
            foreach (User user in userList1)
            {

                Console.WriteLine(user.Id + "\t" + user.Name + "\t" + user.Email + "\t" + user.Location + "\t" + user.Address + "\t" + user.IsActive);
            }
            
            //Active users
            Console.WriteLine("\nActive Users are:");
            List<User> activeUserList = repository.ActiveUsers();
            Console.WriteLine("ID\t UserName\t UserEmail\t UserLocation\t UserAddress\t isActive");
            foreach (User user in activeUserList)
            {
                Console.WriteLine(user.Id + "\t" + user.Name + "\t" + user.Email + "\t" + user.Location + "\t" + user.Address + "\t" +user.IsActive);
            }
            
            //Add user to list
            Console.WriteLine("\nEnter the user Details");
            Console.WriteLine("Enter the name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Location");
            string location = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the User active status");
            Console.WriteLine("0 - inactive \t 1 - active");
            int activeStatus = int.Parse(Console.ReadLine());
            repository.AddUser(new User(){

                Id = repository.userId,
                Name = userName,
                Email = email,
                Location = location,
                Address = address,
                IsActive = activeStatus
            });
            
            //Display list after adding user
            List<User> newList = repository.Users();
            Console.WriteLine("ID\t UserName\t UserEmail\t UserLocation\t UserAddress\t isActive");
            foreach (User user in newList)
            {
                Console.WriteLine(user.Id + "\t" + user.Name + "\t" + user.Email + "\t" + user.Location + "\t" + user.Address + "\t" + user.IsActive);
            }
        }
    }
}
