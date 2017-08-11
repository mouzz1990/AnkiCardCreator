namespace AnkiCardCreator
{
    partial class WinFormView
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinFormView));
            this.txbWord = new System.Windows.Forms.TextBox();
            this.txbTranslation = new System.Windows.Forms.TextBox();
            this.txbTranscription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbImg1 = new System.Windows.Forms.PictureBox();
            this.rbImg3 = new System.Windows.Forms.RadioButton();
            this.pcbImg3 = new System.Windows.Forms.PictureBox();
            this.rbImg2 = new System.Windows.Forms.RadioButton();
            this.pcbImg2 = new System.Windows.Forms.PictureBox();
            this.rbImg1 = new System.Windows.Forms.RadioButton();
            this.txbRefresh = new System.Windows.Forms.Button();
            this.btnAddAnkiCard = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПапкуКонтентаAnkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txbSearchNew = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbWord
            // 
            this.txbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbWord.Location = new System.Drawing.Point(244, 31);
            this.txbWord.Name = "txbWord";
            this.txbWord.Size = new System.Drawing.Size(457, 26);
            this.txbWord.TabIndex = 0;
            // 
            // txbTranslation
            // 
            this.txbTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbTranslation.Location = new System.Drawing.Point(216, 17);
            this.txbTranslation.Name = "txbTranslation";
            this.txbTranslation.Size = new System.Drawing.Size(457, 26);
            this.txbTranslation.TabIndex = 2;
            this.txbTranslation.TextChanged += new System.EventHandler(this.txbTranslation_TextChanged);
            // 
            // txbTranscription
            // 
            this.txbTranscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbTranscription.Location = new System.Drawing.Point(216, 55);
            this.txbTranscription.Name = "txbTranscription";
            this.txbTranscription.Size = new System.Drawing.Size(457, 26);
            this.txbTranscription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(119, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Перевод:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Слово для поиска:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txbRefresh);
            this.panel1.Controls.Add(this.btnAddAnkiCard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbTranscription);
            this.panel1.Controls.Add(this.txbTranslation);
            this.panel1.Location = new System.Drawing.Point(28, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 500);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcbImg1);
            this.groupBox1.Controls.Add(this.rbImg3);
            this.groupBox1.Controls.Add(this.pcbImg3);
            this.groupBox1.Controls.Add(this.rbImg2);
            this.groupBox1.Controls.Add(this.txbSearchNew);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pcbImg2);
            this.groupBox1.Controls.Add(this.rbImg1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(17, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 302);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите изображение";
            // 
            // pcbImg1
            // 
            this.pcbImg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbImg1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbImg1.Location = new System.Drawing.Point(14, 72);
            this.pcbImg1.Name = "pcbImg1";
            this.pcbImg1.Size = new System.Drawing.Size(200, 200);
            this.pcbImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImg1.TabIndex = 6;
            this.pcbImg1.TabStop = false;
            this.pcbImg1.Click += new System.EventHandler(this.pcbImg1_Click);
            // 
            // rbImg3
            // 
            this.rbImg3.AutoSize = true;
            this.rbImg3.Location = new System.Drawing.Point(583, 278);
            this.rbImg3.Name = "rbImg3";
            this.rbImg3.Size = new System.Drawing.Size(14, 13);
            this.rbImg3.TabIndex = 6;
            this.rbImg3.UseVisualStyleBackColor = true;
            // 
            // pcbImg3
            // 
            this.pcbImg3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbImg3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbImg3.Location = new System.Drawing.Point(488, 72);
            this.pcbImg3.Name = "pcbImg3";
            this.pcbImg3.Size = new System.Drawing.Size(200, 200);
            this.pcbImg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImg3.TabIndex = 8;
            this.pcbImg3.TabStop = false;
            this.pcbImg3.Click += new System.EventHandler(this.pcbImg3_Click);
            // 
            // rbImg2
            // 
            this.rbImg2.AutoSize = true;
            this.rbImg2.Location = new System.Drawing.Point(346, 278);
            this.rbImg2.Name = "rbImg2";
            this.rbImg2.Size = new System.Drawing.Size(14, 13);
            this.rbImg2.TabIndex = 5;
            this.rbImg2.UseVisualStyleBackColor = true;
            // 
            // pcbImg2
            // 
            this.pcbImg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbImg2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbImg2.Location = new System.Drawing.Point(251, 72);
            this.pcbImg2.Name = "pcbImg2";
            this.pcbImg2.Size = new System.Drawing.Size(200, 200);
            this.pcbImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImg2.TabIndex = 7;
            this.pcbImg2.TabStop = false;
            this.pcbImg2.Click += new System.EventHandler(this.pcbImg2_Click);
            // 
            // rbImg1
            // 
            this.rbImg1.AutoSize = true;
            this.rbImg1.Checked = true;
            this.rbImg1.Location = new System.Drawing.Point(108, 278);
            this.rbImg1.Name = "rbImg1";
            this.rbImg1.Size = new System.Drawing.Size(14, 13);
            this.rbImg1.TabIndex = 4;
            this.rbImg1.TabStop = true;
            this.rbImg1.UseVisualStyleBackColor = true;
            // 
            // txbRefresh
            // 
            this.txbRefresh.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txbRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txbRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbRefresh.Location = new System.Drawing.Point(31, 435);
            this.txbRefresh.Name = "txbRefresh";
            this.txbRefresh.Size = new System.Drawing.Size(160, 50);
            this.txbRefresh.TabIndex = 7;
            this.txbRefresh.Text = "Обновить изображения";
            this.txbRefresh.UseVisualStyleBackColor = false;
            this.txbRefresh.Click += new System.EventHandler(this.txbRefresh_Click);
            // 
            // btnAddAnkiCard
            // 
            this.btnAddAnkiCard.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAddAnkiCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAnkiCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAnkiCard.Location = new System.Drawing.Point(545, 435);
            this.btnAddAnkiCard.Name = "btnAddAnkiCard";
            this.btnAddAnkiCard.Size = new System.Drawing.Size(160, 50);
            this.btnAddAnkiCard.TabIndex = 8;
            this.btnAddAnkiCard.Text = "Добавить карточку Anki";
            this.btnAddAnkiCard.UseVisualStyleBackColor = false;
            this.btnAddAnkiCard.Click += new System.EventHandler(this.btnAddAnkiCard_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTranslate.Location = new System.Drawing.Point(308, 63);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(160, 50);
            this.btnTranslate.TabIndex = 1;
            this.btnTranslate.Text = "Перевести";
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Слово для перевода:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьПапкуКонтентаAnkiToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // изменитьПапкуКонтентаAnkiToolStripMenuItem
            // 
            this.изменитьПапкуКонтентаAnkiToolStripMenuItem.Name = "изменитьПапкуКонтентаAnkiToolStripMenuItem";
            this.изменитьПапкуКонтентаAnkiToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.изменитьПапкуКонтентаAnkiToolStripMenuItem.Text = "Изменить папку контента Anki";
            this.изменитьПапкуКонтентаAnkiToolStripMenuItem.Click += new System.EventHandler(this.изменитьПапкуКонтентаAnkiToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // txbSearchNew
            // 
            this.txbSearchNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbSearchNew.Location = new System.Drawing.Point(199, 31);
            this.txbSearchNew.Name = "txbSearchNew";
            this.txbSearchNew.Size = new System.Drawing.Size(457, 26);
            this.txbSearchNew.TabIndex = 3;
            // 
            // WinFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(787, 633);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WinFormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnkiCard Creator v.1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImg2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbWord;
        private System.Windows.Forms.TextBox txbTranslation;
        private System.Windows.Forms.TextBox txbTranscription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbImg1;
        private System.Windows.Forms.PictureBox pcbImg2;
        private System.Windows.Forms.PictureBox pcbImg3;
        private System.Windows.Forms.Button btnAddAnkiCard;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.RadioButton rbImg3;
        private System.Windows.Forms.RadioButton rbImg2;
        private System.Windows.Forms.RadioButton rbImg1;
        private System.Windows.Forms.Button txbRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьПапкуКонтентаAnkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox txbSearchNew;
    }
}

