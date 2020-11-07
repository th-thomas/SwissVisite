namespace SwissVisite.Forms
{
    partial class NouveauRapportForm
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
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.motifVal = new System.Windows.Forms.TextBox();
            this.bilanVal = new System.Windows.Forms.TextBox();
            this.pratLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.motifLabel = new System.Windows.Forms.Label();
            this.bilanLabel = new System.Windows.Forms.Label();
            this.pratDetailsBtn = new FontAwesome.Sharp.IconButton();
            this.pratVal = new System.Windows.Forms.ComboBox();
            this.dateVal = new System.Windows.Forms.DateTimePicker();
            this.dateAujCheckBox = new System.Windows.Forms.CheckBox();
            this.panelDroiteSplit = new System.Windows.Forms.SplitContainer();
            this.ajouterEchantBtn = new FontAwesome.Sharp.IconButton();
            this.nombreEchantVal = new System.Windows.Forms.NumericUpDown();
            this.nombreEchantLabel = new System.Windows.Forms.Label();
            this.supprimerEchantBtn = new FontAwesome.Sharp.IconButton();
            this.medicLabel = new System.Windows.Forms.Label();
            this.medicVal = new System.Windows.Forms.ComboBox();
            this.echantLabel = new System.Windows.Forms.Label();
            this.subPanelDroite = new System.Windows.Forms.SplitContainer();
            this.echantPanel = new System.Windows.Forms.Panel();
            this.echantListView = new System.Windows.Forms.ListView();
            this.medicCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nvEnregPanel = new System.Windows.Forms.Panel();
            this.enregistrerBtn = new FontAwesome.Sharp.IconButton();
            this.annulerBtn = new FontAwesome.Sharp.IconButton();
            this.monToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDroiteSplit)).BeginInit();
            this.panelDroiteSplit.Panel1.SuspendLayout();
            this.panelDroiteSplit.Panel2.SuspendLayout();
            this.panelDroiteSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nombreEchantVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subPanelDroite)).BeginInit();
            this.subPanelDroite.Panel1.SuspendLayout();
            this.subPanelDroite.Panel2.SuspendLayout();
            this.subPanelDroite.SuspendLayout();
            this.echantPanel.SuspendLayout();
            this.nvEnregPanel.SuspendLayout();
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
            this.mainContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.mainContainer.Panel2.Controls.Add(this.panelDroiteSplit);
            this.mainContainer.Size = new System.Drawing.Size(962, 717);
            this.mainContainer.SplitterDistance = 648;
            this.mainContainer.TabIndex = 3;
            this.mainContainer.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 6;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.mainPanel.Controls.Add(this.motifVal, 3, 3);
            this.mainPanel.Controls.Add(this.bilanVal, 3, 5);
            this.mainPanel.Controls.Add(this.pratLabel, 1, 1);
            this.mainPanel.Controls.Add(this.dateLabel, 1, 2);
            this.mainPanel.Controls.Add(this.motifLabel, 1, 3);
            this.mainPanel.Controls.Add(this.bilanLabel, 1, 5);
            this.mainPanel.Controls.Add(this.pratDetailsBtn, 4, 1);
            this.mainPanel.Controls.Add(this.pratVal, 3, 1);
            this.mainPanel.Controls.Add(this.dateVal, 3, 2);
            this.mainPanel.Controls.Add(this.dateAujCheckBox, 4, 2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 9;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Size = new System.Drawing.Size(648, 717);
            this.mainPanel.TabIndex = 0;
            // 
            // motifVal
            // 
            this.motifVal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.motifVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainPanel.SetColumnSpan(this.motifVal, 2);
            this.motifVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motifVal.ForeColor = System.Drawing.Color.Black;
            this.motifVal.Location = new System.Drawing.Point(200, 299);
            this.motifVal.Multiline = true;
            this.motifVal.Name = "motifVal";
            this.motifVal.Size = new System.Drawing.Size(424, 97);
            this.motifVal.TabIndex = 1;
            this.motifVal.Text = "Saisissez ici le motif de la visite...";
            this.motifVal.Enter += new System.EventHandler(this.motifVal_Enter);
            this.motifVal.Leave += new System.EventHandler(this.motifVal_Leave);
            // 
            // bilanVal
            // 
            this.bilanVal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bilanVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainPanel.SetColumnSpan(this.bilanVal, 2);
            this.bilanVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bilanVal.ForeColor = System.Drawing.Color.Black;
            this.bilanVal.Location = new System.Drawing.Point(200, 422);
            this.bilanVal.Multiline = true;
            this.bilanVal.Name = "bilanVal";
            this.mainPanel.SetRowSpan(this.bilanVal, 2);
            this.bilanVal.Size = new System.Drawing.Size(424, 190);
            this.bilanVal.TabIndex = 2;
            this.bilanVal.Text = "Saisissez ici le bilan de la visite...";
            this.bilanVal.Enter += new System.EventHandler(this.bilanVal_Enter);
            this.bilanVal.Leave += new System.EventHandler(this.bilanVal_Leave);
            // 
            // pratLabel
            // 
            this.pratLabel.AutoSize = true;
            this.pratLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pratLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pratLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.pratLabel.Location = new System.Drawing.Point(43, 102);
            this.pratLabel.Name = "pratLabel";
            this.pratLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 75);
            this.pratLabel.Size = new System.Drawing.Size(131, 97);
            this.pratLabel.TabIndex = 1;
            this.pratLabel.Text = "Praticien";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.dateLabel.Location = new System.Drawing.Point(43, 199);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 75);
            this.dateLabel.Size = new System.Drawing.Size(131, 97);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date rapport";
            // 
            // motifLabel
            // 
            this.motifLabel.AutoSize = true;
            this.motifLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motifLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motifLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.motifLabel.Location = new System.Drawing.Point(43, 296);
            this.motifLabel.Name = "motifLabel";
            this.motifLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 75);
            this.motifLabel.Size = new System.Drawing.Size(131, 103);
            this.motifLabel.TabIndex = 3;
            this.motifLabel.Text = "Motif";
            // 
            // bilanLabel
            // 
            this.bilanLabel.AutoSize = true;
            this.bilanLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bilanLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bilanLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.bilanLabel.Location = new System.Drawing.Point(43, 419);
            this.bilanLabel.Name = "bilanLabel";
            this.bilanLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.bilanLabel.Size = new System.Drawing.Size(131, 72);
            this.bilanLabel.TabIndex = 4;
            this.bilanLabel.Text = "Bilan";
            // 
            // pratDetailsBtn
            // 
            this.pratDetailsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pratDetailsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pratDetailsBtn.Enabled = false;
            this.pratDetailsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pratDetailsBtn.FlatAppearance.BorderSize = 0;
            this.pratDetailsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.pratDetailsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.pratDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pratDetailsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.pratDetailsBtn.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.pratDetailsBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.pratDetailsBtn.IconSize = 40;
            this.pratDetailsBtn.Location = new System.Drawing.Point(544, 105);
            this.pratDetailsBtn.Name = "pratDetailsBtn";
            this.pratDetailsBtn.Rotation = 0D;
            this.pratDetailsBtn.Size = new System.Drawing.Size(80, 30);
            this.pratDetailsBtn.TabIndex = 20;
            this.pratDetailsBtn.TabStop = false;
            this.monToolTip.SetToolTip(this.pratDetailsBtn, "Afficher les informations détaillées sur le praticien sélectionné.");
            this.pratDetailsBtn.UseVisualStyleBackColor = true;
            this.pratDetailsBtn.Click += new System.EventHandler(this.pratDetailsBtn_Click);
            // 
            // pratVal
            // 
            this.pratVal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pratVal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pratVal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pratVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pratVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pratVal.ForeColor = System.Drawing.Color.Black;
            this.pratVal.FormattingEnabled = true;
            this.pratVal.Location = new System.Drawing.Point(200, 105);
            this.pratVal.Name = "pratVal";
            this.pratVal.Size = new System.Drawing.Size(338, 30);
            this.pratVal.TabIndex = 0;
            this.pratVal.Text = "{Praticien}";
            this.pratVal.SelectionChangeCommitted += new System.EventHandler(this.pratVal_SelectionChangeCommitted);
            // 
            // dateVal
            // 
            this.dateVal.CalendarForeColor = System.Drawing.Color.Black;
            this.dateVal.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateVal.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateVal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateVal.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateVal.Enabled = false;
            this.dateVal.Location = new System.Drawing.Point(200, 202);
            this.dateVal.MaxDate = new System.DateTime(2222, 12, 31, 0, 0, 0, 0);
            this.dateVal.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateVal.Name = "dateVal";
            this.dateVal.Size = new System.Drawing.Size(338, 31);
            this.dateVal.TabIndex = 21;
            this.dateVal.TabStop = false;
            this.dateVal.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dateAujCheckBox
            // 
            this.dateAujCheckBox.AutoSize = true;
            this.dateAujCheckBox.Checked = true;
            this.dateAujCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dateAujCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateAujCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateAujCheckBox.Location = new System.Drawing.Point(544, 202);
            this.dateAujCheckBox.Name = "dateAujCheckBox";
            this.dateAujCheckBox.Size = new System.Drawing.Size(80, 26);
            this.dateAujCheckBox.TabIndex = 22;
            this.dateAujCheckBox.TabStop = false;
            this.dateAujCheckBox.Text = "Auj.";
            this.monToolTip.SetToolTip(this.dateAujCheckBox, "Date d\'aujourd\'hui. Décocher pour une date personnalisée");
            this.dateAujCheckBox.UseVisualStyleBackColor = true;
            this.dateAujCheckBox.CheckedChanged += new System.EventHandler(this.dateAujCheckBox_CheckedChanged);
            // 
            // panelDroiteSplit
            // 
            this.panelDroiteSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDroiteSplit.IsSplitterFixed = true;
            this.panelDroiteSplit.Location = new System.Drawing.Point(0, 0);
            this.panelDroiteSplit.Name = "panelDroiteSplit";
            this.panelDroiteSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // panelDroiteSplit.Panel1
            // 
            this.panelDroiteSplit.Panel1.BackColor = System.Drawing.Color.White;
            this.panelDroiteSplit.Panel1.Controls.Add(this.ajouterEchantBtn);
            this.panelDroiteSplit.Panel1.Controls.Add(this.nombreEchantVal);
            this.panelDroiteSplit.Panel1.Controls.Add(this.nombreEchantLabel);
            this.panelDroiteSplit.Panel1.Controls.Add(this.supprimerEchantBtn);
            this.panelDroiteSplit.Panel1.Controls.Add(this.medicLabel);
            this.panelDroiteSplit.Panel1.Controls.Add(this.medicVal);
            this.panelDroiteSplit.Panel1.Controls.Add(this.echantLabel);
            this.panelDroiteSplit.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            // 
            // panelDroiteSplit.Panel2
            // 
            this.panelDroiteSplit.Panel2.BackColor = System.Drawing.Color.White;
            this.panelDroiteSplit.Panel2.Controls.Add(this.subPanelDroite);
            this.panelDroiteSplit.Size = new System.Drawing.Size(310, 717);
            this.panelDroiteSplit.SplitterDistance = 209;
            this.panelDroiteSplit.TabIndex = 1;
            this.panelDroiteSplit.TabStop = false;
            // 
            // ajouterEchantBtn
            // 
            this.ajouterEchantBtn.BackColor = System.Drawing.Color.White;
            this.ajouterEchantBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ajouterEchantBtn.Enabled = false;
            this.ajouterEchantBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ajouterEchantBtn.FlatAppearance.BorderSize = 0;
            this.ajouterEchantBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.ajouterEchantBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ajouterEchantBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouterEchantBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ajouterEchantBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterEchantBtn.ForeColor = System.Drawing.Color.Black;
            this.ajouterEchantBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ajouterEchantBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.ajouterEchantBtn.IconSize = 30;
            this.ajouterEchantBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ajouterEchantBtn.Location = new System.Drawing.Point(220, 179);
            this.ajouterEchantBtn.Name = "ajouterEchantBtn";
            this.ajouterEchantBtn.Rotation = 0D;
            this.ajouterEchantBtn.Size = new System.Drawing.Size(46, 27);
            this.ajouterEchantBtn.TabIndex = 30;
            this.ajouterEchantBtn.TabStop = false;
            this.ajouterEchantBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ajouterEchantBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.ajouterEchantBtn, "Ajouter l\'échantillon. Un médicament doit être renseigné avec un nombre d\'échanti" +
        "llons supérieur à 0.");
            this.ajouterEchantBtn.UseVisualStyleBackColor = false;
            this.ajouterEchantBtn.Click += new System.EventHandler(this.ajouterEchantBtn_Click);
            // 
            // nombreEchantVal
            // 
            this.nombreEchantVal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nombreEchantVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreEchantVal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nombreEchantVal.ForeColor = System.Drawing.Color.Black;
            this.nombreEchantVal.Location = new System.Drawing.Point(0, 156);
            this.nombreEchantVal.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nombreEchantVal.Name = "nombreEchantVal";
            this.nombreEchantVal.Size = new System.Drawing.Size(148, 27);
            this.nombreEchantVal.TabIndex = 4;
            this.nombreEchantVal.ValueChanged += new System.EventHandler(this.nombreEchantVal_ValueChanged);
            // 
            // nombreEchantLabel
            // 
            this.nombreEchantLabel.AutoSize = true;
            this.nombreEchantLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nombreEchantLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEchantLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.nombreEchantLabel.Location = new System.Drawing.Point(-4, 132);
            this.nombreEchantLabel.Name = "nombreEchantLabel";
            this.nombreEchantLabel.Size = new System.Drawing.Size(184, 21);
            this.nombreEchantLabel.TabIndex = 28;
            this.nombreEchantLabel.Text = "Nombre d\'échantillons";
            // 
            // supprimerEchantBtn
            // 
            this.supprimerEchantBtn.BackColor = System.Drawing.Color.White;
            this.supprimerEchantBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supprimerEchantBtn.Enabled = false;
            this.supprimerEchantBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.supprimerEchantBtn.FlatAppearance.BorderSize = 0;
            this.supprimerEchantBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.supprimerEchantBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.supprimerEchantBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerEchantBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.supprimerEchantBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimerEchantBtn.ForeColor = System.Drawing.Color.Black;
            this.supprimerEchantBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.supprimerEchantBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.supprimerEchantBtn.IconSize = 30;
            this.supprimerEchantBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supprimerEchantBtn.Location = new System.Drawing.Point(254, 179);
            this.supprimerEchantBtn.Name = "supprimerEchantBtn";
            this.supprimerEchantBtn.Rotation = 0D;
            this.supprimerEchantBtn.Size = new System.Drawing.Size(46, 27);
            this.supprimerEchantBtn.TabIndex = 27;
            this.supprimerEchantBtn.TabStop = false;
            this.supprimerEchantBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.supprimerEchantBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.supprimerEchantBtn, "Supprimer l\'échantillon sélectionné");
            this.supprimerEchantBtn.UseVisualStyleBackColor = false;
            this.supprimerEchantBtn.Click += new System.EventHandler(this.supprimerEchantBtn_Click);
            // 
            // medicLabel
            // 
            this.medicLabel.AutoSize = true;
            this.medicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.medicLabel.Location = new System.Drawing.Point(-4, 64);
            this.medicLabel.Name = "medicLabel";
            this.medicLabel.Size = new System.Drawing.Size(185, 21);
            this.medicLabel.TabIndex = 3;
            this.medicLabel.Text = "Médicament présenté";
            // 
            // medicVal
            // 
            this.medicVal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.medicVal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.medicVal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medicVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicVal.ForeColor = System.Drawing.Color.Black;
            this.medicVal.FormattingEnabled = true;
            this.medicVal.Location = new System.Drawing.Point(0, 89);
            this.medicVal.Name = "medicVal";
            this.medicVal.Size = new System.Drawing.Size(300, 30);
            this.medicVal.TabIndex = 3;
            this.medicVal.Text = "{Médicament}";
            this.medicVal.SelectionChangeCommitted += new System.EventHandler(this.medicVal_SelectionChangeCommitted);
            this.medicVal.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.medicVal_Format);
            // 
            // echantLabel
            // 
            this.echantLabel.AutoSize = true;
            this.echantLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.echantLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.echantLabel.Location = new System.Drawing.Point(-4, 9);
            this.echantLabel.Name = "echantLabel";
            this.echantLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.echantLabel.Size = new System.Drawing.Size(187, 42);
            this.echantLabel.TabIndex = 1;
            this.echantLabel.Text = "Offre d\'échantillons";
            // 
            // subPanelDroite
            // 
            this.subPanelDroite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subPanelDroite.Location = new System.Drawing.Point(0, 0);
            this.subPanelDroite.Name = "subPanelDroite";
            this.subPanelDroite.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // subPanelDroite.Panel1
            // 
            this.subPanelDroite.Panel1.Controls.Add(this.echantPanel);
            // 
            // subPanelDroite.Panel2
            // 
            this.subPanelDroite.Panel2.Controls.Add(this.nvEnregPanel);
            this.subPanelDroite.Size = new System.Drawing.Size(310, 504);
            this.subPanelDroite.SplitterDistance = 355;
            this.subPanelDroite.TabIndex = 25;
            this.subPanelDroite.TabStop = false;
            // 
            // echantPanel
            // 
            this.echantPanel.BackColor = System.Drawing.Color.White;
            this.echantPanel.Controls.Add(this.echantListView);
            this.echantPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.echantPanel.Location = new System.Drawing.Point(0, 0);
            this.echantPanel.Name = "echantPanel";
            this.echantPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.echantPanel.Size = new System.Drawing.Size(310, 355);
            this.echantPanel.TabIndex = 24;
            // 
            // echantListView
            // 
            this.echantListView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.echantListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.echantListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.medicCol,
            this.nombreCol});
            this.echantListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.echantListView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.echantListView.ForeColor = System.Drawing.Color.Black;
            this.echantListView.FullRowSelect = true;
            this.echantListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.echantListView.HideSelection = false;
            this.echantListView.Location = new System.Drawing.Point(0, 0);
            this.echantListView.MultiSelect = false;
            this.echantListView.Name = "echantListView";
            this.echantListView.Size = new System.Drawing.Size(300, 345);
            this.echantListView.TabIndex = 0;
            this.echantListView.TabStop = false;
            this.echantListView.UseCompatibleStateImageBehavior = false;
            this.echantListView.View = System.Windows.Forms.View.Details;
            this.echantListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.echantListView_ItemSelectionChanged);
            // 
            // medicCol
            // 
            this.medicCol.Text = "Médicament";
            this.medicCol.Width = 190;
            // 
            // nombreCol
            // 
            this.nombreCol.Text = "Nb. échant.";
            this.nombreCol.Width = 106;
            // 
            // nvEnregPanel
            // 
            this.nvEnregPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.nvEnregPanel.Controls.Add(this.enregistrerBtn);
            this.nvEnregPanel.Controls.Add(this.annulerBtn);
            this.nvEnregPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvEnregPanel.Location = new System.Drawing.Point(0, 0);
            this.nvEnregPanel.Name = "nvEnregPanel";
            this.nvEnregPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.nvEnregPanel.Size = new System.Drawing.Size(310, 145);
            this.nvEnregPanel.TabIndex = 27;
            // 
            // enregistrerBtn
            // 
            this.enregistrerBtn.BackColor = System.Drawing.Color.White;
            this.enregistrerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enregistrerBtn.Enabled = false;
            this.enregistrerBtn.FlatAppearance.BorderSize = 0;
            this.enregistrerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.enregistrerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.enregistrerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrerBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.enregistrerBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrerBtn.ForeColor = System.Drawing.Color.Black;
            this.enregistrerBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.enregistrerBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.enregistrerBtn.IconSize = 30;
            this.enregistrerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enregistrerBtn.Location = new System.Drawing.Point(12, 47);
            this.enregistrerBtn.Name = "enregistrerBtn";
            this.enregistrerBtn.Rotation = 0D;
            this.enregistrerBtn.Size = new System.Drawing.Size(140, 51);
            this.enregistrerBtn.TabIndex = 5;
            this.enregistrerBtn.TabStop = false;
            this.enregistrerBtn.Text = " Enregistrer";
            this.enregistrerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enregistrerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.enregistrerBtn, "Sauvegarder le compte-rendu.");
            this.enregistrerBtn.UseVisualStyleBackColor = false;
            this.enregistrerBtn.Click += new System.EventHandler(this.enregistrerBtn_Click);
            // 
            // annulerBtn
            // 
            this.annulerBtn.BackColor = System.Drawing.Color.White;
            this.annulerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.annulerBtn.FlatAppearance.BorderSize = 0;
            this.annulerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.annulerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.annulerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annulerBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.annulerBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annulerBtn.ForeColor = System.Drawing.Color.Black;
            this.annulerBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.annulerBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.annulerBtn.IconSize = 30;
            this.annulerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.annulerBtn.Location = new System.Drawing.Point(158, 47);
            this.annulerBtn.Name = "annulerBtn";
            this.annulerBtn.Rotation = 0D;
            this.annulerBtn.Size = new System.Drawing.Size(140, 51);
            this.annulerBtn.TabIndex = 6;
            this.annulerBtn.TabStop = false;
            this.annulerBtn.Text = "   Annuler";
            this.annulerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.annulerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.annulerBtn, "Revenir à l\'affichage des comptes-rendus existants, sans enregistrer les modifica" +
        "tions.");
            this.annulerBtn.UseVisualStyleBackColor = false;
            this.annulerBtn.Click += new System.EventHandler(this.annulerBtn_Click);
            // 
            // monToolTip
            // 
            this.monToolTip.BackColor = System.Drawing.Color.White;
            this.monToolTip.ForeColor = System.Drawing.Color.Black;
            this.monToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // NouveauRapportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 717);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "NouveauRapportForm";
            this.Text = "RapportsForm";
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panelDroiteSplit.Panel1.ResumeLayout(false);
            this.panelDroiteSplit.Panel1.PerformLayout();
            this.panelDroiteSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelDroiteSplit)).EndInit();
            this.panelDroiteSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nombreEchantVal)).EndInit();
            this.subPanelDroite.Panel1.ResumeLayout(false);
            this.subPanelDroite.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subPanelDroite)).EndInit();
            this.subPanelDroite.ResumeLayout(false);
            this.echantPanel.ResumeLayout(false);
            this.nvEnregPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Label pratLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label motifLabel;
        private System.Windows.Forms.Label bilanLabel;
        private System.Windows.Forms.TextBox bilanVal;
        private System.Windows.Forms.TextBox motifVal;
        private System.Windows.Forms.ComboBox pratVal;
        private System.Windows.Forms.Panel echantPanel;
        private System.Windows.Forms.Label echantLabel;
        private System.Windows.Forms.ToolTip monToolTip;
        private System.Windows.Forms.SplitContainer panelDroiteSplit;
        private System.Windows.Forms.SplitContainer subPanelDroite;
        private FontAwesome.Sharp.IconButton pratDetailsBtn;
        private System.Windows.Forms.Panel nvEnregPanel;
        private FontAwesome.Sharp.IconButton enregistrerBtn;
        private FontAwesome.Sharp.IconButton annulerBtn;
        private FontAwesome.Sharp.IconButton supprimerEchantBtn;
        private System.Windows.Forms.ComboBox medicVal;
        private System.Windows.Forms.Label medicLabel;
        private System.Windows.Forms.NumericUpDown nombreEchantVal;
        private System.Windows.Forms.Label nombreEchantLabel;
        private System.Windows.Forms.ListView echantListView;
        private System.Windows.Forms.ColumnHeader medicCol;
        private System.Windows.Forms.ColumnHeader nombreCol;
        private FontAwesome.Sharp.IconButton ajouterEchantBtn;
        private System.Windows.Forms.DateTimePicker dateVal;
        private System.Windows.Forms.CheckBox dateAujCheckBox;
    }
}