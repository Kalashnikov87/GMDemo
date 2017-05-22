using System.Collections.Generic;
using GMDemo.Models;

namespace GMDemo.Repository
{
    public interface IGmData
    {
        List<GmModel> GetSampleData();
    }
}