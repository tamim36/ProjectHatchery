using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHatchery.EventDeclaration
{
    public class FishAmountArgs : EventArgs
    {
        public int amount { get; set; }
    }
}
