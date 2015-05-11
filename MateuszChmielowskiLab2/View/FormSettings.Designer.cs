namespace MateuszChmielowskiLab2.View
{
    partial class FormSettings
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
            this.buttonStartTime = new System.Windows.Forms.Button();
            this.buttonStopTime = new System.Windows.Forms.Button();
            this.numericUpDownTimerIntervalSetting = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewSupplies = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSupply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTimerIntervalSetting = new System.Windows.Forms.Label();
            this.labelProjtectedTimeOfArrival = new System.Windows.Forms.Label();
            this.progressBarProjectedTimeOfArrival = new System.Windows.Forms.ProgressBar();
            this.labelCurrentSupplies = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimerIntervalSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplies)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartTime
            // 
            this.buttonStartTime.Location = new System.Drawing.Point(3, 42);
            this.buttonStartTime.Name = "buttonStartTime";
            this.buttonStartTime.Size = new System.Drawing.Size(75, 23);
            this.buttonStartTime.TabIndex = 0;
            this.buttonStartTime.Text = "Start dostaw";
            this.buttonStartTime.UseVisualStyleBackColor = true;
            this.buttonStartTime.Click += new System.EventHandler(this.buttonStartTime_Click);
            // 
            // buttonStopTime
            // 
            this.buttonStopTime.Location = new System.Drawing.Point(83, 42);
            this.buttonStopTime.Name = "buttonStopTime";
            this.buttonStopTime.Size = new System.Drawing.Size(75, 23);
            this.buttonStopTime.TabIndex = 0;
            this.buttonStopTime.Text = "Stop dostaw";
            this.buttonStopTime.UseVisualStyleBackColor = true;
            this.buttonStopTime.Click += new System.EventHandler(this.buttonStopTime_Click);
            // 
            // numericUpDownTimerIntervalSetting
            // 
            this.numericUpDownTimerIntervalSetting.Location = new System.Drawing.Point(3, 16);
            this.numericUpDownTimerIntervalSetting.Name = "numericUpDownTimerIntervalSetting";
            this.numericUpDownTimerIntervalSetting.Size = new System.Drawing.Size(156, 20);
            this.numericUpDownTimerIntervalSetting.TabIndex = 3;
            this.numericUpDownTimerIntervalSetting.ValueChanged += new System.EventHandler(this.numericUpDownTimerIntervalSetting_ValueChanged);
            // 
            // dataGridViewSupplies
            // 
            this.dataGridViewSupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnSupply});
            this.dataGridViewSupplies.Location = new System.Drawing.Point(187, 76);
            this.dataGridViewSupplies.Name = "dataGridViewSupplies";
            this.dataGridViewSupplies.Size = new System.Drawing.Size(352, 150);
            this.dataGridViewSupplies.TabIndex = 4;
            this.dataGridViewSupplies.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplies_CellEndEdit);
            // 
            // columnId
            // 
            this.columnId.HeaderText = "Lp";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            // 
            // columnSupply
            // 
            this.columnSupply.HeaderText = "Towar";
            this.columnSupply.Name = "columnSupply";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonStartTime);
            this.panel1.Controls.Add(this.numericUpDownTimerIntervalSetting);
            this.panel1.Controls.Add(this.labelTimerIntervalSetting);
            this.panel1.Controls.Add(this.buttonStopTime);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 87);
            this.panel1.TabIndex = 5;
            // 
            // labelTimerIntervalSetting
            // 
            this.labelTimerIntervalSetting.AutoSize = true;
            this.labelTimerIntervalSetting.Location = new System.Drawing.Point(3, 0);
            this.labelTimerIntervalSetting.Name = "labelTimerIntervalSetting";
            this.labelTimerIntervalSetting.Size = new System.Drawing.Size(155, 13);
            this.labelTimerIntervalSetting.TabIndex = 2;
            this.labelTimerIntervalSetting.Text = "Interwał pojawiania się dostaw:";
            // 
            // labelProjtectedTimeOfArrival
            // 
            this.labelProjtectedTimeOfArrival.AutoSize = true;
            this.labelProjtectedTimeOfArrival.Location = new System.Drawing.Point(9, 9);
            this.labelProjtectedTimeOfArrival.Name = "labelProjtectedTimeOfArrival";
            this.labelProjtectedTimeOfArrival.Size = new System.Drawing.Size(255, 13);
            this.labelProjtectedTimeOfArrival.TabIndex = 9;
            this.labelProjtectedTimeOfArrival.Text = "Prognozowany czas pojawienia się kolejnej dostawy:";
            // 
            // progressBarProjectedTimeOfArrival
            // 
            this.progressBarProjectedTimeOfArrival.Location = new System.Drawing.Point(12, 25);
            this.progressBarProjectedTimeOfArrival.Maximum = 5;
            this.progressBarProjectedTimeOfArrival.Name = "progressBarProjectedTimeOfArrival";
            this.progressBarProjectedTimeOfArrival.Size = new System.Drawing.Size(528, 23);
            this.progressBarProjectedTimeOfArrival.Step = 1;
            this.progressBarProjectedTimeOfArrival.TabIndex = 8;
            // 
            // labelCurrentSupplies
            // 
            this.labelCurrentSupplies.AutoSize = true;
            this.labelCurrentSupplies.Location = new System.Drawing.Point(187, 60);
            this.labelCurrentSupplies.Name = "labelCurrentSupplies";
            this.labelCurrentSupplies.Size = new System.Drawing.Size(99, 13);
            this.labelCurrentSupplies.TabIndex = 2;
            this.labelCurrentSupplies.Text = "Zamówione towary:";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 249);
            this.Controls.Add(this.labelProjtectedTimeOfArrival);
            this.Controls.Add(this.progressBarProjectedTimeOfArrival);
            this.Controls.Add(this.labelCurrentSupplies);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewSupplies);
            this.Name = "FormSettings";
            this.Text = "Ustawienia aplikacji";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSettings_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimerIntervalSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplies)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartTime;
        private System.Windows.Forms.Button buttonStopTime;
        private System.Windows.Forms.NumericUpDown numericUpDownTimerIntervalSetting;
        private System.Windows.Forms.DataGridView dataGridViewSupplies;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTimerIntervalSetting;
        private System.Windows.Forms.Label labelProjtectedTimeOfArrival;
        private System.Windows.Forms.ProgressBar progressBarProjectedTimeOfArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSupply;
        private System.Windows.Forms.Label labelCurrentSupplies;
    }
}