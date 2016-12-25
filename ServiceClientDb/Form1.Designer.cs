namespace ServiceClientDb
{
    partial class Form1
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
            this.showTablesBtn = new System.Windows.Forms.Button();
            this.showDataBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tablesListView = new System.Windows.Forms.ListBox();
            this.dataListView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // showTablesBtn
            // 
            this.showTablesBtn.Location = new System.Drawing.Point(64, 21);
            this.showTablesBtn.Name = "showTablesBtn";
            this.showTablesBtn.Size = new System.Drawing.Size(75, 23);
            this.showTablesBtn.TabIndex = 0;
            this.showTablesBtn.Text = "Show tables";
            this.showTablesBtn.UseVisualStyleBackColor = true;
            this.showTablesBtn.Click += new System.EventHandler(this.showTablesBtn_Click);
            // 
            // showDataBtn
            // 
            this.showDataBtn.Location = new System.Drawing.Point(358, 21);
            this.showDataBtn.Name = "showDataBtn";
            this.showDataBtn.Size = new System.Drawing.Size(75, 23);
            this.showDataBtn.TabIndex = 3;
            this.showDataBtn.Text = "Show data";
            this.showDataBtn.UseVisualStyleBackColor = true;
            this.showDataBtn.Click += new System.EventHandler(this.showDataBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data";
            // 
            // tablesListView
            // 
            this.tablesListView.FormattingEnabled = true;
            this.tablesListView.Location = new System.Drawing.Point(64, 119);
            this.tablesListView.Name = "tablesListView";
            this.tablesListView.Size = new System.Drawing.Size(231, 186);
            this.tablesListView.TabIndex = 8;
            // 
            // dataListView
            // 
            this.dataListView.FormattingEnabled = true;
            this.dataListView.Location = new System.Drawing.Point(355, 119);
            this.dataListView.Name = "dataListView";
            this.dataListView.Size = new System.Drawing.Size(257, 186);
            this.dataListView.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 416);
            this.Controls.Add(this.dataListView);
            this.Controls.Add(this.tablesListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showDataBtn);
            this.Controls.Add(this.showTablesBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showTablesBtn;
        private System.Windows.Forms.Button showDataBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox tablesListView;
        private System.Windows.Forms.ListBox dataListView;
    }
}

