using System.Drawing;

namespace SwissVisite
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.quitterBtn = new FontAwesome.Sharp.IconButton();
            this.visiteursBtn = new FontAwesome.Sharp.IconButton();
            this.praticiensBtn = new FontAwesome.Sharp.IconButton();
            this.medicamentsBtn = new FontAwesome.Sharp.IconButton();
            this.rapportsBtn = new FontAwesome.Sharp.IconButton();
            this.logoBtn = new System.Windows.Forms.Button();
            this.titreFormEnfantPanel = new System.Windows.Forms.Panel();
            this.visiteurConnecteLabel = new System.Windows.Forms.Label();
            this.minimMiniBtn = new FontAwesome.Sharp.IconButton();
            this.quitterMiniBtn = new FontAwesome.Sharp.IconButton();
            this.titreFormEnfantLabel = new System.Windows.Forms.Label();
            this.titreFormEnfantPicBox = new FontAwesome.Sharp.IconPictureBox();
            this.ombrePanel = new System.Windows.Forms.Panel();
            this.enfantPanel = new System.Windows.Forms.Panel();
            this.messageAccueilLabel = new System.Windows.Forms.Label();
            this.titreMessageAccueilLabel = new System.Windows.Forms.Label();
            this.monToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuPanel.SuspendLayout();
            this.titreFormEnfantPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titreFormEnfantPicBox)).BeginInit();
            this.enfantPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuPanel.Controls.Add(this.quitterBtn);
            this.menuPanel.Controls.Add(this.visiteursBtn);
            this.menuPanel.Controls.Add(this.praticiensBtn);
            this.menuPanel.Controls.Add(this.medicamentsBtn);
            this.menuPanel.Controls.Add(this.rapportsBtn);
            this.menuPanel.Controls.Add(this.logoBtn);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(1, 1);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 30);
            this.menuPanel.Size = new System.Drawing.Size(236, 798);
            this.menuPanel.TabIndex = 0;
            // 
            // quitterBtn
            // 
            this.quitterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitterBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.quitterBtn.FlatAppearance.BorderSize = 0;
            this.quitterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitterBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.quitterBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitterBtn.ForeColor = System.Drawing.Color.White;
            this.quitterBtn.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.quitterBtn.IconColor = System.Drawing.Color.White;
            this.quitterBtn.IconSize = 40;
            this.quitterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quitterBtn.Location = new System.Drawing.Point(0, 702);
            this.quitterBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quitterBtn.Name = "quitterBtn";
            this.quitterBtn.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.quitterBtn.Rotation = 0D;
            this.quitterBtn.Size = new System.Drawing.Size(236, 66);
            this.quitterBtn.TabIndex = 5;
            this.quitterBtn.Text = "Quitter";
            this.quitterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quitterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.quitterBtn, "Quitter l\'application");
            this.quitterBtn.UseVisualStyleBackColor = true;
            // 
            // visiteursBtn
            // 
            this.visiteursBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visiteursBtn.FlatAppearance.BorderSize = 0;
            this.visiteursBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visiteursBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.visiteursBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visiteursBtn.ForeColor = System.Drawing.Color.White;
            this.visiteursBtn.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.visiteursBtn.IconColor = System.Drawing.Color.White;
            this.visiteursBtn.IconSize = 40;
            this.visiteursBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visiteursBtn.Location = new System.Drawing.Point(0, 466);
            this.visiteursBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visiteursBtn.Name = "visiteursBtn";
            this.visiteursBtn.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.visiteursBtn.Rotation = 0D;
            this.visiteursBtn.Size = new System.Drawing.Size(236, 66);
            this.visiteursBtn.TabIndex = 4;
            this.visiteursBtn.Text = "   Visiteurs";
            this.visiteursBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visiteursBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.visiteursBtn, "Afficher les visiteurs médicaux");
            this.visiteursBtn.UseVisualStyleBackColor = true;
            // 
            // praticiensBtn
            // 
            this.praticiensBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.praticiensBtn.FlatAppearance.BorderSize = 0;
            this.praticiensBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.praticiensBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.praticiensBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.praticiensBtn.ForeColor = System.Drawing.Color.White;
            this.praticiensBtn.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.praticiensBtn.IconColor = System.Drawing.Color.White;
            this.praticiensBtn.IconSize = 40;
            this.praticiensBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.praticiensBtn.Location = new System.Drawing.Point(0, 400);
            this.praticiensBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.praticiensBtn.Name = "praticiensBtn";
            this.praticiensBtn.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.praticiensBtn.Rotation = 0D;
            this.praticiensBtn.Size = new System.Drawing.Size(236, 66);
            this.praticiensBtn.TabIndex = 3;
            this.praticiensBtn.Text = "   Praticiens";
            this.praticiensBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.praticiensBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.praticiensBtn, "Afficher les praticiens");
            this.praticiensBtn.UseVisualStyleBackColor = true;
            // 
            // medicamentsBtn
            // 
            this.medicamentsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medicamentsBtn.FlatAppearance.BorderSize = 0;
            this.medicamentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicamentsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.medicamentsBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicamentsBtn.ForeColor = System.Drawing.Color.White;
            this.medicamentsBtn.IconChar = FontAwesome.Sharp.IconChar.Pills;
            this.medicamentsBtn.IconColor = System.Drawing.Color.White;
            this.medicamentsBtn.IconSize = 40;
            this.medicamentsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medicamentsBtn.Location = new System.Drawing.Point(0, 334);
            this.medicamentsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medicamentsBtn.Name = "medicamentsBtn";
            this.medicamentsBtn.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medicamentsBtn.Rotation = 0D;
            this.medicamentsBtn.Size = new System.Drawing.Size(236, 66);
            this.medicamentsBtn.TabIndex = 2;
            this.medicamentsBtn.Text = "   Médicaments";
            this.medicamentsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medicamentsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.medicamentsBtn, "Afficher les médicaments");
            this.medicamentsBtn.UseVisualStyleBackColor = true;
            // 
            // rapportsBtn
            // 
            this.rapportsBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.rapportsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rapportsBtn.FlatAppearance.BorderSize = 0;
            this.rapportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rapportsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.rapportsBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rapportsBtn.ForeColor = System.Drawing.Color.White;
            this.rapportsBtn.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.rapportsBtn.IconColor = System.Drawing.Color.White;
            this.rapportsBtn.IconSize = 40;
            this.rapportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rapportsBtn.Location = new System.Drawing.Point(0, 268);
            this.rapportsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rapportsBtn.Name = "rapportsBtn";
            this.rapportsBtn.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rapportsBtn.Rotation = 0D;
            this.rapportsBtn.Size = new System.Drawing.Size(236, 66);
            this.rapportsBtn.TabIndex = 1;
            this.rapportsBtn.Text = "   Comptes-rendus";
            this.rapportsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rapportsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.rapportsBtn, "Afficher les comptes-rendus / Créer un nouveau compte-rendu");
            this.rapportsBtn.UseVisualStyleBackColor = false;
            // 
            // logoBtn
            // 
            this.logoBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoBtn.BackgroundImage = global::SwissVisiteForm.Properties.Resources.gsb_logo;
            this.logoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.logoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoBtn.Enabled = false;
            this.logoBtn.FlatAppearance.BorderSize = 0;
            this.logoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logoBtn.Location = new System.Drawing.Point(0, 30);
            this.logoBtn.Name = "logoBtn";
            this.logoBtn.Size = new System.Drawing.Size(236, 107);
            this.logoBtn.TabIndex = 0;
            this.logoBtn.UseVisualStyleBackColor = false;
            // 
            // titreFormEnfantPanel
            // 
            this.titreFormEnfantPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.titreFormEnfantPanel.Controls.Add(this.visiteurConnecteLabel);
            this.titreFormEnfantPanel.Controls.Add(this.minimMiniBtn);
            this.titreFormEnfantPanel.Controls.Add(this.quitterMiniBtn);
            this.titreFormEnfantPanel.Controls.Add(this.titreFormEnfantLabel);
            this.titreFormEnfantPanel.Controls.Add(this.titreFormEnfantPicBox);
            this.titreFormEnfantPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titreFormEnfantPanel.Location = new System.Drawing.Point(237, 1);
            this.titreFormEnfantPanel.Name = "titreFormEnfantPanel";
            this.titreFormEnfantPanel.Size = new System.Drawing.Size(962, 75);
            this.titreFormEnfantPanel.TabIndex = 1;
            // 
            // visiteurConnecteLabel
            // 
            this.visiteurConnecteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.visiteurConnecteLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visiteurConnecteLabel.ForeColor = System.Drawing.Color.White;
            this.visiteurConnecteLabel.Location = new System.Drawing.Point(415, 29);
            this.visiteurConnecteLabel.Name = "visiteurConnecteLabel";
            this.visiteurConnecteLabel.Size = new System.Drawing.Size(414, 33);
            this.visiteurConnecteLabel.TabIndex = 4;
            this.visiteurConnecteLabel.Text = "{Visiteur connecté}";
            this.visiteurConnecteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.minimMiniBtn.Location = new System.Drawing.Point(890, 6);
            this.minimMiniBtn.Name = "minimMiniBtn";
            this.minimMiniBtn.Rotation = 0D;
            this.minimMiniBtn.Size = new System.Drawing.Size(39, 34);
            this.minimMiniBtn.TabIndex = 3;
            this.minimMiniBtn.TabStop = false;
            this.monToolTip.SetToolTip(this.minimMiniBtn, "Réduire dans la barre des tâches");
            this.minimMiniBtn.UseVisualStyleBackColor = true;
            this.minimMiniBtn.Click += new System.EventHandler(this.MinimiserBtn_Click);
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
            this.quitterMiniBtn.Location = new System.Drawing.Point(917, 0);
            this.quitterMiniBtn.Name = "quitterMiniBtn";
            this.quitterMiniBtn.Rotation = 0D;
            this.quitterMiniBtn.Size = new System.Drawing.Size(49, 34);
            this.quitterMiniBtn.TabIndex = 2;
            this.quitterMiniBtn.TabStop = false;
            this.monToolTip.SetToolTip(this.quitterMiniBtn, "Quitter l\'application");
            this.quitterMiniBtn.UseVisualStyleBackColor = true;
            // 
            // titreFormEnfantLabel
            // 
            this.titreFormEnfantLabel.AutoSize = true;
            this.titreFormEnfantLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreFormEnfantLabel.ForeColor = System.Drawing.Color.White;
            this.titreFormEnfantLabel.Location = new System.Drawing.Point(87, 24);
            this.titreFormEnfantLabel.Name = "titreFormEnfantLabel";
            this.titreFormEnfantLabel.Size = new System.Drawing.Size(114, 33);
            this.titreFormEnfantLabel.TabIndex = 1;
            this.titreFormEnfantLabel.Text = "Accueil";
            // 
            // titreFormEnfantPicBox
            // 
            this.titreFormEnfantPicBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.titreFormEnfantPicBox.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.titreFormEnfantPicBox.IconColor = System.Drawing.Color.White;
            this.titreFormEnfantPicBox.IconSize = 48;
            this.titreFormEnfantPicBox.Location = new System.Drawing.Point(25, 17);
            this.titreFormEnfantPicBox.Name = "titreFormEnfantPicBox";
            this.titreFormEnfantPicBox.Size = new System.Drawing.Size(50, 48);
            this.titreFormEnfantPicBox.TabIndex = 0;
            this.titreFormEnfantPicBox.TabStop = false;
            // 
            // ombrePanel
            // 
            this.ombrePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.ombrePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ombrePanel.Location = new System.Drawing.Point(237, 76);
            this.ombrePanel.Name = "ombrePanel";
            this.ombrePanel.Size = new System.Drawing.Size(962, 6);
            this.ombrePanel.TabIndex = 2;
            // 
            // enfantPanel
            // 
            this.enfantPanel.BackColor = System.Drawing.Color.White;
            this.enfantPanel.Controls.Add(this.messageAccueilLabel);
            this.enfantPanel.Controls.Add(this.titreMessageAccueilLabel);
            this.enfantPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enfantPanel.Location = new System.Drawing.Point(237, 82);
            this.enfantPanel.Name = "enfantPanel";
            this.enfantPanel.Size = new System.Drawing.Size(962, 717);
            this.enfantPanel.TabIndex = 3;
            // 
            // messageAccueilLabel
            // 
            this.messageAccueilLabel.AutoSize = true;
            this.messageAccueilLabel.ForeColor = System.Drawing.Color.Black;
            this.messageAccueilLabel.Location = new System.Drawing.Point(89, 253);
            this.messageAccueilLabel.Name = "messageAccueilLabel";
            this.messageAccueilLabel.Size = new System.Drawing.Size(411, 22);
            this.messageAccueilLabel.TabIndex = 1;
            this.messageAccueilLabel.Text = "Choisissez une action depuis le menu latéral.";
            // 
            // titreMessageAccueilLabel
            // 
            this.titreMessageAccueilLabel.AutoSize = true;
            this.titreMessageAccueilLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreMessageAccueilLabel.ForeColor = System.Drawing.Color.Black;
            this.titreMessageAccueilLabel.Location = new System.Drawing.Point(86, 192);
            this.titreMessageAccueilLabel.Name = "titreMessageAccueilLabel";
            this.titreMessageAccueilLabel.Size = new System.Drawing.Size(202, 39);
            this.titreMessageAccueilLabel.TabIndex = 0;
            this.titreMessageAccueilLabel.Text = "Bienvenue !";
            // 
            // monToolTip
            // 
            this.monToolTip.BackColor = System.Drawing.Color.White;
            this.monToolTip.ForeColor = System.Drawing.Color.Black;
            this.monToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.ControlBox = false;
            this.Controls.Add(this.enfantPanel);
            this.Controls.Add(this.ombrePanel);
            this.Controls.Add(this.titreFormEnfantPanel);
            this.Controls.Add(this.menuPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuPanel.ResumeLayout(false);
            this.titreFormEnfantPanel.ResumeLayout(false);
            this.titreFormEnfantPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titreFormEnfantPicBox)).EndInit();
            this.enfantPanel.ResumeLayout(false);
            this.enfantPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private FontAwesome.Sharp.IconButton rapportsBtn;
        private FontAwesome.Sharp.IconButton quitterBtn;
        private FontAwesome.Sharp.IconButton visiteursBtn;
        private FontAwesome.Sharp.IconButton praticiensBtn;
        private FontAwesome.Sharp.IconButton medicamentsBtn;
        private System.Windows.Forms.Panel titreFormEnfantPanel;
        private FontAwesome.Sharp.IconPictureBox titreFormEnfantPicBox;
        private System.Windows.Forms.Label titreFormEnfantLabel;
        private System.Windows.Forms.Panel ombrePanel;
        private System.Windows.Forms.Panel enfantPanel;
        private FontAwesome.Sharp.IconButton minimMiniBtn;
        private FontAwesome.Sharp.IconButton quitterMiniBtn;
        private System.Windows.Forms.Button logoBtn;
        private System.Windows.Forms.ToolTip monToolTip;
        private System.Windows.Forms.Label visiteurConnecteLabel;
        private System.Windows.Forms.Label titreMessageAccueilLabel;
        private System.Windows.Forms.Label messageAccueilLabel;
    }
}

