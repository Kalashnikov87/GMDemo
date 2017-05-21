using System.Collections.Generic;
using GMDemo.Models;

namespace GMDemo.Repository
{
    public static class MockData
    {
        public static List<GmModel> GetSampleData()
        {
            var result = new List<GmModel>();

            for (var i = 0; i <= 2000; i++)
            {
                result.Add(new GmModel
                {
                    MachineName = $"Value{i}",
                    MachineDescription = $"Value{i}",
                    Amount = i,
                    CostPerUnit = i,
                    Total = i + i
                });

            }
            return result;
        }
    }
    
}