using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    public class PttManager : ISupplierService
    {
        private ICitizenService _citizenService;

        public PttManager(ICitizenService citizenService)
        {
            _citizenService = citizenService;
        }
        public void GiveMask(Person person)
        {
            
            if (_citizenService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
        }
    }
}
