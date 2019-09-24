using MongoLibrary;
using MongoLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDBChallenge
{
    public partial class Dashboard : Form
    {
        List<PersonModel> people;
        private const string dbName = "ChallengeDB";
        private const string personTable = "People";
        PersonModel currentPerson = new PersonModel();

        public Dashboard()
        {
            InitializeComponent();

            LoadPersonData();
        }

        private void LoadPersonData()
        {
            MongoCRUD db = new MongoCRUD(dbName);
            people = db.LoadRecords<PersonModel>(personTable);

            people.Insert(0, new PersonModel { FirstName = "<add new person>"});

            existingRecordDropDown.DataSource = people;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phoneNumberText.Text))
            {
                MessageBox.Show("Please enter a phone number.");
                return;
            }

            currentPerson.FirstName = firstNameText.Text;
            currentPerson.LastName = lastNameText.Text;
            currentPerson.EmailAddress = emailText.Text;
            currentPerson.PhoneNumber = phoneNumberText.Text;

            MongoCRUD db = new MongoCRUD(dbName);

            if (currentPerson.Id == Guid.Empty)
            {
                var foundPeople = db.FindRecordByNames<PersonModel>(personTable, currentPerson.FirstName, currentPerson.LastName);

                if (foundPeople.Count > 0)
                {
                    foreach (var item in foundPeople)
                    {
                        currentPerson.Id = item.Id;
                        db.UpsertRecord(personTable, item.Id, currentPerson);
                    }
                }
                else
                {
                    db.InsertRecord(personTable, currentPerson);
                }
            }
            else
            {
                db.UpsertRecord(personTable, currentPerson.Id, currentPerson);
            }

            ClearFields();

            currentPerson = new PersonModel();

            LoadPersonData();
        }

        private void existingRecordDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonModel selectedPerson = (PersonModel)existingRecordDropDown.SelectedItem;

            if (string.IsNullOrWhiteSpace(selectedPerson.LastName) == false)
            {
                currentPerson = selectedPerson;

                firstNameText.Text = currentPerson.FirstName;
                lastNameText.Text = currentPerson.LastName;
                emailText.Text = currentPerson.EmailAddress;
                phoneNumberText.Text = currentPerson.PhoneNumber;
            }
            else
            {
                currentPerson = new PersonModel();

                ClearFields();
            }
        }

        private void ClearFields()
        {
            firstNameText.Text = "";
            lastNameText.Text = "";
            emailText.Text = "";
            phoneNumberText.Text = "";
        }
    }
}
