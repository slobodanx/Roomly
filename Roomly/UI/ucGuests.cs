using Roomly.Models;
using Roomly.Services;

namespace Roomly.UI
{
    public partial class ucGuests : UserControl
    {
        private BindingSource guestBindingSource = new BindingSource();

        public ucGuests()
        {
            InitializeComponent();
            dgvGuests.DataSource = guestBindingSource;
            LoadGuests();
        }

        private void LoadGuests()
        {
            try
            {
                var guests = GuestService.GetAllGuests();
                guestBindingSource.DataSource = guests.OrderBy(g => g.FullName).ToList();

                // 1. Hide unwanted columns
                dgvGuests.Columns["Id"]!.Visible = false;
                dgvGuests.Columns["FirstName"]!.Visible = false;
                dgvGuests.Columns["LastName"]!.Visible = false;
                dgvGuests.Columns["DocumentType"]!.Visible = false;
                dgvGuests.Columns["DocumentNumber"]!.Visible = false;
                dgvGuests.Columns["City"]!.Visible = false;
                dgvGuests.Columns["Country"]!.Visible = false;
                dgvGuests.Columns["Note"]!.Visible = false;
                dgvGuests.Columns["Reservations"]!.Visible = false;
                dgvGuests.Columns["BirthDate"]!.Visible = false;
                dgvGuests.Columns["LastUpdated"]!.Visible = false;
                dgvGuests.Columns["ModifiedBy"]!.Visible = false;

                // 2. Format visible columns
                dgvGuests.Columns["FullName"]!.HeaderText = "Name";
                dgvGuests.Columns["Phone"]!.HeaderText = "Phone";
                dgvGuests.Columns["Email"]!.HeaderText = "Email";
                dgvGuests.Columns["CreatedAt"]!.HeaderText = "Created";

                // 3. Set Display Order
                dgvGuests.Columns["FullName"]!.DisplayIndex = 0;
                dgvGuests.Columns["Phone"]!.DisplayIndex = 1;
                dgvGuests.Columns["Email"]!.DisplayIndex = 2;
                dgvGuests.Columns["CreatedAt"]!.DisplayIndex = 3;

                dgvGuests.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading guests: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filter = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(filter))
                {
                    // If the search bar is empty, load all guests
                    guestBindingSource.DataSource = GuestService.GetAllGuests();
                }
                else
                {
                    // Use the centralized search method in GuestService
                    guestBindingSource.DataSource = GuestService.SearchGuests(filter);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching guests: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGuests_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dgvGuests.SelectedRows.Count > 0;
            btnDelete.Enabled = hasSelection;

            if (!hasSelection)
            {
                btnSave.Text = "Create";
                return;
            }

            var selectedItem = dgvGuests.SelectedRows[0].DataBoundItem;
            if (selectedItem == null || !(selectedItem is Guest))
            {
                return;
            }

            var guest = (Guest)selectedItem;

            // Map model to UI
            txtFirstName.Text = guest.FirstName;
            txtLastName.Text = guest.LastName;
            dtpBirthDate.Value = guest.BirthDate ?? DateTime.Now;
            txtCity.Text = guest.City;
            txtCountry.Text = guest.Country;
            txtDocType.Text = guest.DocumentType;
            txtDocNum.Text = guest.DocumentNumber;
            txtPhone.Text = guest.Phone;
            txtEmail.Text = guest.Email;
            txtDescription.Text = guest.Note;

            btnSave.Text = "Update";
            btnDelete.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            var guest = new Guest
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                BirthDate = dtpBirthDate.Value,
                City = txtCity.Text,
                Country = txtCountry.Text,
                DocumentType = txtDocType.Text,
                DocumentNumber = txtDocNum.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Note = txtDescription.Text
            };

            if (btnSave.Text == "Update")
            {
                guest.Id = ((Guest)dgvGuests.SelectedRows[0].DataBoundItem!).Id;
                GuestService.UpdateGuest(guest);
            }
            else
            {
                GuestService.AddGuest(guest);
            }

            LoadGuests();
            ResetForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGuests.SelectedRows.Count > 0)
                {
                    var selectedGuest = (Guest)dgvGuests.SelectedRows[0].DataBoundItem!;

                    var confirm = MessageBox.Show("Are you sure you want to delete this guest?",
                        "Confirm Delete", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        GuestService.DeleteGuest(selectedGuest.Id);
                        LoadGuests();
                        ResetForm();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("btnDelete_Click", ex);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                dgvGuests.ClearSelection();
                ResetForm();
                btnSave.Text = "Create";
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                throw new Exception("btnCancel_Click", ex);
            }
        }

        private void ResetForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtDocType.Clear();
            txtDocNum.Clear();
            txtDescription.Clear();
            dtpBirthDate.Value = DateTime.Now.AddYears(-20);

            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        private bool ValidateForm()
        {
            errProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errProvider.SetError(txtFirstName, "First Name is required");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errProvider.SetError(txtLastName, "Last Name is required");
                isValid = false;
            }
            if (dtpBirthDate.Value.Date > DateTime.Now.Date)
            {
                errProvider.SetError(dtpBirthDate, "Birth date cannot be in the future.");
                isValid = false;
            }
            else if (dtpBirthDate.Value.Year < 1900)
            {
                errProvider.SetError(dtpBirthDate, "Please enter a valid birth date.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errProvider.SetError(txtPhone, "Phone is required");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtDocType.Text))
            {
                errProvider.SetError(txtDocType, "Document type is required");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtDocNum.Text))
            {
                errProvider.SetError(txtDocNum, "Document number is required");
                isValid = false;
            }

            // 1. Check if Document Number exists for this Document Type
            if (!string.IsNullOrWhiteSpace(txtDocNum.Text) && !string.IsNullOrWhiteSpace(txtDocType.Text))
            {
                var currentDocNum = txtDocNum.Text.Trim();
                var currentDocType = txtDocType.Text.Trim();

                // Get all guests to check for duplicates
                var allGuests = GuestService.GetAllGuests();

                bool isDuplicate = allGuests.Any(g =>
                    g.DocumentNumber?.Equals(currentDocNum, StringComparison.OrdinalIgnoreCase) == true &&
                    g.DocumentType?.Equals(currentDocType, StringComparison.OrdinalIgnoreCase) == true &&
                    (btnSave.Text == "Save" || g.Id != GetSelectedGuestId()));

                if (isDuplicate)
                {
                    errProvider.SetError(txtDocNum, "A guest with this document type and number already exists.");
                    isValid = false;
                }
            }

            return isValid;
        }

        private int GetSelectedGuestId()
        {
            if (dgvGuests.SelectedRows.Count > 0 && dgvGuests.SelectedRows[0].DataBoundItem is Guest guest)
            {
                return guest.Id;
            }
            return -1;
        }

        private void ClearError_Event(object sender, EventArgs e)
        {
            try
            {
                // This takes the control that triggered the event and clears its error
                if (sender is Control control)
                {
                    errProvider.SetError(control, "");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ClearError_Event", ex);
            }

        }
    }
}