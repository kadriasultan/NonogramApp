namespace NonogramApp.Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPuzzels = new System.Windows.Forms.Button();
            this.btnInstellingen = new System.Windows.Forms.Button();
            this.btnProfiel = new System.Windows.Forms.Button();
            this.Welkom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Welcome = new System.Windows.Forms.Label();
            this.Uitleg = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Registeren = new System.Windows.Forms.Button();
            this.lblHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHeader.Controls.Add(this.flowLayoutPanel1);
            this.lblHeader.Controls.Add(this.label1);
            this.lblHeader.Location = new System.Drawing.Point(12, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1413, 77);
            this.lblHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nonogram Aplicatie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnHome);
            this.flowLayoutPanel1.Controls.Add(this.btnPuzzels);
            this.flowLayoutPanel1.Controls.Add(this.btnInstellingen);
            this.flowLayoutPanel1.Controls.Add(this.btnProfiel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(862, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(496, 30);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(136, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.Home_Click);
            // 
            // btnPuzzels
            // 
            this.btnPuzzels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPuzzels.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuzzels.Location = new System.Drawing.Point(145, 3);
            this.btnPuzzels.Name = "btnPuzzels";
            this.btnPuzzels.Size = new System.Drawing.Size(116, 23);
            this.btnPuzzels.TabIndex = 1;
            this.btnPuzzels.Text = "Puzzels";
            this.btnPuzzels.UseVisualStyleBackColor = false;
            // 
            // btnInstellingen
            // 
            this.btnInstellingen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInstellingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstellingen.Location = new System.Drawing.Point(267, 3);
            this.btnInstellingen.Name = "btnInstellingen";
            this.btnInstellingen.Size = new System.Drawing.Size(113, 23);
            this.btnInstellingen.TabIndex = 2;
            this.btnInstellingen.Text = "Instellingen";
            this.btnInstellingen.UseVisualStyleBackColor = false;
            // 
            // btnProfiel
            // 
            this.btnProfiel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProfiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfiel.Location = new System.Drawing.Point(386, 3);
            this.btnProfiel.Name = "btnProfiel";
            this.btnProfiel.Padding = new System.Windows.Forms.Padding(1);
            this.btnProfiel.Size = new System.Drawing.Size(106, 23);
            this.btnProfiel.TabIndex = 3;
            this.btnProfiel.Text = "Profiel";
            this.btnProfiel.UseVisualStyleBackColor = false;
            // 
            // Welkom
            // 
            this.Welkom.AutoSize = true;
            this.Welkom.Location = new System.Drawing.Point(372, 165);
            this.Welkom.Name = "Welkom";
            this.Welkom.Size = new System.Drawing.Size(0, 16);
            this.Welkom.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.Registeren);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.Uitleg);
            this.panel1.Controls.Add(this.Welcome);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 133);
            this.panel1.TabIndex = 2;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(15, 23);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(317, 24);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welkom bij de Nanogram Applicatie";
            // 
            // Uitleg
            // 
            this.Uitleg.AutoSize = true;
            this.Uitleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uitleg.Location = new System.Drawing.Point(16, 69);
            this.Uitleg.Name = "Uitleg";
            this.Uitleg.Size = new System.Drawing.Size(747, 20);
            this.Uitleg.TabIndex = 1;
            this.Uitleg.Text = "In deze applicatie kun je uitdagende nonogram puzzels spelen.  Login of registere" +
    "n om te beginnen.";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(1084, 57);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 40);
            this.Login.TabIndex = 2;
            this.Login.Text = "Inloggen";
            this.Login.UseVisualStyleBackColor = false;
            // 
            // Registeren
            // 
            this.Registeren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Registeren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registeren.Location = new System.Drawing.Point(1236, 57);
            this.Registeren.Name = "Registeren";
            this.Registeren.Size = new System.Drawing.Size(100, 40);
            this.Registeren.TabIndex = 3;
            this.Registeren.Text = "Registeren";
            this.Registeren.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1437, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Welkom);
            this.Controls.Add(this.lblHeader);
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.Text = "Nonogram Game";
            this.lblHeader.ResumeLayout(false);
            this.lblHeader.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel lblHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPuzzels;
        private System.Windows.Forms.Button btnInstellingen;
        private System.Windows.Forms.Button btnProfiel;
        private System.Windows.Forms.Label Welkom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label Uitleg;
        private System.Windows.Forms.Button Registeren;
        private System.Windows.Forms.Button Login;
    }
}
