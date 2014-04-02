using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feat5
{
    class QualityAssuranceStep
    {

        List<StepResult> myStepResault = new List<StepResult>();

        public string Name { get; set; }

        public string Description { get; set; }

        public int StepId { get; set; }


        public QualityAssuranceStep (string name, string description, int stepId)

        {
        
            Name = name;
            Description = description;
            StepId = stepId;
        
        }


    }

   
}
