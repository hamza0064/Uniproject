
namespace Pos_ShoeRetail_
{
    partial class ViewService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewService));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_Receipt = new System.Windows.Forms.RichTextBox();
            this.txt_print = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_servicecharges = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_deliverdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_Phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Address = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_customername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_service = new Guna.UI.WinForms.GunaLabel();
            this.txt_purshaseddate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_back = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_newservice = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_Size = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_brand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_color = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_productID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // txt_Receipt
            // 
            this.txt_Receipt.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Receipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Receipt.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Receipt.Location = new System.Drawing.Point(479, 37);
            this.txt_Receipt.Name = "txt_Receipt";
            this.txt_Receipt.ReadOnly = true;
            this.txt_Receipt.Size = new System.Drawing.Size(417, 523);
            this.txt_Receipt.TabIndex = 62;
            this.txt_Receipt.Text = "";
            // 
            // txt_print
            // 
            this.txt_print.Animated = true;
            this.txt_print.AutoRoundedCorners = true;
            this.txt_print.BackColor = System.Drawing.Color.Transparent;
            this.txt_print.BorderRadius = 17;
            this.txt_print.CheckedState.Parent = this.txt_print;
            this.txt_print.CustomImages.Parent = this.txt_print;
            this.txt_print.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_print.ForeColor = System.Drawing.Color.White;
            this.txt_print.HoverState.Parent = this.txt_print;
            this.txt_print.Location = new System.Drawing.Point(292, 584);
            this.txt_print.Name = "txt_print";
            this.txt_print.ShadowDecoration.Parent = this.txt_print;
            this.txt_print.Size = new System.Drawing.Size(78, 37);
            this.txt_print.TabIndex = 61;
            this.txt_print.Text = "Print";
            this.txt_print.Click += new System.EventHandler(this.txt_print_Click_1);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel2.Location = new System.Drawing.Point(704, 563);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(92, 19);
            this.gunaLabel2.TabIndex = 59;
            this.gunaLabel2.Text = "Deliver Date";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(484, 563);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(112, 19);
            this.gunaLabel1.TabIndex = 58;
            this.gunaLabel1.Text = "Purshased Date";
            // 
            // txt_servicecharges
            // 
            this.txt_servicecharges.Animated = true;
            this.txt_servicecharges.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_servicecharges.BorderRadius = 8;
            this.txt_servicecharges.BorderThickness = 2;
            this.txt_servicecharges.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_servicecharges.DefaultText = "";
            this.txt_servicecharges.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_servicecharges.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_servicecharges.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_servicecharges.DisabledState.Parent = this.txt_servicecharges;
            this.txt_servicecharges.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_servicecharges.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_servicecharges.FocusedState.Parent = this.txt_servicecharges;
            this.txt_servicecharges.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_servicecharges.HoverState.Parent = this.txt_servicecharges;
            this.txt_servicecharges.Location = new System.Drawing.Point(254, 409);
            this.txt_servicecharges.Name = "txt_servicecharges";
            this.txt_servicecharges.PasswordChar = '\0';
            this.txt_servicecharges.PlaceholderText = "Service Charges";
            this.txt_servicecharges.ReadOnly = true;
            this.txt_servicecharges.SelectedText = "";
            this.txt_servicecharges.ShadowDecoration.Parent = this.txt_servicecharges;
            this.txt_servicecharges.Size = new System.Drawing.Size(200, 36);
            this.txt_servicecharges.TabIndex = 57;
            // 
            // txt_deliverdate
            // 
            this.txt_deliverdate.Animated = true;
            this.txt_deliverdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txt_deliverdate.BorderRadius = 8;
            this.txt_deliverdate.BorderThickness = 2;
            this.txt_deliverdate.CheckedState.Parent = this.txt_deliverdate;
            this.txt_deliverdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_deliverdate.HoverState.Parent = this.txt_deliverdate;
            this.txt_deliverdate.Location = new System.Drawing.Point(699, 585);
            this.txt_deliverdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_deliverdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_deliverdate.Name = "txt_deliverdate";
            this.txt_deliverdate.ShadowDecoration.Parent = this.txt_deliverdate;
            this.txt_deliverdate.Size = new System.Drawing.Size(200, 36);
            this.txt_deliverdate.TabIndex = 56;
            this.txt_deliverdate.Value = new System.DateTime(2021, 5, 20, 22, 19, 52, 712);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Animated = true;
            this.txt_Phone.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_Phone.BorderRadius = 8;
            this.txt_Phone.BorderThickness = 2;
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.DefaultText = "";
            this.txt_Phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.DisabledState.Parent = this.txt_Phone;
            this.txt_Phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.FocusedState.Parent = this.txt_Phone;
            this.txt_Phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Phone.HoverState.Parent = this.txt_Phone;
            this.txt_Phone.Location = new System.Drawing.Point(254, 353);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '\0';
            this.txt_Phone.PlaceholderText = "Phone";
            this.txt_Phone.ReadOnly = true;
            this.txt_Phone.SelectedText = "";
            this.txt_Phone.ShadowDecoration.Parent = this.txt_Phone;
            this.txt_Phone.Size = new System.Drawing.Size(200, 36);
            this.txt_Phone.TabIndex = 55;
            // 
            // txt_Address
            // 
            this.txt_Address.Animated = true;
            this.txt_Address.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_Address.BorderRadius = 8;
            this.txt_Address.BorderThickness = 2;
            this.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Address.DefaultText = "";
            this.txt_Address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Address.DisabledState.Parent = this.txt_Address;
            this.txt_Address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Address.FocusedState.Parent = this.txt_Address;
            this.txt_Address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Address.HoverState.Parent = this.txt_Address;
            this.txt_Address.Location = new System.Drawing.Point(254, 301);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PasswordChar = '\0';
            this.txt_Address.PlaceholderText = "Address";
            this.txt_Address.ReadOnly = true;
            this.txt_Address.SelectedText = "";
            this.txt_Address.ShadowDecoration.Parent = this.txt_Address;
            this.txt_Address.Size = new System.Drawing.Size(200, 36);
            this.txt_Address.TabIndex = 54;
            // 
            // txt_customername
            // 
            this.txt_customername.Animated = true;
            this.txt_customername.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_customername.BorderRadius = 8;
            this.txt_customername.BorderThickness = 2;
            this.txt_customername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customername.DefaultText = "";
            this.txt_customername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_customername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_customername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customername.DisabledState.Parent = this.txt_customername;
            this.txt_customername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customername.FocusedState.Parent = this.txt_customername;
            this.txt_customername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_customername.HoverState.Parent = this.txt_customername;
            this.txt_customername.Location = new System.Drawing.Point(254, 245);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.PasswordChar = '\0';
            this.txt_customername.PlaceholderText = "Customer Name";
            this.txt_customername.ReadOnly = true;
            this.txt_customername.SelectedText = "";
            this.txt_customername.ShadowDecoration.Parent = this.txt_customername;
            this.txt_customername.Size = new System.Drawing.Size(200, 36);
            this.txt_customername.TabIndex = 53;
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
            this.txt_Search.Location = new System.Drawing.Point(15, 245);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Customer ID";
            this.txt_Search.SelectedText = "";
            this.txt_Search.ShadowDecoration.Parent = this.txt_Search;
            this.txt_Search.Size = new System.Drawing.Size(200, 36);
            this.txt_Search.TabIndex = 52;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // txt_service
            // 
            this.txt_service.AutoSize = true;
            this.txt_service.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.txt_service.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_service.Location = new System.Drawing.Point(138, 193);
            this.txt_service.Name = "txt_service";
            this.txt_service.Size = new System.Drawing.Size(198, 37);
            this.txt_service.TabIndex = 51;
            this.txt_service.Text = "VIEW SERVICE";
            // 
            // txt_purshaseddate
            // 
            this.txt_purshaseddate.Animated = true;
            this.txt_purshaseddate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txt_purshaseddate.BorderRadius = 8;
            this.txt_purshaseddate.BorderThickness = 2;
            this.txt_purshaseddate.CheckedState.Parent = this.txt_purshaseddate;
            this.txt_purshaseddate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txt_purshaseddate.HoverState.Parent = this.txt_purshaseddate;
            this.txt_purshaseddate.Location = new System.Drawing.Point(479, 585);
            this.txt_purshaseddate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_purshaseddate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_purshaseddate.Name = "txt_purshaseddate";
            this.txt_purshaseddate.ShadowDecoration.Parent = this.txt_purshaseddate;
            this.txt_purshaseddate.Size = new System.Drawing.Size(200, 36);
            this.txt_purshaseddate.TabIndex = 50;
            this.txt_purshaseddate.Value = new System.DateTime(2021, 5, 20, 22, 19, 52, 712);
            // 
            // btn_back
            // 
            this.btn_back.Animated = true;
            this.btn_back.AutoRoundedCorners = true;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderRadius = 17;
            this.btn_back.CheckedState.Parent = this.btn_back;
            this.btn_back.CustomImages.Parent = this.btn_back;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.HoverState.Parent = this.btn_back;
            this.btn_back.Location = new System.Drawing.Point(376, 584);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShadowDecoration.Parent = this.btn_back;
            this.btn_back.Size = new System.Drawing.Size(78, 37);
            this.btn_back.TabIndex = 49;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_newservice
            // 
            this.btn_newservice.Animated = true;
            this.btn_newservice.AutoRoundedCorners = true;
            this.btn_newservice.BackColor = System.Drawing.Color.Transparent;
            this.btn_newservice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btn_newservice.BorderRadius = 17;
            this.btn_newservice.CheckedState.Parent = this.btn_newservice;
            this.btn_newservice.CustomImages.Parent = this.btn_newservice;
            this.btn_newservice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newservice.ForeColor = System.Drawing.Color.White;
            this.btn_newservice.HoverState.Parent = this.btn_newservice;
            this.btn_newservice.Location = new System.Drawing.Point(292, 532);
            this.btn_newservice.Name = "btn_newservice";
            this.btn_newservice.ShadowDecoration.Parent = this.btn_newservice;
            this.btn_newservice.Size = new System.Drawing.Size(162, 37);
            this.btn_newservice.TabIndex = 48;
            this.btn_newservice.Text = "Invoice";
            this.btn_newservice.Click += new System.EventHandler(this.btn_newservice_Click);
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
            this.txt_Size.Location = new System.Drawing.Point(15, 472);
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.PasswordChar = '\0';
            this.txt_Size.PlaceholderText = "Size";
            this.txt_Size.ReadOnly = true;
            this.txt_Size.SelectedText = "";
            this.txt_Size.ShadowDecoration.Parent = this.txt_Size;
            this.txt_Size.Size = new System.Drawing.Size(200, 36);
            this.txt_Size.TabIndex = 46;
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
            this.txt_gender.Location = new System.Drawing.Point(15, 409);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.ShadowDecoration.Parent = this.txt_gender;
            this.txt_gender.Size = new System.Drawing.Size(200, 36);
            this.txt_gender.StartIndex = 1;
            this.txt_gender.TabIndex = 45;
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
            this.txt_brand.Location = new System.Drawing.Point(15, 532);
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.ShadowDecoration.Parent = this.txt_brand;
            this.txt_brand.Size = new System.Drawing.Size(200, 36);
            this.txt_brand.StartIndex = 1;
            this.txt_brand.TabIndex = 44;
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
            this.txt_price.Location = new System.Drawing.Point(15, 585);
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.PlaceholderText = "Price";
            this.txt_price.ReadOnly = true;
            this.txt_price.SelectedText = "";
            this.txt_price.ShadowDecoration.Parent = this.txt_price;
            this.txt_price.Size = new System.Drawing.Size(200, 36);
            this.txt_price.TabIndex = 43;
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
            this.txt_color.Location = new System.Drawing.Point(15, 353);
            this.txt_color.Name = "txt_color";
            this.txt_color.ShadowDecoration.Parent = this.txt_color;
            this.txt_color.Size = new System.Drawing.Size(200, 36);
            this.txt_color.StartIndex = 1;
            this.txt_color.TabIndex = 42;
            // 
            // txt_productID
            // 
            this.txt_productID.Animated = true;
            this.txt_productID.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_productID.BorderRadius = 8;
            this.txt_productID.BorderThickness = 2;
            this.txt_productID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_productID.DefaultText = "";
            this.txt_productID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_productID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_productID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_productID.DisabledState.Parent = this.txt_productID;
            this.txt_productID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_productID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_productID.FocusedState.Parent = this.txt_productID;
            this.txt_productID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_productID.HoverState.Parent = this.txt_productID;
            this.txt_productID.Location = new System.Drawing.Point(15, 301);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.PasswordChar = '\0';
            this.txt_productID.PlaceholderText = "Product ID";
            this.txt_productID.ReadOnly = true;
            this.txt_productID.SelectedText = "";
            this.txt_productID.ShadowDecoration.Parent = this.txt_productID;
            this.txt_productID.Size = new System.Drawing.Size(200, 36);
            this.txt_productID.TabIndex = 41;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Pos_ShoeRetail_.Properties.Resources.addd;
            this.guna2PictureBox1.Location = new System.Drawing.Point(113, 15);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(248, 215);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 47;
            this.guna2PictureBox1.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(878, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(25, 29);
            this.guna2ControlBox1.TabIndex = 63;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // ViewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(915, 636);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.txt_Receipt);
            this.Controls.Add(this.txt_print);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txt_servicecharges);
            this.Controls.Add(this.txt_deliverdate);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_customername);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.txt_service);
            this.Controls.Add(this.txt_purshaseddate);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_newservice);
            this.Controls.Add(this.txt_Size);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_brand);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.txt_productID);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewService";
            this.Text = "ViewService";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.RichTextBox txt_Receipt;
        private Guna.UI2.WinForms.Guna2GradientButton txt_print;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_servicecharges;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_deliverdate;
        private Guna.UI2.WinForms.Guna2TextBox txt_Phone;
        private Guna.UI2.WinForms.Guna2TextBox txt_Address;
        private Guna.UI2.WinForms.Guna2TextBox txt_customername;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI.WinForms.GunaLabel txt_service;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_purshaseddate;
        private Guna.UI2.WinForms.Guna2GradientButton btn_back;
        private Guna.UI2.WinForms.Guna2GradientButton btn_newservice;
        private Guna.UI2.WinForms.Guna2TextBox txt_Size;
        private Guna.UI2.WinForms.Guna2ComboBox txt_gender;
        private Guna.UI2.WinForms.Guna2ComboBox txt_brand;
        private Guna.UI2.WinForms.Guna2TextBox txt_price;
        private Guna.UI2.WinForms.Guna2ComboBox txt_color;
        private Guna.UI2.WinForms.Guna2TextBox txt_productID;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}