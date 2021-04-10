namespace todo_list
{
    partial class CreateTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_task_name = new System.Windows.Forms.TextBox();
            this.txt_tag = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.TxtTime = new System.Windows.Forms.DateTimePicker();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_ext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Due Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // txt_task_name
            // 
            this.txt_task_name.Location = new System.Drawing.Point(157, 32);
            this.txt_task_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_task_name.Name = "txt_task_name";
            this.txt_task_name.Size = new System.Drawing.Size(311, 20);
            this.txt_task_name.TabIndex = 4;
            // 
            // txt_tag
            // 
            this.txt_tag.Location = new System.Drawing.Point(148, 271);
            this.txt_tag.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tag.Name = "txt_tag";
            this.txt_tag.Size = new System.Drawing.Size(153, 20);
            this.txt_tag.TabIndex = 5;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(148, 148);
            this.txt_description.Margin = new System.Windows.Forms.Padding(2);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(349, 97);
            this.txt_description.TabIndex = 6;
            // 
            // TxtTime
            // 
            this.TxtTime.Location = new System.Drawing.Point(157, 92);
            this.TxtTime.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.Size = new System.Drawing.Size(236, 20);
            this.TxtTime.TabIndex = 7;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_create.Location = new System.Drawing.Point(137, 315);
            this.btn_create.Margin = new System.Windows.Forms.Padding(2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(85, 31);
            this.btn_create.TabIndex = 8;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_ClickAsync);
            // 
            // btn_ext
            // 
            this.btn_ext.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_ext.Location = new System.Drawing.Point(365, 315);
            this.btn_ext.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(85, 31);
            this.btn_ext.TabIndex = 9;
            this.btn_ext.Text = "Exit";
            this.btn_ext.UseVisualStyleBackColor = false;
            this.btn_ext.Click += new System.EventHandler(this.btn_ext_Click);
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 366);
            this.Controls.Add(this.btn_ext);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.TxtTime);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_tag);
            this.Controls.Add(this.txt_task_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateTask";
            this.Text = "Create Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_task_name;
        private System.Windows.Forms.TextBox txt_tag;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.DateTimePicker TxtTime;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_ext;
    }
}