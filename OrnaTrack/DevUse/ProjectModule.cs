using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FirstApp.MessageAndImageSender;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;
using WebSocket4Net;

namespace FirstApp
{

    static class ProjectModule
    {
        public static OleDbConnection myconnection = new OleDbConnection();
        public static WebSocket WebSocket;
        public static string state = "";
        public static bool ImageFirst { get; set; } = true;
        public readonly static string apostropheReplacer = "{#}";


        public struct Variables
        {
            public static string ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={My.MySettingsProperty.Settings.Db_source}";
        }

        public static void InitaliseConnection()
        {
            try
            {
                myconnection.ConnectionString = Variables.ConnectionString;
            }
            catch
            {
            }
        }

        // FUNCTION:- SQL Command
        public static bool SqlCommand(string cmd, bool CloseConnection = false)
        {
            try
            {
                if (myconnection.State == ConnectionState.Closed)
                    myconnection.Open();
                var comnd = new OleDbCommand(cmd, myconnection);
                comnd.ExecuteNonQuery();
                comnd.Dispose();
                if (CloseConnection)
                    myconnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ProjectModule SQL Command Error:- " + ex.Message);
                return false;
            }
        }

        // FUNCTION:- Returns A DataReader Based On A Command Note:-(Need To Close dr And myconnection After Using.)
        public static object DataReader(string cmdi)
        {
            try
            {
                if (myconnection.State == ConnectionState.Closed)
                    myconnection.Open();
                var cmd = new OleDbCommand()
                {
                    CommandText = cmdi,
                    Connection = myconnection
                };
                var Data_Reader = cmd.ExecuteReader();
                return Data_Reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ProjectModule DataReader Error:- " + ex.Message);
                return null;
            }
        }

        // SUB:- Serialize A Dgv
        public static void SrNoUpdate(DataGridView Dgv, int SerialIndex = 1)
        {
            for (int i = 0, loopTo = Dgv.Rows.Count - 1; i <= loopTo; i++)
                Dgv.Rows[i].Cells[SerialIndex].Value = i + 1;
        }

        // Function: General Function That takes Dictionary Of Parameters As Input And Returns Server Response As String
        public static object ServerHttpRequest(Dictionary<string, string> requestPrams = null, MultipartFormDataContent request_headres = null, string _uri = null)
        {

            if (_uri is null)
                _uri = $"http://{My.MySettingsProperty.Settings.connection_url}";

            if (requestPrams is not null)
            {
                string url = $"{_uri}?";
                foreach (var comm in requestPrams)
                    url += $"{comm.Key}={comm.Value}&";
                _uri = url.Substring(0, url.Length - 1);
            }

            if (string.IsNullOrEmpty(_uri))
                return null;

            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromSeconds(5d);

            try
            {
                var response = client.PostAsync(new Uri(_uri), request_headres).Result;

                if (response.IsSuccessStatusCode)
                {
                    var resposeTask = response.Content.ReadAsStringAsync();
                    return resposeTask;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occurred: While Sending Request To Server: {ex.Message}.", "Exception Thrown", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public async static Task<JObject> UniversalWhatsappMessageBundle(string phno, List<string> msgList, List<string> imgList)
        {

            using (var client = new HttpClient())
            {
                var content = new MultipartFormDataContent() { { new StringContent("91" + phno.Trim()), "phno" } };

                if (imgList.Count == 0 & msgList.Count == 0)
                {
                    MessageBox.Show($"Neither Image Nor Message was provided to send to this number.", "Error", MessageBoxButtons.OK);
                    return null;
                }

                if (!ImageFirst & (msgList.Count > 0 && imgList.Count > 0))
                {
                    var _resp = await UniversalWhatsappMessageBundle(phno, msgList, new List<string>());
                    string status = "fail";
                    if (_resp is not null)
                        status = _resp.SelectToken("result").ToString();

                    if (status == "pass")
                    {
                        msgList.Clear();
                    }
                    else if (status == "fail")
                    {
                        var response = new JObject() { { "result", "fail" } };
                        return response;
                    }
                    else
                    {
                        return null;
                    }
                }

                foreach (var msg in msgList)
                    content.Add(new StringContent(msg), "msg");

                foreach (var imgPath in imgList)
                {
                    if (string.IsNullOrEmpty(imgPath.Trim()))
                        continue;
                    var imageContent = new ByteArrayContent(File.ReadAllBytes(imgPath));
                    imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
                    content.Add(imageContent, "image", Path.GetFileName(imgPath));
                }

                string responseString = null;

                try
                {
                    var response = await client.PostAsync($"http://{My.MySettingsProperty.Settings.connection_url}/upload", content);
                    responseString = response.Content.ReadAsStringAsync().Result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"The Client Made A Successful Request But The Server Failed To Respond. Exception Details: {ex.Message}", "Server Side Error", MessageBoxButtons.OK);
                }

                if (responseString is not null)
                {
                    return JObject.Parse(responseString);
                }
                else
                {
                    return null;
                }

            }

        }

        // Function ServerHttpRequest(command As Dictionary(Of String, String)) As String
        // Dim rawresponse As String = Nothing
        // Try
        // Dim url = $"http://{My.Settings.connection_url}?"
        // For Each comm In command
        // url += $"{comm.Key}={comm.Value}&"
        // Next
        // url = url.Substring(0, url.Length - 1)
        // If String.IsNullOrWhiteSpace(url) Then Return Nothing
        // Dim req As WebRequest = WebRequest.Create(url.Trim)
        // req.Method = "POST"
        // Dim response = DirectCast(req.GetResponse(), HttpWebResponse)
        // Dim reader = New StreamReader(response.GetResponseStream())
        // rawresponse = reader.ReadToEnd().ToString()
        // Catch ex As Exception
        // 'MessageBox.Show(String.Format("An error occurred:{0}{0}{1}",
        // '                                  vbCrLf, ex.Message),
        // '                    "Exception Thrown",
        // '                    MessageBoxButtons.OK,
        // '                    MessageBoxIcon.Warning)
        // End Try
        // Return rawresponse
        // End Function


        // Function: Check's If A Number Is Registered With Watsapp Returns true, false or Nothing In Case When Server Does Not Respond
        public async static Task<string> Isregistered(string PhNo)
        {
            var dict = new Dictionary<string, string>() { { "purpose", "is_registered" }, { "phno", "91" + PhNo } };
            try
            {
                // Dim ResponseString As String = Await 
                return Conversions.ToString(await ServerHttpRequest(dict));
            }
            catch (Exception ex)
            {
                return null;
                // MessageBox.Show(String.Format("An error occurred:{0}{0}{1}",
                // vbCrLf, ex.Message),
                // "Exception Thrown",
                // MessageBoxButtons.OK,
                // MessageBoxIcon.Warning)
            }
        }


        public static object Greet()
        {
            string hour = DateAndTime.TimeOfDay.ToString("hh");
            if (DateAndTime.TimeOfDay.ToString("tt") == "AM")
            {
                return "Good Morning";
            }
            else if (DateAndTime.TimeOfDay.ToString("tt") == "PM" & Conversions.ToDouble(hour) >= 5d & Conversions.ToDouble(hour) <= 11d)

            {
                return "Good Evening";
            }
            else
            {
                return "Good AfterNoon";
            }
        }

        public static string ReplaceTemplateWithDetails(Kitty _kitty, string _text)
        {
            _kitty.Initialize(true);
            _text = _text.Replace(Templates.Greeting, Conversions.ToString(Greet()));
            _text = _text.Replace(Templates.CoustName, _kitty.Owner.FullName());
            _text = _text.Replace(Templates.CoustPhNo, _kitty.Owner.PhNo(","));
            _text = _text.Replace(Templates.KittyType, _kitty.KittyType.ToCurrency(true));
            _text = _text.Replace(Templates.KittyNo, _kitty.KittyNo.ToString());
            _text = _text.Replace(Templates.InstalmentsCompleted, _kitty.GetInstalmentsCompleted().ToString());

            var FirstDate = _kitty.Record.First().Key;
            int InstComp = _kitty.GetInstalmentsCompleted();
            int InstPending = _kitty.GetInstalmentsPending();

            if (InstComp == 1)
            {
                _text = _text.Replace(Templates.PeriodIntalmentsCompleted, $"{FirstDate:MMM}({FirstDate:yyyy})");
            }
            else if (InstComp == 2)
            {
                _text = _text.Replace(Templates.PeriodIntalmentsCompleted, $"{FirstDate:MMM}({FirstDate:yyyy}),{FirstDate.AddMonths(1):MMM}({FirstDate.AddMonths(1):yyyy})");
            }
            else
            {
                _text = _text.Replace(Templates.PeriodIntalmentsCompleted, $"{FirstDate:MMM}({FirstDate:yyyy})-{FirstDate.AddMonths(InstComp - 1):MMM}({FirstDate.AddMonths(InstComp - 1):yyyy})");
            }

            _text = _text.Replace(Templates.GivenAmount, _kitty.GivenAmount().ToCurrency(true));
            _text = _text.Replace(Templates.InstalmentsPending, InstPending.ToString());

            if (InstPending == 1)
            {
                _text = _text.Replace(Templates.PeriodInstalmentsPending, $"{FirstDate.AddMonths(InstComp):MMM}({FirstDate.AddMonths(InstComp):yyyy})");
            }
            else if (InstPending == 2)
            {
                _text = _text.Replace(Templates.PeriodInstalmentsPending, $"{FirstDate.AddMonths(InstComp):MMM}({FirstDate.AddMonths(InstComp):yyyy}),{FirstDate.AddMonths(InstComp + 1):MMM}({FirstDate.AddMonths(InstComp + 1):yyyy})");
            }
            else
            {
                _text = _text.Replace(Templates.PeriodInstalmentsPending, $"{FirstDate.AddMonths(InstComp):MMM}({FirstDate.AddMonths(InstComp):yyyy})-{FirstDate.AddMonths(InstComp + InstPending - 1):MMM}({FirstDate.AddMonths(InstComp + InstPending - 1):yyyy})");
            }


            _text = _text.Replace(Templates.PendingAmount, Conversion.Int(InstPending * _kitty.KittyType).ToCurrency(true));

            return _text;
        }


        public static List<Kitty> OrderBasedOnStatus(this List<Kitty> _list)
        {

            var imMature = new List<Kitty>();
            var Matured = new List<Kitty>();
            var Availed = new List<Kitty>();
            var inActive = new List<Kitty>();

            // Adding Kitty To Respective Lists
            foreach (Kitty _kitty in _list)
            {
                _kitty.Initialize(true);
                if (_kitty.IsAvailed)
                {
                    Availed.Add(_kitty);
                }
                else if (_kitty.IsMatured())
                {
                    Matured.Add(_kitty);
                }
                else if (_kitty.IsInactive)
                {
                    inActive.Add(_kitty);
                }
                else
                {
                    imMature.Add(_kitty);
                }
            }

            _list.Clear();

            // Adding Kitty Back In Order
            _list.AddRange(imMature);
            _list.AddRange(Matured);
            _list.AddRange(Availed);
            _list.AddRange(inActive);

            return _list;
        }

        public static string PendingInstalmentsInWords(this Kitty _kitty, bool IncludeInstalmentWord = false)
        {
            int pendingInst = _kitty.GetInstalmentsPending();
            if (_kitty.Record.Count == -1)
            {
                return "No Entry Made";
            }
            if (pendingInst == 0)
            {
                if (IncludeInstalmentWord)
                {
                    return "No Instalment Pending";
                }
                return "None Pending";
            }
            else
            {
                if (IncludeInstalmentWord)
                {
                    if (pendingInst > 1)
                    {
                        return $"{pendingInst} Instalments Pending";
                    }
                    else
                    {
                        return $"{pendingInst} Instalment Pending";
                    }
                }
                return $"{pendingInst} Pending";
            }
        }

        public static string ToCurrency(this object _number, bool AddSpace = false)
        {
            string _numberCur = _number.ToString();
            if (string.IsNullOrEmpty(_numberCur))
            {
                return "";
            }
            _numberCur = _numberCur.Replace(" ", "");
            _numberCur = _numberCur.Replace("₹", "");
            if (AddSpace)
            {
                return string.Format("₹{0:C}", _numberCur);
            }
            else
            {
                return string.Format("₹ {0:C}", _numberCur);
            }
        }

        // <Extension()>
        // Public Function AddToList(Of TKey, TValue)(_dict As Dictionary(Of TKey, List(Of TValue)), _key As Object, _value As Object)
        // If _dict.ContainsKey(_key) Then
        // _dict.Item(_key).Add(_value)
        // Else

        // End If
        // End Function

    }
}