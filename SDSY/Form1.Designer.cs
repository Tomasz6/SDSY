﻿namespace SDSY
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.start = new System.Windows.Forms.Button();
            this.Wczytaj = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Rodzaj_zapisu = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.EK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ilosc_probek = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Usrednianie = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SDS = new System.Windows.Forms.RadioButton();
            this.CSV = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Program = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.sciezka_zaczytania = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sciezka_zapisu = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.domyslne = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilosc_probek)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Program.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.SteelBlue;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start.ForeColor = System.Drawing.SystemColors.InfoText;
            this.start.Location = new System.Drawing.Point(119, 68);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 48);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Wczytaj
            // 
            this.Wczytaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wczytaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wczytaj.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Wczytaj.Location = new System.Drawing.Point(6, 68);
            this.Wczytaj.Name = "Wczytaj";
            this.Wczytaj.Size = new System.Drawing.Size(107, 48);
            this.Wczytaj.TabIndex = 1;
            this.Wczytaj.Text = "Wczytaj";
            this.Wczytaj.UseVisualStyleBackColor = true;
            this.Wczytaj.Click += new System.EventHandler(this.Wczytaj_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(362, 37);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            // 
            // Rodzaj_zapisu
            // 
            this.Rodzaj_zapisu.CheckOnClick = true;
            this.Rodzaj_zapisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rodzaj_zapisu.FormattingEnabled = true;
            this.Rodzaj_zapisu.Items.AddRange(new object[] {
            "Xlsx",
            "Csv"});
            this.Rodzaj_zapisu.Location = new System.Drawing.Point(11, 20);
            this.Rodzaj_zapisu.Name = "Rodzaj_zapisu";
            this.Rodzaj_zapisu.Size = new System.Drawing.Size(104, 40);
            this.Rodzaj_zapisu.TabIndex = 4;
            this.Rodzaj_zapisu.SelectedIndexChanged += new System.EventHandler(this.Rodzaj_zapisu_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 50;
            this.checkedListBox1.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "   ",
            ".",
            ":",
            ";"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 44);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // EK
            // 
            this.EK.BackColor = System.Drawing.Color.Firebrick;
            this.EK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.EK.ForeColor = System.Drawing.SystemColors.InfoText;
            this.EK.Location = new System.Drawing.Point(266, 14);
            this.EK.Name = "EK";
            this.EK.Size = new System.Drawing.Size(114, 48);
            this.EK.TabIndex = 5;
            this.EK.Text = "Excell Killer";
            this.EK.UseVisualStyleBackColor = false;
            this.EK.Click += new System.EventHandler(this.Stop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ilosc_probek);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Usrednianie);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(281, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 131);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uśrednianie";
            // 
            // ilosc_probek
            // 
            this.ilosc_probek.Location = new System.Drawing.Point(6, 91);
            this.ilosc_probek.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ilosc_probek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ilosc_probek.Name = "ilosc_probek";
            this.ilosc_probek.Size = new System.Drawing.Size(70, 21);
            this.ilosc_probek.TabIndex = 19;
            this.ilosc_probek.ThousandsSeparator = true;
            this.ilosc_probek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ilosc_probek.ValueChanged += new System.EventHandler(this.ilosc_probek_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ilość próbek";
            // 
            // Usrednianie
            // 
            this.Usrednianie.BackColor = System.Drawing.Color.Firebrick;
            this.Usrednianie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usrednianie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Usrednianie.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Usrednianie.Location = new System.Drawing.Point(6, 23);
            this.Usrednianie.Name = "Usrednianie";
            this.Usrednianie.Size = new System.Drawing.Size(70, 36);
            this.Usrednianie.TabIndex = 0;
            this.Usrednianie.Text = "Wył";
            this.Usrednianie.UseVisualStyleBackColor = false;
            this.Usrednianie.Click += new System.EventHandler(this.Usrednianie_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rodzaj_zapisu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(6, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 69);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Format zapisu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox3.Location = new System.Drawing.Point(133, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 70);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delimiter";
            // 
            // SDS
            // 
            this.SDS.AutoSize = true;
            this.SDS.Location = new System.Drawing.Point(11, 25);
            this.SDS.Name = "SDS";
            this.SDS.Size = new System.Drawing.Size(50, 19);
            this.SDS.TabIndex = 12;
            this.SDS.TabStop = true;
            this.SDS.Text = "SDS";
            this.SDS.UseVisualStyleBackColor = true;
            this.SDS.CheckedChanged += new System.EventHandler(this.SDS_CheckedChanged);
            // 
            // CSV
            // 
            this.CSV.AutoSize = true;
            this.CSV.Location = new System.Drawing.Point(125, 25);
            this.CSV.Name = "CSV";
            this.CSV.Size = new System.Drawing.Size(48, 19);
            this.CSV.TabIndex = 13;
            this.CSV.TabStop = true;
            this.CSV.Text = "CSV";
            this.CSV.UseVisualStyleBackColor = true;
            this.CSV.CheckedChanged += new System.EventHandler(this.CSV_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CSV);
            this.groupBox4.Controls.Add(this.SDS);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 56);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Format wejściowy";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 19);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(362, 16);
            this.progressBar2.TabIndex = 15;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.progressBar2);
            this.groupBox5.Location = new System.Drawing.Point(6, 205);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(374, 41);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Zapis pliku";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.progressBar1);
            this.groupBox6.Location = new System.Drawing.Point(6, 252);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(374, 62);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Postęp konwersji";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Program);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(395, 344);
            this.tabControl1.TabIndex = 19;
            // 
            // Program
            // 
            this.Program.Controls.Add(this.button1);
            this.Program.Controls.Add(this.groupBox4);
            this.Program.Controls.Add(this.start);
            this.Program.Controls.Add(this.groupBox6);
            this.Program.Controls.Add(this.Wczytaj);
            this.Program.Controls.Add(this.groupBox5);
            this.Program.Controls.Add(this.EK);
            this.Program.Controls.Add(this.groupBox1);
            this.Program.Controls.Add(this.groupBox3);
            this.Program.Controls.Add(this.groupBox2);
            this.Program.Location = new System.Drawing.Point(4, 22);
            this.Program.Name = "Program";
            this.Program.Padding = new System.Windows.Forms.Padding(3);
            this.Program.Size = new System.Drawing.Size(387, 318);
            this.Program.TabIndex = 0;
            this.Program.Text = "Program";
            this.Program.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.Location = new System.Drawing.Point(200, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(387, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wczytane pliki";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(384, 314);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(387, 318);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(148, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Uwaga!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(0, 142);
            this.label9.MaximumSize = new System.Drawing.Size(350, 0);
            this.label9.MinimumSize = new System.Drawing.Size(350, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(350, 62);
            this.label9.TabIndex = 7;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(0, 389);
            this.label8.MaximumSize = new System.Drawing.Size(350, 0);
            this.label8.MinimumSize = new System.Drawing.Size(350, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(350, 62);
            this.label8.TabIndex = 6;
            this.label8.Text = "W przypadku gdy chcemy uśrednić próbki w pliku wyjściowym względem wejściowego, n" +
    "ależy włączyć Uśrednianie i podać z ilu próbek ma powstać jedna (zbyt duże uśred" +
    "nienie zniekształci wykres)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(0, 320);
            this.label7.MaximumSize = new System.Drawing.Size(350, 0);
            this.label7.MinimumSize = new System.Drawing.Size(350, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 62);
            this.label7.TabIndex = 5;
            this.label7.Text = "Wciśnięcie \"Excell Killer\" powoduje zamknięcie wszystkich aktywnych procesów prog" +
    "ramu \"Excell\", dlatego przed naciśnięciem tego przycisku zamknij wszystkie otwar" +
    "te arkusze kalkulacyjne.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(148, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Uwaga!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(0, 249);
            this.label5.MaximumSize = new System.Drawing.Size(350, 0);
            this.label5.MinimumSize = new System.Drawing.Size(350, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 47);
            this.label5.TabIndex = 3;
            this.label5.Text = "W przypadku gdyby z niewiadomych przyczyn program wyrzucał błąd zaraz po włączeni" +
    "u również należy kliknąć \"Excell Killer\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(0, 217);
            this.label4.MaximumSize = new System.Drawing.Size(350, 0);
            this.label4.MinimumSize = new System.Drawing.Size(350, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jeśli program został wyłączony podczas działania należy kliknąć w \"Excell Killer\"" +
    ". ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.MaximumSize = new System.Drawing.Size(350, 0);
            this.label3.MinimumSize = new System.Drawing.Size(350, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 62);
            this.label3.TabIndex = 1;
            this.label3.Text = "Jeżeli w folderze z programem nie ma folderu \"SDS\", należy go utworzyć, ponieważ " +
    "z niego zostaną zaczytane pliki do konwersji (folder nie jest wymagany w przypad" +
    "ku gdy wskażemy inny do oczytu plików)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.MaximumSize = new System.Drawing.Size(350, 0);
            this.label2.MinimumSize = new System.Drawing.Size(350, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aby program działał należy w folderze programu umieścić plik excell o nazwie \"obs" +
    "zar_roboczy\".";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.domyslne);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.sciezka_zapisu);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.sciezka_zaczytania);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(387, 318);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Ustawienia";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(3, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(224, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ścieżka odczytu plików do konwersji";
            // 
            // sciezka_zaczytania
            // 
            this.sciezka_zaczytania.Location = new System.Drawing.Point(5, 27);
            this.sciezka_zaczytania.Name = "sciezka_zaczytania";
            this.sciezka_zaczytania.Size = new System.Drawing.Size(248, 20);
            this.sciezka_zaczytania.TabIndex = 1;
            this.sciezka_zaczytania.TextChanged += new System.EventHandler(this.sciezka_zaczytania_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 20);
            this.button2.TabIndex = 0;
            this.button2.Text = "Zmień";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(286, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 9);
            this.label11.TabIndex = 20;
            this.label11.Text = "Stworzone przez Toamsz Felczak";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(4, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(217, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Ścieżka zapisu plików po konwersji";
            // 
            // sciezka_zapisu
            // 
            this.sciezka_zapisu.Location = new System.Drawing.Point(6, 87);
            this.sciezka_zapisu.Name = "sciezka_zapisu";
            this.sciezka_zapisu.Size = new System.Drawing.Size(248, 20);
            this.sciezka_zapisu.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 20);
            this.button3.TabIndex = 5;
            this.button3.Text = "Zmień";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // domyslne
            // 
            this.domyslne.Location = new System.Drawing.Point(120, 135);
            this.domyslne.Name = "domyslne";
            this.domyslne.Size = new System.Drawing.Size(101, 27);
            this.domyslne.TabIndex = 6;
            this.domyslne.Text = "Domyślne";
            this.domyslne.UseVisualStyleBackColor = true;
            this.domyslne.Click += new System.EventHandler(this.domyslne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(399, 387);
            this.Name = "Form1";
            this.Text = "Konwerter SDS/CSV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilosc_probek)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Program.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Wczytaj;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        public System.Windows.Forms.CheckedListBox Rodzaj_zapisu;
        private System.Windows.Forms.Button EK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Usrednianie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton SDS;
        private System.Windows.Forms.RadioButton CSV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown ilosc_probek;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Program;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox sciezka_zaczytania;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox sciezka_zapisu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button domyslne;
    }
}

