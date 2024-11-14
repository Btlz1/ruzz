namespace missPACMAN
{
    public partial class Game : Form
    {
        bool goUp, goDown, goLeft, goRight, isGameOver;
        int score, playerSpeed, redGhostSpeed, yellowGhostSpeed, pinkGhostX, pinkGhostY;
        public Game()
        {
            InitializeComponent();

            ResetGame();


        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                ResetGame();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                ResetGame();
            }
        }

        private void MainGameTimer(object sender, EventArgs e)
        {
            // Обработка движения красного призрака
            RedGhost.Left += redGhostSpeed;
            if (RedGhost.Bounds.IntersectsWith(wall1.Bounds) || RedGhost.Bounds.IntersectsWith(wall2.Bounds))
            {
                redGhostSpeed = -redGhostSpeed;
            }

            // Обработка движения желтого призрака
            YellowGhost.Left += yellowGhostSpeed;
            if (YellowGhost.Bounds.IntersectsWith(wall3.Bounds) || YellowGhost.Bounds.IntersectsWith(wall4.Bounds))
            {
                yellowGhostSpeed = -yellowGhostSpeed;
            }

            // Обработка движения розового призрака
            PinkGhost.Left -= pinkGhostX;
            PinkGhost.Top -= pinkGhostY;

            // Проверка границ для розового призрака
            if (PinkGhost.Top < 0 || PinkGhost.Top > 570)
            {
                pinkGhostY = -pinkGhostY;
            }
            if (PinkGhost.Left < 0 || PinkGhost.Left > 625)
            {
                pinkGhostX = -pinkGhostX;
            }

            // Проверка условия победы
            if (score >= 34) // Изменено на >= для большей гибкости
            {
                GameOver("You Win!");
            }



            txtScore.Text = "Score: " + score;

            if (goLeft == true)
            {
                Pacman.Left -= playerSpeed;
                Pacman.Image = Properties.Resources.left;
            }
            if (goRight == true)
            {
                Pacman.Left += playerSpeed;
                Pacman.Image = Properties.Resources.right;
            }
            if (goUp == true)
            {
                Pacman.Top -= playerSpeed;
                Pacman.Image = Properties.Resources.up;
            }
            if (goDown == true)
            {
                Pacman.Top += playerSpeed;
                Pacman.Image = Properties.Resources.down;
            }

            if (Pacman.Left < -5)
            {
                Pacman.Left = 625;
            }
            if (Pacman.Left > 630)
            {
                Pacman.Left = -5;
            }
            if (Pacman.Top < -5)
            {
                Pacman.Top = 570;
            }
            if (Pacman.Top > 575)
            {
                Pacman.Top = -5;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox pictureBox)
                {
                    // Проверка на монеты
                    if ((string)pictureBox.Tag == "coin" && pictureBox.Visible)
                    {
                        if (Pacman.Bounds.IntersectsWith(pictureBox.Bounds))
                        {
                            score++;
                            pictureBox.Visible = false;
                        }
                    }
                    // Проверка на призраков
                    else if ((string)pictureBox.Tag == "ghost")
                    {
                        if (Pacman.Bounds.IntersectsWith(pictureBox.Bounds))
                        {
                            GameOver("You Lose!");
                        }
                    }
                    // Проверка на стены
                    else if ((string)pictureBox.Tag == "wall")
                    {
                        if (Pacman.Bounds.IntersectsWith(pictureBox.Bounds))
                        {
                            GameOver("You Lose!");
                        }
                        if (PinkGhost.Bounds.IntersectsWith(pictureBox.Bounds))
                        {
                            pinkGhostX = -pinkGhostX;
                        }
                    }
                }
            }

        }
        private void ResetGame()
        {
            txtScore.Text = "Score: 0";
            score = 0;

            redGhostSpeed = 5;
            yellowGhostSpeed = 5;
            pinkGhostX = 5;
            pinkGhostY = 5;
            playerSpeed = 8;

            isGameOver = false;

            Pacman.Left = 17;
            Pacman.Top = 36;

            RedGhost.Left = 188;
            RedGhost.Top = 40;

            YellowGhost.Left = 439;
            YellowGhost.Top = 437;

            PinkGhost.Left = 495;
            PinkGhost.Top = 221;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Visible = true;
                }
            }

            GameTimer.Start();


        }
        private void GameOver(string message)
        {
            isGameOver = true;
            GameTimer.Stop();

            txtScore.Text += Environment.NewLine + message;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
