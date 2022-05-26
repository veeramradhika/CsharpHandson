using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Collections;
using Newtonsoft.Json;


namespace serialAndDeserialHandsOn
{
    public class SerializeAndDeserialize
    {
        public class EBBill
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public int NoOfUnits { get; set; }
            public int UnitPerCost { get; set; } = 7;
            public int Total { get; set; }
        }
        public void Serialize()
        {
            List<EBBill> list = new List<EBBill>();
            EBBill bill = new EBBill();
            
            Console.WriteLine("id: " );
            bill.CustomerId = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Name: " );
            bill.Name = Convert.ToString(Console.ReadLine());

           
            Console.WriteLine("NoOfUnits: " );
            bill.NoOfUnits = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("UnitPerCost: " );
            bill.UnitPerCost =7;

            Console.WriteLine("Total: " );
            bill.Total = Convert.ToInt32(Console.ReadLine());
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

            FileStream fileStream = new FileStream(@"C:\Training(.NET)\C#(sharp)\serialAndDeserialHandsOn\serialAndDeserialHandsOn\XmlFile.txt", FileMode.Create);
           
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<EBBill>));
            xmlSerializer.Serialize(fileStream, list);

          
            fileStream.Close(); 
           

        }
        public void Deserialize()
        {
            FileStream fileStream = new FileStream(@"C:\Training(.NET)\C#(sharp)\serialAndDeserialHandsOn\serialAndDeserialHandsOn\XmlFile.txt", FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<EBBill>));
            List<EBBill> bill = (List<EBBill>)xmlSerializer.Deserialize(fileStream);
            fileStream.Close();
            


        }

    }
}
