using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FirstApp
{

    public class Customer
    {

        public Customer(int CustID)
        {
            CustomerID = CustID;
        }

        public override bool Equals(object obj)
        {
            if (obj is null || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                return Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(((Customer)obj).CustomerID, CustomerID, false));
            }
        }

        public object CustomerID { get; private set; } = -1;

        #region Shared Functions
        internal static int[] SearchByKittyNo(string KittyNo, int MaxLimit = -1)
        {
            var SearchResult = new List<int>();

            if (MaxLimit != -1)
            {
                OleDbDataReader dr_count = (OleDbDataReader)ProjectModule.DataReader("Select Count(*) From Kitty_Data Where KittyNo Like '%" + KittyNo + "%'");
                while (dr_count.Read())
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(Conversion.Int(dr_count[0]), MaxLimit, false)))
                        return null;
                }
                dr_count.Close();
            }

            OleDbDataReader dr_search = (OleDbDataReader)ProjectModule.DataReader("Select KittyUID From Kitty_Data Where KittyNo Like'%" + KittyNo + "%'");
            while (dr_search.Read())
                SearchResult.Add(Conversions.ToInteger(Conversion.Int(dr_search["KittyUID"])));
            dr_search.Close();

            return SearchResult.ToArray();

        }

        internal static int[] SearchByPhNo(string PhNo)
        {

            var SearchResult = new List<int>();

            OleDbDataReader dr_search = (OleDbDataReader)ProjectModule.DataReader("Select SrNo From Coustmers_Data Where PhNo Like '%" + PhNo + "%'");
            while (dr_search.Read())
                SearchResult.Add(Conversions.ToInteger(Conversion.Int(dr_search["SrNo"])));
            dr_search.Close();

            return SearchResult.ToArray();

        }

        internal static int[] SearchByName(string Name)
        {

            var SearchResult = new List<int>();

            if (Name.Split(' ').Count() > 1)
            {

                OleDbDataReader dr = (OleDbDataReader)ProjectModule.DataReader("Select SrNo From Coustmers_Data Where (CName Like '%" + Name.Split(' ')[0] + "%') AND (CsName Like '%" + Name.Split(' ')[1] + "%')");
                while (dr.Read())
                    SearchResult.Add(Conversions.ToInteger(Conversion.Int(dr["SrNo"])));
                dr.Close();
            }

            else
            {

                OleDbDataReader dr = (OleDbDataReader)ProjectModule.DataReader("Select SrNo From Coustmers_Data Where CName Like '%" + Name + "%'");
                while (dr.Read())
                    SearchResult.Add(Conversions.ToInteger(Conversion.Int(dr["SrNo"])));
                dr.Close();

                dr = (OleDbDataReader)ProjectModule.DataReader("Select SrNo From Coustmers_Data Where CsName Like '%" + Name + "%'");
                while (dr.Read())
                    SearchResult.Add(Conversions.ToInteger(Conversion.Int(dr["SrNo"])));
                dr.Close();

            }

            return SearchResult.ToArray();

        }

        internal static List<Task<KittyModeControl>> ListOF_KittyModeControl(int[] IDs, int MaxLimit = -1, bool isKittyID = false)
        {
            if (IDs is null || IDs.Count() == 0)
                return null;
            if (MaxLimit != -1 && IDs.Count() > MaxLimit)
                return null;

            var T_List = new List<Task<KittyModeControl>>();
            var KittyIds = new List<Kitty>();

            if (isKittyID)
            {
                foreach (int Id in IDs)
                    KittyIds.Add(new Kitty(Id, true, true));
            }
            else
            {
                foreach (int Id in IDs)
                {
                    var i = new Customer(Id);
                    KittyIds.AddRange(i.OwnedKitties(true, true));
                }
            }

            foreach (Kitty _kitty in KittyIds)
            {
                T_List.Add(Task.Run(() =>
                    {
                        var CoustmerPanel = new KittyModeControl();
                        CoustmerPanel.CoustName = _kitty.Owner.FullName();
                        CoustmerPanel.PhNo = _kitty.Owner.PhNo(",");
                        CoustmerPanel.SetImage = "";
                        if (_kitty.Status() != "Partial")
                        {
                            CoustmerPanel.Status = _kitty.Status();
                        }
                        else
                        {
                            CoustmerPanel.InstalmentsPending = _kitty.GetInstalmentsPending();
                            CoustmerPanel.InstalmentsLeft = _kitty.GetInstalments_LeftForMaturity();
                        }
                        CoustmerPanel.KittyType = _kitty.KittyType.ToString();
                        try
                        {
                            CoustmerPanel.KittyNo = _kitty.KittyNo.ToString();
                        }
                        catch (Exception ex)
                        {
                            CoustmerPanel.KittyType = "";
                        }
                        CoustmerPanel.CoustID = Conversions.ToString(_kitty.Owner.CustomerID);
                        CoustmerPanel.KittyID = _kitty.KittyUID.ToString();
                        return CoustmerPanel;
                    }));
            }

            return T_List;

        }

        internal static List<Task<ActiveKittyControl>> ListOF_ActiveKittyControl(int[] IDs, int MaxLimit = -1)
        {
            if (IDs is null)
                return null;
            if (MaxLimit != -1 && IDs.Count() > MaxLimit)
                return null;

            var T_List = new List<Task<ActiveKittyControl>>();

            foreach (int Id in IDs)
            {
                var _customer = new Customer(Id);
                T_List.Add(Task.Run(() =>
                    {
                        var CoustmerPanel = new ActiveKittyControl();
                        CoustmerPanel.CoustName = _customer.FullName();
                        CoustmerPanel.PhNo = _customer.PhNo(",");
                        CoustmerPanel.SetImage = "";
                        CoustmerPanel.CoustID = Conversions.ToString(_customer.CustomerID);
                        CoustmerPanel.ActiveKitty = _customer.OwnedKitties().Count.ToString();
                        return CoustmerPanel;
                    }));
            }

            return T_List;

        }

        #endregion

        public List<Kitty> OwnedKitties(bool initialise = false, bool completely = false)
        {
            var Result = new List<Kitty>();
            try
            {
                OleDbDataReader dr_KittyUID = (OleDbDataReader)ProjectModule.DataReader($"Select KittyUID From Kitty_Data Where CoustID={CustomerID} ORDER BY KittyUID ASC");
                while (dr_KittyUID.Read())
                    Result.Add(new Kitty(Conversions.ToInteger(dr_KittyUID["KittyUID"]), initialise, completely));
                dr_KittyUID.Close();
                return Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Customer/OwnedCustomer()]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void DeleteCustomer()
        {
            try
            {
                if (MessageBox.Show("Are You Sure That You Permanently Want To Delete This Customet?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                try
                {
                    ProjectModule.SqlCommand($"DELETE FROM Coustmers_Data WHERE SrNo={CustomerID}");
                }
                catch
                {
                }
                try
                {
                    ProjectModule.SqlCommand($"DELETE FROM Kitty_Data WHERE CoustID={CustomerID}");
                }
                catch
                {
                }
            }
            // Try : SqlCommand($"DELETE FROM Udhari_Data WHERE CoustID={CustomerID}") : Catch : End Try
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Customer/DeleteCustomer]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Customer Name
        public string FirstName()
        {
            try
            {
                OleDbDataReader dr_firstName = (OleDbDataReader)ProjectModule.DataReader(Conversions.ToString(Operators.ConcatenateObject("Select CName From Coustmers_Data Where SrNo=", CustomerID)));
                string temp_name = "";
                while (dr_firstName.Read())
                {
                    try
                    {
                        temp_name = Conversions.ToString(dr_firstName["CName"]);
                    }
                    catch (Exception ex)
                    {
                    }
                }
                dr_firstName.Close();
                try
                {
                    temp_name = temp_name.Replace(ProjectModule.apostropheReplacer, "'");
                    return temp_name.Trim();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Customer/FirstName]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string UpdatedFirstName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                value = value.Replace("'", ProjectModule.apostropheReplacer);
                ProjectModule.SqlCommand(Conversions.ToString(Operators.ConcatenateObject("UPDATE Coustmers_Data set CName='" + value.Trim() + "' Where SrNo=", CustomerID)));
            }
        }

        public string LastName()
        {
            try
            {
                OleDbDataReader dr_sirName = (OleDbDataReader)ProjectModule.DataReader(Conversions.ToString(Operators.ConcatenateObject("Select CsName From Coustmers_Data Where SrNo=", CustomerID)));
                string temp_name = "";
                while (dr_sirName.Read())
                {
                    try
                    {
                        temp_name = Conversions.ToString(dr_sirName["CsName"]);
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
                dr_sirName.Close();
                try
                {
                    temp_name = temp_name.Replace(ProjectModule.apostropheReplacer, "'");
                    return temp_name.Trim();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Customer/LastName]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string UpdatedLastName
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.Replace("'", ProjectModule.apostropheReplacer);
                }
                ProjectModule.SqlCommand(Conversions.ToString(Operators.ConcatenateObject("UPDATE Coustmers_Data set CsName='" + value.Trim() + "' Where SrNo=", CustomerID)));
            }
        }

        public string FullName(string seprator = " ")
        {
            try
            {
                if (LastName().Length > 0)
                {
                    return FirstName() + seprator + LastName();
                }
                else
                {
                    return FirstName();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Customer/FullName]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion

        #region CustomerPhoneNo
        public string UpdatedPhNo
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                ProjectModule.SqlCommand(Conversions.ToString(Operators.ConcatenateObject("UPDATE Coustmers_Data set PhNo='" + value + "' Where SrNo=", CustomerID)));
            }
        }

        public string PhNo(string seperator)
        {
            try
            {
                return string.Join(seperator, GetPhNo());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Customer/GetPhNo]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<string> GetPhNo()
        {
            try
            {
                OleDbDataReader dr_phno = (OleDbDataReader)ProjectModule.DataReader(Conversions.ToString(Operators.ConcatenateObject("Select PhNo From Coustmers_Data Where SrNo=", CustomerID)));
                var temp_phno = new List<string>();
                while (dr_phno.Read())
                {
                    try
                    {
                        foreach (var no in dr_phno["PhNo"].ToString().Split(','))
                            temp_phno.Add(no.Replace(" ", ""));
                    }
                    catch (Exception ex)
                    {
                        temp_phno = null;
                    }
                }
                dr_phno.Close();
                return temp_phno;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Customer/GetPhNo]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static List<int> SharedPhNo(string[] _phnos)
        {

            var _sharedMembers = new List<int>();

            foreach (var _no in _phnos)
            {
                if (string.IsNullOrEmpty(_no) | string.IsNullOrWhiteSpace(_no))
                    continue;
                foreach (int _NewcustomerID in SearchByPhNo(_no.Trim()))
                    _sharedMembers.Add(_NewcustomerID);
            }

            return _sharedMembers.Distinct().ToList();
        }
        #endregion

        #region CustomerProfession
        public string Profession()
        {
            try
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(CustomerID, -1, false)))
                    return null;
                OleDbDataReader dr_profession = (OleDbDataReader)ProjectModule.DataReader(Conversions.ToString(Operators.ConcatenateObject("Select Prof From Coustmers_Data Where SrNo=", CustomerID)));
                string temp_profession = null;
                while (dr_profession.Read())
                {
                    try
                    {
                        temp_profession = Conversions.ToString(dr_profession["Prof"]);
                    }
                    catch (Exception ex)
                    {
                    }
                }
                dr_profession.Close();
                try
                {
                    return temp_profession.Replace(ProjectModule.apostropheReplacer, "'");
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Customer/Profession()]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string UpdatedProfession
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                value = value.Replace("'", ProjectModule.apostropheReplacer);
                ProjectModule.SqlCommand(Conversions.ToString(Operators.ConcatenateObject("UPDATE Coustmers_Data set Prof='" + value + "' Where SrNo=", CustomerID)));
            }
        }

        internal static List<string> ListOfProfessions()
        {
            var temp_list = new List<string>();
            try
            {
                OleDbDataReader dr_profession = (OleDbDataReader)ProjectModule.DataReader("select Profession from CBox_Data Where (NOT (Profession = ''))");
                while (dr_profession.Read())
                    temp_list.Add(Conversions.ToString(dr_profession["Profession"]));
                dr_profession.Close();
            }
            catch (Exception ex)
            {
            }
            return temp_list;
        }

        #endregion

        #region CustomerRegion
        public string Region()
        {
            try
            {
                OleDbDataReader dr_region = (OleDbDataReader)ProjectModule.DataReader(Conversions.ToString(Operators.ConcatenateObject("Select Region From Coustmers_Data Where SrNo=", CustomerID)));
                string temp_region = null;
                while (dr_region.Read())
                {
                    try
                    {
                        temp_region = Conversions.ToString(dr_region["Region"]);
                    }
                    catch (Exception ex)
                    {
                    }
                }
                dr_region.Close();
                try
                {
                    return temp_region.Replace(ProjectModule.apostropheReplacer, "'");
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Customer/Region]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string UpdatedRegion
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                value = value.Replace("'", ProjectModule.apostropheReplacer);
                ProjectModule.SqlCommand(Conversions.ToString(Operators.ConcatenateObject("UPDATE Coustmers_Data set Region='" + value + "' Where SrNo=", CustomerID)));
            }
        }

        internal static List<string> ListOfRegions()
        {
            var temp_list = new List<string>();
            try
            {
                OleDbDataReader dr_region = (OleDbDataReader)ProjectModule.DataReader("select Region from CBox_Data Where (NOT (Region = ''))");
                while (dr_region.Read())
                    temp_list.Add(Conversions.ToString(dr_region["Region"]));
                dr_region.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Customer/Region]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return temp_list;
        }
        #endregion

        #region CustomerAddress
        public string Address()
        {
            try
            {
                OleDbDataReader dr_address = (OleDbDataReader)ProjectModule.DataReader(Conversions.ToString(Operators.ConcatenateObject("Select Address From Coustmers_Data Where SrNo=", CustomerID)));
                string temp_address = null;
                while (dr_address.Read())
                {
                    try
                    {
                        temp_address = Conversions.ToString(dr_address["Address"]);
                    }
                    catch (Exception ex)
                    {
                    }
                }
                dr_address.Close();
                try
                {
                    return temp_address.Replace(ProjectModule.apostropheReplacer, "'");
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Customer/Address]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string UpdatedAddress
        {
            set
            {
                value = value.Replace("'", ProjectModule.apostropheReplacer);
                ProjectModule.SqlCommand(Conversions.ToString(Operators.ConcatenateObject("UPDATE Coustmers_Data set Address='" + value + "' Where SrNo=", CustomerID)));
            }
        }
        #endregion

        #region CustomerDescription
        public string Description()
        {
            try
            {
                OleDbDataReader dr_description = (OleDbDataReader)ProjectModule.DataReader(Conversions.ToString(Operators.ConcatenateObject("Select dscrp From Coustmers_Data Where SrNo=", CustomerID)));
                string temp_description = null;
                while (dr_description.Read())
                {
                    try
                    {
                        temp_description = Conversions.ToString(dr_description["dscrp"]);
                    }
                    catch (Exception ex)
                    {
                    }
                }
                dr_description.Close();
                try
                {
                    return temp_description.Replace(ProjectModule.apostropheReplacer, "'");
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Customer/Description]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string UpdatedDescription
        {
            set
            {
                value = value.Replace("'", ProjectModule.apostropheReplacer);
                ProjectModule.SqlCommand(Conversions.ToString(Operators.ConcatenateObject("UPDATE Coustmers_Data set dscrp='" + value + "' Where SrNo=", CustomerID)));
            }
        }
        #endregion

        #region Married
        public bool IsMarried()
        {
            try
            {
                OleDbDataReader dr_isMarried = (OleDbDataReader)ProjectModule.DataReader(Conversions.ToString(Operators.ConcatenateObject("Select Mry From Coustmers_Data Where SrNo=", CustomerID)));
                bool temp_result = false;
                while (dr_isMarried.Read())
                {
                    try
                    {
                        temp_result = Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dr_isMarried["Mry"], "True", false) ?? temp_result == true);
                    }
                    catch (Exception ex)
                    {
                    }
                }
                dr_isMarried.Close();
                return temp_result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Customer/IsMarried]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
        }

        public string UpdatedMarriedStatus
        {
            set
            {
                ProjectModule.SqlCommand(Conversions.ToString(Operators.ConcatenateObject("UPDATE Coustmers_Data set Mry='" + value + "' Where SrNo=", CustomerID)));
            }
        }
        #endregion

        #region Gender
        public string Gender()
        {
            try
            {
                OleDbDataReader dr_gender = (OleDbDataReader)ProjectModule.DataReader(Conversions.ToString(Operators.ConcatenateObject("Select Gender From Coustmers_Data Where SrNo=", CustomerID)));
                string temp_gender = "";
                while (dr_gender.Read())
                {
                    try
                    {
                        temp_gender = Conversions.ToString(dr_gender["Gender"]);
                    }
                    catch (Exception ex)
                    {
                    }
                }
                dr_gender.Close();
                return temp_gender;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Customer/Gender()]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string UpdatedGender
        {
            set
            {
                ProjectModule.SqlCommand(Conversions.ToString(Operators.ConcatenateObject("UPDATE Coustmers_Data set Gender='" + value + "' Where SrNo=", CustomerID)));
            }
        }
        #endregion

        #region Adhaar Number
        public string AdhaarNumber()
        {
            try
            {
                OleDbDataReader dr_adhaar = (OleDbDataReader)ProjectModule.DataReader(Conversions.ToString(Operators.ConcatenateObject("Select Adhaar From Coustmers_Data Where SrNo=", CustomerID)));
                string temp_adhaar = "";
                while (dr_adhaar.Read())
                {
                    try
                    {
                        temp_adhaar = Conversions.ToString(dr_adhaar["Adhaar"]);
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
                dr_adhaar.Close();
                return temp_adhaar.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error [Customer/AdhaarNumber]: {ex.Message}", "Error In Customer Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string UpdatedAdhaarNumber
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.Replace("'", ProjectModule.apostropheReplacer);
                }
                ProjectModule.SqlCommand(Conversions.ToString(Operators.ConcatenateObject("UPDATE Coustmers_Data set Adhaar='" + value.Trim() + "' Where SrNo=", CustomerID)));
            }
        }

        #endregion

    }

    public class Utility
    {
        public static void LoadComboBoxData(ComboBox cBox, IEnumerable List)
        {
            try
            {
                cBox.Items.Clear();
                foreach (var item in List)
                    cBox.Items.Add(item);
                cBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Class: [Utility/Error]: {ex.Message}", "Error In Utility Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int MonthDifference(DateTime first, DateTime second)
        {
            long x = DateAndTime.DateDiff(DateInterval.Day, second.Date, first.Date);
            return (int)Math.Round(x / 31d);
            return Math.Abs(first.Month - second.Month + 12 * (first.Year - second.Year));
        }

    }
}