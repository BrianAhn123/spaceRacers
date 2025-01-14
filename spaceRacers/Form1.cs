using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spaceRacers
{
    public partial class spaceRacer : Form
    {
        //players
        Rectangle rocket1 = new Rectangle(200, 400, 20, 20);
        Rectangle rocket2 = new Rectangle(400, 400, 20, 20);

        int rocketSpeed = 6;


        //lists
        List<Rectangle> asteroids = new List<Rectangle>();
        List<Rectangle> asteroids2 = new List<Rectangle>();

        int asteroidsSpeed = 6;

        //inputs
        bool upPressed = false;
        bool downPressed = false;
        bool wPressed = false;
        bool sPressed = false;
        bool spacePressed = false;



        SolidBrush orangeBrush = new SolidBrush(Color.OrangeRed);
        SolidBrush whiteBrush = new SolidBrush(Color.White);

        int player1Score = 0;
        int player2Score = 0;


        Random randGen = new Random();

        public spaceRacer()
        {
            InitializeComponent();
        }

        private void spaceRacer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.Up:
                    upPressed = true;
                    break;
                case Keys.Down:
                    downPressed = true;
                    break;
                case Keys.Space:
                    spacePressed = true;
                    break;
            }

        }

        private void spaceRacer_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.Up:
                    upPressed = false;
                    break;
                case Keys.Down:
                    downPressed = false;
                    break;
                case Keys.Space:
                    spacePressed = false;
                    break;
            }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //player 2 movement
            if (upPressed && rocket2.Y > 0)
            {
                rocket2.Y -= rocketSpeed;
            }

            if (downPressed && rocket2.Y < this.Height - rocket2.Height)
            {
                rocket2.Y += rocketSpeed;
            }

            //player 1 movement          
            if (wPressed && rocket1.Y > 0)
            {
                rocket1.Y -= rocketSpeed;
            }

            if (sPressed && rocket1.Y < this.Height - rocket1.Height)
            {
                rocket1.Y += rocketSpeed;
            }

            //create asteroids 
            int randValue = randGen.Next(1, 101);

            if (randValue < 20)
            {
                int y = randGen.Next(30, this.Height - 60);
                Rectangle newAsteroids = new Rectangle(0, y, 10, 2);
                asteroids.Add(newAsteroids);

            }

            if (randValue < 20)
            {
                int y = randGen.Next(30, this.Height - 60);
                Rectangle newAsteroids2 = new Rectangle(600, y, 10, 2);
                asteroids2.Add(newAsteroids2);

            }

            //move asteroids 
            for (int i = 0; i < asteroids.Count; i++)
            {
                int x = asteroids[i].X + asteroidsSpeed;
                asteroids[i] = new Rectangle(x, asteroids[i].Y, 10, 2);
            }

            for (int i = 0; i < asteroids2.Count; i++)
            {
                int x = asteroids2[i].X - asteroidsSpeed;
                asteroids2[i] = new Rectangle(x, asteroids2[i].Y, 10, 2);
            }

            //check if rocket1 hits asteroids
            for (int i = 0; i < asteroids.Count; i++)
            {
                if (rocket1.IntersectsWith(asteroids[i]))
                {
                    rocket1.Y = 400;
                    asteroids.RemoveAt(i);
                }
            }

            for (int i = 0; i < asteroids2.Count; i++)
            {
                if (rocket1.IntersectsWith(asteroids2[i]))
                {
                    rocket1.Y = 400;
                    asteroids2.RemoveAt(i);
                }
            }

            //check if rocket2 hits asteroids 
            for (int i = 0; i < asteroids.Count; i++)
            {
                if (rocket2.IntersectsWith(asteroids[i]))
                {
                    rocket2.Y = 400;
                    asteroids.RemoveAt(i);
                }
            }

            for (int i = 0; i < asteroids2.Count; i++)
            {
                if (rocket2.IntersectsWith(asteroids2[i]))
                {
                    rocket2.Y = 400;
                    asteroids2.RemoveAt(i);
                }
            }


            //remove if asteroids hit the end of the border 
            for (int i = 0; i < asteroids.Count; i++)
            {
                if (asteroids[i].X >= this.Width)
                {
                    asteroids.RemoveAt(i);
                }
            }

            for (int i = 0; i < asteroids2.Count; i++)
            {
                if (asteroids2[i].X >= this.Width)
                {
                    asteroids2.RemoveAt(i);
                }
            }

            //check if rocket hits the top 
            if (rocket1.Y < 0)
            {
                rocket1.Y = 400;
                player1Score++;
                player1Label.Text = $"{player1Score}";
            }

            if (rocket2.Y < 0)
            {
                rocket2.Y = 400;
                player2Score++;
                player2Label.Text = $"{player2Score}";
            }

            //win condition
            if (player1Score == 3)
            {
                winLabel.Text = "PLAYER 1 WINS";
                gameTimer.Stop();
            }

            if (player2Score == 3)
            {
                winLabel.Text = "PLAYER 2 WINS";
                gameTimer.Stop();
            }

            Refresh();
        }
        //Paint everything
        private void spaceRacer_Paint(object sender, PaintEventArgs e)
        {
                e.Graphics.FillRectangle(Brushes.White, rocket1);

                e.Graphics.FillRectangle(Brushes.White, rocket2);

                for (int i = 0; i < asteroids.Count; i++)
                {
                    e.Graphics.FillEllipse(whiteBrush, asteroids[i]);
                }

                for (int i = 0; i < asteroids2.Count; i++)
                {
                    e.Graphics.FillEllipse(whiteBrush, asteroids2[i]);
                }
            }
        }
    }

    



   
   









