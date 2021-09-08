
namespace TrackerUI
{
    partial class TournamentViewer
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
            this.scoreButton = new System.Windows.Forms.Button();
            this.temTwoScoreText = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLable = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamOneScoreLable = new System.Windows.Forms.Label();
            this.versusLable = new System.Windows.Forms.Label();
            this.teamOneName = new System.Windows.Forms.Label();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.UnplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.headerLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.Location = new System.Drawing.Point(663, 304);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(133, 54);
            this.scoreButton.TabIndex = 26;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // temTwoScoreText
            // 
            this.temTwoScoreText.Location = new System.Drawing.Point(510, 418);
            this.temTwoScoreText.Name = "temTwoScoreText";
            this.temTwoScoreText.Size = new System.Drawing.Size(100, 20);
            this.temTwoScoreText.TabIndex = 25;
            // 
            // teamTwoScoreLable
            // 
            this.teamTwoScoreLable.AutoSize = true;
            this.teamTwoScoreLable.Location = new System.Drawing.Point(421, 418);
            this.teamTwoScoreLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamTwoScoreLable.Name = "teamTwoScoreLable";
            this.teamTwoScoreLable.Size = new System.Drawing.Size(35, 13);
            this.teamTwoScoreLable.TabIndex = 24;
            this.teamTwoScoreLable.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Location = new System.Drawing.Point(410, 367);
            this.teamTwoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(62, 13);
            this.teamTwoName.TabIndex = 23;
            this.teamTwoName.Text = "<team two>";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(499, 249);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(100, 20);
            this.teamOneScoreValue.TabIndex = 22;
            // 
            // teamOneScoreLable
            // 
            this.teamOneScoreLable.AutoSize = true;
            this.teamOneScoreLable.Location = new System.Drawing.Point(410, 249);
            this.teamOneScoreLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamOneScoreLable.Name = "teamOneScoreLable";
            this.teamOneScoreLable.Size = new System.Drawing.Size(35, 13);
            this.teamOneScoreLable.TabIndex = 21;
            this.teamOneScoreLable.Text = "Score";
            // 
            // versusLable
            // 
            this.versusLable.AutoSize = true;
            this.versusLable.Location = new System.Drawing.Point(503, 313);
            this.versusLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versusLable.Name = "versusLable";
            this.versusLable.Size = new System.Drawing.Size(27, 13);
            this.versusLable.TabIndex = 19;
            this.versusLable.Text = "-VS-";
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Location = new System.Drawing.Point(410, 186);
            this.teamOneName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(63, 13);
            this.teamOneName.TabIndex = 20;
            this.teamOneName.Text = "<team one>";
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.Location = new System.Drawing.Point(13, 201);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(355, 249);
            this.matchupListBox.TabIndex = 18;
            // 
            // UnplayedOnlyCheckBox
            // 
            this.UnplayedOnlyCheckBox.AutoSize = true;
            this.UnplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckBox.Location = new System.Drawing.Point(107, 137);
            this.UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            this.UnplayedOnlyCheckBox.Size = new System.Drawing.Size(89, 17);
            this.UnplayedOnlyCheckBox.TabIndex = 17;
            this.UnplayedOnlyCheckBox.Text = "UnplayedOnly";
            this.UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(107, 86);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(251, 21);
            this.roundDropDown.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Round";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentName.Location = new System.Drawing.Point(208, 1);
            this.TournamentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(150, 50);
            this.TournamentName.TabIndex = 14;
            this.TournamentName.Text = "<none>";
            // 
            // headerLable
            // 
            this.headerLable.AutoSize = true;
            this.headerLable.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLable.Location = new System.Drawing.Point(4, 3);
            this.headerLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLable.Name = "headerLable";
            this.headerLable.Size = new System.Drawing.Size(214, 50);
            this.headerLable.TabIndex = 13;
            this.headerLable.Text = "Tournament:";
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 501);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.temTwoScoreText);
            this.Controls.Add(this.teamTwoScoreLable);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.teamOneScoreLable);
            this.Controls.Add(this.versusLable);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.UnplayedOnlyCheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.headerLable);
            this.Name = "TournamentViewer";
            this.Text = "TournamentViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.TextBox temTwoScoreText;
        private System.Windows.Forms.Label teamTwoScoreLable;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.Label teamOneScoreLable;
        private System.Windows.Forms.Label versusLable;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckBox;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label headerLable;
    }
}