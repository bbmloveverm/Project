using Project.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionStr.connectsql();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (pro_id == null)
            {
                MessageBox.Show("insert data");
            }
            else
            {
                ConnectionStr.executsql("insert into Tbl_Inventory(Product_ID,Product_Name,Product_Price,Product_Qty,Product_Type,Product_Unit) values ('" + pro_id.Text + "','" + pro_name.Text + "','" + pro_price.Text + "','" + pro_qty.Text + "','" + pro_type.Text + "','" + pro_unit.Text + "')");

                MessageBox.Show(pro_id.Text);
            }
            
        }
    }
}
