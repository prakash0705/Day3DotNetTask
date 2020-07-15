using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TaskDay3
{
    public class UserRepository : User,IUserRepository
    {
        public int userId = 1;
        private List<User> list = new List<User>();

        public UserRepository()
        {
            for (int i = 1; i <= 10; i++)
            {
                if(i%2!=0)
                {
                    list.Add(new User()
                    {
                        Id = userId,
                        Name = "Prakash" + i,
                        Email = "prakash" + i + "@gmail.com",
                        Location = "location" + i,
                        Address = "street" + i,
                        IsActive = 1
                    });
                    userId++;
                }
                else
                {
                    list.Add(new User()
                    {
                        Id = userId,
                        Name = "Prakash" + i,
                        Email = "prakash" + i + "@gmail.com",
                        Location = "location" + i,
                        Address = "street" + i,
                        IsActive = 0
                    });
                    userId++;
                }
            }
        }



       public List<User> Users()
        {
            return list;
        }
        public User GetUser(int id)
        {
            var user = list.Where(a => a.Id == id).FirstOrDefault();
            return user;
        }
        public List<User> DeleteUser(int id)
        {
            var removeitem = list.Where(a => a.Id == id).FirstOrDefault();
            if(removeitem==null)
            {
                Console.WriteLine("No User found at id: "+id);
            }
            else
            {
                list.Remove(removeitem);
            }
            return list;            
        }
        public List<User> ActiveUsers()
        {
            List<User> ActiveUserList = new List<User>();
            foreach(var user in list)
            {
                if(user.IsActive==1)
                {
                    ActiveUserList.Add(user);
                }
            }
            return ActiveUserList;
        }
        public List<User> AddUser(User user)
        {
            list.Add(user);
            return list;
        }
    }
}
