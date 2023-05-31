using System.Windows.Forms;
using System;
namespace VisualizzatoreBinario
{
    partial class Form1
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
            this.pictureBox1 = new PictureBox();
            // label per la regolazione delle finestre di Data1 e Data2
            this.btDvgData = new System.Windows.Forms.Button();

            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txHeader = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txColonne = new System.Windows.Forms.TextBox();
            this.dgvHeader = new System.Windows.Forms.DataGridView();
            this.btOpen = new System.Windows.Forms.Button();
            this.dgvHeader2 = new System.Windows.Forms.DataGridView();
            this.dgvData2 = new System.Windows.Forms.DataGridView();
            this.btOpen2 = new System.Windows.Forms.Button();
            this.lbInt = new System.Windows.Forms.Label();
            this.lbFloat = new System.Windows.Forms.Label();
            this.lbF1Len = new System.Windows.Forms.Label();
            this.lbF2Len = new System.Windows.Forms.Label();
            this.lbNDiff = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txFinoA = new System.Windows.Forms.TextBox();
            this.txDa = new System.Windows.Forms.TextBox();
            this.txHeader2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbCerca = new System.Windows.Forms.TextBox();
            this.btCerca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData2)).BeginInit();
            this.SuspendLayout();
            //
            //pitctureBox1 
            //
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 196);
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.TabStop = false;
            this.pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            this.pictureBox1.TabIndex = 27;
            //
            //mouse NEW
            //
            this.btDvgData.AutoSize = true;
            this.btDvgData.Location = new System.Drawing.Point(9, 9);
            this.btDvgData.Name = "btDvgData";
            this.btDvgData.Size = new System.Drawing.Size(42, 13);
            this.btDvgData.TabIndex = 27;
            this.btDvgData.Text = "btDvgData";

            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
               | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 196);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(768, 448);
            this.dgvData.TabIndex = 0;
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvGeneral_SelectionChanged);
            // 
            // txHeader
            // 
            this.txHeader.Location = new System.Drawing.Point(12, 25);
            this.txHeader.Name = "txHeader";
            this.txHeader.Size = new System.Drawing.Size(100, 20);
            this.txHeader.TabIndex = 1;
            this.txHeader.Text = "100";
            this.txHeader.TextChanged += new System.EventHandler(this.txHeader_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Header";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "numColonne";
            // 
            // txColonne
            // 
            this.txColonne.Location = new System.Drawing.Point(12, 64);
            this.txColonne.Name = "txColonne";
            this.txColonne.Size = new System.Drawing.Size(100, 20);
            this.txColonne.TabIndex = 3;
            this.txColonne.Text = "24";
            this.txColonne.TextChanged += new System.EventHandler(this.txColonne_TextChanged);
            // 
            // dgvHeader
            // 
            this.dgvHeader.AllowUserToAddRows = false;
            this.dgvHeader.AllowUserToDeleteRows = false;
            this.dgvHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeader.Location = new System.Drawing.Point(12, 90);
            this.dgvHeader.Name = "dgvHeader";
            this.dgvHeader.ReadOnly = true;
            this.dgvHeader.Size = new System.Drawing.Size(768, 100);
            this.dgvHeader.TabIndex = 5;
            this.dgvHeader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHeaderGeneral_CellContentClick);
            this.dgvHeader.SelectionChanged += new System.EventHandler(this.dgvGeneral_SelectionChanged);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(230, 24);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 6;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // dgvHeader2
            // 
            this.dgvHeader2.AllowUserToAddRows = false;
            this.dgvHeader2.AllowUserToDeleteRows = false;
            this.dgvHeader2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeader2.Location = new System.Drawing.Point(786, 90);
            this.dgvHeader2.Name = "dgvHeader2";
            this.dgvHeader2.ReadOnly = true;
            this.dgvHeader2.Size = new System.Drawing.Size(874, 100);
            this.dgvHeader2.TabIndex = 8;
            this.dgvHeader2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHeaderGeneral_CellContentClick);
            this.dgvHeader2.SelectionChanged += new System.EventHandler(this.dgvGeneral_SelectionChanged);
            // 
            // dgvData2
            // 
            this.dgvData2.AllowUserToAddRows = false;
            this.dgvData2.AllowUserToDeleteRows = false;
            this.dgvData2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
               | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData2.Location = new System.Drawing.Point(786, 196);
            this.dgvData2.Name = "dgvData2";
            this.dgvData2.Size = new System.Drawing.Size(874, 448);
            this.dgvData2.TabIndex = 7;
            this.dgvData2.SelectionChanged += new System.EventHandler(this.dgvGeneral_SelectionChanged);
            // 
            // btOpen2
            // 
            this.btOpen2.Location = new System.Drawing.Point(230, 61);
            this.btOpen2.Name = "btOpen2";
            this.btOpen2.Size = new System.Drawing.Size(75, 23);
            this.btOpen2.TabIndex = 9;
            this.btOpen2.Text = "Open";
            this.btOpen2.UseVisualStyleBackColor = true;
            this.btOpen2.Click += new System.EventHandler(this.btOpen2_Click);
            // 
            // lbInt
            // 
            this.lbInt.AutoSize = true;
            this.lbInt.Location = new System.Drawing.Point(320, 28);
            this.lbInt.Name = "lbInt";
            this.lbInt.Size = new System.Drawing.Size(56, 13);
            this.lbInt.TabIndex = 11;
            this.lbInt.Text = "Header int";
            // 
            // lbFloat
            // 
            this.lbFloat.AutoSize = true;
            this.lbFloat.Location = new System.Drawing.Point(320, 47);
            this.lbFloat.Name = "lbFloat";
            this.lbFloat.Size = new System.Drawing.Size(65, 13);
            this.lbFloat.TabIndex = 12;
            this.lbFloat.Text = "Header float";
            // 
            // lbF1Len
            // 
            this.lbF1Len.AutoSize = true;
            this.lbF1Len.Location = new System.Drawing.Point(632, 71);
            this.lbF1Len.Name = "lbF1Len";
            this.lbF1Len.Size = new System.Drawing.Size(42, 13);
            this.lbF1Len.TabIndex = 13;
            this.lbF1Len.Text = "Header";
            // 
            // lbF2Len
            // 
            this.lbF2Len.AutoSize = true;
            this.lbF2Len.Location = new System.Drawing.Point(819, 74);
            this.lbF2Len.Name = "lbF2Len";
            this.lbF2Len.Size = new System.Drawing.Size(42, 13);
            this.lbF2Len.TabIndex = 14;
            this.lbF2Len.Text = "Header";
            // 
            // lbNDiff
            // 
            this.lbNDiff.AutoSize = true;
            this.lbNDiff.Location = new System.Drawing.Point(518, 28);
            this.lbNDiff.Name = "lbNDiff";
            this.lbNDiff.Size = new System.Drawing.Size(29, 13);
            this.lbNDiff.TabIndex = 15;
            this.lbNDiff.Text = "nDiff";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Numero",
            "Hex",
            "String"});
            this.comboBox1.Location = new System.Drawing.Point(635, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1074, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Concat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txFinoA
            // 
            this.txFinoA.Location = new System.Drawing.Point(862, 2);
            this.txFinoA.Name = "txFinoA";
            this.txFinoA.Size = new System.Drawing.Size(100, 20);
            this.txFinoA.TabIndex = 18;
            this.txFinoA.Text = "Fino A";
            // 
            // txDa
            // 
            this.txDa.Location = new System.Drawing.Point(968, 2);
            this.txDa.Name = "txDa";
            this.txDa.Size = new System.Drawing.Size(100, 20);
            this.txDa.TabIndex = 19;
            this.txDa.Text = "Da";
            // 
            // txHeader2
            // 
            this.txHeader2.Location = new System.Drawing.Point(118, 25);
            this.txHeader2.Name = "txHeader2";
            this.txHeader2.Size = new System.Drawing.Size(100, 20);
            this.txHeader2.TabIndex = 20;
            this.txHeader2.Text = "100";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(635, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Salva1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btSalva1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(716, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Salva2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btSalva2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(862, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Salva1 come numeri";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbCerca
            // 
            this.tbCerca.Location = new System.Drawing.Point(1010, 41);
            this.tbCerca.Name = "tbCerca";
            this.tbCerca.Size = new System.Drawing.Size(100, 20);
            this.tbCerca.TabIndex = 24;
            // 
            // btCerca
            // 
            this.btCerca.Location = new System.Drawing.Point(1116, 41);
            this.btCerca.Name = "btCerca";
            this.btCerca.Size = new System.Drawing.Size(75, 19);
            this.btCerca.TabIndex = 25;
            this.btCerca.Text = "Cerca";
            this.btCerca.UseVisualStyleBackColor = true;
            this.btCerca.Click += new System.EventHandler(this.btCerca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 656);
            this.Controls.Add(this.btCerca);
            this.Controls.Add(this.tbCerca);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txHeader2);
            this.Controls.Add(this.txDa);
            this.Controls.Add(this.txFinoA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbNDiff);
            this.Controls.Add(this.lbF2Len);
            this.Controls.Add(this.lbF1Len);
            this.Controls.Add(this.lbFloat);
            this.Controls.Add(this.lbInt);
            this.Controls.Add(this.btOpen2);
            this.Controls.Add(this.dgvHeader2);
            this.Controls.Add(this.dgvData2);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.dgvHeader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txColonne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txHeader);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btDvgData);//NEW
            this.Controls.Add(this.pictureBox1);//NEW
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btDvgData;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txColonne;
        private System.Windows.Forms.DataGridView dgvHeader;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.DataGridView dgvHeader2;
        private System.Windows.Forms.DataGridView dgvData2;
        private System.Windows.Forms.Button btOpen2;
        private System.Windows.Forms.Label lbInt;
        private System.Windows.Forms.Label lbF1Len;
        private System.Windows.Forms.Label lbF2Len;
        private System.Windows.Forms.Label lbNDiff;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txFinoA;
        private System.Windows.Forms.TextBox txDa;
        private System.Windows.Forms.Label lbFloat;
        private System.Windows.Forms.TextBox txHeader2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbCerca;
        private System.Windows.Forms.Button btCerca;

    }
}