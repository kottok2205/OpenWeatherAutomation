using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherApiTest
{
    public class PricingMiniApiTest : BaseTest
    {
        [Test]
        public async Task PricingTest()
        {
            HttpResponseMessage response = await Client.GetAsync(pricingUrl);

            ClassicAssert.IsTrue(response.IsSuccessStatusCode);
        }
    }
}
