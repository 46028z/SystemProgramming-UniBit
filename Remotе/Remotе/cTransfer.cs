using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remotе
{
    public class cTransfer : MarshalByRefObject
    {
        [Serializable] public struct kAction
        { 
          public string s_Command; 
            // the text to be sent by master 
          public string s_Computer; 
            // Computer name of the sender (=slave) 
        };
        [Serializable] public struct kResponse
        {
            public string s_Result; 
            // the response text sent by slave 
        };
        public cTransfer ()
        {
        }
        public delegate kResponse del_SlaveCall(kAction k_Action);
        public event del_SlaveCall ev_SlaveCall;
        public kResponse CallSlave(kAction k_Action)
        {
            return ev_SlaveCall(k_Action);
        }
        public override Object InitializeLifetimeService()
        {
            return null;
        }
    }
}
