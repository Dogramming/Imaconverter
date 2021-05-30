
namespace Imaconverter_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.checkmark1 = new System.Windows.Forms.PictureBox();
            this.button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkmark1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 13;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(71, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imaconventer 2.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.Animated = true;
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            ".png",
            ".jpg",
            ".bmp",
            ".ico"});
            this.comboBox1.BackColor = System.Drawing.Color.Transparent;
            this.comboBox1.BorderColor = System.Drawing.Color.Gray;
            this.comboBox1.BorderRadius = 10;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.FocusedColor = System.Drawing.Color.Gray;
            this.comboBox1.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.comboBox1.FocusedState.Parent = this.comboBox1;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.ForeColor = System.Drawing.Color.Gray;
            this.comboBox1.HoverState.Parent = this.comboBox1;
            this.comboBox1.ItemHeight = 30;
            this.comboBox1.Items.AddRange(new object[] {
            ".png",
            ".jpg",
            ".bmp",
            ".ico"});
            this.comboBox1.ItemsAppearance.Parent = this.comboBox1;
            this.comboBox1.Location = new System.Drawing.Point(24, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.ShadowDecoration.Parent = this.comboBox1;
            this.comboBox1.Size = new System.Drawing.Size(140, 36);
            this.comboBox1.TabIndex = 15;
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.BorderRadius = 13;
            this.guna2ProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(9, 357);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(173, 30);
            this.guna2ProgressBar1.TabIndex = 17;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // closeButton
            // 
            this.closeButton.Animated = true;
            this.closeButton.BorderRadius = 13;
            this.closeButton.CheckedState.Parent = this.closeButton;
            this.closeButton.CustomImages.Parent = this.closeButton;
            this.closeButton.CustomizableEdges.BottomRight = false;
            this.closeButton.CustomizableEdges.TopLeft = false;
            this.closeButton.CustomizableEdges.TopRight = false;
            this.closeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Gray;
            this.closeButton.HoverState.Parent = this.closeButton;
            this.closeButton.Location = new System.Drawing.Point(749, -1);
            this.closeButton.Name = "closeButton";
            this.closeButton.ShadowDecoration.Parent = this.closeButton;
            this.closeButton.Size = new System.Drawing.Size(52, 45);
            this.closeButton.TabIndex = 19;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.CustomizableEdges.TopLeft = false;
            this.guna2Button1.CustomizableEdges.TopRight = false;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Imaconverter_2._0.Properties.Resources.Reload;
            this.guna2Button1.Location = new System.Drawing.Point(610, -2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.BorderRadius = 0;
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.guna2Button1.Size = new System.Drawing.Size(130, 46);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Reset";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // button1
            // 
            this.button1.Animated = true;
            this.button1.AutoRoundedCorners = true;
            this.button1.BorderRadius = 35;
            this.button1.CheckedState.Parent = this.button1;
            this.button1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.button1.CustomImages.Parent = this.button1;
            this.button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.HoverState.Parent = this.button1;
            this.button1.Image = global::Imaconverter_2._0.Properties.Resources.right_arrow_removebg_preview_png;
            this.button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button1.ImageSize = new System.Drawing.Size(30, 40);
            this.button1.Location = new System.Drawing.Point(8, 253);
            this.button1.Name = "button1";
            this.button1.ShadowDecoration.Parent = this.button1;
            this.button1.Size = new System.Drawing.Size(176, 73);
            this.button1.TabIndex = 16;
            this.button1.Text = "Convert image";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkmark1
            // 
            this.checkmark1.Image = global::Imaconverter_2._0.Properties.Resources.Checkmark__2_1;
            this.checkmark1.Location = new System.Drawing.Point(169, 101);
            this.checkmark1.Name = "checkmark1";
            this.checkmark1.Size = new System.Drawing.Size(59, 51);
            this.checkmark1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkmark1.TabIndex = 14;
            this.checkmark1.TabStop = false;
            this.checkmark1.Click += new System.EventHandler(this.checkmark1_Click);
            // 
            // button2
            // 
            this.button2.Animated = true;
            this.button2.AutoRoundedCorners = true;
            this.button2.BorderRadius = 28;
            this.button2.CheckedState.Parent = this.button2;
            this.button2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.button2.CustomImages.Parent = this.button2;
            this.button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.HoverState.Parent = this.button2;
            this.button2.Image = global::Imaconverter_2._0.Properties.Resources.insert_picture_icon_png;
            this.button2.ImageOffset = new System.Drawing.Point(15, 0);
            this.button2.ImageSize = new System.Drawing.Size(30, 30);
            this.button2.Location = new System.Drawing.Point(24, 96);
            this.button2.Name = "button2";
            this.button2.ShadowDecoration.Parent = this.button2;
            this.button2.Size = new System.Drawing.Size(140, 58);
            this.button2.TabIndex = 12;
            this.button2.Text = "Choose image";
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Imaconverter_2._0.Properties.Resources._1c3554f145f15870b670be74e22d971b;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(238, 102);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.guna2TextBox1.Multiline = true;
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(502, 254);
            this.guna2TextBox1.TabIndex = 20;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2ProgressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkmark1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imaconverter 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkmark1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox checkmark1;
        private Guna.UI2.WinForms.Guna2Button button2;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}

