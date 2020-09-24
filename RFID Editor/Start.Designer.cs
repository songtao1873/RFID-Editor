namespace Editor
{
    partial class Start
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
            this.lab_Tip = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lab_Ret = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_Tip
            // 
            this.lab_Tip.AutoSize = true;
            this.lab_Tip.BackColor = System.Drawing.Color.White;
            this.lab_Tip.Location = new System.Drawing.Point(13, 9);
            this.lab_Tip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Tip.Name = "lab_Tip";
            this.lab_Tip.Size = new System.Drawing.Size(61, 20);
            this.lab_Tip.TabIndex = 1;
            this.lab_Tip.Text = "lab_Tip";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lab_Ret
            // 
            this.lab_Ret.AutoSize = true;
            this.lab_Ret.BackColor = System.Drawing.Color.White;
            this.lab_Ret.Location = new System.Drawing.Point(209, 9);
            this.lab_Ret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Ret.Name = "lab_Ret";
            this.lab_Ret.Size = new System.Drawing.Size(63, 20);
            this.lab_Ret.TabIndex = 2;
            this.lab_Ret.Text = "lab_Ret";
            this.lab_Ret.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Start
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(530, 29);
            this.ControlBox = false;
            this.Controls.Add(this.lab_Ret);
            this.Controls.Add(this.lab_Tip);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_Tip;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lab_Ret;
    }
}