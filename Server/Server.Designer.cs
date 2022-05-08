namespace Bai4
{
    partial class Server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListen = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(290, 12);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.SystemColors.Window;
            this.txtMessage.Location = new System.Drawing.Point(12, 41);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(353, 261);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 314);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnListen);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnListen;
        private RichTextBox txtMessage;
    }
}