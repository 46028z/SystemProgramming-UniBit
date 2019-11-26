using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Remotе;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Services;

namespace Slave
{
    public partial class Master : Form
    {
        private Remotе.cTransfer mi_Transfer = null;
        private System.Windows.Forms.Timer mi_EraseTextTimer;

        public Master()
        {
            InitializeComponent();
            mi_EraseTextTimer = new System.Windows.Forms.Timer();
            mi_EraseTextTimer.Tick += new EventHandler(OnTimerEraseText);
            mi_EraseTextTimer.Interval = 4000;
        }
        private void OnTimerEraseText(Object Object, EventArgs EventArgs)
        {
            mi_EraseTextTimer.Stop(); textBoxAnswer.Text = "Waiting...";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Remotе.kAction k_Action = new Remotе.kAction();
            k_Action.s_Command = textBoxMessage.Text;
            k_Action.s_Computer = Environment.MachineName;
            this.Cursor = Cursors.WaitCursor;
            string s_URL = string.Format("tcp://{0}:{1}/TestService", textBoxComputer.Text, textBoxPort.Text);
            try
            {
                mi_Transfer = (Remotе.cTransfer)Activator.GetObject(typeof(Remotе.cTransfer), s_URL);
                Remotе.kResponse k_Response = mi_Transfer.CallSlave(k_Action);
                textBoxAnswer.Text = "Answer from Slave:\r\n" + k_Response.s_Result;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(this, "Error sending message to Slave:\n" +
                Ex.Message, "Master Error");
            }

            this.Cursor = Cursors.Arrow;
            mi_EraseTextTimer.Start();
        }
    }
}
