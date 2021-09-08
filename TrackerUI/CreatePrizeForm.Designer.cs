
namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.orLable = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLable = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizeAmountLable = new System.Windows.Forms.Label();
            this.prizePrecentageValue = new System.Windows.Forms.TextBox();
            this.prizePrecentageLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNumberLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizeButton.Location = new System.Drawing.Point(73, 325);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(290, 108);
            this.createPrizeButton.TabIndex = 27;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // orLable
            // 
            this.orLable.AutoSize = true;
            this.orLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.orLable.Location = new System.Drawing.Point(22, 229);
            this.orLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orLable.Name = "orLable";
            this.orLable.Size = new System.Drawing.Size(45, 25);
            this.orLable.TabIndex = 26;
            this.orLable.Text = "-or-";
            // 
            // placeNameValue
            // 
            this.placeNameValue.Location = new System.Drawing.Point(219, 154);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(188, 20);
            this.placeNameValue.TabIndex = 25;
            // 
            // placeNameLable
            // 
            this.placeNameLable.AutoSize = true;
            this.placeNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.placeNameLable.Location = new System.Drawing.Point(22, 149);
            this.placeNameLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.placeNameLable.Name = "placeNameLable";
            this.placeNameLable.Size = new System.Drawing.Size(128, 25);
            this.placeNameLable.TabIndex = 24;
            this.placeNameLable.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.Location = new System.Drawing.Point(219, 199);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(188, 20);
            this.prizeAmountValue.TabIndex = 23;
            this.prizeAmountValue.Text = "0";
            // 
            // prizeAmountLable
            // 
            this.prizeAmountLable.AutoSize = true;
            this.prizeAmountLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizeAmountLable.Location = new System.Drawing.Point(22, 194);
            this.prizeAmountLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prizeAmountLable.Name = "prizeAmountLable";
            this.prizeAmountLable.Size = new System.Drawing.Size(140, 25);
            this.prizeAmountLable.TabIndex = 22;
            this.prizeAmountLable.Text = "Prize Amount";
            // 
            // prizePrecentageValue
            // 
            this.prizePrecentageValue.Location = new System.Drawing.Point(219, 269);
            this.prizePrecentageValue.Name = "prizePrecentageValue";
            this.prizePrecentageValue.Size = new System.Drawing.Size(188, 20);
            this.prizePrecentageValue.TabIndex = 21;
            this.prizePrecentageValue.Text = "0";
            // 
            // prizePrecentageLable
            // 
            this.prizePrecentageLable.AutoSize = true;
            this.prizePrecentageLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePrecentageLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizePrecentageLable.Location = new System.Drawing.Point(22, 264);
            this.prizePrecentageLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prizePrecentageLable.Name = "prizePrecentageLable";
            this.prizePrecentageLable.Size = new System.Drawing.Size(177, 25);
            this.prizePrecentageLable.TabIndex = 20;
            this.prizePrecentageLable.Text = "Prize Precentage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Location = new System.Drawing.Point(219, 109);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(188, 20);
            this.placeNumberValue.TabIndex = 19;
            // 
            // placeNumberLable
            // 
            this.placeNumberLable.AutoSize = true;
            this.placeNumberLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.placeNumberLable.Location = new System.Drawing.Point(22, 104);
            this.placeNumberLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.placeNumberLable.Name = "placeNumberLable";
            this.placeNumberLable.Size = new System.Drawing.Size(147, 25);
            this.placeNumberLable.TabIndex = 18;
            this.placeNumberLable.Text = "Place Number";
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 464);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLable);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNameLable);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.prizeAmountLable);
            this.Controls.Add(this.prizePrecentageValue);
            this.Controls.Add(this.prizePrecentageLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placeNumberLable);
            this.Name = "CreatePrizeForm";
            this.Text = "CreatePrize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label orLable;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.Label placeNameLable;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.Label prizeAmountLable;
        private System.Windows.Forms.TextBox prizePrecentageValue;
        private System.Windows.Forms.Label prizePrecentageLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.Label placeNumberLable;
    }
}