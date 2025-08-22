using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Entering Form1_Load: " + DBHelper.TestConnection());
            try
            {
                DataTable statusTable = DBHelper.ExecuteProcedure("Proc_GetStatuses");
                DataRow emptyRow = statusTable.NewRow();
                emptyRow["id"] = DBNull.Value; 
                emptyRow["name"] = "Не выбрано";
                statusTable.Rows.InsertAt(emptyRow, 0);
                statusCombo.DataSource = statusTable;
                statusCombo.DisplayMember = "name";
                statusCombo.ValueMember = "id";
                statusCombo.SelectedIndex = 0; //default


                statStatusCombo.DataSource = DBHelper.ExecuteProcedure("Proc_GetStatuses");
                statStatusCombo.DisplayMember = "name";
                statStatusCombo.ValueMember = "id";
                statStatusCombo.SelectedIndex = -1;

                DataTable depTable = DBHelper.ExecuteProcedure("Proc_GetDeps");
                emptyRow = depTable.NewRow();
                emptyRow["id"] = DBNull.Value;
                emptyRow["name"] = "Не выбрано";
                depTable.Rows.InsertAt(emptyRow, 0);
                depCombo.DataSource = depTable;
                depCombo.DisplayMember = "name";
                depCombo.ValueMember = "id";
                depCombo.SelectedIndex = 0;

                DataTable postTable = DBHelper.ExecuteProcedure("Proc_GetPosts");
                emptyRow = postTable.NewRow();
                emptyRow["id"] = DBNull.Value;
                emptyRow["name"] = "Не выбрано";
                postTable.Rows.InsertAt(emptyRow, 0);
                postCombo.DataSource = postTable;
                postCombo.DisplayMember = "name";
                postCombo.ValueMember = "id";
                postCombo.SelectedIndex = 0;

                sortFieldCombo.Items.AddRange(new[] { "FIO", "Status", "Dep", "Post", "EmployDate", "UnemployDate" });
                sortFieldCombo.SelectedIndex = 0;
                sortDirCombo.Items.AddRange(new[] { "ASC", "DESC" });
                sortDirCombo.SelectedIndex = 0;

                applyFilterButton_Click(null, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Form1_Load error: {ex.Message}");
            }
        }

        private void applyFilterButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ApplyFilterButton clicked");
            try
            {
                SqlParameter[] parameters = new[]
                {
            new SqlParameter("@statusId", statusCombo.SelectedValue ?? (object)DBNull.Value),
            new SqlParameter("@depId", depCombo.SelectedValue ?? (object)DBNull.Value),
            new SqlParameter("@postId", postCombo.SelectedValue ?? (object)DBNull.Value),
            new SqlParameter("@lastNamePart", string.IsNullOrEmpty(lastNameFilter.Text) ? (object)DBNull.Value : lastNameFilter.Text),
            new SqlParameter("@sortField", sortFieldCombo.SelectedItem?.ToString() ?? "FIO"),
            new SqlParameter("@sortDir", sortDirCombo.SelectedItem?.ToString() ?? "ASC")
        };
                DataTable result = DBHelper.ExecuteProcedure("Proc_GetEmployees", parameters);
                Console.WriteLine($"Proc_GetEmployees returned {result.Rows.Count} rows");
                employeesGrid.DataSource = result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"applyFilterButton error: {ex.Message}");
            }
        }

        private void getStatsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statStatusCombo.SelectedValue == null)
                {
                    MessageBox.Show("Выберите статус");
                    return;
                }
                if (startDate.Value > endDate.Value)
                {
                    MessageBox.Show("Неверно указан промежуток дат");
                    return;
                }
                string mode = rbEmploy.Checked ? "Employ" : "Unemploy";
                SqlParameter[] parameters = new[]
                {
                    new SqlParameter("@statusId", statStatusCombo.SelectedValue),
                    new SqlParameter("@startDate", startDate.Value),
                    new SqlParameter("@endDate", endDate.Value),
                    new SqlParameter("@mode", mode)
                };
                statsGrid.DataSource = DBHelper.ExecuteProcedure("Proc_GetStats", parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"getStatsButton error: {ex.Message}");
            }
        }

        private void lastNameFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tabControl1.SelectedTab == tabControl1.TabPages[0])
            {
                applyFilterButton_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}