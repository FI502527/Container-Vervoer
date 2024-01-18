namespace ContainerVervoer_Tim.Schermen
{
    partial class BeginScherm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbBreedte = new TextBox();
            tbLengte = new TextBox();
            tbMax = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 94);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Schip Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 131);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Breedte";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 158);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Lengte";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 184);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 3;
            label4.Text = "Max Gewicht";
            // 
            // tbBreedte
            // 
            tbBreedte.Location = new Point(410, 131);
            tbBreedte.Name = "tbBreedte";
            tbBreedte.Size = new Size(100, 23);
            tbBreedte.TabIndex = 4;
            // 
            // tbLengte
            // 
            tbLengte.Location = new Point(410, 158);
            tbLengte.Name = "tbLengte";
            tbLengte.Size = new Size(100, 23);
            tbLengte.TabIndex = 5;
            // 
            // tbMax
            // 
            tbMax.Location = new Point(410, 184);
            tbMax.Name = "tbMax";
            tbMax.Size = new Size(100, 23);
            tbMax.TabIndex = 6;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(368, 222);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Maak";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // BeginScherm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(tbMax);
            Controls.Add(tbLengte);
            Controls.Add(tbBreedte);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BeginScherm";
            Text = "BeginScherm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbBreedte;
        private TextBox tbLengte;
        private TextBox tbMax;
        private Button btnCreate;
    }
}