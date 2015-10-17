using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Saper
{
    public partial class Form1 : Form
    {
        MineBox[] MB;
        MinePole pole;
        int poleX, poleY, poleNM;
        int NumGame;
        public Form1(int x, int y, int nf, int ng)
        {
            InitializeComponent();
            StartGame(x, y, nf, ng);
        }

        public void StartGame(int x, int y, int nf, int ng)
        {
            poleX = x;
            poleY = y;
            poleNM = nf;
            NumGame = ng;
            NumMineText.Text = nf.ToString();
            TimerText.Text = "00:00";
            TimerText.Location = new Point(x * 20 - 38, 0);
            NewGameBtn.Location = new Point(x * 10 - 10, 0);
            Pole.Width = x * 20 + 2;
            Pole.Height = y * 20 + 2;
            Morda.Width = x * 20 + 2;
            this.Width = x * 20 + 20;
            this.Height = y * 20 + 100;
            this.MB = new MineBox[x * y];
            int n = 0;
            for (int j = 0; j < y; j++)
                for (int i = 0; i < x; i++)
                {
                    MB[n] = new MineBox();
                    this.MB[n].Location = new System.Drawing.Point(20 * i, 20 * j);
                    this.MB[n].Size = new System.Drawing.Size(20, 20);
                    this.MB[n].Name = "MineBox " + n;
                    this.MB[n].TabIndex = n;
                    this.MB[n].TabStop = false;
                    this.MB[n].MouseDown += new System.Windows.Forms.MouseEventHandler(Box_Click);
                    Pole.Controls.Add(MB[n]);
                    n++;
                }
            pole = new MinePole(x, y, nf);
        }

        public void DelPole()
        {
            int n = 0;
            for (int j = 0; j < poleY; j++)
                for (int i = 0; i < poleX; i++)
                {
                    Pole.Controls.Remove(MB[n]);
                    n++;
                }
        }

        public void Box_Click(object sender, MouseEventArgs e)
        {
            MineBox btn = (MineBox)sender;

            if (!pole.PrEndGame)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (pole.FirstClickYN)
                    {
                        pole.FirstClickYN = false;
                        timer.Enabled = true;
                    }
                    if (pole.Bum(btn, MB) == 1)
                    {
                        timer.Enabled = false;
                        pole.ShowAllBum(MB);
                        pole.PrEndGame = true;
                        MessageBox.Show("Вы проиграли!!!");
                    }
                    if (pole.GetOpenBox == poleX * poleY - poleNM)
                    {
                        timer.Enabled = false;
                        pole.ShowAllV(MB);
                        pole.SetFlag(btn);
                        NumMineText.Text = pole.GetNFlag.ToString();
                        pole.PrEndGame = true;
                        MessageBox.Show("Ура победа!!!");
                        IfRecord();
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    if (pole.FirstClickYN)
                    {
                        pole.FirstClickYN = false;
                        timer.Enabled = true;
                    }
                    pole.SetFlag(btn);
                    NumMineText.Text = pole.GetNFlag.ToString();
                }
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            int[] ClockTime = pole.ShowTime();
            TimerText.Text = ClockTime[0].ToString("D2") + ":" + ClockTime[1].ToString("D2");
            if (ClockTime[0] == 59 && ClockTime[1] == 59)
                timer.Enabled = false;
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //Form.ShowDialog(Form1);
           // Application.Restart();// .Run(new Form1(6, 8, 6));
            DelPole();
            StartGame(poleX, poleY, poleNM, NumGame);
            timer.Enabled = false;
        }

        private void MSettings_Click(object sender, EventArgs e)
        {
            Settings WinSet = new Settings();
            if (WinSet.ShowDialog() == DialogResult.OK)
            {
                StreamReader fsetup = new StreamReader("setup.ini");
                string SetStr = fsetup.ReadLine();
                fsetup.Close();
                string[] Set = SetStr.Split(' ');
                DelPole();
                StartGame(Int32.Parse(Set[0]), Int32.Parse(Set[1]), Int32.Parse(Set[2]), Int32.Parse(Set[3]));
            }
        }

        private void Record_Click(object sender, EventArgs e)
        {
            StreamReader frecord = new StreamReader("records.ini");
            string RecShow = "";
            string RecordStr;
            string[] buf;
            while ((RecordStr = frecord.ReadLine()) != null)
            {
                buf = RecordStr.Split(' ');
                RecShow += buf[0] + ":   ";
                if (buf[1] == "99")
                    RecShow += "Не определен";
                else if (buf[1] == "59" && buf[2] == "59")
                    RecShow += "более часа";
                else
                    RecShow += buf[3] + "  " + buf[1] + " мин " + buf[2] + " сек   ";
                RecShow += "\n";

            }
            MessageBox.Show(RecShow, "Рекорды");
            frecord.Close();
        }

        private void RecordClear_Click(object sender, EventArgs e)
        {
            File.Delete("records.ini");
            File.AppendAllText("records.ini", "Новичок 99 99 Anonim\nОпытный 99 99 Anonim\nЭлита 99 99 Anonim");
        }

        private void mNewGame_Click(object sender, EventArgs e)
        {
            DelPole();
            StartGame(poleX, poleY, poleNM, NumGame);
            timer.Enabled = false;
        }

        private void mExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void IfRecord()
        {
            StreamReader frecord = new StreamReader("records.ini");
            NewRec NewRecords = new NewRec();
            int[] ClockTime = pole.ShowTime();
            string RStr1 = frecord.ReadLine();
            string RStr2 = frecord.ReadLine();
            string RStr3 = frecord.ReadLine();
            frecord.Close();
            string[] buf;     
            if (NumGame == 1)
            {
                buf = RStr1.Split(' ');
                if ((60 * ClockTime[0] + ClockTime[1] - 1) < (60 * Int32.Parse(buf[1]) + Int32.Parse(buf[2])))
                {
                    if (NewRecords.ShowDialog() == DialogResult.OK)
                        RStr1 = "Новичок " + ClockTime[0].ToString() + " " + (ClockTime[1] - 1).ToString() + " " + NewRecords.NewName;
                }
            }

            if (NumGame == 2)
            {
                buf = RStr2.Split(' ');
                if ((60 * ClockTime[0] + ClockTime[1] - 1) < (60 * Int32.Parse(buf[1]) + Int32.Parse(buf[2])))
                {
                    if (NewRecords.ShowDialog() == DialogResult.OK)
                        RStr2 = "Опытный " + ClockTime[0].ToString() + " " + (ClockTime[1] - 1).ToString() + " " + NewRecords.NewName;
                }
            }

            if (NumGame == 3)
            {
                buf = RStr3.Split(' ');
                if ((60 * ClockTime[0] + ClockTime[1] - 1) < (60 * Int32.Parse(buf[1]) + Int32.Parse(buf[2])))
                {
                    if (NewRecords.ShowDialog() == DialogResult.OK)
                        RStr3 = "Элита " + ClockTime[0].ToString() + " " + (ClockTime[1] - 1).ToString() + " " + NewRecords.NewName;
                }
            }

            File.Delete("records.ini");
            File.AppendAllText("records.ini", RStr1 + "\n" + RStr2 + "\n" + RStr3 + "\n");
        }
    }

    public class MineBox : Button
    {
        public void Fmine(Boolean BAX)
        {
            if (BAX)
                this.BackgroundImage = Image.FromFile("mine_bax.bmp");
            else
                this.BackgroundImage = Image.FromFile("mine.bmp");
            this.Enabled = false;
        }

        public void FflagSet()
        {
            this.Image = Image.FromFile("flag.bmp");
        }

        public void FflagDel()
        {
            this.Image = null;
 
        }

        public void FErrFlag()
        {
            this.Image = Image.FromFile("ErrFlag.bmp");
        }

        public void Fnum(int N)
        {            
            if (N == 0)
                this.Text = "";
            else
                this.Text = N.ToString();
            this.Enabled = false;
        }

        public void Fempty()
        {
            this.Enabled=false;
        }
    }

    public class MinePole 
    {
        int[] BoxPole; 
        int[] Flags;
        int X, Y;
        int NumFlag;
        int OpenBox;
        int[] Clock;
        Boolean EndGame;
        Boolean FirstClick;

        public MinePole(int x, int y, int NumMine)
        {
            this.X = x;
            this.Y = y;
            this.NumFlag = NumMine;
            OpenBox = 0;
            Clock = new int[2] {0,0};
            FirstClick = true;
            EndGame = false;
            BoxPole = new int[x * y];
            Flags = new int[x * y];
            Random RndMine = new Random();
            int Mine = 0;
            for (int i = 0; i < NumMine;)
            {
                Mine = RndMine.Next(0, x * y - 1);
                if (BoxPole[Mine] != 9)
                {
                    BoxPole[Mine] = 9;
                    i++;
                }
            }

            int n;
            for (int i = 0; i < x * y; i++)
            {
                n=0;
                if (BoxPole[i] != 9)
                {
                    if (i % x != x - 1)
                        if (BoxPole[i + 1] == 9)
                            n += 1;
                    if (i + x < x * y)
                        if (BoxPole[i + x] == 9)
                            n += 1;
                    if (i % x != 0)
                        if (BoxPole[i - 1] == 9)
                            n += 1;
                    if (i - x >= 0)
                        if (BoxPole[i - x] == 9)
                            n += 1;
                    if (i % x != x - 1 && i + x + 1 < x * y)
                        if (BoxPole[i + x + 1] == 9) 
                            n += 1;
                    if (i % x != 0 && i - x - 1 >= 0)
                        if (BoxPole[i - x - 1] == 9)
                            n += 1;
                    if (i % x != x - 1 && i - x + 1 >= 0)
                        if (BoxPole[i - x + 1] == 9)
                            n += 1;
                    if (i % x != 0 && i + x - 1 < x * y)
                        if (BoxPole[i + x - 1] == 9)
                            n += 1;
                    BoxPole[i] = n;
                }
            }
        }

        public int ReturnNum(MineBox Box)
        {
            int i = Box.TabIndex;
            return BoxPole[i];
        }

        public void SetFlag(MineBox Box)
        {
            int i = Box.TabIndex;
            if (Flags[i] == 1)
            {
                Box.FflagDel();
                Flags[i] = 0;
                this.NumFlag += 1;
            }

            else if (Flags[i] != 1 && this.NumFlag > 0)                
            {
                Box.FflagSet();
                Flags[i] = 1;
                this.NumFlag -= 1;
            }
        }

        public int Bum(MineBox Box, MineBox[] MBox)
        {            
            int i = Box.TabIndex;
            if (Flags[i] != 1)
                if (ReturnNum(Box) == 9)
                {
                    Box.Fmine(true);
                    return 1;           // взрыв
                }
                else if (ReturnNum(Box) == 0)
                {
                    EmptyBox(Box, MBox);   //пустая ячейка
                    return 0;
                }
                else
                {
                    Box.Fnum(ReturnNum(Box));    //ячейка с числом
                    OpenBox++;
                    return 0;
                }
            return 0;
        }

        public void EmptyBox(MineBox Box, MineBox[] MBox)
        {
            int i = Box.TabIndex;
            Box.Fnum(ReturnNum(Box));
            OpenBox++;
            if (i % X != X - 1)
            {
                if (ReturnNum(MBox[i + 1]) == 0 && MBox[i + 1].Enabled == true)
                {
                    EmptyBox(MBox[i + 1], MBox);
                }
                else if (MBox[i + 1].Enabled == true)
                {
                    MBox[i + 1].Fnum(ReturnNum(MBox[i + 1]));
                    OpenBox++;
                }
            }
            if (i + X < X * Y)
            {
                if (ReturnNum(MBox[i + X]) == 0 && MBox[i + X].Enabled == true)
                    EmptyBox(MBox[i + X], MBox);
                else if (MBox[i + X].Enabled == true)
                {
                    MBox[i + X].Fnum(ReturnNum(MBox[i + X]));
                    OpenBox++;
                }
            }
            if (i % X != 0)
            {
                if (ReturnNum(MBox[i - 1]) == 0 && MBox[i - 1].Enabled == true)
                    EmptyBox(MBox[i - 1], MBox);
                else if (MBox[i - 1].Enabled == true)
                {
                    MBox[i - 1].Fnum(ReturnNum(MBox[i - 1]));
                    OpenBox++;
                }
            }
            if (i - X >= 0)
            {
                if (ReturnNum(MBox[i - X]) == 0 && MBox[i - X].Enabled == true)
                    EmptyBox(MBox[i - X], MBox);
                else if (MBox[i - X].Enabled == true)
                {
                    MBox[i - X].Fnum(ReturnNum(MBox[i - X]));
                    OpenBox++;
                }
            }
            if (i % X != X - 1 && i + X + 1 < X * Y)
            {
                if (ReturnNum(MBox[i + X + 1]) == 0 && MBox[i + X + 1].Enabled == true)
                    EmptyBox(MBox[i + X + 1], MBox);
                else if (MBox[i + X + 1].Enabled == true)
                {
                    MBox[i + X + 1].Fnum(ReturnNum(MBox[i + X + 1]));
                    OpenBox++;
                }
            }
            if (i % X != 0 && i - X - 1 >= 0)
            {
                if (ReturnNum(MBox[i - X - 1]) == 0 && MBox[i - X - 1].Enabled == true)
                    EmptyBox(MBox[i - X - 1], MBox);
                else if (MBox[i - X - 1].Enabled == true)
                {
                    MBox[i - X - 1].Fnum(ReturnNum(MBox[i - X - 1]));
                    OpenBox++;
                }
            }
            if (i % X != X - 1 && i - X + 1 >= 0)
            {
                if (ReturnNum(MBox[i - X + 1]) == 0 && MBox[i - X + 1].Enabled == true)
                    EmptyBox(MBox[i - X + 1], MBox);
                else if (MBox[i - X + 1].Enabled == true)
                {
                    MBox[i - X + 1].Fnum(ReturnNum(MBox[i - X + 1]));
                    OpenBox++;
                }
            }
            if (i % X != 0 && i + X - 1 < X * Y)
            {
                if (ReturnNum(MBox[i + X - 1]) == 0 && MBox[i + X - 1].Enabled == true)
                    EmptyBox(MBox[i + X - 1], MBox);
                else if (MBox[i + X - 1].Enabled == true)
                {
                    MBox[i + X - 1].Fnum(ReturnNum(MBox[i + X - 1]));
                    OpenBox++;
                }
            }
        }

        public void ShowAllBum(MineBox[] MinB)
        {
            for (int i = 0; i < X * Y; i++)
            {
                if (BoxPole[i] == 9 && MinB[i].Enabled == true && Flags[i] != 1)
                    MinB[i].Fmine(false);
                else if (BoxPole[i] != 9 && MinB[i].Enabled == true && Flags[i] == 1)
                    MinB[i].FErrFlag();
                else if (BoxPole[i] != 9 && Flags[i] != 1)
                    MinB[i].Fnum(BoxPole[i]);

            }
        }

        public void ShowAllV(MineBox[] MinB)
        {
            for (int i = 0; i < X * Y; i++)
            {
                if (MinB[i].Enabled == true && Flags[i] != 1)
                {
                    Flags[i] = 1;
                    NumFlag--;
                    MinB[i].FflagSet();
                }
            }
        }

        public int[] ShowTime()
        {
            if (Clock[1] != 59)
                Clock[1]++;
            else
            {
                Clock[1] = 0;
                Clock[0]++;
            }
            return Clock;
        }

        public Boolean FirstClickYN {
            get {
                return FirstClick;
            }
            set {
                FirstClick = value;
            }
        }

        public int GetNFlag
        {
            get
            {
                return NumFlag;
            }
        }

        public int GetOpenBox
        {
            get
            {
                return OpenBox;
            }
        }

        public Boolean PrEndGame
        {
            get
            {
                return EndGame;
            }
            set
            {
                EndGame = value;
            }
        }
    }

}
