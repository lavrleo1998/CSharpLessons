
namespace JsonDataBaseFootball
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonGetTeamByFootballer = new System.Windows.Forms.Button();
            this.buttonGetTeamByTeamType = new System.Windows.Forms.Button();
            this.buttonGetTeamByDate = new System.Windows.Forms.Button();
            this.buttonGetEventsByFootballer = new System.Windows.Forms.Button();
            this.buttonGetEventsByFootballerAndDate = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(545, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(545, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(527, 393);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // buttonGetTeamByFootballer
            // 
            this.buttonGetTeamByFootballer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetTeamByFootballer.Location = new System.Drawing.Point(545, 12);
            this.buttonGetTeamByFootballer.Name = "buttonGetTeamByFootballer";
            this.buttonGetTeamByFootballer.Size = new System.Drawing.Size(215, 23);
            this.buttonGetTeamByFootballer.TabIndex = 0;
            this.buttonGetTeamByFootballer.Text = "GetTeamByFootballer";
            this.buttonGetTeamByFootballer.UseVisualStyleBackColor = true;
            this.buttonGetTeamByFootballer.Click += new System.EventHandler(this.buttonGetTeamByFootballer_Click);
            // 
            // buttonGetTeamByTeamType
            // 
            this.buttonGetTeamByTeamType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetTeamByTeamType.Location = new System.Drawing.Point(545, 69);
            this.buttonGetTeamByTeamType.Name = "buttonGetTeamByTeamType";
            this.buttonGetTeamByTeamType.Size = new System.Drawing.Size(215, 23);
            this.buttonGetTeamByTeamType.TabIndex = 1;
            this.buttonGetTeamByTeamType.Text = "GetTeamByTeamType";
            this.buttonGetTeamByTeamType.UseVisualStyleBackColor = true;
            this.buttonGetTeamByTeamType.Click += new System.EventHandler(this.buttonGetTeamByTeamType_Click);
            // 
            // buttonGetTeamByDate
            // 
            this.buttonGetTeamByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetTeamByDate.Location = new System.Drawing.Point(545, 130);
            this.buttonGetTeamByDate.Name = "buttonGetTeamByDate";
            this.buttonGetTeamByDate.Size = new System.Drawing.Size(215, 23);
            this.buttonGetTeamByDate.TabIndex = 2;
            this.buttonGetTeamByDate.Text = "GetTeamByDate";
            this.buttonGetTeamByDate.UseVisualStyleBackColor = true;
            this.buttonGetTeamByDate.Click += new System.EventHandler(this.buttonGetTeamByDate_Click);
            // 
            // buttonGetEventsByFootballer
            // 
            this.buttonGetEventsByFootballer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetEventsByFootballer.Location = new System.Drawing.Point(545, 187);
            this.buttonGetEventsByFootballer.Name = "buttonGetEventsByFootballer";
            this.buttonGetEventsByFootballer.Size = new System.Drawing.Size(215, 23);
            this.buttonGetEventsByFootballer.TabIndex = 7;
            this.buttonGetEventsByFootballer.Text = "GetEventsByFootballer";
            this.buttonGetEventsByFootballer.UseVisualStyleBackColor = true;
            this.buttonGetEventsByFootballer.Click += new System.EventHandler(this.buttonGetEventsByFootballer_Click);
            // 
            // buttonGetEventsByFootballerAndDate
            // 
            this.buttonGetEventsByFootballerAndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetEventsByFootballerAndDate.Location = new System.Drawing.Point(545, 244);
            this.buttonGetEventsByFootballerAndDate.Name = "buttonGetEventsByFootballerAndDate";
            this.buttonGetEventsByFootballerAndDate.Size = new System.Drawing.Size(215, 23);
            this.buttonGetEventsByFootballerAndDate.TabIndex = 8;
            this.buttonGetEventsByFootballerAndDate.Text = "GetEventsByFootballerAndDate";
            this.buttonGetEventsByFootballerAndDate.UseVisualStyleBackColor = true;
            this.buttonGetEventsByFootballerAndDate.Click += new System.EventHandler(this.buttonGetEventsByFootballerAndDate_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(545, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(545, 216);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(545, 273);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(651, 273);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(651, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введи айди футболиста";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(651, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Введи название типа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(651, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Введи айди футболиста";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(857, 417);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonGetEventsByFootballerAndDate);
            this.Controls.Add(this.buttonGetEventsByFootballer);
            this.Controls.Add(this.buttonGetTeamByDate);
            this.Controls.Add(this.buttonGetTeamByTeamType);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonGetTeamByFootballer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonGetTeamByFootballer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonGetTeamByTeamType;
        private System.Windows.Forms.Button buttonGetTeamByDate;
        private System.Windows.Forms.Button buttonGetEventsByFootballer;
        private System.Windows.Forms.Button buttonGetEventsByFootballerAndDate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

