using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feat5
{
   public class StepResult
    {


        public string ExpectedResult { get; set; }

        public string ActualResult { get; set; }

        public string ResultName { get; set; }

        public DateTime TimeCompleted { get; set; }


        public StepResult(string expectedResult, string actualResult, string resultName, DateTime timeCompleted )
        
        {

            ExpectedResult = expectedResult;
            ActualResult = actualResult;
            ResultName = resultName;
            TimeCompleted = timeCompleted; 
        
        }
        
        
        

    }
}
