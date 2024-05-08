namespace CRAM2
{
    partial class MiniGame
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
            RescueInfo = new GroupBox();
            Location = new TextBox();
            LocationLabel = new Label();
            Affectation = new TextBox();
            AffectationLabel = new Label();
            SuperFamily = new TextBox();
            SuperFamilyLabel = new Label();
            RescueDate = new TextBox();
            RescueDateLabel = new Label();
            RescueNum = new TextBox();
            RescueNumLabel = new Label();
            AnimalTitle = new GroupBox();
            WeightInput = new TextBox();
            SpecieInput = new TextBox();
            AnimalWeightLabel = new Label();
            AnimalSpecieLabel = new Label();
            AnimalNameLabel = new Label();
            NameInput = new TextBox();
            QuestionLabel = new Label();
            Locally = new Button();
            CRAM = new Button();
            RescueInfo.SuspendLayout();
            AnimalTitle.SuspendLayout();
            SuspendLayout();
            // 
            // RescueInfo
            // 
            RescueInfo.Controls.Add(Location);
            RescueInfo.Controls.Add(LocationLabel);
            RescueInfo.Controls.Add(Affectation);
            RescueInfo.Controls.Add(AffectationLabel);
            RescueInfo.Controls.Add(SuperFamily);
            RescueInfo.Controls.Add(SuperFamilyLabel);
            RescueInfo.Controls.Add(RescueDate);
            RescueInfo.Controls.Add(RescueDateLabel);
            RescueInfo.Controls.Add(RescueNum);
            RescueInfo.Controls.Add(RescueNumLabel);
            RescueInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RescueInfo.ForeColor = SystemColors.Control;
            RescueInfo.Location = new Point(14, 12);
            RescueInfo.Name = "RescueInfo";
            RescueInfo.Size = new Size(346, 226);
            RescueInfo.TabIndex = 1;
            RescueInfo.TabStop = false;
            RescueInfo.Text = "Rescat";
            // 
            // Location
            // 
            Location.Enabled = false;
            Location.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Location.Location = new Point(178, 176);
            Location.Name = "Location";
            Location.ReadOnly = true;
            Location.Size = new Size(155, 29);
            Location.TabIndex = 5;
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LocationLabel.Location = new Point(19, 179);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(105, 21);
            LocationLabel.TabIndex = 8;
            LocationLabel.Text = "Localització:";
            // 
            // Affectation
            // 
            Affectation.Enabled = false;
            Affectation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Affectation.Location = new Point(178, 141);
            Affectation.Name = "Affectation";
            Affectation.ReadOnly = true;
            Affectation.Size = new Size(155, 29);
            Affectation.TabIndex = 4;
            // 
            // AffectationLabel
            // 
            AffectationLabel.AutoSize = true;
            AffectationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AffectationLabel.Location = new Point(19, 144);
            AffectationLabel.Name = "AffectationLabel";
            AffectationLabel.Size = new Size(139, 21);
            AffectationLabel.TabIndex = 6;
            AffectationLabel.Text = "Grau d'afectació:";
            // 
            // SuperFamily
            // 
            SuperFamily.Enabled = false;
            SuperFamily.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SuperFamily.Location = new Point(178, 106);
            SuperFamily.Name = "SuperFamily";
            SuperFamily.ReadOnly = true;
            SuperFamily.Size = new Size(155, 29);
            SuperFamily.TabIndex = 3;
            // 
            // SuperFamilyLabel
            // 
            SuperFamilyLabel.AutoSize = true;
            SuperFamilyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SuperFamilyLabel.Location = new Point(19, 109);
            SuperFamilyLabel.Name = "SuperFamilyLabel";
            SuperFamilyLabel.Size = new Size(149, 21);
            SuperFamilyLabel.TabIndex = 4;
            SuperFamilyLabel.Text = "Espècie a rescatar:";
            // 
            // RescueDate
            // 
            RescueDate.Enabled = false;
            RescueDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RescueDate.Location = new Point(178, 71);
            RescueDate.Name = "RescueDate";
            RescueDate.ReadOnly = true;
            RescueDate.Size = new Size(155, 29);
            RescueDate.TabIndex = 2;
            // 
            // RescueDateLabel
            // 
            RescueDateLabel.AutoSize = true;
            RescueDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RescueDateLabel.Location = new Point(19, 74);
            RescueDateLabel.Name = "RescueDateLabel";
            RescueDateLabel.Size = new Size(131, 21);
            RescueDateLabel.TabIndex = 2;
            RescueDateLabel.Text = "Data del Rescat:";
            // 
            // RescueNum
            // 
            RescueNum.Enabled = false;
            RescueNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RescueNum.Location = new Point(178, 36);
            RescueNum.Name = "RescueNum";
            RescueNum.ReadOnly = true;
            RescueNum.Size = new Size(155, 29);
            RescueNum.TabIndex = 1;
            // 
            // RescueNumLabel
            // 
            RescueNumLabel.AutoSize = true;
            RescueNumLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RescueNumLabel.Location = new Point(19, 39);
            RescueNumLabel.Name = "RescueNumLabel";
            RescueNumLabel.Size = new Size(153, 21);
            RescueNumLabel.TabIndex = 0;
            RescueNumLabel.Text = "Número de Rescat:";
            // 
            // AnimalTitle
            // 
            AnimalTitle.Controls.Add(WeightInput);
            AnimalTitle.Controls.Add(SpecieInput);
            AnimalTitle.Controls.Add(AnimalWeightLabel);
            AnimalTitle.Controls.Add(AnimalSpecieLabel);
            AnimalTitle.Controls.Add(AnimalNameLabel);
            AnimalTitle.Controls.Add(NameInput);
            AnimalTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnimalTitle.ForeColor = SystemColors.Control;
            AnimalTitle.Location = new Point(368, 50);
            AnimalTitle.Name = "AnimalTitle";
            AnimalTitle.Size = new Size(315, 147);
            AnimalTitle.TabIndex = 2;
            AnimalTitle.TabStop = false;
            AnimalTitle.Text = "Animal";
            // 
            // WeightInput
            // 
            WeightInput.Enabled = false;
            WeightInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WeightInput.Location = new Point(148, 106);
            WeightInput.Name = "WeightInput";
            WeightInput.ReadOnly = true;
            WeightInput.Size = new Size(154, 29);
            WeightInput.TabIndex = 16;
            // 
            // SpecieInput
            // 
            SpecieInput.Enabled = false;
            SpecieInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SpecieInput.Location = new Point(148, 71);
            SpecieInput.Name = "SpecieInput";
            SpecieInput.ReadOnly = true;
            SpecieInput.Size = new Size(154, 29);
            SpecieInput.TabIndex = 15;
            // 
            // AnimalWeightLabel
            // 
            AnimalWeightLabel.AutoSize = true;
            AnimalWeightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnimalWeightLabel.Location = new Point(19, 109);
            AnimalWeightLabel.Name = "AnimalWeightLabel";
            AnimalWeightLabel.Size = new Size(123, 21);
            AnimalWeightLabel.TabIndex = 13;
            AnimalWeightLabel.Text = "Pes aproximat:";
            // 
            // AnimalSpecieLabel
            // 
            AnimalSpecieLabel.AutoSize = true;
            AnimalSpecieLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnimalSpecieLabel.Location = new Point(19, 74);
            AnimalSpecieLabel.Name = "AnimalSpecieLabel";
            AnimalSpecieLabel.Size = new Size(71, 21);
            AnimalSpecieLabel.TabIndex = 12;
            AnimalSpecieLabel.Text = "Espècie:";
            // 
            // AnimalNameLabel
            // 
            AnimalNameLabel.AutoSize = true;
            AnimalNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnimalNameLabel.Location = new Point(19, 39);
            AnimalNameLabel.Name = "AnimalNameLabel";
            AnimalNameLabel.Size = new Size(52, 21);
            AnimalNameLabel.TabIndex = 10;
            AnimalNameLabel.Text = "Nom:";
            // 
            // NameInput
            // 
            NameInput.Enabled = false;
            NameInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameInput.Location = new Point(148, 36);
            NameInput.Name = "NameInput";
            NameInput.ReadOnly = true;
            NameInput.Size = new Size(154, 29);
            NameInput.TabIndex = 6;
            // 
            // QuestionLabel
            // 
            QuestionLabel.AutoSize = true;
            QuestionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuestionLabel.Location = new Point(269, 252);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(135, 21);
            QuestionLabel.TabIndex = 3;
            QuestionLabel.Text = "On el vols tractar?";
            // 
            // Locally
            // 
            Locally.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Locally.Location = new Point(184, 290);
            Locally.Name = "Locally";
            Locally.Size = new Size(131, 31);
            Locally.TabIndex = 27;
            Locally.Text = "On l'hem trobat";
            Locally.UseVisualStyleBackColor = true;
            Locally.Click += Locally_Click;
            // 
            // CRAM
            // 
            CRAM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CRAM.Location = new Point(370, 290);
            CRAM.Name = "CRAM";
            CRAM.Size = new Size(99, 31);
            CRAM.TabIndex = 28;
            CRAM.Text = "Al CRAM";
            CRAM.UseVisualStyleBackColor = true;
            CRAM.Click += CRAM_Click;
            // 
            // MiniGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(692, 349);
            Controls.Add(CRAM);
            Controls.Add(Locally);
            Controls.Add(QuestionLabel);
            Controls.Add(AnimalTitle);
            Controls.Add(RescueInfo);
            Name = "MiniGame";
            Text = "MiniGame";
            RescueInfo.ResumeLayout(false);
            RescueInfo.PerformLayout();
            AnimalTitle.ResumeLayout(false);
            AnimalTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox RescueInfo;
        private TextBox Location;
        private Label LocationLabel;
        private TextBox Affectation;
        private Label AffectationLabel;
        private TextBox SuperFamily;
        private Label SuperFamilyLabel;
        private TextBox RescueDate;
        private Label RescueDateLabel;
        private TextBox RescueNum;
        private Label RescueNumLabel;
        private GroupBox AnimalTitle;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox NameInput;
        private Label AnimalNameLabel;
        private Label AnimalSpecieLabel;
        private Label AnimalWeightLabel;
        private Label QuestionLabel;
        private Button Locally;
        private Button CRAM;
        private TextBox WeightInput;
        private TextBox SpecieInput;
    }
}