using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class FullSummary : Form
    {
        public FullSummary()
        {
            InitializeComponent();
        }
        DataHandler handler = new DataHandler();

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            label1.Text = "Displaying All Data Updated to Update.txt";
            handler.AddSummaryUpdate();
            listView1.Items.Clear(); // Clear existing items if necessary

            foreach (var item in handler.newUpdateList)
            {
                // Create a new ListViewItem with the first column (Student ID)
                ListViewItem listViewItem = new ListViewItem(item.StudentID.ToString());

                // Add subitems for other columns
                listViewItem.SubItems.Add(item.Name1);
                listViewItem.SubItems.Add(item.Age1.ToString());
                listViewItem.SubItems.Add(item.Course);

                // Add the ListViewItem to the ListView
                listView1.Items.Add(listViewItem);
            }

        }

        private void btndiplayInsert_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            label1.Text = "Displaying All Data Added to Insert AddedStudnets.txt";
            handler.AddSummaryInsert();
            // Clear existing items if necessary

            foreach (var item in handler.newAddList)
            {
                // Create a new ListViewItem with the first column (Student ID)
                ListViewItem listViewItem = new ListViewItem(item.StudentID.ToString());

                // Add subitems for other columns
                listViewItem.SubItems.Add(item.Name1);
                listViewItem.SubItems.Add(item.Age1.ToString());
                listViewItem.SubItems.Add(item.Course);

                // Add the ListViewItem to the ListView
                listView1.Items.Add(listViewItem);
            }

        }

        private void btnDiplayDeleted_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            label1.Text = "Displaying All Data Deleted to Delete.txt";
            handler.AddSummaryDelete();
            // Clear existing items if necessary

            foreach (var item in handler.newDeleteList)
            {
                // Create a new ListViewItem with the first column (Student ID)
                ListViewItem listViewItem = new ListViewItem(item.StudentID.ToString());

                // Add subitems for other columns
                listViewItem.SubItems.Add(item.Name1);
                listViewItem.SubItems.Add(item.Age1.ToString());
                listViewItem.SubItems.Add(item.Course);

                // Add the ListViewItem to the ListView
                listView1.Items.Add(listViewItem);
            }
        }

        private void BtnDiplayDatabase_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            label1.Text = "Displaying Remaining Database";
            handler.DisplayNewDatabase();
            // Clear existing items if necessary

            foreach (var item in handler.DatabaseList)
            {
                // Create a new ListViewItem with the first column (Student ID)
                ListViewItem listViewItem = new ListViewItem(item.StudentID.ToString());

                // Add subitems for other columns
                listViewItem.SubItems.Add(item.Name1);
                listViewItem.SubItems.Add(item.Age1.ToString());
                listViewItem.SubItems.Add(item.Course);

                // Add the ListViewItem to the ListView
                listView1.Items.Add(listViewItem);
            }
        }
    }
    }

