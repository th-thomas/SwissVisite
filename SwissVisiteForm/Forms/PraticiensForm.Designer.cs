namespace SwissVisite.Forms
{
    partial class PraticiensForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PraticiensForm));
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.coeffNotLabel = new System.Windows.Forms.Label();
            this.villeLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.adresseLabel = new System.Windows.Forms.Label();
            this.lieuExerciceLabel = new System.Windows.Forms.Label();
            this.idVal = new System.Windows.Forms.Label();
            this.nomVal = new System.Windows.Forms.Label();
            this.prenomVal = new System.Windows.Forms.Label();
            this.adresseVal = new System.Windows.Forms.Label();
            this.coeffNotVal = new System.Windows.Forms.Label();
            this.lieuExerciceVal = new System.Windows.Forms.Label();
            this.villeVal = new System.Windows.Forms.Label();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.selecPratPanel = new System.Windows.Forms.Panel();
            this.selecBtn = new FontAwesome.Sharp.IconButton();
            this.retourBtn = new FontAwesome.Sharp.IconButton();
            this.pratSuivBtn = new FontAwesome.Sharp.IconButton();
            this.pratSelecComboBox = new System.Windows.Forms.ComboBox();
            this.pratPrecBtn = new FontAwesome.Sharp.IconButton();
            this.pratSelecLabel = new System.Windows.Forms.Label();
            this.monToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.selecPratPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 4;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.coeffNotLabel, 1, 6);
            this.mainPanel.Controls.Add(this.villeLabel, 1, 5);
            this.mainPanel.Controls.Add(this.idLabel, 1, 1);
            this.mainPanel.Controls.Add(this.nomLabel, 1, 2);
            this.mainPanel.Controls.Add(this.prenomLabel, 1, 3);
            this.mainPanel.Controls.Add(this.adresseLabel, 1, 4);
            this.mainPanel.Controls.Add(this.lieuExerciceLabel, 1, 7);
            this.mainPanel.Controls.Add(this.idVal, 3, 1);
            this.mainPanel.Controls.Add(this.nomVal, 3, 2);
            this.mainPanel.Controls.Add(this.prenomVal, 3, 3);
            this.mainPanel.Controls.Add(this.adresseVal, 3, 4);
            this.mainPanel.Controls.Add(this.coeffNotVal, 3, 6);
            this.mainPanel.Controls.Add(this.lieuExerciceVal, 3, 7);
            this.mainPanel.Controls.Add(this.villeVal, 3, 5);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 9;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Size = new System.Drawing.Size(647, 717);
            this.mainPanel.TabIndex = 0;
            // 
            // coeffNotLabel
            // 
            this.coeffNotLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.coeffNotLabel.AutoSize = true;
            this.coeffNotLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coeffNotLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.coeffNotLabel.Location = new System.Drawing.Point(43, 466);
            this.coeffNotLabel.Name = "coeffNotLabel";
            this.coeffNotLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.coeffNotLabel.Size = new System.Drawing.Size(154, 72);
            this.coeffNotLabel.TabIndex = 4;
            this.coeffNotLabel.Text = "Coeff. notoriété";
            // 
            // villeLabel
            // 
            this.villeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.villeLabel.AutoSize = true;
            this.villeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.villeLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.villeLabel.Location = new System.Drawing.Point(43, 394);
            this.villeLabel.Name = "villeLabel";
            this.villeLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.villeLabel.Size = new System.Drawing.Size(46, 72);
            this.villeLabel.TabIndex = 3;
            this.villeLabel.Text = "Ville";
            // 
            // idLabel
            // 
            this.idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.idLabel.AutoSize = true;
            this.idLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.idLabel.Location = new System.Drawing.Point(43, 106);
            this.idLabel.Name = "idLabel";
            this.idLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.idLabel.Size = new System.Drawing.Size(83, 72);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Numéro";
            // 
            // nomLabel
            // 
            this.nomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nomLabel.AutoSize = true;
            this.nomLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nomLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.nomLabel.Location = new System.Drawing.Point(43, 178);
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
            this.prenomLabel.Location = new System.Drawing.Point(43, 250);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.prenomLabel.Size = new System.Drawing.Size(80, 72);
            this.prenomLabel.TabIndex = 1;
            this.prenomLabel.Text = "Prénom";
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adresseLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.adresseLabel.Location = new System.Drawing.Point(43, 322);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.adresseLabel.Size = new System.Drawing.Size(82, 72);
            this.adresseLabel.TabIndex = 6;
            this.adresseLabel.Text = "Adresse";
            // 
            // lieuExerciceLabel
            // 
            this.lieuExerciceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lieuExerciceLabel.AutoSize = true;
            this.lieuExerciceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lieuExerciceLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.lieuExerciceLabel.Location = new System.Drawing.Point(43, 538);
            this.lieuExerciceLabel.Name = "lieuExerciceLabel";
            this.lieuExerciceLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.lieuExerciceLabel.Size = new System.Drawing.Size(146, 72);
            this.lieuExerciceLabel.TabIndex = 5;
            this.lieuExerciceLabel.Text = "Lieu d\'exercice";
            // 
            // idVal
            // 
            this.idVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.idVal.AutoSize = true;
            this.idVal.ForeColor = System.Drawing.Color.Black;
            this.idVal.Location = new System.Drawing.Point(223, 106);
            this.idVal.Name = "idVal";
            this.idVal.Size = new System.Drawing.Size(95, 72);
            this.idVal.TabIndex = 7;
            this.idVal.Text = "{Numéro}";
            // 
            // nomVal
            // 
            this.nomVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nomVal.AutoSize = true;
            this.nomVal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomVal.ForeColor = System.Drawing.Color.Black;
            this.nomVal.Location = new System.Drawing.Point(223, 178);
            this.nomVal.Name = "nomVal";
            this.nomVal.Size = new System.Drawing.Size(66, 72);
            this.nomVal.TabIndex = 8;
            this.nomVal.Text = "{Nom}";
            // 
            // prenomVal
            // 
            this.prenomVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.prenomVal.AutoSize = true;
            this.prenomVal.ForeColor = System.Drawing.Color.Black;
            this.prenomVal.Location = new System.Drawing.Point(223, 250);
            this.prenomVal.Name = "prenomVal";
            this.prenomVal.Size = new System.Drawing.Size(92, 72);
            this.prenomVal.TabIndex = 9;
            this.prenomVal.Text = "{Prénom}";
            // 
            // adresseVal
            // 
            this.adresseVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.adresseVal.AutoSize = true;
            this.adresseVal.ForeColor = System.Drawing.Color.Black;
            this.adresseVal.Location = new System.Drawing.Point(223, 322);
            this.adresseVal.Name = "adresseVal";
            this.adresseVal.Size = new System.Drawing.Size(94, 72);
            this.adresseVal.TabIndex = 10;
            this.adresseVal.Text = "{Adresse}";
            // 
            // coeffNotVal
            // 
            this.coeffNotVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.coeffNotVal.AutoSize = true;
            this.coeffNotVal.ForeColor = System.Drawing.Color.Black;
            this.coeffNotVal.Location = new System.Drawing.Point(223, 466);
            this.coeffNotVal.Name = "coeffNotVal";
            this.coeffNotVal.Size = new System.Drawing.Size(240, 72);
            this.coeffNotVal.TabIndex = 11;
            this.coeffNotVal.Text = "{Coefficient de notoriété}";
            // 
            // lieuExerciceVal
            // 
            this.lieuExerciceVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lieuExerciceVal.AutoSize = true;
            this.lieuExerciceVal.ForeColor = System.Drawing.Color.Black;
            this.lieuExerciceVal.Location = new System.Drawing.Point(223, 538);
            this.lieuExerciceVal.Name = "lieuExerciceVal";
            this.lieuExerciceVal.Size = new System.Drawing.Size(158, 72);
            this.lieuExerciceVal.TabIndex = 13;
            this.lieuExerciceVal.Text = "{Lieu d\'exercice}";
            // 
            // villeVal
            // 
            this.villeVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.villeVal.AutoSize = true;
            this.villeVal.ForeColor = System.Drawing.Color.Black;
            this.villeVal.Location = new System.Drawing.Point(223, 394);
            this.villeVal.Name = "villeVal";
            this.villeVal.Size = new System.Drawing.Size(113, 72);
            this.villeVal.TabIndex = 12;
            this.villeVal.Text = "{CP et Ville}";
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.White;
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
            this.mainContainer.Panel2.Controls.Add(this.selecPratPanel);
            this.mainContainer.Size = new System.Drawing.Size(962, 717);
            this.mainContainer.SplitterDistance = 647;
            this.mainContainer.TabIndex = 1;
            this.mainContainer.TabStop = false;
            // 
            // selecPratPanel
            // 
            this.selecPratPanel.Controls.Add(this.selecBtn);
            this.selecPratPanel.Controls.Add(this.retourBtn);
            this.selecPratPanel.Controls.Add(this.pratSuivBtn);
            this.selecPratPanel.Controls.Add(this.pratSelecComboBox);
            this.selecPratPanel.Controls.Add(this.pratPrecBtn);
            this.selecPratPanel.Controls.Add(this.pratSelecLabel);
            this.selecPratPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecPratPanel.Location = new System.Drawing.Point(19, 220);
            this.selecPratPanel.Name = "selecPratPanel";
            this.selecPratPanel.Size = new System.Drawing.Size(273, 276);
            this.selecPratPanel.TabIndex = 23;
            // 
            // selecBtn
            // 
            this.selecBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selecBtn.BackColor = System.Drawing.Color.White;
            this.selecBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selecBtn.FlatAppearance.BorderSize = 0;
            this.selecBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.selecBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.selecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selecBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.selecBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecBtn.ForeColor = System.Drawing.Color.Black;
            this.selecBtn.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.selecBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.selecBtn.IconSize = 30;
            this.selecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selecBtn.Location = new System.Drawing.Point(0, 225);
            this.selecBtn.Name = "selecBtn";
            this.selecBtn.Rotation = 0D;
            this.selecBtn.Size = new System.Drawing.Size(150, 51);
            this.selecBtn.TabIndex = 26;
            this.selecBtn.Text = " Sélectionner";
            this.selecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.selecBtn, "Sélectionner ce praticien et revenir au formulaire précédent.");
            this.selecBtn.UseVisualStyleBackColor = false;
            this.selecBtn.Visible = false;
            this.selecBtn.Click += new System.EventHandler(this.selecBtn_Click);
            // 
            // retourBtn
            // 
            this.retourBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.retourBtn.BackColor = System.Drawing.Color.White;
            this.retourBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retourBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.retourBtn.FlatAppearance.BorderSize = 0;
            this.retourBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.retourBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.retourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retourBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.retourBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retourBtn.ForeColor = System.Drawing.Color.Black;
            this.retourBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.retourBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.retourBtn.IconSize = 30;
            this.retourBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.retourBtn.Location = new System.Drawing.Point(156, 225);
            this.retourBtn.Name = "retourBtn";
            this.retourBtn.Rotation = 0D;
            this.retourBtn.Size = new System.Drawing.Size(117, 51);
            this.retourBtn.TabIndex = 25;
            this.retourBtn.Text = "   Retour";
            this.retourBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.retourBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.retourBtn, "Revenir au formulaire précédent.");
            this.retourBtn.UseVisualStyleBackColor = false;
            this.retourBtn.Visible = false;
            // 
            // pratSuivBtn
            // 
            this.pratSuivBtn.BackColor = System.Drawing.Color.White;
            this.pratSuivBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pratSuivBtn.FlatAppearance.BorderSize = 0;
            this.pratSuivBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.pratSuivBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.pratSuivBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pratSuivBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.pratSuivBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pratSuivBtn.ForeColor = System.Drawing.Color.Black;
            this.pratSuivBtn.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.pratSuivBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.pratSuivBtn.IconSize = 40;
            this.pratSuivBtn.Location = new System.Drawing.Point(138, 89);
            this.pratSuivBtn.Name = "pratSuivBtn";
            this.pratSuivBtn.Rotation = 0D;
            this.pratSuivBtn.Size = new System.Drawing.Size(135, 51);
            this.pratSuivBtn.TabIndex = 24;
            this.pratSuivBtn.Text = "   Suiv.";
            this.pratSuivBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.monToolTip.SetToolTip(this.pratSuivBtn, "Aller au praticien suivant.");
            this.pratSuivBtn.UseVisualStyleBackColor = false;
            this.pratSuivBtn.Click += new System.EventHandler(this.pratSuivBtn_Click);
            // 
            // pratSelecComboBox
            // 
            this.pratSelecComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pratSelecComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pratSelecComboBox.BackColor = System.Drawing.Color.White;
            this.pratSelecComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pratSelecComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pratSelecComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pratSelecComboBox.ForeColor = System.Drawing.Color.Black;
            this.pratSelecComboBox.FormattingEnabled = true;
            this.pratSelecComboBox.Location = new System.Drawing.Point(0, 26);
            this.pratSelecComboBox.Name = "pratSelecComboBox";
            this.pratSelecComboBox.Size = new System.Drawing.Size(273, 29);
            this.pratSelecComboBox.TabIndex = 3;
            this.monToolTip.SetToolTip(this.pratSelecComboBox, "Sélectionner un praticien.");
            this.pratSelecComboBox.SelectionChangeCommitted += new System.EventHandler(this.pratSelecComboBox_SelectionChangeCommitted);
            // 
            // pratPrecBtn
            // 
            this.pratPrecBtn.BackColor = System.Drawing.Color.White;
            this.pratPrecBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pratPrecBtn.FlatAppearance.BorderSize = 0;
            this.pratPrecBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.pratPrecBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.pratPrecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pratPrecBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.pratPrecBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pratPrecBtn.ForeColor = System.Drawing.Color.Black;
            this.pratPrecBtn.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.pratPrecBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.pratPrecBtn.IconSize = 40;
            this.pratPrecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pratPrecBtn.Location = new System.Drawing.Point(0, 89);
            this.pratPrecBtn.Name = "pratPrecBtn";
            this.pratPrecBtn.Rotation = 0D;
            this.pratPrecBtn.Size = new System.Drawing.Size(135, 51);
            this.pratPrecBtn.TabIndex = 23;
            this.pratPrecBtn.Text = "   Préc.";
            this.pratPrecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pratPrecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.pratPrecBtn, "Aller au praticien précédent.");
            this.pratPrecBtn.UseVisualStyleBackColor = false;
            this.pratPrecBtn.Click += new System.EventHandler(this.pratPrecBtn_Click);
            // 
            // pratSelecLabel
            // 
            this.pratSelecLabel.AutoSize = true;
            this.pratSelecLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pratSelecLabel.Location = new System.Drawing.Point(0, 0);
            this.pratSelecLabel.Name = "pratSelecLabel";
            this.pratSelecLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pratSelecLabel.Size = new System.Drawing.Size(166, 26);
            this.pratSelecLabel.TabIndex = 2;
            this.pratSelecLabel.Text = "Trouver un praticien";
            // 
            // monToolTip
            // 
            this.monToolTip.BackColor = System.Drawing.Color.White;
            this.monToolTip.ForeColor = System.Drawing.Color.Black;
            this.monToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // PraticiensForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.retourBtn;
            this.ClientSize = new System.Drawing.Size(962, 717);
            this.ControlBox = false;
            this.Controls.Add(this.mainContainer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "PraticiensForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GSB SwissVisite - Annuaire des praticiens";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.selecPratPanel.ResumeLayout(false);
            this.selecPratPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label villeLabel;
        private System.Windows.Forms.Label coeffNotLabel;
        private System.Windows.Forms.Label lieuExerciceLabel;
        private System.Windows.Forms.Label adresseLabel;
        private System.Windows.Forms.Label idVal;
        private System.Windows.Forms.Label nomVal;
        private System.Windows.Forms.Label prenomVal;
        private System.Windows.Forms.Label adresseVal;
        private System.Windows.Forms.Label villeVal;
        private System.Windows.Forms.Label coeffNotVal;
        private System.Windows.Forms.Label lieuExerciceVal;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.Panel selecPratPanel;
        private FontAwesome.Sharp.IconButton retourBtn;
        private FontAwesome.Sharp.IconButton selecBtn;
        private System.Windows.Forms.ToolTip monToolTip;
        private FontAwesome.Sharp.IconButton pratSuivBtn;
        private System.Windows.Forms.ComboBox pratSelecComboBox;
        private FontAwesome.Sharp.IconButton pratPrecBtn;
        private System.Windows.Forms.Label pratSelecLabel;
    }
}