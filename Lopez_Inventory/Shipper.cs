using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lopez_Inventory
{
    internal class Shipper
    {
        List<IShippable> shippables = new List<IShippable>();
        public Shipper() { }

        public string Add(IShippable shippable)
        {
            shippables.Add(shippable);
            return $"1 {shippable.Product} has been added";
        }

        public string ComputeShippingCharges()
        {
            decimal total = shippables.Sum(s => s.ShipCost);
            return $"Total shipping cost for this order is {total.ToString("C")}";
        }

        public string ListShipmentItems()
        {
            string manifestText = $"Shipment manifest {Environment.NewLine}";

            Dictionary<string, List<IShippable>> manifest = new Dictionary<string, List<IShippable>>();

            foreach (IShippable s in shippables)
            {
                if (!manifest.ContainsKey(s.Product))
                {
                    manifest.Add(s.Product, new List<IShippable> { s });
                    continue;
                }

                manifest[s.Product].Add(s);
            }

            foreach (var kv in manifest)
            {
                if(kv.Value.Count > 1)
                {
                    if(kv.Key == "Crackers")
                    {
                        manifestText += $"{kv.Value.Count.ToString()} {kv.Key} {Environment.NewLine}";
                    }else
                    {
                        manifestText += $"{kv.Value.Count.ToString()} {kv.Key + "s"} {Environment.NewLine}";
                    }
                    
                }
                else {
                    manifestText += $"{kv.Value.Count.ToString()} {kv.Key} {Environment.NewLine}";
                }
            }

            return manifestText;
        }
    }
}
