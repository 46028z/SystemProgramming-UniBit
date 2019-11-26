namespace Slave
{
    partial class Slave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxResponce = new System.Windows.Forms.TextBox();
            this.btnRespond = new System.Windows.Forms.Button();
            this.checkBoxListen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TCP Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Received message from Master";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Send responce message to Master";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(352, 58);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(140, 31);
            this.textBoxPort.TabIndex = 5;
            this.textBoxPort.Text = "1500";
            this.textBoxPort.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(32, 133);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(460, 133);
            this.textBoxMessage.TabIndex = 6;
            this.textBoxMessage.Text = "Waiting...";
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            // 
            // textBoxResponce
            // 
            this.textBoxResponce.Location = new System.Drawing.Point(32, 306);
            this.textBoxResponce.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxResponce.Multiline = true;
            this.textBoxResponce.Name = "textBoxResponce";
            this.textBoxResponce.Size = new System.Drawing.Size(460, 133);
            this.textBoxResponce.TabIndex = 7;
            this.textBoxResponce.Text = "Hello Master !";
            // 
            // btnRespond
            // 
            this.btnRespond.Location = new System.Drawing.Point(536, 356);
            this.btnRespond.Margin = new System.Windows.Forms.Padding(6);
            this.btnRespond.Name = "btnRespond";
            this.btnRespond.Size = new System.Drawing.Size(150, 44);
            this.btnRespond.TabIndex = 8;
            this.btnRespond.Text = "Send";
            this.btnRespond.UseVisualStyleBackColor = true;
            this.btnRespond.Click += new System.EventHandler(this.btnRespond_Click);
            // 
            // checkBoxListen
            // 
            this.checkBoxListen.AutoSize = true;
            this.checkBoxListen.Checked = true;
            this.checkBoxListen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxListen.Location = new System.Drawing.Point(32, 58);
            this.checkBoxListen.Name = "checkBoxListen";
            this.checkBoxListen.Size = new System.Drawing.Size(102, 29);
            this.checkBoxListen.TabIndex = 9;
            this.checkBoxListen.Text = "Listen";
            this.checkBoxListen.UseVisualStyleBackColor = false;
            this.checkBoxListen.CheckedChanged += new System.EventHandler(this.checkBoxListen_CheckedChanged);
            // 
            // Slave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 458);
            this.Controls.Add(this.checkBoxListen);
            this.Controls.Add(this.btnRespond);
            this.Controls.Add(this.textBoxResponce);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Slave";
            this.Text = "Slave";
            this.Load += new System.EventHandler(this.Slave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxResponce;
        private System.Windows.Forms.Button btnRespond;
        private System.Windows.Forms.CheckBox checkBoxListen;
    }
}

