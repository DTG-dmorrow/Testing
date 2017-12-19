using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTG.ACKProgram
{
    public class AckResponsePair
    {
        private String m_Ack = "";
        private String m_Resposne = "";

        public AckResponsePair(String ack, String response)
        {
            this.m_Ack = ack;
            this.m_Resposne = response;
        }

        public String Ack
        {
            get
            {
                return this.m_Ack;
            }
            set
            {
                this.m_Ack = value;
            }
        }
        public String Response
        {
            get
            {
                return this.m_Resposne;
            }
            set
            {
                this.m_Resposne = value;
            }
        }
    }
}
