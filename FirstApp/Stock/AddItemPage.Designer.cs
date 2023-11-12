using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AddItemPage : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ItemNameLB = new Label();
            ItemNameTB = new TextBox();
            ItemNameTB.LostFocus += new EventHandler(ItemNameTB_LostFocus);
            NameLB = new Label();
            AttrNameTB = new TextBox();
            TypeLB = new Label();
            OptionalChB = new CheckBox();
            DefValLB = new Label();
            DefaultValueTB = new TextBox();
            ContextMenuStrip1 = new ContextMenuStrip(components);
            NotNowToolStripMenuItem = new ToolStripMenuItem();
            NotNowToolStripMenuItem.Click += new EventHandler(NotNowToolStripMenuItem_Click);
            UnKnownToolStripMenuItem = new ToolStripMenuItem();
            UnKnownToolStripMenuItem.Click += new EventHandler(UnKnownToolStripMenuItem_Click);
            ClearToolStripMenuItem = new ToolStripMenuItem();
            ClearToolStripMenuItem.Click += new EventHandler(ClearToolStripMenuItem_Click);
            AttrTypeCB = new ComboBox();
            AttrTypeCB.SelectedIndexChanged += new EventHandler(AttrTypeCB_SelectedIndexChanged);
            ConstantChB = new CheckBox();
            CurrencyChB = new CheckBox();
            TrueChB = new CheckBox();
            TrueChB.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            FalseChB = new CheckBox();
            FalseChB.CheckedChanged += new EventHandler(FalseChB_CheckedChanged);
            ListValuesCB = new ComboBox();
            AddAttributeButton = new FontAwesome.Sharp.IconButton();
            AddAttributeButton.Click += new EventHandler(AddAttributeButton_Click);
            EditListBT = new FontAwesome.Sharp.IconButton();
            EditListBT.Click += new EventHandler(EditListBT_Click);
            AttrCategoryCB = new ComboBox();
            CtgLB = new Label();
            SaveBT = new FontAwesome.Sharp.IconButton();
            SaveBT.Click += new EventHandler(SaveBT_Click);
            FillDockPNL = new Panel();
            SaleFP = new UserControl1();
            ProductFP = new UserControl1();
            PurchaseFP = new UserControl1();
            TopDockPNL = new Panel();
            AbrvLB = new Label();
            AbbreviationTB = new TextBox();
            FormulaBT = new FontAwesome.Sharp.IconButton();
            FormulaBT.Click += new EventHandler(FormulaBT_Click);
            DeleteBT = new FontAwesome.Sharp.IconButton();
            DeleteBT.Click += new EventHandler(DeleteBT_Click);
            ClearBT = new FontAwesome.Sharp.IconButton();
            ClearBT.Click += new EventHandler(ClearBT_Click);
            ContextMenuStrip1.SuspendLayout();
            FillDockPNL.SuspendLayout();
            TopDockPNL.SuspendLayout();
            SuspendLayout();
            // 
            // ItemNameLB
            // 
            ItemNameLB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ItemNameLB.AutoSize = true;
            ItemNameLB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemNameLB.ForeColor = Color.Peru;
            ItemNameLB.Location = new Point(49, 603);
            ItemNameLB.Margin = new Padding(4, 0, 4, 0);
            ItemNameLB.Name = "ItemNameLB";
            ItemNameLB.Size = new Size(158, 30);
            ItemNameLB.TabIndex = 249;
            ItemNameLB.Text = "Item-Name:";
            // 
            // ItemNameTB
            // 
            ItemNameTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ItemNameTB.Font = new Font("Century", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemNameTB.Location = new Point(223, 597);
            ItemNameTB.Margin = new Padding(4, 5, 4, 5);
            ItemNameTB.Name = "ItemNameTB";
            ItemNameTB.Size = new Size(293, 36);
            ItemNameTB.TabIndex = 248;
            // 
            // NameLB
            // 
            NameLB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NameLB.AutoSize = true;
            NameLB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLB.ForeColor = Color.Peru;
            NameLB.Location = new Point(1118, 594);
            NameLB.Margin = new Padding(4, 0, 4, 0);
            NameLB.Name = "NameLB";
            NameLB.Size = new Size(157, 30);
            NameLB.TabIndex = 252;
            NameLB.Text = "Attr.-Name:";
            // 
            // AttrNameTB
            // 
            AttrNameTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AttrNameTB.Font = new Font("Century", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AttrNameTB.Location = new Point(1312, 592);
            AttrNameTB.Margin = new Padding(4, 5, 4, 5);
            AttrNameTB.Name = "AttrNameTB";
            AttrNameTB.Size = new Size(293, 36);
            AttrNameTB.TabIndex = 251;
            // 
            // TypeLB
            // 
            TypeLB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TypeLB.AutoSize = true;
            TypeLB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            TypeLB.ForeColor = Color.Peru;
            TypeLB.Location = new Point(569, 657);
            TypeLB.Margin = new Padding(4, 0, 4, 0);
            TypeLB.Name = "TypeLB";
            TypeLB.Size = new Size(147, 30);
            TypeLB.TabIndex = 254;
            TypeLB.Text = "Attr.-Type:";
            // 
            // OptionalChB
            // 
            OptionalChB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OptionalChB.AutoSize = true;
            OptionalChB.BackColor = Color.Transparent;
            OptionalChB.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            OptionalChB.ForeColor = SystemColors.ActiveCaption;
            OptionalChB.Location = new Point(1309, 715);
            OptionalChB.Margin = new Padding(4, 5, 4, 5);
            OptionalChB.Name = "OptionalChB";
            OptionalChB.Size = new Size(159, 34);
            OptionalChB.TabIndex = 279;
            OptionalChB.TabStop = false;
            OptionalChB.Text = "IsOptional";
            OptionalChB.UseVisualStyleBackColor = false;
            // 
            // DefValLB
            // 
            DefValLB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DefValLB.AutoSize = true;
            DefValLB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DefValLB.ForeColor = Color.Peru;
            DefValLB.Location = new Point(1118, 657);
            DefValLB.Margin = new Padding(4, 0, 4, 0);
            DefValLB.Name = "DefValLB";
            DefValLB.Size = new Size(190, 30);
            DefValLB.TabIndex = 282;
            DefValLB.Text = "Default Value:";
            // 
            // DefaultValueTB
            // 
            DefaultValueTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DefaultValueTB.ContextMenuStrip = ContextMenuStrip1;
            DefaultValueTB.Font = new Font("Century", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DefaultValueTB.Location = new Point(1312, 655);
            DefaultValueTB.Margin = new Padding(4, 5, 4, 5);
            DefaultValueTB.Name = "DefaultValueTB";
            DefaultValueTB.Size = new Size(293, 36);
            DefaultValueTB.TabIndex = 281;
            // 
            // ContextMenuStrip1
            // 
            ContextMenuStrip1.ImageScalingSize = new Size(24, 24);
            ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { NotNowToolStripMenuItem, UnKnownToolStripMenuItem, ClearToolStripMenuItem });
            ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip1.Size = new Size(161, 100);
            // 
            // NotNowToolStripMenuItem
            // 
            NotNowToolStripMenuItem.Name = "NotNowToolStripMenuItem";
            NotNowToolStripMenuItem.Size = new Size(160, 32);
            NotNowToolStripMenuItem.Text = "NotNow";
            // 
            // UnKnownToolStripMenuItem
            // 
            UnKnownToolStripMenuItem.Name = "UnKnownToolStripMenuItem";
            UnKnownToolStripMenuItem.Size = new Size(160, 32);
            UnKnownToolStripMenuItem.Text = "UnKnown";
            // 
            // ClearToolStripMenuItem
            // 
            ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            ClearToolStripMenuItem.Size = new Size(160, 32);
            ClearToolStripMenuItem.Text = "Clear";
            // 
            // AttrTypeCB
            // 
            AttrTypeCB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AttrTypeCB.DropDownHeight = 200;
            AttrTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            AttrTypeCB.FlatStyle = FlatStyle.Flat;
            AttrTypeCB.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttrTypeCB.FormattingEnabled = true;
            AttrTypeCB.IntegralHeight = false;
            AttrTypeCB.Location = new Point(732, 657);
            AttrTypeCB.Margin = new Padding(4, 5, 4, 5);
            AttrTypeCB.MaxDropDownItems = 20;
            AttrTypeCB.Name = "AttrTypeCB";
            AttrTypeCB.Size = new Size(293, 34);
            AttrTypeCB.TabIndex = 283;
            AttrTypeCB.Tag = "";
            // 
            // ConstantChB
            // 
            ConstantChB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ConstantChB.AutoSize = true;
            ConstantChB.BackColor = Color.Transparent;
            ConstantChB.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConstantChB.ForeColor = SystemColors.ActiveCaption;
            ConstantChB.Location = new Point(1490, 715);
            ConstantChB.Margin = new Padding(4, 5, 4, 5);
            ConstantChB.Name = "ConstantChB";
            ConstantChB.Size = new Size(163, 34);
            ConstantChB.TabIndex = 284;
            ConstantChB.TabStop = false;
            ConstantChB.Text = "IsConstant";
            ConstantChB.UseVisualStyleBackColor = false;
            // 
            // CurrencyChB
            // 
            CurrencyChB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CurrencyChB.AutoSize = true;
            CurrencyChB.BackColor = Color.Transparent;
            CurrencyChB.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CurrencyChB.ForeColor = SystemColors.ActiveCaption;
            CurrencyChB.Location = new Point(1123, 715);
            CurrencyChB.Margin = new Padding(4, 5, 4, 5);
            CurrencyChB.Name = "CurrencyChB";
            CurrencyChB.Size = new Size(164, 34);
            CurrencyChB.TabIndex = 285;
            CurrencyChB.TabStop = false;
            CurrencyChB.Text = "IsCurrency";
            CurrencyChB.UseVisualStyleBackColor = false;
            // 
            // TrueChB
            // 
            TrueChB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TrueChB.AutoSize = true;
            TrueChB.BackColor = Color.Transparent;
            TrueChB.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TrueChB.ForeColor = SystemColors.ActiveCaption;
            TrueChB.Location = new Point(1335, 655);
            TrueChB.Margin = new Padding(4, 5, 4, 5);
            TrueChB.Name = "TrueChB";
            TrueChB.Size = new Size(88, 34);
            TrueChB.TabIndex = 289;
            TrueChB.TabStop = false;
            TrueChB.Text = "True";
            TrueChB.UseVisualStyleBackColor = false;
            TrueChB.Visible = false;
            // 
            // FalseChB
            // 
            FalseChB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FalseChB.AutoSize = true;
            FalseChB.BackColor = Color.Transparent;
            FalseChB.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            FalseChB.ForeColor = SystemColors.ActiveCaption;
            FalseChB.Location = new Point(1431, 655);
            FalseChB.Margin = new Padding(4, 5, 4, 5);
            FalseChB.Name = "FalseChB";
            FalseChB.Size = new Size(99, 34);
            FalseChB.TabIndex = 288;
            FalseChB.TabStop = false;
            FalseChB.Text = "False";
            FalseChB.UseVisualStyleBackColor = false;
            FalseChB.Visible = false;
            // 
            // ListValuesCB
            // 
            ListValuesCB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ListValuesCB.DropDownHeight = 200;
            ListValuesCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ListValuesCB.FlatStyle = FlatStyle.Flat;
            ListValuesCB.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListValuesCB.FormattingEnabled = true;
            ListValuesCB.IntegralHeight = false;
            ListValuesCB.Location = new Point(1312, 657);
            ListValuesCB.Margin = new Padding(4, 5, 4, 5);
            ListValuesCB.MaxDropDownItems = 20;
            ListValuesCB.Name = "ListValuesCB";
            ListValuesCB.Size = new Size(293, 34);
            ListValuesCB.TabIndex = 290;
            ListValuesCB.Tag = "";
            ListValuesCB.Visible = false;
            // 
            // AddAttributeButton
            // 
            AddAttributeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddAttributeButton.AutoSize = true;
            AddAttributeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddAttributeButton.BackColor = Color.FromArgb(25, 25, 70);
            AddAttributeButton.FlatAppearance.BorderSize = 0;
            AddAttributeButton.FlatStyle = FlatStyle.Flat;
            AddAttributeButton.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddAttributeButton.ForeColor = Color.MediumPurple;
            AddAttributeButton.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            AddAttributeButton.IconColor = Color.White;
            AddAttributeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddAttributeButton.IconSize = 45;
            AddAttributeButton.Location = new Point(1384, 809);
            AddAttributeButton.Margin = new Padding(4, 5, 4, 5);
            AddAttributeButton.Name = "AddAttributeButton";
            AddAttributeButton.Size = new Size(221, 51);
            AddAttributeButton.TabIndex = 277;
            AddAttributeButton.Text = "Add Attribute";
            AddAttributeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddAttributeButton.UseVisualStyleBackColor = false;
            // 
            // EditListBT
            // 
            EditListBT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditListBT.AutoSize = true;
            EditListBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditListBT.BackColor = Color.Transparent;
            EditListBT.FlatAppearance.BorderSize = 0;
            EditListBT.FlatAppearance.MouseDownBackColor = Color.Transparent;
            EditListBT.FlatAppearance.MouseOverBackColor = Color.Transparent;
            EditListBT.FlatStyle = FlatStyle.Flat;
            EditListBT.Font = new Font("Century Gothic", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditListBT.ForeColor = Color.Transparent;
            EditListBT.IconChar = FontAwesome.Sharp.IconChar.List;
            EditListBT.IconColor = Color.Goldenrod;
            EditListBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditListBT.IconSize = 35;
            EditListBT.Location = new Point(1613, 655);
            EditListBT.Margin = new Padding(4, 5, 4, 5);
            EditListBT.Name = "EditListBT";
            EditListBT.Size = new Size(41, 41);
            EditListBT.TabIndex = 286;
            EditListBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            EditListBT.UseVisualStyleBackColor = false;
            EditListBT.Visible = false;
            // 
            // AttrCategoryCB
            // 
            AttrCategoryCB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AttrCategoryCB.DropDownHeight = 200;
            AttrCategoryCB.DropDownStyle = ComboBoxStyle.DropDownList;
            AttrCategoryCB.FlatStyle = FlatStyle.Flat;
            AttrCategoryCB.Font = new Font("Microsoft Sans Serif", 11.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttrCategoryCB.FormattingEnabled = true;
            AttrCategoryCB.IntegralHeight = false;
            AttrCategoryCB.Items.AddRange(new object[] { "Purchase Attr.", "Product Attr.", "Sale Attribute" });
            AttrCategoryCB.Location = new Point(732, 594);
            AttrCategoryCB.Margin = new Padding(4, 5, 4, 5);
            AttrCategoryCB.MaxDropDownItems = 20;
            AttrCategoryCB.Name = "AttrCategoryCB";
            AttrCategoryCB.Size = new Size(293, 34);
            AttrCategoryCB.TabIndex = 315;
            AttrCategoryCB.Tag = "";
            // 
            // CtgLB
            // 
            CtgLB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CtgLB.AutoSize = true;
            CtgLB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            CtgLB.ForeColor = Color.Peru;
            CtgLB.Location = new Point(569, 594);
            CtgLB.Margin = new Padding(4, 0, 4, 0);
            CtgLB.Name = "CtgLB";
            CtgLB.Size = new Size(136, 30);
            CtgLB.TabIndex = 314;
            CtgLB.Text = "Attr.-Ctg.:";
            // 
            // SaveBT
            // 
            SaveBT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveBT.AutoSize = true;
            SaveBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveBT.BackColor = Color.FromArgb(25, 25, 70);
            SaveBT.FlatAppearance.BorderSize = 0;
            SaveBT.FlatStyle = FlatStyle.Flat;
            SaveBT.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBT.ForeColor = Color.MediumPurple;
            SaveBT.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            SaveBT.IconColor = Color.White;
            SaveBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SaveBT.IconSize = 45;
            SaveBT.Location = new Point(293, 661);
            SaveBT.Margin = new Padding(4, 5, 4, 5);
            SaveBT.Name = "SaveBT";
            SaveBT.Size = new Size(124, 51);
            SaveBT.TabIndex = 316;
            SaveBT.Text = "Save";
            SaveBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaveBT.UseVisualStyleBackColor = false;
            // 
            // FillDockPNL
            // 
            FillDockPNL.AutoScroll = true;
            FillDockPNL.Controls.Add(SaleFP);
            FillDockPNL.Controls.Add(ProductFP);
            FillDockPNL.Controls.Add(PurchaseFP);
            FillDockPNL.Dock = DockStyle.Fill;
            FillDockPNL.Location = new Point(0, 0);
            FillDockPNL.Name = "FillDockPNL";
            FillDockPNL.Size = new Size(1688, 572);
            FillDockPNL.TabIndex = 317;
            // 
            // SaleFP
            // 
            SaleFP.AllowDrop = true;
            SaleFP.BackColor = Color.FromArgb(36, 30, 60);
            SaleFP.BorderStyle = BorderStyle.Fixed3D;
            SaleFP.Dock = DockStyle.Left;
            SaleFP.Location = new Point(1122, 0);
            SaleFP.Name = "SaleFP";
            SaleFP.Size = new Size(561, 572);
            SaleFP.TabIndex = 306;
            SaleFP.Title = "Sale Attr.";
            // 
            // ProductFP
            // 
            ProductFP.AllowDrop = true;
            ProductFP.BackColor = Color.FromArgb(36, 30, 60);
            ProductFP.BorderStyle = BorderStyle.Fixed3D;
            ProductFP.Dock = DockStyle.Left;
            ProductFP.Location = new Point(561, 0);
            ProductFP.Name = "ProductFP";
            ProductFP.Size = new Size(561, 572);
            ProductFP.TabIndex = 305;
            ProductFP.Title = "Product Attr.";
            // 
            // PurchaseFP
            // 
            PurchaseFP.AllowDrop = true;
            PurchaseFP.BackColor = Color.FromArgb(36, 30, 60);
            PurchaseFP.BorderStyle = BorderStyle.Fixed3D;
            PurchaseFP.Dock = DockStyle.Left;
            PurchaseFP.Location = new Point(0, 0);
            PurchaseFP.Name = "PurchaseFP";
            PurchaseFP.Size = new Size(561, 572);
            PurchaseFP.TabIndex = 304;
            PurchaseFP.Title = "Puchase Attr.";
            // 
            // TopDockPNL
            // 
            TopDockPNL.BorderStyle = BorderStyle.FixedSingle;
            TopDockPNL.Controls.Add(FillDockPNL);
            TopDockPNL.Dock = DockStyle.Top;
            TopDockPNL.Location = new Point(0, 0);
            TopDockPNL.Name = "TopDockPNL";
            TopDockPNL.Size = new Size(1690, 574);
            TopDockPNL.TabIndex = 318;
            // 
            // AbrvLB
            // 
            AbrvLB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AbrvLB.AutoSize = true;
            AbrvLB.Font = new Font("Century Schoolbook", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AbrvLB.ForeColor = Color.Peru;
            AbrvLB.Location = new Point(569, 721);
            AbrvLB.Margin = new Padding(4, 0, 4, 0);
            AbrvLB.Name = "AbrvLB";
            AbrvLB.Size = new Size(153, 30);
            AbrvLB.TabIndex = 322;
            AbrvLB.Text = "Attr.-Abrv.:";
            AbrvLB.Visible = false;
            // 
            // AbbreviationTB
            // 
            AbbreviationTB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AbbreviationTB.Font = new Font("Century", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AbbreviationTB.Location = new Point(732, 715);
            AbbreviationTB.Margin = new Padding(4, 5, 4, 5);
            AbbreviationTB.Name = "AbbreviationTB";
            AbbreviationTB.Size = new Size(293, 36);
            AbbreviationTB.TabIndex = 321;
            AbbreviationTB.Visible = false;
            // 
            // FormulaBT
            // 
            FormulaBT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FormulaBT.AutoSize = true;
            FormulaBT.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormulaBT.BackColor = Color.Transparent;
            FormulaBT.FlatAppearance.BorderSize = 0;
            FormulaBT.FlatAppearance.MouseDownBackColor = Color.Transparent;
            FormulaBT.FlatAppearance.MouseOverBackColor = Color.Transparent;
            FormulaBT.FlatStyle = FlatStyle.Flat;
            FormulaBT.Font = new Font("Century Gothic", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormulaBT.ForeColor = Color.Transparent;
            FormulaBT.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            FormulaBT.IconColor = Color.Goldenrod;
            FormulaBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            FormulaBT.IconSize = 35;
            FormulaBT.Location = new Point(1613, 655);
            FormulaBT.Margin = new Padding(4, 5, 4, 5);
            FormulaBT.Name = "FormulaBT";
            FormulaBT.Size = new Size(41, 41);
            FormulaBT.TabIndex = 323;
            FormulaBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            FormulaBT.UseVisualStyleBackColor = false;
            FormulaBT.Visible = false;
            // 
            // DeleteBT
            // 
            DeleteBT.BackColor = Color.Maroon;
            DeleteBT.FlatAppearance.BorderSize = 0;
            DeleteBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            DeleteBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            DeleteBT.FlatStyle = FlatStyle.Flat;
            DeleteBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBT.ForeColor = Color.Linen;
            DeleteBT.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            DeleteBT.IconColor = Color.White;
            DeleteBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeleteBT.IconSize = 36;
            DeleteBT.Location = new Point(1335, 811);
            DeleteBT.Margin = new Padding(4, 5, 4, 5);
            DeleteBT.Name = "DeleteBT";
            DeleteBT.Size = new Size(45, 44);
            DeleteBT.TabIndex = 10039;
            DeleteBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteBT.UseVisualStyleBackColor = false;
            DeleteBT.Visible = false;
            // 
            // ClearBT
            // 
            ClearBT.BackColor = Color.Transparent;
            ClearBT.FlatAppearance.BorderSize = 0;
            ClearBT.FlatAppearance.MouseDownBackColor = Color.Lime;
            ClearBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 0);
            ClearBT.FlatStyle = FlatStyle.Flat;
            ClearBT.Font = new Font("Century Gothic", 14.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearBT.ForeColor = Color.Linen;
            ClearBT.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            ClearBT.IconColor = Color.White;
            ClearBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ClearBT.IconSize = 36;
            ClearBT.Location = new Point(1639, 580);
            ClearBT.Margin = new Padding(4, 5, 4, 5);
            ClearBT.Name = "ClearBT";
            ClearBT.Size = new Size(45, 44);
            ClearBT.TabIndex = 10040;
            ClearBT.TextImageRelation = TextImageRelation.ImageBeforeText;
            ClearBT.UseVisualStyleBackColor = false;
            // 
            // AddItemPage
            // 
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(1690, 896);
            Controls.Add(ClearBT);
            Controls.Add(DeleteBT);
            Controls.Add(AbrvLB);
            Controls.Add(AbbreviationTB);
            Controls.Add(TopDockPNL);
            Controls.Add(SaveBT);
            Controls.Add(AttrCategoryCB);
            Controls.Add(CtgLB);
            Controls.Add(DefaultValueTB);
            Controls.Add(TrueChB);
            Controls.Add(FalseChB);
            Controls.Add(CurrencyChB);
            Controls.Add(ConstantChB);
            Controls.Add(AttrTypeCB);
            Controls.Add(DefValLB);
            Controls.Add(OptionalChB);
            Controls.Add(AddAttributeButton);
            Controls.Add(TypeLB);
            Controls.Add(NameLB);
            Controls.Add(AttrNameTB);
            Controls.Add(ItemNameLB);
            Controls.Add(ItemNameTB);
            Controls.Add(ListValuesCB);
            Controls.Add(EditListBT);
            Controls.Add(FormulaBT);
            DoubleBuffered = true;
            Name = "AddItemPage";
            ContextMenuStrip1.ResumeLayout(false);
            FillDockPNL.ResumeLayout(false);
            TopDockPNL.ResumeLayout(false);
            Load += new EventHandler(AddItemPage_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label ItemNameLB;
        internal TextBox ItemNameTB;
        internal Label NameLB;
        internal TextBox AttrNameTB;
        internal Label TypeLB;
        internal FontAwesome.Sharp.IconButton AddAttributeButton;
        internal CheckBox OptionalChB;
        internal Label DefValLB;
        internal TextBox DefaultValueTB;
        internal ComboBox AttrTypeCB;
        internal CheckBox ConstantChB;
        internal FontAwesome.Sharp.IconButton EditListBT;
        internal CheckBox CurrencyChB;
        internal CheckBox TrueChB;
        internal CheckBox FalseChB;
        internal ComboBox ListValuesCB;
        internal UserControl1 PurchaseFP;
        internal UserControl1 ProductFP;
        internal UserControl1 SaleFP;
        internal ComboBox AttrCategoryCB;
        internal Label CtgLB;
        internal FontAwesome.Sharp.IconButton SaveBT;
        internal Panel FillDockPNL;
        internal Panel TopDockPNL;
        internal Label AbrvLB;
        internal TextBox AbbreviationTB;
        internal FontAwesome.Sharp.IconButton FormulaBT;
        internal ContextMenuStrip ContextMenuStrip1;
        internal ToolStripMenuItem NotNowToolStripMenuItem;
        internal ToolStripMenuItem UnKnownToolStripMenuItem;
        internal ToolStripMenuItem ClearToolStripMenuItem;
        internal FontAwesome.Sharp.IconButton DeleteBT;
        internal FontAwesome.Sharp.IconButton ClearBT;
    }
}