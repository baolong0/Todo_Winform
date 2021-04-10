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
using todo_list.Model;

namespace todo_list
{
    public partial class TaskList : Form
    {
        private string userID = "";
        private string serverEndPoin = "";
        public TaskList()
        {
            InitializeComponent();
        }
        public TaskList(string sv, string id)
        {
            userID = id;
            serverEndPoin = sv;
            InitializeComponent();
            getListTask();

        }

        private  void Btn_refresh_click(object sender, EventArgs e)
        {
             getListTask();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void getListTask()
        {
            string url = serverEndPoin + "/tasks";

            // Khởi tạo http client
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", userID);
            // Get data
            var response = await httpClient.GetAsync(url);
            var responseContent = await response.Content.ReadAsStringAsync();
            var status = response.StatusCode;

            // Chuyển sang object 
            JavaScriptSerializer j = new JavaScriptSerializer();
            var obj = j.Deserialize<dynamic>(responseContent);
            List<TaskDT> listTask = new List<TaskDT>();
            foreach (var item in obj["data"])
            {
                TaskDT temp = new TaskDT();
                temp.Id = item["id"];
                temp.Name = item["name"];
                temp.DueTime = item["dueTime"];
                temp.Status = item["status"];
                temp.Tag = item["tagsList"][0]["name"];
                listTask.Add(temp);
            }
            dgv_list_task.DataSource = listTask;
            switch (status)
            {
                case System.Net.HttpStatusCode.OK:
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
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            CreateTask ftm = new CreateTask(serverEndPoin,userID);
            ftm.Show();
        }

        private void btn_viewprofile_Click(object sender, EventArgs e)
        {

        }
    }
}
