namespace diplomski
{
    partial class Live
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.MenuSkladiste = new System.Windows.Forms.Button();
            this.MenuNeispravni = new System.Windows.Forms.Button();
            this.MenuLive = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.liveControl1 = new diplomski.LiveControl();
            this.skladisteControl1 = new diplomski.SkladisteControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.MenuSkladiste);
            this.panel1.Controls.Add(this.MenuNeispravni);
            this.panel1.Controls.Add(this.MenuLive);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 1192);
            this.panel1.TabIndex = 13;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Red;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(29, 250);
            this.SidePanel.TabIndex = 3;
            // 
            // MenuSkladiste
            // 
            this.MenuSkladiste.BackColor = System.Drawing.SystemColors.Window;
            this.MenuSkladiste.FlatAppearance.BorderSize = 0;
            this.MenuSkladiste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuSkladiste.Location = new System.Drawing.Point(0, 256);
            this.MenuSkladiste.Name = "MenuSkladiste";
            this.MenuSkladiste.Size = new System.Drawing.Size(373, 250);
            this.MenuSkladiste.TabIndex = 2;
            this.MenuSkladiste.Text = "SKLADIŠTE";
            this.MenuSkladiste.UseVisualStyleBackColor = false;
            this.MenuSkladiste.Click += new System.EventHandler(this.MenuSkladiste_Click);
            // 
            // MenuNeispravni
            // 
            this.MenuNeispravni.BackColor = System.Drawing.Color.White;
            this.MenuNeispravni.FlatAppearance.BorderSize = 0;
            this.MenuNeispravni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuNeispravni.Location = new System.Drawing.Point(0, 512);
            this.MenuNeispravni.Name = "MenuNeispravni";
            this.MenuNeispravni.Size = new System.Drawing.Size(373, 258);
            this.MenuNeispravni.TabIndex = 1;
            this.MenuNeispravni.Text = "NEISPRAVNI";
            this.MenuNeispravni.UseVisualStyleBackColor = false;
            this.MenuNeispravni.Click += new System.EventHandler(this.MenuNeispravni_Click);
            // 
            // MenuLive
            // 
            this.MenuLive.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MenuLive.FlatAppearance.BorderSize = 0;
            this.MenuLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuLive.Location = new System.Drawing.Point(0, 0);
            this.MenuLive.Name = "MenuLive";
            this.MenuLive.Size = new System.Drawing.Size(371, 250);
            this.MenuLive.TabIndex = 0;
            this.MenuLive.Text = "LIVE";
            this.MenuLive.UseVisualStyleBackColor = false;
            this.MenuLive.Click += new System.EventHandler(this.MenuLive_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(384, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1580, 180);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1407, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurac";
            // 
            // liveControl1
            // 
            this.liveControl1.Location = new System.Drawing.Point(464, 186);
            this.liveControl1.Name = "liveControl1";
            this.liveControl1.Size = new System.Drawing.Size(1488, 994);
            this.liveControl1.TabIndex = 16;
            // 
            // skladisteControl1
            // 
            this.skladisteControl1.Location = new System.Drawing.Point(439, 186);
            this.skladisteControl1.Name = "skladisteControl1";
            this.skladisteControl1.Size = new System.Drawing.Size(1513, 982);
            this.skladisteControl1.TabIndex = 17;
            // 
            // Live
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1964, 1192);
            this.Controls.Add(this.skladisteControl1);
            this.Controls.Add(this.liveControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Live";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Live";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MenuSkladiste;
        private System.Windows.Forms.Button MenuNeispravni;
        private System.Windows.Forms.Button MenuLive;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private LiveControl liveControl1;
        private SkladisteControl skladisteControl1;
    }
}

