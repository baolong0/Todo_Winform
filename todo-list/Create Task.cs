using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace todo_list
{
    public partial class CreateTask : Form
    {
        private string userID = "";
        private string serverEndPoin = "";
        public CreateTask()
        {
            InitializeComponent();
        }
        public CreateTask(string sv, string id)
        {
            userID = id;
            serverEndPoin = sv;
            InitializeComponent();

        }

        private void btn_ext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_create_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                var httpClient = new HttpClient();

                string url = serverEndPoin + "/tasks";
                string name = txt_task_name.Text;
                string description = txt_description.Text;
                string dueTime = TxtTime.Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.sssZ");
                string tag = txt_tag.Text;
                // Khởi tạo http client
                var httpRequestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(url)                  
                };
                // Tạo StringContent
                string jsoncontent = "{\"taskName\": \"" + name + "\", \"description\": \"" + description + "\", \"dueTime\": \"" + dueTime + "\", \"tags\": [\"" + tag + "\"]}";
                var httpContent = new StringContent(jsoncontent, Encoding.UTF8, "application/json");
                httpRequestMessage.Content = httpContent;
                httpClient.DefaultRequestHeaders.Add("Authorization", userID);
                // call api
                var response = await httpClient.SendAsync(httpRequestMessage);
                var responseContent = await response.Content.ReadAsStringAsync();
                var status = response.StatusCode;
                MessageBox.Show(responseContent);
                // Chuyển sang object 
                JavaScriptSerializer j = new JavaScriptSerializer();
                var obj = j.Deserialize<dynamic>(responseContent);


                switch (status)
                {
                    case System.Net.HttpStatusCode.OK:
                        MessageBox.Show("Created");
                        break;
                    case System.Net.HttpStatusCode.Unauthorized:
                        break;
                    case System.Net.HttpStatusCode.Created:
                        MessageBox.Show("New Task Created");
                        TaskList frm = new TaskList(serverEndPoin, userID);
                        frm.Show();
                        this.Hide();
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
    }
}
