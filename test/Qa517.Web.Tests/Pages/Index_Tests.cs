using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Qa517.Pages
{
    public class Index_Tests : Qa517WebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
