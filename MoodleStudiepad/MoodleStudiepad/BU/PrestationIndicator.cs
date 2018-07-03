﻿using System;
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

        /// <summary>
        /// This method requires a id of the user in order to get all the prestation indicators of that user.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>Returns a list of all the prestation indicators of the user you gave in.</returns>
        public List<PrestationIndicator> getPrestationIndicatorsById(int id) {
            // return list of prestation indicators
            QueryStrings queryStrings = new QueryStrings();
            List<PrestationIndicator> piList = queryStrings.getPrestationIndicatorsById(id);
            return piList;
        }

        /// <summary>
        /// This methods requires a id of the user in orde to get all the grades of that user.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>Returns a list of all prestation indicators of the user you gave in.</returns>
        public List<PrestationIndicator> getAverageGradeById(int id) {
            QueryStrings queryStrings = new QueryStrings();
            List<PrestationIndicator> gradeList = queryStrings.getAverageGradeById(id);
            return gradeList;
        }
    }
}
