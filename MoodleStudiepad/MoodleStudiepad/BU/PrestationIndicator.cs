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
        public double grade;
        public int weight;
        public float avgGrade;

        public List<PrestationIndicator> getPrestationIndicators(int id) {
            // return list of prestation indicators
            QueryStrings queryStrings = new QueryStrings();
            List<PrestationIndicator> piList = queryStrings.getPrestationIndicatorsById(id);
            return piList;
        }

        void getAverageGrades() {
            // return avgGrade
        }

        //public Student getSingleStudent(int id)
        //{
        //    QueryStrings queryStrings = new QueryStrings();
        //    Student singleStudent = queryStrings.getSingleStudentById(id);
        //    return singleStudent;
        //}
    }
}
