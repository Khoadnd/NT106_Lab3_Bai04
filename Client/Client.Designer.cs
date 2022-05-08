namespace Bai4
{
    partial class Client
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessageReceived = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(349, 359);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessageReceived
            // 
            this.txtMessageReceived.Location = new System.Drawing.Point(12, 12);
            this.txtMessageReceived.Name = "txtMessageReceived";
            this.txtMessageReceived.Size = new System.Drawing.Size(412, 313);
            this.txtMessageReceived.TabIndex = 1;
            this.txtMessageReceived.Text = "";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 360);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PlaceholderText = "Message";
            this.txtMessage.Size = new System.Drawing.Size(331, 23);
            this.txtMessage.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 331);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Name";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(349, 331);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 394);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtMessageReceived);
            this.Controls.Add(this.btnSend);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSend;
        private RichTextBox txtMessageReceived;
        private TextBox txtMessage;
        private TextBox txtName;
        private Button btnConnect;
    }
}