namespace Project
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
            this.pro_id = new System.Windows.Forms.TextBox();
            this.pro_name = new System.Windows.Forms.TextBox();
            this.pro_price = new System.Windows.Forms.TextBox();
            this.pro_qty = new System.Windows.Forms.TextBox();
            this.pro_type = new System.Windows.Forms.TextBox();
            this.pro_unit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pro_id
            // 
            this.pro_id.Location = new System.Drawing.Point(235, 68);
            this.pro_id.Name = "pro_id";
            this.pro_id.Size = new System.Drawing.Size(188, 20);
            this.pro_id.TabIndex = 0;
            // 
            // pro_name
            // 
            this.pro_name.Location = new System.Drawing.Point(235, 100);
            this.pro_name.Name = "pro_name";
            this.pro_name.Size = new System.Drawing.Size(188, 20);
            this.pro_name.TabIndex = 1;
            // 
            // pro_price
            // 
            this.pro_price.Location = new System.Drawing.Point(235, 136);
            this.pro_price.Name = "pro_price";
            this.pro_price.Size = new System.Drawing.Size(188, 20);
            this.pro_price.TabIndex = 2;
            // 
            // pro_qty
            // 
            this.pro_qty.Location = new System.Drawing.Point(235, 177);
            this.pro_qty.Name = "pro_qty";
            this.pro_qty.Size = new System.Drawing.Size(188, 20);
            this.pro_qty.TabIndex = 3;
            // 
            // pro_type
            // 
            this.pro_type.Location = new System.Drawing.Point(235, 210);
            this.pro_type.Name = "pro_type";
            this.pro_type.Size = new System.Drawing.Size(188, 20);
            this.pro_type.TabIndex = 4;
            // 
            // pro_unit
            // 
            this.pro_unit.Location = new System.Drawing.Point(235, 247);
            this.pro_unit.Name = "pro_unit";
            this.pro_unit.Size = new System.Drawing.Size(188, 20);
            this.pro_unit.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "รหัสสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ชื่อสินค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ราคาสินค้า";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "จำนวนสินค้า";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ประเภทสินค้า";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "หน่วยนับสินค้า";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(348, 289);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "บันทึกข้อมูล";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pro_unit);
            this.Controls.Add(this.pro_type);
            this.Controls.Add(this.pro_qty);
            this.Controls.Add(this.pro_price);
            this.Controls.Add(this.pro_name);
            this.Controls.Add(this.pro_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pro_id;
        private System.Windows.Forms.TextBox pro_name;
        private System.Windows.Forms.TextBox pro_price;
        private System.Windows.Forms.TextBox pro_qty;
        private System.Windows.Forms.TextBox pro_type;
        private System.Windows.Forms.TextBox pro_unit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_save;
    }
}

