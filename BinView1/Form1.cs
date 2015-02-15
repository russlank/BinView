using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace BinView1
{
    public partial class MainForm : Form
    {
        byte[] m_data;
        Int32[,] m_finger_print = new Int32[256, 256];
        Int32 m_max_dencity = 0;
        Int32 m_avarage_dencity = 0;

        int m_block_size = 10240;
        int m_previous_y = -1;
        
        public MainForm()
        {
            InitializeComponent();

            m_data = null;

            BlockSizeBox.Text = m_block_size.ToString();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            

        }

        private void CalculateRangeFingerPrint(int range_start, int range_end)
        {
            if (m_data != null)
            {
                int x, y;
                int start;
                int end;

                m_max_dencity = 0;
                m_avarage_dencity = 0;

                for (x = 0; x < 256; x++)
                    for (y = 0; y < 256; y++)
                        m_finger_print[x, y] = 0;

                if (range_start < range_end)
                {
                    start = range_start;
                    end = range_end;
                } else {
                    start = range_end;
                    end = range_start;
                }

                if (start < 0)
                {
                    start = 0;
                    if (end < 0) end = 0;
                }

                if (end >= m_data.Length)
                {
                    end = m_data.Length - 1;
                    if (start >= m_data.Length - 1) start  = m_data.Length - 1;
                }

                y = m_data[start];

                for (int i = start + 1; i < end; i++)
                {
                    x = y;
                    y = m_data[i];
                    m_finger_print[x, y]++;

                    if (m_max_dencity < m_finger_print[x, y]) m_max_dencity = m_finger_print[x, y];
                }

                for (x = 0; x < 256; x++)
                    for (y = 0; y < 256; y++)
                        m_avarage_dencity += m_finger_print[x, y];

                m_avarage_dencity = m_avarage_dencity / (256 * 256);

            }
        }

        
        private void CalculateFingerPrint()
        {
            if (m_data != null)
            {
                int x, y;

                m_max_dencity = 0;
                m_avarage_dencity = 0;

                for (x = 0; x < 256; x++)
                    for (y = 0; y < 256; y++)
                        m_finger_print[x, y] = 0;

                y = m_data[0];

                for (int i = 1; i < m_data.Length; i++)
                {
                    x = y;
                    y = m_data[i];
                    m_finger_print[x, y]++;

                    if (m_max_dencity < m_finger_print[x, y]) m_max_dencity = m_finger_print[x, y];
                }

                for (x = 0; x < 256; x++)
                    for (y = 0; y < 256; y++)
                        m_avarage_dencity += m_finger_print[x, y];

                m_avarage_dencity = m_avarage_dencity / (256 * 256);

            }
        }

        private void DrawDataImage()
        {
            const int Width = 128;
            int Height = (int)Math.Ceiling((float)(m_data.Length) / (float)(Width));

            Bitmap bm = new Bitmap(Width, Height);
            for (int i = 1; i < m_data.Length; i++)
            {
                bm.SetPixel(i % Width, i / Width, Color.FromArgb(255, 32, m_data[i], 64));

            }

            DataPictureBox.Image = bm;
        }

        private void DrawFingerPrint()
        {
            //Bitmap bm = new Bitmap( 512, 512);
            Bitmap bm = new Bitmap(256, 256);

            bool Scaled = ScaleChk.Checked;
            bool Normalize = NormalizeChk.Checked;

            int x, y;

            if (Scaled)
            {
                if (Normalize)
                {
                    for( x = 0; x < 256; x++) for (y = 0; y < 256; y++)
                    {
                        Int32 dencity = m_finger_print[x,y];
                        byte v_dencity;

                        if (dencity < m_avarage_dencity)
                        {
                            v_dencity = (byte)(((float)180.0 * (float)dencity) / (float)m_avarage_dencity);
                        } else {
                            v_dencity = (byte)(180.0 + ((float)75.0 * (float)dencity) / (float)m_max_dencity);
                        }
                        
                        
                        Color co = Color.FromArgb(255, v_dencity, v_dencity, v_dencity);


                        if (m_finger_print[x, y] > 0)
                        {
                            bm.SetPixel(x, y, co);
                        }
                    }                    

                } else {
                    
                    for( x = 0; x < 256; x++) for (y = 0; y < 256; y++)
                    {
                        Int32 dencity = m_finger_print[x,y];
                        byte v_dencity;

                        if (dencity < 256) v_dencity = (byte)dencity;
                        else v_dencity = 255;

                        Color co = Color.FromArgb(255, v_dencity, v_dencity, v_dencity);

                        if (m_finger_print[x, y] > 0)
                        {
                            bm.SetPixel(x, y, co);
                        }
                    }                    
                }

            } else {
                Color active = Color.FromArgb(255, 255, 255, 255);
                //Color iniactive = Color.FromArgb(255, 255, 255, 255);

                for( x = 0; x < 256; x++) for (y = 0; y < 256; y++)
                {
                    if (m_finger_print[x, y] > 0)
                    {
                        bm.SetPixel(x, y, active);
                    }
                }
            }

            pictureBox1.Image = bm;
        }

        /*

        private void DrawData()
        {
            Bitmap bm = new Bitmap( 512, 512);
            bool Scaled = ScaleChk.Checked;
            bool Normalize = NormalizeChk.Checked;

            if (m_data != null)
            {
                int x;
                int y;
                int Max = 0;

                for (x = 0; x < 512; x++)
                    for (y = 0; y < 512; y++)
                    {
                        bm.SetPixel(x, y, Color.FromArgb(255,0,0,0));
                    }

                

                if (Scaled)
                {
                    y = m_data[0] * 2;
                    for (int i = 1; i < m_data.Length; i++)
                    {
                        x = y;
                        y = m_data[i] * 2;
                        Color c = bm.GetPixel(x, y);
                        Color nc;

                        int Current = c.R;

                        if (Current < 255) Current = Current + 1;

                        nc = Color.FromArgb(255, Current, Current, Current);

                        if (Max < Current) Max = Current;

                        bm.SetPixel(x, y, nc);
                        bm.SetPixel(x + 1, y, nc);
                        bm.SetPixel(x, y + 1, nc);
                        bm.SetPixel(x + 1, y + 1, nc);
                    }

                    if (Normalize)
                    {
                        if (Max < 255)
                        {
                            float Ratio = 255 / Max;

                            for (x = 0; x < 512; x++)
                                for (y = 0; y < 512; y++)
                                {
                                    Color c = bm.GetPixel(x, y);
                                    int Normalized = (int)(c.R * Ratio) % 256;
                                    Color nc = Color.FromArgb(255, Normalized, Normalized, Normalized);
                                    bm.SetPixel(x, y, nc);
                                }
                        }
                    }                
                } else {
                    Color nc = Color.FromArgb(255, 200, 200, 200);
                    y = m_data[0] * 2;

                    for (int i = 1; i < m_data.Length; i++)
                    {
                        x = y;
                        y = m_data[i] * 2;
                        
                        bm.SetPixel(x, y, nc);
                        bm.SetPixel(x + 1, y, nc);
                        bm.SetPixel(x, y + 1, nc);
                        bm.SetPixel(x + 1, y + 1, nc);
                    }
                }

            }

            pictureBox1.Image = bm;
        }
        */

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                if (m_data != null) m_data = null;
                
                FileStream fs = File.OpenRead(openFileDlg.FileName);
                m_data = new byte[fs.Length];
                fs.Read( m_data, 0, m_data.Length);
                fs.Close();

                //DrawData();
                //CalculateFingerPrint();
                if (FullViewChk.Checked)
                {
                    CalculateRangeFingerPrint(0, m_data.Length);
                }
                else
                {
                    CalculateRangeFingerPrint(0, m_block_size);
                }
                DrawFingerPrint();
                DrawDataImage();
            }
        }

        private void Scale_CheckedChanged(object sender, EventArgs e)
        {
            //DrawData();
            DrawFingerPrint();
        }

        private void NormalizeChk_CheckedChanged(object sender, EventArgs e)
        {
            if (ScaleChk.Checked) {
                //DrawData();
                DrawFingerPrint();
            }
        }

        private void DataPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DataPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (m_data != null)
            {
                if (m_previous_y != e.Y)
                {
                    if (pictureBox1.Height > 1)
                    {
                        int position = (int)(((float)e.Y / (float)pictureBox1.Height) * (float)m_data.Length);
                        int start = position - m_block_size / 2;
                        int end = position + m_block_size / 2;

                        CalculateRangeFingerPrint(start, end);
                        DrawFingerPrint();
                        //DrawDataImage();
                        m_previous_y = e.Y;
                    }
                }
            }
            
        }

        private void DataPictureBox_MouseHover(object sender, EventArgs e)
        {

        }

        private void DataPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_data != null)
            {

                if (!FullViewChk.Checked)
                {
                    if (m_previous_y != e.Y)
                    {
                        if (pictureBox1.Height > 1)
                        {
                            int position = (int)(((float)e.Y / (float)pictureBox1.Height) * (float)m_data.Length);
                            int start = position - m_block_size / 2;
                            int end = position + m_block_size / 2;

                            CalculateRangeFingerPrint(start, end);
                            DrawFingerPrint();
                            //DrawDataImage();
                            m_previous_y = e.Y;
                        }
                    }

                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (FullViewChk.Checked)
            {
                if (m_data != null)
                {
                    CalculateRangeFingerPrint(0, m_data.Length);
                    DrawFingerPrint();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (BlockSizeBox.Text.Length > 0)
            {
                try {
                    m_block_size = Convert.ToInt32(BlockSizeBox.Text);
                } 
                catch (Exception ee)
                {
                    m_block_size = 10240;
                }
            }
        }

        private void BlockSizeBox_Leave(object sender, EventArgs e)
        {
            BlockSizeBox.Text = m_block_size.ToString();
        }
    }
}
