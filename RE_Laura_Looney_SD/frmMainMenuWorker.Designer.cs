namespace RE_Laura_Looney_SD
{
    partial class frmMainMenuWorker
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
            this.mnuMainW = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOrder = new System.Windows.Forms.Button();
            this.mnuMainW.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainW
            // 
            this.mnuMainW.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainW.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuHomePage});
            this.mnuMainW.Location = new System.Drawing.Point(0, 0);
            this.mnuMainW.Name = "mnuMainW";
            this.mnuMainW.Size = new System.Drawing.Size(901, 28);
            this.mnuMainW.TabIndex = 4;
            this.mnuMainW.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(47, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuHomePage
            // 
            this.mnuHomePage.Name = "mnuHomePage";
            this.mnuHomePage.Size = new System.Drawing.Size(100, 24);
            this.mnuHomePage.Text = "Home Page";
            this.mnuHomePage.Click += new System.EventHandler(this.mnuHomePage_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(346, 155);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(197, 97);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // frmMainMenuWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 420);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.mnuMainW);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainMenuWorker";
            this.Text = "Looney\'s Liquer - [Main Menu]";
            this.mnuMainW.ResumeLayout(false);
            this.mnuMainW.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainW;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHomePage;
        private System.Windows.Forms.Button btnOrder;
    }
}