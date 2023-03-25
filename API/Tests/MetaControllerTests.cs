using API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace API.Tests
{
    //unit test for the Get method of the MetaController.
    [TestFixture]
    public class MetaControllerTests
    {
        private MetaController controller;

        [SetUp]
        public void SetUp()
        {
            controller = new MetaController();
        }

        [Test]
        public async Task Get_Returns_Valid_Data()
        {
         
            var result = await controller.Get();

            //checks if the result of the Get method is an OkObjectResult by using the Assert.IsInstanceOf method.
            //This assertion checks if the result object is an instance of the OkObjectResult class.

            Assert.IsInstanceOf<OkObjectResult>(result);

            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);

            var data = okResult.Value as string;
            Assert.IsNotNull(data);

            // Validate JSON format
            var isValidJson = false;
            try
            {
                JObject.Parse(data);
                isValidJson = true;
            }
            catch (Exception ex)
            {
                isValidJson = false;
            }

            Assert.IsTrue(isValidJson);
        }
    }

}
