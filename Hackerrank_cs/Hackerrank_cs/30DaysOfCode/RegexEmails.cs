using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hackerrank_cs._30DaysOfCode
{
    class RegexEmails
    {
        public RegexEmails()
        {
            var str = "vin-i_lkp@gmailacom";
            var re = new Regex("[a-zA-Z\\-_]+@gmail\\.com");
            Console.WriteLine(re.IsMatch(str));
        }
    }
}
