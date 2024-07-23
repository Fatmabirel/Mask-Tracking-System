using Business.Abstract;
using Entitites.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    public class PersonManager : IApplicantService
    {
        //Encapsulation
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            var response = client.TCKimlikNoDogrulaAsync(
                person.NationalIdentity,
                person.FirstName,
                person.LastName,
                person.DateOfBirthYear
            ).Result;

            return response.Body.TCKimlikNoDogrulaResult;
        }



        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
