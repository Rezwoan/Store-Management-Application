namespace Store_Management_Application
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(materialButton2);
            panel1.Controls.Add(materialButton1);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(512, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 701);
            panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(60, 400);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(389, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 314);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(389, 23);
            textBox1.TabIndex = 7;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(258, 479);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(94, 36);
            materialButton2.TabIndex = 6;
            materialButton2.Text = "Clear";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(157, 479);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(94, 36);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "Login";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(60, 378);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(83, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Password : ";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(60, 292);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(53, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Email : ";
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.user_profile_icon_png_download_fa_user_circle_removebg_preview__1_;
            panel3.Location = new Point(157, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(195, 205);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 701);
            panel2.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 768);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LOGIN";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
