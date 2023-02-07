// Programmer: Maxwell Ahmadi
// Project: Ahmadi_2
// Date: 10/05/2022
// Description: Individual Assignment #2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahmadi_2
{
    public partial class LAIRegistrationForm : Form
    {
        // Declare class-level constants for in-state and out-of-state price to differtiate course costs for registration.
        private const decimal IN_STATE_PRICE = 49.00m;
        private const decimal OUT_OF_STATE_PRICE = 99.00m;

        // Declare class-level variables to ensure the feasibility of check-box buttons for later calculations.
        private decimal pricePerCourse;
        private int coursesPurchased;
        private decimal totalOrderPrice;
        private int YUP = 2;



        public LAIRegistrationForm()
        {
            InitializeComponent();
        }

        // Execute when the form loads (the program starts running up)
        private void LAIRegistrationForm_Load(object sender, EventArgs e)
        {
            // Declare default actions to the form when it first loads
            coursesPurchased = 0;
            totalOrderPrice = 0.00m;
            coursesPurchasedLabel.Text = coursesPurchased.ToString();
            totalOrderPriceLabel.Text = totalOrderPrice.ToString("c");
            fallRadioButton.Checked = true;
            inStateRadioButton.Checked = true;
            masterCardRadioButton.Checked = true;
        }

        private void inStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (inStateRadioButton.Checked)
            {
                pricePerCourse = IN_STATE_PRICE;
                pricePerCourseLabel.Text = pricePerCourse.ToString("c");
            }
        }

        private void outOfStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (outOfStateRadioButton.Checked)
            {
                pricePerCourse = OUT_OF_STATE_PRICE;
                pricePerCourseLabel.Text = pricePerCourse.ToString("c");
            }
        }

        private void frenchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            totalOrderPrice = 0.00m;
            pricePerCourseLabel.Text = pricePerCourse.ToString("c");
            totalOrderPriceLabel.Text = totalOrderPrice.ToString("c");

            // Set coursesPurchased to 0
            coursesPurchased = 0;

            if (frenchCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (germanCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (spanishCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (russianCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (italianCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (coursesPurchased <= 3)
            {
                totalOrderPrice = coursesPurchased * pricePerCourse;
                totalOrderPriceLabel.Text = totalOrderPrice.ToString("c");
                coursesPurchasedLabel.Text = coursesPurchased.ToString();
            }

            else
            {
                MessageBox.Show("Course selections cannot exceed three.");
            }
        }

        private void germanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            totalOrderPrice = 0.00m;
            pricePerCourseLabel.Text = pricePerCourse.ToString("c");
            totalOrderPriceLabel.Text = totalOrderPrice.ToString("c");

            // Set coursesPurchased to 0
            coursesPurchased = 0;

            if (germanCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (frenchCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (spanishCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (russianCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (italianCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (coursesPurchased <= 3)
            {
                totalOrderPrice = coursesPurchased * pricePerCourse;
                totalOrderPriceLabel.Text = totalOrderPrice.ToString("c");
                coursesPurchasedLabel.Text = coursesPurchased.ToString();
            }

            else
            {
                MessageBox.Show("Course selections cannot exceed three.");
            }
        }

        private void spanishCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            totalOrderPrice = 0.00m;
            pricePerCourseLabel.Text = pricePerCourse.ToString("c");
            totalOrderPriceLabel.Text = totalOrderPrice.ToString("c");

            // Set coursesPurchased to 0
            coursesPurchased = 0;

            if (germanCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (frenchCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (spanishCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (russianCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (italianCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (coursesPurchased <= 3)
            {
                totalOrderPrice = coursesPurchased * pricePerCourse;
                totalOrderPriceLabel.Text = totalOrderPrice.ToString("c");
                coursesPurchasedLabel.Text = coursesPurchased.ToString();
            }

            else
            {
                MessageBox.Show("Course selections cannot exceed three.");
            }
        }

        private void russianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            totalOrderPrice = 0.00m;
            pricePerCourseLabel.Text = pricePerCourse.ToString("c");
            totalOrderPriceLabel.Text = totalOrderPrice.ToString("c");

            // Set coursesPurchased to 0
            coursesPurchased = 0;

            if (germanCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (frenchCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (spanishCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (russianCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (italianCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (coursesPurchased <= 3)
            {
                totalOrderPrice = coursesPurchased * pricePerCourse;
                totalOrderPriceLabel.Text = totalOrderPrice.ToString("c");
                coursesPurchasedLabel.Text = coursesPurchased.ToString();
            }

            else
            {
                MessageBox.Show("Course selections cannot exceed three.");
            }
        }

        private void italianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            totalOrderPrice = 0.00m;
            pricePerCourseLabel.Text = pricePerCourse.ToString("c");
            totalOrderPriceLabel.Text = totalOrderPrice.ToString("c");

            // Set coursesPurchased to 0
            coursesPurchased = 0;

            if (germanCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (frenchCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (spanishCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (russianCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (italianCheckBox.Checked)
            {
                coursesPurchased += 1;
            }

            if (coursesPurchased <= 3)
            {
                totalOrderPrice = coursesPurchased * pricePerCourse;
                totalOrderPriceLabel.Text = totalOrderPrice.ToString("c");
                coursesPurchasedLabel.Text = coursesPurchased.ToString();
            }

            else
            {
                MessageBox.Show("Course selections cannot exceed three.");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (coursesPurchased != 0 && coursesPurchased <= 3)
            {
                string registrationTerm = "Fall";
                if (fallRadioButton.Checked)
                {
                    registrationTerm = "Fall";
                }
                else
                {
                    registrationTerm = "Spring";
                }

                string residenceStatus = "In-State";
                if (inStateRadioButton.Checked)
                {
                    residenceStatus = "In-State";
                }
                else
                {
                    residenceStatus = "Out-Of-State";
                }

                string creditCardType = "MasterCard";
                if (masterCardRadioButton.Checked)
                {
                    creditCardType = "MasterCard";
                }
                else
                {
                    creditCardType = "Visa";
                }

                string year = yearComboBox.Text;
                string studentID = studentIDMaskedTextBox.Text;
                string studentFirstName = firstNameTextBox.Text;
                string studentLastName = lastNameTextBox.Text;
                string emailAddress = emailAddressTextBox.Text;
                string totalCoursesPurchased = coursesPurchased.ToString();
                string pricePerCourse = pricePerCourseLabel.Text;
                string totalPrice = totalOrderPrice.ToString();


                // Set string to allow for message box to display all necessary items to confirm the purchase of the courses.
                string cardNumber = cardNumberMaskedTextBox.Text;
                string expirationDate = expirationDateMaskedTextBox.Text;
                // Organize message box to allow it to be clear and insert the necessary icons for display.
                MessageBox.Show("Registration Term: " + registrationTerm + " " + year + "\n" + "Student ID: " + studentID + "\n" + "Student Name: " + studentFirstName + " " + studentLastName
                    + "\n" + "Email Address: " + emailAddress + "\n" + "Residence Status: " + residenceStatus + "\n" + "Total Courses Purchased: " + totalCoursesPurchased + "\n" + "Price Per Course: " + pricePerCourse
                    + "\n" + "Total Order Price: " + totalOrderPrice.ToString() + "\n" + "Credit Card Type: " + creditCardType + "\n" + "Card Number: " + cardNumber + "\n" + "Card Expiration Date: " + expirationDate + "\n", "Order Information:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Number of courses should not exceed three", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    

        // Executes the clear button, reseting all entry values, and returning the form to its original loading position.
        private void clearButton_Click(object sender, EventArgs e)
        {
            fallRadioButton.Checked = true;
            yearComboBox.SelectedIndex = -1;
            studentIDMaskedTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailAddressTextBox.Text = "";
            inStateRadioButton.Checked = true;
            frenchCheckBox.Checked = false;
            germanCheckBox.Checked = false;
            spanishCheckBox.Checked = false;
            russianCheckBox.Checked = false;
            italianCheckBox.Checked = false;
            masterCardRadioButton.Checked = true;
            cardNumberMaskedTextBox.Text = "";
            expirationDateMaskedTextBox.Text = "";
            fallRadioButton.Focus();
        }

        // Executes the exit button, which will prompt the user to ensure they want to make the decision, and then allow them to exit the program (close the form).
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult selection;
            selection = MessageBox.Show("Are you sure you wish to quit the program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (selection == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
