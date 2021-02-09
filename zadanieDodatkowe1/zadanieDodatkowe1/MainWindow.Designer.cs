using System;
using System.IO;

namespace zadanieDodatkowe1
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.keyWordInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.keyWordList = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.customButton2 = new CustomButton.CustomButton();
            this.label6 = new System.Windows.Forms.Label();
            this.customButton1 = new CustomButton.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // keyWordInput
            // 
            this.keyWordInput.Location = new System.Drawing.Point(214, 58);
            this.keyWordInput.Name = "keyWordInput";
            this.keyWordInput.Size = new System.Drawing.Size(148, 20);
            this.keyWordInput.TabIndex = 1;
            this.keyWordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyWordInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wprowadź słowa klucze";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(368, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(470, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Słowa kluczowe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 135);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 137);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sprawdzany tekst";
            // 
            // keyWordList
            // 
            this.keyWordList.AutoArrange = false;
            this.keyWordList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.keyWordList.HideSelection = false;
            this.keyWordList.Location = new System.Drawing.Point(449, 34);
            this.keyWordList.Name = "keyWordList";
            this.keyWordList.Size = new System.Drawing.Size(178, 351);
            this.keyWordList.TabIndex = 0;
            this.keyWordList.UseCompatibleStateImageBehavior = false;
            this.keyWordList.View = System.Windows.Forms.View.List;
            this.keyWordList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 397);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 114);
            this.label5.TabIndex = 2;
            this.label5.Text = "Wojskowa Akademia Techniczna";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::zadanieDodatkowe1.Properties.Resources.unnamed;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 397);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(245, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Zapisz słowa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // customButton2
            // 
            this.customButton2.MyEvent += loadFile;
            this.customButton2.Image = global::zadanieDodatkowe1.Properties.Resources.img_504113;
            this.customButton2.ImageHover = global::zadanieDodatkowe1.Properties.Resources.img_504113_2_;
            this.customButton2.ImageNormal = global::zadanieDodatkowe1.Properties.Resources.img_504113;
            this.customButton2.Location = new System.Drawing.Point(351, 296);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(48, 50);
            this.customButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customButton2.TabIndex = 11;
            this.customButton2.TabStop = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(348, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Wczytaj słowa";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // customButton1
            // 
            this.customButton1.MyEvent += saveFile;
            this.customButton1.Image = global::zadanieDodatkowe1.Properties.Resources.save_icon_1320167995084087448;
            this.customButton1.ImageHover = global::zadanieDodatkowe1.Properties.Resources.save_icon_1320167995084087448_2_;
            this.customButton1.ImageNormal = global::zadanieDodatkowe1.Properties.Resources.save_icon_1320167995084087448;
            this.customButton1.Location = new System.Drawing.Point(248, 296);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(48, 50);
            this.customButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customButton1.TabIndex = 13;
            this.customButton1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(639, 397);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.keyWordList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyWordInput);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Zadanie Dodatkowe - Michał Petryński";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private async void saveFile(object sender, EventArgs e)
        {
            string text = "";
            foreach(System.Windows.Forms.ListViewItem keyWord in keyWordList.Items)
            {
                text += keyWord.Text.ToString() + " ";
            }

            using (var sw = new StreamWriter("SavedWordsFile.txt"))
            {
                await sw.WriteAsync(text);
            }
        }

        private async void loadFile(object sender, EventArgs e)
        {
            try { 
                using (var sr = new StreamReader("SavedWordsFile.txt"))
                {
                    string s;
                    s = await sr.ReadToEndAsync();
                    string[] strArray = s.Split(' ');
                    foreach(string str in strArray)
                    {
                        if(!string.IsNullOrWhiteSpace(str))
                            keyWordList.Items.Add(str);
                    }
                }
            }
            catch (FileNotFoundException) 
            {
                System.Windows.Forms.MessageBox.Show("File does not exist!", "No file to load"); 
            }
        }
        #endregion

        private System.Windows.Forms.ListView keyWordList;
        private System.Windows.Forms.TextBox keyWordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private CustomButton.CustomButton customButton2;
        private System.Windows.Forms.Label label6;
        private CustomButton.CustomButton customButton1;
    }
}

