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
            this.Disconnect = new System.Windows.Forms.Button();
            this.Send_Message = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(31, 51);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(104, 51);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(141, 51);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(101, 51);
            this.Disconnect.TabIndex = 1;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            // 
            // Send_Message
            // 
            this.Send_Message.Location = new System.Drawing.Point(141, 117);
            this.Send_Message.Name = "Send_Message";
            this.Send_Message.Size = new System.Drawing.Size(101, 40);
            this.Send_Message.TabIndex = 2;
            this.Send_Message.Text = "Send Message";
            this.Send_Message.UseVisualStyleBackColor = true;
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(35, 128);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(100, 20);
            this.Message.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Send_Message);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Send_Message;
        private System.Windows.Forms.TextBox Message;
    }
}

