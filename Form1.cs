using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace VisualizzatoreBinario
{
    public partial class Form1 : Form
    {
        struct data
        {
            public byte[] value;
            public bool[] diff;
        }

        data fData = new data();
        data fData2 = new data();
        
        //Valori inizializzati su comboBox1_SelectedIndexChanged
        private int r1Index, r2Index, fr1Index, fr2Index, sr1Index, sr2Index;
        //Valori inizializzatu su Form1()
        private DataGridViewCellStyle RedStyle;
        private DataGridViewCellStyle SelectedRedStyle;
        private DataGridViewCellStyle GreenStyle;
        private DataGridViewCellStyle SelectedGreenStyle;
        public Form1()
        {
            InitializeComponent();

            RedStyle = new DataGridViewCellStyle();
            SelectedRedStyle = new DataGridViewCellStyle();
            GreenStyle = new DataGridViewCellStyle();
            SelectedGreenStyle = new DataGridViewCellStyle();

            RedStyle.BackColor = Color.Red;
            SelectedRedStyle.BackColor = Color.DarkRed;
            GreenStyle.BackColor = Color.LightGreen;
            SelectedGreenStyle.BackColor = Color.DarkOliveGreen;
        }
        private void ForEachRIn(ref DataGridView dgvGeneral, ref List<byte> b)
        {
            foreach (DataGridViewRow r in dgvGeneral.Rows)
                foreach (DataGridViewCell c in r.Cells)
                    if (c.Value != null)
                        b.Add(Convert.ToByte(c.Value));
        }
        private void clearDgv(DataGridView data)
        {
            data.Rows.Clear();
            data.Columns.Clear();
        }
        private void processData()
        {
            int maxDiff = Convert.ToInt32(tbMaxDiff.Text);
            int j = 0;
            int i = 0;
            while (i < fData.value.Length && j < fData2.value.Length)
            {
                if (fData.value[i] == fData2.value[j])
                {
                    fData.diff[i++] = false;
                    fData2.diff[j++] = false;
                }
                else
                {
                    int k;
                    for (k = 0; k + j < fData2.value.Length && k < maxDiff && fData.value[i] != fData2.value[j + k]; k++)
                    {
                        fData2.diff[k + j] = true;
                    }
                    if (k == maxDiff)
                    {
                        for (int l = 0; l < k; l++)
                        {
                            fData2.diff[l + j] = false;
                        }
                        fData.diff[i++] = true;
                    }
                    else
                    {
                        fData.diff[i] = false;
                        j += k;
                    }
                }
            }
        }
        private void ProcessFile(ref data data, DataGridView dgvH, DataGridView dgvD, int Header)
        {
            try
            {
                int nColonne = int.Parse(txColonne.Text);
                int dCounter = 0;
                int traslHeader = data.value == fData.value ? 0 : int.Parse(txHeader2.Text) - int.Parse(txHeader.Text);
                for (int i = 0; i < Header; i++)
                {
                    DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                    dgvc.Width = 28;
                    dgvH.Columns.Add(dgvc);
                }
                while (dCounter < Header)
                {
                    DataGridViewRow dgvr = new DataGridViewRow();
                    dgvr.HeaderCell.Value = dCounter.ToString();
                    for (int i = 0; dCounter < Header && i < 20; i++)
                    {
                        dgvr.Cells.Add(getByteCell(data.value[dCounter]));
                        dCounter++;
                    }
                    dgvr.HeaderCell.Value = (dgvH.Rows.Count + 1).ToString();
                    dgvH.Rows.Add(dgvr);
                }

                for (int i = 0; i < nColonne; i++)
                {
                    DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                    dgvc.Width = 28;
                    dgvD.Columns.Add(dgvc);
                }

                while (dCounter < data.value.Length)
                {
                    DataGridViewRow dgvr = new DataGridViewRow();
                    dgvr.HeaderCell.Value = dCounter.ToString();
                    for (int i = 0; dCounter < data.value.Length && i < nColonne; i++)
                    {
                        if (fData.value.Length + traslHeader > dCounter && data.diff[dCounter] == true)
                            dgvr.Cells.Add(getByteCellChanged(data.value[dCounter]));
                        else
                            dgvr.Cells.Add(getByteCell(data.value[dCounter]));
                        dCounter++;
                    }
                    dgvr.HeaderCell.Value = (dgvD.Rows.Count + 1).ToString();
                    dgvD.Rows.Add(dgvr);
                }

            }
            catch{ }
        }
        private DataGridViewTextBoxCell getByteCellChanged(byte data)
        {
            DataGridViewTextBoxCell myCell = getByteCell(data);
            myCell.Style = RedStyle;
            return myCell;
        }
        private DataGridViewTextBoxCell getByteCell(byte data)
        {
            DataGridViewTextBoxCell bCell = new DataGridViewTextBoxCell();
            if (comboBox1.Text == "Hex")
                bCell.Value = data.ToString("X");
            else if (comboBox1.Text == "String")
                bCell.Value = Convert.ToChar(data);
            else
                bCell.Value = data.ToString();

            return bCell;
        }
        private void noChanged(object sender, EventArgs e)
        { }
        private void ProcessAll()
        {
            if (fData.value == null || fData2.value == null)
                return;

            int Header = Math.Min(fData.value.Length, int.Parse(txHeader.Text));
            int Header2;
            if (!String.IsNullOrWhiteSpace(txHeader2.Text))
                Header2 = Math.Min(fData2.value.Length, int.Parse(txHeader2.Text));
            else
                Header2 = Header;
            idDiff.Clear();
            int iDiff = Header2 - Header;
            int nDiff = 0;
            for (int i = 0; i < Math.Min(fData.value.Length, fData2.value.Length); i++)
            {
                if (i + iDiff >= 0 && i + iDiff < fData2.value.Length && fData.value[i] != fData2.value[i + iDiff])
                {
                    idDiff.Add(i);
                    nDiff++;
                }
            }
            lbNDiff.Text = "Differences : " + nDiff.ToString();

            clearDgv(dgvData);
            clearDgv(dgvHeader);
            clearDgv(dgvData2);
            clearDgv(dgvHeader2);

            processData();

            ProcessFile(ref fData, dgvHeader, dgvData, Header);
            ProcessFile(ref fData2, dgvHeader2, dgvData2, Header2);
        }
        List<int> idDiff = new List<int>();
        private void openFile(ref data fd, ref Label lb, ref Label lbName)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (System.IO.File.Exists(ofd.FileName))
            {
                fd.value = System.IO.File.ReadAllBytes(ofd.FileName);
                lb.Text = "n. byte: " + fd.value.Length.ToString();
                FileInfo fi = new FileInfo(ofd.FileName);
                lbName.Text = fi.Name;
                fd.diff = new bool[fd.value.Length];
            }
        }
        private void btOpen_Click(object sender, EventArgs e)
        {
            openFile(ref fData, ref lbF1Len, ref lbInt);
        }
        private void btOpen2_Click(object sender, EventArgs e)
        {
            openFile(ref fData2, ref lbF2Len, ref lbFloat);
        }
        private void processSelection(DataGridView dgv)
        {
            try
            {
                if (dgv.Rows.Count == 4 || dgv.Rows.Count == 8)
                {
                    byte[] data = new byte[dgv.SelectedCells.Count];

                    for (int i = 0; i < dgv.SelectedCells.Count; i++)
                        data[i] = byte.Parse((string)dgv.SelectedCells[i].Value);

                    lbInt.Text = BitConverter.ToInt32(data, 0).ToString();
                }
            }
            catch { }
        }
        private void dgvGeneral_SelectionChanged(object sender, EventArgs e)//funzione generale che agisce su Form1.Designer
        {
            processSelection((DataGridView)sender);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text)){
                r1Index = -1;
                r2Index = -1;
                fr1Index = -2;
                fr2Index = -2;
                sr1Index = -1;
                sr2Index = -1;
                ProcessAll();
            }

        }
        private void salvaFile(DataGridView header, DataGridView data)
        {
            List<byte> b = new List<byte>();
            ForEachRIn(ref header, ref b);
            ForEachRIn(ref data, ref b);

            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Txt|.txt";
            if (s.ShowDialog() != DialogResult.No)
            {
                try
                {
                    System.IO.File.WriteAllBytes(s.FileName, b.ToArray());
                }
                catch { }
            }
        }
        private void btSalva1_Click(object sender, EventArgs e)
        {
            salvaFile(dgvHeader, dgvData);
        }
        private void btSalva2_Click(object sender, EventArgs e)
        {
            salvaFile(dgvHeader2, dgvData2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int finoA = int.Parse(txFinoA.Text);
            int Da = int.Parse(txDa.Text);
            if (fData.value != null && fData2.value != null)
            {
                if (finoA + fData2.value.Length - Da > 0 && Da < fData.value.Length && finoA >= 0 && Da >= 0)
                {
                    byte[] newData = new byte[finoA + fData2.value.Length - Da];
                    int o = 0;
                    for (int i = 0; i < finoA; i++)
                        newData[o++] = fData.value[i];

                    for (int i = Da; i < fData2.value.Length; i++)
                        newData[o++] = fData2.value[i];

                    using (System.Windows.Forms.SaveFileDialog sfd = new SaveFileDialog())
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                System.IO.File.WriteAllBytes(sfd.FileName, newData);
                            }
                            catch { }
                        }
                    }
                }
                else
                    MessageBox.Show("Wrong or impossible inputs!");
            }
            else
                MessageBox.Show("Files need to be opened!");


        }
        private void search(DataGridView data)
        {
            string[] c;
            if (comboBox1.Text == "String")
            {
                c = new string[tbCerca.Text.Length];
                for (int i = 0; i < c.Length; i++)  
                    c[i] = Convert.ToString(tbCerca.Text[i]);
            }
            else
                c = tbCerca.Text.Split(' ');

            string[] s = new string[c.Length];
            foreach (DataGridViewRow row in data.Rows)
            {
                //Search c
                for (int i = 0; i <= row.Cells.Count - c.Length; i++)
                {
                    for (int j = 0; j < c.Length; j++)
                        s[j] = Convert.ToString(row.Cells[i + j].Value);
                    

                    //Change color
                    if (s.SequenceEqual(c))
                        for (int j = 0; j < c.Length; j++)
                            row.Cells[i + j].Style = GreenStyle;
                }
            }
        }
        private void searchNext(object sender, EventArgs e)
        {
            generalNext(dgvData, GreenStyle, SelectedGreenStyle, ref sr1Index, ref fr1Index);
            generalNext(dgvData2, GreenStyle, SelectedGreenStyle, ref sr2Index, ref fr2Index);
        }
        private void searchPrevious(object sender, EventArgs e)
        {
            generalPrevious(dgvData, GreenStyle, SelectedGreenStyle, ref sr1Index, ref fr1Index);
            generalPrevious(dgvData2, GreenStyle, SelectedGreenStyle, ref sr2Index, ref fr2Index);
        }
        private void btCerca_Click(object sender, EventArgs e)
        {
            search(dgvData);
            search(dgvData2);
        }
        private Point? _mousePos;
        private int perc = 500;
        private const int TOTAL = 1250, START = TOTAL / 2, MINX = 100, MAXX = TOTAL - MINX;
        private void btDgvData_MouseMove(object sender, MouseEventArgs e)
        {
            if (this._mousePos.HasValue)
            {
                int futPos = btDgvData.Left + e.X - this._mousePos.Value.X;
                if (futPos > MINX && futPos < MAXX && Math.Abs(futPos - btDgvData.Left) > 20)
                    btDgvData.Left = futPos;
            }
        }
        private void btDgvData_MouseUp(object sender, MouseEventArgs e)
        {
            this._mousePos = null;

            perc = btDgvData.Left * 500 / START;
            //move every dgv
            dgvData.Size = new System.Drawing.Size(TOTAL * perc / 1000, dgvData.Size.Height);
            dgvHeader.Size = new System.Drawing.Size(dgvData.Size.Width, dgvHeader.Size.Height);
            dgvData2.Left = btDgvData.Right;
            dgvHeader2.Left = btDgvData.Right;
            dgvData2.Size = new System.Drawing.Size(TOTAL * (1000 - perc) / 1000, dgvData2.Size.Height);
            dgvHeader2.Size = new System.Drawing.Size(dgvData2.Size.Width, dgvHeader2.Size.Height);
            this.SuspendLayout();
        }
        private void btDgvData_MouseDown(object sender, MouseEventArgs e)
        {
            this._mousePos = e.Location;
            this.ResumeLayout(true);
        }
        private void btNext(object sender, EventArgs e)
        {
            generalNext(dgvData, RedStyle, SelectedRedStyle, ref r1Index, ref fr1Index);
            generalNext(dgvData2, RedStyle, SelectedRedStyle, ref r2Index, ref fr2Index);
        }
        private void btPrevious(object sender, EventArgs e)
        {
            generalPrevious(dgvData, RedStyle, SelectedRedStyle, ref r1Index, ref fr1Index);
            generalPrevious(dgvData2, RedStyle, SelectedRedStyle, ref r2Index, ref fr2Index);
        }
        private void changeColorRow(DataGridView data, int index, DataGridViewCellStyle color, DataGridViewCellStyle newColor)
        {
            for (int i = 0; i < data.Rows[index].Cells.Count; i++)
                if (data.Rows[index].Cells[i].Style == color)
                    data.Rows[index].Cells[i].Style = newColor;
        }
        private void generalPrevious(DataGridView data, DataGridViewCellStyle color, DataGridViewCellStyle selectedColor, ref int index, ref int fIndex)
        {
            bool found = false;
            if (data.Rows.Count > 0)
            {
                for (index--; !found && index >= 0; index--)
                    for (int cIndex = data.Rows[index].Cells.Count - 1; !found && cIndex >= 0; cIndex--)
                        if (data.Rows[index].Cells[cIndex].Style == color)
                            found = true;

                if (fIndex > -2)
                    changeColorRow(data, fIndex, selectedColor, color);

                if (found)
                {
                    index++;
                    fIndex = index;
                    try
                    {
                        changeColorRow(data, fIndex, color, selectedColor);
                        data.FirstDisplayedScrollingRowIndex = index;
                    }
                    catch { }
                }
                else
                    index = data.Rows.Count;
            }
        }
        private void generalNext(DataGridView data, DataGridViewCellStyle color, DataGridViewCellStyle selectedColor, ref int index, ref int fIndex)
        {
            bool found = false;
            if(data.Rows.Count > 0) 
            {
                for(index++; !found && index < data.Rows.Count; index++)
                    for (int cIndex = 0; !found && cIndex < data.Rows[index].Cells.Count; cIndex++)
                        if (data.Rows[index].Cells[cIndex].Style == color)
                            found = true;

                if (fIndex > -2)
                    changeColorRow(data, fIndex, selectedColor, color);
                if (found)
                {
                    index--;
                    fIndex = index;
                    try
                    {
                        changeColorRow(data, fIndex, color, selectedColor);
                        data.FirstDisplayedScrollingRowIndex = index;
                    }
                    catch { }
                }
                else
                    index = -1;
            }
        }
        
    }
}