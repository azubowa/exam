using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.NewFolder1
{
    public class studentinfo
    {
        public List<interfacestudent> student = new List<interfacestudent>();
        public studentinfo()
        {
            interfacestudent a = new classstudent("Иванов И. И." , "И-12345", "ЭИ-18", "1 курс", "Не оплатил", "Не выпустился");
            student.Add(a);
    }
    }
}
