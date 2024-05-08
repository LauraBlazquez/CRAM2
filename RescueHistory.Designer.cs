namespace CRAM2
{
    partial class RescueHistory
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
            Return = new Button();
            dataGridView1 = new DataGridView();
            RescueHistoryTitle = new Label();
            IdInput = new TextBox();
            IdLabel = new Label();
            Search = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Return
            // 
            Return.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Return.Location = new Point(12, 447);
            Return.Name = "Return";
            Return.Size = new Size(83, 31);
            Return.TabIndex = 22;
            Return.Text = "Tornar";
            Return.UseVisualStyleBackColor = true;
            Return.Click += Return_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(609, 319);
            dataGridView1.TabIndex = 21;
            // 
            // RescueHistoryTitle
            // 
            RescueHistoryTitle.AutoSize = true;
            RescueHistoryTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RescueHistoryTitle.Location = new Point(214, 19);
            RescueHistoryTitle.Name = "RescueHistoryTitle";
            RescueHistoryTitle.Size = new Size(198, 30);
            RescueHistoryTitle.TabIndex = 23;
            RescueHistoryTitle.Text = "Historial de rescats";
            // 
            // IdInput
            // 
            IdInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IdInput.Location = new Point(48, 67);
            IdInput.Name = "IdInput";
            IdInput.Size = new Size(100, 29);
            IdInput.TabIndex = 25;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IdLabel.Location = new Point(12, 70);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(29, 21);
            IdLabel.TabIndex = 24;
            IdLabel.Text = "Id:";
            // 
            // Search
            // 
            Search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Search.Location = new Point(169, 66);
            Search.Name = "Search";
            Search.Size = new Size(83, 31);
            Search.TabIndex = 26;
            Search.Text = "Buscar";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // RescueHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(633, 495);
            Controls.Add(Search);
            Controls.Add(IdInput);
            Controls.Add(IdLabel);
            Controls.Add(RescueHistoryTitle);
            Controls.Add(Return);
            Controls.Add(dataGridView1);
            Name = "RescueHistory";
            Text = "RescueHistory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Return;
        private DataGridView dataGridView1;
        private Label RescueHistoryTitle;
        private TextBox IdInput;
        private Label IdLabel;
        private Button Search;
    }
}