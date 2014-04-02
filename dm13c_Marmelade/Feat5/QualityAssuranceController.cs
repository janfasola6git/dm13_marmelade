using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feat5
{
    class QualityAssuranceController
    {
        List<QualityAssuranceTest> myQualityAssuranceTest = new List<QualityAssuranceTest>();

        List<QualityAssuranceStep> myQualityAssuranceSteps = new List<QualityAssuranceStep>();


        public void CreateTest(string testName, int machineId, int employeeId,
                               int batchId, DateTime dateOfTest, bool completedTest)
        {
            int myTestId;
            try 
            
            { 

                //TO DO

             myTestId = myDataAccessDb.AddQualityTestInDb(testName, machineId, employeeId, batchId, dateOfTest, completedTest);
             QualityAssuranceTest myQualityTest = new QualityAssuranceTest(myTestId, testName, machineId,
                                                                employeeId, batchId, dateOfTest, completedTest);

              myQualityAssuranceTest.Add(myQualityTest);
           
            }

            catch

            {
            throw new Exception("Error");
            }
            
        }

        public void CreateQualityAssuranceStep(string name, string description)
        {

            int myStepId;
            try
            {

                myStepId = myDataAccesDb.AddQualityAssuranceStepInDb(name, description);
                QualityAssuranceStep myQaStep = new QualityAssuranceStep(name, description, myStepId);

                myQualityAssuranceSteps.Add(myQaStep);

            }

            catch

            {
                throw new Exception();
            }
                     
            
        }


    }

    
}
