using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodleStudiepad.DAL;

namespace MoodleStudiepad.BU {
    public class PrestationIndicator {
        public int studentId;
        public int courseId;
        public int piCode;
        public decimal grade;
        public decimal avgGrade;

        public List<PrestationIndicator> getPrestationIndicatorsById(int id) {
            // return list of prestation indicators
            QueryStrings queryStrings = new QueryStrings();
            List<PrestationIndicator> piList = queryStrings.getPrestationIndicatorsById(id);
            return piList;
        }

        public List<PrestationIndicator> getAverageGradeById(int id) {
            QueryStrings queryStrings = new QueryStrings();
            List<PrestationIndicator> gradeList = queryStrings.getAverageGradeById(id);
            return gradeList;
        }
    }
}
