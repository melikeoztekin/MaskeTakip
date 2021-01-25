using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //interfaceler belli method imzalarını barındrırlar birbirinin alternatifi olan sistemlerin farklı implementasyon yapmalarını sağlarlar.
    public interface IApplicantService
    {
        void ApplyForMask(Person person);


        List<Person> GetList();


        bool CheckPerson(Person person);
        
    }
}
