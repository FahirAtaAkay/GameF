using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameF
{
    //burada parametre atarken amacım Add metodunun yalnız yeni kullanıcılar için diğer iki metodun var olan kullanıcılar için çalışmasını
    //sağlamaktı ama galiba NewUser ve ExistingUser ı farklı değişkenler olarak algıladı burada kafamda soru işaretleri var
    public interface IUserManager
    {
        void Add(User NewUser);
        void Remove(User ExistingUser);
        void Update(User ExistingUser);

    }
}
