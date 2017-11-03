using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class PhunWithStrings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // 1.  Reverse the order of the characters of the following string:
            string name = "Bob Tabor";
                      
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverseNameLabel.Text += name[i];
            }


            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            string[] nameArray = names.Split(',');
            string result = "";

            for (int i = nameArray.Length - 1; i >= 0; i--)
            {
                result += nameArray[i] + ", ";
            }
            result = result.Remove(result.Length -2, 1);
            reverseSequenceLabel.Text = result;


            // 3. Use the sequence to create ascii art:

            string rebels = "";
            for (int i = 0; i < nameArray.Length; i++)
            {
                int leftSide = (14 - nameArray[i].Length) / 2;
                string paddingL = nameArray[i].PadLeft(nameArray[i].Length + leftSide, '*');
                rebels += paddingL.PadRight(14, '*') + " <br/>";
            }
            paddedNamesLabel.Text = "<br/>" + rebels;

            // End resuly should display as:
            //*****Luke*****
            //*****Leia*****
            //*****Han******
            //**Chewbacca***
            

            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            string removeMe = "remove-me";
            int cut = puzzle.IndexOf("remove-me");
            puzzle = puzzle.Remove(cut, removeMe.Length);
            puzzle = puzzle.ToLower().Remove(0, 1).Insert(0, "N").Replace("z","t");

            puzzleLabel.Text = puzzle;

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.
        }
    }
}