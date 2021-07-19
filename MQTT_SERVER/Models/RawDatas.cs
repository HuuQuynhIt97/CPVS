using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization;
using System.ComponentModel.DataAnnotations;

namespace MQTT_SERVER.Models
{
    public class RawDatas
    {
        public RawDatas()
        {
            CreatedDateTime = DateTime.Now;
        }

        [Key]
        public int ID { get; set; }
        public string Line { get; set; }
        public string Camera { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int Count { get; set; }
        public DateTime TimeRecieve { get; set; }
    }
}
