using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManjotDogRace
{
    public partial class Form1 : Form
    {

        // varibale to store the budget of the player with updated amount
        int pl1 = 90, pl2 = 70, pl3 = 80;

        // array to store the amount of the bet which is done y the players
        int []amt = { 0,0,0};
         //array to store  the value of the dog which is sued in the race game 
        int []dg= { 0,0,0};


        //object of the all local classes that are used to move the dog from one location to another with using random method 
        dog1 obj1 = new dog1();
        dog2 obj2 = new dog2();
        dog3 obj3 = new dog3();
        dog4 obj4 = new dog4();

        private void button2_Click(object sender, EventArgs e)
        {
            //this is the 2nd button of the game that is used to start the game and on the timer to call the method again and again  like looping 
            timer1.Start();
        }

        //self developed method that is used to reset the whole when the once race is over reset the array local variable picture box and position 
        public void reset() {

             obj1 = new dog1();
             obj2 = new dog2();
             obj3 = new dog3();
            obj4 = new dog4();

            frstDog.Left = 0;
            scndDog.Left = 0;
            thrdDog.Left = 0;
            frthDog.Left = 0;
            amt[0] = 0;
            amt[1] = 0;
            amt[2] = 0;

            dg[0] = 0;
            dg[1] = 0;
            dg[2] = 0;
            button2.Enabled = false;
            Player1.Text = "choose the Player";
            Player2.Text = "choose the Player";
            Player3.Text = "choose the Player";

            lstPlayer.Text = "";
            lstDog.Text = "";
            nmAmount.Value = 1;
        }
        //this is also another self develeoped method that is used to find the winner of the game and also updatet he byget of the player with respectively 
        public void result(int dogId) {

            if (amt[0]>0 && dogId==dg[0]) {
                pl1 = pl1 + amt[0];
                lstPlayer.Items[0] = "Sona has "+ (pl1)+"  Dollar";
                MessageBox.Show("Great Sona you won the Race");
            }else if (amt[0] > 0 && dogId != dg[0])
            {
                pl1 = pl1 + amt[0];
                lstPlayer.Items[0] = "Sona has " + (pl1) + "  Dollar";

            }

            if (amt[1] > 0 && dogId == dg[1])
            {
                pl2 = pl2 + amt[1];
                lstPlayer.Items[1] = "Manjot has " + (pl2) + "  Dollar";
                MessageBox.Show("Great Manjot you won the Race");
            }
            else if (amt[1] > 0 && dogId != dg[1])
            {
                pl2 = pl2 - amt[1];
                lstPlayer.Items[1] = "Manjot has " + (pl2) + "  Dollar";

            }


            if (amt[2] > 0 && dogId == dg[2])
            {
                pl3 = pl3 + amt[2];
                lstPlayer.Items[2] = "Sabhi has " + (pl3) + "  Dollar";
                MessageBox.Show("Great Sabhi you won the Race");
            }
            else if (amt[2] > 0 && dogId != dg[2])
            {
                pl3 = pl3 - amt[2];
                lstPlayer.Items[2] = "Sabhi has " + (pl3) + "  Dollar";

            }


            reset();


        }
        //this is the timer which is start by the 2nd button to move the dog from one position to another 
        //byte using the objet of the other classes object 
        private void timer1_Tick(object sender, EventArgs e)
        {
          if (obj1.winner())
            {
                
                timer1.Stop();
                MessageBox.Show("Dog 1 is the Winner");
                result(1);
            }
            else
            {
                frstDog.Left = obj1.jump(frstDog.Left);
            }

            if (obj2.winner())
            {
                
                timer1.Stop();
                MessageBox.Show("Dog 2 is the Winner");
                result(2);
            }
            else
            {
                scndDog.Left = obj2.jump(scndDog.Left);
            }

            if (obj3.winner())
            {
               // MessageBox.Show("Dog 3 is the Winner");
                timer1.Stop();
                MessageBox.Show("Dog 3 is the Winner");
                result(3);
            }
            else
            {
                thrdDog.Left = obj3.jump(thrdDog.Left);
            }

            if (obj4.winner())
            {
                //MessageBox.Show("Dog 4 is the Winner");
                timer1.Stop();
                MessageBox.Show("Dog 4 is the Winner");
                result(4);
            }
            else {
                frthDog.Left = obj4.jump(frthDog.Left);
            }


            
        }

        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }
        //this is the first buttont hat is sued to setup the game for race like who want to participate  in the bet with how much amount all kind of details are used to store in the arrat with repectivley details 
        private void button1_Click(object sender, EventArgs e)
        {

          //  MessageBox.Show(""+lstPlayer.SelectedIndex);
            if (lstPlayer.SelectedIndex == 0 && nmAmount.Value <= pl1 && lstPlayer.Text!="")
            {
                Player1.Text = "Sona set the Bet at " + lstDog.SelectedItem + " Dollar " + nmAmount.Value;
                button2.Enabled = true;
                amt[0] =Convert.ToInt32(nmAmount.Value);
                dg[0]= Convert.ToInt32(lstDog.SelectedItem.ToString());

            }
            else if (lstPlayer.SelectedIndex == 1 && nmAmount.Value <= pl2 && lstPlayer.Text != "")
            {
                Player2.Text = "Manjot set the Bet at " + lstDog.SelectedItem + " Dollar " + nmAmount.Value;
                button2.Enabled = true;
                amt[1] = Convert.ToInt32(nmAmount.Value);
                dg[1] = Convert.ToInt32(lstDog.SelectedItem.ToString());

            }
            else if (lstPlayer.SelectedIndex == 2 && nmAmount.Value <= pl3 && lstPlayer.Text != "")
            {
                Player3.Text = "Sabhi set the Bet at " + lstDog.SelectedItem + " Dollar " + nmAmount.Value;
                button2.Enabled = true;
                amt[2] = Convert.ToInt32(nmAmount.Value);
                dg[2] = Convert.ToInt32(lstDog.SelectedItem.ToString());

            }
            else {
                MessageBox.Show("You have to select the Any one Player and Dog ");
            }

        }
    }
}
