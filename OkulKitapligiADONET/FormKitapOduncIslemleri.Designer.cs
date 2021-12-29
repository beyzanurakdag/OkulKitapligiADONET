
namespace OkulKitapligiADONET
{
    partial class FormKitapOduncIslemleri
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
            this.comboBoxOgrenci = new System.Windows.Forms.ComboBox();
            this.comboBoxKitap = new System.Windows.Forms.ComboBox();
            this.groupBoxOgrenci = new System.Windows.Forms.GroupBox();
            this.groupBoxKitap = new System.Windows.Forms.GroupBox();
            this.groupBoxOduncTarihler = new System.Windows.Forms.GroupBox();
            this.dateTimePickerBitis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewOduncKitaplar = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kitabiTeslimEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UC_MyButtonOduncAl = new OkulKitapligiADONET.UC_MyButton();
            this.uC_MyButton1 = new OkulKitapligiADONET.UC_MyButton();
            this.groupBoxOgrenci.SuspendLayout();
            this.groupBoxKitap.SuspendLayout();
            this.groupBoxOduncTarihler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOduncKitaplar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxOgrenci
            // 
            this.comboBoxOgrenci.FormattingEnabled = true;
            this.comboBoxOgrenci.Location = new System.Drawing.Point(8, 41);
            this.comboBoxOgrenci.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOgrenci.Name = "comboBoxOgrenci";
            this.comboBoxOgrenci.Size = new System.Drawing.Size(347, 24);
            this.comboBoxOgrenci.TabIndex = 0;
            this.comboBoxOgrenci.SelectedIndexChanged += new System.EventHandler(this.comboBoxOgrenci_SelectedIndexChanged);
            // 
            // comboBoxKitap
            // 
            this.comboBoxKitap.FormattingEnabled = true;
            this.comboBoxKitap.Location = new System.Drawing.Point(8, 41);
            this.comboBoxKitap.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKitap.Name = "comboBoxKitap";
            this.comboBoxKitap.Size = new System.Drawing.Size(347, 24);
            this.comboBoxKitap.TabIndex = 1;
            this.comboBoxKitap.SelectedIndexChanged += new System.EventHandler(this.comboBoxKitap_SelectedIndexChanged);
            // 
            // groupBoxOgrenci
            // 
            this.groupBoxOgrenci.Controls.Add(this.comboBoxOgrenci);
            this.groupBoxOgrenci.Location = new System.Drawing.Point(16, 28);
            this.groupBoxOgrenci.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOgrenci.Name = "groupBoxOgrenci";
            this.groupBoxOgrenci.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOgrenci.Size = new System.Drawing.Size(384, 94);
            this.groupBoxOgrenci.TabIndex = 2;
            this.groupBoxOgrenci.TabStop = false;
            this.groupBoxOgrenci.Text = "Öğrenci Seçiniz:";
            // 
            // groupBoxKitap
            // 
            this.groupBoxKitap.Controls.Add(this.comboBoxKitap);
            this.groupBoxKitap.Location = new System.Drawing.Point(16, 151);
            this.groupBoxKitap.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxKitap.Name = "groupBoxKitap";
            this.groupBoxKitap.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxKitap.Size = new System.Drawing.Size(384, 94);
            this.groupBoxKitap.TabIndex = 3;
            this.groupBoxKitap.TabStop = false;
            this.groupBoxKitap.Text = "Kitap Seçiniz:";
            // 
            // groupBoxOduncTarihler
            // 
            this.groupBoxOduncTarihler.Controls.Add(this.UC_MyButtonOduncAl);
            this.groupBoxOduncTarihler.Controls.Add(this.uC_MyButton1);
            this.groupBoxOduncTarihler.Controls.Add(this.dateTimePickerBitis);
            this.groupBoxOduncTarihler.Controls.Add(this.label2);
            this.groupBoxOduncTarihler.Controls.Add(this.label1);
            this.groupBoxOduncTarihler.Controls.Add(this.dateTimePickerBaslangic);
            this.groupBoxOduncTarihler.Location = new System.Drawing.Point(411, 28);
            this.groupBoxOduncTarihler.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOduncTarihler.Name = "groupBoxOduncTarihler";
            this.groupBoxOduncTarihler.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOduncTarihler.Size = new System.Drawing.Size(328, 217);
            this.groupBoxOduncTarihler.TabIndex = 2;
            this.groupBoxOduncTarihler.TabStop = false;
            this.groupBoxOduncTarihler.Text = "Tarihleri Seçiniz:";
            // 
            // dateTimePickerBitis
            // 
            this.dateTimePickerBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBitis.Location = new System.Drawing.Point(21, 131);
            this.dateTimePickerBitis.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerBitis.Name = "dateTimePickerBitis";
            this.dateTimePickerBitis.Size = new System.Drawing.Size(265, 23);
            this.dateTimePickerBitis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç Tarihi:";
            // 
            // dateTimePickerBaslangic
            // 
            this.dateTimePickerBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBaslangic.Location = new System.Drawing.Point(20, 62);
            this.dateTimePickerBaslangic.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerBaslangic.Name = "dateTimePickerBaslangic";
            this.dateTimePickerBaslangic.Size = new System.Drawing.Size(265, 23);
            this.dateTimePickerBaslangic.TabIndex = 0;
            this.dateTimePickerBaslangic.ValueChanged += new System.EventHandler(this.dateTimePickerBaslangic_ValueChanged);
            // 
            // dataGridViewOduncKitaplar
            // 
            this.dataGridViewOduncKitaplar.AllowUserToAddRows = false;
            this.dataGridViewOduncKitaplar.AllowUserToDeleteRows = false;
            this.dataGridViewOduncKitaplar.AllowUserToOrderColumns = true;
            this.dataGridViewOduncKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOduncKitaplar.Location = new System.Drawing.Point(16, 266);
            this.dataGridViewOduncKitaplar.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOduncKitaplar.Name = "dataGridViewOduncKitaplar";
            this.dataGridViewOduncKitaplar.ReadOnly = true;
            this.dataGridViewOduncKitaplar.Size = new System.Drawing.Size(723, 192);
            this.dataGridViewOduncKitaplar.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitabiTeslimEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // kitabiTeslimEtToolStripMenuItem
            // 
            this.kitabiTeslimEtToolStripMenuItem.Name = "kitabiTeslimEtToolStripMenuItem";
            this.kitabiTeslimEtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kitabiTeslimEtToolStripMenuItem.Text = "Kitabı Teslim Et";
            this.kitabiTeslimEtToolStripMenuItem.Click += new System.EventHandler(this.kitabiTeslimEtToolStripMenuItem_Click);
            // 
            // UC_MyButtonOduncAl
            // 
            this.UC_MyButtonOduncAl.Location = new System.Drawing.Point(21, 176);
            this.UC_MyButtonOduncAl.Margin = new System.Windows.Forms.Padding(4);
            this.UC_MyButtonOduncAl.Name = "UC_MyButtonOduncAl";
            this.UC_MyButtonOduncAl.Size = new System.Drawing.Size(265, 33);
            this.UC_MyButtonOduncAl.TabIndex = 5;
            // 
            // uC_MyButton1
            // 
            this.uC_MyButton1.Location = new System.Drawing.Point(32, 261);
            this.uC_MyButton1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uC_MyButton1.Name = "uC_MyButton1";
            this.uC_MyButton1.Size = new System.Drawing.Size(400, 62);
            this.uC_MyButton1.TabIndex = 4;
            // 
            // FormKitapOduncIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 470);
            this.Controls.Add(this.dataGridViewOduncKitaplar);
            this.Controls.Add(this.groupBoxOduncTarihler);
            this.Controls.Add(this.groupBoxKitap);
            this.Controls.Add(this.groupBoxOgrenci);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKitapOduncIslemleri";
            this.Text = "HOŞGELDİNİZ... KİTAP ÖDÜNÇ ALIM FORMU";
            this.Load += new System.EventHandler(this.FormKitapOduncIslemleri_Load);
            this.groupBoxOgrenci.ResumeLayout(false);
            this.groupBoxKitap.ResumeLayout(false);
            this.groupBoxOduncTarihler.ResumeLayout(false);
            this.groupBoxOduncTarihler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOduncKitaplar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOgrenci;
        private System.Windows.Forms.ComboBox comboBoxKitap;
        private System.Windows.Forms.GroupBox groupBoxOgrenci;
        private System.Windows.Forms.GroupBox groupBoxKitap;
        private System.Windows.Forms.GroupBox groupBoxOduncTarihler;
        private UC_MyButton uC_MyButton1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOduncKitaplar;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangic;
        private UC_MyButton UC_MyButtonOduncAl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitabiTeslimEtToolStripMenuItem;
    }
}