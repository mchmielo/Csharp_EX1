using MateuszChmielowskiLab2.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MateuszChmielowskiLab2.View
{
    public partial class FormSettings : Form
    {

        public static int timerInterval { get; set;}        // zmienna określająca co jaki interwał czasowy uruchomione zostanie zdarzenie timera w FormMain
        private static System.Timers.Timer oneSecondTimer;  // timer aktualizujący progressBarProjectedTimeOfArrival co 1 sekundę
        private bool dontRunNumericUpDownIntervalSettingEventHandler = true;    // zmienna mówi czy przerwać obsługę zdarzeń pola do wprowadzania interwału timera

        public FormSettings()
        {
            InitializeComponent();
            UpdateDataGridViewSupply();                         // wczytanie danych z FormMainController.supplies do tabeli
            oneSecondTimer = new System.Timers.Timer(1000);     // timer z interwałem czasowym 5s
            oneSecondTimer.Elapsed += new System.Timers.ElapsedEventHandler(EverySecondEvent);   // dodanie zdarzenia co każde 5 sekund                           // włączenie timera
            progressBarProjectedTimeOfArrival.Maximum = timerInterval - 1;  // ustawienie zakresu progressBara
            numericUpDownTimerIntervalSetting.Value = timerInterval;        // atualizacja wartości czasu interwału timera w FormMain  
            dontRunNumericUpDownIntervalSettingEventHandler = false;        // włączenie obsługi zdarzeń
        }
        /// <summary>
        /// Statyczny konstruktor ustawia pole statyczne timerInterwal w momencie tworzenia klasy.
        /// </summary>
        static FormSettings()
        {
            timerInterval = 5;  
        }
        /// <summary>
        /// Metoda zostawje wywaołana, gdy zmieniony jest interwał czasowy timera w FormMain.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownTimerIntervalSetting_ValueChanged(object sender, EventArgs e)
        {
            if (!dontRunNumericUpDownIntervalSettingEventHandler)
            {
                oneSecondTimer.Stop();              // zatrzymanie obu timerów
                FormMain.fiveSecondsTimer.Stop();
                progressBarProjectedTimeOfArrival.Value = 0;    // ustawienie paska postępu na 0
                timerInterval = (int)numericUpDownTimerIntervalSetting.Value;   // ustawienie interwału timera FormMain na wartość numericUpDownTimerIntervalSetting
                FormMain.fiveSecondsTimer.Interval = timerInterval * 1000;        // przeskalowanie interwału na milisekundy
                progressBarProjectedTimeOfArrival.Maximum = timerInterval - 1;  // przeskalowanie paska postępu
                oneSecondTimer.Start();             // wystartowanie obu timerów
                FormMain.fiveSecondsTimer.Start();
            }
        }
        /// <summary>
        /// Metoda aktualizuje co sekundę pasek postępu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EverySecondEvent(object sender, ElapsedEventArgs e)
        {
            if (progressBarProjectedTimeOfArrival.Value == timerInterval - 1)
                progressBarProjectedTimeOfArrival.Invoke(new Action(() => progressBarProjectedTimeOfArrival.Value = 0));
            else if (progressBarProjectedTimeOfArrival.Value < timerInterval - 1)
                progressBarProjectedTimeOfArrival.Invoke(new Action(() => progressBarProjectedTimeOfArrival.Value += 1));             
        }
        /// <summary>
        /// Metoda zatrzymuje timer po zamknięciu okna.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            oneSecondTimer.Stop();
            dontRunNumericUpDownIntervalSettingEventHandler = true; // wyłączenie obsługi zdarzeń
        }
        /// <summary>
        /// Metoda startująca obydwa timery.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartTime_Click(object sender, EventArgs e)
        {
            oneSecondTimer.Start();
            FormMain.fiveSecondsTimer.Start();
        }
        /// <summary>
        /// Metoda zatrzymująca obydwa timery.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopTime_Click(object sender, EventArgs e)
        {
            oneSecondTimer.Stop();
            FormMain.fiveSecondsTimer.Stop();
            progressBarProjectedTimeOfArrival.Value = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        private void UpdateDataGridViewSupply()
        {
            dataGridViewSupplies.Rows.Clear();
            for (int i = 0; i < FormMainController.supplies.Count(); i++)
			{
                dataGridViewSupplies.Rows.Add(dataGridViewSupplies.Rows.Count.ToString(), FormMainController.supplies[i]);
			}
            
        }
        /// <summary>
        /// Metoda wywoływana poprzez edycję tabeli dataGridViewSupplies.
        /// Zmienione/dodane wiersze aktualizuje w FormMainController.supplies.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewSupplies_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGridViewSupplies.Rows.Count - 2)
            {
                int index = int.Parse(dataGridViewSupplies.Rows[e.RowIndex].Cells[0].Value.ToString()) - 1;
                FormMainController.supplies[index] = dataGridViewSupplies.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else
            {
                FormMainController.supplies.Add(dataGridViewSupplies.Rows[e.RowIndex].Cells[1].Value.ToString());
                dataGridViewSupplies.Rows[e.RowIndex].Cells[0].Value = dataGridViewSupplies.Rows.Count - 1;
            }
        }
    }
}
