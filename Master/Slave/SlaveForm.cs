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
using System.Threading;

namespace Slave
{
    public partial class Slave : Form
    {
        private Remotе.cTransfer mi_Transfer = null;
        private ObjRef mi_Service = null;
        private TcpChannel mi_Channel = null;
        private bool mb_WaitButton = false;
        private System.Windows.Forms.Timer mi_EraseTextTimer;

        public Slave()
        {
            InitializeComponent();
            checkBoxListen.Checked = true; // calls StartListen()
            mi_EraseTextTimer = new System.Windows.Forms.Timer();
            mi_EraseTextTimer.Tick += new EventHandler(OnTimerEraseText);
            mi_EraseTextTimer.Interval = 4000;
        }
        private void OnTimerEraseText(Object Object, EventArgs EventArgs)
        {
            mi_EraseTextTimer.Stop();
            textBoxMessage.Text = "Waiting...";
        }

        private void btnRespond_Click(object sender, EventArgs e)
        {
            if (!mb_WaitButton)
            {
                MessageBox.Show(this, "This button has no effect until the master has sent a message!", "Slave Error");
            }
            mb_WaitButton = false;
            mi_EraseTextTimer.Start();
        }

        private void Slave_Load(object sender, EventArgs e)
        {

        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {
            checkBoxListen.Checked = false;
        }

        public void StopListen()
        {
            if (mi_Service != null)
                RemotingServices.Unmarshal(mi_Service);
            if (mi_Transfer != null)
                RemotingServices.Disconnect(mi_Transfer);
            if (mi_Channel != null)
                ChannelServices.UnregisterChannel(mi_Channel);
            mi_Service = null;
            mi_Transfer = null;
            mi_Channel = null;
        }

        public void StartListen()
        {
            StopListen(); // if there is any channel still open --> close it
            try
            {
                int s32_Port = int.Parse(textBoxPort.Text);
                mi_Channel = new TcpChannel(s32_Port);
                ChannelServices.RegisterChannel(mi_Channel, false);
                mi_Transfer = new Remotе.cTransfer();
                mi_Service = RemotingServices.Marshal(mi_Transfer, "TestService");
                mi_Transfer.ev_SlaveCall +=
                new Remotе.cTransfer.del_SlaveCall(OnMasterEvent);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(this, "Error starting listening:\n" +
                Ex.Message, "Slave");
                checkBoxListen.Checked = false; // calls StopListen()
            }
        }

        Remotе.kResponse OnMasterEvent(Remotе.kAction k_Action)
        {
            Remotе.kResponse k_Response = new Remotе.kResponse();
            if (mb_WaitButton)
            {
                k_Response.s_Result =
                "Sorry! Slave is currently busy.\r\nTry again later";
                return k_Response;
            }
            textBoxMessage.Text = string.Format("Message from [{0}]:\r\n{1}\r\n(Click Button \"Send\" to answer)", k_Action.s_Computer, k_Action.s_Command);
            mi_EraseTextTimer.Stop();
            mb_WaitButton = true;
            while (mb_WaitButton)
            {
                Thread.Sleep(200);
            };
            k_Response.s_Result = textBoxResponce.Text;
            return k_Response;
        }

        private void checkBoxListen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxListen.Checked)
                StartListen();
            else
                StopListen();
        }
    }
}
