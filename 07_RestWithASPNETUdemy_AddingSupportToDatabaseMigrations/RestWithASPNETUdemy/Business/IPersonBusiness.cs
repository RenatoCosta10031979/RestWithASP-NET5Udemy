using RestWithASPNETUdemy.Model;
using System.Collections.Generic;


 


namespace RestWithASPNETUdemy.Business
{
    public interface IPersonBusiness
    {
       Person Create( Person person);

       Person FindByID(long id);

       List <Person> Findall();

       Person Update(Person person);

        void Delete(long id);
    }
}