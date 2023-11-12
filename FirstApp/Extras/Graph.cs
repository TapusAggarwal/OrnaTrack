using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Graph
    {

        private Dictionary<int, int> payments2019 = new Dictionary<int, int>();
        private Dictionary<int, int> payments2020 = new Dictionary<int, int>();
        private Dictionary<int, int> payments2021 = new Dictionary<int, int>();
        private Dictionary<int, int> payments2022 = new Dictionary<int, int>();

        private Dictionary<string, int> paymentsCount = new Dictionary<string, int>();

        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {

            int given = 0;
            int interest = 0;
            int avail = 0;

            for (int i = 1; i <= 581; i++)
            {

                var _kitty = new Kitty(UID: i, InitializeKitty: true, completely: true);

                if (_kitty.Record.Count == 0)
                    continue;

                switch (_kitty.Record.First().Key.Year)
                {
                    case 2019:
                        {
                            if (payments2019.ContainsKey(_kitty.Record.First().Key.Month))
                            {
                                payments2019[_kitty.Record.First().Key.Month] += 1;
                            }
                            else
                            {
                                payments2019.Add(_kitty.Record.First().Key.Month, 1);
                            }

                            break;
                        }
                    case 2020:
                        {
                            if (payments2020.ContainsKey(_kitty.Record.First().Key.Month))
                            {
                                payments2020[_kitty.Record.First().Key.Month] += 1;
                            }
                            else
                            {
                                payments2020.Add(_kitty.Record.First().Key.Month, 1);
                            }

                            break;
                        }
                    case 2021:
                        {
                            if (payments2021.ContainsKey(_kitty.Record.First().Key.Month))
                            {
                                payments2021[_kitty.Record.First().Key.Month] += 1;
                            }
                            else
                            {
                                payments2021.Add(_kitty.Record.First().Key.Month, 1);
                            }

                            break;
                        }
                    case 2022:
                        {
                            if (payments2022.ContainsKey(_kitty.Record.First().Key.Month))
                            {
                                payments2022[_kitty.Record.First().Key.Month] += 1;
                            }
                            else
                            {
                                payments2022.Add(_kitty.Record.First().Key.Month, 1);
                            }

                            break;
                        }
                }

                given += _kitty.GivenAmount();
                interest += _kitty.KittyInterest;

                if (_kitty.IsAvailed)
                {
                    avail += _kitty.GivenAmount();
                }

            }

            var sorted2019 = from pair in payments2019
                             orderby pair.Key
                             select pair;

            foreach (var i in sorted2019)
            {
                var lbl = new Label();
                lbl.Text = $"{i.Key},2019-{i.Value}";
                lbl.AutoSize = true;
                FlowLayoutPanel2019.Controls.Add(lbl);
            }

            var sorted2020 = from pair in payments2020
                             orderby pair.Key
                             select pair;

            foreach (var i in sorted2020)
            {
                var lbl = new Label();
                lbl.Text = $"{i.Key},2020-{i.Value}";
                lbl.AutoSize = true;
                FlowLayoutPanel2020.Controls.Add(lbl);
            }

            var sorted2021 = from pair in payments2021
                             orderby pair.Key
                             select pair;

            foreach (var i in sorted2021)
            {
                var lbl = new Label();
                lbl.Text = $"{i.Key},2021-{i.Value}";
                lbl.AutoSize = true;
                FlowLayoutPanel2021.Controls.Add(lbl);
            }

            var sorted2022 = from pair in payments2022
                             orderby pair.Key
                             select pair;

            foreach (var i in sorted2022)
            {
                var lbl = new Label();
                lbl.Text = $"{i.Key},2022-{i.Value}";
                lbl.AutoSize = true;
                FlowLayoutPanel2022.Controls.Add(lbl);
            }


            Label1.Text = given.ToString();
            Label2.Text = interest.ToString();
            Label3.Text = avail.ToString();

        }

        private void TillDateAmount()
        {

            for (int i = 1; i <= 581; i++)
            {

                var _kitty = new Kitty(UID: i, InitializeKitty: true, completely: true);

                foreach (var pair in _kitty.Record)
                {

                    var _date = new Tuple<int, int>(pair.Key.Month, pair.Key.Year);
                    int _amount = pair.Value;

                    if (_date.Item2 == 2019)
                    {
                        if (payments2019.ContainsKey(_date.Item1))
                        {
                            payments2019[_date.Item1] += _amount;
                        }
                        else
                        {
                            payments2019.Add(_date.Item1, _amount);
                        }
                    }

                    if (_date.Item2 == 2020)
                    {
                        if (payments2020.ContainsKey(_date.Item1))
                        {
                            payments2020[_date.Item1] += _amount;
                        }
                        else
                        {
                            payments2020.Add(_date.Item1, _amount);
                        }
                    }

                    if (_date.Item2 == 2021)
                    {
                        if (payments2021.ContainsKey(_date.Item1))
                        {
                            payments2021[_date.Item1] += _amount;
                        }
                        else
                        {
                            payments2021.Add(_date.Item1, _amount);
                        }
                    }

                    if (_date.Item2 == 2022)
                    {
                        if (payments2022.ContainsKey(_date.Item1))
                        {
                            payments2022[_date.Item1] += _amount;
                        }
                        else
                        {
                            payments2022.Add(_date.Item1, _amount);
                        }
                    }

                }

            }

            var sorted2019 = from pair in payments2019
                             orderby pair.Key
                             select pair;

            foreach (var i in sorted2019)
            {
                var lbl = new Label();
                lbl.Text = $"{i.Key},2019-{i.Value}";
                lbl.AutoSize = true;
                FlowLayoutPanel2019.Controls.Add(lbl);
            }

            var sorted2020 = from pair in payments2020
                             orderby pair.Key
                             select pair;

            foreach (var i in sorted2020)
            {
                var lbl = new Label();
                lbl.Text = $"{i.Key},2020-{i.Value}";
                lbl.AutoSize = true;
                FlowLayoutPanel2020.Controls.Add(lbl);
            }

            var sorted2021 = from pair in payments2021
                             orderby pair.Key
                             select pair;

            foreach (var i in sorted2021)
            {
                var lbl = new Label();
                lbl.Text = $"{i.Key},2021-{i.Value}";
                lbl.AutoSize = true;
                FlowLayoutPanel2021.Controls.Add(lbl);
            }

            var sorted2022 = from pair in payments2022
                             orderby pair.Key
                             select pair;

            foreach (var i in sorted2022)
            {
                var lbl = new Label();
                lbl.Text = $"{i.Key},2022-{i.Value}";
                lbl.AutoSize = true;
                FlowLayoutPanel2022.Controls.Add(lbl);
            }

        }

    }
}