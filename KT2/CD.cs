using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT2
{
    class CD
    {
        public string Album { get; set; }
        public string Artist { get; set; }
        public string SName { get; set; }
        public string Time { get; set; }

        public override string ToString()
        {
            return "- " + SName + ", " + Time;
        }
    }
}
