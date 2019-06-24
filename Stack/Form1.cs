using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        private int[] stackTable = new int[5];
        private int back = 0;
        //private int front = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fadeIn.Start();
        }

        ///////////////////////////////////////////////////////////
        ///                        CLOSE                        ///
        ///////////////////////////////////////////////////////////
        private void BunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            fadeOut.Start();
        }

        ////////////////////////////////////////////////////////////
        ///                         PUSH                         ///
        ////////////////////////////////////////////////////////////
        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (!(valueBox.Text.Equals("")))
            {
                if (!isFull())
                {
                    //Do Push
                    try
                    {
                        int value = int.Parse(valueBox.Text);

                        stackTable[back] = value;

                        back++;

                        ReDraw();

                        Alert.showUp("Push " + value + " success.", Alert.AlertType.success);
                    }
                    catch (Exception ex)
                    {
                        Alert.showUp("Please enter number.", Alert.AlertType.error);
                    }
                }
                else
                {
                    //Alert Full
                    Alert.showUp("Stack is Full.", Alert.AlertType.error);
                }
            }
            else
            {
                //Alert Empty
                Alert.showUp("Value Box is Empty.", Alert.AlertType.error);
            }
        }

        ///////////////////////////////////////////////////////////
        ///                         POP                         ///
        ///////////////////////////////////////////////////////////
        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (!isEmpty())
            {
                //Do Pop
                back--;

                int value = stackTable[back];

                ReDraw();

                Alert.showUp("Pop " + value + " success.", Alert.AlertType.success);
            }
            else
            {
                //Alert Empty
                Alert.showUp("Stack is Empty.", Alert.AlertType.error);
            }
        }

        ////////////////////////////////////////////////////////////
        ///                        isFull                        ///
        ////////////////////////////////////////////////////////////
        private bool isFull()
        {
            return back == stackTable.Length;
        }

        ///////////////////////////////////////////////////////////
        ///                       isEmpty                       ///
        ///////////////////////////////////////////////////////////
        private bool isEmpty()
        {
            return back == 0;
        }

        ////////////////////////////////////////////////////////////
        ///                        ReDraw                        ///
        ////////////////////////////////////////////////////////////
        private void ReDraw()
        {
            //Remove Unused box
            int rest = stackTable.Length - back;

            for (int n = back; n < (rest + back); n++)
            {
                switch (n)
                {
                    case 0: val1.Text = "";
                        break;
                    case 1: val2.Text = "";
                        break;
                    case 2: val3.Text = "";
                        break;
                    case 3: val4.Text = "";
                        break;
                    case 4: val5.Text = "";
                        break;
                }
            }

            //Show on Display
            for (int n = 0; n < back; n++)
            {
                switch (n)
                {
                    case 0: val1.Text = stackTable[n].ToString();
                        break;
                    case 1: val2.Text = stackTable[n].ToString();
                        break;
                    case 2: val3.Text = stackTable[n].ToString();
                        break;
                    case 3: val4.Text = stackTable[n].ToString();
                        break;
                    case 4: val5.Text = stackTable[n].ToString();
                        break;
                }
            }
        }

        ////////////////////////////////////////////////////////////
        ///                         Fade                         ///
        ////////////////////////////////////////////////////////////
        private void FadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.1;
            }
            else
            {
                fadeIn.Stop();
            }
        }

        private void FadeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                fadeOut.Stop();

                Application.Exit();
            }
        }
    }
}
