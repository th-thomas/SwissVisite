using System.Drawing;

namespace SwissVisite.Forms
{
    partial class QuitterForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.quitterNonBtn = new System.Windows.Forms.Button();
            this.quitterOuiBtn = new System.Windows.Forms.Button();
            this.quitterLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.quitterNonBtn);
            this.mainPanel.Controls.Add(this.quitterOuiBtn);
            this.mainPanel.Controls.Add(this.quitterLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(1, 1);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(362, 189);
            this.mainPanel.TabIndex = 0;
            // 
            // quitterNonBtn
            // 
            this.quitterNonBtn.BackColor = System.Drawing.Color.White;
            this.quitterNonBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitterNonBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quitterNonBtn.FlatAppearance.BorderSize = 0;
            this.quitterNonBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.quitterNonBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.quitterNonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitterNonBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitterNonBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.quitterNonBtn.Location = new System.Drawing.Point(191, 100);
            this.quitterNonBtn.Name = "quitterNonBtn";
            this.quitterNonBtn.Size = new System.Drawing.Size(97, 55);
            this.quitterNonBtn.TabIndex = 0;
            this.quitterNonBtn.Text = "Non";
            this.quitterNonBtn.UseVisualStyleBackColor = false;
            this.quitterNonBtn.Click += new System.EventHandler(this.quitterNonBtn_Click);
            // 
            // quitterOuiBtn
            // 
            this.quitterOuiBtn.BackColor = System.Drawing.Color.White;
            this.quitterOuiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitterOuiBtn.FlatAppearance.BorderSize = 0;
            this.quitterOuiBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.quitterOuiBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.quitterOuiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitterOuiBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitterOuiBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.quitterOuiBtn.Location = new System.Drawing.Point(76, 100);
            this.quitterOuiBtn.Name = "quitterOuiBtn";
            this.quitterOuiBtn.Size = new System.Drawing.Size(97, 55);
            this.quitterOuiBtn.TabIndex = 1;
            this.quitterOuiBtn.Text = "Oui";
            this.quitterOuiBtn.UseVisualStyleBackColor = false;
            this.quitterOuiBtn.Click += new System.EventHandler(this.quitterOuiBtn_Click);
            // 
            // quitterLabel
            // 
            this.quitterLabel.AutoSize = true;
            this.quitterLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitterLabel.ForeColor = System.Drawing.Color.Black;
            this.quitterLabel.Location = new System.Drawing.Point(31, 36);
            this.quitterLabel.Name = "quitterLabel";
            this.quitterLabel.Size = new System.Drawing.Size(303, 23);
            this.quitterLabel.TabIndex = 2;
            this.quitterLabel.Text = "Êtes-vous sûr de vouloir quitter ?";
            // 
            // QuitterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.quitterNonBtn;
            this.ClientSize = new System.Drawing.Size(364, 191);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "QuitterForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuitterForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label quitterLabel;
        private System.Windows.Forms.Button quitterOuiBtn;
        private System.Windows.Forms.Button quitterNonBtn;
    }
}