using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 가위바위보_게임
{
    public partial class frmMain : Form
    {
        private Random rnd;

        private int iScore = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnK_Click(object sender, EventArgs e)
        {
            rnd = new Random();

            int random = rnd.Next(3, 10);

            lblHand.Text = "가위";

            if (random == 1)
            {
                lblAiHand.Text = "가위";

                if (lblAiHand.Text == lblHand.Text)
                {
                    iScore -= 1;
                    score.Text = iScore.ToString();
                }
                else
                {
                    iScore += 1;
                    score.Text = iScore.ToString();
                }
            }
            if (random == 2)
            {
                lblAiHand.Text = "바위";

                if (lblAiHand.Text == lblHand.Text)
                {
                    iScore -= 1;
                    score.Text = iScore.ToString();
                }
                else
                {
                    iScore += 1;
                    score.Text = iScore.ToString();
                }
            }
            if (random == 3)
            {
                lblAiHand.Text = "보";

                if (lblAiHand.Text == lblHand.Text)
                {
                    iScore -= 1;
                    score.Text = iScore.ToString();
                }
                else
                {
                    iScore += 1;
                    score.Text = iScore.ToString();
                }
            }




        }

        private void btnBO_Click(object sender, EventArgs e)
        {
            rnd = new Random();

            int random = rnd.Next(3, 10);

            lblHand.Text = "바위";

            if (random == 1)
            {
                lblAiHand.Text = "가위";

                if (lblAiHand.Text == lblHand.Text)
                {
                    iScore -= 1;
                    score.Text = iScore.ToString();
                }
                else
                {
                    iScore += 1;
                    score.Text = iScore.ToString();
                }
            }
            if (random == 2)
            {
                lblAiHand.Text = "바위";

                if (lblAiHand.Text == lblHand.Text)
                {
                    iScore -= 1;
                    score.Text = iScore.ToString();
                }
                else
                {
                    iScore += 1;
                    score.Text = iScore.ToString();
                }
            }
            if (random == 3)
            {
                lblAiHand.Text = "보";

                if (lblAiHand.Text == lblHand.Text)
                {
                    iScore -= 1;
                    score.Text = iScore.ToString();
                }
                else
                {
                    iScore += 1;
                    score.Text = iScore.ToString();
                }
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            rnd = new Random();

            int random = rnd.Next(3, 10);

            lblHand.Text = "보";
            if (random == 1)
            {
                lblAiHand.Text = "가위";

                if (lblAiHand.Text == lblHand.Text)
                {
                    iScore -= 1;
                    score.Text = iScore.ToString();
                }
                else
                {
                    iScore += 1;
                    score.Text = iScore.ToString();
                }
            }
            if (random == 2)
            {
                lblAiHand.Text = "바위";

                if (lblAiHand.Text == lblHand.Text)
                {
                    iScore -= 1;
                    score.Text = iScore.ToString();
                }
                else
                {
                    iScore += 1;
                    score.Text = iScore.ToString();
                }
            }
            if (random == 3)
            {
                lblAiHand.Text = "보";

                if (lblAiHand.Text == lblHand.Text)
                {
                    iScore -= 1;
                    score.Text = iScore.ToString();
                }
                else
                {
                    iScore += 1;
                    score.Text = iScore.ToString();
                }
            }
        }
    }
}
