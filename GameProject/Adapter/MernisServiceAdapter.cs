using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference1;

namespace GameProject.Adapter
{
    class MernisServiceAdapter : IUserValidationService
    {
     

        bool IUserValidationService.Validate(User gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.IdentityNumber), gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(), gamer.BirthYear.Year).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
