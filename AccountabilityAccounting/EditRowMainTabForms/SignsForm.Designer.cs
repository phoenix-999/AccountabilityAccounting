namespace AccountabilityAccounting
{
    partial class SignsForm
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
            this.dataGridViewSigns = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSigns)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSigns
            // 
            this.dataGridViewSigns.AllowUserToAddRows = false;
            this.dataGridViewSigns.AllowUserToDeleteRows = false;
            this.dataGridViewSigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSigns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSigns.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSigns.Name = "dataGridViewSigns";
            this.dataGridViewSigns.ReadOnly = true;
            this.dataGridViewSigns.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewSigns.Size = new System.Drawing.Size(195, 75);
            this.dataGridViewSigns.TabIndex = 0;
            // 
            // SignsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 75);
            this.Controls.Add(this.dataGridViewSigns);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SignsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приход/Расход";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSigns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSigns;
    }
}