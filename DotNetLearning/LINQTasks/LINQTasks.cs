using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearning.LINQTasks
{
    public class LINQTestData
    {
        public int FirstValue { get; set; }

        public int SecondValue { get; set; }

        public DateTime DateTime { get; set; }
    }

    public class LINQTasks
    {
        public List<LINQTestData> OnlyPositiveFirstValue(List<LINQTestData> dataList)
        {
            return dataList.Where(c => c.FirstValue > 0).Select(c => c).ToList();
            
        }
        
        public int FirstValueSecondValueSum(List<LINQTestData> dataList)
        {
           var first =  dataList.Select(c =>c);
            return first.ToList().Sum(x => x.SecondValue);
        }

        public bool IsEmpty(List<LINQTestData> dataList)
        {
            return !dataList.Select(c => c).Any();
        }

        public List<DateTime> ReturnDateTimeList(List<LINQTestData> dataList)
        {
            var result = dataList.Select(c=> c.DateTime);
            return result.ToList();
        }
    }
}
