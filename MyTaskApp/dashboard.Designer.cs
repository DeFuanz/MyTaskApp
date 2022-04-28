namespace MyTaskApp
{
    partial class DashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userlabel = new System.Windows.Forms.Label();
            this.taskappDataSet = new MyTaskApp.taskappDataSet();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksTableAdapter = new MyTaskApp.taskappDataSetTableAdapters.tasksTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button_logout = new System.Windows.Forms.Button();
            this.panel_tasks = new System.Windows.Forms.Panel();
            this.textBox_addtask = new System.Windows.Forms.TextBox();
            this.panel_home = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_daystasks = new System.Windows.Forms.ListBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskappDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_tasks.SuspendLayout();
            this.panel_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(163, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add New Task";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(433, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear All Tasks";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome,";
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.BackColor = System.Drawing.Color.White;
            this.userlabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.ForeColor = System.Drawing.Color.Black;
            this.userlabel.Location = new System.Drawing.Point(136, 21);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(99, 25);
            this.userlabel.TabIndex = 6;
            this.userlabel.Text = "username";
            this.userlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskappDataSet
            // 
            this.taskappDataSet.DataSetName = "taskappDataSet";
            this.taskappDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "tasks";
            this.tasksBindingSource.DataSource = this.taskappDataSet;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(320, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "Mark As Completed";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 496);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(0, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 334);
            this.panel3.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-1, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(228, 42);
            this.button5.TabIndex = 1;
            this.button5.Text = "Manage Tasks";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-1, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(228, 41);
            this.button4.TabIndex = 0;
            this.button4.Text = "DashBoard";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "TaskApp";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(35, 17);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(504, 357);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.White;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_logout.Location = new System.Drawing.Point(713, 9);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(91, 22);
            this.button_logout.TabIndex = 4;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.Button_logout_Click);
            // 
            // panel_tasks
            // 
            this.panel_tasks.Controls.Add(this.textBox_addtask);
            this.panel_tasks.Controls.Add(this.checkedListBox1);
            this.panel_tasks.Controls.Add(this.button1);
            this.panel_tasks.Controls.Add(this.button3);
            this.panel_tasks.Controls.Add(this.button2);
            this.panel_tasks.Location = new System.Drawing.Point(234, 37);
            this.panel_tasks.Name = "panel_tasks";
            this.panel_tasks.Size = new System.Drawing.Size(570, 446);
            this.panel_tasks.TabIndex = 10;
            // 
            // textBox_addtask
            // 
            this.textBox_addtask.Location = new System.Drawing.Point(35, 401);
            this.textBox_addtask.Multiline = true;
            this.textBox_addtask.Name = "textBox_addtask";
            this.textBox_addtask.Size = new System.Drawing.Size(122, 42);
            this.textBox_addtask.TabIndex = 8;
            // 
            // panel_home
            // 
            this.panel_home.Controls.Add(this.label4);
            this.panel_home.Controls.Add(this.listBox_daystasks);
            this.panel_home.Controls.Add(this.label_date);
            this.panel_home.Controls.Add(this.label3);
            this.panel_home.Controls.Add(this.label2);
            this.panel_home.Controls.Add(this.userlabel);
            this.panel_home.Location = new System.Drawing.Point(234, 37);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(570, 446);
            this.panel_home.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Your Current Tasks Are:";
            // 
            // listBox_daystasks
            // 
            this.listBox_daystasks.FormattingEnabled = true;
            this.listBox_daystasks.Location = new System.Drawing.Point(35, 188);
            this.listBox_daystasks.Name = "listBox_daystasks";
            this.listBox_daystasks.Size = new System.Drawing.Size(322, 225);
            this.listBox_daystasks.TabIndex = 9;
            this.listBox_daystasks.SelectedIndexChanged += new System.EventHandler(this.listBox_daystasks_SelectedIndexChanged);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BackColor = System.Drawing.Color.White;
            this.label_date.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.Black;
            this.label_date.Location = new System.Drawing.Point(108, 61);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(44, 21);
            this.label_date.TabIndex = 8;
            this.label_date.Text = "date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Today Is";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 495);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_home);
            this.Controls.Add(this.panel_tasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 495);
            this.MinimumSize = new System.Drawing.Size(816, 495);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskappDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel_tasks.ResumeLayout(false);
            this.panel_tasks.PerformLayout();
            this.panel_home.ResumeLayout(false);
            this.panel_home.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userlabel;
        private taskappDataSet taskappDataSet;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private taskappDataSetTableAdapters.tasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Panel panel_tasks;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_addtask;
        private System.Windows.Forms.ListBox listBox_daystasks;
        private System.Windows.Forms.Label label4;
    }
}