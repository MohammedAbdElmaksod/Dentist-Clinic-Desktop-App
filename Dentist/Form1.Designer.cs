namespace Dentist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowSearch = new System.Windows.Forms.Button();
            this.btnMinmaize = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaidUp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRest = new System.Windows.Forms.TextBox();
            this.dtEX = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtReEX = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDone = new System.Windows.Forms.TextBox();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.btnClearData = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.HomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnPatients);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel3);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.Salmon;
            this.label11.Name = "label11";
            // 
            // btnPatients
            // 
            this.btnPatients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnPatients, "btnPatients");
            this.btnPatients.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPatients.FlatAppearance.BorderSize = 0;
            this.btnPatients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnPatients.ForeColor = System.Drawing.Color.Black;
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.UseVisualStyleBackColor = false;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Name = "btnHome";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnShowSearch);
            this.panel2.Controls.Add(this.btnMinmaize);
            this.panel2.Controls.Add(this.btnResize);
            this.panel2.Controls.Add(this.btnClose);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("txtSearch.AutoCompleteCustomSource"),
            resources.GetString("txtSearch.AutoCompleteCustomSource1"),
            resources.GetString("txtSearch.AutoCompleteCustomSource2"),
            resources.GetString("txtSearch.AutoCompleteCustomSource3"),
            resources.GetString("txtSearch.AutoCompleteCustomSource4"),
            resources.GetString("txtSearch.AutoCompleteCustomSource5"),
            resources.GetString("txtSearch.AutoCompleteCustomSource6"),
            resources.GetString("txtSearch.AutoCompleteCustomSource7"),
            resources.GetString("txtSearch.AutoCompleteCustomSource8"),
            resources.GetString("txtSearch.AutoCompleteCustomSource9"),
            resources.GetString("txtSearch.AutoCompleteCustomSource10"),
            resources.GetString("txtSearch.AutoCompleteCustomSource11"),
            resources.GetString("txtSearch.AutoCompleteCustomSource12"),
            resources.GetString("txtSearch.AutoCompleteCustomSource13"),
            resources.GetString("txtSearch.AutoCompleteCustomSource14"),
            resources.GetString("txtSearch.AutoCompleteCustomSource15"),
            resources.GetString("txtSearch.AutoCompleteCustomSource16"),
            resources.GetString("txtSearch.AutoCompleteCustomSource17"),
            resources.GetString("txtSearch.AutoCompleteCustomSource18")});
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Name = "txtSearch";
            // 
            // btnShowSearch
            // 
            this.btnShowSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnShowSearch, "btnShowSearch");
            this.btnShowSearch.FlatAppearance.BorderSize = 0;
            this.btnShowSearch.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnShowSearch.Name = "btnShowSearch";
            this.btnShowSearch.UseVisualStyleBackColor = false;
            this.btnShowSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMinmaize
            // 
            this.btnMinmaize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnMinmaize, "btnMinmaize");
            this.btnMinmaize.FlatAppearance.BorderSize = 0;
            this.btnMinmaize.ForeColor = System.Drawing.Color.Black;
            this.btnMinmaize.Name = "btnMinmaize";
            this.btnMinmaize.UseVisualStyleBackColor = false;
            this.btnMinmaize.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnResize
            // 
            this.btnResize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnResize, "btnResize");
            this.btnResize.FlatAppearance.BorderSize = 0;
            this.btnResize.ForeColor = System.Drawing.Color.White;
            this.btnResize.Name = "btnResize";
            this.btnResize.UseVisualStyleBackColor = false;
            this.btnResize.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtPAge
            // 
            resources.ApplyResources(this.txtPAge, "txtPAge");
            this.txtPAge.Name = "txtPAge";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtPaidUp
            // 
            resources.ApplyResources(this.txtPaidUp, "txtPaidUp");
            this.txtPaidUp.Name = "txtPaidUp";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtRest
            // 
            resources.ApplyResources(this.txtRest, "txtRest");
            this.txtRest.Name = "txtRest";
            // 
            // dtEX
            // 
            resources.ApplyResources(this.dtEX, "dtEX");
            this.dtEX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEX.Name = "dtEX";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // dtReEX
            // 
            resources.ApplyResources(this.dtReEX, "dtReEX");
            this.dtReEX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtReEX.Name = "dtReEX";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.txtPhone.Name = "txtPhone";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtDone
            // 
            resources.ApplyResources(this.txtDone, "txtDone");
            this.txtDone.Name = "txtDone";
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.btnClearData);
            this.HomePanel.Controls.Add(this.dataView);
            this.HomePanel.Controls.Add(this.txtPName);
            this.HomePanel.Controls.Add(this.btnClear);
            this.HomePanel.Controls.Add(this.btnEdit);
            this.HomePanel.Controls.Add(this.btnSave);
            this.HomePanel.Controls.Add(this.txtDone);
            this.HomePanel.Controls.Add(this.label10);
            this.HomePanel.Controls.Add(this.txtPhone);
            this.HomePanel.Controls.Add(this.label9);
            this.HomePanel.Controls.Add(this.label8);
            this.HomePanel.Controls.Add(this.dtReEX);
            this.HomePanel.Controls.Add(this.label7);
            this.HomePanel.Controls.Add(this.dtEX);
            this.HomePanel.Controls.Add(this.txtRest);
            this.HomePanel.Controls.Add(this.label6);
            this.HomePanel.Controls.Add(this.txtPaidUp);
            this.HomePanel.Controls.Add(this.label5);
            this.HomePanel.Controls.Add(this.txtPAge);
            this.HomePanel.Controls.Add(this.label4);
            this.HomePanel.Controls.Add(this.label3);
            resources.ApplyResources(this.HomePanel, "HomePanel");
            this.HomePanel.Name = "HomePanel";
            // 
            // btnClearData
            // 
            this.btnClearData.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnClearData, "btnClearData");
            this.btnClearData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.UseVisualStyleBackColor = false;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // dataView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dataView, "dataView");
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataView.RowTemplate.Height = 33;
            // 
            // txtPName
            // 
            resources.ApplyResources(this.txtPName, "txtPName");
            this.txtPName.Name = "txtPName";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinmaize;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnShowSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPaidUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRest;
        private System.Windows.Forms.DateTimePicker dtEX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtReEX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDone;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button btnClearData;
    }
}

