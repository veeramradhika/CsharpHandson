using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace serialAndDeserialHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SerializeAndDeserialize serializeAndDeserialize = new SerializeAndDeserialize();
            //serializeAndDeserialize.Deserialize();

            //JsonSerializeAndDeserialize jsonSerializeAndDeserialize = new JsonSerializeAndDeserialize();
            //jsonSerializeAndDeserialize.JsonSerialize();

            JsonSerializeAndDeserialize jsonSerializeAndDeserialize = new JsonSerializeAndDeserialize();
            jsonSerializeAndDeserialize.JsonDeserialize();
        }
    }
}
