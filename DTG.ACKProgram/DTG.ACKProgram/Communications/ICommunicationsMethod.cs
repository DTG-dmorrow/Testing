using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTG.ACKProgram.Communications
{
    interface ICommunicationsMethod
    {
        void Connect();

        void Close();
    }
}
