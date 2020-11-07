namespace SwissVisite.Forms
{
    partial class MedicsForm
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
            this.selecMedicPanel = new System.Windows.Forms.Panel();
            this.medicSuivBtn = new FontAwesome.Sharp.IconButton();
            this.medicSelecComboBox = new System.Windows.Forms.ComboBox();
            this.medicPrecBtn = new FontAwesome.Sharp.IconButton();
            this.medicSelecLabel = new System.Windows.Forms.Label();
            this.optionTriPanel = new System.Windows.Forms.Panel();
            this.familleSelecComboBox = new System.Windows.Forms.ComboBox();
            this.triParFamilleRadioBtn = new System.Windows.Forms.RadioButton();
            this.triTousRadioBtn = new System.Windows.Forms.RadioButton();
            this.optionTriLabel = new System.Windows.Forms.Label();
            this.contreIndicVal = new System.Windows.Forms.TextBox();
            this.effetsVal = new System.Windows.Forms.TextBox();
            this.codeVal = new System.Windows.Forms.Label();
            this.nomCommVal = new System.Windows.Forms.Label();
            this.familleLabel = new System.Windows.Forms.Label();
            this.contreIndicLabel = new System.Windows.Forms.Label();
            this.effetsLabel = new System.Windows.Forms.Label();
            this.composLabel = new System.Windows.Forms.Label();
            this.nomCommLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.familleVal = new System.Windows.Forms.TextBox();
            this.composVal = new System.Windows.Forms.TextBox();
            this.infoMedicPanel = new System.Windows.Forms.TableLayoutPanel();
            this.prixEchantVal = new System.Windows.Forms.Label();
            this.prixEchantLabel = new System.Windows.Forms.Label();
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.monToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.selecMedicPanel.SuspendLayout();
            this.optionTriPanel.SuspendLayout();
            this.infoMedicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // selecMedicPanel
            // 
            this.selecMedicPanel.Controls.Add(this.medicSuivBtn);
            this.selecMedicPanel.Controls.Add(this.medicSelecComboBox);
            this.selecMedicPanel.Controls.Add(this.medicPrecBtn);
            this.selecMedicPanel.Controls.Add(this.medicSelecLabel);
            this.selecMedicPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecMedicPanel.Location = new System.Drawing.Point(16, 347);
            this.selecMedicPanel.Name = "selecMedicPanel";
            this.selecMedicPanel.Size = new System.Drawing.Size(273, 140);
            this.selecMedicPanel.TabIndex = 22;
            // 
            // medicSuivBtn
            // 
            this.medicSuivBtn.BackColor = System.Drawing.Color.White;
            this.medicSuivBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medicSuivBtn.FlatAppearance.BorderSize = 0;
            this.medicSuivBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.medicSuivBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.medicSuivBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicSuivBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.medicSuivBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicSuivBtn.ForeColor = System.Drawing.Color.Black;
            this.medicSuivBtn.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.medicSuivBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.medicSuivBtn.IconSize = 40;
            this.medicSuivBtn.Location = new System.Drawing.Point(138, 89);
            this.medicSuivBtn.Name = "medicSuivBtn";
            this.medicSuivBtn.Rotation = 0D;
            this.medicSuivBtn.Size = new System.Drawing.Size(135, 51);
            this.medicSuivBtn.TabIndex = 24;
            this.medicSuivBtn.Text = "   Suiv.";
            this.medicSuivBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.monToolTip.SetToolTip(this.medicSuivBtn, "Aller au médicament suivant.");
            this.medicSuivBtn.UseVisualStyleBackColor = false;
            this.medicSuivBtn.Click += new System.EventHandler(this.medicSuivBtn_Click);
            // 
            // medicSelecComboBox
            // 
            this.medicSelecComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.medicSelecComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.medicSelecComboBox.BackColor = System.Drawing.Color.White;
            this.medicSelecComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medicSelecComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.medicSelecComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicSelecComboBox.ForeColor = System.Drawing.Color.Black;
            this.medicSelecComboBox.FormattingEnabled = true;
            this.medicSelecComboBox.Location = new System.Drawing.Point(0, 28);
            this.medicSelecComboBox.Name = "medicSelecComboBox";
            this.medicSelecComboBox.Size = new System.Drawing.Size(273, 31);
            this.medicSelecComboBox.TabIndex = 3;
            this.monToolTip.SetToolTip(this.medicSelecComboBox, "Sélectionner un médicament.");
            this.medicSelecComboBox.SelectionChangeCommitted += new System.EventHandler(this.medicSelecComboBox_SelectionChangeCommitted);
            // 
            // medicPrecBtn
            // 
            this.medicPrecBtn.BackColor = System.Drawing.Color.White;
            this.medicPrecBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medicPrecBtn.FlatAppearance.BorderSize = 0;
            this.medicPrecBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.medicPrecBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.medicPrecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medicPrecBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.medicPrecBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicPrecBtn.ForeColor = System.Drawing.Color.Black;
            this.medicPrecBtn.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.medicPrecBtn.IconColor = System.Drawing.Color.DodgerBlue;
            this.medicPrecBtn.IconSize = 40;
            this.medicPrecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medicPrecBtn.Location = new System.Drawing.Point(0, 89);
            this.medicPrecBtn.Name = "medicPrecBtn";
            this.medicPrecBtn.Rotation = 0D;
            this.medicPrecBtn.Size = new System.Drawing.Size(135, 51);
            this.medicPrecBtn.TabIndex = 23;
            this.medicPrecBtn.Text = "   Préc.";
            this.medicPrecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.medicPrecBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.monToolTip.SetToolTip(this.medicPrecBtn, "Aller au médicament précédent.");
            this.medicPrecBtn.UseVisualStyleBackColor = false;
            this.medicPrecBtn.Click += new System.EventHandler(this.medicPrecBtn_Click);
            // 
            // medicSelecLabel
            // 
            this.medicSelecLabel.AutoSize = true;
            this.medicSelecLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.medicSelecLabel.Location = new System.Drawing.Point(0, 0);
            this.medicSelecLabel.Name = "medicSelecLabel";
            this.medicSelecLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.medicSelecLabel.Size = new System.Drawing.Size(244, 28);
            this.medicSelecLabel.TabIndex = 2;
            this.medicSelecLabel.Text = "Trouver un médicament";
            // 
            // optionTriPanel
            // 
            this.optionTriPanel.Controls.Add(this.familleSelecComboBox);
            this.optionTriPanel.Controls.Add(this.triParFamilleRadioBtn);
            this.optionTriPanel.Controls.Add(this.triTousRadioBtn);
            this.optionTriPanel.Controls.Add(this.optionTriLabel);
            this.optionTriPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionTriPanel.Location = new System.Drawing.Point(16, 189);
            this.optionTriPanel.Name = "optionTriPanel";
            this.optionTriPanel.Size = new System.Drawing.Size(273, 129);
            this.optionTriPanel.TabIndex = 19;
            // 
            // familleSelecComboBox
            // 
            this.familleSelecComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.familleSelecComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.familleSelecComboBox.BackColor = System.Drawing.Color.White;
            this.familleSelecComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.familleSelecComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.familleSelecComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.familleSelecComboBox.ForeColor = System.Drawing.Color.Black;
            this.familleSelecComboBox.FormattingEnabled = true;
            this.familleSelecComboBox.Location = new System.Drawing.Point(0, 92);
            this.familleSelecComboBox.Name = "familleSelecComboBox";
            this.familleSelecComboBox.Size = new System.Drawing.Size(273, 31);
            this.familleSelecComboBox.TabIndex = 21;
            this.monToolTip.SetToolTip(this.familleSelecComboBox, "Sélectionner une famille de médicaments.");
            this.familleSelecComboBox.Visible = false;
            this.familleSelecComboBox.SelectionChangeCommitted += new System.EventHandler(this.familleSelecComboBox_SelectionChangeCommitted);
            // 
            // triParFamilleRadioBtn
            // 
            this.triParFamilleRadioBtn.AutoSize = true;
            this.triParFamilleRadioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triParFamilleRadioBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.triParFamilleRadioBtn.ForeColor = System.Drawing.Color.Black;
            this.triParFamilleRadioBtn.Location = new System.Drawing.Point(0, 60);
            this.triParFamilleRadioBtn.Name = "triParFamilleRadioBtn";
            this.triParFamilleRadioBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.triParFamilleRadioBtn.Size = new System.Drawing.Size(273, 32);
            this.triParFamilleRadioBtn.TabIndex = 19;
            this.triParFamilleRadioBtn.Text = "Une seule famille";
            this.triParFamilleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // triTousRadioBtn
            // 
            this.triTousRadioBtn.AutoSize = true;
            this.triTousRadioBtn.Checked = true;
            this.triTousRadioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triTousRadioBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.triTousRadioBtn.ForeColor = System.Drawing.Color.Black;
            this.triTousRadioBtn.Location = new System.Drawing.Point(0, 28);
            this.triTousRadioBtn.Name = "triTousRadioBtn";
            this.triTousRadioBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.triTousRadioBtn.Size = new System.Drawing.Size(273, 32);
            this.triTousRadioBtn.TabIndex = 18;
            this.triTousRadioBtn.TabStop = true;
            this.triTousRadioBtn.Text = "Tous, de A à Z";
            this.triTousRadioBtn.UseVisualStyleBackColor = true;
            // 
            // optionTriLabel
            // 
            this.optionTriLabel.AutoSize = true;
            this.optionTriLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionTriLabel.Location = new System.Drawing.Point(0, 0);
            this.optionTriLabel.Name = "optionTriLabel";
            this.optionTriLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.optionTriLabel.Size = new System.Drawing.Size(287, 28);
            this.optionTriLabel.TabIndex = 20;
            this.optionTriLabel.Text = "Affichage des médicaments";
            // 
            // contreIndicVal
            // 
            this.contreIndicVal.BackColor = System.Drawing.Color.White;
            this.contreIndicVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contreIndicVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contreIndicVal.ForeColor = System.Drawing.Color.Black;
            this.contreIndicVal.Location = new System.Drawing.Point(282, 483);
            this.contreIndicVal.Multiline = true;
            this.contreIndicVal.Name = "contreIndicVal";
            this.contreIndicVal.ReadOnly = true;
            this.infoMedicPanel.SetRowSpan(this.contreIndicVal, 3);
            this.contreIndicVal.Size = new System.Drawing.Size(363, 144);
            this.contreIndicVal.TabIndex = 16;
            this.contreIndicVal.TabStop = false;
            this.contreIndicVal.Text = "{ContreIndications}";
            // 
            // effetsVal
            // 
            this.effetsVal.BackColor = System.Drawing.Color.White;
            this.effetsVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.effetsVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.effetsVal.ForeColor = System.Drawing.Color.Black;
            this.effetsVal.Location = new System.Drawing.Point(282, 333);
            this.effetsVal.Multiline = true;
            this.effetsVal.Name = "effetsVal";
            this.effetsVal.ReadOnly = true;
            this.infoMedicPanel.SetRowSpan(this.effetsVal, 3);
            this.effetsVal.Size = new System.Drawing.Size(363, 144);
            this.effetsVal.TabIndex = 15;
            this.effetsVal.TabStop = false;
            this.effetsVal.Text = "{Effets}";
            // 
            // codeVal
            // 
            this.codeVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.codeVal.AutoSize = true;
            this.codeVal.ForeColor = System.Drawing.Color.Black;
            this.codeVal.Location = new System.Drawing.Point(282, 30);
            this.codeVal.Name = "codeVal";
            this.codeVal.Size = new System.Drawing.Size(96, 50);
            this.codeVal.TabIndex = 14;
            this.codeVal.Text = "{Code}";
            // 
            // nomCommVal
            // 
            this.nomCommVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nomCommVal.AutoSize = true;
            this.nomCommVal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomCommVal.ForeColor = System.Drawing.Color.Black;
            this.nomCommVal.Location = new System.Drawing.Point(282, 80);
            this.nomCommVal.Name = "nomCommVal";
            this.nomCommVal.Size = new System.Drawing.Size(233, 50);
            this.nomCommVal.TabIndex = 13;
            this.nomCommVal.Text = "{Nom commercial}";
            // 
            // familleLabel
            // 
            this.familleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.familleLabel.AutoSize = true;
            this.familleLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.familleLabel.Location = new System.Drawing.Point(23, 130);
            this.familleLabel.Name = "familleLabel";
            this.familleLabel.Size = new System.Drawing.Size(99, 50);
            this.familleLabel.TabIndex = 6;
            this.familleLabel.Text = "Famille";
            // 
            // contreIndicLabel
            // 
            this.contreIndicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contreIndicLabel.AutoSize = true;
            this.contreIndicLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.contreIndicLabel.Location = new System.Drawing.Point(23, 480);
            this.contreIndicLabel.Name = "contreIndicLabel";
            this.contreIndicLabel.Size = new System.Drawing.Size(233, 50);
            this.contreIndicLabel.TabIndex = 4;
            this.contreIndicLabel.Text = "Contre-indications";
            // 
            // effetsLabel
            // 
            this.effetsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.effetsLabel.AutoSize = true;
            this.effetsLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.effetsLabel.Location = new System.Drawing.Point(23, 330);
            this.effetsLabel.Name = "effetsLabel";
            this.effetsLabel.Size = new System.Drawing.Size(76, 50);
            this.effetsLabel.TabIndex = 3;
            this.effetsLabel.Text = "Effets";
            // 
            // composLabel
            // 
            this.composLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.composLabel.AutoSize = true;
            this.composLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.composLabel.Location = new System.Drawing.Point(23, 230);
            this.composLabel.Name = "composLabel";
            this.composLabel.Size = new System.Drawing.Size(166, 50);
            this.composLabel.TabIndex = 2;
            this.composLabel.Text = "Composition";
            // 
            // nomCommLabel
            // 
            this.nomCommLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nomCommLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.nomCommLabel.Location = new System.Drawing.Point(23, 80);
            this.nomCommLabel.Name = "nomCommLabel";
            this.nomCommLabel.Size = new System.Drawing.Size(177, 50);
            this.nomCommLabel.TabIndex = 1;
            this.nomCommLabel.Text = "Nom commercial";
            // 
            // codeLabel
            // 
            this.codeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.codeLabel.AutoSize = true;
            this.codeLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.codeLabel.Location = new System.Drawing.Point(23, 30);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(81, 50);
            this.codeLabel.TabIndex = 0;
            this.codeLabel.Text = "Code";
            // 
            // familleVal
            // 
            this.familleVal.BackColor = System.Drawing.Color.White;
            this.familleVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.familleVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.familleVal.ForeColor = System.Drawing.Color.Black;
            this.familleVal.Location = new System.Drawing.Point(282, 133);
            this.familleVal.Multiline = true;
            this.familleVal.Name = "familleVal";
            this.familleVal.ReadOnly = true;
            this.infoMedicPanel.SetRowSpan(this.familleVal, 2);
            this.familleVal.Size = new System.Drawing.Size(363, 94);
            this.familleVal.TabIndex = 23;
            this.familleVal.TabStop = false;
            this.familleVal.Text = "{Famille}";
            // 
            // composVal
            // 
            this.composVal.BackColor = System.Drawing.Color.White;
            this.composVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.composVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.composVal.ForeColor = System.Drawing.Color.Black;
            this.composVal.Location = new System.Drawing.Point(282, 233);
            this.composVal.Multiline = true;
            this.composVal.Name = "composVal";
            this.composVal.ReadOnly = true;
            this.infoMedicPanel.SetRowSpan(this.composVal, 2);
            this.composVal.Size = new System.Drawing.Size(363, 94);
            this.composVal.TabIndex = 24;
            this.composVal.TabStop = false;
            this.composVal.Text = "{Composition}";
            // 
            // infoMedicPanel
            // 
            this.infoMedicPanel.ColumnCount = 4;
            this.infoMedicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoMedicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.infoMedicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.infoMedicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infoMedicPanel.Controls.Add(this.prixEchantVal, 3, 13);
            this.infoMedicPanel.Controls.Add(this.prixEchantLabel, 1, 13);
            this.infoMedicPanel.Controls.Add(this.nomCommLabel, 1, 2);
            this.infoMedicPanel.Controls.Add(this.familleLabel, 1, 3);
            this.infoMedicPanel.Controls.Add(this.codeVal, 3, 1);
            this.infoMedicPanel.Controls.Add(this.composLabel, 1, 5);
            this.infoMedicPanel.Controls.Add(this.composVal, 3, 5);
            this.infoMedicPanel.Controls.Add(this.effetsVal, 3, 7);
            this.infoMedicPanel.Controls.Add(this.effetsLabel, 1, 7);
            this.infoMedicPanel.Controls.Add(this.familleVal, 3, 3);
            this.infoMedicPanel.Controls.Add(this.contreIndicLabel, 1, 10);
            this.infoMedicPanel.Controls.Add(this.contreIndicVal, 3, 10);
            this.infoMedicPanel.Controls.Add(this.codeLabel, 1, 1);
            this.infoMedicPanel.Controls.Add(this.nomCommVal, 3, 2);
            this.infoMedicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoMedicPanel.Location = new System.Drawing.Point(0, 0);
            this.infoMedicPanel.Name = "infoMedicPanel";
            this.infoMedicPanel.RowCount = 15;
            this.infoMedicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.infoMedicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.infoMedicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.infoMedicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.infoMedicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.infoMedicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.infoMedicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.infoMedicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.infoMedicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.infoMedicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.infoMedicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.infoMedicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.infoMedicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.infoMedicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692309F));
            this.infoMedicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.infoMedicPanel.Size = new System.Drawing.Size(648, 717);
            this.infoMedicPanel.TabIndex = 1;
            // 
            // prixEchantVal
            // 
            this.prixEchantVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.prixEchantVal.AutoSize = true;
            this.prixEchantVal.ForeColor = System.Drawing.Color.Black;
            this.prixEchantVal.Location = new System.Drawing.Point(282, 630);
            this.prixEchantVal.Name = "prixEchantVal";
            this.prixEchantVal.Size = new System.Drawing.Size(209, 50);
            this.prixEchantVal.TabIndex = 11;
            this.prixEchantVal.Text = "{Prix échantillon}";
            // 
            // prixEchantLabel
            // 
            this.prixEchantLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.prixEchantLabel.AutoSize = true;
            this.prixEchantLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.prixEchantLabel.Location = new System.Drawing.Point(23, 630);
            this.prixEchantLabel.Name = "prixEchantLabel";
            this.prixEchantLabel.Size = new System.Drawing.Size(194, 50);
            this.prixEchantLabel.TabIndex = 5;
            this.prixEchantLabel.Text = "Prix échantillon";
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
            this.mainContainer.Panel1.Controls.Add(this.infoMedicPanel);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.mainContainer.Panel2.Controls.Add(this.selecMedicPanel);
            this.mainContainer.Panel2.Controls.Add(this.optionTriPanel);
            this.mainContainer.Size = new System.Drawing.Size(962, 717);
            this.mainContainer.SplitterDistance = 648;
            this.mainContainer.TabIndex = 23;
            this.mainContainer.TabStop = false;
            // 
            // monToolTip
            // 
            this.monToolTip.BackColor = System.Drawing.Color.White;
            this.monToolTip.ForeColor = System.Drawing.Color.Black;
            this.monToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // MedicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 717);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MedicsForm";
            this.Text = "MedicsForm";
            this.selecMedicPanel.ResumeLayout(false);
            this.selecMedicPanel.PerformLayout();
            this.optionTriPanel.ResumeLayout(false);
            this.optionTriPanel.PerformLayout();
            this.infoMedicPanel.ResumeLayout(false);
            this.infoMedicPanel.PerformLayout();
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label familleLabel;
        private System.Windows.Forms.Label contreIndicLabel;
        private System.Windows.Forms.Label effetsLabel;
        private System.Windows.Forms.Label composLabel;
        private System.Windows.Forms.Label nomCommLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label nomCommVal;
        private System.Windows.Forms.Label codeVal;
        private System.Windows.Forms.TextBox contreIndicVal;
        private System.Windows.Forms.TextBox effetsVal;
        private System.Windows.Forms.RadioButton triTousRadioBtn;
        private System.Windows.Forms.Panel optionTriPanel;
        private System.Windows.Forms.RadioButton triParFamilleRadioBtn;
        private System.Windows.Forms.Label optionTriLabel;
        private System.Windows.Forms.Panel selecMedicPanel;
        private System.Windows.Forms.ComboBox medicSelecComboBox;
        private System.Windows.Forms.Label medicSelecLabel;
        private System.Windows.Forms.TextBox familleVal;
        private System.Windows.Forms.TextBox composVal;
        private System.Windows.Forms.TableLayoutPanel infoMedicPanel;
        private System.Windows.Forms.SplitContainer mainContainer;
        private FontAwesome.Sharp.IconButton medicSuivBtn;
        private FontAwesome.Sharp.IconButton medicPrecBtn;
        private System.Windows.Forms.Label prixEchantVal;
        private System.Windows.Forms.Label prixEchantLabel;
        private System.Windows.Forms.ComboBox familleSelecComboBox;
        private System.Windows.Forms.ToolTip monToolTip;
    }
}