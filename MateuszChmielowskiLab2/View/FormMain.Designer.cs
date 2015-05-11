namespace MateuszChmielowskiLab2
{
    partial class FormMain
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
            this.buttonNew = new System.Windows.Forms.Button();
            this.textBoxRegistrationNumber = new System.Windows.Forms.TextBox();
            this.textBoxSupply = new System.Windows.Forms.TextBox();
            this.labelRegistrationNumber = new System.Windows.Forms.Label();
            this.labelSupply = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.dataGridViewArrivals = new System.Windows.Forms.DataGridView();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.textBoxFilterAmount = new System.Windows.Forms.TextBox();
            this.textBoxFilterSupply = new System.Windows.Forms.TextBox();
            this.textBoxFilterRegistrationNumber = new System.Windows.Forms.TextBox();
            this.textBoxFilterId = new System.Windows.Forms.TextBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.textBoxFilterDate = new System.Windows.Forms.TextBox();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSupply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrivals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(12, 12);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(103, 37);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Nowy przyjazd";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // textBoxRegistrationNumber
            // 
            this.textBoxRegistrationNumber.Location = new System.Drawing.Point(121, 28);
            this.textBoxRegistrationNumber.Name = "textBoxRegistrationNumber";
            this.textBoxRegistrationNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistrationNumber.TabIndex = 1;
            this.textBoxRegistrationNumber.Text = "DW 6669";
            // 
            // textBoxSupply
            // 
            this.textBoxSupply.Location = new System.Drawing.Point(227, 28);
            this.textBoxSupply.Name = "textBoxSupply";
            this.textBoxSupply.Size = new System.Drawing.Size(309, 20);
            this.textBoxSupply.TabIndex = 1;
            this.textBoxSupply.Text = "Krzesła";
            // 
            // labelRegistrationNumber
            // 
            this.labelRegistrationNumber.AutoSize = true;
            this.labelRegistrationNumber.Location = new System.Drawing.Point(118, 12);
            this.labelRegistrationNumber.Name = "labelRegistrationNumber";
            this.labelRegistrationNumber.Size = new System.Drawing.Size(79, 13);
            this.labelRegistrationNumber.TabIndex = 2;
            this.labelRegistrationNumber.Text = "Nr rejestracyjny";
            // 
            // labelSupply
            // 
            this.labelSupply.AutoSize = true;
            this.labelSupply.Location = new System.Drawing.Point(224, 12);
            this.labelSupply.Name = "labelSupply";
            this.labelSupply.Size = new System.Drawing.Size(37, 13);
            this.labelSupply.TabIndex = 2;
            this.labelSupply.Text = "Towar";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(539, 12);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(29, 13);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Ilość";
            // 
            // dataGridViewArrivals
            // 
            this.dataGridViewArrivals.AllowUserToOrderColumns = true;
            this.dataGridViewArrivals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArrivals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArrivals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrivals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnRegistrationNumber,
            this.columnSupply,
            this.columnAmount,
            this.columnDate});
            this.dataGridViewArrivals.Location = new System.Drawing.Point(12, 90);
            this.dataGridViewArrivals.Name = "dataGridViewArrivals";
            this.dataGridViewArrivals.Size = new System.Drawing.Size(655, 222);
            this.dataGridViewArrivals.TabIndex = 3;
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(542, 28);
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(125, 20);
            this.numericUpDownAmount.TabIndex = 4;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(12, 318);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(103, 23);
            this.buttonSaveToFile.TabIndex = 5;
            this.buttonSaveToFile.Text = "Zapisz do pliku";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(121, 318);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(103, 23);
            this.buttonReadFile.TabIndex = 5;
            this.buttonReadFile.Text = "Odczytaj z pliku";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // textBoxFilterAmount
            // 
            this.textBoxFilterAmount.Location = new System.Drawing.Point(424, 64);
            this.textBoxFilterAmount.Name = "textBoxFilterAmount";
            this.textBoxFilterAmount.Size = new System.Drawing.Size(116, 20);
            this.textBoxFilterAmount.TabIndex = 1;
            this.textBoxFilterAmount.TextChanged += new System.EventHandler(this.textBoxFilterAmount_TextChanged);
            // 
            // textBoxFilterSupply
            // 
            this.textBoxFilterSupply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterSupply.Location = new System.Drawing.Point(301, 64);
            this.textBoxFilterSupply.Name = "textBoxFilterSupply";
            this.textBoxFilterSupply.Size = new System.Drawing.Size(116, 20);
            this.textBoxFilterSupply.TabIndex = 1;
            this.textBoxFilterSupply.TextChanged += new System.EventHandler(this.textBoxFilterSupply_TextChanged);
            // 
            // textBoxFilterRegistrationNumber
            // 
            this.textBoxFilterRegistrationNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterRegistrationNumber.Location = new System.Drawing.Point(178, 64);
            this.textBoxFilterRegistrationNumber.Name = "textBoxFilterRegistrationNumber";
            this.textBoxFilterRegistrationNumber.Size = new System.Drawing.Size(116, 20);
            this.textBoxFilterRegistrationNumber.TabIndex = 1;
            this.textBoxFilterRegistrationNumber.TextChanged += new System.EventHandler(this.textBoxFilterRegistrationNumber_TextChanged);
            // 
            // textBoxFilterId
            // 
            this.textBoxFilterId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilterId.Location = new System.Drawing.Point(55, 64);
            this.textBoxFilterId.Name = "textBoxFilterId";
            this.textBoxFilterId.Size = new System.Drawing.Size(116, 20);
            this.textBoxFilterId.TabIndex = 1;
            this.textBoxFilterId.TextChanged += new System.EventHandler(this.textBoxFilterId_TextChanged);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(230, 318);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(103, 23);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "Ustawienia";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonSummary
            // 
            this.buttonSummary.Location = new System.Drawing.Point(339, 318);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(103, 23);
            this.buttonSummary.TabIndex = 5;
            this.buttonSummary.Text = "Podsumowanie";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // textBoxFilterDate
            // 
            this.textBoxFilterDate.Location = new System.Drawing.Point(547, 64);
            this.textBoxFilterDate.Name = "textBoxFilterDate";
            this.textBoxFilterDate.Size = new System.Drawing.Size(116, 20);
            this.textBoxFilterDate.TabIndex = 1;
            this.textBoxFilterDate.TextChanged += new System.EventHandler(this.textBoxFilterDate_TextChanged);
            // 
            // columnId
            // 
            this.columnId.HeaderText = "Lp";
            this.columnId.Name = "columnId";
            // 
            // columnRegistrationNumber
            // 
            this.columnRegistrationNumber.HeaderText = "Nr rejestracyjny";
            this.columnRegistrationNumber.Name = "columnRegistrationNumber";
            // 
            // columnSupply
            // 
            this.columnSupply.HeaderText = "Towar";
            this.columnSupply.Name = "columnSupply";
            // 
            // columnAmount
            // 
            this.columnAmount.HeaderText = "Ilość";
            this.columnAmount.Name = "columnAmount";
            // 
            // columnDate
            // 
            this.columnDate.HeaderText = "Data";
            this.columnDate.Name = "columnDate";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 356);
            this.Controls.Add(this.textBoxFilterId);
            this.Controls.Add(this.textBoxFilterRegistrationNumber);
            this.Controls.Add(this.textBoxFilterSupply);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.textBoxFilterDate);
            this.Controls.Add(this.textBoxFilterAmount);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.dataGridViewArrivals);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelSupply);
            this.Controls.Add(this.labelRegistrationNumber);
            this.Controls.Add(this.textBoxSupply);
            this.Controls.Add(this.textBoxRegistrationNumber);
            this.Controls.Add(this.buttonNew);
            this.Name = "FormMain";
            this.Text = "Rejestr przyjazdów";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrivals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textBoxRegistrationNumber;
        private System.Windows.Forms.TextBox textBoxSupply;
        private System.Windows.Forms.Label labelRegistrationNumber;
        private System.Windows.Forms.Label labelSupply;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.DataGridView dataGridViewArrivals;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.TextBox textBoxFilterAmount;
        private System.Windows.Forms.TextBox textBoxFilterSupply;
        private System.Windows.Forms.TextBox textBoxFilterRegistrationNumber;
        private System.Windows.Forms.TextBox textBoxFilterId;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonSummary;
        private System.Windows.Forms.TextBox textBoxFilterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRegistrationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSupply;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
    }
}

