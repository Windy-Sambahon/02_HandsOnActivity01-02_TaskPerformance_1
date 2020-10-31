namespace Basic_Queuing_System
{
    partial class CustomerView
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
            this.lblNowServing = new System.Windows.Forms.Label();
            this.lblOutofService = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNowServing
            // 
            this.lblNowServing.AutoSize = true;
            this.lblNowServing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowServing.Location = new System.Drawing.Point(31, 25);
            this.lblNowServing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNowServing.Name = "lblNowServing";
            this.lblNowServing.Size = new System.Drawing.Size(125, 20);
            this.lblNowServing.TabIndex = 0;
            this.lblNowServing.Text = " * Now Serving";
            this.lblNowServing.Click += new System.EventHandler(this.lblNowServing_Click);
            // 
            // lblOutofService
            // 
            this.lblOutofService.AutoSize = true;
            this.lblOutofService.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutofService.Location = new System.Drawing.Point(97, 105);
            this.lblOutofService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutofService.Name = "lblOutofService";
            this.lblOutofService.Size = new System.Drawing.Size(0, 31);
            this.lblOutofService.TabIndex = 1;
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 199);
            this.Controls.Add(this.lblOutofService);
            this.Controls.Add(this.lblNowServing);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblNowServing;
        public System.Windows.Forms.Label lblOutofService;
    }
}