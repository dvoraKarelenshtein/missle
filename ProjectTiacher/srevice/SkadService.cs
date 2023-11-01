using api_model;
using System;

namespace api_service
{
    public class SkadService
    {
        

        public SkadService()
        {

        }
        public IEnumerable<Skad>GetData()
        {
            return DB.data;
        }

        public IEnumerable<Skad> GetData(string city)
        {
            return DB.data.Where(t=>t.Location.City == city).ToList();
        }

        public IEnumerable<Location> GetPlace()
        {
            // return DB.data.Location.olist;

            List<Location> certainValues = new List<Location>();
            foreach (var obj in DB.data)
            {
                var certainValue = obj.Location;
                certainValues.Add(certainValue);
            }
            return certainValues;
        }

        public bool add(Skad skad)
        {
            DB.data.Add(skad);
            return true;
        }

    }
}
