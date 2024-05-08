namespace CRAM2
{
    partial class UserSelection
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
            UserIntro = new Label();
            NameLabel = new Label();
            RolLabel = new Label();
            RolComboBox = new ComboBox();
            NameInput = new TextBox();
            Continue = new Button();
            SuspendLayout();
            // 
            // UserIntro
            // 
            UserIntro.AutoSize = true;
            UserIntro.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserIntro.Location = new Point(12, 19);
            UserIntro.Name = "UserIntro";
            UserIntro.Size = new Size(222, 30);
            UserIntro.TabIndex = 0;
            UserIntro.Text = "Dades del treballador";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.Location = new Point(17, 59);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(48, 21);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Nom:";
            // 
            // RolLabel
            // 
            RolLabel.AutoSize = true;
            RolLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RolLabel.Location = new Point(17, 119);
            RolLabel.Name = "RolLabel";
            RolLabel.Size = new Size(36, 21);
            RolLabel.TabIndex = 2;
            RolLabel.Text = "Rol:";
            // 
            // RolComboBox
            // 
            RolComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RolComboBox.FormattingEnabled = true;
            RolComboBox.Items.AddRange(new object[] { "Tècnic/a", "Veterinari/a" });
            RolComboBox.Location = new Point(17, 143);
            RolComboBox.Name = "RolComboBox";
            RolComboBox.Size = new Size(121, 23);
            RolComboBox.TabIndex = 3;
            // 
            // NameInput
            // 
            NameInput.Location = new Point(17, 83);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(121, 23);
            NameInput.TabIndex = 4;
            // 
            // Continue
            // 
            Continue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Continue.Location = new Point(16, 190);
            Continue.Name = "Continue";
            Continue.Size = new Size(100, 31);
            Continue.TabIndex = 5;
            Continue.Text = "Continuar";
            Continue.UseVisualStyleBackColor = true;
            Continue.Click += Continue_Click;
            // 
            // UserSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(268, 244);
            Controls.Add(Continue);
            Controls.Add(NameInput);
            Controls.Add(RolComboBox);
            Controls.Add(RolLabel);
            Controls.Add(NameLabel);
            Controls.Add(UserIntro);
            Name = "UserSelection";
            Text = "UserSelection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserIntro;
        private Label NameLabel;
        private Label RolLabel;
        private ComboBox RolComboBox;
        private TextBox NameInput;
        private Button Continue;
    }
}