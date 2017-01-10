namespace Lab5_WF
{
    partial class Form1
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
        
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.startB_1Dim = new System.Windows.Forms.Button();
            this.startB_2Dim = new System.Windows.Forms.Button();
            this.startB_Jagged = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ActionButton = new System.Windows.Forms.Button();
            this.ActionName = new System.Windows.Forms.TextBox();
            this.DoCreateButton = new System.Windows.Forms.Button();
            this.taskBox = new System.Windows.Forms.TextBox();
            this.DoActionButton = new System.Windows.Forms.Button();
            this.RandFillButton = new System.Windows.Forms.Button();
            this.RFButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(10, 10);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(780, 140);
            this.textBox.Text = "Для начала работы выберите одну из кнопок";
            this.textBox.TabIndex = 0;
            this.textBox.WordWrap = false;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // startB_1Dim
            // 
            this.startB_1Dim.Font = new System.Drawing.Font("Helvetica Neue", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startB_1Dim.Location = new System.Drawing.Point(20, 165);
            this.startB_1Dim.Name = "startB_1Dim";
            this.startB_1Dim.Size = new System.Drawing.Size(200, 35);
            this.startB_1Dim.TabIndex = 1;
            this.startB_1Dim.Text = "Одномерный массив";
            this.startB_1Dim.UseVisualStyleBackColor = true;
            this.startB_1Dim.Click += new System.EventHandler(this.startB_1Dim_Click);
            // 
            // startB_2Dim
            // 
            this.startB_2Dim.Font = new System.Drawing.Font("Helvetica Neue", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startB_2Dim.Location = new System.Drawing.Point(300, 165);
            this.startB_2Dim.Name = "startB_2Dim";
            this.startB_2Dim.Size = new System.Drawing.Size(200, 35);
            this.startB_2Dim.TabIndex = 2;
            this.startB_2Dim.Text = "Двумерный массив";
            this.startB_2Dim.UseVisualStyleBackColor = true;
            this.startB_2Dim.Click += new System.EventHandler(this.startB_2Dim_Click);
            // 
            // startB_Jagged
            // 
            this.startB_Jagged.Font = new System.Drawing.Font("Helvetica Neue", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startB_Jagged.Location = new System.Drawing.Point(580, 165);
            this.startB_Jagged.Name = "startB_Jagged";
            this.startB_Jagged.Size = new System.Drawing.Size(200, 35);
            this.startB_Jagged.TabIndex = 3;
            this.startB_Jagged.Text = "Рваный массив";
            this.startB_Jagged.UseVisualStyleBackColor = true;
            this.startB_Jagged.Click += new System.EventHandler(this.startB_Jagged_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Helvetica Neue", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(580, 215);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(200, 35);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Создать массив";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Visible = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ActionButton
            // 
            this.ActionButton.Font = new System.Drawing.Font("Helvetica Neue", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionButton.Location = new System.Drawing.Point(20, 215);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(200, 35);
            this.ActionButton.TabIndex = 7;
            this.ActionButton.Text = "Действие";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Visible = false;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // ActionName
            // 
            this.ActionName.Enabled = false;
            this.ActionName.Font = new System.Drawing.Font("Helvetica Neue", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionName.Location = new System.Drawing.Point(250, 205);
            this.ActionName.Multiline = true;
            this.ActionName.Name = "ActionName";
            this.ActionName.ReadOnly = true;
            this.ActionName.Size = new System.Drawing.Size(300, 50);
            this.ActionName.TabIndex = 8;
            this.ActionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ActionName.Visible = false;
            // 
            // DoCreateButton
            // 
            this.DoCreateButton.Font = new System.Drawing.Font("Helvetica Neue", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoCreateButton.Location = new System.Drawing.Point(20, 265);
            this.DoCreateButton.Name = "DoCreateButton";
            this.DoCreateButton.Size = new System.Drawing.Size(370, 35);
            this.DoCreateButton.TabIndex = 9;
            this.DoCreateButton.Text = "Записать массив";
            this.DoCreateButton.UseVisualStyleBackColor = true;
            this.DoCreateButton.Visible = false;
            this.DoCreateButton.Click += new System.EventHandler(this.DoCreateButton_Click);
            // 
            // taskBox
            // 
            this.taskBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskBox.Location = new System.Drawing.Point(20, 315);
            this.taskBox.Multiline = true;
            this.taskBox.Name = "taskBox";
            this.taskBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.taskBox.Size = new System.Drawing.Size(760, 75);
            this.taskBox.TabIndex = 10;
            this.taskBox.Visible = false;
            this.taskBox.WordWrap = false;
            this.taskBox.TextChanged += new System.EventHandler(this.taskBox_TextChanged);
            // 
            // DoActionButton
            // 
            this.DoActionButton.Font = new System.Drawing.Font("Helvetica Neue", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoActionButton.Location = new System.Drawing.Point(20, 400);
            this.DoActionButton.Name = "DoActionButton";
            this.DoActionButton.Size = new System.Drawing.Size(760, 30);
            this.DoActionButton.TabIndex = 11;
            this.DoActionButton.Text = "Выполнить действие";
            this.DoActionButton.UseVisualStyleBackColor = true;
            this.DoActionButton.Visible = false;
            this.DoActionButton.Click += new System.EventHandler(this.DoActionButton_Click);
            // 
            // RandFillButton
            // 
            this.RandFillButton.Font = new System.Drawing.Font("Helvetica Neue", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandFillButton.Location = new System.Drawing.Point(410, 265);
            this.RandFillButton.Name = "RandFillButton";
            this.RandFillButton.Size = new System.Drawing.Size(370, 35);
            this.RandFillButton.TabIndex = 12;
            this.RandFillButton.Text = "Заполнить случайно";
            this.RandFillButton.UseVisualStyleBackColor = true;
            this.RandFillButton.Visible = false;
            this.RandFillButton.Click += new System.EventHandler(this.RandFillButton_Click);
            // 
            // RFButton
            // 
            this.RFButton.Font = new System.Drawing.Font("Helvetica Neue", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFButton.Location = new System.Drawing.Point(410, 265);
            this.RFButton.Name = "RFButton";
            this.RFButton.Size = new System.Drawing.Size(370, 35);
            this.RFButton.TabIndex = 13;
            this.RFButton.Text = "Заполнить случайно";
            this.RFButton.UseVisualStyleBackColor = true;
            this.RFButton.Visible = false;
            this.RFButton.Click += new System.EventHandler(this.RFButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RFButton);
            this.Controls.Add(this.RandFillButton);
            this.Controls.Add(this.DoActionButton);
            this.Controls.Add(this.taskBox);
            this.Controls.Add(this.DoCreateButton);
            this.Controls.Add(this.ActionName);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.startB_Jagged);
            this.Controls.Add(this.startB_2Dim);
            this.Controls.Add(this.startB_1Dim);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "5 Лаба";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button startB_1Dim;
        private System.Windows.Forms.Button startB_2Dim;
        private System.Windows.Forms.Button startB_Jagged;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.TextBox ActionName;
        private System.Windows.Forms.Button DoCreateButton;
        private System.Windows.Forms.TextBox taskBox;
        private System.Windows.Forms.Button DoActionButton;
        private System.Windows.Forms.Button RandFillButton;
        private System.Windows.Forms.Button RFButton;
    }
}

