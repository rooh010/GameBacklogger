namespace GameBacklogger
{
    partial class GameDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameDetails));
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.textProgress = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboGenre
            // 
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(27, 68);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(171, 21);
            this.comboGenre.TabIndex = 7;
            // 
            // textProgress
            // 
            this.textProgress.Location = new System.Drawing.Point(27, 106);
            this.textProgress.Name = "textProgress";
            this.textProgress.Size = new System.Drawing.Size(171, 20);
            this.textProgress.TabIndex = 6;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(27, 30);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(171, 20);
            this.textName.TabIndex = 5;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateButton.Location = new System.Drawing.Point(300, 242);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(130, 64);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.OrangeRed;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelButton.Location = new System.Drawing.Point(439, 242);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 64);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // GameDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(581, 318);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.comboGenre);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.textName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameDetails";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.GameDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.TextBox textProgress;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
    }
}