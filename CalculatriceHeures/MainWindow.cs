using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatriceHeures
{
    public partial class CalculHeure : Form
    {
        //VARIABLES ET CONSTANTES
        int hours;
        int minutes;
        int hoursTotal;
        int minutesTotal;

        const bool DEBUG_MODE = true;
        ErrorManager error = new ErrorManager("", "", DEBUG_MODE);


        public CalculHeure()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            errorLBL.Text = error.ResetError();
        }

        private void ConfirmBTN_Click(object sender, EventArgs e)
        {
            errorLBL.Text = error.ResetError();
            CalculateResult();
            errorLBL.Text = error.PrintError();
        }

        private void CalculateResult()
        {
            string textToParse;
            int startingHours;
            int startingMinutes;
            int endingHours;
            int endingMinutes;

            textToParse = entryIN.Text;
            if (ValidValue(textToParse))
            {
                startingHours = hours;
                startingMinutes = minutes;

                textToParse = exitIN.Text;
                if(ValidValue(textToParse))
                {
                    endingHours = hours;
                    endingMinutes = minutes;

                    CalculTime(startingHours, startingMinutes, endingHours, endingMinutes);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }

        }

        private void CalculTime(int startH, int startMin, int endH, int endMin)
        {
            if(endMin >= startMin) 
            {
                minutesTotal= endMin - startMin;
                hoursTotal= endH - startH;
            }
            else
            {
                minutesTotal= (endMin + 60) - startMin;
                hoursTotal= (endH - 1) - startH;
            }

            if(hoursTotal < 0 )
            {
                hoursTotal += 24;
            }

            entryIN.Text = "";
            exitIN.Text = "";

            resultLBL.Text = $"{hoursTotal}h{minutesTotal:D2}";
        }

        private bool ValidValue(string time)
        {
            if (entryIN.Text == "" || exitIN.Text == "")
            {
                error.SetError("ValidValue", "Please fill every field!");
                return false;
            }

            if (ParseTime(time))
            {
                return true;
            }

            if(hours < 24 && hours >= 0)
            {
                if(minutes < 59 && minutes >= 0)
                {
                    return true;
                }
                else
                {
                    error.SetError("ValidValue", "Minutes must be between 0 and 59");
                }
            }
            else
            {
                error.SetError("ValidValue", "Hours must be between 0 and 23");
            }

            return false;
        }

        private bool ParseTime(string time)
        {
            Regex timeRegex = new Regex(@"^(\d{1,2})[h:](\d{2})$");
            Match match = timeRegex.Match(time);

            if (match.Success)
            {
                try
                {
                    hours = int.Parse(match.Groups[1].Value);
                }
                catch (Exception)
                {
                    error.SetError("ParseTime", "The value for hours is incorrect!");
                    hours = 0;
                    return false;
                }

                try
                {
                    minutes = int.Parse(match.Groups[2].Value);
                }
                catch (Exception)
                {
                    error.SetError("ParseTime", "The value for minutes is incorrect!");
                    minutes = 0;
                    return false;
                }
                return true;
            }
            else
            {
                error.SetError("ParseTime", "Incorrect time format!\n this is the correct time format (0h00) or (0:00)");
                return false;
            }
        }
    }
}