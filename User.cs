using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public string getSurname()
    {
        return this.surname;
    }

    public string getName()
    {
        return this.name;
    }

    public string getEmail()
    {
        return this.email;
    }

    public string getPassword()
    {
        return this.password;
    }
    public int getTelephone()
    {
        return this.telephone;
    }
}