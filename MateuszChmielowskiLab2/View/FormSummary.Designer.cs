namespace MateuszChmielowskiLab2.View
{
    partial class FormSummary
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
            this.buttonGeneratePdf = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.textBoxPdfFileName = new System.Windows.Forms.TextBox();
            this.labelPdfFileName = new System.Windows.Forms.Label();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.checkBoxDateFiltr = new System.Windows.Forms.CheckBox();
            this.labelPdf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGeneratePdf
            // 
            this.buttonGeneratePdf.Location = new System.Drawing.Point(218, 169);
            this.buttonGeneratePdf.Name = "buttonGeneratePdf";
            this.buttonGeneratePdf.Size = new System.Drawing.Size(200, 23);
            this.buttonGeneratePdf.TabIndex = 2;
            this.buttonGeneratePdf.Text = "Generuj PDF";
            this.buttonGeneratePdf.UseVisualStyleBackColor = true;
            this.buttonGeneratePdf.Click += new System.EventHandler(this.buttonGeneratePdf_Click);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Enabled = false;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(12, 139);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Enabled = false;
            this.dateTimePickerTo.Location = new System.Drawing.Point(218, 139);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 0;
            // 
            // textBoxPdfFileName
            // 
            this.textBoxPdfFileName.Location = new System.Drawing.Point(12, 57);
            this.textBoxPdfFileName.Name = "textBoxPdfFileName";
            this.textBoxPdfFileName.Size = new System.Drawing.Size(200, 20);
            this.textBoxPdfFileName.TabIndex = 1;
            // 
            // labelPdfFileName
            // 
            this.labelPdfFileName.AutoSize = true;
            this.labelPdfFileName.Location = new System.Drawing.Point(12, 41);
            this.labelPdfFileName.Name = "labelPdfFileName";
            this.labelPdfFileName.Size = new System.Drawing.Size(96, 13);
            this.labelPdfFileName.TabIndex = 3;
            this.labelPdfFileName.Text = "Podaj nazwę pliku:";
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Location = new System.Drawing.Point(9, 119);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(51, 13);
            this.labelDateFrom.TabIndex = 3;
            this.labelDateFrom.Text = "Dane od:";
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Location = new System.Drawing.Point(215, 119);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(51, 13);
            this.labelDateTo.TabIndex = 3;
            this.labelDateTo.Text = "Dane do:";
            // 
            // checkBoxDateFiltr
            // 
            this.checkBoxDateFiltr.AutoSize = true;
            this.checkBoxDateFiltr.Location = new System.Drawing.Point(12, 83);
            this.checkBoxDateFiltr.Name = "checkBoxDateFiltr";
            this.checkBoxDateFiltr.Size = new System.Drawing.Size(215, 17);
            this.checkBoxDateFiltr.TabIndex = 4;
            this.checkBoxDateFiltr.Text = "Filtruj po terminie pojawienia się dostawy";
            this.checkBoxDateFiltr.UseVisualStyleBackColor = true;
            this.checkBoxDateFiltr.CheckedChanged += new System.EventHandler(this.checkBoxDateFiltr_CheckedChanged);
            // 
            // labelPdf
            // 
            this.labelPdf.AutoSize = true;
            this.labelPdf.Location = new System.Drawing.Point(215, 60);
            this.labelPdf.Name = "labelPdf";
            this.labelPdf.Size = new System.Drawing.Size(25, 13);
            this.labelPdf.TabIndex = 3;
            this.labelPdf.Text = ".pdf";
            // 
            // FormSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 229);
            this.Controls.Add(this.checkBoxDateFiltr);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.labelPdf);
            this.Controls.Add(this.labelPdfFileName);
            this.Controls.Add(this.buttonGeneratePdf);
            this.Controls.Add(this.textBoxPdfFileName);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Name = "FormSummary";
            this.Text = "Podsumowanie dostaw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGeneratePdf;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.TextBox textBoxPdfFileName;
        private System.Windows.Forms.Label labelPdfFileName;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.CheckBox checkBoxDateFiltr;
        private System.Windows.Forms.Label labelPdf;
    }
}