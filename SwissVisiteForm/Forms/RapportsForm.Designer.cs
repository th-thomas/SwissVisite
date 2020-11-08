namespace SwissVisiteForm.Forms
{
    partial class RapportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RapportsForm));
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pratVal = new System.Windows.Forms.Label();
            this.dateVal = new System.Windows.Forms.Label();
            this.motifVal = new System.Windows.Forms.TextBox();
            this.bilanVal = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.pratLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.motifLabel = new System.Windows.Forms.Label();
            this.bilanLabel = new System.Windows.Forms.Label();
            this.idVal = new System.Windows.Forms.Label();
            this.pratDetailsBtn = new FontAwesome.Sharp.IconButton();
            this.panelDroiteSplit = new System.Windows.Forms.SplitContainer();
            this.echantPanel = new System.Windows.Forms.Panel();
            this.echantListView = new System.Windows.Forms.ListView();
            this.medicCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.echantLabel = new System.Windows.Forms.Label();
            this.subPanelDroite = new System.Windows.Forms.SplitContainer();
            this.rapportSelecLabel = new System.Windows.Forms.Label();
            this.rappPrecBtn = new FontAwesome.Sharp.IconButton();
            this.rapportSelecComboBox = new System.Windows.Forms.ComboBox();
            this.rappSuivBtn = new FontAwesome.Sharp.IconButton();
            this.nouveauBtn = new FontAwesome.Sharp.IconButton();
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
            this.echantPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subPanelDroite)).BeginInit();
            this.subPanelDroite.Panel1.SuspendLayout();
            this.subPanelDroite.Panel2.SuspendLayout();
            this.subPanelDroite.SuspendLayout();
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
            this.mainContainer.TabIndex = 4;
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
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.mainPanel.Controls.Add(this.pratVal, 3, 2);
            this.mainPanel.Controls.Add(this.dateVal, 3, 3);
            this.mainPanel.Controls.Add(this.motifVal, 3, 4);
            this.mainPanel.Controls.Add(this.bilanVal, 3, 5);
            this.mainPanel.Controls.Add(this.idLabel, 1, 1);
            this.mainPanel.Controls.Add(this.pratLabel, 1, 2);
            this.mainPanel.Controls.Add(this.dateLabel, 1, 3);
            this.mainPanel.Controls.Add(this.motifLabel, 1, 4);
            this.mainPanel.Controls.Add(this.bilanLabel, 1, 5);
            this.mainPanel.Controls.Add(this.idVal, 3, 1);
            this.mainPanel.Controls.Add(this.pratDetailsBtn, 4, 2);
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
            this.mainPanel.Size = new System.Drawing.Size(648, 717);
            this.mainPanel.TabIndex = 0;
            // 
            // pratVal
            // 
            this.pratVal.AutoSize = true;
            this.pratVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pratVal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pratVal.ForeColor = System.Drawing.Color.Black;
            this.pratVal.Location = new System.Drawing.Point(200, 159);
            this.pratVal.Name = "pratVal";
            this.pratVal.Size = new System.Drawing.Size(325, 97);
            this.pratVal.TabIndex = 22;
            this.pratVal.Text = "{Praticien}";
            // 
            // dateVal
            // 
            this.dateVal.AutoSize = true;
            this.dateVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateVal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateVal.ForeColor = System.Drawing.Color.Black;
            this.dateVal.Location = new System.Drawing.Point(200, 256);
            this.dateVal.Name = "dateVal";
            this.dateVal.Size = new System.Drawing.Size(325, 97);
            this.dateVal.TabIndex = 21;
            this.dateVal.Text = "{Date}";
            // 
            // motifVal
            // 
            this.motifVal.BackColor = System.Drawing.Color.White;
            this.motifVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainPanel.SetColumnSpan(this.motifVal, 2);
            this.motifVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motifVal.ForeColor = System.Drawing.Color.Black;
            this.motifVal.Location = new System.Drawing.Point(200, 356);
            this.motifVal.Multiline = true;
            this.motifVal.Name = "motifVal";
            this.motifVal.ReadOnly = true;
            this.motifVal.Size = new System.Drawing.Size(407, 99);
            this.motifVal.TabIndex = 0;
            this.motifVal.TabStop = false;
            this.motifVal.Text = "{Motif}";
            // 
            // bilanVal
            // 
            this.bilanVal.BackColor = System.Drawing.Color.White;
            this.bilanVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainPanel.SetColumnSpan(this.bilanVal, 2);
            this.bilanVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bilanVal.ForeColor = System.Drawing.Color.Black;
            this.bilanVal.Location = new System.Drawing.Point(200, 461);
            this.bilanVal.Multiline = true;
            this.bilanVal.Name = "bilanVal";
            this.bilanVal.ReadOnly = true;
            this.mainPanel.SetRowSpan(this.bilanVal, 2);
            this.bilanVal.Size = new System.Drawing.Size(407, 190);
            this.bilanVal.TabIndex = 1;
            this.bilanVal.TabStop = false;
            this.bilanVal.Text = "{Bilan}";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.idLabel.Location = new System.Drawing.Point(43, 62);
            this.idLabel.Name = "idLabel";
            this.idLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 75);
            this.idLabel.Size = new System.Drawing.Size(131, 97);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "N° rapport";
            // 
            // pratLabel
            // 
            this.pratLabel.AutoSize = true;
            this.pratLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pratLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pratLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.pratLabel.Location = new System.Drawing.Point(43, 159);
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
            this.dateLabel.Location = new System.Drawing.Point(43, 256);
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
            this.motifLabel.Location = new System.Drawing.Point(43, 353);
            this.motifLabel.Name = "motifLabel";
            this.motifLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 75);
            this.motifLabel.Size = new System.Drawing.Size(131, 105);
            this.motifLabel.TabIndex = 3;
            this.motifLabel.Text = "Motif";
            // 
            // bilanLabel
            // 
            this.bilanLabel.AutoSize = true;
            this.bilanLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bilanLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bilanLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.bilanLabel.Location = new System.Drawing.Point(43, 458);
            this.bilanLabel.Name = "bilanLabel";
            this.bilanLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.bilanLabel.Size = new System.Drawing.Size(131, 72);
            this.bilanLabel.TabIndex = 4;
            this.bilanLabel.Text = "Bilan";
            // 
            // idVal
            // 
            this.idVal.AutoSize = true;
            this.mainPanel.SetColumnSpan(this.idVal, 2);
            this.idVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idVal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idVal.ForeColor = System.Drawing.Color.Black;
            this.idVal.Location = new System.Drawing.Point(200, 62);
            this.idVal.Name = "idVal";
            this.idVal.Size = new System.Drawing.Size(407, 97);
            this.idVal.TabIndex = 8;
            this.idVal.Text = "{Numéro}";
            // 
            // pratDetailsBtn
            // 
            this.pratDetailsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pratDetailsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pratDetailsBtn.FlatAppearance.BorderSize = 0;
            this.pratDetailsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.pratDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pratDetailsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.pratDetailsBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pratDetailsBtn.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.pratDetailsBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.pratDetailsBtn.IconSize = 40;
            this.pratDetailsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pratDetailsBtn.Location = new System.Drawing.Point(531, 162);
            this.pratDetailsBtn.Name = "pratDetailsBtn";
            this.pratDetailsBtn.Rotation = 0D;
            this.pratDetailsBtn.Size = new System.Drawing.Size(59, 30);
            this.pratDetailsBtn.TabIndex = 20;
            this.pratDetailsBtn.TabStop = false;
            this.monToolTip.SetToolTip(this.pratDetailsBtn, "Voir la fiche du praticien.");
            this.pratDetailsBtn.UseVisualStyleBackColor = true;
            this.pratDetailsBtn.Click += new System.EventHandler(this.pratDetailsBtn_Click);
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
            this.panelDroiteSplit.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDroiteSplit.Panel1.Controls.Add(this.echantPanel);
            // 
            // panelDroiteSplit.Panel2
            // 
            this.panelDroiteSplit.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDroiteSplit.Panel2.Controls.Add(this.subPanelDroite);
            this.panelDroiteSplit.Size = new System.Drawing.Size(310, 717);
            this.panelDroiteSplit.SplitterDistance = 348;
            this.panelDroiteSplit.TabIndex = 1;
            this.panelDroiteSplit.TabStop = false;
            // 
            // echantPanel
            // 
            this.echantPanel.BackColor = System.Drawing.Color.White;
            this.echantPanel.Controls.Add(this.echantListView);
            this.echantPanel.Controls.Add(this.echantLabel);
            this.echantPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.echantPanel.Location = new System.Drawing.Point(0, 0);
            this.echantPanel.Name = "echantPanel";
            this.echantPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.echantPanel.Size = new System.Drawing.Size(310, 348);
            this.echantPanel.TabIndex = 24;
            // 
            // echantListView
            // 
            this.echantListView.BackColor = System.Drawing.Color.White;
            this.echantListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.echantListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.medicCol,
            this.nombreCol});
            this.echantListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.echantListView.Enabled = false;
            this.echantListView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.echantListView.ForeColor = System.Drawing.Color.Black;
            this.echantListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.echantListView.HideSelection = false;
            this.echantListView.Location = new System.Drawing.Point(0, 52);
            this.echantListView.MultiSelect = false;
            this.echantListView.Name = "echantListView";
            this.echantListView.Size = new System.Drawing.Size(300, 286);
            this.echantListView.TabIndex = 2;
            this.echantListView.UseCompatibleStateImageBehavior = false;
            this.echantListView.View = System.Windows.Forms.View.Details;
            // 
            // medicCol
            // 
            this.medicCol.Text = "Médicament";
            this.medicCol.Width = 174;
            // 
            // nombreCol
            // 
            this.nombreCol.Text = "Nb. échant.";
            this.nombreCol.Width = 126;
            // 
            // echantLabel
            // 
            this.echantLabel.AutoSize = true;
            this.echantLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.echantLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.echantLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.echantLabel.Location = new System.Drawing.Point(0, 0);
            this.echantLabel.Name = "echantLabel";
            this.echantLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.echantLabel.Size = new System.Drawing.Size(187, 52);
            this.echantLabel.TabIndex = 1;
            this.echantLabel.Text = "Offre d\'échantillons";
            // 
            // subPanelDroite
            // 
            this.subPanelDroite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subPanelDroite.IsSplitterFixed = true;
            this.subPanelDroite.Location = new System.Drawing.Point(0, 0);
            this.subPanelDroite.Name = "subPanelDroite";
            this.subPanelDroite.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // subPanelDroite.Panel1
            // 
            this.subPanelDroite.Panel1.Controls.Add(this.rapportSelecLabel);
            this.subPanelDroite.Panel1.Controls.Add(this.rappPrecBtn);
            this.subPanelDroite.Panel1.Controls.Add(this.rapportSelecComboBox);
            this.subPanelDroite.Panel1.Controls.Add(this.rappSuivBtn);
            this.subPanelDroite.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // subPanelDroite.Panel2
            // 
            this.subPanelDroite.Panel2.Controls.Add(this.nouveauBtn);
            this.subPanelDroite.Size = new System.Drawing.Size(310, 365);
            this.subPanelDroite.SplitterDistance = 240;
            this.subPanelDroite.TabIndex = 25;
            this.subPanelDroite.TabStop = false;
            // 
            // rapportSelecLabel
            // 
            this.rapportSelecLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rapportSelecLabel.AutoSize = true;
            this.rapportSelecLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.rapportSelecLabel.Location = new System.Drawing.Point(6, 30);
            this.rapportSelecLabel.Name = "rapportSelecLabel";
            this.rapportSelecLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.rapportSelecLabel.Size = new System.Drawing.Size(199, 27);
            this.rapportSelecLabel.TabIndex = 2;
            this.rapportSelecLabel.Text = "Mes comptes-rendus";
            // 
            // rappPrecBtn
            // 
            this.rappPrecBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rappPrecBtn.BackColor = System.Drawing.Color.White;
            this.rappPrecBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rappPrecBtn.FlatAppearance.BorderSize = 0;
            this.rappPrecBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.rappPrecBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.rappPrecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rappPrecBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.rappPrecBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rappPrecBtn.ForeColor = System.Drawing.Color.Black;
            this.rappPrecBtn.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.rappPrecBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.rappPrecBtn.IconSize = 40;
            this.rappPrecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rappPrecBtn.Location = new System.Drawing.Point(10, 136);
            this.rappPrecBtn.Name = "rappPrecBtn";
            this.rappPrecBtn.Rotation = 0D;
            this.rappPrecBtn.Size = new System.Drawing.Size(140, 51);
            this.rappPrecBtn.TabIndex = 23;
            this.rappPrecBtn.Text = "   Préc.";
            this.rappPrecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rappPrecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.rappPrecBtn, "Aller au compte-rendu précédent.");
            this.rappPrecBtn.UseVisualStyleBackColor = false;
            this.rappPrecBtn.Click += new System.EventHandler(this.rappPrecBtn_Click);
            // 
            // rapportSelecComboBox
            // 
            this.rapportSelecComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rapportSelecComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rapportSelecComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rapportSelecComboBox.BackColor = System.Drawing.Color.White;
            this.rapportSelecComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rapportSelecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rapportSelecComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rapportSelecComboBox.ForeColor = System.Drawing.Color.Black;
            this.rapportSelecComboBox.FormattingEnabled = true;
            this.rapportSelecComboBox.Location = new System.Drawing.Point(10, 83);
            this.rapportSelecComboBox.Name = "rapportSelecComboBox";
            this.rapportSelecComboBox.Size = new System.Drawing.Size(290, 30);
            this.rapportSelecComboBox.TabIndex = 3;
            this.monToolTip.SetToolTip(this.rapportSelecComboBox, "Sélectionner un compte-rendu.");
            this.rapportSelecComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.rapportSelecComboBox_Format);
            // 
            // rappSuivBtn
            // 
            this.rappSuivBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rappSuivBtn.BackColor = System.Drawing.Color.White;
            this.rappSuivBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rappSuivBtn.FlatAppearance.BorderSize = 0;
            this.rappSuivBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.rappSuivBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.rappSuivBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rappSuivBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.rappSuivBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rappSuivBtn.ForeColor = System.Drawing.Color.Black;
            this.rappSuivBtn.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.rappSuivBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.rappSuivBtn.IconSize = 40;
            this.rappSuivBtn.Location = new System.Drawing.Point(160, 136);
            this.rappSuivBtn.Name = "rappSuivBtn";
            this.rappSuivBtn.Rotation = 0D;
            this.rappSuivBtn.Size = new System.Drawing.Size(140, 51);
            this.rappSuivBtn.TabIndex = 24;
            this.rappSuivBtn.Text = "   Suiv.";
            this.rappSuivBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.monToolTip.SetToolTip(this.rappSuivBtn, "Aller au compte-rendu suivant.");
            this.rappSuivBtn.UseVisualStyleBackColor = false;
            this.rappSuivBtn.Click += new System.EventHandler(this.rappSuivBtn_Click);
            // 
            // nouveauBtn
            // 
            this.nouveauBtn.BackColor = System.Drawing.Color.White;
            this.nouveauBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nouveauBtn.FlatAppearance.BorderSize = 0;
            this.nouveauBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.nouveauBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.nouveauBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nouveauBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.nouveauBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauBtn.ForeColor = System.Drawing.Color.Black;
            this.nouveauBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.nouveauBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.nouveauBtn.IconSize = 40;
            this.nouveauBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nouveauBtn.Location = new System.Drawing.Point(79, 35);
            this.nouveauBtn.Name = "nouveauBtn";
            this.nouveauBtn.Rotation = 0D;
            this.nouveauBtn.Size = new System.Drawing.Size(153, 51);
            this.nouveauBtn.TabIndex = 25;
            this.nouveauBtn.Text = "   Nouveau";
            this.nouveauBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nouveauBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.nouveauBtn, "Edition d\'un nouveau compte-rendu.");
            this.nouveauBtn.UseVisualStyleBackColor = false;
            this.nouveauBtn.Click += new System.EventHandler(this.nouveauBtn_Click);
            // 
            // monToolTip
            // 
            this.monToolTip.BackColor = System.Drawing.Color.White;
            this.monToolTip.ForeColor = System.Drawing.Color.Black;
            this.monToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // RapportsForm
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
            this.Name = "RapportsForm";
            this.Text = "GSB SwissVisite - Affichage des comptes-rendus";
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panelDroiteSplit.Panel1.ResumeLayout(false);
            this.panelDroiteSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelDroiteSplit)).EndInit();
            this.panelDroiteSplit.ResumeLayout(false);
            this.echantPanel.ResumeLayout(false);
            this.echantPanel.PerformLayout();
            this.subPanelDroite.Panel1.ResumeLayout(false);
            this.subPanelDroite.Panel1.PerformLayout();
            this.subPanelDroite.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subPanelDroite)).EndInit();
            this.subPanelDroite.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Label dateVal;
        private System.Windows.Forms.TextBox motifVal;
        private System.Windows.Forms.TextBox bilanVal;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label pratLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label motifLabel;
        private System.Windows.Forms.Label bilanLabel;
        private System.Windows.Forms.Label idVal;
        private FontAwesome.Sharp.IconButton pratDetailsBtn;
        private System.Windows.Forms.SplitContainer panelDroiteSplit;
        private System.Windows.Forms.SplitContainer subPanelDroite;
        private FontAwesome.Sharp.IconButton rappSuivBtn;
        private System.Windows.Forms.ComboBox rapportSelecComboBox;
        private FontAwesome.Sharp.IconButton rappPrecBtn;
        private System.Windows.Forms.Label rapportSelecLabel;
        private FontAwesome.Sharp.IconButton nouveauBtn;
        private System.Windows.Forms.Panel echantPanel;
        private System.Windows.Forms.Label echantLabel;
        private System.Windows.Forms.ListView echantListView;
        private System.Windows.Forms.ColumnHeader medicCol;
        private System.Windows.Forms.ColumnHeader nombreCol;
        private System.Windows.Forms.Label pratVal;
        private System.Windows.Forms.ToolTip monToolTip;
    }
}