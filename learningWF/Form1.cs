using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learningWF
{
    public partial class programForm : Form
    {
        Random rnd = new Random();

        public programForm()
        {
            InitializeComponent();
        }

        private void diseThrowBtn_Click(object sender, EventArgs e)
        {
            string textThrow = "";
            int sumThrow = 0;
            int rndCount;

            int[] typeDice = { 4, 6, 8, 10, 12, 20, 100 };
            int[] disesCount = new int[] {(int)d4Count.Value, (int)d6Count.Value, (int)d8Count.Value,
                (int)d10Count.Value, (int)d12Count.Value, (int)d20Count.Value, (int)d100Count.Value};

            for (int i = 0; i < disesCount.Length; i++) 
            {
                if (disesCount[i] > 0)
                {
                    if (textThrow != "") textThrow += "+ ";

                    textThrow += $"({disesCount[i]}D{typeDice[i]}) ";

                    for (int j = 0; j < disesCount[i]; j++)
                    {
                        rndCount = rnd.Next(1, typeDice[i]);
                        sumThrow += rndCount;
                        textThrow += $"{rndCount} {(j == disesCount[i] - 1 ? "" : " + ")}";
                    }

                    //textThrow += $") ";
                }
            }

            textThrow += $"= {sumThrow}";
            
            sumResultText.Text = textThrow;
        }
    }
}
