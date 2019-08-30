using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleService.Models
{
    public interface IPeopleProvider
    {
        List<Person> GetPeople();
    }
}
