namespace SwissVisiteForm.Forms
{
    partial class QuitterEditionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuitterEditionForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.quitterNonBtn = new System.Windows.Forms.Button();
            this.quitterOuiBtn = new System.Windows.Forms.Button();
            this.messageTitreLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.messageTextBox);
            this.mainPanel.Controls.Add(this.quitterNonBtn);
            this.mainPanel.Controls.Add(this.quitterOuiBtn);
            this.mainPanel.Controls.Add(this.messageTitreLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(1, 1);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(665, 371);
            this.mainPanel.TabIndex = 1;
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.White;
            this.messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageTextBox.Enabled = false;
            this.messageTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.ForeColor = System.Drawing.Color.Black;
            this.messageTextBox.Location = new System.Drawing.Point(111, 127);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(500, 59);
            this.messageTextBox.TabIndex = 4;
            this.messageTextBox.TabStop = false;
            this.messageTextBox.Text = "Vous perdrez les données en cours de saisie.";
            // 
            // quitterNonBtn
            // 
            this.quitterNonBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quitterNonBtn.BackColor = System.Drawing.Color.White;
            this.quitterNonBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitterNonBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quitterNonBtn.FlatAppearance.BorderSize = 0;
            this.quitterNonBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.quitterNonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitterNonBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitterNonBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.quitterNonBtn.Location = new System.Drawing.Point(294, 228);
            this.quitterNonBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quitterNonBtn.Name = "quitterNonBtn";
            this.quitterNonBtn.Size = new System.Drawing.Size(272, 68);
            this.quitterNonBtn.TabIndex = 0;
            this.quitterNonBtn.Text = "Non (retour à l\'édition)";
            this.quitterNonBtn.UseVisualStyleBackColor = false;
            // 
            // quitterOuiBtn
            // 
            this.quitterOuiBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quitterOuiBtn.BackColor = System.Drawing.Color.White;
            this.quitterOuiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitterOuiBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.quitterOuiBtn.FlatAppearance.BorderSize = 0;
            this.quitterOuiBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.quitterOuiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitterOuiBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitterOuiBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.quitterOuiBtn.Location = new System.Drawing.Point(98, 228);
            this.quitterOuiBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quitterOuiBtn.Name = "quitterOuiBtn";
            this.quitterOuiBtn.Size = new System.Drawing.Size(188, 68);
            this.quitterOuiBtn.TabIndex = 1;
            this.quitterOuiBtn.Text = "Oui";
            this.quitterOuiBtn.UseVisualStyleBackColor = false;
            // 
            // messageTitreLabel
            // 
            this.messageTitreLabel.AutoSize = true;
            this.messageTitreLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTitreLabel.ForeColor = System.Drawing.Color.Black;
            this.messageTitreLabel.Location = new System.Drawing.Point(107, 74);
            this.messageTitreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageTitreLabel.Name = "messageTitreLabel";
            this.messageTitreLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.messageTitreLabel.Size = new System.Drawing.Size(451, 35);
            this.messageTitreLabel.TabIndex = 0;
            this.messageTitreLabel.Text = "Confirmez-vous vouloir quitter le mode édition ?";
            // 
            // QuitterEditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(667, 373);
            this.Controls.Add(this.mainPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuitterEditionForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GSB SwissVisite - Quitter le mode édition";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button quitterNonBtn;
        private System.Windows.Forms.Button quitterOuiBtn;
        private System.Windows.Forms.Label messageTitreLabel;
        private System.Windows.Forms.TextBox messageTextBox;
    }
}