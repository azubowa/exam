using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.NewFolder1
{
   public class classstudent : interfacestudent
    {
        string _name;
        string _numz;
        string _grupe;
        string _kursnum;
        string _pay;
        string _endstuding;
        public classstudent(string name, string numz, string grupe, string kursnum, string pay, string endstuding)
        {
            _name=name;
            _numz=numz;
            _grupe=grupe;
            _kursnum = kursnum;
            _pay=pay;
            _endstuding=endstuding;
        }
        public string name { get => _name; set => _name = value; }
        public string numz { get => _numz; set => _numz = value; }
        public string grupe { get => _grupe; set => _grupe = value; }
        public string kursnum { get => _kursnum; set => _kursnum = value; }
        public string pay { get => _pay; set => _pay = value; }
        public string endstuding { get => _endstuding; set => _endstuding = value; }
    }
}
