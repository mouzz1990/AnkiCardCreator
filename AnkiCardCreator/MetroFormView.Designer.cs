namespace AnkiCardCreator
{
    partial class MetroFormView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetroFormView));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txbWord = new MetroFramework.Controls.MetroTextBox();
            this.btnTranslate = new MetroFramework.Controls.MetroButton();
            this.panel1 = new MetroFramework.Controls.MetroPanel();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.изменитьПапкуКонтентаAnkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПапкуФайлаИмпортаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddAnkiCard = new MetroFramework.Controls.MetroButton();
            this.txbRefresh = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new MetroFramework.Controls.MetroPanel();
            this.rbImg3 = new MetroFramework.Controls.MetroRadioButton();
            this.rbImg2 = new MetroFramework.Controls.MetroRadioButton();
            this.rbImg1 = new MetroFramework.Controls.MetroRadioButton();
            this.pcbImg3 = new System.Windows.Forms.PictureBox();
            this.pcbImg2 = new System.Windows.Forms.PictureBox();
            this.pcbImg1 = new System.Windows.Forms.PictureBox();
            this.txbSearchNew = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txbTranscription = new MetroFramework.Controls.MetroTextBox();
            this.txbTranslation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pcbLang = new System.Windows.Forms.PictureBox();
            this.tTipLanguage = new System.Windows.Forms.ToolTip(this.components);
            this.установитьКлючPixaBayApiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLang)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(91, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Перевести:";
            // 
            // txbWord
            // 
            // 
            // 
            // 
            this.txbWord.CustomButton.Image = null;
            this.txbWord.CustomButton.Location = new System.Drawing.Point(489, 2);
            this.txbWord.CustomButton.Name = "";
            this.txbWord.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txbWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbWord.CustomButton.TabIndex = 1;
            this.txbWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbWord.CustomButton.UseSelectable = true;
            this.txbWord.CustomButton.Visible = false;
            this.txbWord.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txbWord.Lines = new string[0];
            this.txbWord.Location = new System.Drawing.Point(202, 79);
            this.txbWord.MaxLength = 32767;
            this.txbWord.Name = "txbWord";
            this.txbWord.PasswordChar = '\0';
            this.txbWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbWord.SelectedText = "";
            this.txbWord.SelectionLength = 0;
            this.txbWord.SelectionStart = 0;
            this.txbWord.ShortcutsEnabled = true;
            this.txbWord.Size = new System.Drawing.Size(517, 30);
            this.txbWord.TabIndex = 1;
            this.txbWord.UseSelectable = true;
            this.txbWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnTranslate
            // 
            this.btnTranslate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnTranslate.Location = new System.Drawing.Point(323, 124);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(160, 45);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "Перевод";
            this.btnTranslate.UseSelectable = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ContextMenuStrip = this.metroContextMenu1;
            this.panel1.Controls.Add(this.btnAddAnkiCard);
            this.panel1.Controls.Add(this.txbRefresh);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txbTranscription);
            this.panel1.Controls.Add(this.txbTranslation);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.HorizontalScrollbarBarColor = true;
            this.panel1.HorizontalScrollbarHighlightOnWheel = false;
            this.panel1.HorizontalScrollbarSize = 10;
            this.panel1.Location = new System.Drawing.Point(23, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 514);
            this.panel1.TabIndex = 3;
            this.panel1.VerticalScrollbarBarColor = true;
            this.panel1.VerticalScrollbarHighlightOnWheel = false;
            this.panel1.VerticalScrollbarSize = 10;
            this.panel1.Visible = false;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьПапкуКонтентаAnkiToolStripMenuItem,
            this.изменитьПапкуФайлаИмпортаToolStripMenuItem,
            this.установитьКлючPixaBayApiToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(253, 114);
            // 
            // изменитьПапкуКонтентаAnkiToolStripMenuItem
            // 
            this.изменитьПапкуКонтентаAnkiToolStripMenuItem.Image = global::AnkiCardCreator.Properties.Resources.programsChange;
            this.изменитьПапкуКонтентаAnkiToolStripMenuItem.Name = "изменитьПапкуКонтентаAnkiToolStripMenuItem";
            this.изменитьПапкуКонтентаAnkiToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.изменитьПапкуКонтентаAnkiToolStripMenuItem.Text = "Изменить папку контента Anki";
            this.изменитьПапкуКонтентаAnkiToolStripMenuItem.Click += new System.EventHandler(this.изменитьПапкуКонтентаAnkiToolStripMenuItem_Click);
            // 
            // изменитьПапкуФайлаИмпортаToolStripMenuItem
            // 
            this.изменитьПапкуФайлаИмпортаToolStripMenuItem.Image = global::AnkiCardCreator.Properties.Resources.programsChange;
            this.изменитьПапкуФайлаИмпортаToolStripMenuItem.Name = "изменитьПапкуФайлаИмпортаToolStripMenuItem";
            this.изменитьПапкуФайлаИмпортаToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.изменитьПапкуФайлаИмпортаToolStripMenuItem.Text = "Изменить папку файла импорта";
            this.изменитьПапкуФайлаИмпортаToolStripMenuItem.Click += new System.EventHandler(this.изменитьПапкуФайлаИмпортаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::AnkiCardCreator.Properties.Resources.power;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // btnAddAnkiCard
            // 
            this.btnAddAnkiCard.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAddAnkiCard.Location = new System.Drawing.Point(549, 451);
            this.btnAddAnkiCard.Name = "btnAddAnkiCard";
            this.btnAddAnkiCard.Size = new System.Drawing.Size(175, 45);
            this.btnAddAnkiCard.TabIndex = 8;
            this.btnAddAnkiCard.Text = "Добавить Anki-карточку";
            this.btnAddAnkiCard.UseSelectable = true;
            this.btnAddAnkiCard.Click += new System.EventHandler(this.btnAddAnkiCard_Click);
            // 
            // txbRefresh
            // 
            this.txbRefresh.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.txbRefresh.Location = new System.Drawing.Point(21, 451);
            this.txbRefresh.Name = "txbRefresh";
            this.txbRefresh.Size = new System.Drawing.Size(175, 45);
            this.txbRefresh.TabIndex = 7;
            this.txbRefresh.Text = "Обновить изображение";
            this.txbRefresh.UseSelectable = true;
            this.txbRefresh.Click += new System.EventHandler(this.txbRefresh_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(64, 114);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(160, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Выберите изображение";
            // 
            // groupBox1
            // 
            this.groupBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBox1.Controls.Add(this.rbImg3);
            this.groupBox1.Controls.Add(this.rbImg2);
            this.groupBox1.Controls.Add(this.rbImg1);
            this.groupBox1.Controls.Add(this.pcbImg3);
            this.groupBox1.Controls.Add(this.pcbImg2);
            this.groupBox1.Controls.Add(this.pcbImg1);
            this.groupBox1.Controls.Add(this.txbSearchNew);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.HorizontalScrollbarBarColor = true;
            this.groupBox1.HorizontalScrollbarHighlightOnWheel = false;
            this.groupBox1.HorizontalScrollbarSize = 10;
            this.groupBox1.Location = new System.Drawing.Point(21, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 301);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.VerticalScrollbarBarColor = true;
            this.groupBox1.VerticalScrollbarHighlightOnWheel = false;
            this.groupBox1.VerticalScrollbarSize = 10;
            // 
            // rbImg3
            // 
            this.rbImg3.AutoSize = true;
            this.rbImg3.Location = new System.Drawing.Point(567, 275);
            this.rbImg3.Name = "rbImg3";
            this.rbImg3.Size = new System.Drawing.Size(26, 15);
            this.rbImg3.TabIndex = 5;
            this.rbImg3.Text = " ";
            this.rbImg3.UseSelectable = true;
            // 
            // rbImg2
            // 
            this.rbImg2.AutoSize = true;
            this.rbImg2.Location = new System.Drawing.Point(338, 275);
            this.rbImg2.Name = "rbImg2";
            this.rbImg2.Size = new System.Drawing.Size(26, 15);
            this.rbImg2.TabIndex = 5;
            this.rbImg2.Text = " ";
            this.rbImg2.UseSelectable = true;
            // 
            // rbImg1
            // 
            this.rbImg1.AutoSize = true;
            this.rbImg1.Checked = true;
            this.rbImg1.Location = new System.Drawing.Point(109, 275);
            this.rbImg1.Name = "rbImg1";
            this.rbImg1.Size = new System.Drawing.Size(26, 15);
            this.rbImg1.TabIndex = 5;
            this.rbImg1.TabStop = true;
            this.rbImg1.Text = " ";
            this.rbImg1.UseSelectable = true;
            // 
            // pcbImg3
            // 
            this.pcbImg3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbImg3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbImg3.Location = new System.Drawing.Point(473, 69);
            this.pcbImg3.Name = "pcbImg3";
            this.pcbImg3.Size = new System.Drawing.Size(200, 200);
            this.pcbImg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImg3.TabIndex = 4;
            this.pcbImg3.TabStop = false;
            this.pcbImg3.Click += new System.EventHandler(this.pcbImg3_Click);
            // 
            // pcbImg2
            // 
            this.pcbImg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbImg2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbImg2.Location = new System.Drawing.Point(244, 69);
            this.pcbImg2.Name = "pcbImg2";
            this.pcbImg2.Size = new System.Drawing.Size(200, 200);
            this.pcbImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImg2.TabIndex = 4;
            this.pcbImg2.TabStop = false;
            this.pcbImg2.Click += new System.EventHandler(this.pcbImg2_Click);
            // 
            // pcbImg1
            // 
            this.pcbImg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbImg1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbImg1.Location = new System.Drawing.Point(15, 69);
            this.pcbImg1.Name = "pcbImg1";
            this.pcbImg1.Size = new System.Drawing.Size(200, 200);
            this.pcbImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImg1.TabIndex = 4;
            this.pcbImg1.TabStop = false;
            this.pcbImg1.Click += new System.EventHandler(this.pcbImg1_Click);
            // 
            // txbSearchNew
            // 
            // 
            // 
            // 
            this.txbSearchNew.CustomButton.Image = null;
            this.txbSearchNew.CustomButton.Location = new System.Drawing.Point(489, 2);
            this.txbSearchNew.CustomButton.Name = "";
            this.txbSearchNew.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txbSearchNew.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbSearchNew.CustomButton.TabIndex = 1;
            this.txbSearchNew.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbSearchNew.CustomButton.UseSelectable = true;
            this.txbSearchNew.CustomButton.Visible = false;
            this.txbSearchNew.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txbSearchNew.Lines = new string[0];
            this.txbSearchNew.Location = new System.Drawing.Point(156, 28);
            this.txbSearchNew.MaxLength = 32767;
            this.txbSearchNew.Name = "txbSearchNew";
            this.txbSearchNew.PasswordChar = '\0';
            this.txbSearchNew.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbSearchNew.SelectedText = "";
            this.txbSearchNew.SelectionLength = 0;
            this.txbSearchNew.SelectionStart = 0;
            this.txbSearchNew.ShortcutsEnabled = true;
            this.txbSearchNew.Size = new System.Drawing.Size(517, 30);
            this.txbSearchNew.TabIndex = 3;
            this.txbSearchNew.UseSelectable = true;
            this.txbSearchNew.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbSearchNew.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(2, 30);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(157, 25);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Слово для поиска:";
            // 
            // txbTranscription
            // 
            // 
            // 
            // 
            this.txbTranscription.CustomButton.Image = null;
            this.txbTranscription.CustomButton.Location = new System.Drawing.Point(489, 2);
            this.txbTranscription.CustomButton.Name = "";
            this.txbTranscription.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txbTranscription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbTranscription.CustomButton.TabIndex = 1;
            this.txbTranscription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbTranscription.CustomButton.UseSelectable = true;
            this.txbTranscription.CustomButton.Visible = false;
            this.txbTranscription.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txbTranscription.Lines = new string[0];
            this.txbTranscription.Location = new System.Drawing.Point(178, 58);
            this.txbTranscription.MaxLength = 32767;
            this.txbTranscription.Name = "txbTranscription";
            this.txbTranscription.PasswordChar = '\0';
            this.txbTranscription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbTranscription.SelectedText = "";
            this.txbTranscription.SelectionLength = 0;
            this.txbTranscription.SelectionStart = 0;
            this.txbTranscription.ShortcutsEnabled = true;
            this.txbTranscription.Size = new System.Drawing.Size(517, 30);
            this.txbTranscription.TabIndex = 5;
            this.txbTranscription.UseSelectable = true;
            this.txbTranscription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbTranscription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbTranslation
            // 
            // 
            // 
            // 
            this.txbTranslation.CustomButton.Image = null;
            this.txbTranslation.CustomButton.Location = new System.Drawing.Point(489, 2);
            this.txbTranslation.CustomButton.Name = "";
            this.txbTranslation.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txbTranslation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbTranslation.CustomButton.TabIndex = 1;
            this.txbTranslation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbTranslation.CustomButton.UseSelectable = true;
            this.txbTranslation.CustomButton.Visible = false;
            this.txbTranslation.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txbTranslation.Lines = new string[0];
            this.txbTranslation.Location = new System.Drawing.Point(178, 18);
            this.txbTranslation.MaxLength = 32767;
            this.txbTranslation.Name = "txbTranslation";
            this.txbTranslation.PasswordChar = '\0';
            this.txbTranslation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbTranslation.SelectedText = "";
            this.txbTranslation.SelectionLength = 0;
            this.txbTranslation.SelectionStart = 0;
            this.txbTranslation.ShortcutsEnabled = true;
            this.txbTranslation.Size = new System.Drawing.Size(517, 30);
            this.txbTranslation.TabIndex = 4;
            this.txbTranslation.UseSelectable = true;
            this.txbTranslation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbTranslation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbTranslation.TextChanged += new System.EventHandler(this.txbTranslation_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(43, 63);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(129, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Транскрипция:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(82, 18);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Перевод:";
            // 
            // pcbLang
            // 
            this.pcbLang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbLang.Image = global::AnkiCardCreator.Properties.Resources.russian1;
            this.pcbLang.Location = new System.Drawing.Point(737, 79);
            this.pcbLang.Name = "pcbLang";
            this.pcbLang.Size = new System.Drawing.Size(30, 30);
            this.pcbLang.TabIndex = 4;
            this.pcbLang.TabStop = false;
            this.tTipLanguage.SetToolTip(this.pcbLang, "Перевод осуществляется на \"Русский\"");
            this.pcbLang.Click += new System.EventHandler(this.pcbLang_Click);
            // 
            // tTipLanguage
            // 
            this.tTipLanguage.AutomaticDelay = 200;
            // 
            // установитьКлючPixaBayApiToolStripMenuItem
            // 
            this.установитьКлючPixaBayApiToolStripMenuItem.Image = global::AnkiCardCreator.Properties.Resources.programsChange;
            this.установитьКлючPixaBayApiToolStripMenuItem.Name = "установитьКлючPixaBayApiToolStripMenuItem";
            this.установитьКлючPixaBayApiToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.установитьКлючPixaBayApiToolStripMenuItem.Text = "Установить ключ PixaBay Api";
            this.установитьКлючPixaBayApiToolStripMenuItem.Click += new System.EventHandler(this.установитьКлючPixaBayApiToolStripMenuItem_Click);
            // 
            // MetroFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 733);
            this.ContextMenuStrip = this.metroContextMenu1;
            this.Controls.Add(this.pcbLang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txbWord);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MetroFormView";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Anki Card Creator v.1.2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroContextMenu1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txbWord;
        private MetroFramework.Controls.MetroButton btnTranslate;
        private MetroFramework.Controls.MetroPanel panel1;
        private MetroFramework.Controls.MetroTextBox txbTranscription;
        private MetroFramework.Controls.MetroTextBox txbTranslation;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel groupBox1;
        private MetroFramework.Controls.MetroRadioButton rbImg3;
        private MetroFramework.Controls.MetroRadioButton rbImg2;
        private MetroFramework.Controls.MetroRadioButton rbImg1;
        private System.Windows.Forms.PictureBox pcbImg3;
        private System.Windows.Forms.PictureBox pcbImg2;
        private System.Windows.Forms.PictureBox pcbImg1;
        private MetroFramework.Controls.MetroTextBox txbSearchNew;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnAddAnkiCard;
        private MetroFramework.Controls.MetroButton txbRefresh;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem изменитьПапкуКонтентаAnkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcbLang;
        private System.Windows.Forms.ToolTip tTipLanguage;
        private System.Windows.Forms.ToolStripMenuItem изменитьПапкуФайлаИмпортаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem установитьКлючPixaBayApiToolStripMenuItem;
    }
}