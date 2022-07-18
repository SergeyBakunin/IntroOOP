using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP
{
    public class StudentsGroup : NamedItem
    {
        public List<Student> Students { get; set; } = new List<Student>();

    }
}
