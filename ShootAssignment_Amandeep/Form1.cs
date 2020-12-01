using ShootAssignment_Amandeep.Classes;
using ShootAssignment_Amandeep.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootAssignment_Amandeep
{
    public partial class Form1 : Form
    {
        // Assign variables

        int load, away, totalShot, win, loss, totalGamePlayed = 0;
        int myNum;
        bool isGameOver = false;
        bool isPassing = false;
        string userName;

        gamePlay myGamePlay = new gamePlay();
        soundPlayers mysoundPlayer = new soundPlayers();
        public Form1()
        {
            InitializeComponent();
            mysoundPlayer.soundPlayerSystem(Resources.gameSound);
        }

        //Assign Debug or counts
        private void debug()
        {
            totalShot = load + away;
            this.Text = "Load = " + load + " Away = " + away + " Total = " + totalShot;
            totalGamePlayed = loss + win;
            this.Text = "win = " + win + " loss = " + loss + " Total game played = " + totalGamePlayed;
        }
        private void btnLoader_Click(object sender, EventArgs e)
        {
            mysoundPlayer.soundPlayerSystem(Resources.load);
            myNum = myGamePlay.RndNumber();
            lblUserName.Visible = false;
            txtUserName.Visible = false;
        }

        private void btnShot_Click(object sender, EventArgs e)
        {
            load++;
            debug();
            btnLoader.Enabled = false;
            mysoundPlayer.soundPlayerSystem(Resources.shot);

            if (myNum != load)
            {// You are under the random number
                isGameOver = false;

            }
            else if (myNum == load)
            {
                //you equal the random number
                mysoundPlayer.soundPlayerSystem(Resources.load);
                isGameOver = true;
                MessageBox.Show("You Dead " + txtUserName.Text + " ! Try again");
                BackgroundImage = Resources.gameOver;
                btnPlayAgain.Visible = true;

            }
        }

        private void btnAway_Click(object sender, EventArgs e)
        {
            away++;
            load++;
            debug();

            isPassing = true;
            mysoundPlayer.soundPlayerSystem(Resources.Away1);

            if (myNum == load)
            {
                mysoundPlayer.soundPlayerSystem(Resources.victory);
                MessageBox.Show("You Live " + txtUserName.Text + "!");
                BackgroundImage = Resources.gameStart;
                btnPlayAgain.Visible = true;

            }

            else if (away >= 2)
            {
                //allow to pass only 2 times
                MessageBox.Show("You lost both 2 Chances to Live!");
                btnAway.Enabled = false;
                isPassing = false;

            }
        }

        private void btnRuleToPlay_Click(object sender, EventArgs e)
        {
            mysoundPlayer.soundPlayerSystem(Resources.rule);
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //Replay
            btnPlayAgain.Visible = false;
            BackgroundImage = null;
            load = 0;
            away = 0;
            isGameOver = false;
            btnAway.Enabled = true;
            lblUserName.Visible = true;
            txtUserName.Visible = true;
            txtUserName.Text = null;
            mysoundPlayer.soundPlayerSystem(Resources.gameSound);
            btnLoader.Enabled = true;
        }
    }
}
