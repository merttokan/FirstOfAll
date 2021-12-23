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
    public partial class Kasa : Form
    {
        
        Mutfak mutfakform = new Mutfak();
        
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        int count5 = 0;
        int count6 = 0;
        int count7 = 0;
        int count8 = 0;
        int count9 = 0;
        int count10 = 0;
        int count11 = 0;
        int count12 = 0;
        int count13 = 0;
        int count14 = 0;
        int count15 = 0;
        int count16 = 0;
        int count17 = 0;
        int count18 = 0;
        int count19 = 0;
        int count20 = 0;
        int count21 = 0;
        int count22 = 0;
        int count23 = 0;
        int count24 = 0;
        int count25 = 0;
        int count26 = 0;

        int count27 = 0;
        int count28 = 0;
        int count29 = 0;
        int count30 = 0;
        
        public Kasa()
        {
            InitializeComponent();
        }
        private void setToZero()
        {
            count2 = 0; count20 = 0;
            count1 = 0; count21 = 0;
            count3 = 0; count22 = 0;
            count4 = 0; count23= 0;
            count5 = 0; count24 = 0;
            count6 = 0; count25 = 0;
            count7 = 0; count26 = 0;
            count8 = 0; count27 = 0;
            count9 = 0; count28 = 0;
            count10 = 0; count29 = 0;
            count11 = 0; count30 = 0;
            count12 = 0; 
            count13 = 0; 
            count14 = 0; 
            count15 = 0; 
            count16 = 0; 
            count17 = 0; 
            count18 = 0;
            count19 = 0;

        }


        private void secSil_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
            {
                // clb is the name of the CheckedListBox control
                if (checkedListBox1.GetItemChecked(i))
                {
                
                    int q = checkedListBox1.Items[i].ToString().Length;
                    string tempOb = checkedListBox1.Items[i].ToString().Substring(0,q - 3);
                    int num = 0;
                    try {
                        num = int.Parse(checkedListBox1.Items[i].ToString().Substring((q - 2), 1)) - 1; }
                    catch (Exception exc)
                    {

                    }
                    
                    
                    if (tempOb.Equals(pogaca.Text.ToString()))
                    {
                        count1 = num;
                    }
                    else if (tempOb.Equals(bpSv.Text.ToString()))
                    {
                        count2 = num;
                    }
                    else if (tempOb.Equals(tonBSv.Text.ToString()))
                    {
                        count3 = num;
                    }
                    else if (tempOb.Equals(cheddarSv.Text.ToString()))
                    {
                        count4 = num;
                    }
                    else if (tempOb.Equals(salamSv.Text.ToString()))
                    {
                        count5 = num;
                    }
                    else if (tempOb.Equals(schnitSv.Text.ToString()))
                    {
                        count6 = num;
                    }
                    else if (tempOb.Equals(ucgenSv.Text.ToString()))
                    {
                        count7 = num;
                    }
                    else if (tempOb.Equals(kumruSv.Text.ToString()))
                    {
                        count8 = num;
                    }
                    else if (tempOb.Equals(corba.Text.ToString()))
                    {
                        count9 = num;
                    }
                    else if (tempOb.Equals(tereSimit.Text.ToString()))
                    {
                        count10 = num;
                    }
                    else if (tempOb.Equals(kSu.Text.ToString()))
                    {
                        count11 = num;
                    }
                    else if (tempOb.Equals(altiSu.Text.ToString()))
                    {
                        count12 = num;

                    }
                    else if (tempOb.Equals(kCay.Text.ToString()))
                    {
                        count13 = num;
                    }
                    else if (tempOb.Equals(bCay.Text.ToString()))
                    {
                        count14 = num;
                    }
                    else if (tempOb.Equals(bitkiCayı.Text.ToString()))
                    {
                        count15 = num;
                    }
                    else if (tempOb.Equals(kutuIcecek.Text.ToString()))
                    {
                        count16 = num;
                    }
                    else if (tempOb.Equals(litreKutu.Text.ToString()))
                    {
                        count17 = num;
                    }
                    else if (tempOb.Equals(Schweppes.Text.ToString()))
                    {
                        count18 = num;
                    }
                    else if (tempOb.Equals(KutuMeyve.Text.ToString()))
                    {
                        count19 = num;
                    }
                    else if (tempOb.Equals(litreMeyve.Text.ToString()))
                    {
                        count20 = num;
                    }
                    else if (tempOb.Equals(ayran.Text.ToString()))
                    {
                        count21 = num;
                    }
                    else if (tempOb.Equals(salgam.Text.ToString()))
                    {
                        count22 = num;
                    }
                    else if (tempOb.Equals(soda.Text.ToString()))
                    {
                        count23 = num;
                    }
                    else if (tempOb.Equals(sadeSut.Text.ToString()))
                    {
                        count24 = num;
                    }
                    else if (tempOb.Equals(meyveliSut.Text.ToString()))
                    {
                        count25 = num;
                    }
                    else if (tempOb.Equals(burn.Text.ToString()))
                    {           
                        count26 = num;
                    }
                    else if (tempOb.Equals(monster.Text.ToString()))
                    {
                        count27 = num;
                    }
                    else if (tempOb.Equals(powerade.Text.ToString()))
                    {
                        count28 = num;
                    }
                    else if (tempOb.Equals(redbull.Text.ToString()))
                    {
                        count29 = num;
                    }
                    if (num !=0) {
                        
                        checkedListBox1.Items.Add(checkedListBox1.Items[i].ToString().
                            Replace(checkedListBox1.Items[i].ToString().Substring(
                                        (q - 2), 1), num.ToString()

                                        ));

                        checkedListBox1.SetItemChecked(checkedListBox1.Items.Count-1, true);
                        checkedListBox1.Items.Remove(checkedListBox1.Items[i]);
                       

                    }
                    else
                    {
                        checkedListBox1.Items.Remove(checkedListBox1.Items[i]);
                       
                    }
                   
                    
                    
                    
                }
            }

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


            /* if (a != 1)
             {

                 checkedListBox1.Items.RemoveAt(checkedListBox1.Items.IndexOf(checkedListBox1.GetItemText(b.Text.ToString() + "(" + (a - 1).ToString() + ")")));

                 checkedListBox1.Items.Add(checkedListBox1.GetItemText(b.Text.ToString() + "(" + a.ToString() + ")"));
             }
             else
             {
                 checkedListBox1.Items.Add(checkedListBox1.GetItemText(b.Text.ToString() + "(" + a.ToString() + ")"));
             }
            */
        }
    
            
          
                
                
            
            

            
            
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            count1++;
           
            addToCheckBox(pogaca, count1);



        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            count2++;
            addToCheckBox(bpSv,count2);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            count3++;
            addToCheckBox(tonBSv,count3);
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            count30++;
            addToCheckBox(bSu, count30);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tatliEkle_Click(object sender, EventArgs e)
        {
            try
            {

                checkedListBox1.Items.Add(tatliDrop.SelectedItem.ToString());
            }
            catch(NullReferenceException nu)
            {
                tatliDrop.Text ="Seçmeden ekleyemezsiniz!";
            }
            
        }

        private void cheddarSv_Click(object sender, EventArgs e)
        {

            count4++;
            addToCheckBox(cheddarSv, count4);
        }

        private void salamSv_Click(object sender, EventArgs e)
        {
            count5++;
            addToCheckBox(salamSv, count5);
        }

        private void schnitSv_Click(object sender, EventArgs e)
        {
            count6++;
            addToCheckBox(schnitSv, count6);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            count7++;
            addToCheckBox(ucgenSv,count7);
        }

        private void kumruSv_Click(object sender, EventArgs e)
        {
            count8++;
            addToCheckBox(kumruSv,count8);


        }

        private void corba_Click(object sender, EventArgs e)
        {
            count9++;
            addToCheckBox(corba, count9); ;
        }

        private void tereSimit_Click(object sender, EventArgs e)
        {
            count10++;
            addToCheckBox(tereSimit, count10); ;
        }

        private void kSu_Click(object sender, EventArgs e)
        {
            count11++;
            addToCheckBox(kSu,count11);
        }

        private void altiSu_Click(object sender, EventArgs e)
        {
            count12++;
            addToCheckBox(altiSu, count12);
        }

        private void kCay_Click(object sender, EventArgs e)
        {
            count13++;
            addToCheckBox(kCay, count13);
        }

        private void bCay_Click(object sender, EventArgs e)
        {
            count14++;
            addToCheckBox(bCay, count14);

        }

        private void bitkiCayı_Click(object sender, EventArgs e)
        {
            count15++;
            addToCheckBox(bitkiCayı, count15);

        }

        private void kutuIcecek_Click(object sender, EventArgs e)
        {
            count16++;
            addToCheckBox(kutuIcecek, count16);
        }

        private void litreKutu_Click(object sender, EventArgs e)
        {
            count17++;
            addToCheckBox(litreKutu, count17);
        }

        private void Schweppes_Click(object sender, EventArgs e)
        {
            count18++;
            addToCheckBox(Schweppes, count18);
        }

        private void KutuMeyve_Click(object sender, EventArgs e)
        {
            count19++;
            addToCheckBox(KutuMeyve, count19);
        }

        private void litreMeyve_Click(object sender, EventArgs e)
        {
            count20++;
            addToCheckBox(litreMeyve, count20);
        }

        private void ayran_Click(object sender, EventArgs e)
        {
            count21++;
            addToCheckBox(ayran, count21);
        }

        private void salgam_Click(object sender, EventArgs e)
        {
            count22++;
            addToCheckBox(salgam, count22);
        }

        private void soda_Click(object sender, EventArgs e)
        {
            count23++;
            addToCheckBox(soda, count23);
        }

        private void sadeSut_Click(object sender, EventArgs e)
        {
            count24++;
            addToCheckBox(sadeSut, count24);
        }

        private void meyveliSut_Click(object sender, EventArgs e)
        {
            count25++;
            addToCheckBox(meyveliSut, count25);
        }

        private void burn_Click(object sender, EventArgs e)
        {
            count26++;
            addToCheckBox(burn, count26);

        }

        private void monster_Click(object sender, EventArgs e)
        {
            count27++;
            addToCheckBox(monster, count27);
        }

        private void powerade_Click(object sender, EventArgs e)
        {
            count28++;
            addToCheckBox(powerade, count28);
        }

        private void redbull_Click(object sender, EventArgs e)
        {
            count29++;
            addToCheckBox(redbull, count29);
        }

        private void button1_Click_4(object sender, EventArgs e)
        {

        }

       
    

        private void hepsiSil_Click(object sender, EventArgs e)
        {

            setToZero();
            checkedListBox1.Items.Clear();
        }

        private void Mutfak_Click(object sender, EventArgs e)
        {
            
            mutfakform.Show();
           
           
       

            
          
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_5(object sender, EventArgs e)
        {
          
        }
    }
}
