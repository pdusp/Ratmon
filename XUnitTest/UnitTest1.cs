
using Pd.Ratmon;
using Xunit;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public async void Login()
        {
            string username = res.username;
            string password = res.password;
            var token = await Request.PostRequestAuth(username, password);
            Assert.Equal(20, token.Expiration);
        }

        [Fact]
        public async void GetAllCircuts()
        {   
            //tyle obwodów zwraca api ok
            string username = res.username;
            string password = res.password;
            var token = await Request.PostRequestAuth(username, password);
            var allcircut = await Request.GetRequestAllCircuits(token);
            Assert.True(allcircut.Count>=36);
        }


        [Fact]
        public async void GetChanel()
        {
            int id = 12; // testujemy petle nr 12 czy jest nadal rozłączona?
            string username = res.username;
            string password = res.password;
            var token = await Request.PostRequestAuth(username, password);
            var chanel = await Request.GetRequestSelectedChanel(id, token);
            Assert.Equal(">200,00 [MΩ]", chanel.Resistance.R1);
        }

    }
}
