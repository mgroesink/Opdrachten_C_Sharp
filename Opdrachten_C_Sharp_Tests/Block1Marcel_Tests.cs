using Opdrachten_C_Sharp.Models.Block1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_C_Sharp_Tests
{
    public partial class Block1Tests
    {
        [Fact]
        public void MarcelExercise1Constructor1Test()
        {
            Me person = new Me("Marcel", "Roesink", 66);
            string fullname = person.FullName;
            Assert.Equal("Marcel Roesink", fullname);
        }
    }
}
