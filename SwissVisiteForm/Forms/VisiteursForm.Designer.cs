namespace SwissVisite.Forms
{
    partial class VisiteursForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisiteursForm));
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nomLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.nomVal = new System.Windows.Forms.Label();
            this.adresseLabel = new System.Windows.Forms.Label();
            this.prenomVal = new System.Windows.Forms.Label();
            this.villeLabel = new System.Windows.Forms.Label();
            this.adresseVal = new System.Windows.Forms.Label();
            this.secteurLabel = new System.Windows.Forms.Label();
            this.villeVal = new System.Windows.Forms.Label();
            this.laboLabel = new System.Windows.Forms.Label();
            this.laboVal = new System.Windows.Forms.Label();
            this.secteurVal = new System.Windows.Forms.Label();
            this.selecVisitPanel = new System.Windows.Forms.Panel();
            this.visitSuivBtn = new FontAwesome.Sharp.IconButton();
            this.visitSelecComboBox = new System.Windows.Forms.ComboBox();
            this.visitPrecBtn = new FontAwesome.Sharp.IconButton();
            this.visitSelecLabel = new System.Windows.Forms.Label();
            this.monToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.selecVisitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.IsSplitterFixed = true;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.mainPanel);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.mainContainer.Panel2.Controls.Add(this.selecVisitPanel);
            this.mainContainer.Size = new System.Drawing.Size(962, 717);
            this.mainContainer.SplitterDistance = 648;
            this.mainContainer.TabIndex = 2;
            this.mainContainer.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 4;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.nomLabel, 1, 1);
            this.mainPanel.Controls.Add(this.prenomLabel, 1, 2);
            this.mainPanel.Controls.Add(this.nomVal, 3, 1);
            this.mainPanel.Controls.Add(this.adresseLabel, 1, 3);
            this.mainPanel.Controls.Add(this.prenomVal, 3, 2);
            this.mainPanel.Controls.Add(this.villeLabel, 1, 4);
            this.mainPanel.Controls.Add(this.adresseVal, 3, 3);
            this.mainPanel.Controls.Add(this.secteurLabel, 1, 5);
            this.mainPanel.Controls.Add(this.villeVal, 3, 4);
            this.mainPanel.Controls.Add(this.laboLabel, 1, 6);
            this.mainPanel.Controls.Add(this.laboVal, 3, 6);
            this.mainPanel.Controls.Add(this.secteurVal, 3, 5);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 8;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.Size = new System.Drawing.Size(648, 717);
            this.mainPanel.TabIndex = 0;
            // 
            // nomLabel
            // 
            this.nomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nomLabel.AutoSize = true;
            this.nomLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nomLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.nomLabel.Location = new System.Drawing.Point(43, 142);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.nomLabel.Size = new System.Drawing.Size(53, 72);
            this.nomLabel.TabIndex = 2;
            this.nomLabel.Text = "Nom";
            // 
            // prenomLabel
            // 
            this.prenomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prenomLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.prenomLabel.Location = new System.Drawing.Point(43, 214);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.prenomLabel.Size = new System.Drawing.Size(80, 72);
            this.prenomLabel.TabIndex = 1;
            this.prenomLabel.Text = "Prénom";
            // 
            // nomVal
            // 
            this.nomVal.AutoSize = true;
            this.nomVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nomVal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomVal.ForeColor = System.Drawing.Color.Black;
            this.nomVal.Location = new System.Drawing.Point(185, 142);
            this.nomVal.Name = "nomVal";
            this.nomVal.Size = new System.Drawing.Size(460, 72);
            this.nomVal.TabIndex = 8;
            this.nomVal.Text = "{Nom}";
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adresseLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.adresseLabel.Location = new System.Drawing.Point(43, 286);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.adresseLabel.Size = new System.Drawing.Size(82, 72);
            this.adresseLabel.TabIndex = 6;
            this.adresseLabel.Text = "Adresse";
            // 
            // prenomVal
            // 
            this.prenomVal.AutoSize = true;
            this.prenomVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prenomVal.ForeColor = System.Drawing.Color.Black;
            this.prenomVal.Location = new System.Drawing.Point(185, 214);
            this.prenomVal.Name = "prenomVal";
            this.prenomVal.Size = new System.Drawing.Size(460, 72);
            this.prenomVal.TabIndex = 9;
            this.prenomVal.Text = "{Prénom}";
            // 
            // villeLabel
            // 
            this.villeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.villeLabel.AutoSize = true;
            this.villeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.villeLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.villeLabel.Location = new System.Drawing.Point(43, 358);
            this.villeLabel.Name = "villeLabel";
            this.villeLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.villeLabel.Size = new System.Drawing.Size(46, 72);
            this.villeLabel.TabIndex = 3;
            this.villeLabel.Text = "Ville";
            // 
            // adresseVal
            // 
            this.adresseVal.AutoSize = true;
            this.adresseVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adresseVal.ForeColor = System.Drawing.Color.Black;
            this.adresseVal.Location = new System.Drawing.Point(185, 286);
            this.adresseVal.Name = "adresseVal";
            this.adresseVal.Size = new System.Drawing.Size(460, 72);
            this.adresseVal.TabIndex = 10;
            this.adresseVal.Text = "{Adresse}";
            // 
            // secteurLabel
            // 
            this.secteurLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.secteurLabel.AutoSize = true;
            this.secteurLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secteurLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.secteurLabel.Location = new System.Drawing.Point(43, 430);
            this.secteurLabel.Name = "secteurLabel";
            this.secteurLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.secteurLabel.Size = new System.Drawing.Size(80, 72);
            this.secteurLabel.TabIndex = 4;
            this.secteurLabel.Text = "Secteur";
            // 
            // villeVal
            // 
            this.villeVal.AutoSize = true;
            this.villeVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.villeVal.ForeColor = System.Drawing.Color.Black;
            this.villeVal.Location = new System.Drawing.Point(185, 358);
            this.villeVal.Name = "villeVal";
            this.villeVal.Size = new System.Drawing.Size(460, 72);
            this.villeVal.TabIndex = 12;
            this.villeVal.Text = "{CP et Ville}";
            // 
            // laboLabel
            // 
            this.laboLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.laboLabel.AutoSize = true;
            this.laboLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.laboLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.laboLabel.Location = new System.Drawing.Point(43, 502);
            this.laboLabel.Name = "laboLabel";
            this.laboLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.laboLabel.Size = new System.Drawing.Size(116, 72);
            this.laboLabel.TabIndex = 5;
            this.laboLabel.Text = "Laboratoire";
            // 
            // laboVal
            // 
            this.laboVal.AutoSize = true;
            this.laboVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laboVal.ForeColor = System.Drawing.Color.Black;
            this.laboVal.Location = new System.Drawing.Point(185, 502);
            this.laboVal.Name = "laboVal";
            this.laboVal.Size = new System.Drawing.Size(460, 72);
            this.laboVal.TabIndex = 11;
            this.laboVal.Text = "{Labo}";
            // 
            // secteurVal
            // 
            this.secteurVal.AutoSize = true;
            this.secteurVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secteurVal.ForeColor = System.Drawing.Color.Black;
            this.secteurVal.Location = new System.Drawing.Point(185, 430);
            this.secteurVal.Name = "secteurVal";
            this.secteurVal.Size = new System.Drawing.Size(460, 72);
            this.secteurVal.TabIndex = 13;
            this.secteurVal.Text = "{Secteur}";
            // 
            // selecVisitPanel
            // 
            this.selecVisitPanel.Controls.Add(this.visitSuivBtn);
            this.selecVisitPanel.Controls.Add(this.visitSelecComboBox);
            this.selecVisitPanel.Controls.Add(this.visitPrecBtn);
            this.selecVisitPanel.Controls.Add(this.visitSelecLabel);
            this.selecVisitPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecVisitPanel.Location = new System.Drawing.Point(16, 268);
            this.selecVisitPanel.Name = "selecVisitPanel";
            this.selecVisitPanel.Size = new System.Drawing.Size(273, 140);
            this.selecVisitPanel.TabIndex = 23;
            // 
            // visitSuivBtn
            // 
            this.visitSuivBtn.BackColor = System.Drawing.Color.White;
            this.visitSuivBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visitSuivBtn.FlatAppearance.BorderSize = 0;
            this.visitSuivBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.visitSuivBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.visitSuivBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visitSuivBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.visitSuivBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitSuivBtn.ForeColor = System.Drawing.Color.Black;
            this.visitSuivBtn.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.visitSuivBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.visitSuivBtn.IconSize = 40;
            this.visitSuivBtn.Location = new System.Drawing.Point(138, 89);
            this.visitSuivBtn.Name = "visitSuivBtn";
            this.visitSuivBtn.Rotation = 0D;
            this.visitSuivBtn.Size = new System.Drawing.Size(135, 51);
            this.visitSuivBtn.TabIndex = 24;
            this.visitSuivBtn.Text = "   Suiv.";
            this.visitSuivBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.monToolTip.SetToolTip(this.visitSuivBtn, "Aller au visiteur suivant.");
            this.visitSuivBtn.UseVisualStyleBackColor = false;
            this.visitSuivBtn.Click += new System.EventHandler(this.visitSuivBtn_Click);
            // 
            // visitSelecComboBox
            // 
            this.visitSelecComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.visitSelecComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.visitSelecComboBox.BackColor = System.Drawing.Color.White;
            this.visitSelecComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visitSelecComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.visitSelecComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visitSelecComboBox.ForeColor = System.Drawing.Color.Black;
            this.visitSelecComboBox.FormattingEnabled = true;
            this.visitSelecComboBox.Location = new System.Drawing.Point(0, 26);
            this.visitSelecComboBox.Name = "visitSelecComboBox";
            this.visitSelecComboBox.Size = new System.Drawing.Size(273, 29);
            this.visitSelecComboBox.TabIndex = 3;
            this.visitSelecComboBox.Text = "{Visiteur}";
            this.monToolTip.SetToolTip(this.visitSelecComboBox, "Sélectionner un visiteur.");
            this.visitSelecComboBox.SelectedIndexChanged += new System.EventHandler(this.visitSelecComboBox_SelectedIndexChanged);
            // 
            // visitPrecBtn
            // 
            this.visitPrecBtn.BackColor = System.Drawing.Color.White;
            this.visitPrecBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visitPrecBtn.FlatAppearance.BorderSize = 0;
            this.visitPrecBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.visitPrecBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.visitPrecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visitPrecBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.visitPrecBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitPrecBtn.ForeColor = System.Drawing.Color.Black;
            this.visitPrecBtn.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.visitPrecBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.visitPrecBtn.IconSize = 40;
            this.visitPrecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visitPrecBtn.Location = new System.Drawing.Point(0, 89);
            this.visitPrecBtn.Name = "visitPrecBtn";
            this.visitPrecBtn.Rotation = 0D;
            this.visitPrecBtn.Size = new System.Drawing.Size(135, 51);
            this.visitPrecBtn.TabIndex = 23;
            this.visitPrecBtn.Text = "   Préc.";
            this.visitPrecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.visitPrecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.visitPrecBtn, "Aller au visiteur précédent.");
            this.visitPrecBtn.UseVisualStyleBackColor = false;
            this.visitPrecBtn.Click += new System.EventHandler(this.visitPrecBtn_Click);
            // 
            // visitSelecLabel
            // 
            this.visitSelecLabel.AutoSize = true;
            this.visitSelecLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.visitSelecLabel.Location = new System.Drawing.Point(0, 0);
            this.visitSelecLabel.Name = "visitSelecLabel";
            this.visitSelecLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.visitSelecLabel.Size = new System.Drawing.Size(150, 26);
            this.visitSelecLabel.TabIndex = 2;
            this.visitSelecLabel.Text = "Trouver un visiteur";
            // 
            // monToolTip
            // 
            this.monToolTip.BackColor = System.Drawing.Color.White;
            this.monToolTip.ForeColor = System.Drawing.Color.Black;
            // 
            // VisiteursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 717);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "VisiteursForm";
            this.Text = "GSB SwissVisite - Annuaire des praticiens";
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.selecVisitPanel.ResumeLayout(false);
            this.selecVisitPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Label secteurLabel;
        private System.Windows.Forms.Label villeLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label adresseLabel;
        private System.Windows.Forms.Label laboLabel;
        private System.Windows.Forms.Label nomVal;
        private System.Windows.Forms.Label prenomVal;
        private System.Windows.Forms.Label adresseVal;
        private System.Windows.Forms.Label laboVal;
        private System.Windows.Forms.Label secteurVal;
        private System.Windows.Forms.Label villeVal;
        private System.Windows.Forms.Panel selecVisitPanel;
        private FontAwesome.Sharp.IconButton visitSuivBtn;
        private System.Windows.Forms.ComboBox visitSelecComboBox;
        private FontAwesome.Sharp.IconButton visitPrecBtn;
        private System.Windows.Forms.Label visitSelecLabel;
        private System.Windows.Forms.ToolTip monToolTip;
    }
}