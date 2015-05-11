using MateuszChmielowskiLab2.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace MateuszChmielowskiLab2.Controller
{
    public static class FormMainController
    {   
        public static List<string> supplies = new List<string>{"Krzesło", "Stół", "Fotel"};

        public static void SaveToFile(DataGridView dataGridViewArrivals, string fileName)
        {
            if (dataGridViewArrivals.Rows.Count > 1)                                // jeśli są jakieś dane do zapisania
            {
                StreamWriter stream = new StreamWriter(fileName);                 // utworzenie i otwarcie strumienia pliku
                for (int i = 0; i < (dataGridViewArrivals.Rows.Count - 1); i++)     // iteracja po wierszach tabeli
                {   
                    for (int j = 0; j < dataGridViewArrivals.Columns.Count; j++)    // iteracja po kolumnach tabeli
                    {
                        if (j < dataGridViewArrivals.Columns.Count - 1)             // jesli to nie ostnia kolumna w tabeli
                            stream.Write(dataGridViewArrivals.Rows[i].Cells[j].Value.ToString() + ";"); // to dopisz średnik
                        else
                            stream.Write(dataGridViewArrivals.Rows[i].Cells[j].Value.ToString() + Environment.NewLine); // dopisz nową linię
                    }
                }
                stream.Close();                                                     // zamknij strumień do pliku
            }
        }

        public static void ReadFromFile(DataGridView dataGridViewArrivals, string fileName)
        {
            StreamReader stream = new StreamReader(fileName);     // utworzenie strumienia i otwarcie pliku (jeśli brak pliku wyjątek)
            string line;                                            // string do wczytywania linii z pliku
            bool dataRead = false;                                  // jeśli wczytano chociaż jeden wiersz to true 
            dataGridViewArrivals.Rows.Clear();
            while ((line = stream.ReadLine()) != null)              // dopóki coś jest odczytane z pliku
            {
                string[] columns = line.Split(';');                 // rozdzielenie stringa na podstringi w miejscu gdzie jest ;
                if (columns.Count() == 5)                           // jeśli poprawny format danych
                {
                    dataGridViewArrivals.Rows.Add(columns[0], columns[1], columns[2], columns[3], columns[4]);  // to wpisz do tabelki
                    dataRead = true;
                }
                else
                    throw new InvalidDataException("Nieprawidłowy format danych w pliku."); // w przeciwnym wypadku wyjątek
            }
            if (!dataRead)                                          // jeśli nie wczytano żadnego wiersza
            {
                throw new Exception("Nie wczytano żadnych danych.");
            }
            stream.Close();                                         // zamknięcie strumienia do pliku
        }

        public static void FilterData(string filter, int columnToFilter, DataGridView dataGridViewArrivals, int letters)
        {
            if (letters == 0)       // dane niefiltrowane
            {
                SaveToFile(dataGridViewArrivals, "niefiltrowaneDane.txt");
            }

            StreamReader stream = new StreamReader("niefiltrowaneDane.txt");     // utworzenie strumienia i otwarcie pliku (jeśli brak pliku wyjątek)
            string line;                                            // string do wczytywania linii z pliku
            dataGridViewArrivals.Rows.Clear();
            while ((line = stream.ReadLine()) != null)              // dopóki coś jest odczytane z pliku
            {
                string[] columns = line.Split(';');                 // rozdzielenie stringa na podstringi w miejscu gdzie jest ;
                if (columns.Count() == 5 && columns[columnToFilter].Contains(filter))                           // jeśli poprawny format danych
                {
                    dataGridViewArrivals.Rows.Add(columns[0], columns[1], columns[2], columns[3], columns[4]);  // to wpisz do tabelki
                }
            }
            stream.Close();                                         // zamknięcie strumienia do pliku
            
        }
        public static void AddRandomData(DataGridView dataGridViewArrivals)
        {
            Random random = new Random();
            int index = 0;
            string registrationNumber = "DW ";
            string supply = "";
            for (int i = 0; i < 4; i++)
            {
                registrationNumber += random.Next(1, 10);
            }
            index = random.Next(0, FormMainController.supplies.Count());
            Console.WriteLine(index.ToString());
            supply = FormMainController.supplies[index];
            dataGridViewArrivals.Invoke(new Action(() => dataGridViewArrivals.Rows.Add(dataGridViewArrivals.Rows.Count.ToString(), registrationNumber, supply, random.Next(1, 100), DateTime.Now.ToString("dd:MM:yyy"))));
        }

        internal static void GeneratePdfFile(string fileName, DataGridView dataTable, string dateFrom = null, string dateTo = null)
        {
            DateTime from = new DateTime();
            DateTime to = new DateTime();
            bool isFilterOn = false;
            // inicjalizacja dokumentu pdf, o rozmiarze papieru Letter, marginesach lewy,prawy, gorny, dolny: 10, 10, 25, 25
            Document pdfDocument = new Document(iTextSharp.text.PageSize.LETTER, 50, 50, 25, 25);
            // inicjalizacja obiektu IO o podanej nazwie i trybie create
            PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDocument, new FileStream(fileName, FileMode.Create));
            pdfDocument.Open(); // inicjalizacja otwarcie pliku pdf

            // utworzenie 2 czcionek
            iTextSharp.text.Font arial26 = FontFactory.GetFont(@"C:\WINDOWS\Fonts\arial.ttf", "iso-8859-2", 26, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font arial12 = FontFactory.GetFont(@"C:\WINDOWS\Fonts\arial.ttf", "iso-8859-2", 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //utworzenie paragrafu z obecna data, czasem i miejscem
            Paragraph paragraphDateTimePlace = new Paragraph(50, "Wrocław, " + DateTime.Now.Date.ToString("dd.MM.yyyy"), arial12);
            paragraphDateTimePlace.FirstLineIndent = 360;   // wciecie paragrafu
            pdfDocument.Add(paragraphDateTimePlace);        // dodanie paragrafu do dokumentu

            // utworzenie paragrafu tytulowego dla dokumentu, z wykorzystaniem utworzonej czcionki
            string temporary = "";
            if (!string.IsNullOrEmpty(dateFrom) && !string.IsNullOrEmpty(dateFrom))
            {
                temporary = " od " + dateFrom + " do " + dateTo;
                from = DateTime.ParseExact(dateFrom, "dd:MM:yyyy", null);
                to = DateTime.ParseExact(dateTo, "dd:MM:yyyy", null);
                isFilterOn = true;
            }
            Paragraph title = new Paragraph("Podsumowanie dostaw" + temporary, arial26);
            title.SpacingAfter = 50;
            pdfDocument.Add(title);         // dodanie paragrafu do dokumentu

            // utworzenie tabeli o 5 kolumnach
            PdfPTable pdfPTableOrder = new PdfPTable(5);
            pdfPTableOrder.SpacingBefore = 50;
            pdfPTableOrder.AddCell(new Phrase("Lp", arial12));              // utworzenie komorek tabeli tworzacych pierwszy wiersz
            pdfPTableOrder.AddCell(new Phrase("Nr rejestracyjny", arial12));
            pdfPTableOrder.AddCell(new Phrase("Towar", arial12));
            pdfPTableOrder.AddCell(new Phrase("Ilość", arial12));
            pdfPTableOrder.AddCell(new Phrase("Data", arial12));

            for (int i = 0; i < (dataTable.Rows.Count - 1); i++)     // iteracja po wierszach tabeli
            {
                if (isFilterOn)
                {
                    if (DateTime.ParseExact(dataTable.Rows[i].Cells[4].Value.ToString(), "dd:MM:yyyy", null) <= to && DateTime.ParseExact(dataTable.Rows[i].Cells[4].Value.ToString(), "dd:MM:yyyy", null) >= from)
                        for (int j = 0; j < dataTable.Columns.Count; j++)    // iteracja po kolumnach tabeli
                            pdfPTableOrder.AddCell(new Phrase(dataTable.Rows[i].Cells[j].Value.ToString(), arial12));
                }
                else
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)    // iteracja po kolumnach tabeli
                    {
                        pdfPTableOrder.AddCell(new Phrase(dataTable.Rows[i].Cells[j].Value.ToString(), arial12));
                    }
                }
            }

            pdfDocument.Add(pdfPTableOrder);    // dodanie tabeli do dokumentu
            pdfDocument.Close();                // zamkniecie dokumentu
            // otwarcie domyslnej przegladarki plikow pdf z otwartym utworzonym plikiem
            Process Proc = new Process();
            Proc.StartInfo = new ProcessStartInfo(fileName);
            Proc.Start();
        }
    }
}
