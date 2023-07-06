using Liskov_Substitution_IdealCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_NotIdealCode
{
    abstract class Cloud
    {
        public abstract void Translate();
        public abstract void MachineLearning();
    }

    class AWS : Cloud
    {
        public override void Translate()
            => Console.WriteLine("AWS Translate");
        public override void MachineLearning()
            => Console.WriteLine("AWS Machine Learning");
    }

    class Azure : Cloud
    {
        public override void Translate()
        {
            throw new NotImplementedException();
        }

        public override void MachineLearning()
            => Console.WriteLine("Azure Machine Learning");
    }

    class Google : Cloud
    {
        public override void Translate()
            => Console.WriteLine("Google Translate");

        public override void MachineLearning()
            => Console.WriteLine("Google Machine Learning");
    }
}
