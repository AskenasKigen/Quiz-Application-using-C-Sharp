using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seaQuizes
{
     public partial class  BirdsClass : DBConnection
    {
        protected string question1;
        protected string question2;
        protected string question3;

        public BirdsClass()
        {
        }

        public BirdsClass(string question1)
        {
            this.question1 = question1;
            // this.question3 = question3;
        }

        internal string Show()
        {
            return "Which is the flying " + question1;
        }

    }
    public class Fly : BirdsClass
    {
        // private string question2;
        public Fly() : base()
        {
            question1 = question1;
            question3 = question3;
        }
        public Fly(string question1, string question3) : base()
        {

            this.question1 = question1;
            this.question3 = question3;
            
        }
        public new string Show()
        {
            question2 = question1;
            return question2;
        }
        public string Show1()
        {
            // question3 = question3;
            return question3;
        }
    }
}
