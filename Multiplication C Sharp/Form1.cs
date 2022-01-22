using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplication_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            // To clear the textboxes

            txtstart.Text = "";
            txtstop.Text = "";
            txtmultiply.Text = "";

            listbox.Items.Clear();
            

        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {

            // To declare variables

            int start, stop, multiplier;
            int result;
            int i;
            result = 1;

            // Assigning variables to textboxes

            start = int.Parse(txtstart .Text);
            stop = int.Parse(txtstop .Text );
            multiplier = int.Parse(txtmultiply .Text );

            // Performing the Loop

            for ( i = start ; i <= stop ; i++)
            {
                // Doing the calculation

                result = multiplier * i;

                // Displaying the result in a Listbox
                listbox.Items.Add(multiplier + " " +  "Times" + " " +  i  + " " + "=" + " " + result.ToString());
                
 
            }
           
                   
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {

           // this.Close();
           // Application.Exit();

            if (MessageBox.Show("Sure to Exit", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                Application.Exit();
            }

        }
    }
}
