using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameF
{
    //New user classını bir manager olarak kullandım dolayısıyla tek bir user class ı için iki ayrı operasyon sınıfı kullanmış oldum 
    //buradaki amaç yalnızca yeni kullanıcılar için kimlik doğrulama ve var olan kullanıcılara özel remove metodunu kullanabilmekti
    public class NewUser : IUserManager
    {
        IValService valService;

        public NewUser(IValService valService)
        {
            this.valService = valService;
        }
        //constructor validate i çağırabilmemizi sağladı Add metodunda da validate sağlandıysa kayıt yap komutu verdik
        public void Add(User NewUser)
        {
            if (valService.Validate(NewUser) == true)
            {
                Console.WriteLine("kayıt basarılı kimlik doğrulandı");
            }
            else
            {
                Console.WriteLine("kayıt basarısız kimlik doğrulanamadı");
            }
        }

        public void Remove(User ExistingUser)
        {
            throw new NotImplementedException();
        }

        public void Update(User ExistingUser)
        {
            throw new NotImplementedException();
        }
        //yeni kaydolan oyuncuya bonus veren yapıyı 
        //simule etmek istedim ama programda çalışmadı.
        public void Welcome(User user)
        {
            Console.WriteLine("500 gameF points gifted");
        }
    }
}
