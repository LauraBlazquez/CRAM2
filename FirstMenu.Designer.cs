namespace CRAM2
{
    partial class FirstMenu
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
            Title = new Label();
            Play = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(23, 19);
            Title.Name = "Title";
            Title.Size = new Size(356, 54);
            Title.TabIndex = 0;
            Title.Text = "Save The Ocean II";
            // 
            // Play
            // 
            Play.Font = new Font("Segoe UI", 16F);
            Play.Location = new Point(146, 91);
            Play.Name = "Play";
            Play.Size = new Size(104, 46);
            Play.TabIndex = 1;
            Play.Text = "Jugar";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // Exit
            // 
            Exit.Font = new Font("Segoe UI", 16F);
            Exit.Location = new Point(146, 153);
            Exit.Name = "Exit";
            Exit.Size = new Size(104, 46);
            Exit.TabIndex = 2;
            Exit.Text = "Sortir";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // FirstMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(405, 256);
            Controls.Add(Exit);
            Controls.Add(Play);
            Controls.Add(Title);
            Name = "FirstMenu";
            Text = "Save The Ocean II";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button Play;
        private Button Exit;
    }
}
