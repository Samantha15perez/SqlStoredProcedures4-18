namespace SQLDataRetrieval
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
            this.tabControlJobLeadsPerDay = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridInactiveLeads = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.dataGridLeadsBySource = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridActiveContactList = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridActiveLeads = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.LeadReport = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFromDate = new System.Windows.Forms.TextBox();
            this.textBoxUntilDate = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridLeadReport = new System.Windows.Forms.DataGridView();
            this.dataGridJobLeadsPerDay = new System.Windows.Forms.DataGridView();
            this.dataGridSearchLog = new System.Windows.Forms.DataGridView();
            this.tabControlJobLeadsPerDay.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInactiveLeads)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeadsBySource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActiveContactList)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActiveLeads)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.LeadReport.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeadReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJobLeadsPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchLog)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlJobLeadsPerDay
            // 
            this.tabControlJobLeadsPerDay.Controls.Add(this.tabPage2);
            this.tabControlJobLeadsPerDay.Controls.Add(this.tabPage1);
            this.tabControlJobLeadsPerDay.Controls.Add(this.tabPage3);
            this.tabControlJobLeadsPerDay.Controls.Add(this.tabPage4);
            this.tabControlJobLeadsPerDay.Controls.Add(this.tabPage5);
            this.tabControlJobLeadsPerDay.Controls.Add(this.LeadReport);
            this.tabControlJobLeadsPerDay.Controls.Add(this.tabPage6);
            this.tabControlJobLeadsPerDay.Location = new System.Drawing.Point(12, 12);
            this.tabControlJobLeadsPerDay.Name = "tabControlJobLeadsPerDay";
            this.tabControlJobLeadsPerDay.SelectedIndex = 0;
            this.tabControlJobLeadsPerDay.Size = new System.Drawing.Size(636, 248);
            this.tabControlJobLeadsPerDay.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridInactiveLeads);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "InactiveLeads";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridInactiveLeads
            // 
            this.dataGridInactiveLeads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInactiveLeads.Location = new System.Drawing.Point(16, 17);
            this.dataGridInactiveLeads.Name = "dataGridInactiveLeads";
            this.dataGridInactiveLeads.Size = new System.Drawing.Size(597, 181);
            this.dataGridInactiveLeads.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridLeadsBySource);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 222);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "LeadsBySource";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(570, 266);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(74, 37);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Update";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // dataGridLeadsBySource
            // 
            this.dataGridLeadsBySource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLeadsBySource.Location = new System.Drawing.Point(16, 19);
            this.dataGridLeadsBySource.Name = "dataGridLeadsBySource";
            this.dataGridLeadsBySource.Size = new System.Drawing.Size(597, 181);
            this.dataGridLeadsBySource.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridActiveContactList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(628, 222);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "ActiveContactList";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridActiveContactList
            // 
            this.dataGridActiveContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActiveContactList.Location = new System.Drawing.Point(16, 19);
            this.dataGridActiveContactList.Name = "dataGridActiveContactList";
            this.dataGridActiveContactList.Size = new System.Drawing.Size(597, 181);
            this.dataGridActiveContactList.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridActiveLeads);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(628, 222);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "ActiveLeads";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridActiveLeads
            // 
            this.dataGridActiveLeads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActiveLeads.Location = new System.Drawing.Point(16, 19);
            this.dataGridActiveLeads.Name = "dataGridActiveLeads";
            this.dataGridActiveLeads.Size = new System.Drawing.Size(597, 181);
            this.dataGridActiveLeads.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridSearchLog);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(628, 222);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "SearchLog";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // LeadReport
            // 
            this.LeadReport.Controls.Add(this.dataGridLeadReport);
            this.LeadReport.Location = new System.Drawing.Point(4, 22);
            this.LeadReport.Name = "LeadReport";
            this.LeadReport.Padding = new System.Windows.Forms.Padding(3);
            this.LeadReport.Size = new System.Drawing.Size(628, 222);
            this.LeadReport.TabIndex = 6;
            this.LeadReport.Text = "LeadReport";
            this.LeadReport.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Until:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "From:";
            // 
            // textBoxFromDate
            // 
            this.textBoxFromDate.Location = new System.Drawing.Point(153, 275);
            this.textBoxFromDate.Name = "textBoxFromDate";
            this.textBoxFromDate.Size = new System.Drawing.Size(123, 20);
            this.textBoxFromDate.TabIndex = 8;
            // 
            // textBoxUntilDate
            // 
            this.textBoxUntilDate.Location = new System.Drawing.Point(403, 275);
            this.textBoxUntilDate.Name = "textBoxUntilDate";
            this.textBoxUntilDate.Size = new System.Drawing.Size(123, 20);
            this.textBoxUntilDate.TabIndex = 9;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridJobLeadsPerDay);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(628, 222);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "JobLeadsPerDay";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridLeadReport
            // 
            this.dataGridLeadReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLeadReport.Location = new System.Drawing.Point(16, 19);
            this.dataGridLeadReport.Name = "dataGridLeadReport";
            this.dataGridLeadReport.Size = new System.Drawing.Size(597, 181);
            this.dataGridLeadReport.TabIndex = 5;
            // 
            // dataGridJobLeadsPerDay
            // 
            this.dataGridJobLeadsPerDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJobLeadsPerDay.Location = new System.Drawing.Point(16, 19);
            this.dataGridJobLeadsPerDay.Name = "dataGridJobLeadsPerDay";
            this.dataGridJobLeadsPerDay.Size = new System.Drawing.Size(597, 181);
            this.dataGridJobLeadsPerDay.TabIndex = 6;
            // 
            // dataGridSearchLog
            // 
            this.dataGridSearchLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchLog.Location = new System.Drawing.Point(16, 19);
            this.dataGridSearchLog.Name = "dataGridSearchLog";
            this.dataGridSearchLog.Size = new System.Drawing.Size(597, 181);
            this.dataGridSearchLog.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 316);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControlJobLeadsPerDay);
            this.Controls.Add(this.textBoxFromDate);
            this.Controls.Add(this.textBoxUntilDate);
            this.Name = "Form1";
            this.Text = "Sql Stored Procedures";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlJobLeadsPerDay.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInactiveLeads)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeadsBySource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActiveContactList)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActiveLeads)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.LeadReport.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeadReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJobLeadsPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlJobLeadsPerDay;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridInactiveLeads;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridLeadsBySource;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridActiveContactList;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridActiveLeads;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage LeadReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFromDate;
        private System.Windows.Forms.TextBox textBoxUntilDate;
        private System.Windows.Forms.DataGridView dataGridSearchLog;
        private System.Windows.Forms.DataGridView dataGridLeadReport;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridJobLeadsPerDay;
    }
}

