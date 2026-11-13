using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CellularAutomaton
{
    public partial class frmMain : Form
    {
        Bitmap field;
        List<List<bool>> data;
        short lifeLow;
        short lifeHigh = 8;
        short deathLow;
        short deathHigh = 8;
        short size;
        short rad;
        short random;
        short side;
        short minMargin = 380; //чтобы за кнопки поле не улетало
        short step;
        short speed;
        bool neigh; //true - фон Нейман, false - Мур

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            globalInit();
            fieldInit();
            btnStart.Enabled = true;
            btnClear.Enabled = true;
            btnRandom.Enabled = true;
        }

        private void fieldInit()
        {
            step = Convert.ToInt16(pbxMain.Width / size);
            side = Convert.ToInt16(step * size);
            clearField();
            drawGrid();
        }

        private void drawGrid()
        {
            int x, y;
            using (Graphics g = Graphics.FromImage(field))
            {
                Pen pen = new Pen(Color.FromArgb(100, 100, 100), 1);
                for (x = 0; x < size; x++)
                {
                    g.DrawLine(pen, step * x, 0, step * x, side);
                }
                for (y = 0; y < size; y++)
                {
                    g.DrawLine(pen, 0, step * y, side, step * y);
                }
            }
        }

        private void lifeLowInit()
        {
            try
            {
                lifeLow = short.Parse(tbxLifeLow.Text);
                if (lifeLow < 0 || lifeLow > 8) throw new Exception("Parsing Error");
            }
            catch
            {
                lifeLow = 3;
                tbxLifeLow.Text = lifeLow.ToString();
                MessageBox.Show("Введите корректное целочисленное значение от 0 до 8", "Ошибка конверсии критического значения");
            }
        }

        private void lifeHighInit()
        {
            try
            {
                lifeHigh = short.Parse(tbxLifeHigh.Text);
                if (lifeHigh < 0 || lifeHigh > 8) throw new Exception("Parsing Error");
            }
            catch
            {
                lifeHigh = 3;
                tbxLifeHigh.Text = lifeHigh.ToString();
                MessageBox.Show("Введите корректное целочисленное значение от 0 до 8", "Ошибка конверсии критического значения");
            }
        }

        private void deathLowInit()
        {
            try
            {
                deathLow = short.Parse(tbxDeathLow.Text);
                if (deathLow < 0 || deathLow > 8) throw new Exception("Parsing Error");
            }
            catch
            {
                deathLow = 2;
                tbxDeathLow.Text = deathLow.ToString();
                MessageBox.Show("Введите корректное целочисленное значение от 0 до 8", "Ошибка конверсии критического значения");
            }
        }

        private void deathHighInit()
        {
            try
            {
                deathHigh = short.Parse(tbxDeathHigh.Text);
                if (deathHigh < 0 || deathHigh > 8) throw new Exception("Parsing Error");
            }
            catch
            {
                deathHigh = 3;
                tbxDeathHigh.Text = deathHigh.ToString();
                MessageBox.Show("Введите корректное целочисленное значение от 0 до 8", "Ошибка конверсии критического значения");
            }
        }

        private void sizeInit()
        {
            try
            {
                size = short.Parse(tbxSize.Text);
                if (size < 0 || size > 99) throw new ArgumentException("Parsing Error");
            }
            catch
            {
                size = 10;
                tbxSize.Text = "10";
                MessageBox.Show("Введите корректное целочисленное значение от 0 до 99", "Ошибка конверсии размера поля");
            }
        }

        private void speedInit()
        {
            try
            {
                speed = Convert.ToInt16(nudSpeed.Value);
                if (speed < 50 || speed > 2000) throw new ArgumentException("Parsing Error");
            }
            catch
            {
                speed = 200;
                nudSpeed.Value = 200;
                MessageBox.Show("Введите корректное целочисленное значение от 50 до 2000", "Ошибка конверсии скорости симуляции");
            }
        }

        private void radInit()
        {
            try
            {
                rad = Convert.ToInt16(nudRad.Value);
                if (rad < 0 || rad > 10) throw new ArgumentException("Parsing Error");
            }
            catch
            {
                rad = 1;
                nudRad.Value = 1;
                MessageBox.Show("Введите корректное целочисленное значение от 0 до 10", "Ошибка конверсии расстояния Чебышева");
            }
        }

        private void randomInit()

        {
            try
            {
                random = short.Parse(tbxRandom.Text);
                if (random < 0 || random > 100) throw new ArgumentException("Parsing Error");
            }
            catch
            {
                random = 0;
                tbxRandom.Text = "0";
                trbRandom.Value = 0;
                MessageBox.Show("Введите корректное значение от 0 до 100", "Ошибка конверсии коэффициента случайного заполнения");
            }
        }

        private void neighInit()
        {
            if (rbtConnect4.Checked ==  true) neigh = true;
            else neigh = false;
        }

        private void globalInit() 
        {
            lifeLowInit();
            lifeHighInit();
            deathLowInit();
            deathHighInit();
            sizeInit();
            radInit();
            randomInit();
            neighInit();
            speedInit();
        }

        private void rbtConnect8_CheckedChanged(object sender, EventArgs e)
        {
            neighInit();
        }

        private void rbtConnect4_CheckedChanged(object sender, EventArgs e)
        {
            neighInit();
        }

        private void tbxSize_TextChanged(object sender, EventArgs e)
        {
            sizeInit();
        }

        private void nudRad_ValueChanged(object sender, EventArgs e)
        {
            radInit();
        }

        private void tbxRandom_TextChanged(object sender, EventArgs e)
        {
            randomInit();
            trbRandom.Value = Convert.ToInt32(random);
        }

        private void trbRandom_Scroll(object sender, EventArgs e)
        {
            tbxRandom.Text = Convert.ToString(trbRandom.Value);
            randomInit();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (Size.Height - 60 > Size.Width - minMargin - 25)
                pbxMain.Width = Size.Width - minMargin - 25;
            else
                pbxMain.Width = Size.Height - 60;
            pbxMain.Height = pbxMain.Width;
        }

        private void pbxMain_MouseDown(object sender, MouseEventArgs e)
        {
            int xe = e.X;
            int ye = e.Y;
            Color pixelColor = field.GetPixel(xe, ye);
            xe = (xe / step) * step;
            ye = (ye / step) * step;
            using (Graphics g = Graphics.FromImage(field))
            {
                Brush br1 = new SolidBrush(Color.FromArgb(40, 170, 140));
                Brush br2 = new SolidBrush(Color.LightCyan);
                if (pixelColor == Color.FromArgb(255, 224, 255, 255))
                    g.FillRectangle(br1, xe, ye, step, step);
                else
                    g.FillRectangle(br2, xe, ye, step, step);
                pbxMain.Image = field;
            }
            drawGrid();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            tmrMain.Enabled = true;
            dataInit();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            tmrMain.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
            drawGrid();
        }

        private void clearField() {
            field = new Bitmap(side, side);
            using (Graphics g = Graphics.FromImage(field))
            {
                Brush br = new SolidBrush(Color.LightCyan);
                g.FillRectangle(br, 0, 0, side, side);
            }
            pbxMain.Image = field;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            clearField();
            Random rnd = new Random();
            short temp; 
            int x, y;
            for (x = 0; x < size; x++)
            {
                for (y = 0; y < size; y++)
                {
                    temp = (short)(random - rnd.Next(0, 99));
                    if (temp > 0)
                    {
                        using (Graphics g = Graphics.FromImage(field))
                        {
                            Brush br = new SolidBrush(Color.FromArgb(40, 170, 140));
                            g.FillRectangle(br, x*step, y*step, step, step);
                            pbxMain.Image = field;
                        }
                    }
                }
            }
            drawGrid();
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            if (neigh) data = countVonNeumann(data);
            else data = countMoore(data);
            dataWrite();
            tmrMain.Interval = speed;
        }

        private List<List<bool>> countVonNeumann(List<List<bool>> input)
        {
            List<List<bool>> output = new List<List<bool>>();
            output.Capacity = size;
            for (int i = 0; i < output.Capacity; i++)
            { output.Add(new List<bool>()); }
            foreach (List<bool> col in output)
            {
                col.Capacity = size;
                for (int i = 0; i < col.Capacity; i++)
                { col.Add(new bool()); }
            }

            for (int i = 0; i < output.Count; i++)
            {
                for (int j = 0; j < output[i].Count; j++)   
                {
                    int count = 0;
                    for (int k = 0; k < input.Count; k++)
                    {
                        for (int l = 0; l < input[k].Count; l++)
                        {
                            if (i == k && j == l) continue;
                            int diff = Math.Abs(k - i) + Math.Abs(l - j);
                            if (diff <= rad && input[k][l]) count++;
                        }
                    }
                    if (!input[i][j])
                    {
                        if (count >= lifeLow && count <= lifeHigh)
                            { output[i][j] = true; }
                        else { output[i][j] = false; }
                    }
                    else
                        if (count < deathLow || count > deathHigh)
                            { output[i][j] = false; }
                        else { output[i][j] = true; }
                }
            }
            return output;
        }

        private List<List<bool>> countMoore(List<List<bool>> input)
        {
            List<List<bool>> output = new List<List<bool>>();
            output.Capacity = size;
            for (int i = 0; i < output.Capacity; i++)
            { output.Add(new List<bool>()); }
            foreach (List<bool> col in output)
            {
                col.Capacity = size;
                for (int i = 0; i < col.Capacity; i++)
                { col.Add(new bool()); }
            }

            for (int i = 0; i < output.Count; i++)
            {
                for (int j = 0; j < output[i].Count; j++)
                {
                    int count = 0;
                    for (int k = 0; k < input.Count; k++)
                    {
                        for (int l = 0; l < input[k].Count; l++)
                        {
                            if (i == k && j == l) continue;
                            int diff = Math.Max(Math.Abs(k - i), Math.Abs(l - j));
                            if (diff <= rad && input[k][l]) count++;
                        }
                    }
                    if (!input[i][j])
                    {
                        if (count >= lifeLow && count <= lifeHigh) 
                            { output[i][j] = true; }
                        else { output[i][j] = false; }
                    }
                    else
                        if (count < deathLow || count > deathHigh)
                            { output[i][j] = false; }
                        else { output[i][j] = true; }
                }
            }
            return output;
        }

        private void dataInit() {
            data = new List<List<bool>>();
            data.Capacity = size;
            for (int i = 0; i < data.Capacity; i++)
            { data.Add(new List<bool>()); }

            foreach (List<bool> col in data)
            {
                col.Capacity = size;
                for (int i = 0; i < col.Capacity; i++)
                { col.Add(new bool()); }
            }
            dataRead();
        }

        private void dataRead()
        {
            int x, y;
            int xcount = 0;
            int ycount = 0;
            for (x = step/2; x < side; x = x + step)
            {
                for (y = step/2; y < side; y = y + step)
                {
                    Color pixelColor = field.GetPixel(x, y);
                    if(pixelColor != Color.FromArgb(255,224,255,255))
                        data[xcount][ycount] = true;
                    ycount++;
                }
                ycount = 0;
                xcount++;
            }
        }

        private void dataWrite() 
        {
            Brush br1 = new SolidBrush(Color.FromArgb(40, 170, 140));
            Brush br2 = new SolidBrush(Color.LightCyan);

            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].Count; j++)
                {
                    using (Graphics g = Graphics.FromImage(field))
                    {
                        if (data[i][j]) g.FillRectangle(br1, i * step, j * step, step, step);
                        else g.FillRectangle(br2, i * step, j * step, step, step);
                    }
                }
            }
            pbxMain.Image = field;
            drawGrid();
        }

        private void nudSpeed_ValueChanged(object sender, EventArgs e)
        {
            speedInit();
        }

        private void tbxDeathLow_TextChanged(object sender, EventArgs e)
        {
            deathLowInit();
        }

        private void tbxLifeLow_TextChanged(object sender, EventArgs e)
        {
            lifeLowInit();
        }

        private void tbxLifeHigh_TextChanged(object sender, EventArgs e)
        {
            lifeHighInit();
        }

        private void tbxDeathHigh_TextChanged(object sender, EventArgs e)
        {
            deathHighInit();
        }

        private void cbxPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxPresets.SelectedIndex)
            {
                case 0:
                    rbtConnect8.Checked = true;
                    neighInit();
                    tbxLifeLow.Text = "3";
                    tbxLifeHigh.Text = "3";
                    tbxDeathLow.Text = "2";
                    tbxDeathHigh.Text = "3";
                    lifeLow = 3;
                    lifeHigh = 3;
                    deathLow = 2;
                    deathHigh = 3;
                    break;
                case 1:
                    rbtConnect8.Checked = true;
                    neighInit();
                    tbxLifeLow.Text = "3";
                    tbxLifeHigh.Text = "3";
                    tbxDeathLow.Text = "0";
                    tbxDeathHigh.Text = "8";
                    lifeLow = 3;
                    lifeHigh = 3;
                    deathLow = 0;
                    deathHigh = 8;
                    break;
                case 2:
                    rbtConnect8.Checked = true;
                    neighInit();
                    tbxLifeLow.Text = "3";
                    tbxLifeHigh.Text = "3";
                    tbxDeathLow.Text = "4";
                    tbxDeathHigh.Text = "8";
                    lifeLow = 3;
                    lifeHigh = 3;
                    deathLow = 4;
                    deathHigh = 8;
                    break;
                case 3:
                    rbtConnect8.Checked = true;
                    neighInit();
                    tbxLifeLow.Text = "3";
                    tbxLifeHigh.Text = "4";
                    tbxDeathLow.Text = "4";
                    tbxDeathHigh.Text = "6";
                    lifeLow = 3;
                    lifeHigh = 4;
                    deathLow = 4;
                    deathHigh = 6;
                    break;
                case 4:
                    rbtConnect8.Checked = true;
                    neighInit();
                    tbxLifeLow.Text = "3";
                    tbxLifeHigh.Text = "5";
                    tbxDeathLow.Text = "4";
                    tbxDeathHigh.Text = "7";
                    lifeLow = 3;
                    lifeHigh = 5;
                    deathLow = 4;
                    deathHigh = 7;
                    break;
                case 5:
                    rbtConnect8.Checked = true;
                    neighInit();
                    tbxLifeLow.Text = "3";
                    tbxLifeHigh.Text = "3";
                    tbxDeathLow.Text = "1";
                    tbxDeathHigh.Text = "5";
                    lifeLow = 3;
                    lifeHigh = 3;
                    deathLow = 1;
                    deathHigh = 5;
                    break;
                case 6:
                    rbtConnect8.Checked = true;
                    neighInit();
                    tbxLifeLow.Text = "3";
                    tbxLifeHigh.Text = "3";
                    tbxDeathLow.Text = "2";
                    tbxDeathHigh.Text = "4";
                    lifeLow = 3;
                    lifeHigh = 3;
                    deathLow = 2;
                    deathHigh = 4;
                    break;
                case 7:
                    rbtConnect8.Checked = true;
                    neighInit();
                    tbxLifeLow.Text = "3";
                    tbxLifeHigh.Text = "4";
                    tbxDeathLow.Text = "2";
                    tbxDeathHigh.Text = "3";
                    lifeLow = 3;
                    lifeHigh = 4;
                    deathLow = 2;
                    deathHigh = 3;
                    break;
                case 8:
                    rbtConnect8.Checked = true;
                    neighInit();
                    tbxLifeLow.Text = "3";
                    tbxLifeHigh.Text = "4";
                    tbxDeathLow.Text = "2";
                    tbxDeathHigh.Text = "2";
                    lifeLow = 3;
                    lifeHigh = 4;
                    deathLow = 2;
                    deathHigh = 2;
                    break;
                case 9:
                    rbtConnect8.Checked = true;
                    neighInit();
                    tbxLifeLow.Text = "5";
                    tbxLifeHigh.Text = "8";
                    tbxDeathLow.Text = "4";
                    tbxDeathHigh.Text = "8";
                    lifeLow = 5;
                    lifeHigh = 8;
                    deathLow = 4;
                    deathHigh = 8;
                    break;
                case 10:
                    rbtConnect8.Checked = true;
                    neighInit();
                    tbxLifeLow.Text = "1";
                    tbxLifeHigh.Text = "1";
                    tbxDeathLow.Text = "0";
                    tbxDeathHigh.Text = "8";
                    lifeLow = 1;
                    lifeHigh = 1;
                    deathLow = 0;
                    deathHigh = 8;
                    break;
                case 11:
                    rbtConnect4.Checked = true;
                    neighInit();
                    tbxLifeLow.Text = "1";
                    tbxLifeHigh.Text = "1";
                    tbxDeathLow.Text = "0";
                    tbxDeathHigh.Text = "8";
                    lifeLow = 1;
                    lifeHigh = 1;
                    deathLow = 0;
                    deathHigh = 8;
                    break;
                default:
                    break;
            }

        }
    }
}
