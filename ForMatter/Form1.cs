using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForMatter
{
    public partial class formatter : Form
    {
        public int offset=0,size=16;
        public byte[] buff = new byte[16];
        public System.IO.FileStream fs;
        private bool semaphore = false;
        public formatter()
        {
            InitializeComponent();
            
            
        }

        private void ForM_Load(object sender, EventArgs e)
        {
            int count = System.Environment.GetCommandLineArgs().Count();
            if (count == 4)
            {
                byte[] b = new byte[16];
                try
                {
                    if (!System.IO.File.Exists(System.Environment.GetCommandLineArgs()[1])) return; //File must exist
                    offset = int.Parse(System.Environment.GetCommandLineArgs()[2]);
                    if (offset < 0) return;
                    if (System.Environment.GetCommandLineArgs()[3].Length % 2 != 0) return;
                    else
                    {
                        b = new byte[System.Environment.GetCommandLineArgs()[3].Length / 2];
                        string seq = System.Environment.GetCommandLineArgs()[3].ToUpper();
                        for (int i = 0; i < seq.Length; i += 2)
                        {
                            b[i / 2] = (byte)int.Parse(seq[i].ToString() + seq[i + 1].ToString(), System.Globalization.NumberStyles.HexNumber);
                        }
                    }
                }
                catch (System.Exception m) { return; }
                fs = System.IO.File.Open(System.Environment.GetCommandLineArgs()[1], System.IO.FileMode.Open);
                fs.Seek(offset, System.IO.SeekOrigin.Current);
                foreach (byte sb in b) fs.WriteByte(sb);
                fs.Close();
                play_success(true);
                Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void offsetval_TextChanged(object sender, EventArgs e)
        {
            if (semaphore) return;
            semaphore = true;
            err.Text = "";
            if(fs.CanRead)fs.Close();
            fs = System.IO.File.Open(openFileDialog1.FileName, System.IO.FileMode.Open);
            string t = "";
            for(int i = 0; i < offsetval.Text.Length; i++)
            {
                if (offsetval.Text[i] >= 48 && offsetval.Text[i] <= 58) t += offsetval.Text[i];
            }
            offsetval.Text = t;
            if (offsetval.Text.Length != 0) offset = int.Parse(offsetval.Text);
            else
            {
                offset = 0;
            }
            if (offset+size >= fs.Length) { offset = 0; offsetval.Text = "0"; err.Text = "offset + size must be less than file size!";  }

            dump.Text = "";
            buff = new byte[size];
            fs.Seek(offset, System.IO.SeekOrigin.Current);
            for(int i = 0; i < buff.Length; i++)
            {
                buff[i] = (byte)fs.ReadByte();
                dump.Text += buff[i].ToString("X2") + ",";
            }
            fs.Close();
            semaphore = false;
        }
        private void sizeval_TextChanged(object sender, EventArgs e)
        {
            semaphore = true;
            err.Text = "";
            fs = System.IO.File.Open(openFileDialog1.FileName,System.IO.FileMode.Open);
            string t = "";
            for( int i=0;i<sizeval.Text.Length;i++)
            {
                if (sizeval.Text[i] >= 48 && sizeval.Text[i] <= 58)t+=sizeval.Text[i] ;//ok
            }
            sizeval.Text = t;
            if (sizeval.Text.Length != 0)
            {
                size = int.Parse(sizeval.Text);
            }
            else
            {
                size = 0;
            }
            if (size+offset > fs.Length)
            {
                size = 0;
                sizeval.Text = "0";
                err.Text = "size + offset must be less than file size!";
            }
            dump.MaxLength = size*3;
            dump.Text = "";
            buff = new byte[size];
            fs.Seek(offset,System.IO.SeekOrigin.Current);
            
            for(int i = 0; i < buff.Length; i++)
            {
                buff[i] = (byte)fs.ReadByte();
                dump.Text+=buff[i].ToString("X2")+",";
            }
            fs.Close();
            semaphore = false;
        }

        private void sizeval_Validating(object sender, CancelEventArgs e)
        {
        }

        private void sizeval_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void dump_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fs = System.IO.File.OpenRead(openFileDialog1.FileName);
                fs.Seek(offset, System.IO.SeekOrigin.Current);
                string t = "";
                fs.Seek(offset, System.IO.SeekOrigin.Current);
                for (int i = 0; i < dump.Text.Length; i++)
                {
                    if (i % 3 == 0 && i != 0)
                    {
                        t += ",";
                        continue;
                    }

                }
                fs.Close();
            }
            catch (System.Exception) { }
        }

        private void dump_MouseDown(object sender, MouseEventArgs e)
        {
            dump.Select(dump.GetCharIndexFromPosition(new Point(e.X,e.Y)),1);
            if(dump.SelectedText.Contains(","))dump.Select(dump.GetCharIndexFromPosition(new Point(e.X, e.Y))-2, 1);
        }

        private void dump_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void dump_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void dump_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dump_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dump_CursorChanged(object sender, EventArgs e)
        {

        }

        private void dump_Validating(object sender, CancelEventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            semaphore = true;
            err.Text = "";
            fs = System.IO.File.Open(openFileDialog1.FileName, System.IO.FileMode.Open);
            fs.Seek(offset, System.IO.SeekOrigin.Begin);
            byte[] b = new byte[size];
            try
            {
                for (int i = 0; i < size * 3; i += 3)
                {
                    b[i / 3] = (byte)int.Parse((dump.Text[i].ToString() + dump.Text[i + 1].ToString()), System.Globalization.NumberStyles.HexNumber);
                }
            }
            catch (System.Exception) { err.Text = "Error: Incorrect sequence!"; fs.Close(); play_success(false); semaphore=false; return; }
            for (int i = 0; i < buff.Length; i++)
            {
                fs.WriteByte(b[i]);
            }
            fs.Close();
            err.Text = "Saved";
            play_success(true);
            semaphore = false;
        }

        private void play_success(bool isSuccess)
        {
            List<int> melody = new List<int>();
            if (isSuccess) melody.AddRange(new[] { 770, 200, 700, 222, 689, 222, 500, 344, 800, 320, 630, 250 });
            else melody.AddRange(new[] { 370, 200, 300, 322, 289, 222 });
            for (int i = 0; i < melody.Count && i + 1 < melody.Count; i += 2)
            {
                System.Console.Beep(melody[i], melody[i + 1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            err.Text = "";
            openFileDialog1.Multiselect = false;
            DialogResult result=openFileDialog1.ShowDialog();

            if (result == DialogResult.Yes || result == DialogResult.OK)
            {
                try
                {
                    fs = System.IO.File.Open(openFileDialog1.FileName, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite);
                }catch(System.Exception m) { err.Text = m.Message; play_success(false); return; }
                statecap.Text = openFileDialog1.FileName;
                length_cap.Text = "Length: " +fs.Length+ " bytes";
                if (fs.Length == 0)
                {
                    fs.Close();
                    return;
                }
                else
                {
                    if (fs.Length < 16)
                    {
                        offset = 0;
                        size = (int)fs.Length;
                        offsetval.Text = string.Format("{0}",0);
                        sizeval.Text = fs.Length.ToString();
                    }
                    offsetval.Enabled = true;
                    sizeval.Enabled = true;
                    dump.Enabled = true;
                    savebtn.Enabled = true;
                    fs.Seek(0,System.IO.SeekOrigin.Current);
                    buff = new byte[size];
                    fs.Read(buff, offset, size);
                    dump.Text = "";
                    for (int i = 0; i < buff.Length; i++)
                    {
                        dump.Text+= buff[i].ToString("X2")+",";
                    }
                }
                fs.Close();
                play_success(true);
            }
            else
            {
                play_success(false);
            }
        }
    }
}
