namespace LuckyNumberGenerator
{
    partial class LuckyNumberGenerator
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
            this.cmbbx_date = new System.Windows.Forms.ComboBox();
            this.cmbbx_month = new System.Windows.Forms.ComboBox();
            this.cmbbx_year = new System.Windows.Forms.ComboBox();
            this.cmbbx_color = new System.Windows.Forms.ComboBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbbx_date
            // 
            this.cmbbx_date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_date.FormattingEnabled = true;
            this.cmbbx_date.Location = new System.Drawing.Point(451, 291);
            this.cmbbx_date.Name = "cmbbx_date";
            this.cmbbx_date.Size = new System.Drawing.Size(104, 37);
            this.cmbbx_date.TabIndex = 0;
            // 
            // cmbbx_month
            // 
            this.cmbbx_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_month.FormattingEnabled = true;
            this.cmbbx_month.Location = new System.Drawing.Point(451, 182);
            this.cmbbx_month.Name = "cmbbx_month";
            this.cmbbx_month.Size = new System.Drawing.Size(254, 37);
            this.cmbbx_month.TabIndex = 1;
            this.cmbbx_month.SelectedIndexChanged += new System.EventHandler(this.cmbbx_month_SelectedIndexChanged);
            // 
            // cmbbx_year
            // 
            this.cmbbx_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_year.FormattingEnabled = true;
            this.cmbbx_year.Location = new System.Drawing.Point(451, 73);
            this.cmbbx_year.Name = "cmbbx_year";
            this.cmbbx_year.Size = new System.Drawing.Size(147, 37);
            this.cmbbx_year.TabIndex = 2;
            // 
            // cmbbx_color
            // 
            this.cmbbx_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_color.FormattingEnabled = true;
            this.cmbbx_color.Location = new System.Drawing.Point(451, 400);
            this.cmbbx_color.Name = "cmbbx_color";
            this.cmbbx_color.Size = new System.Drawing.Size(209, 37);
            this.cmbbx_color.TabIndex = 3;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(348, 294);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(69, 29);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "Date:";
            // 
            // lbl_Month
            // 
            this.lbl_Month.AutoSize = true;
            this.lbl_Month.Location = new System.Drawing.Point(332, 185);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(85, 29);
            this.lbl_Month.TabIndex = 5;
            this.lbl_Month.Text = "Month:";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(347, 76);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(70, 29);
            this.lbl_year.TabIndex = 6;
            this.lbl_year.Text = "Year:";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(246, 403);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(171, 29);
            this.lbl_color.TabIndex = 7;
            this.lbl_color.Text = "Favorite Color:";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(451, 504);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(147, 79);
            this.btn_calculate.TabIndex = 8;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // dataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 641);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_Month);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.cmbbx_color);
            this.Controls.Add(this.cmbbx_year);
            this.Controls.Add(this.cmbbx_month);
            this.Controls.Add(this.cmbbx_date);
            this.Name = "dataForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbx_date;
        private System.Windows.Forms.ComboBox cmbbx_month;
        private System.Windows.Forms.ComboBox cmbbx_year;
        private System.Windows.Forms.ComboBox cmbbx_color;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_Month;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Button btn_calculate;
    }
}

