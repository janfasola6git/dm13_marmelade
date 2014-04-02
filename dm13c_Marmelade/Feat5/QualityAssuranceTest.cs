using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feat5
{
    public class QualityAssuranceTest
    {

       List<QualityAssuranceStep> myQualityAssuranceStep = new List<QualityAssuranceStep>();

       public int TestID { get;set; }

       public string TestName { get; set; }

       public int MachineId { get; set; }

       public int EmployeeId { get; set; }

       public int BatchId { get; set; }   

       public  DateTime DateOfTest { get; set; }

       public  bool CompletedTest { get; set; }


       public QualityAssuranceTest(int testID, string testName, int machineId, int employeeId, int batchId, DateTime dateOfTest, bool completedTest)
       
       {
           TestID = testID;
           TestName = testName;
           MachineId = machineId;
           BatchId = batchId;
           DateOfTest = dateOfTest;
           CompletedTest = completedTest;
       
       }







    }
}
