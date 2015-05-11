using MateuszChmielowskiLab2.Controller;
using MateuszChmielowskiLab2.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace MateuszChmielowskiLab2
{   
    public partial class FormMain : Form
    {   
        int filterLetterCount = 0;      // zmienna zlicza ile liter zostało wpisanych we wszystkie pola filtrów
        public static System.Timers.Timer fiveSecondsTimer { get; set; }    // statyczny timer, domyślnie 5 sekundowy

        public FormMain()
        {
            InitializeComponent();
            fiveSecondsTimer = new System.Timers.Timer(5000);   // timer z interwałem czasowym 5s
            fiveSecondsTimer.Elapsed += new System.Timers.ElapsedEventHandler(EveryFiveSecondsEvent);   // dodanie zdarzenia co każde 5 sekund
        //    fiveSecondsTimer.Start();                    // włączenie timera
        }
        /// <summary>
        /// Funkcja przepisuje dane z formularza do tabeli po naciśnięciu przycisku Nowy przyjazd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNew_Click(object sender, EventArgs e)
        {
            dataGridViewArrivals.Rows.Add(dataGridViewArrivals.Rows.Count.ToString(),textBoxRegistrationNumber.Text, textBoxSupply.Text, numericUpDownAmount.Value.ToString(), DateTime.Now.ToString("dd:MM:yyy"));
        }
        /// <summary>
        /// Metoda wywoływana przyciskiem buttonSaveToFile.
        /// Metoda próbuje zapisać wszystkie pola tabeli do pliku test.txt.
        /// W przypadku, gdy to się nie uda zostanie wyświetlone okienko z błędem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                FormMainController.SaveToFile(dataGridViewArrivals, "test.txt");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }        
        }
        /// <summary>
        /// Metoda wywoływana przyciskiem buttonReadFile.
        /// Metoda próbuje odczytać dane z pliku test.txt. Wyrzuci błąd jeśli
        /// nie uda się otworzyć pliku, jeśli brak danych lub jeśli dane będą błędne.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                FormMainController.ReadFromFile(dataGridViewArrivals, "test.txt");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        /// <summary>
        /// Metoda wywoływana w momencie wpisania znaku w textBoxFilterId.
        /// Metoda uruchamia funkcję FilterData, przekazując jej która kolumna ma być filtrowana,
        /// tekst do filtrowania, referencję do tabeli oraz liczbę wpisanych liter w filtrach.
        /// Na końcu globalna zmienna filterLetterCount jest aktualizowana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFilterId_TextChanged(object sender, EventArgs e)
        {
            int countFilterLetters = textBoxFilterId.Text.Count() + textBoxFilterSupply.Text.Count() + textBoxFilterRegistrationNumber.Text.Count() + textBoxFilterAmount.Text.Count() + textBoxFilterDate.Text.Count();
            try
            {
                FormMainController.FilterData(this.textBoxFilterId.Text, 0, dataGridViewArrivals, filterLetterCount);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            filterLetterCount = countFilterLetters;
        }
        /// <summary>
        /// Metoda wywoływana w momencie wpisania znaku w textBoxFilterRegistrationNumber.
        /// Metoda uruchamia funkcję FilterData, przekazując jej która kolumna ma być filtrowana,
        /// tekst do filtrowania, referencję do tabeli oraz liczbę wpisanych liter w filtrach.
        /// Na końcu globalna zmienna filterLetterCount jest aktualizowana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFilterRegistrationNumber_TextChanged(object sender, EventArgs e)
        {
            int countFilterLetters = textBoxFilterId.Text.Count() + textBoxFilterSupply.Text.Count() + textBoxFilterRegistrationNumber.Text.Count() + textBoxFilterAmount.Text.Count() + textBoxFilterDate.Text.Count();
            try
            {
                FormMainController.FilterData(this.textBoxFilterRegistrationNumber.Text, 1, dataGridViewArrivals, filterLetterCount);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            filterLetterCount = countFilterLetters;
        }
        /// <summary>
        /// Metoda wywoływana w momencie wpisania znaku w textBoxFilterSupply.
        /// Metoda uruchamia funkcję FilterData, przekazując jej która kolumna ma być filtrowana,
        /// tekst do filtrowania, referencję do tabeli oraz liczbę wpisanych liter w filtrach.
        /// Na końcu globalna zmienna filterLetterCount jest aktualizowana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFilterSupply_TextChanged(object sender, EventArgs e)
        {
            int countFilterLetters = textBoxFilterId.Text.Count() + textBoxFilterSupply.Text.Count() + textBoxFilterRegistrationNumber.Text.Count() + textBoxFilterAmount.Text.Count() + textBoxFilterDate.Text.Count();
            try
            {
                FormMainController.FilterData(this.textBoxFilterSupply.Text, 2, dataGridViewArrivals, filterLetterCount);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            filterLetterCount = countFilterLetters;
        }
        /// <summary>
        /// Metoda wywoływana w momencie wpisania znaku w textBoxFilterAmount.
        /// Metoda uruchamia funkcję FilterData, przekazując jej która kolumna ma być filtrowana,
        /// tekst do filtrowania, referencję do tabeli oraz liczbę wpisanych liter w filtrach.
        /// Na końcu globalna zmienna filterLetterCount jest aktualizowana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFilterAmount_TextChanged(object sender, EventArgs e)
        {
            int countFilterLetters = textBoxFilterId.Text.Count() + textBoxFilterSupply.Text.Count() + textBoxFilterRegistrationNumber.Text.Count() + textBoxFilterAmount.Text.Count() + textBoxFilterDate.Text.Count();
            try
            {
                FormMainController.FilterData(this.textBoxFilterAmount.Text, 3, dataGridViewArrivals, filterLetterCount);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            filterLetterCount = countFilterLetters;
        }
        /// <summary>
        /// Metoda wywoływana w momencie wpisania znaku w textBoxFilterDate.
        /// Metoda uruchamia funkcję FilterData, przekazując jej która kolumna ma być filtrowana,
        /// tekst do filtrowania, referencję do tabeli oraz liczbę wpisanych liter w filtrach.
        /// Na końcu globalna zmienna filterLetterCount jest aktualizowana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFilterDate_TextChanged(object sender, EventArgs e)
        {
            int countFilterLetters = textBoxFilterId.Text.Count() + textBoxFilterSupply.Text.Count() + textBoxFilterRegistrationNumber.Text.Count() + textBoxFilterAmount.Text.Count() + textBoxFilterDate.Text.Count();
            try
            {
                FormMainController.FilterData(this.textBoxFilterDate.Text, 4, dataGridViewArrivals, filterLetterCount);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            filterLetterCount = countFilterLetters;
        }
        /// <summary>
        /// Metoda wywoływana co interwał czasu ustawiony w FormSettings.timerInterval. Wywołuje funkcję AddRandomData, która dodaje
        /// losowe wartości do tabeli.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EveryFiveSecondsEvent(object sender, ElapsedEventArgs e)
        {
            FormMainController.AddRandomData(this.dataGridViewArrivals);
        }
        
        /// <summary>
        /// Metoda tworzy i otwiera nowe okno dialogowe ustawień.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.ShowDialog();
        }
        /// <summary>
        /// Metoda tworzy i otwiera nowe okno z podsumowaniem.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSummary_Click(object sender, EventArgs e)
        {
            FormSummary formSummary = new FormSummary(dataGridViewArrivals);
            formSummary.Show();
            
        }

        
    }
}
