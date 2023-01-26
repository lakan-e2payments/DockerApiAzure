using DockerApiAzure.Controllers;

namespace DockerApiAzure.Test
{
    public class UnitTest
    {
        private WeatherForecastController _controller;
        public UnitTest()
        {
            _controller = new WeatherForecastController();
        }
        [Fact]
        public void Get_HasData()
        {
            var data = _controller.Get();
            Assert.True(data.Any());
        }
    }
}