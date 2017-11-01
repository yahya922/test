using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateDistance
{
    public class StringComparison
    {
        public string FirstString;
        public string SecondString;
        public Relation Relation;
    }
    public enum Relation { Equal, Update, Delete }
}
