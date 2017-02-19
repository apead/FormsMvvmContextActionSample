using System.Collections.Generic;
using MvvmContextActionSample.Models;

namespace MvvmContextActionSample.Services
{
    public static class MockSamplesService
    {
        public static List<SampleModel> GetSamples()
        {
            var returnList = new List<SampleModel>();
            var item = new SampleModel() {Description = "Row 1"};

            returnList.Add(item);
            item = new SampleModel() { Description = "Row 2" };
            returnList.Add(item);

            return returnList;
        }
    }
}
