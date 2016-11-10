namespace VIAChatMessengerLike
{
    partial class Form4ChatCenter
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
            this.panel2MessageBody = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelYourUserName = new System.Windows.Forms.Label();
            this.textBox1MessageDisplay = new System.Windows.Forms.TextBox();
            this.labelToUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2MessageToSend = new System.Windows.Forms.TextBox();
            this.button1SendMessageSuccess = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2MessageBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2MessageBody
            // 
            this.panel2MessageBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.panel2MessageBody.Controls.Add(this.panel1);
            this.panel2MessageBody.Controls.Add(this.textBox1);
            this.panel2MessageBody.Controls.Add(this.textBox1MessageDisplay);
            this.panel2MessageBody.Location = new System.Drawing.Point(201, 71);
            this.panel2MessageBody.Name = "panel2MessageBody";
            this.panel2MessageBody.Size = new System.Drawing.Size(563, 332);
            this.panel2MessageBody.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(153, 96);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 50);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Message here click to read";
            // 
            // labelYourUserName
            // 
            this.labelYourUserName.AutoSize = true;
            this.labelYourUserName.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.labelYourUserName.ForeColor = System.Drawing.Color.White;
            this.labelYourUserName.Location = new System.Drawing.Point(641, 33);
            this.labelYourUserName.Name = "labelYourUserName";
            this.labelYourUserName.Size = new System.Drawing.Size(123, 35);
            this.labelYourUserName.TabIndex = 0;
            this.labelYourUserName.Text = "mwajuma";
            // 
            // textBox1MessageDisplay
            // 
            this.textBox1MessageDisplay.BackColor = System.Drawing.Color.White;
            this.textBox1MessageDisplay.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.textBox1MessageDisplay.Location = new System.Drawing.Point(9, 31);
            this.textBox1MessageDisplay.Multiline = true;
            this.textBox1MessageDisplay.Name = "textBox1MessageDisplay";
            this.textBox1MessageDisplay.Size = new System.Drawing.Size(365, 42);
            this.textBox1MessageDisplay.TabIndex = 1;
            this.textBox1MessageDisplay.Text = "Message here click to read";
            // 
            // labelToUserName
            // 
            this.labelToUserName.AutoSize = true;
            this.labelToUserName.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.labelToUserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelToUserName.Location = new System.Drawing.Point(204, 33);
            this.labelToUserName.Name = "labelToUserName";
            this.labelToUserName.Size = new System.Drawing.Size(202, 35);
            this.labelToUserName.TabIndex = 0;
            this.labelToUserName.Text = "toSendusername";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 63);
            this.panel1.TabIndex = 2;
            // 
            // textBox2MessageToSend
            // 
            this.textBox2MessageToSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.textBox2MessageToSend.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBox2MessageToSend.Location = new System.Drawing.Point(204, 426);
            this.textBox2MessageToSend.Multiline = true;
            this.textBox2MessageToSend.Name = "textBox2MessageToSend";
            this.textBox2MessageToSend.Size = new System.Drawing.Size(462, 109);
            this.textBox2MessageToSend.TabIndex = 1;
            this.textBox2MessageToSend.Text = "Type Message and send";
            // 
            // button1SendMessageSuccess
            // 
            this.button1SendMessageSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(109)))), ((int)(((byte)(122)))));
            this.button1SendMessageSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1SendMessageSuccess.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.button1SendMessageSuccess.ForeColor = System.Drawing.Color.White;
            this.button1SendMessageSuccess.Location = new System.Drawing.Point(672, 426);
            this.button1SendMessageSuccess.Name = "button1SendMessageSuccess";
            this.button1SendMessageSuccess.Size = new System.Drawing.Size(104, 109);
            this.button1SendMessageSuccess.TabIndex = 4;
            this.button1SendMessageSuccess.Text = "Send";
            this.button1SendMessageSuccess.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.button1.Location = new System.Drawing.Point(12, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4ChatCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(896, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1SendMessageSuccess);
            this.Controls.Add(this.textBox2MessageToSend);
            this.Controls.Add(this.panel2MessageBody);
            this.Controls.Add(this.labelToUserName);
            this.Controls.Add(this.labelYourUserName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4ChatCenter";
            this.Text = "VIA Chat Messenger";
            this.panel2MessageBody.ResumeLayout(false);
            this.panel2MessageBody.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2MessageBody;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelYourUserName;
        private System.Windows.Forms.TextBox textBox1MessageDisplay;
        private System.Windows.Forms.Label labelToUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2MessageToSend;
        private System.Windows.Forms.Button button1SendMessageSuccess;
        private System.Windows.Forms.Button button1;
    }
}