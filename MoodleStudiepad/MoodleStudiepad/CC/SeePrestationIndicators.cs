using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.CC
{
    class SeePrestationIndicators
    {
        public List<PrestationIndicator> getPrestationIndicatorsById(int id)
        {
            PrestationIndicator prestationIndicator = new PrestationIndicator();
            List<PrestationIndicator> piList = prestationIndicator.getPrestationIndicatorsById(id);
            return piList;
        }

        public List<PrestationIndicator> getAverageGradeById(int id)
        {
            PrestationIndicator prestationIndicator = new PrestationIndicator();
            List<PrestationIndicator> gradeList = prestationIndicator.getAverageGradeById(id);
            return gradeList;
        }
    }
}
