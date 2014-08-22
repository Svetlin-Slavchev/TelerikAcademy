using OOPmySolution;
using System;
using System.Text;

namespace mySolution
{
    public class OffsiteCourse : Course, IOffsiteCourse
    {
        public string Town { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.GetType().Name);
            sb.Append(": Name=" + this.Name);
            if (this.Teacher != null)
            {
                sb.Append("; Teacher=" + this.Teacher.Name);
            }
            if (myTopic.Count > 0)
            {
                sb.Append("; Topics=" + base.ReturnTopics(myTopic));
            }
            sb.Append("; Town=" + this.Town);

            return sb.ToString();
        }
    }
}
