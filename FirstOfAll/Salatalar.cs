using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstOfAll
{
    public partial class Salatalar : Form
    {
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;

        public Salatalar()
        {
            InitializeComponent();
        }
       
        public void addToCheckBox(Button b, int a)
        {

            if (a != 1)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.Items.IndexOf(checkedListBox1.GetItemText(b.Text.ToString() + "(" + (a - 1).ToString() + ")")));

                checkedListBox1.Items.Add(checkedListBox1.GetItemText(b.Text.ToString() + "(" + a.ToString() + ")"));

            }
            else
            {
                checkedListBox1.Items.Add(checkedListBox1.GetItemText(b.Text.ToString() + "(" + a.ToString() + ")"));
            }


            
        }
        private void ByzPeynrlSlt_Click(object sender, EventArgs e)
        {
            count1++;

            addToCheckBox(ByzPeynrlSlt, count1);
        }

        private void TnBlklSlt_Click(object sender, EventArgs e)
        {
            count2++;

            addToCheckBox(TnBlklSlt, count2);
        }

        private void SchntzlSlt_Click(object sender, EventArgs e)
        {
            count3++;

            addToCheckBox(SchntzlSlt, count3);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void KsrlSlt_Click(object sender, EventArgs e)
        {
            count4++;

            addToCheckBox(KsrlSlt, count4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
            {
                // clb is the name of the CheckedListBox control
                if (checkedListBox1.GetItemChecked(i))
                {

                    int q = checkedListBox1.Items[i].ToString().Length;
                    string tempOb = checkedListBox1.Items[i].ToString().Substring(0, q - 3);
                    int num = 0;
                    try
                    {
                        num = int.Parse(checkedListBox1.Items[i].ToString().Substring((q - 2), 1)) - 1;
                    }
                    catch (Exception exc)
                    {

                    }


                    if (tempOb.Equals(ByzPeynrlSlt.Text.ToString()))
                    {
                        count1 = num;
                    }
                    else if (tempOb.Equals(TnBlklSlt.Text.ToString()))
                    {
                        count2 = num;
                    }
                    else if (tempOb.Equals(SchntzlSlt.Text.ToString()))
                    {
                        count3 = num;
                    }
                    else if (tempOb.Equals(KsrlSlt.Text.ToString()))
                    {
                        count4 = num;
                    }

                    if (num != 0)
                    {

                        checkedListBox1.Items.Add(checkedListBox1.Items[i].ToString().
                            Replace(checkedListBox1.Items[i].ToString().Substring(
                                        (q - 2), 1), num.ToString()

                                        ));

                        checkedListBox1.SetItemChecked(checkedListBox1.Items.Count - 1, true);
                        checkedListBox1.Items.Remove(checkedListBox1.Items[i]);


                    }
                    else
                    {
                        checkedListBox1.Items.Remove(checkedListBox1.Items[i]);

                    }




                }
            }
        }

        private void silHepsini_Click(object sender, EventArgs e)
        {
            count1 = 0; count2 = 0; count3 = 0; count4 = 0;
            checkedListBox1.Items.Clear();
        }

        private void Salatalar_Load(object sender, EventArgs e)
        {

        }
    }
}
