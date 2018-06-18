using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 17-06-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #25 - Alphabet Nested Loops
 * This program spits unicode out into the listbox
*/

namespace AlphabetLoopsTivaR
{
    public partial class frmAlphabetLoops : Form
    {
        public frmAlphabetLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            string firstLetter;
            string secondLetter;

            int counterOutside;
            int counterInside;

            // clear listbox
            this.lstLetters.Items.Clear();

            // Loop through the letters from A to Z
            for (counterOutside = 65; counterOutside <= 90; counterOutside++)
            {
                firstLetter = Char.ConvertFromUtf32(counterOutside);

                for (counterInside = 65; counterInside <= 90; counterInside++)
                {
                    secondLetter = Char.ConvertFromUtf32(counterInside);

                    this.lstLetters.Items.Add(firstLetter + " ->" + secondLetter);
                }
            }
        }
    }
}
