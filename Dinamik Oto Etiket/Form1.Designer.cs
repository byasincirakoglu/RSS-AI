using Dinamik_Oto_Etiket.DataConnection.MSSQL;
using Dinamik_Oto_Etiket.Helper;
using System;
using System.Data;

namespace Dinamik_Oto_Etiket
{
    partial class Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btnCari_KodArama = new System.Windows.Forms.Button();
            this.txtAramaKod = new System.Windows.Forms.TextBox();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Cari_Arama = new System.Windows.Forms.TextBox();
            this.cari_isimLabel = new System.Windows.Forms.Label();
            this.btnCari_IsımArama = new System.Windows.Forms.Button();
            this.cari_KodLabel = new System.Windows.Forms.Label();
            this.OnizlemeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnCari_KodArama
            // 
            this.btnCari_KodArama.BackColor = System.Drawing.Color.Black;
            this.btnCari_KodArama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCari_KodArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari_KodArama.ForeColor = System.Drawing.Color.White;
            this.btnCari_KodArama.Location = new System.Drawing.Point(545, 49);
            this.btnCari_KodArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCari_KodArama.Name = "btnCari_KodArama";
            this.btnCari_KodArama.Size = new System.Drawing.Size(111, 40);
            this.btnCari_KodArama.TabIndex = 19;
            this.btnCari_KodArama.Text = "ARA";
            this.btnCari_KodArama.UseVisualStyleBackColor = false;
            this.btnCari_KodArama.Click += new System.EventHandler(this.btnCari_KodArama_Click);
            // 
            // txtAramaKod
            // 
            this.txtAramaKod.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAramaKod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAramaKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAramaKod.Location = new System.Drawing.Point(274, 49);
            this.txtAramaKod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAramaKod.Multiline = true;
            this.txtAramaKod.Name = "txtAramaKod";
            this.txtAramaKod.Size = new System.Drawing.Size(265, 40);
            this.txtAramaKod.TabIndex = 18;
            this.txtAramaKod.TextChanged += new System.EventHandler(this.txtAramaKod_TextChanged);
            this.txtAramaKod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAramaKod_KeyDown);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(718, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DİNAMİK OTOMOTİV ETİKET";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1902, 1033);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(3, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1896, 909);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Tag = "";
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.Resize += new System.EventHandler(this.Form1_Resize);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.05674F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.05654F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.717238F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.16948F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 520F));
            this.tableLayoutPanel2.Controls.Add(this.btnCari_KodArama, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtAramaKod, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_Cari_Arama, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cari_isimLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCari_IsımArama, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cari_KodLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.OnizlemeButton, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1896, 114);
            this.tableLayoutPanel2.TabIndex = 13;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // txt_Cari_Arama
            // 
            this.txt_Cari_Arama.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Cari_Arama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Cari_Arama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Cari_Arama.Location = new System.Drawing.Point(274, 2);
            this.txt_Cari_Arama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Cari_Arama.Multiline = true;
            this.txt_Cari_Arama.Name = "txt_Cari_Arama";
            this.txt_Cari_Arama.Size = new System.Drawing.Size(265, 43);
            this.txt_Cari_Arama.TabIndex = 13;
            this.txt_Cari_Arama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            this.txt_Cari_Arama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArama_KeyDown);
            this.txt_Cari_Arama.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtArama_KeyUp);
            // 
            // cari_isimLabel
            // 
            this.cari_isimLabel.AutoSize = true;
            this.cari_isimLabel.BackColor = System.Drawing.Color.Black;
            this.cari_isimLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cari_isimLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cari_isimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_isimLabel.ForeColor = System.Drawing.Color.White;
            this.cari_isimLabel.Location = new System.Drawing.Point(3, 0);
            this.cari_isimLabel.Name = "cari_isimLabel";
            this.cari_isimLabel.Size = new System.Drawing.Size(265, 47);
            this.cari_isimLabel.TabIndex = 16;
            this.cari_isimLabel.Text = "CARİ İSİM";
            this.cari_isimLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCari_IsımArama
            // 
            this.btnCari_IsımArama.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCari_IsımArama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCari_IsımArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari_IsımArama.ForeColor = System.Drawing.Color.White;
            this.btnCari_IsımArama.Location = new System.Drawing.Point(545, 2);
            this.btnCari_IsımArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCari_IsımArama.Name = "btnCari_IsımArama";
            this.btnCari_IsımArama.Size = new System.Drawing.Size(111, 43);
            this.btnCari_IsımArama.TabIndex = 14;
            this.btnCari_IsımArama.Text = "ARA";
            this.btnCari_IsımArama.UseVisualStyleBackColor = false;
            this.btnCari_IsımArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // cari_KodLabel
            // 
            this.cari_KodLabel.AutoSize = true;
            this.cari_KodLabel.BackColor = System.Drawing.Color.Black;
            this.cari_KodLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cari_KodLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cari_KodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cari_KodLabel.ForeColor = System.Drawing.Color.White;
            this.cari_KodLabel.Location = new System.Drawing.Point(3, 47);
            this.cari_KodLabel.Name = "cari_KodLabel";
            this.cari_KodLabel.Size = new System.Drawing.Size(265, 44);
            this.cari_KodLabel.TabIndex = 20;
            this.cari_KodLabel.Text = "CARİ KOD";
            // 
            // OnizlemeButton
            // 
            this.OnizlemeButton.BackColor = System.Drawing.Color.Black;
            this.OnizlemeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OnizlemeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.OnizlemeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.OnizlemeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.OnizlemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnizlemeButton.ForeColor = System.Drawing.Color.White;
            this.OnizlemeButton.Location = new System.Drawing.Point(1377, 2);
            this.OnizlemeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OnizlemeButton.Name = "OnizlemeButton";
            this.OnizlemeButton.Size = new System.Drawing.Size(516, 43);
            this.OnizlemeButton.TabIndex = 20;
            this.OnizlemeButton.Text = "ÖNİZLEME";
            this.OnizlemeButton.UseVisualStyleBackColor = false;
            this.OnizlemeButton.Click += new System.EventHandler(this.OnizlemeButton1_Click1);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1080, 960);
            this.Name = "Form";
            this.Text = "DİNAMİK OTOMOTİV ETİKET";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        
        


        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btnCari_KodArama;
        private System.Windows.Forms.TextBox txtAramaKod;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label cari_KodLabel;
        private System.Windows.Forms.Button OnizlemeButton;
        private System.Windows.Forms.TextBox txt_Cari_Arama;
        private System.Windows.Forms.Label cari_isimLabel;
        private System.Windows.Forms.Button btnCari_IsımArama;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

