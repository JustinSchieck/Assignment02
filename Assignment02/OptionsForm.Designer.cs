namespace Assignment02
{
    partial class OptionsForm
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ColorBox = new System.Windows.Forms.GroupBox();
            this.GreyRadioButton = new System.Windows.Forms.RadioButton();
            this.PinkRadioButton = new System.Windows.Forms.RadioButton();
            this.DarkRadioButton = new System.Windows.Forms.RadioButton();
            this.BlueRadioButton = new System.Windows.Forms.RadioButton();
            this.RedRadioButton = new System.Windows.Forms.RadioButton();
            this.ClassicRadioButton = new System.Windows.Forms.RadioButton();
            this.FontButton = new System.Windows.Forms.Button();
            this.FormFontDialog = new System.Windows.Forms.FontDialog();
            this.ColorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptButton.Location = new System.Drawing.Point(13, 409);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(119, 57);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this._AcceptButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(315, 408);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(117, 57);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this._CancelButton_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.Controls.Add(this.GreyRadioButton);
            this.ColorBox.Controls.Add(this.PinkRadioButton);
            this.ColorBox.Controls.Add(this.DarkRadioButton);
            this.ColorBox.Controls.Add(this.BlueRadioButton);
            this.ColorBox.Controls.Add(this.RedRadioButton);
            this.ColorBox.Controls.Add(this.ClassicRadioButton);
            this.ColorBox.Location = new System.Drawing.Point(13, 13);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(435, 266);
            this.ColorBox.TabIndex = 2;
            this.ColorBox.TabStop = false;
            this.ColorBox.Text = "Color Options";
            // 
            // GreyRadioButton
            // 
            this.GreyRadioButton.AutoSize = true;
            this.GreyRadioButton.Location = new System.Drawing.Point(245, 203);
            this.GreyRadioButton.Name = "GreyRadioButton";
            this.GreyRadioButton.Size = new System.Drawing.Size(60, 21);
            this.GreyRadioButton.TabIndex = 5;
            this.GreyRadioButton.Text = "Grey";
            this.GreyRadioButton.UseVisualStyleBackColor = true;
            this.GreyRadioButton.CheckedChanged += new System.EventHandler(this._FormLayoutRadioButton_CheckedChanged);
            // 
            // PinkRadioButton
            // 
            this.PinkRadioButton.AutoSize = true;
            this.PinkRadioButton.Location = new System.Drawing.Point(245, 123);
            this.PinkRadioButton.Name = "PinkRadioButton";
            this.PinkRadioButton.Size = new System.Drawing.Size(94, 21);
            this.PinkRadioButton.TabIndex = 4;
            this.PinkRadioButton.Text = "Neon Pink";
            this.PinkRadioButton.UseVisualStyleBackColor = true;
            this.PinkRadioButton.CheckedChanged += new System.EventHandler(this._FormLayoutRadioButton_CheckedChanged);
            // 
            // DarkRadioButton
            // 
            this.DarkRadioButton.AutoSize = true;
            this.DarkRadioButton.Location = new System.Drawing.Point(245, 37);
            this.DarkRadioButton.Name = "DarkRadioButton";
            this.DarkRadioButton.Size = new System.Drawing.Size(59, 21);
            this.DarkRadioButton.TabIndex = 3;
            this.DarkRadioButton.Text = "Dark";
            this.DarkRadioButton.UseVisualStyleBackColor = true;
            this.DarkRadioButton.CheckedChanged += new System.EventHandler(this._FormLayoutRadioButton_CheckedChanged);
            // 
            // BlueRadioButton
            // 
            this.BlueRadioButton.AutoSize = true;
            this.BlueRadioButton.Location = new System.Drawing.Point(44, 203);
            this.BlueRadioButton.Name = "BlueRadioButton";
            this.BlueRadioButton.Size = new System.Drawing.Size(57, 21);
            this.BlueRadioButton.TabIndex = 2;
            this.BlueRadioButton.Text = "Blue";
            this.BlueRadioButton.UseVisualStyleBackColor = true;
            this.BlueRadioButton.CheckedChanged += new System.EventHandler(this._FormLayoutRadioButton_CheckedChanged);
            // 
            // RedRadioButton
            // 
            this.RedRadioButton.AutoSize = true;
            this.RedRadioButton.Location = new System.Drawing.Point(44, 123);
            this.RedRadioButton.Name = "RedRadioButton";
            this.RedRadioButton.Size = new System.Drawing.Size(55, 21);
            this.RedRadioButton.TabIndex = 1;
            this.RedRadioButton.Text = "Red";
            this.RedRadioButton.UseVisualStyleBackColor = true;
            this.RedRadioButton.CheckedChanged += new System.EventHandler(this._FormLayoutRadioButton_CheckedChanged);
            // 
            // ClassicRadioButton
            // 
            this.ClassicRadioButton.AutoSize = true;
            this.ClassicRadioButton.Checked = true;
            this.ClassicRadioButton.Location = new System.Drawing.Point(44, 37);
            this.ClassicRadioButton.Name = "ClassicRadioButton";
            this.ClassicRadioButton.Size = new System.Drawing.Size(73, 21);
            this.ClassicRadioButton.TabIndex = 0;
            this.ClassicRadioButton.TabStop = true;
            this.ClassicRadioButton.Text = "Classic";
            this.ClassicRadioButton.UseVisualStyleBackColor = true;
            this.ClassicRadioButton.CheckedChanged += new System.EventHandler(this._FormLayoutRadioButton_CheckedChanged);
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(161, 408);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(122, 56);
            this.FontButton.TabIndex = 3;
            this.FontButton.Text = "Font";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this._FontButton_Click);
            // 
            // FormFontDialog
            // 
            this.FormFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormFontDialog.MaxSize = 22;
            this.FormFontDialog.MinSize = 8;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 501);
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.ColorBox.ResumeLayout(false);
            this.ColorBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox ColorBox;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.RadioButton GreyRadioButton;
        private System.Windows.Forms.RadioButton PinkRadioButton;
        private System.Windows.Forms.RadioButton DarkRadioButton;
        private System.Windows.Forms.RadioButton BlueRadioButton;
        private System.Windows.Forms.RadioButton RedRadioButton;
        private System.Windows.Forms.RadioButton ClassicRadioButton;
        private System.Windows.Forms.FontDialog FormFontDialog;
    }
}