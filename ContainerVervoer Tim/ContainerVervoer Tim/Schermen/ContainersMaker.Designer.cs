namespace ContainerVervoer_Tim.Schermen
{
    partial class ContainersMaker
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
            lblDetails = new Label();
            lbContainers = new ListBox();
            label2 = new Label();
            label3 = new Label();
            tbGewicht = new TextBox();
            cbType = new ComboBox();
            label4 = new Label();
            btnToevoegen = new Button();
            lblGewicht = new Label();
            btnRandom = new Button();
            btnSorteer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Schip Details:";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(12, 24);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(34, 15);
            lblDetails.TabIndex = 1;
            lblDetails.Text = "A x B";
            // 
            // lbContainers
            // 
            lbContainers.FormattingEnabled = true;
            lbContainers.ItemHeight = 15;
            lbContainers.Location = new Point(155, 93);
            lbContainers.Name = "lbContainers";
            lbContainers.Size = new Size(465, 289);
            lbContainers.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(662, 9);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 3;
            label2.Text = "Voeg Container Toe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(662, 27);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Gewicht";
            // 
            // tbGewicht
            // 
            tbGewicht.Location = new Point(718, 24);
            tbGewicht.Name = "tbGewicht";
            tbGewicht.Size = new Size(64, 23);
            tbGewicht.TabIndex = 5;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(718, 53);
            cbType.Name = "cbType";
            cbType.Size = new Size(64, 23);
            cbType.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(662, 56);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 7;
            label4.Text = "Type";
            // 
            // btnToevoegen
            // 
            btnToevoegen.Location = new Point(687, 82);
            btnToevoegen.Name = "btnToevoegen";
            btnToevoegen.Size = new Size(75, 23);
            btnToevoegen.TabIndex = 8;
            btnToevoegen.Text = "Voeg toe";
            btnToevoegen.UseVisualStyleBackColor = true;
            btnToevoegen.Click += btnToevoegen_Click;
            // 
            // lblGewicht
            // 
            lblGewicht.AutoSize = true;
            lblGewicht.Location = new Point(12, 39);
            lblGewicht.Name = "lblGewicht";
            lblGewicht.Size = new Size(37, 15);
            lblGewicht.TabIndex = 9;
            lblGewicht.Text = "C Ton";
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(662, 111);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(120, 23);
            btnRandom.TabIndex = 10;
            btnRandom.Text = "Random Container";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // btnSorteer
            // 
            btnSorteer.Location = new Point(348, 399);
            btnSorteer.Name = "btnSorteer";
            btnSorteer.Size = new Size(75, 23);
            btnSorteer.TabIndex = 11;
            btnSorteer.Text = "Sorteer";
            btnSorteer.UseVisualStyleBackColor = true;
            btnSorteer.Click += btnSorteer_Click;
            // 
            // ContainersMaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSorteer);
            Controls.Add(btnRandom);
            Controls.Add(lblGewicht);
            Controls.Add(btnToevoegen);
            Controls.Add(label4);
            Controls.Add(cbType);
            Controls.Add(tbGewicht);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbContainers);
            Controls.Add(lblDetails);
            Controls.Add(label1);
            Name = "ContainersMaker";
            Text = "ContainersMaker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblDetails;
        private ListBox lbContainers;
        private Label label2;
        private Label label3;
        private TextBox tbGewicht;
        private ComboBox cbType;
        private Label label4;
        private Button btnToevoegen;
        private Label lblGewicht;
        private Button btnRandom;
        private Button btnSorteer;
    }
}