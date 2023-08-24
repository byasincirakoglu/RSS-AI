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
            this.label1 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnAramaKod = new System.Windows.Forms.Button();
            this.txtAramaKod = new System.Windows.Forms.TextBox();
            this.OnizlemeButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(886, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DİNAMİK OTOMOTİV ETİKET";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // txtArama
            // 
            this.txtArama.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtArama.Location = new System.Drawing.Point(203, 69);
            this.txtArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArama.Multiline = true;
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(353, 38);
            this.txtArama.TabIndex = 13;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnArama
            // 
            this.btnArama.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnArama.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArama.ForeColor = System.Drawing.Color.White;
            this.btnArama.Location = new System.Drawing.Point(586, 69);
            this.btnArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(91, 38);
            this.btnArama.TabIndex = 17;
            this.btnArama.Text = "ARA";
            this.btnArama.UseVisualStyleBackColor = false;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // btnAramaKod
            // 
            this.btnAramaKod.BackColor = System.Drawing.Color.Black;
            this.btnAramaKod.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAramaKod.ForeColor = System.Drawing.Color.White;
            this.btnAramaKod.Location = new System.Drawing.Point(586, 111);
            this.btnAramaKod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAramaKod.Name = "btnAramaKod";
            this.btnAramaKod.Size = new System.Drawing.Size(91, 38);
            this.btnAramaKod.TabIndex = 17;
            this.btnAramaKod.Text = "ARA";
            this.btnAramaKod.UseVisualStyleBackColor = false;
            this.btnAramaKod.Click += new System.EventHandler(this.btnAramaKod_Click);
            // 
            // txtAramaKod
            // 
            this.txtAramaKod.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAramaKod.Location = new System.Drawing.Point(203, 111);
            this.txtAramaKod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAramaKod.Multiline = true;
            this.txtAramaKod.Name = "txtAramaKod";
            this.txtAramaKod.Size = new System.Drawing.Size(353, 38);
            this.txtAramaKod.TabIndex = 18;
            this.txtAramaKod.TextChanged += new System.EventHandler(this.txtAramaKod_TextChanged);
            // 
            // OnizlemeButton
            // 
            this.OnizlemeButton.BackColor = System.Drawing.Color.Black;
            this.OnizlemeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.OnizlemeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.OnizlemeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.OnizlemeButton.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnizlemeButton.ForeColor = System.Drawing.Color.White;
            this.OnizlemeButton.Location = new System.Drawing.Point(713, 94);
            this.OnizlemeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OnizlemeButton.Name = "OnizlemeButton";
            this.OnizlemeButton.Size = new System.Drawing.Size(147, 39);
            this.OnizlemeButton.TabIndex = 19;
            this.OnizlemeButton.Text = "ÖNİZLEME";
            this.OnizlemeButton.UseVisualStyleBackColor = false;
            this.OnizlemeButton.Click += new System.EventHandler(this.OnizlemeButton1_Click1);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(2609, 1078);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 34);
            this.label2.TabIndex = 16;
            this.label2.Text = "CARİ İSİM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 34);
            this.label3.TabIndex = 20;
            this.label3.Text = "CARİ KOD";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(2803, 1420);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OnizlemeButton);
            this.Controls.Add(this.txtAramaKod);
            this.Controls.Add(this.btnAramaKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form";
            this.Text = "DİNAMİK OTOMOTİV ETİKET";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            Helper.Helper.InitialData(dataGridView1);
        }


        
        


        #endregion

        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnAramaKod;
        private System.Windows.Forms.TextBox txtAramaKod;
        private System.Windows.Forms.Button OnizlemeButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
    }
}

