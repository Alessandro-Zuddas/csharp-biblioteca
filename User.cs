﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class User
    {
        string surname;
        string name;
        string email;
        string password;
        int telephone;

        public User(string surname, string name, string email, string password, int telephone)
        {
            this.surname = surname;
            this.name = name;
            this.email = email;
            this.password = password;
            this.telephone = telephone;
        }       
    }
}