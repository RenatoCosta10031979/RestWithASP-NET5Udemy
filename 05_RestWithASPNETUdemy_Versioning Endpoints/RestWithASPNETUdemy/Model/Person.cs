using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model
{
    [Table ("person")]
    public class Person
    {
        // internal string First_name;

        [Column("id")] 
        public long Id {get; set;}

        [Column("address")]
        public string Address {get; set;}

        [Column("first_name")]
        public string FirstName { get; set; } 

        [Column("gender")]
        public string Gender { get; set; } 

        [Column("last_name")]
        public string LastName {get; set;}
       // public string LastName { get; internal set; }
    }
}