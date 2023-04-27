using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameF
{
    public class ValidationManager : IValService
    {
    
        //burada kimlik doğrulama simulasyonu yaptık
        public bool Validate(User NewUser)
        {
            if(NewUser.Name=="Akbey Aslan"&&NewUser.Id==1234561996 && NewUser.Mailaddress == "aslanakbey43@windowslive") 
            {
                return true;
            }
            else 
            {
                return false;   
            }
        }
    }
}
