﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;


namespace SDSY
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.SetItemChecked(3, true);
            SDS.Select();
            if (Properties.Settings.Default.sciezka_odczytu_se.Count() > 4)
                sciezka_zaczytania.Text = Properties.Settings.Default.sciezka_odczytu_se;
            else
                sciezka_zaczytania.Text = Directory.GetCurrentDirectory() + (char)92 + "SDS";
            if (Properties.Settings.Default.sciezka_zapisu_se.Count() > 4)
                sciezka_zapisu.Text = Properties.Settings.Default.sciezka_zapisu_se;
            else
                sciezka_zapisu.Text = Directory.GetCurrentDirectory() + (char)92 + "SDSP";

        }
        
        string delimiter;
        public static int progress = 0;
        string[] pliki;
        string[] nazwy;
        int nr_nazwy = 0;
        public static short przerwanie = 0;

        private void start_Click(object sender, EventArgs e)
        {
            
            progress = 0;
            progressBar1.Value = 0;
            if (backgroundWorker1.IsBusy == false && nazwy != null)
            {
                if (!backgroundWorker2.IsBusy) backgroundWorker2.RunWorkerAsync();
                backgroundWorker1.RunWorkerAsync();
            }
            else
                MessageBox.Show("Program juz dziala lub nie zaczytano plików");
        }

        private void Wczytaj_Click(object sender, EventArgs e)
        {
            pliki = Directory.GetFiles(sciezka_zaczytania.Text, "*.csv");
            nazwy_pobranie();
            if (nazwy != null)
            {
                this.InvokeIfRequired((value) => progressBar1.Maximum = value, nazwy.Length - 1);
                tabControl1.SelectTab(1);
            }
            else
                MessageBox.Show("Brak plików do wczytania");
            
        }
        
        public void Rozdzielanie_danych(List<string> dane)
        {
            string[] dane_podzielone;
            char[] delimiter = new char[2] { ',', 'e' };
            
            List<string> dane_wszystkie = new List<string>();
            int ilosc_kolumn = 2;
            foreach (string item in dane)
            {
                dane_podzielone = item.Split(delimiter);
                foreach (string item2 in dane_podzielone)
                {
                    dane_wszystkie.Add(item2);
                }
                ilosc_kolumn = dane_podzielone.Length;
                dane_podzielone = null;
            }
            Konwersja_na_int(dane_wszystkie, ilosc_kolumn);
            dane_wszystkie.Clear();
        }
        
        private void Konwersja_na_int(List<string> dane, int ilosc_kolumn)
        {
            List<double> dane_int = new List<double>();
            for (int i = 0; i < dane.Count; i++)
            {
                string temp2 = null;
                for (int j = 0; j < dane[i].Length; j++)
                {
                    if (dane[i][j] == '.')
                        temp2 += ',';
                    else
                        temp2 += dane[i][j];
                }
                try
                {
                    dane_int.Add(Convert.ToDouble(temp2));
                }
                catch(Exception e)
                {

                }
            }   
            bool zaznaczone = false;
            string onoff = null;

            if (CSV.Checked)
            {
                ilosc_kolumn /= 2;
                dostosowanie_CSV(ref dane_int);
            }
            progress2 = 0;
            this.InvokeIfRequired((value) => progressBar2.Maximum = value, dane_int.Count / ilosc_kolumn);
            this.InvokeIfRequired((value) => onoff = Usrednianie.Text, 0);
            if (onoff == "Wł")
            {
                this.InvokeIfRequired((value) => progressBar2.Maximum = value, dane_int.Count / ilosc_kolumn / (int)ilosc_probek.Value);
                zageszczenie(ref dane_int, ilosc_kolumn);

            }
            this.InvokeIfRequired((value) => zaznaczone = Rodzaj_zapisu.GetItemChecked(1), 0);

            if (zaznaczone) zapis_do_csv(nazwy[nr_nazwy], dane_int, ilosc_kolumn, Properties.Settings.Default.sciezka_zapisu_se);

            this.InvokeIfRequired((value) => zaznaczone = Rodzaj_zapisu.GetItemChecked(0), 0);
            zapis_xlsx zapis_Xlsx = new zapis_xlsx();
            if (zaznaczone)  zapis_Xlsx.zapis2(nazwy[nr_nazwy], dane_int, ilosc_kolumn, Properties.Settings.Default.sciezka_zapisu_se);
            progress2= dane_int.Count / ilosc_kolumn / (int)ilosc_probek.Value;
            progress++;
            

            dane.Clear();
            
        }

        void dostosowanie_CSV(ref List<double> dane)
        {
            List<double> temp = new List<double>();
            for (int i = 0; i < dane.Count-2; i += 2)
            {
                if (dane[i + 1] != 0)
                    temp.Add(dane[i]*Math.Pow(10, dane[i + 1]));
                else
                    temp.Add(dane[i]);
            }
            dane = temp;
        }
        void nazwy_pobranie()
        {
            short poczatek = 0;
            for (int i = pliki[0].Length-1; i > 0; i--)
            {
                if (pliki[0][i] == (char)92)
                {
                    poczatek = (short)(i+1);
                    break;
                }
            }
            string temp = null;
            for (int i = 0; i < pliki.Length; i++)
            {
                for (int j = poczatek; j < pliki[i].Length - 3; j++)
                {
                    temp += pliki[i][j];
                }
            }
            nazwy = temp.Split('.');
            temp = null;
            foreach (var item in nazwy)
            {
                if (item.Length>1)
                temp += item + "\n";
            }
            this.InvokeIfRequired((value) => richTextBox1.Text = value, temp);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<string> wczytane_dane = new List<string>();
            nr_nazwy = 0;
            try
            {
                przerwanie = 0;
                foreach (string sciezka in pliki)
                {
                    if (przerwanie == 1)
                        break;
                    using (StreamReader plik = new StreamReader(sciezka))
                    {
                        while (!plik.EndOfStream)
                        {
                            wczytane_dane.Add(plik.ReadLine());
                        }
                        plik.Close();
                    }
                    wczytane_dane.RemoveAt(0);
                    wczytane_dane.RemoveAt(0);
                    Rozdzielanie_danych(wczytane_dane);
                    nr_nazwy++;
                    wczytane_dane.Clear();
                }  
            }
            finally
            {

                if (przerwanie == 1 && stop_button == false) MessageBox.Show("Zapis pliku '" + nazwy[nr_nazwy] + "' nie powiódł się. \nNależy ponownie uruchomić program, ale przed naciśnięciem start należy użyc Excell Killera");
                else if (przerwanie == 1 && stop_button == true) MessageBox.Show("Program został zatrzymany");
                else MessageBox.Show("Wszystko przerobione i zapisane");
                progress = 0;
                progress2 = 0;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        void zapis_do_csv(string name, List<double> dane, int ilosc_kolumn, string sciezka_zapisu)
        {
            try
           {
               using (StreamWriter plik = new StreamWriter(sciezka_zapisu + "/" + name + ".csv"))
               {
                    plik.WriteLine("Time" + delimiter + "CH1" + delimiter + "CH2");
                   for (int i = 0; i < dane.Count / 3 - 1; i++)
                   {
                       for(int j = 0; j < ilosc_kolumn; j++)
                       {
                           plik.Write(dane[i * ilosc_kolumn + j] + delimiter);
                       }
                       plik.WriteLine();
                   }
               }
           }
           catch (Exception)
           {
                MessageBox.Show("Zapis pliku " + nazwy[nr_nazwy] + " nie powiódł się");
           }
        }

        public void Rodzaj_zapisu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (checkedListBox1.CheckedItems.Count > 1)
            {
                checkedListBox1.SetItemChecked(1, false);
                checkedListBox1.SetItemChecked(2, false);
                checkedListBox1.SetItemChecked(3, false);
                checkedListBox1.SetItemChecked(0, false);
            };
            if (checkedListBox1.GetItemChecked(0))
                delimiter = "   ";
            else if (checkedListBox1.GetItemChecked(1))
                delimiter = ".";
            else if (checkedListBox1.GetItemChecked(2))
                delimiter = ":";
            else
                delimiter = ";";
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Process[] Excel = Process.GetProcessesByName("Excel");
            foreach (Process CurrentExcel in Excel)
            {
                CurrentExcel.Kill();
            }
        }

        public void zageszczenie(ref List<double> dane, int ilosc_kolumn)
        {
            
            List<double> zageszczone = new List<double>();
            double temp = 0;
            int minus = (int)dane[0];
            for (int i = 0; i < dane.Count - ilosc_probek.Value * ilosc_kolumn; i += ilosc_kolumn * (int)ilosc_probek.Value)
            {
                for (int j = 0; j < ilosc_kolumn; j++)
                {
                    for (int k = 0; k < ilosc_probek.Value; k++)
                    {

                        int a = (i + j + (k * ilosc_kolumn));
                        if (j != 0)
                            temp += dane[a];
                        else
                        {
                            temp += dane[a] - minus;
                        }
                    }
                    zageszczone.Add(temp / (int)ilosc_probek.Value);
                    temp = 0;
                }
            }
            dane = zageszczone;
        }

        private void Usrednianie_Click(object sender, EventArgs e)
        {
            if (Usrednianie.Text.ToString() == "Wł")
            {
                Usrednianie.Text = "Wył";
                Usrednianie.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                Usrednianie.Text = "Wł";
                Usrednianie.BackColor = System.Drawing.Color.SteelBlue;
            }
        }

        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SDS_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CSV_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void progressBar2_Click(object sender, EventArgs e)
        {

        }
        public static int progress2;
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                this.InvokeIfRequired((value) => progressBar1.Value = value, progress);
                this.InvokeIfRequired((value) => progressBar2.Value = value, progress2);
                System.Threading.Thread.Sleep(100);
            }
        }
        private void ilosc_probek_ValueChanged(object sender, EventArgs e)
        {

        }
        bool stop_button = false;
        private void button1_Click_1(object sender, EventArgs e)
        {
            stop_button = true;
            przerwanie = 1;
        }

        private void sciezka_zaczytania_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "Wybierz folder z którego mają zostać zaczytane pliki CSV lub SDS";
            FBD.RootFolder = Environment.SpecialFolder.MyComputer;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                sciezka_zaczytania.Text = FBD.SelectedPath;
                Properties.Settings.Default.sciezka_odczytu_se = FBD.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "Wybierz folder do którego mają zostać zapisane pliki po konwersji";
            FBD.RootFolder = Environment.SpecialFolder.MyComputer;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                sciezka_zapisu.Text = FBD.SelectedPath;
                Properties.Settings.Default.sciezka_zapisu_se = FBD.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }
        
        private void domyslne_Click(object sender, EventArgs e)
        {
            sciezka_zaczytania.Text = Directory.GetCurrentDirectory() + (char)92 + "SDS";
            sciezka_zapisu.Text = Directory.GetCurrentDirectory() + (char)92 + "SDSP";
            Properties.Settings.Default.sciezka_odczytu_se = Directory.GetCurrentDirectory() + (char)92 + "SDS";
            Properties.Settings.Default.sciezka_zapisu_se = Directory.GetCurrentDirectory() + (char)92 + "SDSP";
            Properties.Settings.Default.Save();
        }
    }
}
