using System;
using System.Windows.Forms;
using AnkiCardCreator.Interfaces;
using System.Xml.Linq;

namespace AnkiCardCreator
{
    public partial class WinFormView : Form, IView
    {
        public Presenter presenter { get; set; }
        public event EventHandler TranslationChanged;
        
        
        object locker = new object();

        public WinFormView()
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

        public string AlternativeImageSearch {
            get { return txbSearchNew.Text; }
            set { txbSearchNew.Text = value; }
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
            DialogResult res = fbd.ShowDialog();

            if (res == System.Windows.Forms.DialogResult.OK)
            {
                XDocument xDoc = XDocument.Load("settings.xml");

                xDoc.Element("SETTINGS").Element("AnkiContentPath").Value = fbd.SelectedPath;
                xDoc.Save("settings.xml");
            }
            else
            {
                return;
            }
        }


        public void SuccessfullMessage()
        {
            MessageBox.Show("Операция завершина успешно!" ,"Операция успешна.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //not use
        public void ErrorMessage()
        {
            MessageBox.Show("Ошибка операции!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            
            
            GetTranslation();

            panel1.Visible = true;

            AlternativeImageSearch = txbWord.Text;

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
            if (Word != AlternativeImageSearch)
                presenter.AlternativeSearchImage();

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

        public void ViewCatchModelException(string message)
        {
            MessageBox.Show(message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        public void ChangeLanguage()
        {
            throw new NotImplementedException();
        }


        public string Language
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
