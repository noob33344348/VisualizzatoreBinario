using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void ForEachRIn(ref DataGridView dgvGeneral, ref List<byte> b) //NEW function
        {

            foreach (DataGridViewRow r in dgvGeneral.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.Value != null)
                        b.Add(Convert.ToByte(c.Value));
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (System.IO.File.Exists(ofd.FileName))
            {
                fData = System.IO.File.ReadAllBytes(ofd.FileName);
                lbF1Len.Text = fData.Length.ToString();
            }
        }

        private void ProcessFile(byte[] inData, DataGridView dgvH, DataGridView dgvD, int Header)
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
                            dgvr.Cells.Add(getByteCellChanged(inData[dCounter], true));
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
                            dgvr.Cells.Add(getByteCellChanged(inData[dCounter], true));
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

        // movimenti del mouse traccati

        private Point MouseDownLocation;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox1.Left = e.X + pictureBox1.Left - MouseDownLocation.X;

            }
        }

        //
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
        private DataGridViewTextBoxCell getByteCellChanged(byte data, bool changed)
        {
            DataGridViewTextBoxCell myCell = getByteCell(data);
            if (changed)
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

        private void txHeader_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProcessAll()
        {
            int Header = Math.Min(fData.Length, int.Parse(txHeader.Text));
            int Header2;
            if (!String.IsNullOrWhiteSpace(txHeader2.Text))
                Header2 = Math.Min(fData2.Length, int.Parse(txHeader2.Text));
            else
                Header2 = Header;
            idDiff.Clear();
            int iDiff = Header2 - Header;
            int nDiff = 0;
            for (int i = 0; i < Math.Min(fData.Length, fData2.Length); i++)
            {
                if (i + iDiff >= 0 && i + iDiff < fData2.Length && fData[i] != fData2[i + iDiff])
                {
                    idDiff.Add(i);
                    nDiff++;
                }
            }
            lbNDiff.Text = "NDiff:" + nDiff.ToString();
            ProcessFile(fData, dgvHeader, dgvData, Header);
            ProcessFile(fData2, dgvHeader2, dgvData2, Header2);
        }

        private void txColonne_TextChanged(object sender, EventArgs e)
        { }
        List<int> idDiff = new List<int>();
        private void btOpen2_Click(object sender, EventArgs e)
        {
            idDiff = new List<int>();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (System.IO.File.Exists(ofd.FileName))
            {
                fData2 = System.IO.File.ReadAllBytes(ofd.FileName);
                lbF2Len.Text = fData2.Length.ToString();
            }
            if (fData == null) return;

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
            catch (Exception ex)
            { }
        }

        private void dgvHeaderGeneral_CellContentClick(object sender, DataGridViewCellEventArgs e) // CHANGES : funzione generale che agisce su Form1.Designer
        { }
        private void dgvGeneral_SelectionChanged(object sender, EventArgs e) // CHANGES : funzione generale che agisce su Form1.Designer
        {
            processSelection((DataGridView)sender);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ProcessFile(fData, dgvHeader, dgvData, header);
            //ProcessFile(fData2, dgvHeader2, dgvData2);
            ProcessAll();
        }
        private void btSalva1_Click(object sender, EventArgs e)
        {
            List<byte> b = new List<byte>();

            ForEachRIn(ref dgvHeader, ref b);//CHANGES
            ForEachRIn(ref dgvData, ref b);//CHANGES

            SaveFileDialog s = new SaveFileDialog();
            //s.Filter = "Txt|.txt";
            s.Filter = "VDTD|.VDTD";
            if (s.ShowDialog() != DialogResult.No)
                System.IO.File.WriteAllBytes(s.FileName, b.ToArray());
        }

        private void btSalva2_Click(object sender, EventArgs e)
        {
            List<byte> b = new List<byte>();

            ForEachRIn(ref dgvHeader2, ref b);//CHANGES
            ForEachRIn(ref dgvData2, ref b);//CHANGES

            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Txt|.txt";
            if (s.ShowDialog() != DialogResult.No)
                System.IO.File.WriteAllBytes(s.FileName, b.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int finoA = int.Parse(txFinoA.Text);
            int Da = int.Parse(txDa.Text);
            byte[] newData = new byte[finoA + fData2.Length - Da];
            int o = 0;
            for (int i = 0; i < finoA; i++)
            {
                newData[o++] = fData[i];
            }
            for (int i = Da; i < fData2.Length; i++)
            {
                newData[o++] = fData2[i];
            }
            using (System.Windows.Forms.SaveFileDialog sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllBytes(sfd.FileName, newData);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<byte> b = new List<byte>();

            ForEachRIn(ref dgvHeader, ref b);//CHANGES
            ForEachRIn(ref dgvData, ref b);//CHANGES

            SaveFileDialog s = new SaveFileDialog();
            string mystring = Encoding.Unicode.GetString(b.ToArray());
            if (s.ShowDialog() != DialogResult.No)
                System.IO.File.WriteAllText(s.FileName, mystring);
        }

        private void btCerca_Click(object sender, EventArgs e)
        {
            string c = tbCerca.Text;
            if (string.IsNullOrEmpty(c))
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style = new DataGridViewCellStyle() { BackColor = Color.White };
                    }
                }
            }
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string s = Convert.ToString(cell.Value);
                    if (s.Equals(c))
                        cell.Style = new DataGridViewCellStyle() { BackColor = Color.LightGreen };
                    else
                        cell.Style = new DataGridViewCellStyle() { BackColor = Color.White };
                }
            }
        }
    }
}