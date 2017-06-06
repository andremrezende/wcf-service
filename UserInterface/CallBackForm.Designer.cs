namespace UserInterface
{
    partial class CallBackForm
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
            this.textBoxCallBack = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxCallBack
            // 
            this.textBoxCallBack.Location = new System.Drawing.Point(12, 25);
            this.textBoxCallBack.Multiline = true;
            this.textBoxCallBack.Name = "textBoxCallBack";
            this.textBoxCallBack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCallBack.Size = new System.Drawing.Size(407, 277);
            this.textBoxCallBack.TabIndex = 0;
            // 
            // CallBackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 352);
            this.Controls.Add(this.textBoxCallBack);
            this.Name = "CallBackForm";
            this.Text = "CallBackForm";
            this.Load += new System.EventHandler(this.CallBackForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxCallBack;
    }
}