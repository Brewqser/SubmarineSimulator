using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public interface IStorable
    {
        int Amount { get; set; }

        void HowMuchLeft();
    }
}