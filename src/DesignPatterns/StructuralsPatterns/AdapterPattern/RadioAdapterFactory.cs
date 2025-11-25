using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class RadioAdapterFactory 
    {
        
        public IRadioAdapter Create(string selectedRadio)
        {
            // Match Patterns

            return selectedRadio switch
            {
                "M" => new MotorolaRadioAdapter(new MotorolaRadio()),
                "H" => new HyteraRadioAdapter(new HyteraRadio(), "1234"),
                _ => throw new NotSupportedException(),
            };
        }
    }
}
