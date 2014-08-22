using System;

namespace mySolution
{
    public class LocalCourse : Course, ILocalCourse
    {
        public string Lab { get; set; }

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
            sb.Append("; Lab=" + this.Lab);

            return sb.ToString();
        }
    }
}
