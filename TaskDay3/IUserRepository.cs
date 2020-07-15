﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskDay3
{
    public interface IUserRepository
    {
            public List<User> Users();
            public User GetUser(int id);
            public List<User> DeleteUser(int id);
            public List<User> ActiveUsers();
            public List<User> AddUser(User user);
    }
    
}
