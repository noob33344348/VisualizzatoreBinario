using System.Windows.Forms;
using System;
using System.Drawing;

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
            this.btDgvData = new System.Windows.Forms.Button();
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
            // btDgvData
            // 
            this.btDgvData.AutoSize = true;
            this.btDgvData.Location = new System.Drawing.Point(xPos, 369);
            this.btDgvData.Margin = new System.Windows.Forms.Padding(4);
            this.btDgvData.Name = "btDgvData";
            this.btDgvData.Size = new System.Drawing.Size(42, 26);
            this.btDgvData.TabIndex = 27;
            this.btDgvData.Text = " = ";
            this.btDgvData.MouseDown += this.btDgvData_MouseDown;
            //this.btDgvData.MouseUp += this.btDgvData_MouseUp;
            this.btDgvData.MouseMove += this.btDgvData_MouseMove;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(16, 241);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(1024, 551);
            this.dgvData.TabIndex = 0;
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvGeneral_SelectionChanged);
            // 
            // txHeader
            // 
            this.txHeader.Location = new System.Drawing.Point(16, 31);
            this.txHeader.Margin = new System.Windows.Forms.Padding(4);
            this.txHeader.Name = "txHeader";
            this.txHeader.Size = new System.Drawing.Size(132, 22);
            this.txHeader.TabIndex = 1;
            this.txHeader.Text = "100";
            this.txHeader.TextChanged += new System.EventHandler(this.txHeader_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Header";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "numColonne";
            // 
            // txColonne
            // 
            this.txColonne.Location = new System.Drawing.Point(16, 79);
            this.txColonne.Margin = new System.Windows.Forms.Padding(4);
            this.txColonne.Name = "txColonne";
            this.txColonne.Size = new System.Drawing.Size(132, 22);
            this.txColonne.TabIndex = 3;
            this.txColonne.Text = "24";
            this.txColonne.TextChanged += new System.EventHandler(this.txColonne_TextChanged);
            // 
            // dgvHeader
            // 
            this.dgvHeader.AllowUserToAddRows = false;
            this.dgvHeader.AllowUserToDeleteRows = false;
            this.dgvHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeader.Location = new System.Drawing.Point(16, 111);
            this.dgvHeader.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHeader.Name = "dgvHeader";
            this.dgvHeader.ReadOnly = true;
            this.dgvHeader.RowHeadersWidth = 51;
            this.dgvHeader.Size = new System.Drawing.Size(1024, 123);
            this.dgvHeader.TabIndex = 5;
            this.dgvHeader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHeaderGeneral_CellContentClick);
            this.dgvHeader.SelectionChanged += new System.EventHandler(this.dgvGeneral_SelectionChanged);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(307, 30);
            this.btOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(100, 28);
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
            this.dgvHeader2.Location = new System.Drawing.Point(1048, 111);
            this.dgvHeader2.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHeader2.Name = "dgvHeader2";
            this.dgvHeader2.ReadOnly = true;
            this.dgvHeader2.RowHeadersWidth = 51;
            this.dgvHeader2.Size = new System.Drawing.Size(1165, 123);
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
            this.dgvData2.Location = new System.Drawing.Point(1048, 241);
            this.dgvData2.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData2.Name = "dgvData2";
            this.dgvData2.RowHeadersWidth = 51;
            this.dgvData2.Size = new System.Drawing.Size(1165, 551);
            this.dgvData2.TabIndex = 7;
            this.dgvData2.SelectionChanged += new System.EventHandler(this.dgvGeneral_SelectionChanged);
            // 
            // btOpen2
            // 
            this.btOpen2.Location = new System.Drawing.Point(307, 75);
            this.btOpen2.Margin = new System.Windows.Forms.Padding(4);
            this.btOpen2.Name = "btOpen2";
            this.btOpen2.Size = new System.Drawing.Size(100, 28);
            this.btOpen2.TabIndex = 9;
            this.btOpen2.Text = "Open";
            this.btOpen2.UseVisualStyleBackColor = true;
            this.btOpen2.Click += new System.EventHandler(this.btOpen2_Click);
            // 
            // lbInt
            // 
            this.lbInt.AutoSize = true;
            this.lbInt.Location = new System.Drawing.Point(427, 34);
            this.lbInt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInt.Name = "lbInt";
            this.lbInt.Size = new System.Drawing.Size(69, 16);
            this.lbInt.TabIndex = 11;
            this.lbInt.Text = "Header int";
            // 
            // lbFloat
            // 
            this.lbFloat.AutoSize = true;
            this.lbFloat.Location = new System.Drawing.Point(427, 58);
            this.lbFloat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFloat.Name = "lbFloat";
            this.lbFloat.Size = new System.Drawing.Size(81, 16);
            this.lbFloat.TabIndex = 12;
            this.lbFloat.Text = "Header float";
            // 
            // lbF1Len
            // 
            this.lbF1Len.AutoSize = true;
            this.lbF1Len.Location = new System.Drawing.Point(843, 87);
            this.lbF1Len.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbF1Len.Name = "lbF1Len";
            this.lbF1Len.Size = new System.Drawing.Size(53, 16);
            this.lbF1Len.TabIndex = 13;
            this.lbF1Len.Text = "Header";
            // 
            // lbF2Len
            // 
            this.lbF2Len.AutoSize = true;
            this.lbF2Len.Location = new System.Drawing.Point(1092, 91);
            this.lbF2Len.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbF2Len.Name = "lbF2Len";
            this.lbF2Len.Size = new System.Drawing.Size(53, 16);
            this.lbF2Len.TabIndex = 14;
            this.lbF2Len.Text = "Header";
            // 
            // lbNDiff
            // 
            this.lbNDiff.AutoSize = true;
            this.lbNDiff.Location = new System.Drawing.Point(691, 34);
            this.lbNDiff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNDiff.Name = "lbNDiff";
            this.lbNDiff.Size = new System.Drawing.Size(33, 16);
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
            this.comboBox1.Location = new System.Drawing.Point(847, 7);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1432, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Concat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txFinoA
            // 
            this.txFinoA.Location = new System.Drawing.Point(1149, 2);
            this.txFinoA.Margin = new System.Windows.Forms.Padding(4);
            this.txFinoA.Name = "txFinoA";
            this.txFinoA.Size = new System.Drawing.Size(132, 22);
            this.txFinoA.TabIndex = 18;
            this.txFinoA.Text = "Fino A";
            // 
            // txDa
            // 
            this.txDa.Location = new System.Drawing.Point(1291, 2);
            this.txDa.Margin = new System.Windows.Forms.Padding(4);
            this.txDa.Name = "txDa";
            this.txDa.Size = new System.Drawing.Size(132, 22);
            this.txDa.TabIndex = 19;
            this.txDa.Text = "Da";
            // 
            // txHeader2
            // 
            this.txHeader2.Location = new System.Drawing.Point(157, 31);
            this.txHeader2.Margin = new System.Windows.Forms.Padding(4);
            this.txHeader2.Name = "txHeader2";
            this.txHeader2.Size = new System.Drawing.Size(132, 22);
            this.txHeader2.TabIndex = 20;
            this.txHeader2.Text = "100";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(847, 46);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 21;
            this.button2.Text = "Salva1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btSalva1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(955, 46);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 22;
            this.button3.Text = "Salva2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btSalva2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1149, 46);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 28);
            this.button4.TabIndex = 23;
            this.button4.Text = "Salva1 come numeri";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbCerca
            // 
            this.tbCerca.Location = new System.Drawing.Point(1347, 50);
            this.tbCerca.Margin = new System.Windows.Forms.Padding(4);
            this.tbCerca.Name = "tbCerca";
            this.tbCerca.Size = new System.Drawing.Size(132, 22);
            this.tbCerca.TabIndex = 24;
            // 
            // btCerca
            // 
            this.btCerca.Location = new System.Drawing.Point(1488, 50);
            this.btCerca.Margin = new System.Windows.Forms.Padding(4);
            this.btCerca.Name = "btCerca";
            this.btCerca.Size = new System.Drawing.Size(100, 23);
            this.btCerca.TabIndex = 25;
            this.btCerca.Text = "Cerca";
            this.btCerca.UseVisualStyleBackColor = true;
            this.btCerca.Click += new System.EventHandler(this.BtCerca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 807);
            this.Controls.Add(this.btDgvData);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btDgvData;
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