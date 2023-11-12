using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public partial class AddFormulaForm
    {

        public List<Item.Item_Attribute> Attributes { get; set; } = new List<Item.Item_Attribute>();
        public bool FormulaInUse
        {
            get
            {
                return UseBT.Text is not null && UseBT.Text == "Don't Use This Calculation";
            }
        }

        public AddFormulaForm()
        {
            InitializeComponent();
        }

        private void AddFormulaForm_Load(object sender, EventArgs e)
        {

            FlowLayoutPanel1.Controls.Clear();

            foreach (var i in Attributes)
            {
                var _cntrl = new AttributeControl() { CurrentAttribute = i };
                _cntrl.UsedButton.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
                _cntrl.UsedButton.IconColor = Color.ForestGreen;

                _cntrl.ButtonClick += () => FormulaTB.SelectedText = $"{{{i.Name}}}";

                FlowLayoutPanel1.Controls.Add(_cntrl);
            }

            FormulaTB.Select();
            FormulaTB_KeyDown(FormulaTB, EventArgs.Empty);
        }

        private void FormulaTB_KeyDown(object sender, EventArgs e)
        {
            int cursorIndex = FormulaTB.SelectionStart;
            string pattern = @"\{[^{}]*\}|\s+";
            var regex = new Regex(pattern);

            FormulaTB.Text = regex.Replace(FormulaTB.Text, (match) => { if (match.Value.StartsWith("{")) { return match.Value; } else { return string.Join("", match.Value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)); } });
            FormulaTB.SelectionStart = cursorIndex;

            HighlightWords();
            HighLightOperations();

        }

        private void FormulaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar == '\r' && Conversions.ToString(e.KeyChar) != "%" && Conversions.ToString(e.KeyChar) != "(" && Conversions.ToString(e.KeyChar) != ")" && Conversions.ToString(e.KeyChar) != "*" && Conversions.ToString(e.KeyChar) != "+" && Conversions.ToString(e.KeyChar) != "-" && Conversions.ToString(e.KeyChar) != "/")
            {

                e.Handled = true;
            }
        }

        private void HighLightOperations()
        {
            var wordRegex = new Regex(@"[%()*+\-/]");
            var matches = wordRegex.Matches(FormulaTB.Text);

            int cursorIndex = FormulaTB.SelectionStart;

            foreach (Match match in matches)
            {
                FormulaTB.SelectionStart = match.Index;
                FormulaTB.SelectionLength = match.Length;
                FormulaTB.SelectionColor = Color.Red;
            }

            FormulaTB.SelectionStart = cursorIndex;
            FormulaTB.SelectionLength = 0;
            FormulaTB.SelectionColor = Color.Black;
        }

        private void HighlightWords()
        {
            var wordRegex = new Regex(@"\{[^{}]+\}");
            var matches = wordRegex.Matches(FormulaTB.Text);

            int cursorIndex = FormulaTB.SelectionStart;

            FormulaTB.SelectionStart = 0;
            FormulaTB.SelectionLength = FormulaTB.TextLength;
            FormulaTB.SelectionColor = Color.Black;

            foreach (Match match in matches)
            {
                FormulaTB.SelectionStart = match.Index;
                FormulaTB.SelectionLength = match.Length;
                FormulaTB.SelectionColor = SystemColors.Highlight;
            }

            FormulaTB.SelectionStart = cursorIndex;
            FormulaTB.SelectionLength = 0;
            FormulaTB.SelectionColor = Color.Black;

            if (matches.Count > 0)
            {
                UseBT.Enabled = true;
            }
            else
            {
                UseBT.Enabled = false;
                if (FormulaInUse)
                    ToggleUseBT();
            }

        }

        private void MathOperations_Click(FontAwesome.Sharp.IconButton sender, EventArgs e)
        {
            string Operation = "";

            if (ReferenceEquals(sender, LeftBracketBT))
            {
                Operation = "(";
            }
            else if (ReferenceEquals(sender, RightBracketBT))
            {
                Operation = ")";
            }
            else if (ReferenceEquals(sender, DivideBT))
            {
                Operation = "/";
            }
            else if (ReferenceEquals(sender, MultiplyBT))
            {
                Operation = "*";
            }
            else if (ReferenceEquals(sender, PlusBT))
            {
                Operation = "+";
            }
            else if (ReferenceEquals(sender, MinusBT))
            {
                Operation = "-";
            }

            FormulaTB.SelectedText = Operation;
        }

        public List<Item.Item_Attribute> ValidateFormulaText()
        {
            string pattern = @"\{[^{}]+\}|[\d()+\-*\/%]";
            var regex = new Regex(pattern);

            if (!regex.IsMatch(FormulaTB.Text))
            {
                // Return an empty list if the text contains invalid characters
                return new List<Item.Item_Attribute>();
            }

            // Extract the attributes from the text
            var matches = regex.Matches(FormulaTB.Text);
            var attributes = new List<Item.Item_Attribute>();
            foreach (Match match in matches)
            {
                if (match.Value.StartsWith("{"))
                {
                    string _attr = match.Value.Substring(1, match.Value.Length - 2);
                    attributes.Add((Item.Item_Attribute)attributes.Where(f => (f.Name ?? "") == (_attr ?? "")));
                }
            }

            return attributes;
        }

        private void UseBT_Click(object sender, EventArgs e)
        {
            ToggleUseBT();
        }

        public event UseBT_ToggledEventHandler UseBT_Toggled;

        public delegate void UseBT_ToggledEventHandler();

        public void ToggleUseBT()
        {
            if (UseBT.Text == "Don't Use This Calculation")
            {
                UseBT.Text = "Use This Calculation";
                UseBT.BackColor = Color.ForestGreen;
                UseBT.Location = new Point(1017, UseBT.Location.Y);
            }
            else
            {
                UseBT.Text = "Don't Use This Calculation";
                UseBT.BackColor = Color.Maroon;
                UseBT.Location = new Point(952, UseBT.Location.Y);
            }
            UseBT_Toggled?.Invoke();
        }

    }
}