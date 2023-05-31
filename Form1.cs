using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualizzatoreBinario
{
    public partial class Form1 : Form
    {
        byte[] fData;
        byte[] fData2;
        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessFile(byte[] inData,DataGridView dgvH,DataGridView dgvD,int Header)
        {
            try
            {
                dgvH.Rows.Clear();
                dgvH.Columns.Clear();
                dgvD.Rows.Clear();
                dgvD.Columns.Clear();
                if (inData == null)
                    return;
                int nColonne = int.Parse(txColonne.Text);
                int dCounter = 0;
                int traslHeader = inData == fData ? 0 : int.Parse(txHeader2.Text) - int.Parse(txHeader.Text);
                for (int i = 0; i < 20; i++)
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
                        if (fData.Length > dCounter && fData[dCounter] != inData[dCounter])
                            dgvr.Cells.Add(getByteCellChanged(inData[dCounter]));
                        else
                            dgvr.Cells.Add(getByteCell(inData[dCounter]));
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
                while (dCounter < inData.Length)
                {
                    DataGridViewRow dgvr = new DataGridViewRow();
                    dgvr.HeaderCell.Value = dCounter.ToString();
                    for (int i = 0; dCounter < inData.Length && i < nColonne; i++)
                    {
                        if (fData.Length + traslHeader > dCounter && fData[dCounter - traslHeader] != inData[dCounter])
                            dgvr.Cells.Add(getByteCellChanged(inData[dCounter]));
                        else
                            dgvr.Cells.Add(getByteCell(inData[dCounter]));
                        dCounter++;
                    }
                    dgvr.HeaderCell.Value = (dgvD.Rows.Count + 1).ToString();
                    dgvD.Rows.Add(dgvr);
                }

            }
            catch (Exception ex)
            {

            }
        }
        private DataGridViewCellStyle myRedStyle;
        private DataGridViewCellStyle RedStyle()
        {
            if (myRedStyle == null)
            {
                myRedStyle = new DataGridViewCellStyle();
                myRedStyle.BackColor = Color.Red;
            }
            return myRedStyle;
        }
        private DataGridViewTextBoxCell getByteCellChanged(byte data)//NEW
        {
            DataGridViewTextBoxCell myCell = getByteCell(data);
            myCell.Style = RedStyle();
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
        private void noChanged(object sender, EventArgs e)//NEW
        { }
        private void ProcessAll()
        {
            int Header = Math.Min(fData.Length, int.Parse(txHeader.Text));
            int Header2;
            if (!String.IsNullOrWhiteSpace(txHeader2.Text))
                Header2 = Math.Min(fData2.Length, int.Parse(txHeader2.Text));
            else
                Header2 = Header;

            int iDiff = Header2 - Header;
            int nDiff = 0;
            for (int i = 0; i < Math.Min(fData.Length, fData2.Length); i++)
                if (i+ iDiff>= 0 && i+ iDiff<fData2.Length && fData[i] != fData2[i+ iDiff])
                    nDiff++;

            lbNDiff.Text = "NDiff:" + nDiff.ToString();
            ProcessFile(fData, dgvHeader, dgvData, Header);
            ProcessFile(fData2, dgvHeader2, dgvData2, Header2);
        }
        private void openFile(ref byte[] fd, ref Label lb)//NEW
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (System.IO.File.Exists(ofd.FileName))
            {
                fd = System.IO.File.ReadAllBytes(ofd.FileName);
                lb.Text = fd.Length.ToString();
            }
        }
        private void btOpen_Click(object sender, EventArgs e)//NEW
        {
            openFile(ref fData, ref lbF1Len);
        }
        private void btOpen2_Click(object sender, EventArgs e)//NEW
        {
            openFile(ref fData2, ref lbF2Len);
        }
        private void processSelection(DataGridView dgv)
        {
            try
            {
                if (dgv.SelectedCells.Count == 4)
                {
                    byte[] data = new byte[4];
                    for (int i = 0; i < dgv.SelectedCells.Count; i++)
                    {
                        data[i] = byte.Parse((string)dgv.SelectedCells[i].Value);
                    }
                    lbInt.Text = BitConverter.ToInt32(data, 0).ToString();
                    //lbFloat.Text = BitConverter.ToSingle(data, 0).ToString();
                }
                if (dgv.SelectedCells.Count == 8)
                {
                    byte[] data = new byte[8];
                    for (int i = 0; i < dgv.SelectedCells.Count; i++)
                    {
                        data[i] = byte.Parse((string)dgv.SelectedCells[i].Value);
                    }
                    lbInt.Text = BitConverter.ToInt64(data, 0).ToString();
                    //lbFloat.Text = BitConverter.ToDouble(data, 0).ToString();
                }
            }
            catch(Exception ex)
            { }
        }
        private void selectionChanged(object sender, EventArgs e)//NEW
        {
            processSelection((DataGridView)sender); 
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessAll();
        }
        private void salvaFile(DataGridView data)//NEW
        {
            List<byte> b = new List<byte>();
            foreach (DataGridViewRow r in data.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.Value != null)
                        b.Add(Convert.ToByte(c.Value));
                }
            }
            foreach (DataGridViewRow r in dgvData.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.Value != null)
                        b.Add(Convert.ToByte(c.Value));
                }
            }

            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Txt|.txt";
            //s.Filter = "VDTD|.VDTD";
            if (s.ShowDialog() != DialogResult.No)
                System.IO.File.WriteAllBytes(s.FileName, b.ToArray());
        }
        private void btSalva1_Click(object sender, EventArgs e)//NEW
        {
            salvaFile(dgvHeader);
        }
        private void btSalva2_Click(object sender, EventArgs e)//NEW
        {
            salvaFile(dgvHeader2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int finoA = int.Parse(txFinoA.Text);
            int Da = int.Parse(txDa.Text);
            byte[] newData = new byte[finoA + fData2.Length - Da];
            int o = 0;
            for (int i = 0; i < finoA; i++)
                newData[o++] = fData[i];

            for (int i = Da; i < fData2.Length; i++)
                newData[o++] = fData2[i];
            
            using (System.Windows.Forms.SaveFileDialog sfd = new SaveFileDialog())
                if (sfd.ShowDialog() == DialogResult.OK)
                    System.IO.File.WriteAllBytes(sfd.FileName, newData);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            List<byte> b = new List<byte>();
            foreach (DataGridViewRow r in dgvHeader.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.Value != null)
                        b.Add(Convert.ToByte(c.Value));
                }
            }
            foreach (DataGridViewRow r in dgvData.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.Value != null)
                        b.Add(Convert.ToByte(c.Value));
                }
            }

            SaveFileDialog s = new SaveFileDialog();
            string mystring = Encoding.Unicode.GetString(b.ToArray());
            if (s.ShowDialog() != DialogResult.No)
                System.IO.File.WriteAllText(s.FileName, mystring);
        }
        private void search(DataGridView data)//NEW
        {
            //Remove spaces if searching in Hex or Int.
            string[] c;
            if (comboBox1.Text == "String")
            {
                c = new string[tbCerca.Text.Length];
                for(int i=0; i<c.Length; i++)
                    c[i] = Convert.ToString(tbCerca.Text[i]);
            }    
            
            else
                c = tbCerca.Text.Split(' ');

            string[] s = new string[c.Length];
            foreach (DataGridViewRow row in data.Rows)
            {
                //Set every color to white
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Style = new DataGridViewCellStyle() { BackColor = Color.White };


                //Search c
                for (int i = 0; i <= row.Cells.Count - c.Length; i++)
                {
                    for (int j = 0; j < c.Length; j++)
                        s[j] = Convert.ToString(row.Cells[i + j].Value);

                    //Change color
                    if (s.SequenceEqual(c))
                        for (int j = 0; j < c.Length; j++)
                            row.Cells[i + j].Style = new DataGridViewCellStyle() { BackColor = Color.LightGreen };
                }
            }

        }
        private void btCerca_Click(object sender, EventArgs e)//NEW
        {
            search(dgvData);
            search(dgvData2);
        }
    }
}