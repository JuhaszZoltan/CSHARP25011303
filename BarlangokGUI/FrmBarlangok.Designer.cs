namespace BarlangokGUI
{
    partial class FrmBarlangok
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
            lblUI01 = new Label();
            tbxHossz = new TextBox();
            btnKereses = new Button();
            lblUI02 = new Label();
            lblUI03 = new Label();
            lblUI04 = new Label();
            lblNev = new Label();
            tbxMely = new TextBox();
            tbxAzon = new TextBox();
            btnMentes = new Button();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(12, 29);
            lblUI01.Margin = new Padding(3, 20, 3, 20);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(114, 30);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Azonosító:";
            // 
            // tbxHossz
            // 
            tbxHossz.Location = new Point(162, 174);
            tbxHossz.Name = "tbxHossz";
            tbxHossz.Size = new Size(180, 36);
            tbxHossz.TabIndex = 1;
            // 
            // btnKereses
            // 
            btnKereses.Location = new Point(398, 29);
            btnKereses.Name = "btnKereses";
            btnKereses.Size = new Size(224, 49);
            btnKereses.TabIndex = 2;
            btnKereses.Text = "Barlang keresése";
            btnKereses.UseVisualStyleBackColor = true;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(12, 103);
            lblUI02.Margin = new Padding(3, 20, 3, 20);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(144, 30);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "Barlang neve:";
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(12, 177);
            lblUI03.Margin = new Padding(3, 20, 3, 20);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(120, 30);
            lblUI03.TabIndex = 0;
            lblUI03.Text = "Hosszúság:";
            // 
            // lblUI04
            // 
            lblUI04.AutoSize = true;
            lblUI04.Location = new Point(12, 251);
            lblUI04.Margin = new Padding(3, 20, 3, 20);
            lblUI04.Name = "lblUI04";
            lblUI04.Size = new Size(100, 30);
            lblUI04.TabIndex = 0;
            lblUI04.Text = "Mélység:";
            // 
            // lblNev
            // 
            lblNev.AutoSize = true;
            lblNev.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNev.Location = new Point(162, 103);
            lblNev.Margin = new Padding(3, 20, 3, 20);
            lblNev.Name = "lblNev";
            lblNev.Size = new Size(0, 30);
            lblNev.TabIndex = 0;
            // 
            // tbxMely
            // 
            tbxMely.Location = new Point(162, 248);
            tbxMely.Name = "tbxMely";
            tbxMely.Size = new Size(180, 36);
            tbxMely.TabIndex = 1;
            // 
            // tbxAzon
            // 
            tbxAzon.Location = new Point(162, 26);
            tbxAzon.Name = "tbxAzon";
            tbxAzon.Size = new Size(180, 36);
            tbxAzon.TabIndex = 1;
            // 
            // btnMentes
            // 
            btnMentes.Enabled = false;
            btnMentes.Location = new Point(398, 232);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(224, 49);
            btnMentes.TabIndex = 2;
            btnMentes.Text = "Adatok mentése";
            btnMentes.UseVisualStyleBackColor = true;
            // 
            // FrmBarlangok
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 311);
            Controls.Add(btnMentes);
            Controls.Add(btnKereses);
            Controls.Add(tbxAzon);
            Controls.Add(tbxMely);
            Controls.Add(tbxHossz);
            Controls.Add(lblUI04);
            Controls.Add(lblUI03);
            Controls.Add(lblNev);
            Controls.Add(lblUI02);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmBarlangok";
            Text = "Barlangok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox tbxHossz;
        private Button btnKereses;
        private Label lblUI02;
        private Label lblUI03;
        private Label lblUI04;
        private Label lblNev;
        private TextBox tbxMely;
        private TextBox tbxAzon;
        private Button btnMentes;
    }
}
