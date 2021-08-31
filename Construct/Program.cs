using System;

namespace Constructor
{

}
class Program
{

    static void Main(string[] args)
    {
        User tom = new User( null, "admin1", 12345);
        tom.description();

        User jack = new User("", "admin", 123);
        jack.description();

        Console.ReadKey();
    }


}


public class User
{
    public string role;
    public string login;
    public int password;



    public User(string r, string l, int p)
    {
        role = r; login = l; password = p;

        _= (role == null) || (role == String.Empty) ? role = "Unknown" : role = r;

    }
    




    public void description()
    {                     
                 
        {

            Console.WriteLine($"Role: { role} \nLogin: { login} \nPassword: {password}");
        }


    }

}
