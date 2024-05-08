namespace CRAM2
{
    partial class AnimalsAdmin
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
            AdminTitle = new Label();
            AnimalInfo = new GroupBox();
            IdInput = new TextBox();
            IdLabel = new Label();
            SuperFamilyComboBox = new ComboBox();
            AnimalWeight = new TextBox();
            AnimalWeightLabel = new Label();
            AnimalSpecie = new TextBox();
            AnimalSpecieLabel = new Label();
            AnimalFamilyLabel = new Label();
            AnimalName = new TextBox();
            AnimalNameLabel = new Label();
            dataGridView1 = new DataGridView();
            Delete = new Button();
            Insert = new Button();
            Return = new Button();
            AnimalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AdminTitle
            // 
            AdminTitle.AutoSize = true;
            AdminTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminTitle.Location = new Point(50, 19);
            AdminTitle.Name = "AdminTitle";
            AdminTitle.Size = new Size(0, 30);
            AdminTitle.TabIndex = 14;
            // 
            // AnimalInfo
            // 
            AnimalInfo.Controls.Add(IdInput);
            AnimalInfo.Controls.Add(IdLabel);
            AnimalInfo.Controls.Add(SuperFamilyComboBox);
            AnimalInfo.Controls.Add(AnimalWeight);
            AnimalInfo.Controls.Add(AnimalWeightLabel);
            AnimalInfo.Controls.Add(AnimalSpecie);
            AnimalInfo.Controls.Add(AnimalSpecieLabel);
            AnimalInfo.Controls.Add(AnimalFamilyLabel);
            AnimalInfo.Controls.Add(AnimalName);
            AnimalInfo.Controls.Add(AnimalNameLabel);
            AnimalInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnimalInfo.ForeColor = SystemColors.Control;
            AnimalInfo.Location = new Point(12, 12);
            AnimalInfo.Name = "AnimalInfo";
            AnimalInfo.Size = new Size(609, 158);
            AnimalInfo.TabIndex = 15;
            AnimalInfo.TabStop = false;
            AnimalInfo.Text = "Dades de l'animal";
            // 
            // IdInput
            // 
            IdInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IdInput.Location = new Point(178, 32);
            IdInput.Name = "IdInput";
            IdInput.ReadOnly = true;
            IdInput.Size = new Size(100, 29);
            IdInput.TabIndex = 8;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IdLabel.Location = new Point(19, 35);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(29, 21);
            IdLabel.TabIndex = 7;
            IdLabel.Text = "Id:";
            // 
            // SuperFamilyComboBox
            // 
            SuperFamilyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SuperFamilyComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SuperFamilyComboBox.FormattingEnabled = true;
            SuperFamilyComboBox.Items.AddRange(new object[] { "Tortuga Marina", "Au Marina", "Cetaci" });
            SuperFamilyComboBox.Location = new Point(178, 105);
            SuperFamilyComboBox.Name = "SuperFamilyComboBox";
            SuperFamilyComboBox.Size = new Size(100, 29);
            SuperFamilyComboBox.TabIndex = 2;
            // 
            // AnimalWeight
            // 
            AnimalWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnimalWeight.Location = new Point(483, 105);
            AnimalWeight.Name = "AnimalWeight";
            AnimalWeight.Size = new Size(100, 29);
            AnimalWeight.TabIndex = 4;
            // 
            // AnimalWeightLabel
            // 
            AnimalWeightLabel.AutoSize = true;
            AnimalWeightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnimalWeightLabel.Location = new Point(324, 108);
            AnimalWeightLabel.Name = "AnimalWeightLabel";
            AnimalWeightLabel.Size = new Size(123, 21);
            AnimalWeightLabel.TabIndex = 6;
            AnimalWeightLabel.Text = "Pes aproximat:";
            // 
            // AnimalSpecie
            // 
            AnimalSpecie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnimalSpecie.Location = new Point(483, 70);
            AnimalSpecie.Name = "AnimalSpecie";
            AnimalSpecie.Size = new Size(100, 29);
            AnimalSpecie.TabIndex = 3;
            // 
            // AnimalSpecieLabel
            // 
            AnimalSpecieLabel.AutoSize = true;
            AnimalSpecieLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnimalSpecieLabel.Location = new Point(324, 73);
            AnimalSpecieLabel.Name = "AnimalSpecieLabel";
            AnimalSpecieLabel.Size = new Size(71, 21);
            AnimalSpecieLabel.TabIndex = 4;
            AnimalSpecieLabel.Text = "Espècie:";
            // 
            // AnimalFamilyLabel
            // 
            AnimalFamilyLabel.AutoSize = true;
            AnimalFamilyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnimalFamilyLabel.Location = new Point(19, 105);
            AnimalFamilyLabel.Name = "AnimalFamilyLabel";
            AnimalFamilyLabel.Size = new Size(112, 21);
            AnimalFamilyLabel.TabIndex = 2;
            AnimalFamilyLabel.Text = "Superfamília:";
            // 
            // AnimalName
            // 
            AnimalName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnimalName.Location = new Point(178, 67);
            AnimalName.Name = "AnimalName";
            AnimalName.Size = new Size(100, 29);
            AnimalName.TabIndex = 1;
            // 
            // AnimalNameLabel
            // 
            AnimalNameLabel.AutoSize = true;
            AnimalNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnimalNameLabel.Location = new Point(19, 70);
            AnimalNameLabel.Name = "AnimalNameLabel";
            AnimalNameLabel.Size = new Size(52, 21);
            AnimalNameLabel.TabIndex = 0;
            AnimalNameLabel.Text = "Nom:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(609, 250);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Delete
            // 
            Delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Delete.Location = new Point(435, 180);
            Delete.Name = "Delete";
            Delete.Size = new Size(83, 31);
            Delete.TabIndex = 5;
            Delete.Text = "Eliminar";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Insert
            // 
            Insert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Insert.Location = new Point(534, 180);
            Insert.Name = "Insert";
            Insert.Size = new Size(83, 31);
            Insert.TabIndex = 6;
            Insert.Text = "Inserir";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // Return
            // 
            Return.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Return.Location = new Point(12, 479);
            Return.Name = "Return";
            Return.Size = new Size(83, 31);
            Return.TabIndex = 9;
            Return.Text = "Tornar";
            Return.UseVisualStyleBackColor = true;
            Return.Click += Return_Click;
            // 
            // AnimalsAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(634, 526);
            Controls.Add(Return);
            Controls.Add(Insert);
            Controls.Add(Delete);
            Controls.Add(dataGridView1);
            Controls.Add(AnimalInfo);
            Controls.Add(AdminTitle);
            Name = "AnimalsAdmin";
            Text = "AnimalsAdmin";
            AnimalInfo.ResumeLayout(false);
            AnimalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AdminTitle;
        private GroupBox AnimalInfo;
        private TextBox AnimalWeight;
        private Label AnimalWeightLabel;
        private TextBox AnimalSpecie;
        private Label AnimalSpecieLabel;
        private Label AnimalFamilyLabel;
        private TextBox AnimalName;
        private Label AnimalNameLabel;
        private DataGridView dataGridView1;
        private Button Delete;
        private Button Insert;
        private Button Return;
        private ComboBox SuperFamilyComboBox;
        private TextBox IdInput;
        private Label IdLabel;
    }
}