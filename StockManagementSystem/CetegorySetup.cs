using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.BLL;
using StockManagementSystem.Models;

namespace StockManagementSystem
{
    public partial class CategorySetup : Form
    {
        public CategorySetup()
        {
            InitializeComponent();
        }

        private static string conString = "Server= DESKTOP-B86R21Q; Database= StockManagementSystem; Integrated Security=true";
        SqlConnection con=new SqlConnection(conString);
        CategorySetupManager _categorySetupManager=new CategorySetupManager();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Category category=new Category();
            try
            {
                category.CategoryName = categoryNameTextBox.Text;
                category.UserName = "Admin";
                category.CreateDate = DateTime.Now;
                if (string.IsNullOrEmpty(category.CategoryName))
                {
                    string message = "fill up the field first";
                    emptyFileLebel.Text=message;

                }

                bool isExist = _categorySetupManager.IsExist(category);
                if (isExist)
                {
                    string message = "Already Exist";
                    MessageBox.Show(message);
                }
                else
                {
                    bool isSave = _categorySetupManager.IsSave(category);
                    if (isSave)
                    {
                        string message = "Save Successfully";
                        MessageBox.Show(message);
                        ShowCategory();
                    }

                    else
                    {
                        string message = "Save Failed";
                        MessageBox.Show(message);
                    }
                }
                
            }


            
            catch (Exception exception)
            {
                exception.Message.ToString();
                
            }

          
        }

        private void ShowCategory()
        {
            DataTable dataTable = _categorySetupManager.ShowCategories();
         
            categoryListDataGridView.DataSource = dataTable;
        }

        private void categoryListDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            hiddenLebel.Text = categoryListDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            categoryNameTextBox.Text = categoryListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void CategorySetup_Load(object sender, EventArgs e)
        {
            ShowCategory();
        }

        private void UpdateButton_Click(object sender, EventArgs e)

        {
            Category category= new Category();
            category.CategoryName=categoryNameTextBox.Text;
            category.Id = Convert.ToInt32(hiddenLebel.Text);
            
            
           

            bool isCategoryUpdate = _categorySetupManager.UpdateCategories(category);
            if (isCategoryUpdate)
            {
                MessageBox.Show("Category Update");
                 ShowCategory();
            }


        }
    }
}
