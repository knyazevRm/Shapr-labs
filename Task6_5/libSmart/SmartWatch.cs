using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libSmart
{
    internal class SmartWatch : SiemensMobile
    {
        public bool IsTrackingFitness { get; set; }
        public int StepsCount { get; set; }

        public SmartWatch(string model) : base(model)
        {
            IsTrackingFitness = false;
            StepsCount = 0;
        }

        public void StartFitnessTracking()
        {
            IsTrackingFitness = true;
        }

        public void StopFitnessTracking()
        {
            IsTrackingFitness = false;
        }

        public void AddSteps(int amount)
        {
            StepsCount += amount;
        }

        public void ClearSteps()
        {
            StepsCount = 0;
        }
    }
}
