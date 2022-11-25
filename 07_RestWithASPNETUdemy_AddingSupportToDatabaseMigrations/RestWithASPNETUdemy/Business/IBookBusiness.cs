using RestWithASPNETUdemy.Model;
using System.Collections.Generic;


namespace RestWithASPNETUdemy.Business
{
    public interface IBookBusiness
    {
       Book Create( Book book);

       Book FindByID(long id);

       List <Book> Findall();

      Book Update(Book book);

        void Delete(long id);
    }
}