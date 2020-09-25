namespace WebSocketSimpleExample
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Connect = new System.Windows.Forms.Button();
            this.Send_Message = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.ConsoleMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(31, 12);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(211, 51);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Send_Message
            // 
            this.Send_Message.Location = new System.Drawing.Point(141, 77);
            this.Send_Message.Name = "Send_Message";
            this.Send_Message.Size = new System.Drawing.Size(101, 40);
            this.Send_Message.TabIndex = 2;
            this.Send_Message.Text = "Send Message";
            this.Send_Message.UseVisualStyleBackColor = true;
            this.Send_Message.Click += new System.EventHandler(this.Send_Message_Click);
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(31, 88);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(100, 20);
            this.Message.TabIndex = 3;
            // 
            // ConsoleMessage
            // 
            this.ConsoleMessage.Location = new System.Drawing.Point(31, 135);
            this.ConsoleMessage.Multiline = true;
            this.ConsoleMessage.Name = "ConsoleMessage";
            this.ConsoleMessage.Size = new System.Drawing.Size(211, 96);
            this.ConsoleMessage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ConsoleMessage);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Send_Message);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Send_Message;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.TextBox ConsoleMessage;
    }
}

