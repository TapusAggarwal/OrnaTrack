using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public class Kitty
    {

        #region Properties
        public int KittyUID { get; private set; } = -1;

        public int KittyNo { get; set; } = -1;

        public int KittyType { get; set; } = -1;

        public int KittyInterest { get; set; } = -1;

        public int Duration { get; set; } = -1;

        public int CustomerID { get; set; } = -1;

        public string Notes { get; set; } = "";

        public bool IsAvailed { get; set; } = false;

        public bool IsInactive { get; set; } = false;

        public Dictionary<DateTime, int> Record { get; set; } = new Dictionary<DateTime, int>();
        public Dictionary<DateTime, List<Transaction>> Transactions { get; set; } = new Dictionary<DateTime, List<Transaction>>();

        private bool Initialized { get; set; } = false;

        public Customer Owner
        {
            get
            {
                try
                {
                    return new Customer(CustomerID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error [Kitty]/Owner This Kitty DoesNot Have A Associated Customer With It.", "Wrong Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        #endregion

        public Kitty(int UID = -1, bool InitializeKitty = false, bool completely = false)
        {
            if (UID == -1)
                return;
            KittyUID = UID;
            if (InitializeKitty)
                Initialize(completely);
        }

        public void Initialize(bool InitializeCompletely = true)
        {
            if (KittyUID == -1)
                return;
            if (Initialized)
                return;
            OleDbDataReader dr = (OleDbDataReader)ProjectModule.DataReader("Select * From Kitty_Data Where KittyUID=" + KittyUID);
            while (dr.Read())
            {
                KittyNo = Conversions.ToInteger(dr["KittyNo"]);
                CustomerID = Conversions.ToInteger(dr["CoustID"]);
                KittyType = Conversions.ToInteger(dr["KittyType"]);
                KittyInterest = Conversions.ToInteger(dr["Interest"]);
                Duration = Conversions.ToInteger(dr["Duration"]);
                IsAvailed = Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dr["Availed"], "False", false)) ? false : true;
                IsInactive = Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dr["InActive"], "False", false)) ? false : true;
                try
                {
                    Notes = dr["Notes"].ToString().Replace(ProjectModule.apostropheReplacer, "'");
                }
                catch
                {
                }
                if (InitializeCompletely)
                {
                    AddRecord(Conversions.ToString(dr["Dates"]));
                    Initialized = true;
                }
            }
            dr.Close();

        }

        public void Save()
        {
            if (KittyUID == -1)
            {
                if (CustomerID == -1)
                {
                    MessageBox.Show("[Kitty] Attempt To Save A Kitty Without A Customer To Own It. Can't Proceed Further Without A CustomerId.", "Illegal Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("[Kitty] Do You Want To Add New Kitty ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                ProjectModule.SqlCommand("INSERT INTO Kitty_Data (CoustID,KittyNo,KittyType,Dates,Interest,Duration,Availed,InActive,Notes)" + $"VALUES({CustomerID},{KittyNo},{KittyType},'{RecordString()}',{KittyInterest},{Duration},'{IsAvailed}','{IsInactive}','{Notes.Replace("'", ProjectModule.apostropheReplacer)}')");
            }
            else
            {
                if (CustomerID == -1)
                    return;
                if (MessageBox.Show("[Kitty] Do You Want To Update This Kitty ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                ProjectModule.SqlCommand($"UPDATE Kitty_Data set CoustID={CustomerID},KittyNo={KittyNo},KittyType={KittyType},Dates='{RecordString()}',Interest={KittyInterest},Duration={Duration}" + $",Availed ='{IsAvailed}',InActive='{IsInactive}',Notes='{Notes.Replace("'", ProjectModule.apostropheReplacer)}' WHERE KittyUID={KittyUID}");
            }
        }

        public void Dissolve()
        {
            try
            {
                if (MessageBox.Show("Are You Sure That You Want To Dissolve This Kitty ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                ProjectModule.SqlCommand($"DELETE FROM Kitty_Data WHERE KittyUID={KittyUID}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Kitty]/Dissolve: {ex.Message}");
            }
        }

        public void InitializeTransactions()
        {
            Transactions.Clear();
            OleDbDataReader dr = (OleDbDataReader)ProjectModule.DataReader($"Select TrnsID From Transaction_Data Where KittyIds LIKE '%,{KittyUID},%'");
            while (dr.Read())
            {
                var _trns = new Transaction(Conversions.ToInteger(dr[0]));
                if (!Transactions.ContainsKey(_trns.TrnsDate))
                {
                    Transactions.Add(_trns.TrnsDate, new List<Transaction>(new[] { _trns }));
                }
                else
                {
                    Transactions[_trns.TrnsDate].Add(_trns);
                }
            }
            dr.Close();
        }

        public bool AddRecord(string _entry)
        {
            try
            {
                if (string.IsNullOrEmpty(_entry))
                    return false;
                foreach (string i in _entry.Split(','))
                {
                    string _entryDate = i.Substring(0, 10).Trim();
                    int _entryAmount = Conversions.ToInteger(i.Substring(10));
                    if (Record.ContainsKey(Conversions.ToDate(_entryDate)))
                    {
                        if (Record[Conversions.ToDate(_entryDate)] + _entryAmount < KittyType)
                        {
                            Record.Remove(Conversions.ToDate(_entryDate));
                        }
                        else
                        {
                            Record[Conversions.ToDate(_entryDate)] += _entryAmount;
                        }
                    }
                    else if (_entryAmount >= KittyType)
                        Record.Add(Conversions.ToDate(_entryDate), _entryAmount);
                }

                var sorted = from pair in Record
                             orderby pair.Key
                             select pair;

                Record = sorted.ToDictionary(k => k.Key, v => v.Value);

                foreach (var i in Transactions.Where(f => !Record.ContainsKey(f.Key)))
                {

                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Add Entry To Record [Kitty]: " + ex.Message);
                return false;
            }
        }

        public string RecordString(string Seperator = ",")
        {
            if (Record is null)
                return null;
            return string.Join(Seperator, Record.Select(f => $"{f.Key.ToShortDateString()}{f.Value}").ToArray());
        }

        public int TotalAmount()
        {
            return KittyType * Duration;
        }

        public int GivenAmount()
        {
            return Record.Values.Sum();
        }

        public int GetInstalmentsCompleted()
        {
            return (int)Math.Round(Conversion.Int(GivenAmount() / (double)KittyType));
        }

        public int GetInstalmentsPending()  // Instalments Pending Till Date
        {
            if (Record.Count == 0)
                return default;
            var FirstDate = Record.First().Key;

            var ExpectedDate = FirstDate;
            int ExpectedInstalments = 0;

            while (ExpectedDate < DateTime.Today)  // Adding One To Get Instalments Expected Until Today (It Will Add One Extra Month At Last)
            {
                ExpectedDate = ExpectedDate.AddMonths(1);
                ExpectedInstalments += 1;
            }

            ExpectedInstalments -= 1; // Subtracting One To Get Instalments Expected Until Today

            ExpectedInstalments -= GetInstalmentsCompleted() - 1; // Subtracting Instalments Given And One More Instalment That Is The First Instalment

            if (ExpectedInstalments > GetInstalments_LeftForMaturity()) // If Instalments Due Past The Date Of Maturity
            {
                ExpectedInstalments = GetInstalments_LeftForMaturity();
            }

            if (GetInstalments_LeftForMaturity() == 0)
                return -1; // If Matured -> Return -1

            if (ExpectedInstalments < 0) // If SomeBody Paid More Than Necessary
            {
                return 0;
            }
            else
            {
                return ExpectedInstalments;
            }
        }

        public int GetInstalments_LeftForMaturity() // Instalments Pending For Maturity
        {
            return Conversion.Int(Duration - GetInstalmentsCompleted());
        }

        public bool IsActive()
        {
            Initialize(true);
            return !(IsMatured() | IsAvailed | IsInactive);
        }

        public bool IsMatured()
        {
            if (GivenAmount() >= KittyType * Duration)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
    /// <code>Status =: Availed, Cracked, InActive, Matured, Partial</code>
    /// </summary>
    /// <returns>Status Of The Given Kitty</returns>
        public string Status()
        {
            if (IsAvailed)
            {
                if (IsMatured())
                {
                    return "Availed";
                }
                else
                {
                    return "Cracked";
                }
            }
            else if (IsInactive)
            {
                return "InActive";
            }
            else if (IsMatured())
            {
                return "Matured";
            }
            else
            {
                return "Partial";
            }
        }

        #region Public Shared Function
        internal static List<int> GetListOfKittyTypes()
        {
            var temp_list = new List<int>();
            try
            {
                OleDbDataReader dr_kittyType = (OleDbDataReader)ProjectModule.DataReader("Select KittyType from CBox_Data Where (NOT (KittyType = ''))");
                while (dr_kittyType.Read())
                    temp_list.Add(Conversions.ToInteger(dr_kittyType["KittyType"]));
                dr_kittyType.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Get List Of KittyTypes [Kitty]: " + ex.Message);
            }
            return temp_list;
        }

        internal static List<int> GetListOfKittyIntrests()
        {
            var temp_list = new List<int>();
            try
            {
                OleDbDataReader dr_kittyInterest = (OleDbDataReader)ProjectModule.DataReader("Select KittyIntrest from CBox_Data Where (NOT (KittyIntrest = ''))");
                while (dr_kittyInterest.Read())
                    temp_list.Add(Conversions.ToInteger(dr_kittyInterest["KittyIntrest"]));
                dr_kittyInterest.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Get List Of KittyInterests [Kitty]: " + ex.Message);
            }
            return temp_list;
        }

        internal static List<string> GetListOfPaymentModes()
        {
            var temp_list = new List<string>();
            try
            {
                OleDbDataReader dr_Modes = (OleDbDataReader)ProjectModule.DataReader("Select PaymentModes from CBox_Data Where (NOT (PaymentModes = ''))");
                while (dr_Modes.Read())
                    temp_list.Add(Conversions.ToString(dr_Modes["PaymentModes"]));
                dr_Modes.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Get List Of PaymentModes [Kitty]: " + ex.Message);
            }
            return temp_list;
        }

        internal static List<string> GetListOfAccounts()
        {
            var temp_list = new List<string>();
            try
            {
                OleDbDataReader dr_Accounts = (OleDbDataReader)ProjectModule.DataReader("Select Accounts from CBox_Data Where (NOT (Accounts = ''))");
                while (dr_Accounts.Read())
                    temp_list.Add(Conversions.ToString(dr_Accounts["Accounts"]));
                dr_Accounts.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Get List Of Accounts [Kitty]: " + ex.Message);
            }
            return temp_list;
        }

        #endregion

    }

    public class Transaction : ICloneable
    {
        public int TrnsID { get; set; } = -1;
        public DateTime TrnsDate { get; set; }
        public string Mode { get; set; } = "";
        public string Account { get; set; }
        public int Amount { get; set; } = -1;
        public string RefNo { get; set; }
        public string Notes { get; set; }
        public Dictionary<int, int> KittyIds { get; set; } = new Dictionary<int, int>();
        public List<Kitty> InitialisedKitty
        {
            get
            {
                return (from i in KittyIds
                        select new Kitty(i.Key, true)).ToList();
            }
        }

        public Transaction(int _id)
        {
            if (_id == -1)
                return;
            OleDbDataReader dr = (OleDbDataReader)ProjectModule.DataReader($"Select * From Transaction_Data Where TrnsID={_id}");
            while (dr.Read())
            {
                TrnsDate = DateTime.Parse(Conversions.ToString(dr["TrnsDate"]));
                Mode = Conversions.ToString(dr["Mode"]);
                Account = Conversions.ToString(dr["Account"]);
                Amount = Conversions.ToInteger(dr["Amount"]);
                RefNo = Conversions.ToString(dr["RefNo"] is DBNull ? "" : dr["RefNo"]);

                if (!(dr["KittyIds"] is DBNull))
                {
                    foreach (var i in dr["KittyIds"].ToString().Split(','))
                    {
                        if (!(i.Length > 0))
                            continue;
                        KittyIds.Add(Conversions.ToInteger(Conversion.Int(i)), -1);
                    }
                    int _index = 0;
                    foreach (var i in dr["Structure"].ToString().Split(','))
                    {
                        if (!(i.Length > 0))
                            continue;
                        KittyIds[KittyIds.ElementAt(_index).Key] = Conversions.ToInteger(Conversion.Int(i));
                        _index += 1;
                    }
                }

                Notes = Conversions.ToString(dr["Notes"] is DBNull ? "" : dr["Notes"]);
            }
            dr.Close();
            TrnsID = _id;
        }

        public int Save()
        {
            if (TrnsID < 0)
            {
                bool res = ProjectModule.SqlCommand("Insert Into Transaction_Data (TrnsDate,Mode,Account,Amount,RefNo,KittyIds,Notes,Structure) " + $"Values ('{TrnsDate.ToShortDateString()}','{Mode}','{Account}','{Amount}','{RefNo}',',{string.Join(",", KittyIds.Keys)},','{Notes}','{string.Join(",", KittyIds.Values)}')");
                if (res)
                {
                    OleDbDataReader dr = (OleDbDataReader)ProjectModule.DataReader("Select Max(TrnsID) From Transaction_Data");
                    while (dr.Read())
                    {
                        if (!(dr[0] is DBNull))
                        {
                            TrnsID = Conversions.ToInteger(Conversion.Int(dr[0]));
                            return Conversions.ToInteger(Conversion.Int(dr[0]));
                        }
                    }
                }
            }
            else
            {
                ProjectModule.SqlCommand("Update Transaction_Data Set " + $"TrnsDate='{TrnsDate.ToShortDateString()}',Mode='{Mode}',Account='{Account}',Amount='{Amount}',RefNo='{RefNo}'" + $",KittyIds=',{string.Join(",", KittyIds.Keys)},',Notes='{Notes}',Structure='{string.Join(",", KittyIds.Values)}' Where TrnsID={TrnsID}");
            }
            return -1;
        }

        public void Delete(int _kittyID = -1)
        {
            if (_kittyID != -1)
            {
                if (KittyIds.Count > 1)
                {
                    KittyIds.Remove(_kittyID);
                }
            }
            ProjectModule.SqlCommand($"Delete From Transaction_Data Where TrnsID={TrnsID}");
        }

        public override int GetHashCode()
        {
            return (TrnsID, TrnsDate, Mode, Account, Amount, RefNo, KittyIds, Notes).GetHashCode();
        }

        public object Clone()
        {
            var x = MemberwiseClone();
            ((dynamic)x).KittyIds = KittyIds.ToDictionary(g => g.Key, g => g.Value);
            return x;
        }
    }
}