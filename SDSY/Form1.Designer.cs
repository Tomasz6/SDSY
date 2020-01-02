namespace SDSY
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.start.Location = new System.Drawing.Point(125, 68);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(113, 48);
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
            this.progressBar1.Size = new System.Drawing.Size(339, 37);
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
            this.Rodzaj_zapisu.Size = new System.Drawing.Size(96, 40);
            this.Rodzaj_zapisu.TabIndex = 4;
            this.Rodzaj_zapisu.SelectedIndexChanged += new System.EventHandler(this.Rodzaj_zapisu_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 45;
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
            this.checkedListBox1.Size = new System.Drawing.Size(101, 44);
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
            this.EK.Location = new System.Drawing.Point(244, 14);
            this.EK.Name = "EK";
            this.EK.Size = new System.Drawing.Size(111, 48);
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
            this.groupBox1.Location = new System.Drawing.Point(244, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uśrednianie";
            // 
            // ilosc_probek
            // 
            this.ilosc_probek.Location = new System.Drawing.Point(6, 97);
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
            this.label1.Location = new System.Drawing.Point(3, 79);
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
            this.Usrednianie.Location = new System.Drawing.Point(6, 29);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 69);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Format zapisu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox3.Location = new System.Drawing.Point(125, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 70);
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
            this.groupBox4.Size = new System.Drawing.Size(232, 56);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Format wejściowy";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 19);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(339, 16);
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
            this.groupBox5.Size = new System.Drawing.Size(351, 41);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Zapis pliku";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.progressBar1);
            this.groupBox6.Location = new System.Drawing.Point(6, 252);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(351, 62);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Postęp konwersji";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Program);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(369, 343);
            this.tabControl1.TabIndex = 19;
            // 
            // Program
            // 
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
            this.Program.Size = new System.Drawing.Size(361, 317);
            this.Program.TabIndex = 0;
            this.Program.Text = "Program";
            this.Program.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(361, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wczytane pliki";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
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
            this.tabPage1.Size = new System.Drawing.Size(361, 317);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(358, 314);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.MaximumSize = new System.Drawing.Size(330, 0);
            this.label2.MinimumSize = new System.Drawing.Size(330, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aby program działał należy w folderze programu umieścić plik excell o nazwie \"obs" +
    "zar_roboczy\".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.MaximumSize = new System.Drawing.Size(330, 0);
            this.label3.MinimumSize = new System.Drawing.Size(330, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 47);
            this.label3.TabIndex = 1;
            this.label3.Text = "Jeżeli w folderze z programem nie ma folderu \"SDS\", należy go utworzyć, ponieważ " +
    "z niego zostaną zaczytane pliki do konwersji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 101);
            this.label4.MaximumSize = new System.Drawing.Size(330, 0);
            this.label4.MinimumSize = new System.Drawing.Size(330, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Jeśli program został wyłączony podczas działania należy kliknąć w \"Excell Killer\"" +
    ". ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 144);
            this.label5.MaximumSize = new System.Drawing.Size(330, 0);
            this.label5.MinimumSize = new System.Drawing.Size(330, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 47);
            this.label5.TabIndex = 3;
            this.label5.Text = "W przypadku gdyby z niewiadomych przyczyn program wyrzucał błąd zaraz po włączeni" +
    "u również należy kliknąć \"Excell Killer\"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(138, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Uwaga!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(6, 213);
            this.label7.MaximumSize = new System.Drawing.Size(330, 0);
            this.label7.MinimumSize = new System.Drawing.Size(330, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(330, 62);
            this.label7.TabIndex = 5;
            this.label7.Text = "Wciśnięcie \"Excell Killer\" powoduje zamknięcie wszystkich aktywnych procesów prog" +
    "ramu \"Excell\", dlatego przed naciśnięciem tego przycisku zamknij wszystkie otwar" +
    "te arkusze kalkulacyjne.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(6, 295);
            this.label8.MaximumSize = new System.Drawing.Size(330, 0);
            this.label8.MinimumSize = new System.Drawing.Size(330, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(330, 62);
            this.label8.TabIndex = 6;
            this.label8.Text = "W przypadku gdy chcemy uśrednić próbki w pliku wyjściowym względem wejściowego, n" +
    "ależy włączyć Uśrednianie i podać z ilu próbek ma powstać jedna (zbyt duże uśred" +
    "nienie zniekształci wykres)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(385, 353);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(389, 356);
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
            this.ResumeLayout(false);

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
    }
}

