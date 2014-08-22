using OOPmySolution;
using System;
using System.Collections.Generic;
using System.Text;

namespace mySolution
{
    public class Course : ICourse
    {
        protected List<string> myTopic = new List<string>();

        public string Name { get; set; }

        public ITeacher Teacher { get; set; }

        public void AddTopic(string topic)
        {
            myTopic.Add(topic);
        }

        public string ReturnTopics(List<string> myTopic)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (var topics in myTopic)
            {
                sb.Append(topics);
                sb.Append(", ");
            }
             sb.Remove(sb.Length - 2, 2);
             sb.Append("]");
            return sb.ToString();
        }
    }
}
