using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace x_and_os
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        private bool drawing = false;
        private Point lastPoint;
        private bool rightButtonDown = false; // Flag to track right button state
        private Pen penColor;

        public Form1()
        {
            InitializeComponent();

            // Initialize the bitmap
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White); // Start with a white background
            }
            pictureBox1.Image = bitmap;
        }
        private void DrawInitialFormation()
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Define positions for the linemen and center
                int centerX = bitmap.Width / 2;
                int linemanY = bitmap.Height / 2 + 50; // Adjust as needed for vertical placement
                int offset = 50; // Space between each player

                // Draw linemen as "O"
                for (int i = -2; i <= 2; i++) // 5 linemen
                {
                    if (i != 0)
                        DrawO(new Point(centerX + i * offset, linemanY));
                }

                // Draw center as "X"
                DrawX(new Point(centerX, linemanY - 10)); // Slightly above the linemen
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            penColor = Pens.Black;
            // Load the image from a file or URL
            using (var webClient = new System.Net.WebClient())
            {
                var imageBytes = webClient.DownloadData("https://7363726.fs1.hubspotusercontent-na1.net/hub/7363726/hubfs/Content%20Offerings/COLLEGE%2016x9%20REDZONE.png?width=1200&length=1200&name=COLLEGE%2016x9%20REDZONE.png");
                using (var ms = new System.IO.MemoryStream(imageBytes))
                {
                    var loadedImage = Image.FromStream(ms);
                    // Create a new bitmap with the loaded image dimensions
                    bitmap = new Bitmap(loadedImage.Width, loadedImage.Height);
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        // Set the opacity level (0.0 fully transparent, 1.0 fully opaque)
                        float opacity = 0.5f; // Adjust opacity level here
                        ColorMatrix colorMatrix = new ColorMatrix();
                        colorMatrix.Matrix33 = opacity; // Set alpha to the specified opacity

                        using (ImageAttributes attributes = new ImageAttributes())
                        {
                            attributes.SetColorMatrix(colorMatrix);
                            // Draw the image with the specified opacity
                            g.DrawImage(loadedImage, new Rectangle(0, 0, loadedImage.Width, loadedImage.Height),
                                         0, 0, loadedImage.Width, loadedImage.Height, GraphicsUnit.Pixel, attributes);
                        }
                    }
                }
            }

            // Draw the initial offensive formation
            DrawInitialFormation();

            pictureBox1.Image = bitmap;
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal; // Adjust size mode as needed
        }


        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Start drawing mode and set the last point
                drawing = true;
                lastPoint = e.Location; // Set last point for painting
            }
            else if (e.Button == MouseButtons.Right)
            {
                DrawO(e.Location); // Draw "O" immediately on right-click
                pictureBox1.Invalidate(); // Refresh to show the new "O"
                rightButtonDown = true; // Set flag for right button hold
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing) // If left button is held down, paint "X"
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.DrawLine(penColor, lastPoint, e.Location); // Draw "X" line while holding left mouse button
                }
                lastPoint = e.Location;
                pictureBox1.Invalidate(); // Refresh the PictureBox to show the new line
            }
            else if (rightButtonDown) // If right button is held down, draw "O"s
            {
                DrawO(e.Location);
                pictureBox1.Invalidate(); // Refresh the PictureBox to show the new "O"
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                // Check if the last point is valid for placing an "X"
                if (!drawing) // Only place an "X" if we weren't drawing
                {
                    DrawX(lastPoint); // Draw "X" at the last point
                    pictureBox1.Invalidate(); // Refresh to show the new "X"
                }
                drawing = false; // Stop drawing on mouse release

            }
            else if (e.Button == MouseButtons.Right)
            {
                rightButtonDown = false; // Reset the flag on mouse release
            }
        }




        private void DrawX(Point location)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                int size = 20; // Size of the "X"
                g.DrawLine(penColor, location.X - size, location.Y - size, location.X + size, location.Y + size);
                g.DrawLine(penColor, location.X + size, location.Y - size, location.X - size, location.Y + size);
            }
        }

        private void DrawO(Point location)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                int size = 20; // Radius of the "O"
                g.DrawEllipse(penColor, location.X - size, location.Y - size, size * 2, size * 2);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    bitmap.Save(sfd.FileName);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White); // Clear the bitmap with white color
            }
            Form1_Load(sender, e);
            pictureBox1.Invalidate(); // Refresh the PictureBox
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            bitmap.Dispose();
            base.OnFormClosing(e);
        }

        private void threeFourdbtn_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Define positions for the defense
                int centerX = bitmap.Width / 2;
                int linemanY = bitmap.Height / 2; // Adjust as needed for vertical placement
                int offset = 150; // Space between each player

                // Draw defensive linemen as "O"
                for (int i = -1; i <= 1; i++) // 3 defensive linemen
                {
                    DrawO(new Point(centerX + i * offset, linemanY));
                }
                offset = 135;
                // Draw linebackers as "O" slightly above the linemen
                for (int i = -2; i <= 1; i++) // 4 linebackers
                {
                    DrawO(new Point((centerX + i * offset) + 65, linemanY - 70)); // Adjust vertical position
                }
            }
            pictureBox1.Invalidate();

        }

        private void penColorBlackbtn_Click(object sender, EventArgs e)
        {
            penColor = Pens.Black;
        }

        private void penColorBluebtn_Click(object sender, EventArgs e)
        {
            penColor = Pens.Blue;
        }

        private void penColorGreenbtn_Click(object sender, EventArgs e)
        {
            penColor = Pens.Green;
        }

        private void penColorPurplebtn_Click(object sender, EventArgs e)
        {
            penColor = Pens.Purple;
        }

        private void penColorYellowbtn_Click(object sender, EventArgs e)
        {
            penColor = Pens.Orange;
        }

        private void penColorRedbtn_Click(object sender, EventArgs e)
        {
            penColor = Pens.Red;
        }
    }
}
