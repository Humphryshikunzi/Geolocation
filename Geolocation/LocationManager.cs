using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace Geolocation
{
  public  class LocationManager
    {
        public async static Task<Geoposition> GetGeoPosition()
        {
            var accessstatus =await Geolocator.RequestAccessAsync();
            if(accessstatus!=GeolocationAccessStatus.Allowed) throw new Exception();

            var geolocator=new Geolocator{DesiredAccuracyInMeters = 0};
            var postion = await geolocator.GetGeopositionAsync();
            return postion;
            
        }
    }
}
