using IAmGroot;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

public class GuardianTests
{
    private HttpClient Client;
    private TestServer Server;

    public GuardianTests()
    {
        //arrange
        Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        Client = Server.CreateClient();
    }

    [Fact]
    public async Task IndexShouldReturnOkStatus()
    {
        //act
        var response = await Client.GetAsync("/api");

        //assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task GrootWithQueryStringShouldReturnOkStatus()
    {
        //act
        var queryStringResponse = await Client.GetAsync("/groot?message=somemessage");

        //assert
        Assert.Equal(HttpStatusCode.OK, queryStringResponse.StatusCode);
    }

    [Fact]
    public async Task WithoutGivingAParameterTheStatusIsNotOk()
    {
        //act
        var response = await Client.GetAsync("/groot");

        //assert
        Assert.NotEqual(HttpStatusCode.NotFound, response.StatusCode);
    }
}
