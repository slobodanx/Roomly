using Roomly.Data;

namespace Roomly.UI
{
    public partial class ucAdminDashboard : UserControl
    {
        public ucAdminDashboard()
        {
            InitializeComponent();
            cmbStatus.SelectedIndex = 1;
            LoadData();
        }

        private void LoadData()
        {
            using (var db = new AppDbContext())
            {
                // 1. Start the query
                var query = db.Users.AsQueryable();

                // 2. Apply Filters
                if (cmbStatus.SelectedItem?.ToString() == "Active")
                    query = query.Where(u => u.IsActive);
                else if (cmbStatus.SelectedItem?.ToString() == "Inactive")
                    query = query.Where(u => !u.IsActive);

                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                    query = query.Where(u => u.Username.Contains(txtSearch.Text));

                // 3. Project into an anonymous type for the DataGridView
                // This flattens the User and Role data for clean display
                var userList = query.Select(u => new
                {
                    u.Id,
                    u.Username,
                    CreatedAt = u.CreatedAt.ToString("dd.MM.yyyy"),
                    u.RoleId,
                    RoleName = u.Role != null ? u.Role.Name : "N/A",
                    u.IsActive
                }).ToList();

                // 4. Bind the projection to the grid
                dgvUsers.DataSource = userList;

                dgvUsers.Columns["Id"]!.HeaderText = "User ID";
                dgvUsers.Columns["CreatedAt"]!.HeaderText = "Created at";
                dgvUsers.Columns["RoleId"]!.HeaderText = "Role ID";
                dgvUsers.Columns["RoleName"]!.HeaderText = "Role";
                dgvUsers.Columns["IsActive"]!.HeaderText = "Active Status";
            }
        }

        private void tsmiActivate_Click(object sender, EventArgs e)
        {
            ToggleUserStatus(true);
        }

        private void tsmiDeactivate_Click(object sender, EventArgs e)
        {
            ToggleUserStatus(false);
        }

        private void ToggleUserStatus(bool targetStatus)
        {
            // 1. Guard Clause
            if (dgvUsers.CurrentRow?.DataBoundItem == null)
            {
                MessageBox.Show("Please select a user from the list first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Access the data using dynamic (no 'is' pattern matching needed)
            dynamic selectedUser = dgvUsers.CurrentRow.DataBoundItem;

            // 3. Validation
            if (selectedUser.IsActive == targetStatus)
            {
                string state = targetStatus ? "active" : "inactive";
                MessageBox.Show($"User {selectedUser.Username} is already {state}.",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 4. Confirmation and Update
            string action = targetStatus ? "activated" : "deactivated";
            var confirm = MessageBox.Show($"Are you sure you want {selectedUser.Username} to be {action}?",
                                          "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (var db = new AppDbContext())
                {
                    // Use the Id from your anonymous type to find the real entity
                    var user = db.Users.Find(selectedUser.Id);
                    if (user != null)
                    {
                        user.IsActive = targetStatus;
                        db.SaveChanges();
                        LoadData(); // Refresh the grid
                    }
                }
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvUsers.Rows[e.RowIndex].Selected = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
