using System.Collections.Generic;
using GMDemo.Models;

namespace GMDemo.Repository
{
    public class MockData : IGmData
    {
        List<GmModel> IGmData.GetSampleData()
        {
            return GetSampleData();
        }

        public static List<GmModel> GetSampleData()
        {
            var result = new List<GmModel>();

            for (var i = 0; i < 75; i++)
                result.Add(new GmModel
                {
                    MachineName = $"Machine {i}",
                    MachineDescription = $"This is machine {i}",
                    Amount = i,
                    CostPerUnit = i,
                    Total = i * i
                });
            return result;
        }
    }
}