﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitOfWorkExample.UnitOfWork;

namespace AnalitikaAnketa.Forms
{
    public partial class GroupOfTags : Form
    {
        DatabaseContext context = new DatabaseContext();
        public GroupOfTags()
        {
            InitializeComponent();
        }

        private void GroupOfTags_Load(object sender, EventArgs e)
        {
            SetDataGrid();
        }
        private void SetDataGrid()
        {
            context.Groups.Load();
            dataGridView1.DataSource = context.Groups.Local.ToBindingList();
            dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = context.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Izmene su uspesno sacuvane");
            }
        }
    }
}