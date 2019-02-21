using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.IdentityModel.Tokens;

namespace AuthenticationService
{
    [ServiceContract]
    public interface IAuthentication
    {
        [OperationContract]
        //В клиенте необходимо добавлять все ссылки на сборки пространствоимен которых используется, иначе котракт службы не импортируется, вместо него будет создан клас исключения в существующем простарнве имен. Можно поробавать указать полное имя исключения в контракте службы.
        [FaultContract(typeof(SecurityTokenException))]
        User Authenticate(string userName, string password);
    }
}
