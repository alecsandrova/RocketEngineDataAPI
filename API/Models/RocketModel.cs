using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Globalization;

namespace API.Models
{
    [BsonIgnoreExtraElements]
    public class RocketModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UnitNumber { get; set; }
        public string Time { get; set; }
        public string OperationalSetting1 { get; set; }
        public string OperationalSetting2 { get; set; }
        public string OperationalSetting3 { get; set; }
        public string SensorMeasurement1 { get; set; }
        public string SensorMeasurement2 { get; set; }
        public string SensorMeasurement3 { get; set; }
        public string SensorMeasurement4 { get; set; }
        public string SensorMeasurement5 { get; set; }
        public string SensorMeasurement6 { get; set; }
        public string SensorMeasurement7 { get; set; }
        public string SensorMeasurement8 { get; set; }
        public string SensorMeasurement9 { get; set; }
        public string SensorMeasurement10 { get; set; }
        public string SensorMeasurement11 { get; set; }
        public string SensorMeasurement12 { get; set; }
        public string SensorMeasurement13 { get; set; }
        public string SensorMeasurement14 { get; set; }
        public string SensorMeasurement15 { get; set; }
        public string SensorMeasurement16 { get; set; }
        public string SensorMeasurement17 { get; set; }
        public string SensorMeasurement18 { get; set; }
        public string SensorMeasurement19 { get; set; }
        public string SensorMeasurement20 { get; set; }
        public string SensorMeasurement21 { get; set; }

    }
}
