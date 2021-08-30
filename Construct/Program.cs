using System;

namespace Constructor
{

}
class Program
{

    static void Main(string[] args)
    {
        User tom = new User("admin1", 12345);

        tom.description();


        Console.ReadKey();
    }


}


public class User
{
    public string role;
    public string login;
    public int password;



    public User(string l, int p) { role = "Unknown"; login = l; password = p; }

    public void description()
    {
        Console.WriteLine($"Role: { role} \nLogin: { login} \nPassword: {password}");
    }


}

