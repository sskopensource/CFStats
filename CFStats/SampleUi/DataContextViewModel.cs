using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUi
{
    class DataContextViewModel
    {
        public Model1 model1 { get; set; }
        public Model2 model2 { get; set; }

        public DataContextViewModel()
        {
            model1 = new Model1() { Model="First"};
            model2 = new Model2() { Model="Second"};
        }
    }
}
