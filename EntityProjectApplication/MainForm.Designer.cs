namespace EntityProjectApplication
{
    partial class MainForm
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
            this.BtnCtgrTrns = new System.Windows.Forms.Button();
            this.BtnPrdctTrns = new System.Windows.Forms.Button();
            this.BtnStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCtgrTrns
            // 
            this.BtnCtgrTrns.Location = new System.Drawing.Point(12, 12);
            this.BtnCtgrTrns.Name = "BtnCtgrTrns";
            this.BtnCtgrTrns.Size = new System.Drawing.Size(136, 83);
            this.BtnCtgrTrns.TabIndex = 0;
            this.BtnCtgrTrns.Text = "Category Transactions";
            this.BtnCtgrTrns.UseVisualStyleBackColor = true;
            this.BtnCtgrTrns.Click += new System.EventHandler(this.BtnCtgrTrns_Click);
            // 
            // BtnPrdctTrns
            // 
            this.BtnPrdctTrns.Location = new System.Drawing.Point(154, 12);
            this.BtnPrdctTrns.Name = "BtnPrdctTrns";
            this.BtnPrdctTrns.Size = new System.Drawing.Size(136, 83);
            this.BtnPrdctTrns.TabIndex = 1;
            this.BtnPrdctTrns.Text = "Product Transactions";
            this.BtnPrdctTrns.UseVisualStyleBackColor = true;
            this.BtnPrdctTrns.Click += new System.EventHandler(this.BtnPrdctTrns_Click);
            // 
            // BtnStatistics
            // 
            this.BtnStatistics.Location = new System.Drawing.Point(296, 12);
            this.BtnStatistics.Name = "BtnStatistics";
            this.BtnStatistics.Size = new System.Drawing.Size(136, 83);
            this.BtnStatistics.TabIndex = 2;
            this.BtnStatistics.Text = "Statistics";
            this.BtnStatistics.UseVisualStyleBackColor = true;
            this.BtnStatistics.Click += new System.EventHandler(this.BtnStatistics_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 107);
            this.Controls.Add(this.BtnStatistics);
            this.Controls.Add(this.BtnPrdctTrns);
            this.Controls.Add(this.BtnCtgrTrns);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCtgrTrns;
        private System.Windows.Forms.Button BtnPrdctTrns;
        private System.Windows.Forms.Button BtnStatistics;
    }
}