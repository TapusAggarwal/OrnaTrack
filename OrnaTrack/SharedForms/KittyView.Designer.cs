using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FirstApp
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class KittyView : Form
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            var DataGridViewCellStyle13 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            var DataGridViewCellStyle14 = new DataGridViewCellStyle();
            var DataGridViewCellStyle23 = new DataGridViewCellStyle();
            var DataGridViewCellStyle24 = new DataGridViewCellStyle();
            var DataGridViewCellStyle25 = new DataGridViewCellStyle();
            var DataGridViewCellStyle15 = new DataGridViewCellStyle();
            var DataGridViewCellStyle16 = new DataGridViewCellStyle();
            var DataGridViewCellStyle17 = new DataGridViewCellStyle();
            var DataGridViewCellStyle18 = new DataGridViewCellStyle();
            var DataGridViewCellStyle19 = new DataGridViewCellStyle();
            var DataGridViewCellStyle20 = new DataGridViewCellStyle();
            var DataGridViewCellStyle21 = new DataGridViewCellStyle();
            var DataGridViewCellStyle22 = new DataGridViewCellStyle();
            DgvMain = new DataGridView();
            DgvMain.CellClick += new DataGridViewCellEventHandler(Dgv_CellClick);
            Column10 = new DataGridViewCheckBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewButtonColumn();
            Entry = new DataGridViewButtonColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Label3 = new Label();
            MessageCheckBox = new CheckBox();
            MessageCheckBox.CheckedChanged += new EventHandler(MarriedCheckBox_CheckedChanged);
            DgvMessage = new DataGridView();
            DgvMessage.CellClick += new DataGridViewCellEventHandler(DgvMessage_CellClick);
            DataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            DataGridViewButtonColumn1 = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            SendMessageButton = new FontAwesome.Sharp.IconButton();
            SendMessageButton.Click += new EventHandler(SendMessageButton_Click);
            SharingPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)DgvMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvMessage).BeginInit();
            SharingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DgvMain
            // 
            DgvMain.AllowUserToAddRows = false;
            DgvMain.AllowUserToDeleteRows = false;
            DgvMain.AllowUserToResizeColumns = false;
            DgvMain.AllowUserToResizeRows = false;
            DgvMain.BackgroundColor = Color.FromArgb(36, 30, 60);
            DgvMain.BorderStyle = BorderStyle.None;
            DgvMain.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(36, 35, 80);
            DataGridViewCellStyle1.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            DataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            DgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMain.Columns.AddRange(new DataGridViewColumn[] { Column10, Column1, Column9, Column5, Column2, Column6, Column4, Status, Column7, Entry, Column8 });
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle11.BackColor = SystemColors.Window;
            DataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle11.ForeColor = SystemColors.ActiveCaptionText;
            DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            DgvMain.DefaultCellStyle = DataGridViewCellStyle11;
            DgvMain.EditMode = DataGridViewEditMode.EditProgrammatically;
            DgvMain.GridColor = Color.FromArgb(36, 35, 80);
            DgvMain.Location = new Point(9, 40);
            DgvMain.Margin = new Padding(4, 5, 4, 5);
            DgvMain.MultiSelect = false;
            DgvMain.Name = "DgvMain";
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle12.BackColor = Color.FromArgb(36, 35, 80);
            DataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle12.ForeColor = Color.White;
            DataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(36, 35, 80);
            DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            DgvMain.RowHeadersDefaultCellStyle = DataGridViewCellStyle12;
            DgvMain.RowHeadersVisible = false;
            DgvMain.RowHeadersWidth = 62;
            DataGridViewCellStyle13.BackColor = Color.FromArgb(32, 32, 32);
            DataGridViewCellStyle13.ForeColor = Color.White;
            DataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(32, 32, 32);
            DataGridViewCellStyle13.SelectionForeColor = Color.White;
            DgvMain.RowsDefaultCellStyle = DataGridViewCellStyle13;
            DgvMain.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DgvMain.Size = new Size(1317, 238);
            DgvMain.TabIndex = 1;
            // 
            // Column10
            // 
            Column10.Frozen = true;
            Column10.HeaderText = "";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Resizable = DataGridViewTriState.False;
            Column10.Width = 27;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewCellStyle2.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.NullValue = null;
            DataGridViewCellStyle2.SelectionBackColor = Color.White;
            DataGridViewCellStyle2.SelectionForeColor = Color.Black;
            Column1.DefaultCellStyle = DataGridViewCellStyle2;
            Column1.Frozen = true;
            Column1.HeaderText = "";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 40;
            // 
            // Column9
            // 
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle3.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Column9.DefaultCellStyle = DataGridViewCellStyle3;
            Column9.Frozen = true;
            Column9.HeaderText = "KittyNo";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column9.Width = 91;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle4.BackColor = Color.White;
            DataGridViewCellStyle4.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Column5.DefaultCellStyle = DataGridViewCellStyle4;
            Column5.Frozen = true;
            Column5.HeaderText = "KittyType";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 113;
            // 
            // Column2
            // 
            DataGridViewCellStyle5.Font = new Font("Century Schoolbook", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle5.Format = "d";
            DataGridViewCellStyle5.NullValue = null;
            DataGridViewCellStyle5.SelectionBackColor = Color.White;
            DataGridViewCellStyle5.SelectionForeColor = Color.Black;
            Column2.DefaultCellStyle = DataGridViewCellStyle5;
            Column2.Frozen = true;
            Column2.HeaderText = "Pending Instalments";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 244;
            // 
            // Column6
            // 
            DataGridViewCellStyle6.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle6.ForeColor = Color.Red;
            Column6.DefaultCellStyle = DataGridViewCellStyle6;
            Column6.Frozen = true;
            Column6.HeaderText = "Given Amt";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 146;
            // 
            // Column4
            // 
            DataGridViewCellStyle7.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle7.NullValue = null;
            Column4.DefaultCellStyle = DataGridViewCellStyle7;
            Column4.Frozen = true;
            Column4.HeaderText = "Total Amt+Intrst";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 226;
            // 
            // Status
            // 
            DataGridViewCellStyle8.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Status.DefaultCellStyle = DataGridViewCellStyle8;
            Status.Frozen = true;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 135;
            // 
            // Column7
            // 
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle9.BackColor = Color.FromArgb(36, 35, 80);
            DataGridViewCellStyle9.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle9.ForeColor = Color.White;
            DataGridViewCellStyle9.SelectionBackColor = Color.ForestGreen;
            Column7.DefaultCellStyle = DataGridViewCellStyle9;
            Column7.Frozen = true;
            Column7.HeaderText = "Show Details";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Text = "Show Details";
            Column7.UseColumnTextForButtonValue = true;
            Column7.Width = 145;
            // 
            // Entry
            // 
            DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle10.Font = new Font("Century Schoolbook", 10.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Entry.DefaultCellStyle = DataGridViewCellStyle10;
            Entry.Frozen = true;
            Entry.HeaderText = "Entry";
            Entry.MinimumWidth = 8;
            Entry.Name = "Entry";
            Entry.Resizable = DataGridViewTriState.True;
            Entry.SortMode = DataGridViewColumnSortMode.Automatic;
            Entry.Text = "MakeEntry";
            Entry.UseColumnTextForButtonValue = true;
            Entry.Width = 125;
            // 
            // Column8
            // 
            Column8.Frozen = true;
            Column8.HeaderText = "KittyID";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Visible = false;
            Column8.Width = 119;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Century Gothic", 26.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.ForeColor = SystemColors.ActiveCaption;
            Label3.Location = new Point(8, 39);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(136, 63);
            Label3.TabIndex = 227;
            Label3.Text = "Kitty";
            // 
            // MessageCheckBox
            // 
            MessageCheckBox.BackColor = Color.Transparent;
            MessageCheckBox.Font = new Font("Century Gothic", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MessageCheckBox.ForeColor = SystemColors.ActiveCaption;
            MessageCheckBox.Location = new Point(1071, 0);
            MessageCheckBox.Margin = new Padding(4, 5, 4, 5);
            MessageCheckBox.Name = "MessageCheckBox";
            MessageCheckBox.Size = new Size(230, 40);
            MessageCheckBox.TabIndex = 228;
            MessageCheckBox.Text = "Message Mode";
            MessageCheckBox.UseVisualStyleBackColor = false;
            // 
            // DgvMessage
            // 
            DgvMessage.AllowUserToAddRows = false;
            DgvMessage.AllowUserToDeleteRows = false;
            DgvMessage.AllowUserToResizeColumns = false;
            DgvMessage.AllowUserToResizeRows = false;
            DgvMessage.BackgroundColor = Color.FromArgb(36, 30, 60);
            DgvMessage.BorderStyle = BorderStyle.None;
            DgvMessage.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle14.BackColor = Color.FromArgb(36, 35, 80);
            DataGridViewCellStyle14.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle14.ForeColor = Color.Gainsboro;
            DataGridViewCellStyle14.SelectionBackColor = Color.Transparent;
            DataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            DgvMessage.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14;
            DgvMessage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMessage.Columns.AddRange(new DataGridViewColumn[] { DataGridViewCheckBoxColumn1, DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7, DataGridViewButtonColumn1, DataGridViewTextBoxColumn8 });
            DataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle23.BackColor = SystemColors.Window;
            DataGridViewCellStyle23.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle23.ForeColor = SystemColors.ActiveCaptionText;
            DataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            DgvMessage.DefaultCellStyle = DataGridViewCellStyle23;
            DgvMessage.EditMode = DataGridViewEditMode.EditProgrammatically;
            DgvMessage.GridColor = Color.FromArgb(36, 35, 80);
            DgvMessage.Location = new Point(9, 40);
            DgvMessage.Margin = new Padding(4, 5, 4, 5);
            DgvMessage.MultiSelect = false;
            DgvMessage.Name = "DgvMessage";
            DataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle24.BackColor = Color.FromArgb(36, 35, 80);
            DataGridViewCellStyle24.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle24.ForeColor = Color.White;
            DataGridViewCellStyle24.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle24.SelectionForeColor = Color.FromArgb(36, 35, 80);
            DataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            DgvMessage.RowHeadersDefaultCellStyle = DataGridViewCellStyle24;
            DgvMessage.RowHeadersVisible = false;
            DgvMessage.RowHeadersWidth = 62;
            DataGridViewCellStyle25.BackColor = Color.FromArgb(32, 32, 32);
            DataGridViewCellStyle25.ForeColor = Color.White;
            DataGridViewCellStyle25.SelectionBackColor = Color.FromArgb(32, 32, 32);
            DataGridViewCellStyle25.SelectionForeColor = Color.White;
            DgvMessage.RowsDefaultCellStyle = DataGridViewCellStyle25;
            DgvMessage.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DgvMessage.Size = new Size(1084, 238);
            DgvMessage.TabIndex = 229;
            DgvMessage.Visible = false;
            // 
            // DataGridViewCheckBoxColumn1
            // 
            DataGridViewCheckBoxColumn1.Frozen = true;
            DataGridViewCheckBoxColumn1.HeaderText = "";
            DataGridViewCheckBoxColumn1.MinimumWidth = 8;
            DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
            DataGridViewCheckBoxColumn1.ReadOnly = true;
            DataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.False;
            DataGridViewCheckBoxColumn1.Width = 27;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewCellStyle15.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle15.NullValue = null;
            DataGridViewCellStyle15.SelectionBackColor = Color.White;
            DataGridViewCellStyle15.SelectionForeColor = Color.Black;
            DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle15;
            DataGridViewTextBoxColumn1.HeaderText = "";
            DataGridViewTextBoxColumn1.MinimumWidth = 8;
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            DataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            DataGridViewTextBoxColumn1.Width = 40;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle16.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle16;
            DataGridViewTextBoxColumn2.HeaderText = "KittyNo";
            DataGridViewTextBoxColumn2.MinimumWidth = 8;
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewTextBoxColumn2.Width = 91;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataGridViewCellStyle17.BackColor = Color.White;
            DataGridViewCellStyle17.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle17;
            DataGridViewTextBoxColumn3.HeaderText = "KittyType";
            DataGridViewTextBoxColumn3.MinimumWidth = 8;
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            DataGridViewTextBoxColumn3.Width = 113;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewCellStyle18.Font = new Font("Century Schoolbook", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle18.Format = "d";
            DataGridViewCellStyle18.NullValue = null;
            DataGridViewCellStyle18.SelectionBackColor = Color.White;
            DataGridViewCellStyle18.SelectionForeColor = Color.Black;
            DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle18;
            DataGridViewTextBoxColumn4.HeaderText = "Pending Inst.";
            DataGridViewTextBoxColumn4.MinimumWidth = 8;
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            DataGridViewTextBoxColumn4.ReadOnly = true;
            DataGridViewTextBoxColumn4.Width = 254;
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewCellStyle19.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle19.ForeColor = Color.Red;
            DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle19;
            DataGridViewTextBoxColumn5.HeaderText = "Given Amt";
            DataGridViewTextBoxColumn5.MinimumWidth = 8;
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            DataGridViewTextBoxColumn5.ReadOnly = true;
            DataGridViewTextBoxColumn5.Width = 146;
            // 
            // DataGridViewTextBoxColumn6
            // 
            DataGridViewCellStyle20.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle20.NullValue = null;
            DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle20;
            DataGridViewTextBoxColumn6.HeaderText = "Total Amt+Intrst";
            DataGridViewTextBoxColumn6.MinimumWidth = 8;
            DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            DataGridViewTextBoxColumn6.ReadOnly = true;
            DataGridViewTextBoxColumn6.Width = 216;
            // 
            // DataGridViewTextBoxColumn7
            // 
            DataGridViewCellStyle21.Font = new Font("Century Schoolbook", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle21;
            DataGridViewTextBoxColumn7.HeaderText = "Status";
            DataGridViewTextBoxColumn7.MinimumWidth = 8;
            DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            DataGridViewTextBoxColumn7.ReadOnly = true;
            DataGridViewTextBoxColumn7.Width = 135;
            // 
            // DataGridViewButtonColumn1
            // 
            DataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle22.BackColor = Color.FromArgb(36, 35, 80);
            DataGridViewCellStyle22.Font = new Font("Century Schoolbook", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridViewCellStyle22.ForeColor = Color.White;
            DataGridViewCellStyle22.NullValue = false;
            DataGridViewCellStyle22.SelectionBackColor = Color.ForestGreen;
            DataGridViewButtonColumn1.DefaultCellStyle = DataGridViewCellStyle22;
            DataGridViewButtonColumn1.HeaderText = "";
            DataGridViewButtonColumn1.MinimumWidth = 8;
            DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1";
            DataGridViewButtonColumn1.Resizable = DataGridViewTriState.True;
            DataGridViewButtonColumn1.Width = 27;
            // 
            // DataGridViewTextBoxColumn8
            // 
            DataGridViewTextBoxColumn8.HeaderText = "KittyID";
            DataGridViewTextBoxColumn8.MinimumWidth = 8;
            DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            DataGridViewTextBoxColumn8.ReadOnly = true;
            DataGridViewTextBoxColumn8.Visible = false;
            DataGridViewTextBoxColumn8.Width = 119;
            // 
            // SendMessageButton
            // 
            SendMessageButton.BackColor = Color.FromArgb(25, 25, 70);
            SendMessageButton.Enabled = false;
            SendMessageButton.FlatAppearance.BorderSize = 0;
            SendMessageButton.FlatStyle = FlatStyle.Flat;
            SendMessageButton.Font = new Font("Century Gothic", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            SendMessageButton.ForeColor = Color.DimGray;
            SendMessageButton.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            SendMessageButton.IconColor = Color.Black;
            SendMessageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SendMessageButton.IconSize = 40;
            SendMessageButton.Location = new Point(961, 288);
            SendMessageButton.Margin = new Padding(4, 5, 4, 5);
            SendMessageButton.Name = "SendMessageButton";
            SendMessageButton.Size = new Size(340, 70);
            SendMessageButton.TabIndex = 230;
            SendMessageButton.Text = "Send Message";
            SendMessageButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            SendMessageButton.UseVisualStyleBackColor = false;
            // 
            // SharingPanel
            // 
            SharingPanel.BackColor = Color.FromArgb(36, 30, 60);
            SharingPanel.Controls.Add(SendMessageButton);
            SharingPanel.Controls.Add(MessageCheckBox);
            SharingPanel.Controls.Add(DgvMain);
            SharingPanel.Controls.Add(DgvMessage);
            SharingPanel.Location = new Point(137, 2);
            SharingPanel.Name = "SharingPanel";
            SharingPanel.Size = new Size(1338, 367);
            SharingPanel.TabIndex = 231;
            // 
            // KittyView
            // 
            AccessibleRole = AccessibleRole.Dialog;
            AutoScaleDimensions = new SizeF(9.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(36, 30, 60);
            ClientSize = new Size(1476, 371);
            Controls.Add(Label3);
            Controls.Add(SharingPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "KittyView";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)DgvMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvMessage).EndInit();
            SharingPanel.ResumeLayout(false);
            Load += new EventHandler(KittyView_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label Label3;
        internal CheckBox MessageCheckBox;
        internal FontAwesome.Sharp.IconButton SendMessageButton;
        internal Panel SharingPanel;
        internal DataGridView DgvMain;
        internal DataGridView DgvMessage;
        internal DataGridViewCheckBoxColumn Column10;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column9;
        internal DataGridViewTextBoxColumn Column5;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column6;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Status;
        internal DataGridViewButtonColumn Column7;
        internal DataGridViewButtonColumn Entry;
        internal DataGridViewTextBoxColumn Column8;
        internal DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        internal DataGridViewCheckBoxColumn DataGridViewButtonColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
    }
}