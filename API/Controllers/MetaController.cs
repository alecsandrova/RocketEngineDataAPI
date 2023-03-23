using API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("/get_meta")]
    public class MetaController: ControllerBase
    {
   

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                /* RocketModel model = new RocketModel();
                 var context = new JObject { { "@schema", "MongoDB" } };
                 var listaProprietati = JObject.Parse(Newtonsoft.Json.JsonConvert.SerializeObject(model, Newtonsoft.Json.Formatting.Indented));
                 var data = new JObject
                     {
                         { "@context", context },
                         { "@list",  listaProprietati}
                     };*/
                string data = @"{
    ""@context"": {
        ""schema"": ""MongoDB""
    },
    ""rockets"": ""Id,UnitNumber,Time,OperationalSetting1,OperationalSetting2,OperationalSetting3,SensorMeasurement1,SensorMeasurement2,SensorMeasurement3,SensorMeasurement4,SensorMeasurement5,SensorMeasurement6,SensorMeasurement7,SensorMeasurement8,SensorMeasurement9,SensorMeasurement10,SensorMeasurement11,SensorMeasurement12,SensorMeasurement13,SensorMeasurement14,SensorMeasurement15,SensorMeasurement16,SensorMeasurement17,SensorMeasurement18,SensorMeasurement19,SensorMeasurement20,SensorMeasurement21""
}";

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
