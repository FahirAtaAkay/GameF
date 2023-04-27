using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameF
{
    public class ExistingUser : IUserManager
    {
        //yrni kullanıcıdan farklı olarak bu classta newlenen herhangi bir nesne için Add metodu çalışmasın istedim çünkğ adı üstünde bu zaten var olan br kullanıcı
        public void Add(User NewUser)
        {
            throw new NotImplementedException();
        }

        public void Remove(User ExistingUser)
        {
            throw new NotImplementedException();
        }

        public void Update(User ExistingUser)
        {
            throw new NotImplementedException();
        }
        //belli bir süre oyunu oynayan kullanıcıya bonus verme 
        //islemini simule etmek istedim fakat çalışmadı
        public void Time(User user)
        {
            Console.WriteLine("gongrats 30 hours of playtime reached 850 gameF points gifted");
        }
    }
}
