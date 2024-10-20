namespace x_and_os
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            clrButton = new Button();
            saveButton = new Button();
            threeFourbtn = new Button();
            label1 = new Label();
            penColorBlackbtn = new Button();
            penColorBluebtn = new Button();
            penColorGreenbtn = new Button();
            penColorPurplebtn = new Button();
            penColorOrangebtn = new Button();
            penColorRedbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(11, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1400, 858);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
            // 
            // clrButton
            // 
            clrButton.Location = new Point(956, 884);
            clrButton.Name = "clrButton";
            clrButton.Size = new Size(202, 67);
            clrButton.TabIndex = 1;
            clrButton.Text = "Clear";
            clrButton.UseVisualStyleBackColor = true;
            clrButton.Click += btnClear_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(1202, 884);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(202, 67);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += btnSave_Click;
            // 
            // threeFourbtn
            // 
            threeFourbtn.Location = new Point(21, 884);
            threeFourbtn.Name = "threeFourbtn";
            threeFourbtn.Size = new Size(189, 52);
            threeFourbtn.TabIndex = 3;
            threeFourbtn.Text = "Add 3-4 D";
            threeFourbtn.UseVisualStyleBackColor = true;
            threeFourbtn.Click += threeFourdbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1620, 23);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 4;
            label1.Text = "Pen Color:";
            // 
            // penColorBlackbtn
            // 
            penColorBlackbtn.Location = new Point(1551, 60);
            penColorBlackbtn.Name = "penColorBlackbtn";
            penColorBlackbtn.Size = new Size(112, 34);
            penColorBlackbtn.TabIndex = 5;
            penColorBlackbtn.Text = "Black";
            penColorBlackbtn.UseVisualStyleBackColor = true;
            penColorBlackbtn.Click += penColorBlackbtn_Click;
            // 
            // penColorBluebtn
            // 
            penColorBluebtn.Location = new Point(1669, 60);
            penColorBluebtn.Name = "penColorBluebtn";
            penColorBluebtn.Size = new Size(112, 34);
            penColorBluebtn.TabIndex = 6;
            penColorBluebtn.Text = "Blue";
            penColorBluebtn.UseVisualStyleBackColor = true;
            penColorBluebtn.Click += penColorBluebtn_Click;
            // 
            // penColorGreenbtn
            // 
            penColorGreenbtn.Location = new Point(1551, 100);
            penColorGreenbtn.Name = "penColorGreenbtn";
            penColorGreenbtn.Size = new Size(112, 34);
            penColorGreenbtn.TabIndex = 7;
            penColorGreenbtn.Text = "Green";
            penColorGreenbtn.UseVisualStyleBackColor = true;
            penColorGreenbtn.Click += penColorGreenbtn_Click;
            // 
            // penColorPurplebtn
            // 
            penColorPurplebtn.Location = new Point(1669, 100);
            penColorPurplebtn.Name = "penColorPurplebtn";
            penColorPurplebtn.Size = new Size(112, 34);
            penColorPurplebtn.TabIndex = 8;
            penColorPurplebtn.Text = "Purple";
            penColorPurplebtn.UseVisualStyleBackColor = true;
            penColorPurplebtn.Click += penColorPurplebtn_Click;
            // 
            // penColorOrangebtn
            // 
            penColorOrangebtn.Location = new Point(1551, 140);
            penColorOrangebtn.Name = "penColorOrangebtn";
            penColorOrangebtn.Size = new Size(112, 34);
            penColorOrangebtn.TabIndex = 9;
            penColorOrangebtn.Text = "Orange";
            penColorOrangebtn.UseVisualStyleBackColor = true;
            penColorOrangebtn.Click += penColorYellowbtn_Click;
            // 
            // penColorRedbtn
            // 
            penColorRedbtn.Location = new Point(1669, 140);
            penColorRedbtn.Name = "penColorRedbtn";
            penColorRedbtn.Size = new Size(112, 34);
            penColorRedbtn.TabIndex = 10;
            penColorRedbtn.Text = "Red";
            penColorRedbtn.UseVisualStyleBackColor = true;
            penColorRedbtn.Click += penColorRedbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1796, 964);
            Controls.Add(penColorRedbtn);
            Controls.Add(penColorOrangebtn);
            Controls.Add(penColorPurplebtn);
            Controls.Add(penColorGreenbtn);
            Controls.Add(penColorBluebtn);
            Controls.Add(penColorBlackbtn);
            Controls.Add(label1);
            Controls.Add(threeFourbtn);
            Controls.Add(saveButton);
            Controls.Add(clrButton);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button clrButton;
        private Button saveButton;
        private Button threeFourbtn;
        private Label label1;
        private Button penColorBlackbtn;
        private Button penColorBluebtn;
        private Button penColorGreenbtn;
        private Button penColorPurplebtn;
        private Button penColorOrangebtn;
        private Button penColorRedbtn;
    }
}
