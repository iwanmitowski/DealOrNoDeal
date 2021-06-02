using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СделкаИлиНе
{

    public partial class DealOrNot : Form
    {
        //Variables
        public string userName;
        static string[] prizes = new string[] { "00.10", "00.50", "20.00", "100.00", "300.00", "5000", "7500", "12000", "25000", "100000" };
        List<string> currentPrizes = prizes.ToList();
        int[] arr; //Box Generation
        int openedBoxes = 0;
        BankOffer bankOffer = new BankOffer();
        public static bool isAccepted = false; //Accepted bank offer
        bool isChosen = false; //Is the player box chosen
        bool isSwapping = false; //Is player swapping the boxes 
        string wonPrize = string.Empty;
        bool lastDealIsSwap = false;


        public DealOrNot()
        {
            InitializeComponent();

        }


        //Preloading backend scenario
        int fillingCounter = 0;
        private void FillingScreenPrizes()
        {
            RefreshPrizesFile();
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is Label && Controls[i].Name.Contains("label"))
                {
                    Controls[i].Text = prizes[fillingCounter++];
                }
                if (fillingCounter == 9)
                {
                    break;
                }
            }

        }


        private void RemovingFromScreenPrizesAndRefreshPrizesFile(string prize)
        {
            RemovePrizeAndRefreshPrizesFile(prize);
            foreach (Control item in this.Controls)
            {
                if (item is Label && item.Text.Contains(prize) && item.Name.Contains("label"))
                {
                    item.Visible = false;
                    break;
                }
            }
        }


        private int[] GeneratingBoxes()
        {
            int[] arr = new int[10];
            Random boxRnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int num = boxRnd.Next(1, 11);
                if (arr.Contains(num))
                {
                    i--;
                    continue;
                }
                arr[i] = num;

            }

            return arr;

        }


        private void FillingClosedBoxes()
        {

            for (int i = 0; i < 10; i++)
            {
                int counter = 0;


                for (int j = 0; j < this.Controls.Count; j++)
                {

                    if (counter > 9)
                    {
                        break;
                    }
                    int num = arr[counter++];


                    if (Controls[j] is PictureBox && Controls[j].Name.Contains("Closed"))
                    {
                        PictureBox item = (PictureBox)Controls[j];

                        switch (num)
                        {
                            case 1:
                                item.Image = Properties.Resources._1BoxClosed;
                                lblPrize1Box.Text = prizes[counter - 1];
                                break;
                            case 2:
                                item.Image = Properties.Resources._2BoxClosed;
                                lblPrize2Box.Text = prizes[counter - 1];

                                break;
                            case 3:
                                item.Image = Properties.Resources._3BoxClosed;
                                lblPrize3Box.Text = prizes[counter - 1];

                                break;
                            case 4:
                                item.Image = Properties.Resources._4BoxClosed;
                                lblPrize4Box.Text = prizes[counter - 1];

                                break;
                            case 5:
                                item.Image = Properties.Resources._5BoxClosed;
                                lblPrize5Box.Text = prizes[counter - 1];

                                break;
                            case 6:
                                item.Image = Properties.Resources._6BoxClosed;
                                lblPrize6Box.Text = prizes[counter - 1];

                                break;
                            case 7:
                                item.Image = Properties.Resources._7BoxClosed;
                                lblPrize7Box.Text = prizes[counter - 1];

                                break;
                            case 8:
                                item.Image = Properties.Resources._8BoxClosed;
                                lblPrize8Box.Text = prizes[counter - 1];

                                break;
                            case 9:
                                item.Image = Properties.Resources._9BoxClosed;
                                lblPrize9Box.Text = prizes[counter - 1];

                                break;
                            case 10:
                                item.Image = Properties.Resources._10BoxClosed;
                                lblPrize10Box.Text = prizes[counter - 1];

                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        counter--;
                    }

                }
            }
        }


        private void FillingOpenedBoxes()
        {
            for (int i = 0; i < 10; i++)
            {
                int counter = 0;

                for (int j = 0; j < this.Controls.Count; j++)
                {
                    if (counter > 9)
                    {
                        break;
                    }
                    int num = arr[counter++];


                    if (Controls[j] is PictureBox && Controls[j].Name.Contains("Opened"))
                    {


                        PictureBox itemOpened = (PictureBox)Controls[j];
                        itemOpened.Visible = false;
                        switch (num)
                        {
                            case 1:
                                itemOpened.Image = Properties.Resources._1BoxOpened;

                                break;
                            case 2:
                                itemOpened.Image = Properties.Resources._2BoxOpened;
                                break;
                            case 3:
                                itemOpened.Image = Properties.Resources._3BoxOpened;
                                break;
                            case 4:
                                itemOpened.Image = Properties.Resources._4BoxOpened;
                                break;
                            case 5:
                                itemOpened.Image = Properties.Resources._5BoxOpened;
                                break;
                            case 6:
                                itemOpened.Image = Properties.Resources._6BoxOpened;
                                break;
                            case 7:
                                itemOpened.Image = Properties.Resources._7BoxOpened;
                                break;
                            case 8:
                                itemOpened.Image = Properties.Resources._8BoxOpened;
                                break;
                            case 9:
                                itemOpened.Image = Properties.Resources._9BoxOpened;
                                break;
                            case 10:
                                itemOpened.Image = Properties.Resources._10BoxOpened;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        counter--;
                    }
                }

            }
        }


        //Loadtime 
        private void DealOrNot_Load(object sender, EventArgs e)
        {
            arr = GeneratingBoxes();
            FillingClosedBoxes();
            FillingOpenedBoxes();
            HideLblPrizeBox();
            FillingScreenPrizes();
            lblPlayerName.Text = userName;
            lblPlayerPrize.Visible = false;
            btnToHighScores.Visible = false;
            btnToMenu.Visible = false;
            isAccepted = false;
            MaximizeBox = false;
        }
        private void HideLblPrizeBox()
        {
            lblPrize1Box.Visible = false;
            lblPrize2Box.Visible = false;
            lblPrize3Box.Visible = false;
            lblPrize4Box.Visible = false;
            lblPrize5Box.Visible = false;
            lblPrize6Box.Visible = false;
            lblPrize7Box.Visible = false;
            lblPrize8Box.Visible = false;
            lblPrize9Box.Visible = false;
            lblPrize10Box.Visible = false;
            prizePlaceholder.Visible = false;
        }


        //Main Logic
        int turncounter = 1;

        private void OpeningBoxLogic(PictureBox pictureBoxNOpened, Label lblPrizeNBox, PictureBox pictureBoxNClosed)
        {
            RemovingFromScreenPrizesAndRefreshPrizesFile(lblPrizeNBox.Text);
            pictureBoxNOpened.Visible = true;
            lblPrizeNBox.Visible = true;
        }


        private bool SkippingIterationIfSwapping(PictureBox pictureBoxNOpened, Label lblPrizeNBox, PictureBox pictureBoxNClosed)
        {
            SendPlaceholderToSwappedBox(pictureBoxNOpened, lblPrizeNBox, pictureBoxNClosed);
            if (CheckIfLastDealWasSwap())
            {
                lastDealIsSwap = false;
                return true;
            }
            return false;
        }


        private void OpenBox(object sender, MouseEventArgs e)
        {
            ChooseBox.Visible = false;

            if (turncounter++ == 1)
            {
                MessageBox.Show("Време е да отворим 2 кутии!");
                return;
            }

            PlayMusic("Windows Exclamation.WAV");

            if (((PictureBox)sender).Name.Contains("2"))
            {
                if (SkippingIterationIfSwapping(pictureBox2Opened, lblPrize2Box, pictureBox2Closed))
                {
                    return;
                }
                OpeningBoxLogic(pictureBox2Opened, lblPrize2Box, pictureBox2Closed);


            }
            else if (((PictureBox)sender).Name.Contains("3"))
            {
                if (SkippingIterationIfSwapping(pictureBox3Opened, lblPrize3Box, pictureBox3Closed))
                {
                    return;
                }
                OpeningBoxLogic(pictureBox3Opened, lblPrize3Box, pictureBox3Closed);

            }
            else if (((PictureBox)sender).Name.Contains("4"))
            {

                if (SkippingIterationIfSwapping(pictureBox4Opened, lblPrize4Box, pictureBox4Closed))
                {
                    return;
                }
                OpeningBoxLogic(pictureBox4Opened, lblPrize4Box, pictureBox4Closed);

            }
            else if (((PictureBox)sender).Name.Contains("5"))
            {

                if (SkippingIterationIfSwapping(pictureBox5Opened, lblPrize5Box, pictureBox5Closed))
                {
                    return;
                }
                OpeningBoxLogic(pictureBox5Opened, lblPrize5Box, pictureBox5Closed);

            }
            else if (((PictureBox)sender).Name.Contains("6"))
            {

                if (SkippingIterationIfSwapping(pictureBox6Opened, lblPrize6Box, pictureBox6Closed))
                {
                    return;
                }
                OpeningBoxLogic(pictureBox6Opened, lblPrize6Box, pictureBox6Closed);

            }
            else if (((PictureBox)sender).Name.Contains("7"))
            {

                if (SkippingIterationIfSwapping(pictureBox7Opened, lblPrize7Box, pictureBox7Closed))
                {
                    return;
                }
                OpeningBoxLogic(pictureBox7Opened, lblPrize7Box, pictureBox7Closed);

            }
            else if (((PictureBox)sender).Name.Contains("8"))
            {

                if (SkippingIterationIfSwapping(pictureBox8Opened, lblPrize8Box, pictureBox8Closed))
                {
                    return;
                }
                OpeningBoxLogic(pictureBox8Opened, lblPrize8Box, pictureBox8Closed);

            }
            else if (((PictureBox)sender).Name.Contains("9"))
            {

                if (SkippingIterationIfSwapping(pictureBox9Opened, lblPrize9Box, pictureBox9Closed))
                {
                    return;
                }
                OpeningBoxLogic(pictureBox9Opened, lblPrize9Box, pictureBox9Closed);

            }
            else if (((PictureBox)sender).Name.Contains("10"))
            {

                if (SkippingIterationIfSwapping(pictureBox10Opened, lblPrize10Box, pictureBox10Closed))
                {
                    return;
                }
                OpeningBoxLogic(pictureBox10Opened, lblPrize10Box, pictureBox10Closed);

            }
            else
            {
                if (SkippingIterationIfSwapping(pictureBox1Opened, lblPrize1Box, pictureBox1Closed))
                {
                    return;
                }
                OpeningBoxLogic(pictureBox1Opened, lblPrize1Box, pictureBox1Closed);

            }

            openedBoxes++;


            if (openedBoxes == 8 && isAccepted == true)
            {
                BankOffer();

            }

            if (openedBoxes % 2 == 0 && openedBoxes <= 8 && isAccepted == false)
            {
                BankOffer();
            }

            if (openedBoxes == 9)
            {
                FinishingTheGame();
            }

        }
        private void BankOffer()
        {

            if ((openedBoxes % 2 == 0 && openedBoxes <= 8))
            {
                PlayMusic("Windows Ringin.WAV");

                bankOffer.StartPosition = FormStartPosition.CenterScreen;


                if (bankOffer.ShowDialog() == DialogResult.OK)
                {

                    string[] comeingOffer = bankOffer.Offer.Split();
                    if (isAccepted == false && decimal.TryParse(comeingOffer[0], out decimal priz))
                    {
                        MessageBox.Show($"Приехте офертата на банката!{Environment.NewLine}Отворете другите кутии, за да видим на печалба ли сте!");
                        isAccepted = true;
                        wonPrize = $"{comeingOffer[0]}";
                        lastDealIsSwap = false;
                        bankOffer.isAccepted = true;
                    }
                    else
                    {
                        if (openedBoxes == 8)
                        {
                            MessageBox.Show($"Приехте офертата на банката!{Environment.NewLine}Смяна на кутиите, нека видим какво се крие във вашата кутия!");

                        }
                        else
                        {
                            MessageBox.Show($"Приехте офертата на банката!{Environment.NewLine}Смяна на кутиите!");
                        }
                        isSwapping = true;
                        if (isSwapping)
                        {

                            isChosen = false;
                        }
                        lastDealIsSwap = true;
                    }

                }
                else
                {
                    if (openedBoxes == 8)
                    {
                        MessageBox.Show("Време е да отворим последните кутии!");

                    }
                    else
                    {
                        MessageBox.Show("Време е да отворим 2 кутии!");

                    }
                }

                RemoveOpenedBoxes();
            }
        }

        public void PlayMusic(string music)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(music);
            player.Play();
            player.Play();
            player.Play();
            player.Dispose();
        }

        public bool CheckIfLastDealWasSwap()
        {
            return lastDealIsSwap;
        }


        public void SendPlaceholderToSwappedBox(PictureBox pb, Label lbl, PictureBox pbcl)
        {
            if (isSwapping == true)
            {
                pb.Image = pbPlaceholderop.Image;
                lbl.Text = prizePlaceholder.Text;
                pbcl.Image = pbPlaceholdercl.Image;
                isSwapping = false;

            }

        }


        public void RemovePrizeAndRefreshPrizesFile(string prize)
        {
            currentPrizes.Remove(prize);
            RefreshPrizesFile();
        }


        public void RefreshPrizesFile()
        {
            string dest = Path.Combine("Prizes.txt");

            File.WriteAllLines(dest, currentPrizes);
        }


        public void RemoveOpenedBoxes()
        {
            if (pictureBox1Opened.Visible == true)
            {
                HideBoxElements(pictureBox1Opened, pictureBox1Closed, lblPrize1Box);
            }
            if (pictureBox2Opened.Visible == true)
            {
                HideBoxElements(pictureBox2Opened, pictureBox2Closed, lblPrize2Box);
            }
            if (pictureBox3Opened.Visible == true)
            {
                HideBoxElements(pictureBox3Opened, pictureBox3Closed, lblPrize3Box);
            }
            if (pictureBox4Opened.Visible == true)
            {
                HideBoxElements(pictureBox4Opened, pictureBox4Closed, lblPrize4Box);
            }
            if (pictureBox5Opened.Visible == true)
            {
                HideBoxElements(pictureBox5Opened, pictureBox5Closed, lblPrize5Box);
            }
            if (pictureBox6Opened.Visible == true)
            {
                HideBoxElements(pictureBox6Opened, pictureBox6Closed, lblPrize6Box);
            }
            if (pictureBox7Opened.Visible == true)
            {
                HideBoxElements(pictureBox7Opened, pictureBox7Closed, lblPrize7Box);
            }
            if (pictureBox8Opened.Visible == true)
            {
                HideBoxElements(pictureBox8Opened, pictureBox8Closed, lblPrize8Box);
            }
            if (pictureBox9Opened.Visible == true)
            {
                HideBoxElements(pictureBox9Opened, pictureBox9Closed, lblPrize9Box);
            }
            if (pictureBox10Opened.Visible == true)
            {
                HideBoxElements(pictureBox10Opened, pictureBox10Closed, lblPrize10Box);
            }
        }
        private void HideBoxElements(PictureBox pbOpened, PictureBox pbClosed, Label lbl)
        {
            pbOpened.Visible = false;
            pbClosed.Visible = false;
            lbl.Visible = false;
        }


        //Early Game
        private void ChoosePlayersBox(object sender, EventArgs e)
        {
            ChooseOrSwapPlayersBox(sender, e);
        }


        private void ChooseOrSwapPlayersBox(object sender, EventArgs e)
        {
            if (isChosen == true)
            {
                return;
            }

            if (isSwapping)
            {
                pbPlaceholderop.Image = pbPlayeropened.Image;
                pbPlaceholdercl.Image = pbPlayerclosed.Image;
                prizePlaceholder.Text = lblPlayerPrize.Text;
            }


            //Disabling box

            pbPlayerclosed.Image = ((PictureBox)sender).Image;
            if (turncounter == 1)
            {
                ((PictureBox)sender).Visible = false;

            }

            PictureBox current = (PictureBox)sender;

            if (current.Name.Contains("10"))
            {
                SetPlayerOpenedBoxAndPrize(pictureBox10Opened, lblPrize10Box);


            }
            else if (current.Name.Contains("2"))
            {
                SetPlayerOpenedBoxAndPrize(pictureBox2Opened, lblPrize2Box);

            }
            else if (current.Name.Contains("3"))
            {
                SetPlayerOpenedBoxAndPrize(pictureBox3Opened, lblPrize3Box);

            }
            else if (current.Name.Contains("4"))
            {
                SetPlayerOpenedBoxAndPrize(pictureBox4Opened, lblPrize4Box);

            }
            else if (current.Name.Contains("5"))
            {
                SetPlayerOpenedBoxAndPrize(pictureBox5Opened, lblPrize5Box);

            }
            else if (current.Name.Contains("6"))
            {
                SetPlayerOpenedBoxAndPrize(pictureBox6Opened, lblPrize6Box);

            }
            else if (current.Name.Contains("7"))
            {
                SetPlayerOpenedBoxAndPrize(pictureBox7Opened, lblPrize7Box);

            }
            else if (current.Name.Contains("8"))
            {
                SetPlayerOpenedBoxAndPrize(pictureBox8Opened, lblPrize8Box);

            }
            else if (current.Name.Contains("9"))
            {
                SetPlayerOpenedBoxAndPrize(pictureBox9Opened, lblPrize9Box);

            }
            else
            {
                SetPlayerOpenedBoxAndPrize(pictureBox1Opened, lblPrize1Box);

            }

            pbPlayeropened.Visible = false;
            lblPlayerPrize.Visible = false;
            isChosen = true;
        }
        private void SetPlayerOpenedBoxAndPrize(PictureBox pb, Label lbl)
        {
            pbPlayeropened.Image = pb.Image;
            lblPlayerPrize.Text = lbl.Text;
        }

        //End Game
        public void WriteWinnerInFile()
        {
            string dest = Path.Combine("HighScore.txt");
            List<string> lines = File.ReadAllLines(dest).ToList();
            lines.Add($"{userName} - {wonPrize}");

            File.WriteAllLines(dest, lines);
        }


        public void FinishingTheGame()
        {
            if (isAccepted == false)
            {
                wonPrize = lblPlayerPrize.Text;
            }

            pbPlayeropened.Visible = true;
            lblPlayerPrize.Visible = true;

            foreach (Control item in this.Controls)
            {
                if (item is Label && item.Name.Contains("label"))
                {
                    item.Visible = false;

                    continue;
                }
            }

            if (isAccepted)
            {
                MessageBox.Show($"{userName}, Вие спечелихте {wonPrize} лева!{Environment.NewLine}Вие имахте {lblPlayerPrize.Text} лева във вашата кутия!");

                if (double.Parse(wonPrize) > double.Parse(lblPlayerPrize.Text))
                {
                    PlayMusic("tada.WAV");
                }
                else
                {
                    PlayMusic("Windows Logoff Sound.WAV");
                }
            }
            else
            {
                MessageBox.Show($"{userName}, Вие спечелихте {wonPrize} лева!");
                PlayMusic("Windows Print complete.WAV");

            }

            WriteWinnerInFile();

            if (wonPrize == "100000")
            {
                EndGame.Image = Properties.Resources._10000;

            }
            else
            {
                EndGame.Image = Properties.Resources.EndGameBox;
                EndGamePrize.Visible = true;

            }


            EndGamePrize.Text = wonPrize;
            EndGame.Visible = true;
            Button.Visible = false;
            btnToHighScores.Visible = true;
            btnToMenu.Visible = true;

        }


        private void btnToHighScores_Click(object sender, EventArgs e)
        {
            this.Hide();

            HighScores highScores = new СделкаИлиНе.HighScores();
            highScores.ShowDialog();
        }

        private void btnToMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Наистина ли искате да се върнете към менюто ?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
