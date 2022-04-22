namespace MyTaskApp
{
    partial class newtask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newtask));
            this.textBox_newtask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_addtask = new System.Windows.Forms.Button();
            this.button_closeapp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_newtask
            // 
            this.textBox_newtask.Location = new System.Drawing.Point(42, 75);
            this.textBox_newtask.Multiline = true;
            this.textBox_newtask.Name = "textBox_newtask";
            this.textBox_newtask.Size = new System.Drawing.Size(232, 163);
            this.textBox_newtask.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Task";
            // 
            // button_addtask
            // 
            this.button_addtask.Location = new System.Drawing.Point(42, 244);
            this.button_addtask.Name = "button_addtask";
            this.button_addtask.Size = new System.Drawing.Size(232, 48);
            this.button_addtask.TabIndex = 2;
            this.button_addtask.Text = "Create New Task";
            this.button_addtask.UseVisualStyleBackColor = true;
            this.button_addtask.Click += new System.EventHandler(this.button_addtask_Click);
            // 
            // button_closeapp
            // 
            this.button_closeapp.FlatAppearance.BorderSize = 0;
            this.button_closeapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_closeapp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_closeapp.Location = new System.Drawing.Point(283, 12);
            this.button_closeapp.Name = "button_closeapp";
            this.button_closeapp.Size = new System.Drawing.Size(30, 29);
            this.button_closeapp.TabIndex = 10;
            this.button_closeapp.Text = "X";
            this.button_closeapp.UseVisualStyleBackColor = true;
            this.button_closeapp.Click += new System.EventHandler(this.button_closeapp_Click);
            // 
            // newtask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(306, 294);
            this.Controls.Add(this.button_closeapp);
            this.Controls.Add(this.button_addtask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_newtask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(322, 333);
            this.MinimumSize = new System.Drawing.Size(322, 333);
            this.Name = "newtask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newtask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_newtask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_addtask;
        private System.Windows.Forms.Button button_closeapp;
    }
}