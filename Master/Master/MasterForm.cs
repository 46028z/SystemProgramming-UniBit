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

namespace Master
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

    }
}
