using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.CC
{
    public class SeePrestationIndicators
    {
        /// <summary>
        /// This method requires a id of the user and send it to the Business Layer.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>Returns a list of prestation indicators objects.</returns>
        public List<PrestationIndicator> getPrestationIndicatorsById(int id)
        {
            PrestationIndicator prestationIndicator = new PrestationIndicator();
            List<PrestationIndicator> piList = prestationIndicator.getPrestationIndicatorsById(id);
            return piList;
        }

        /// <summary>
        /// This method requires a id of the user and send it to the Business Layer.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>Returns a list of prestation indicators objects</returns>
        public List<PrestationIndicator> getAverageGradeById(int id)
        {
            PrestationIndicator prestationIndicator = new PrestationIndicator();
            List<PrestationIndicator> gradeList = prestationIndicator.getAverageGradeById(id);
            return gradeList;
        }
    }
}
