using MateuszChmielowskiLab2.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateuszChmielowskiLab2.View
{
    public partial class FormSummary : Form
    {
        private DataGridView suppliesFromFormMain;  // przekazana od FormMain tabela z danymi
        public FormSummary(DataGridView dataGridViewArrivals)
        {
            InitializeComponent();
            dateTimePickerTo.MaxDate = DateTime.Today;
            dateTimePickerFrom.MaxDate = DateTime.Today;  
            suppliesFromFormMain = dataGridViewArrivals;
        }
        /// <summary>
        /// Jeśli checkBox zaznaczony wtedy metoda włącza możliwość wyboru dat, w przeciwnym wypadku wyłącza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxDateFiltr_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDateFiltr.Checked)
            {
                dateTimePickerFrom.Enabled = true;
                dateTimePickerTo.Enabled = true;
            }
            else
            {
                dateTimePickerFrom.Enabled = false;
                dateTimePickerTo.Enabled = false;
            }
        }
        /// <summary>
        /// Metoda sprawdza czy odpowiednie pola są zaznaczone oraz czy zakresy dat są poprawne,
        /// a następnie wywołuje metodę generującą pdf.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGeneratePdf_Click(object sender, EventArgs e)
        {
            if (checkBoxDateFiltr.Checked && dateTimePickerTo.Value < dateTimePickerFrom.Value)
            {
                MessageBox.Show("Data końcowa musi być co najmniej równa początkowej.");
            }
            else if (string.IsNullOrEmpty(textBoxPdfFileName.Text))
            {
                MessageBox.Show("Należy wprowadzić nazwę pliku.");
            }
            else
            {
                try
                {
                    if (checkBoxDateFiltr.Checked)
                        FormMainController.GeneratePdfFile(textBoxPdfFileName.Text, suppliesFromFormMain, dateTimePickerFrom.Value.ToString("dd:MM:yyyy"), dateTimePickerTo.Value.ToString("dd:MM:yyyy"));
                    else
                        FormMainController.GeneratePdfFile(textBoxPdfFileName.Text, suppliesFromFormMain);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
