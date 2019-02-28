namespace AccountabilityAccounting
{
    partial class EditRowMainTab
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSign = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTranscriptItem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAccept = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbAccountables = new System.Windows.Forms.TextBox();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnAccountables = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnSigns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Приход/Расход (+/-)";
            // 
            // tbSign
            // 
            this.tbSign.Location = new System.Drawing.Point(155, 48);
            this.tbSign.Name = "tbSign";
            this.tbSign.ReadOnly = true;
            this.tbSign.Size = new System.Drawing.Size(42, 20);
            this.tbSign.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(303, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Проект";
            // 
            // tbProject
            // 
            this.tbProject.Location = new System.Drawing.Point(375, 16);
            this.tbProject.Name = "tbProject";
            this.tbProject.ReadOnly = true;
            this.tbProject.Size = new System.Drawing.Size(350, 20);
            this.tbProject.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(264, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Подотчетник";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(298, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Статьтя";
            // 
            // tbItem
            // 
            this.tbItem.Location = new System.Drawing.Point(375, 84);
            this.tbItem.Name = "tbItem";
            this.tbItem.ReadOnly = true;
            this.tbItem.Size = new System.Drawing.Size(350, 20);
            this.tbItem.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(259, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Расшифровка";
            // 
            // tbTranscriptItem
            // 
            this.tbTranscriptItem.Location = new System.Drawing.Point(375, 115);
            this.tbTranscriptItem.Name = "tbTranscriptItem";
            this.tbTranscriptItem.Size = new System.Drawing.Size(350, 20);
            this.tbTranscriptItem.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Сумма";
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(61, 188);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(136, 20);
            this.tbSum.TabIndex = 13;
            this.tbSum.Text = "0";
            this.tbSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(613, 216);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(89, 34);
            this.btCancel.TabIndex = 14;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAccept
            // 
            this.btAccept.Location = new System.Drawing.Point(500, 216);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(89, 34);
            this.btAccept.TabIndex = 15;
            this.btAccept.Text = "Применить";
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.btAccept_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(61, 10);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(136, 20);
            this.dtpDate.TabIndex = 17;
            // 
            // tbAccountables
            // 
            this.tbAccountables.Location = new System.Drawing.Point(375, 49);
            this.tbAccountables.Name = "tbAccountables";
            this.tbAccountables.ReadOnly = true;
            this.tbAccountables.Size = new System.Drawing.Size(350, 20);
            this.tbAccountables.TabIndex = 18;
            // 
            // btnProjects
            // 
            this.btnProjects.Location = new System.Drawing.Point(731, 16);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(41, 20);
            this.btnProjects.TabIndex = 19;
            this.btnProjects.Text = "...";
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnAccountables
            // 
            this.btnAccountables.Location = new System.Drawing.Point(731, 48);
            this.btnAccountables.Name = "btnAccountables";
            this.btnAccountables.Size = new System.Drawing.Size(41, 22);
            this.btnAccountables.TabIndex = 20;
            this.btnAccountables.Text = "...";
            this.btnAccountables.UseVisualStyleBackColor = true;
            this.btnAccountables.Click += new System.EventHandler(this.btnAccountables_Click);
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(731, 84);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(41, 22);
            this.btnItems.TabIndex = 21;
            this.btnItems.Text = "...";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnSigns
            // 
            this.btnSigns.Location = new System.Drawing.Point(203, 48);
            this.btnSigns.Name = "btnSigns";
            this.btnSigns.Size = new System.Drawing.Size(35, 22);
            this.btnSigns.TabIndex = 22;
            this.btnSigns.Text = "...";
            this.btnSigns.UseVisualStyleBackColor = true;
            this.btnSigns.Click += new System.EventHandler(this.btnSigns_Click);
            // 
            // EditRowMainTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 262);
            this.Controls.Add(this.btnSigns);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnAccountables);
            this.Controls.Add(this.btnProjects);
            this.Controls.Add(this.tbAccountables);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btAccept);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTranscriptItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbProject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditRowMainTab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Правка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTranscriptItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnAccountables;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnSigns;
        internal System.Windows.Forms.TextBox tbSign;
        public System.Windows.Forms.TextBox tbProject;
        internal System.Windows.Forms.TextBox tbItem;
        internal System.Windows.Forms.TextBox tbAccountables;
    }
}