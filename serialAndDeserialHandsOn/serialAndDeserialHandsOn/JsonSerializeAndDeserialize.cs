using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;




namespace serialAndDeserialHandsOn
{
    public class JsonSerializeAndDeserialize
    {
        public class EBBill
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public int NoOfUnits { get; set; }
            public int UnitPerCost { get; set; } = 7;
            public int Total { get; set; }
        }
        public void JsonSerialize()
        {
            List<EBBill> list = new List<EBBill>();
            EBBill bill = new EBBill();

            Console.WriteLine("id: ");
            bill.CustomerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name: ");
            bill.Name = Convert.ToString(Console.ReadLine());


            Console.WriteLine("NoOfUnits: ");
            bill.NoOfUnits = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total: ");
            bill.Total = bill.UnitPerCost * bill.NoOfUnits;
            list.Add(bill);

            bill = new EBBill();

            Console.WriteLine("id: ");
            bill.CustomerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name: ");
            bill.Name = Convert.ToString(Console.ReadLine());


            Console.WriteLine("NoOfUnits: ");
            bill.NoOfUnits = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total: ");
            bill.Total = bill.UnitPerCost * bill.NoOfUnits;
            list.Add(bill);



            list.Add(bill);

            FileStream fileStream = new FileStream(@"C:\Training(.NET)\C#(sharp)\serialAndDeserialHandsOn\serialAndDeserialHandsOn\JsonFile.txt", FileMode.Create);

            JsonSerializer jsonSerializer = new JsonSerializer();
            StreamWriter sw = new StreamWriter(fileStream);
            JsonWriter jsonWriter = new JsonTextWriter(sw);
            jsonSerializer.Serialize(jsonWriter, list);
            sw.Close();
            jsonWriter.Close();
            fileStream.Close() ;


        }
        public void JsonDeserialize()
        {
            EBBill eBBill;
            FileStream fileStream = new FileStream(@"C:\Training(.NET)\C#(sharp)\serialAndDeserialHandsOn\serialAndDeserialHandsOn\JsonFile.txt", FileMode.Open);
            JsonSerializer jsonSerializer = new JsonSerializer();
            StreamReader sw = new StreamReader(fileStream);
            JsonReader jsonReader = new JsonTextReader(sw);
            List<EBBill> bill =(List<EBBill>) jsonSerializer.Deserialize(jsonReader,typeof(List<EBBill>));
            sw.Close();
            jsonReader.Close();
            fileStream.Close();

            Console.WriteLine(bill.Count);
            Console.ReadLine();
        }
    }
}
