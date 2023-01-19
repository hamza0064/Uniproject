
namespace Pos_ShoeRetail_
{
    partial class UpdateItem
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
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_close = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Update = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_Size = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_brand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_color = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_product = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.guna2PictureBox1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Pos_ShoeRetail_.Properties.Resources.addd;
            this.guna2PictureBox1.Location = new System.Drawing.Point(121, -13);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(248, 215);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 25;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 14;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txt_date
            // 
            this.txt_date.Animated = true;
            this.txt_date.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txt_date.BorderRadius = 8;
            this.txt_date.BorderThickness = 2;
            this.txt_date.CheckedState.Parent = this.txt_date;
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_date.HoverState.Parent = this.txt_date;
            this.txt_date.Location = new System.Drawing.Point(25, 414);
            this.txt_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_date.Name = "txt_date";
            this.txt_date.ShadowDecoration.Parent = this.txt_date;
            this.txt_date.Size = new System.Drawing.Size(200, 36);
            this.txt_date.TabIndex = 28;
            this.txt_date.Value = new System.DateTime(2021, 5, 20, 22, 19, 52, 712);
            // 
            // btn_close
            // 
            this.btn_close.Animated = true;
            this.btn_close.AutoRoundedCorners = true;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BorderRadius = 17;
            this.btn_close.CheckedState.Parent = this.btn_close;
            this.btn_close.CustomImages.Parent = this.btn_close;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.HoverState.Parent = this.btn_close;
            this.btn_close.Location = new System.Drawing.Point(362, 458);
            this.btn_close.Name = "btn_close";
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(102, 37);
            this.btn_close.TabIndex = 27;
            this.btn_close.Text = "Cancel";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Animated = true;
            this.btn_Update.AutoRoundedCorners = true;
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_Update.BorderRadius = 17;
            this.btn_Update.CheckedState.Parent = this.btn_Update;
            this.btn_Update.CustomImages.Parent = this.btn_Update;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.HoverState.Parent = this.btn_Update;
            this.btn_Update.Location = new System.Drawing.Point(244, 458);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.ShadowDecoration.Parent = this.btn_Update;
            this.btn_Update.Size = new System.Drawing.Size(102, 37);
            this.btn_Update.TabIndex = 26;
            this.btn_Update.Text = "Update";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_Size
            // 
            this.txt_Size.Animated = true;
            this.txt_Size.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_Size.BorderRadius = 8;
            this.txt_Size.BorderThickness = 2;
            this.txt_Size.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Size.DefaultText = "";
            this.txt_Size.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Size.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Size.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Size.DisabledState.Parent = this.txt_Size;
            this.txt_Size.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Size.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Size.FocusedState.Parent = this.txt_Size;
            this.txt_Size.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Size.HoverState.Parent = this.txt_Size;
            this.txt_Size.Location = new System.Drawing.Point(264, 354);
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.PasswordChar = '\0';
            this.txt_Size.PlaceholderText = "Size";
            this.txt_Size.SelectedText = "";
            this.txt_Size.ShadowDecoration.Parent = this.txt_Size;
            this.txt_Size.Size = new System.Drawing.Size(200, 36);
            this.txt_Size.TabIndex = 24;
            // 
            // txt_gender
            // 
            this.txt_gender.Animated = true;
            this.txt_gender.BackColor = System.Drawing.Color.Transparent;
            this.txt_gender.BorderRadius = 8;
            this.txt_gender.BorderThickness = 2;
            this.txt_gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_gender.FocusedColor = System.Drawing.Color.Empty;
            this.txt_gender.FocusedState.Parent = this.txt_gender;
            this.txt_gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_gender.FormattingEnabled = true;
            this.txt_gender.HoverState.Parent = this.txt_gender;
            this.txt_gender.ItemHeight = 30;
            this.txt_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Kids"});
            this.txt_gender.ItemsAppearance.Parent = this.txt_gender;
            this.txt_gender.Location = new System.Drawing.Point(25, 356);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.ShadowDecoration.Parent = this.txt_gender;
            this.txt_gender.Size = new System.Drawing.Size(200, 36);
            this.txt_gender.StartIndex = 1;
            this.txt_gender.TabIndex = 23;
            // 
            // txt_brand
            // 
            this.txt_brand.Animated = true;
            this.txt_brand.BackColor = System.Drawing.Color.Transparent;
            this.txt_brand.BorderRadius = 8;
            this.txt_brand.BorderThickness = 2;
            this.txt_brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_brand.FocusedColor = System.Drawing.Color.Empty;
            this.txt_brand.FocusedState.Parent = this.txt_brand;
            this.txt_brand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_brand.FormattingEnabled = true;
            this.txt_brand.HoverState.Parent = this.txt_brand;
            this.txt_brand.ItemHeight = 30;
            this.txt_brand.Items.AddRange(new object[] {
            "Jordan",
            "Air",
            "360",
            "Sneaker"});
            this.txt_brand.ItemsAppearance.Parent = this.txt_brand;
            this.txt_brand.Location = new System.Drawing.Point(264, 288);
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.ShadowDecoration.Parent = this.txt_brand;
            this.txt_brand.Size = new System.Drawing.Size(200, 36);
            this.txt_brand.StartIndex = 1;
            this.txt_brand.TabIndex = 22;
            // 
            // txt_price
            // 
            this.txt_price.Animated = true;
            this.txt_price.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_price.BorderRadius = 8;
            this.txt_price.BorderThickness = 2;
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.DefaultText = "";
            this.txt_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.DisabledState.Parent = this.txt_price;
            this.txt_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.FocusedState.Parent = this.txt_price;
            this.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.HoverState.Parent = this.txt_price;
            this.txt_price.Location = new System.Drawing.Point(264, 228);
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.PlaceholderText = "Price";
            this.txt_price.SelectedText = "";
            this.txt_price.ShadowDecoration.Parent = this.txt_price;
            this.txt_price.Size = new System.Drawing.Size(200, 36);
            this.txt_price.TabIndex = 21;
            // 
            // txt_color
            // 
            this.txt_color.Animated = true;
            this.txt_color.BackColor = System.Drawing.Color.Transparent;
            this.txt_color.BorderRadius = 8;
            this.txt_color.BorderThickness = 2;
            this.txt_color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_color.FocusedColor = System.Drawing.Color.Empty;
            this.txt_color.FocusedState.Parent = this.txt_color;
            this.txt_color.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_color.FormattingEnabled = true;
            this.txt_color.HoverState.Parent = this.txt_color;
            this.txt_color.ItemHeight = 30;
            this.txt_color.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Yellow",
            "Green"});
            this.txt_color.ItemsAppearance.Parent = this.txt_color;
            this.txt_color.Location = new System.Drawing.Point(25, 290);
            this.txt_color.Name = "txt_color";
            this.txt_color.ShadowDecoration.Parent = this.txt_color;
            this.txt_color.Size = new System.Drawing.Size(200, 36);
            this.txt_color.StartIndex = 1;
            this.txt_color.TabIndex = 20;
            // 
            // txt_Search
            // 
            this.txt_Search.Animated = true;
            this.txt_Search.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_Search.BorderRadius = 8;
            this.txt_Search.BorderThickness = 2;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.DisabledState.Parent = this.txt_Search;
            this.txt_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.FocusedState.Parent = this.txt_Search;
            this.txt_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Search.HoverState.Parent = this.txt_Search;
            this.txt_Search.Location = new System.Drawing.Point(25, 166);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Search ID";
            this.txt_Search.SelectedText = "";
            this.txt_Search.ShadowDecoration.Parent = this.txt_Search;
            this.txt_Search.Size = new System.Drawing.Size(200, 36);
            this.txt_Search.TabIndex = 19;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // txt_product
            // 
            this.txt_product.Animated = true;
            this.txt_product.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_product.BorderRadius = 8;
            this.txt_product.BorderThickness = 2;
            this.txt_product.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_product.DefaultText = "";
            this.txt_product.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product.DisabledState.Parent = this.txt_product;
            this.txt_product.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product.FocusedState.Parent = this.txt_product;
            this.txt_product.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product.HoverState.Parent = this.txt_product;
            this.txt_product.Location = new System.Drawing.Point(25, 228);
            this.txt_product.Name = "txt_product";
            this.txt_product.PasswordChar = '\0';
            this.txt_product.PlaceholderText = "Product ID";
            this.txt_product.SelectedText = "";
            this.txt_product.ShadowDecoration.Parent = this.txt_product;
            this.txt_product.Size = new System.Drawing.Size(200, 36);
            this.txt_product.TabIndex = 29;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(449, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(25, 29);
            this.guna2ControlBox1.TabIndex = 30;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // UpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(486, 516);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txt_Size);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_brand);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateItem";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_date;
        private Guna.UI2.WinForms.Guna2GradientButton btn_close;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Update;
        private Guna.UI2.WinForms.Guna2TextBox txt_Size;
        private Guna.UI2.WinForms.Guna2ComboBox txt_gender;
        private Guna.UI2.WinForms.Guna2ComboBox txt_brand;
        private Guna.UI2.WinForms.Guna2TextBox txt_price;
        private Guna.UI2.WinForms.Guna2ComboBox txt_color;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_product;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}