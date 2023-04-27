using System;
using System.Net.Http.Headers;

namespace GameF
{
    class Program
    {
        static void Main(string[] args)
        {
            NewUser newUser = new NewUser(new ValidationManager());
            newUser.Add(new User { Name="Akbey Aslan",Mailaddress="aslanakbey43@windowslive",Id=1234561996});
            ExistingUser existingUser = new ExistingUser();
            existingUser.Remove(new User { Name = "fatih", LastName = "terim", Mailaddress = "imparatorterim@galatasaraySK" });
            
         

        }
    }
    

   
    

}
