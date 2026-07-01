using Roomly.Models;

namespace Roomly.UI
{
    public partial class ucRooms : UserControl
    {
        private BindingSource roomBindingSource = new BindingSource();
        public ucRooms()
        {
            InitializeComponent();
            cmbRoomType.DataSource = Enum.GetValues(typeof(RoomType));
            cmbRoomView.DataSource = Enum.GetValues(typeof(RoomView));

            dgvRooms.DataSource = roomBindingSource;
            LoadRooms();
        }

        private void LoadRooms()
        {
            try
            {
                dgvRooms.AutoGenerateColumns = true; //sort by clicking on column headers
                var rooms = RoomService.GetAllRooms();
                roomBindingSource.DataSource = rooms.OrderBy(r => r.RoomNumber).ToList();

                dgvRooms.Columns["Id"]!.Visible = false;
                dgvRooms.Columns["MaxOccupancy"]!.Visible = false;
                dgvRooms.Columns["PricePerNight"]!.Visible = false;
                dgvRooms.Columns["HasFridge"]!.Visible = false;
                dgvRooms.Columns["IsSmokingAllowed"]!.Visible = false;
                dgvRooms.Columns["AllowsPets"]!.Visible = false;
                dgvRooms.Columns["HasTowels"]!.Visible = false;
                dgvRooms.Columns["HasWifi"]!.Visible = false;
                dgvRooms.Columns["IncludesMeals"]!.Visible = false;
                dgvRooms.Columns["Description"]!.Visible = false;

                dgvRooms.Columns["RoomNumber"]!.HeaderText = "Number";
                dgvRooms.Columns["RoomType"]!.HeaderText = "Type";
                dgvRooms.Columns["View"]!.HeaderText = "View";
                dgvRooms.Columns["IsAvailable"]!.HeaderText = "Availability";
                dgvRooms.Columns["CreatedAt"]!.HeaderText = "Created at";

                dgvRooms.ClearSelection();
            }
            catch (Exception ex)
            {
                throw new Exception("LoadRooms", ex);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filter = txtSearch.Text.ToLower();

                if (string.IsNullOrWhiteSpace(filter))
                {
                    roomBindingSource.DataSource = RoomService.GetAllRooms();
                }
                else
                {
                    var filteredList = RoomService.GetAllRooms()
                        .Where(r => r.RoomNumber.ToLower().Contains(filter))
                        .ToList();
                    roomBindingSource.DataSource = filteredList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("txtSearch_TextChanged", ex);
            }
        }

        private void dgvRooms_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                bool hasSelection = dgvRooms.SelectedRows.Count > 0;
                btnDelete.Enabled = hasSelection;

                if (!hasSelection)
                {
                    btnSave.Text = "Create";
                    return;
                }

                var selectedItem = dgvRooms.SelectedRows[0].DataBoundItem;
                if (selectedItem == null || !(selectedItem is Room))
                {
                    return;
                }

                var room = (Room)selectedItem;

                // Basic Info
                txtRoomNumber.Text = room.RoomNumber;
                cmbRoomType.SelectedItem = room.RoomType;
                cmbRoomView.SelectedItem = room.View;
                numMaxOccupancy.Value = room.MaxOccupancy;

                // Pricing & Status
                txtPrice.Text = room.PricePerNight.ToString();
                chkAvailable.Checked = room.IsAvailable;

                // Amenities
                chk_hasFridge.Checked = room.HasFridge;
                chk_smoking.Checked = room.IsSmokingAllowed;
                chk_pets.Checked = room.AllowsPets;
                chk_towels.Checked = room.HasTowels;
                chk_wifi.Checked = room.HasWifi;
                chk_meals.Checked = room.IncludesMeals;

                // Description
                txtDescription.Text = room.Description;

                btnSave.Text = "Update";
            }
            catch (Exception ex)
            {
                throw new Exception("dgvRooms_SelectionChanged", ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm())
                {
                    MessageBox.Show("Please fix the errors in the form.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop the process
                }
                // 1. Create a new object from the UI values
                var room = new Room
                {
                    RoomNumber = txtRoomNumber.Text,
                    RoomType = (RoomType)cmbRoomType.SelectedItem!,
                    View = (RoomView)cmbRoomView.SelectedItem!,
                    MaxOccupancy = (int)numMaxOccupancy.Value,
                    PricePerNight = decimal.Parse(txtPrice.Text),
                    IsAvailable = chkAvailable.Checked,
                    HasFridge = chk_hasFridge.Checked,
                    IsSmokingAllowed = chk_smoking.Checked,
                    AllowsPets = chk_pets.Checked,
                    HasTowels = chk_towels.Checked,
                    HasWifi = chk_wifi.Checked,
                    IncludesMeals = chk_meals.Checked,
                    Description = txtDescription.Text
                };

                if (btnSave.Text == "Update")
                {
                    // Get the ID of the currently selected room
                    var selectedRoom = (Room)dgvRooms.SelectedRows[0].DataBoundItem!;
                    room.Id = selectedRoom.Id;

                    RoomService.UpdateRoom(room);
                    MessageBox.Show("Room updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    RoomService.AddRoom(room);
                    MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Refresh grid and reset form
                LoadRooms();
                ResetForm();
            }
            catch (Exception ex)
            {
                throw new Exception("btnSave_Click", ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRooms.SelectedRows.Count > 0)
                {
                    var selectedRoom = (Room)dgvRooms.SelectedRows[0].DataBoundItem!;

                    var confirm = MessageBox.Show("Are you sure you want to delete this room?",
                        "Confirm Delete", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        RoomService.DeleteRoom(selectedRoom.Id);
                        LoadRooms();
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
                dgvRooms.ClearSelection();
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
            try
            {
                // Clear Text fields
                txtRoomNumber.Clear();
                txtPrice.Clear();
                txtDescription.Clear();

                // Reset ComboBoxes
                cmbRoomType.SelectedIndex = -1;
                cmbRoomView.SelectedIndex = -1;

                // Reset NumericUpDown
                numMaxOccupancy.Value = 1;

                // Reset CheckBoxes
                chkAvailable.Checked = true;
                chk_hasFridge.Checked = false;
                chk_smoking.Checked = false;
                chk_pets.Checked = false;
                chk_towels.Checked = false;
                chk_wifi.Checked = false;
                chk_meals.Checked = false;

                // Reset Buttons and Focus
                btnSave.Text = "Create";
                btnDelete.Enabled = false;
                txtRoomNumber.Focus();
            }
            catch (Exception ex)
            {
                throw new Exception("ResetForm", ex);
            }
        }

        private bool ValidateForm()
        {
            try
            {
                errProvider.Clear();
                bool isValid = true;

                // 1. Room Number (Required)
                if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
                {
                    errProvider.SetError(txtRoomNumber, "Room Number is required.");
                    isValid = false;
                }

                // 1.1 Check for duplicates
                string currentRoomNumber = txtRoomNumber.Text.Trim();

                var allRooms = (List<Room>)roomBindingSource.DataSource!;

                // Logic: Find a room with the same number, but not the one we are currently editing
                bool isDuplicate = allRooms.Any(r =>
                    r.RoomNumber.Equals(currentRoomNumber, StringComparison.OrdinalIgnoreCase) &&
                    (btnSave.Text == "Create" || r.Id != GetSelectedRoomId()));

                if (isDuplicate)
                {
                    errProvider.SetError(txtRoomNumber, "A room with this number already exists.");
                    isValid = false;
                }

                // 2. Room Type (ComboBox)
                if (cmbRoomType.SelectedIndex == -1)
                {
                    errProvider.SetError(cmbRoomType, "Please select a Room Type.");
                    isValid = false;
                }

                // 3. Room View (ComboBox - NEW)
                if (cmbRoomView.SelectedIndex == -1)
                {
                    errProvider.SetError(cmbRoomView, "Please select a Room View.");
                    isValid = false;
                }

                // 4. Price (Required & Numeric)
                if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
                {
                    errProvider.SetError(txtPrice, "Please enter a valid price (must be 0 or greater).");
                    isValid = false;
                }

                return isValid;
            }
            catch (Exception ex)
            {
                throw new Exception("ValidateForm", ex);
            }
        }

        private int GetSelectedRoomId()
        {
            if (dgvRooms.SelectedRows.Count > 0 && dgvRooms.SelectedRows[0].DataBoundItem is Room room)
            {
                return room.Id;
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
