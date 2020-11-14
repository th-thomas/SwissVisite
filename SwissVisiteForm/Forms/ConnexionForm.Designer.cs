namespace SwissVisite.Forms
{
    partial class ConnexionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnexionForm));
            this.bordureHautPanel = new System.Windows.Forms.Panel();
            this.titreFormLabel = new System.Windows.Forms.Label();
            this.minimMiniBtn = new FontAwesome.Sharp.IconButton();
            this.quitterMiniBtn = new FontAwesome.Sharp.IconButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.motDePasseValEffaceBtn = new FontAwesome.Sharp.IconButton();
            this.identifiantValEffaceBtn = new FontAwesome.Sharp.IconButton();
            this.erreurTextBox = new System.Windows.Forms.Label();
            this.boutonsPanel = new System.Windows.Forms.Panel();
            this.connexionBtn = new System.Windows.Forms.Button();
            this.quitterBtn = new System.Windows.Forms.Button();
            this.motDePasseVal = new System.Windows.Forms.TextBox();
            this.motDePasseLabel = new System.Windows.Forms.Label();
            this.identifiantVal = new System.Windows.Forms.TextBox();
            this.identifiantLabel = new System.Windows.Forms.Label();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.monToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bordureHautPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.boutonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // bordureHautPanel
            // 
            this.bordureHautPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.bordureHautPanel.Controls.Add(this.titreFormLabel);
            this.bordureHautPanel.Controls.Add(this.minimMiniBtn);
            this.bordureHautPanel.Controls.Add(this.quitterMiniBtn);
            this.bordureHautPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bordureHautPanel.Location = new System.Drawing.Point(1, 1);
            this.bordureHautPanel.Name = "bordureHautPanel";
            this.bordureHautPanel.Size = new System.Drawing.Size(598, 50);
            this.bordureHautPanel.TabIndex = 6;
            // 
            // titreFormLabel
            // 
            this.titreFormLabel.AutoSize = true;
            this.titreFormLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreFormLabel.ForeColor = System.Drawing.Color.White;
            this.titreFormLabel.Location = new System.Drawing.Point(24, 16);
            this.titreFormLabel.Name = "titreFormLabel";
            this.titreFormLabel.Size = new System.Drawing.Size(219, 19);
            this.titreFormLabel.TabIndex = 5;
            this.titreFormLabel.Text = "GSB SwissVisite - Connexion";
            // 
            // minimMiniBtn
            // 
            this.minimMiniBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimMiniBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minimMiniBtn.FlatAppearance.BorderSize = 0;
            this.minimMiniBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimMiniBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimMiniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimMiniBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.minimMiniBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.minimMiniBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimMiniBtn.IconColor = System.Drawing.Color.White;
            this.minimMiniBtn.IconSize = 32;
            this.minimMiniBtn.Location = new System.Drawing.Point(522, 10);
            this.minimMiniBtn.Name = "minimMiniBtn";
            this.minimMiniBtn.Rotation = 0D;
            this.minimMiniBtn.Size = new System.Drawing.Size(39, 34);
            this.minimMiniBtn.TabIndex = 4;
            this.minimMiniBtn.TabStop = false;
            this.minimMiniBtn.UseVisualStyleBackColor = true;
            this.minimMiniBtn.Click += new System.EventHandler(this.minimMiniBtn_Click);
            // 
            // quitterMiniBtn
            // 
            this.quitterMiniBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitterMiniBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quitterMiniBtn.FlatAppearance.BorderSize = 0;
            this.quitterMiniBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.quitterMiniBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.quitterMiniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitterMiniBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.quitterMiniBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.quitterMiniBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.quitterMiniBtn.IconColor = System.Drawing.Color.White;
            this.quitterMiniBtn.IconSize = 32;
            this.quitterMiniBtn.Location = new System.Drawing.Point(548, 3);
            this.quitterMiniBtn.Name = "quitterMiniBtn";
            this.quitterMiniBtn.Rotation = 0D;
            this.quitterMiniBtn.Size = new System.Drawing.Size(49, 34);
            this.quitterMiniBtn.TabIndex = 3;
            this.quitterMiniBtn.TabStop = false;
            this.quitterMiniBtn.UseVisualStyleBackColor = true;
            this.quitterMiniBtn.Click += new System.EventHandler(this.quitterMiniBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.motDePasseValEffaceBtn);
            this.mainPanel.Controls.Add(this.identifiantValEffaceBtn);
            this.mainPanel.Controls.Add(this.erreurTextBox);
            this.mainPanel.Controls.Add(this.boutonsPanel);
            this.mainPanel.Controls.Add(this.motDePasseVal);
            this.mainPanel.Controls.Add(this.motDePasseLabel);
            this.mainPanel.Controls.Add(this.identifiantVal);
            this.mainPanel.Controls.Add(this.identifiantLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.ForeColor = System.Drawing.Color.Black;
            this.mainPanel.Location = new System.Drawing.Point(15, 15);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.mainPanel.Size = new System.Drawing.Size(366, 368);
            this.mainPanel.TabIndex = 11;
            // 
            // motDePasseValEffaceBtn
            // 
            this.motDePasseValEffaceBtn.BackColor = System.Drawing.Color.Transparent;
            this.motDePasseValEffaceBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.motDePasseValEffaceBtn.FlatAppearance.BorderSize = 0;
            this.motDePasseValEffaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motDePasseValEffaceBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.motDePasseValEffaceBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.motDePasseValEffaceBtn.IconColor = System.Drawing.Color.DimGray;
            this.motDePasseValEffaceBtn.IconSize = 22;
            this.motDePasseValEffaceBtn.Location = new System.Drawing.Point(299, 189);
            this.motDePasseValEffaceBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.motDePasseValEffaceBtn.Name = "motDePasseValEffaceBtn";
            this.motDePasseValEffaceBtn.Rotation = 0D;
            this.motDePasseValEffaceBtn.Size = new System.Drawing.Size(22, 19);
            this.motDePasseValEffaceBtn.TabIndex = 11;
            this.monToolTip.SetToolTip(this.motDePasseValEffaceBtn, "Effacer le mot de passe saisi");
            this.motDePasseValEffaceBtn.UseVisualStyleBackColor = false;
            this.motDePasseValEffaceBtn.Visible = false;
            this.motDePasseValEffaceBtn.Click += new System.EventHandler(this.motDePasseValEffaceBtn_Click);
            // 
            // identifiantValEffaceBtn
            // 
            this.identifiantValEffaceBtn.BackColor = System.Drawing.Color.Transparent;
            this.identifiantValEffaceBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.identifiantValEffaceBtn.FlatAppearance.BorderSize = 0;
            this.identifiantValEffaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.identifiantValEffaceBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.identifiantValEffaceBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.identifiantValEffaceBtn.IconColor = System.Drawing.Color.DimGray;
            this.identifiantValEffaceBtn.IconSize = 22;
            this.identifiantValEffaceBtn.Location = new System.Drawing.Point(299, 105);
            this.identifiantValEffaceBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.identifiantValEffaceBtn.Name = "identifiantValEffaceBtn";
            this.identifiantValEffaceBtn.Rotation = 0D;
            this.identifiantValEffaceBtn.Size = new System.Drawing.Size(22, 19);
            this.identifiantValEffaceBtn.TabIndex = 10;
            this.monToolTip.SetToolTip(this.identifiantValEffaceBtn, "Effacer l\'identifiant saisi");
            this.identifiantValEffaceBtn.UseVisualStyleBackColor = false;
            this.identifiantValEffaceBtn.Visible = false;
            this.identifiantValEffaceBtn.Click += new System.EventHandler(this.identifiantValEffaceBtn_Click);
            // 
            // erreurTextBox
            // 
            this.erreurTextBox.AutoSize = true;
            this.erreurTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreurTextBox.ForeColor = System.Drawing.Color.Red;
            this.erreurTextBox.Location = new System.Drawing.Point(30, 20);
            this.erreurTextBox.Name = "erreurTextBox";
            this.erreurTextBox.Size = new System.Drawing.Size(62, 19);
            this.erreurTextBox.TabIndex = 9;
            this.erreurTextBox.Text = "{Erreur}";
            this.erreurTextBox.Visible = false;
            // 
            // boutonsPanel
            // 
            this.boutonsPanel.Controls.Add(this.connexionBtn);
            this.boutonsPanel.Controls.Add(this.quitterBtn);
            this.boutonsPanel.Location = new System.Drawing.Point(7, 256);
            this.boutonsPanel.Name = "boutonsPanel";
            this.boutonsPanel.Size = new System.Drawing.Size(352, 100);
            this.boutonsPanel.TabIndex = 8;
            // 
            // connexionBtn
            // 
            this.connexionBtn.BackColor = System.Drawing.Color.White;
            this.connexionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connexionBtn.Enabled = false;
            this.connexionBtn.FlatAppearance.BorderSize = 0;
            this.connexionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.connexionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connexionBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connexionBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.connexionBtn.Location = new System.Drawing.Point(32, 23);
            this.connexionBtn.Name = "connexionBtn";
            this.connexionBtn.Size = new System.Drawing.Size(130, 55);
            this.connexionBtn.TabIndex = 6;
            this.connexionBtn.Text = "Connexion";
            this.connexionBtn.UseVisualStyleBackColor = false;
            this.connexionBtn.Click += new System.EventHandler(this.connexionBtn_Click);
            // 
            // quitterBtn
            // 
            this.quitterBtn.BackColor = System.Drawing.Color.White;
            this.quitterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitterBtn.FlatAppearance.BorderSize = 0;
            this.quitterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.quitterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitterBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitterBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.quitterBtn.Location = new System.Drawing.Point(190, 23);
            this.quitterBtn.Name = "quitterBtn";
            this.quitterBtn.Size = new System.Drawing.Size(130, 55);
            this.quitterBtn.TabIndex = 7;
            this.quitterBtn.Text = "Annuler";
            this.quitterBtn.UseVisualStyleBackColor = false;
            this.quitterBtn.Click += new System.EventHandler(this.quitterBtn_Click);
            // 
            // motDePasseVal
            // 
            this.motDePasseVal.BackColor = System.Drawing.Color.Gainsboro;
            this.motDePasseVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.motDePasseVal.ForeColor = System.Drawing.Color.Black;
            this.motDePasseVal.Location = new System.Drawing.Point(34, 189);
            this.motDePasseVal.Name = "motDePasseVal";
            this.motDePasseVal.PasswordChar = '*';
            this.motDePasseVal.Size = new System.Drawing.Size(260, 24);
            this.motDePasseVal.TabIndex = 5;
            // 
            // motDePasseLabel
            // 
            this.motDePasseLabel.AutoSize = true;
            this.motDePasseLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motDePasseLabel.Location = new System.Drawing.Point(30, 132);
            this.motDePasseLabel.Name = "motDePasseLabel";
            this.motDePasseLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.motDePasseLabel.Size = new System.Drawing.Size(148, 54);
            this.motDePasseLabel.TabIndex = 3;
            this.motDePasseLabel.Text = "Mot de passe";
            // 
            // identifiantVal
            // 
            this.identifiantVal.BackColor = System.Drawing.Color.Gainsboro;
            this.identifiantVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.identifiantVal.ForeColor = System.Drawing.Color.Black;
            this.identifiantVal.Location = new System.Drawing.Point(34, 105);
            this.identifiantVal.Name = "identifiantVal";
            this.identifiantVal.Size = new System.Drawing.Size(260, 24);
            this.identifiantVal.TabIndex = 4;
            // 
            // identifiantLabel
            // 
            this.identifiantLabel.AutoSize = true;
            this.identifiantLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifiantLabel.Location = new System.Drawing.Point(30, 58);
            this.identifiantLabel.Name = "identifiantLabel";
            this.identifiantLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.identifiantLabel.Size = new System.Drawing.Size(110, 44);
            this.identifiantLabel.TabIndex = 2;
            this.identifiantLabel.Text = "Identifiant";
            // 
            // logoPicBox
            // 
            this.logoPicBox.BackgroundImage = global::SwissVisiteForm.Properties.Resources.gsb_logo;
            this.logoPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPicBox.Location = new System.Drawing.Point(25, 15);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(158, 368);
            this.logoPicBox.TabIndex = 0;
            this.logoPicBox.TabStop = false;
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.White;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(1, 51);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.logoPicBox);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(25, 15, 15, 15);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.mainPanel);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.splitContainer.Size = new System.Drawing.Size(598, 398);
            this.splitContainer.SplitterDistance = 198;
            this.splitContainer.TabIndex = 12;
            this.splitContainer.TabStop = false;
            // 
            // monToolTip
            // 
            this.monToolTip.BackColor = System.Drawing.Color.White;
            this.monToolTip.ForeColor = System.Drawing.Color.Black;
            this.monToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ConnexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.bordureHautPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnexionForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSB SwissVisite - Connexion";
            this.bordureHautPanel.ResumeLayout(false);
            this.bordureHautPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.boutonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bordureHautPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.Label motDePasseLabel;
        private System.Windows.Forms.Label identifiantLabel;
        private System.Windows.Forms.TextBox identifiantVal;
        private System.Windows.Forms.TextBox motDePasseVal;
        private System.Windows.Forms.Button quitterBtn;
        private System.Windows.Forms.Button connexionBtn;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel boutonsPanel;
        private FontAwesome.Sharp.IconButton quitterMiniBtn;
        private FontAwesome.Sharp.IconButton minimMiniBtn;
        private System.Windows.Forms.Label titreFormLabel;
        private System.Windows.Forms.Label erreurTextBox;
        private FontAwesome.Sharp.IconButton identifiantValEffaceBtn;
        private FontAwesome.Sharp.IconButton motDePasseValEffaceBtn;
        private System.Windows.Forms.ToolTip monToolTip;
    }
}