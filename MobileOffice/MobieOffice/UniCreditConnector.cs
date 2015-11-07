using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace MobieOffice
{
    public class UniCreditConnector : IBankConnector
    {



        public UniCreditConnector()
        {

        }

        public async Task GetBranches()
        {

            Geolocator geolocator1 = new Geolocator { DesiredAccuracyInMeters = 250 };
            Geoposition pos = await geolocator1.GetGeopositionAsync();

            Debug.Write(pos);

        }
    }
}
