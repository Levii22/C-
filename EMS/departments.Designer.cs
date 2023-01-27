using System.Windows.Forms;
using System;

namespace EMS
{
    partial class departments
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.DepTab = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.EmpTab = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.departdata = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.DepNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departdata)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EMS.Properties.Resources._16147924811618134427_128;
            this.pictureBox3.Location = new System.Drawing.Point(624, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // DepTab
            // 
            this.DepTab.AutoSize = true;
            this.DepTab.BackColor = System.Drawing.Color.Transparent;
            this.DepTab.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DepTab.ForeColor = System.Drawing.Color.Black;
            this.DepTab.Location = new System.Drawing.Point(498, 60);
            this.DepTab.Name = "DepTab";
            this.DepTab.Size = new System.Drawing.Size(120, 25);
            this.DepTab.TabIndex = 29;
            this.DepTab.Text = "Departments";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EMS.Properties.Resources._2440463971582985690_128;
            this.pictureBox2.Location = new System.Drawing.Point(444, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // EmpTab
            // 
            this.EmpTab.AutoSize = true;
            this.EmpTab.BackColor = System.Drawing.Color.Transparent;
            this.EmpTab.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EmpTab.ForeColor = System.Drawing.Color.Black;
            this.EmpTab.Location = new System.Drawing.Point(340, 60);
            this.EmpTab.Name = "EmpTab";
            this.EmpTab.Size = new System.Drawing.Size(98, 25);
            this.EmpTab.TabIndex = 27;
            this.EmpTab.Text = "Employees";
            this.EmpTab.Click += new System.EventHandler(this.EmpTab_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EMS.Properties.Resources._19339625881548233621_128;
            this.pictureBox1.Location = new System.Drawing.Point(286, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.UpdateBtn.FlatAppearance.BorderSize = 3;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn.Location = new System.Drawing.Point(127, 268);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(105, 44);
            this.UpdateBtn.TabIndex = 43;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.AddBtn.FlatAppearance.BorderSize = 3;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(12, 268);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(105, 44);
            this.AddBtn.TabIndex = 42;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            // 
            // departdata
            // 
            this.departdata.BackgroundColor = System.Drawing.SystemColors.Control;
            this.departdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departdata.GridColor = System.Drawing.Color.White;
            this.departdata.Location = new System.Drawing.Point(238, 189);
            this.departdata.Name = "departdata";
            this.departdata.ReadOnly = true;
            this.departdata.RowTemplate.Height = 25;
            this.departdata.Size = new System.Drawing.Size(751, 507);
            this.departdata.TabIndex = 39;
            this.departdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departdata_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Department name";
            // 
            // DepNameTb
            // 
            this.DepNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepNameTb.Location = new System.Drawing.Point(12, 217);
            this.DepNameTb.Name = "DepNameTb";
            this.DepNameTb.Size = new System.Drawing.Size(185, 26);
            this.DepNameTb.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(386, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 30);
            this.label2.TabIndex = 28;
            this.label2.Text = "Manage departments";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(678, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Log out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Management System v7";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 88);
            this.panel1.TabIndex = 27;
            // 
            // departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 709);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "departments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "departments";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox3;
        private Label DepTab;
        private PictureBox pictureBox2;
        private Label EmpTab;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button1;
        private DataGridView departdata;
        private Label label4;
        private TextBox DepNameTb;
        private Label label2;
        private Label label11;
        private Label label1;
        private Panel panel1;
    }
}