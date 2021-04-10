using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Web.Script.Serialization;

namespace todo_list
{
    public partial class SignIn : Form
    {
         string userID = "";
         string serverEndPoin = "";
        public SignIn()
        {
            InitializeComponent();
        }
        public SignIn(string sv, string id)
        {
            userID = id;
            serverEndPoin = sv;
            InitializeComponent();

        }
        private async void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                var httpClient = new HttpClient();

                string url = serverEndPoin + "/users/login";
                string email = txt_email.Text;
                string password = txt_pass.Text;
                // Khởi tạo http client
                var httpRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(url)
                };
                // Tạo StringContent
                string jsoncontent = "{\"email\": \"" + email + "\", \"password\": \"" + password + "\"}";
                var httpContent = new StringContent(jsoncontent, Encoding.UTF8, "application/json");
                httpRequestMessage.Content = httpContent;
                // call api
                var response = await httpClient.SendAsync(httpRequestMessage);
                var responseContent = await response.Content.ReadAsStringAsync();
                var status = response.StatusCode;

                // Chuyển sang object 
                JavaScriptSerializer j = new JavaScriptSerializer();
                var obj = j.Deserialize<dynamic>(responseContent);


                switch (status)
                {
                    case System.Net.HttpStatusCode.OK:
                        userID = obj["data"]["id"];
                        TaskList frm = new TaskList(serverEndPoin, userID);
                        frm.Show();
                        this.Hide();
                        break;
                    case System.Net.HttpStatusCode.Unauthorized:
                        break;
                    case System.Net.HttpStatusCode.Forbidden:
                        break;
                    case System.Net.HttpStatusCode.BadRequest:
                        string Res = "";
                        if (obj["reasons"] != null)
                        {
                            foreach (var item in obj["reasons"])
                            {
                                Res = Res + "\n" + item["path"] + " : " + item["message"];
                            }
                        }
                        MessageBox.Show(obj["message"] + "\n" + Res);
                        break;
                    case System.Net.HttpStatusCode.RequestTimeout:
                        MessageBox.Show("RequestTimeout");
                        break;
                    case System.Net.HttpStatusCode.InternalServerError:
                        MessageBox.Show("InternalServerError");
                        break;
                    default:
                        MessageBox.Show(obj["message"]);
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
