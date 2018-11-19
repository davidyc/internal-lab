using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11
{
    public class StudentTestInformation : IComparable
    {
        public string Name { get; set; }
        public string TestName { get; set; }
        public int Score { get; set; }
        public DateTime TestDate { get; set; }

        public StudentTestInformation(string name, string testname)
        {
            Name = name;
            TestName = testname;
        }

        public StudentTestInformation(string name, string testname, int score, DateTime date) : this(name, testname)
        {
            Name = name;
            TestName = testname;
            Score = score;
            TestDate = DateTime.Now;
        }

        /// <summary>
        /// Convetr informaion about test in string
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return String.Format("Name = {0} Test ={1} Score = {2} Date = {3}", Name, TestName, Score, TestDate);
        }

        /// <summary>
        /// compares two objects
        /// </summary>
        /// <param name="obj">object for comperees</param>
        /// <returns>result</returns>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            StudentTestInformation tmp = obj as StudentTestInformation;

            if (tmp != null)
                //return this.temperatureF.CompareTo(otherTemperature.temperatureF);
                return this.Score.CompareTo(tmp.Score);
            else
                throw new ArgumentException("Object is not a StudentTestInformation");

        }
    }
}
