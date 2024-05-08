namespace CRAM2
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AdminButton = new Button();
            MainMenuTitle = new Label();
            ViewRescues = new Button();
            NewRescue = new Button();
            SuspendLayout();
            // 
            // AdminButton
            // 
            AdminButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminButton.Location = new Point(29, 62);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(173, 31);
            AdminButton.TabIndex = 11;
            AdminButton.Text = "Administrar animals";
            AdminButton.UseVisualStyleBackColor = true;
            AdminButton.Click += AdminButton_Click;
            // 
            // MainMenuTitle
            // 
            MainMenuTitle.AutoSize = true;
            MainMenuTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainMenuTitle.Location = new Point(48, 19);
            MainMenuTitle.Name = "MainMenuTitle";
            MainMenuTitle.Size = new Size(140, 30);
            MainMenuTitle.TabIndex = 6;
            MainMenuTitle.Text = "Què vols fer?";
            // 
            // ViewRescues
            // 
            ViewRescues.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewRescues.Location = new Point(29, 104);
            ViewRescues.Name = "ViewRescues";
            ViewRescues.Size = new Size(173, 31);
            ViewRescues.TabIndex = 12;
            ViewRescues.Text = "Consultar rescats";
            ViewRescues.UseVisualStyleBackColor = true;
            ViewRescues.Click += ViewRescues_Click;
            // 
            // NewRescue
            // 
            NewRescue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewRescue.Location = new Point(29, 146);
            NewRescue.Name = "NewRescue";
            NewRescue.Size = new Size(173, 31);
            NewRescue.TabIndex = 13;
            NewRescue.Text = "Generar un  nou rescat";
            NewRescue.UseVisualStyleBackColor = true;
            NewRescue.Click += NewRescue_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(234, 202);
            Controls.Add(NewRescue);
            Controls.Add(ViewRescues);
            Controls.Add(AdminButton);
            Controls.Add(MainMenuTitle);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AdminButton;
        private Label MainMenuTitle;
        private Button ViewRescues;
        private Button NewRescue;
    }
}