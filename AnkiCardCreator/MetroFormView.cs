using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using AnkiCardCreator.Interfaces;
using System.Xml.Linq;
using System.IO;
using System.Diagnostics;

namespace AnkiCardCreator
{
    public partial class MetroFormView : MetroForm, IView
    {
        public Presenter presenter { get; set; }
        public event EventHandler TranslationChanged;

        bool LangEnglish = true;

        object locker = new object();


        public MetroFormView()
        {
            InitializeComponent();
        }


        public string Word
        {
            get { return txbWord.Text; }
            set { txbWord.Text = value; }
        }
        public string Translation
        {
            get { return txbTranslation.Text; }
            set { txbTranslation.Text = value; }
        }
        public string Transcription
        {
            get { return txbTranscription.Text; }
            set { txbTranscription.Text = value; }
        }

        public string AlternativeImageSearch
        {
            get { return txbSearchNew.Text; }
            set { txbSearchNew.Text = value; }
        }

        public string Language 
        { 
            get 
            {
                if (LangEnglish) return "en-ru";
                else return "ru-en";
            }
            set
            {
                if (LangEnglish) Language = "en-ru";
                else Language = "ru-en";
            }
        }

        private string wordToSearch;
        public string WordToSearch
        {
            get { return wordToSearch; }
            set { wordToSearch = value; }
        }


        public void GetTranslation()
        {
            presenter.ShowTranslation();
        }

        public void DisplayTranslation(string w, string tr, string ts)
        {
            txbWord.Text = w;
            txbTranslation.Text = tr;
            txbTranscription.Text = ts;
        }

        public void DisplayImage()
        {
            ThreadDownloading();
        }

        void ThreadDownloading()
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                DownloaderThreading dwn;
                PictureBox pcb = ctr as PictureBox;
                if (pcb != null)
                    dwn = new DownloaderThreading(presenter, pcb);
            }
        }

        public string GetSelectedURL()
        {
            if (rbImg1.Checked) return pcbImg1.ImageLocation;
            else if (rbImg2.Checked) return pcbImg2.ImageLocation;
            else return pcbImg3.ImageLocation;
        }

        public void ChangeAnkiContentFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = AnkiAppSettings.AnkiContentPath;

            DialogResult res = fbd.ShowDialog();

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                AnkiAppSettings.SaveContentChanges(fbd.SelectedPath);
            }
            else
            {
                return;
            }
        }


        public void SuccessfullMessage()
        {
            MessageBox.Show("Операция завершина успешно!", "Операция успешна.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //not use
        public void ErrorMessage()
        {
            MessageBox.Show("Ошибка операции!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ViewCatchModelException(string message)
        {
            MessageBox.Show(message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            GetTranslation();
            panel1.Visible = true;
            AlternativeImageSearch = txbWord.Text;
            WordToSearch = txbWord.Text;
            DisplayImage();
        }

        private void txbTranslation_TextChanged(object sender, EventArgs e)
        {
            TranslationChanged(sender, e);
        }

        private void pcbImg1_Click(object sender, EventArgs e)
        {
            rbImg1.Checked = true;
        }

        private void pcbImg2_Click(object sender, EventArgs e)
        {
            rbImg2.Checked = true;
        }

        private void pcbImg3_Click(object sender, EventArgs e)
        {
            rbImg3.Checked = true;
        }

        private void txbRefresh_Click(object sender, EventArgs e)
        {
            if (WordToSearch != AlternativeImageSearch)
            {
                presenter.AlternativeSearchImage();
                WordToSearch = AlternativeImageSearch;
            }

            DisplayImage();
        }

        private void btnAddAnkiCard_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            presenter.OnCreateAnkiCard(GetSelectedURL());
            txbWord.Text = "";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void изменитьПапкуКонтентаAnkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeAnkiContentFolder();
        }

        private void pcbLang_Click(object sender, EventArgs e)
        {
            if (Language == "en-ru")
            {
                pcbLang.Image = AnkiCardCreator.Properties.Resources.English;
                tTipLanguage.SetToolTip(pcbLang, "Перевод осуществляется на \"Английский\"");
                LangEnglish = false;
            }
            else
            {
                pcbLang.Image = AnkiCardCreator.Properties.Resources.russian1;
                tTipLanguage.SetToolTip(pcbLang, "Перевод осуществляется на \"Русский\"");
                LangEnglish = true;
            }
        }

        private void изменитьПапкуФайлаИмпортаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = AnkiAppSettings.AnkiImportPath;

            DialogResult res = fbd.ShowDialog();

            if (res == System.Windows.Forms.DialogResult.OK)
                AnkiAppSettings.SaveImportChanges(fbd.SelectedPath);
        }

        private void установитьКлючPixaBayApiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                    string.Format("Введите ваш PixaBay Api-ключ в открывшемся документе после чего закройте текстовый редактор:{0}{0}<PixaBayApiKey> Ваш ключ </PixaBayApiKey>", Environment.NewLine),
                    "Изменение настроек PixaBay Api-key",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

            var pcs = Process.Start("settings.xml");

            pcs.WaitForExit();

            AnkiAppSettings.LoadSettings();
        }



    }
}
