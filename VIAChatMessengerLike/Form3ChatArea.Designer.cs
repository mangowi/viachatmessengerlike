namespace VIAChatMessengerLike
{
    partial class Form3ChatArea
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
            this.components = new System.ComponentModel.Container();
            this.panel1Menu = new System.Windows.Forms.Panel();
            this.menuStrip1Left = new System.Windows.Forms.MenuStrip();
            this.messagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1UserNameDisplay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1MessageDisplay = new System.Windows.Forms.TextBox();
            this.label2UserNameDiply = new System.Windows.Forms.Label();
            this.textBox2MessageToSend = new System.Windows.Forms.TextBox();
            this.button1SendMessageSuccess = new System.Windows.Forms.Button();
            this.panel1Menu.SuspendLayout();
            this.menuStrip1Left.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1Menu
            // 
            this.panel1Menu.Controls.Add(this.menuStrip1Left);
            this.panel1Menu.Location = new System.Drawing.Point(110, 99);
            this.panel1Menu.Name = "panel1Menu";
            this.panel1Menu.Size = new System.Drawing.Size(97, 405);
            this.panel1Menu.TabIndex = 0;
            // 
            // menuStrip1Left
            // 
            this.menuStrip1Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1Left.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Bold);
            this.menuStrip1Left.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messagesToolStripMenuItem,
            this.unreadToolStripMenuItem,
            this.readToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1Left.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1Left.Name = "menuStrip1Left";
            this.menuStrip1Left.Size = new System.Drawing.Size(98, 405);
            this.menuStrip1Left.TabIndex = 0;
            this.menuStrip1Left.Text = "menuStrip1";
            this.menuStrip1Left.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // messagesToolStripMenuItem
            // 
            this.messagesToolStripMenuItem.Enabled = false;
            this.messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            this.messagesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.messagesToolStripMenuItem.Text = "Messages";
            // 
            // unreadToolStripMenuItem
            // 
            this.unreadToolStripMenuItem.Name = "unreadToolStripMenuItem";
            this.unreadToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.unreadToolStripMenuItem.Text = "Unread";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.readToolStripMenuItem.Text = "Read";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.accountToolStripMenuItem.Text = "Drafts";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1UserNameDisplay
            // 
            this.label1UserNameDisplay.AutoSize = true;
            this.label1UserNameDisplay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1UserNameDisplay.ForeColor = System.Drawing.Color.White;
            this.label1UserNameDisplay.Location = new System.Drawing.Point(105, 43);
            this.label1UserNameDisplay.Name = "label1UserNameDisplay";
            this.label1UserNameDisplay.Size = new System.Drawing.Size(0, 25);
            this.label1UserNameDisplay.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1MessageDisplay);
            this.panel1.Controls.Add(this.label2UserNameDiply);
            this.panel1.Location = new System.Drawing.Point(259, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 328);
            this.panel1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Location = new System.Drawing.Point(19, 261);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(525, 50);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Message here click to read";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "doejoe";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Location = new System.Drawing.Point(19, 163);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(525, 50);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Message here click to read";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "mwajuma";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1MessageDisplay
            // 
            this.textBox1MessageDisplay.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1MessageDisplay.Location = new System.Drawing.Point(19, 61);
            this.textBox1MessageDisplay.Multiline = true;
            this.textBox1MessageDisplay.Name = "textBox1MessageDisplay";
            this.textBox1MessageDisplay.Size = new System.Drawing.Size(525, 50);
            this.textBox1MessageDisplay.TabIndex = 1;
            this.textBox1MessageDisplay.Text = "Message here click to read";
            // 
            // label2UserNameDiply
            // 
            this.label2UserNameDiply.AutoSize = true;
            this.label2UserNameDiply.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.label2UserNameDiply.ForeColor = System.Drawing.Color.White;
            this.label2UserNameDiply.Location = new System.Drawing.Point(13, 23);
            this.label2UserNameDiply.Name = "label2UserNameDiply";
            this.label2UserNameDiply.Size = new System.Drawing.Size(110, 35);
            this.label2UserNameDiply.TabIndex = 0;
            this.label2UserNameDiply.Text = "sername";
            this.label2UserNameDiply.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2MessageToSend
            // 
            this.textBox2MessageToSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.textBox2MessageToSend.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBox2MessageToSend.Location = new System.Drawing.Point(259, 444);
            this.textBox2MessageToSend.Multiline = true;
            this.textBox2MessageToSend.Name = "textBox2MessageToSend";
            this.textBox2MessageToSend.Size = new System.Drawing.Size(389, 46);
            this.textBox2MessageToSend.TabIndex = 2;
            this.textBox2MessageToSend.Text = "Type Message and send";
            // 
            // button1SendMessageSuccess
            // 
            this.button1SendMessageSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(109)))), ((int)(((byte)(122)))));
            this.button1SendMessageSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1SendMessageSuccess.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.button1SendMessageSuccess.ForeColor = System.Drawing.Color.White;
            this.button1SendMessageSuccess.Location = new System.Drawing.Point(708, 444);
            this.button1SendMessageSuccess.Name = "button1SendMessageSuccess";
            this.button1SendMessageSuccess.Size = new System.Drawing.Size(95, 46);
            this.button1SendMessageSuccess.TabIndex = 5;
            this.button1SendMessageSuccess.Text = "Send";
            this.button1SendMessageSuccess.UseVisualStyleBackColor = false;
            // 
            // Form3ChatArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(880, 537);
            this.Controls.Add(this.textBox2MessageToSend);
            this.Controls.Add(this.button1SendMessageSuccess);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1UserNameDisplay);
            this.Controls.Add(this.panel1Menu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3ChatArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIA Chat Messenger";
            this.Load += new System.EventHandler(this.Form3ChatArea_Load);
            this.panel1Menu.ResumeLayout(false);
            this.panel1Menu.PerformLayout();
            this.menuStrip1Left.ResumeLayout(false);
            this.menuStrip1Left.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1Menu;
        private System.Windows.Forms.MenuStrip menuStrip1Left;
        private System.Windows.Forms.ToolStripMenuItem messagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unreadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1UserNameDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2UserNameDiply;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1MessageDisplay;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2MessageToSend;
        private System.Windows.Forms.Button button1SendMessageSuccess;
    }
}