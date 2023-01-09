using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seaQuizes
{
    public partial class Fish : DBConnection


    {
        protected string question1;
        protected string question2;
        protected string question3;

        public Fish()
        {

        }
        public Fish(string Q1, string Q2, string Q3)
        {
            this.question1 = Q1;
            this.question2 = Q2;
            this.question3 = Q3;
        }

        public string Question1()
        {
            return question1;
        }
        public string Question2()
        {
            return question2;
        }
        public string Question3()
        {
            return question3;
        }
    }
}
