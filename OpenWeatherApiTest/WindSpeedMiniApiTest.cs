using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherApiTest
{
    public class WindSpeedMiniApiTest : BaseTest
    {
        [Test]
        public async Task WindSpeedTest()
        {
            HttpResponseMessage response = await Client.GetAsync(baseUrl + windSpeedUrl);

            ClassicAssert.IsTrue(response.IsSuccessStatusCode);
        }
    }
}
