using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExam
{
    internal class Question
    {
        public string Header { get; set; }
    
        public string Body { get; set; }
        public double Mark { get; set; }

        public Question()
        {

        }

        public Question(string _Header ,string _Body ,double _Mark)

        {
            this.Header = _Header;
            this.Body = _Body;
            this.Mark = _Mark;

        }

        public override string ToString()
        {
            return $"Question : {Body} , Possible Marks{Mark}";
        }
    }
}
