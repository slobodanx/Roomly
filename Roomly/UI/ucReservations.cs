using Roomly.Models;
using Roomly.Services;

namespace Roomly.UI
{
    public partial class ucReservations : UserControl
    {
        private BindingSource reservationBindingSource = new BindingSource();
        private Room _selectedRoom;
        private Guest _selectedGuest;
        private int basePrice = 0;
        private int discountValue = 0;

        public ucReservations()
        {
            InitializeComponent();
            cmbStatus.DataSource = Enum.GetValues(typeof(ReservationStatus));
            cmbDiscountType.DataSource = Enum.GetValues(typeof(DiscountType));
            cmbDiscountType.SelectedIndex = 0;
            dgvReservations.DataSource = reservationBindingSource;
            LoadReservations();
            ResetForm();
        }

        private void LoadReservations()
        {
            try
            {
                var reservations = ReservationService.GetAll();
                reservationBindingSource.DataSource = reservations.OrderBy(r => r.CheckInDate).ToList();

                // 1. Hide unwanted columns
                dgvReservations.Columns["Id"]!.Visible = false;
                dgvReservations.Columns["Guest"]!.Visible = false;
                dgvReservations.Columns["Room"]!.Visible = false;
                dgvReservations.Columns["ChildrenCount"]!.Visible = false;
                dgvReservations.Columns["ChildrenAges"]!.Visible = false;
                dgvReservations.Columns["BasePrice"]!.Visible = false;
                dgvReservations.Columns["DiscountValue"]!.Visible = false;
                dgvReservations.Columns["DiscountType"]!.Visible = false;
                dgvReservations.Columns["Note"]!.Visible = false;
                dgvReservations.Columns["FinalPrice"]!.Visible = false;
                dgvReservations.Columns["AdultCount"]!.Visible = false;

                // 2. Format and Set Display Order
                dgvReservations.Columns["GuestId"]!.Visible = false;
                dgvReservations.Columns["RoomId"]!.Visible = false;

                dgvReservations.Columns["FullName"]!.HeaderText = "Guest Name";
                dgvReservations.Columns["CheckInDate"]!.HeaderText = "Check-In";
                dgvReservations.Columns["CheckInDate"]!.DefaultCellStyle.Format = "dd.MM.yyyy";

                dgvReservations.Columns["CheckOutDate"]!.HeaderText = "Check-Out";
                dgvReservations.Columns["CheckOutDate"]!.DefaultCellStyle.Format = "dd.MM.yyyy";

                dgvReservations.Columns["Status"]!.HeaderText = "Status";
                dgvReservations.Columns["CreatedAt"]!.HeaderText = "Created at";
                dgvReservations.Columns["CreatedAt"]!.DefaultCellStyle.Format = "dd.MM.yyyy";

                dgvReservations.Columns["FullName"]!.DisplayIndex = 0;
                dgvReservations.Columns["CheckInDate"]!.DisplayIndex = 1;
                dgvReservations.Columns["CheckOutDate"]!.DisplayIndex = 2;
                dgvReservations.Columns["Status"]!.DisplayIndex = 3;
                dgvReservations.Columns["CreatedAt"]!.DisplayIndex = 4;

                dgvReservations.ClearSelection();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading guests: " + ex.Message);
            }
        }

        private void ResetForm()
        {
            txtGuestName.Clear();
            txtRoomNumber.Clear();
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now;
            numAdults.Value = 1;
            numChildren.Value = 0;
            txtBasePrice.Text = "Base Price: ";
            txtFinalPrice.Text = "Final Price: ";
            numDiscountValue.Value = 0;
            cmbStatus.SelectedIndex = -1;
            cmbDiscountType.SelectedIndex = 0;
            txtDescription.Clear();

            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvReservations.DataSource = ReservationService.Search(txtSearch.Text);
        }

        private void dgvReservations_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dgvReservations.SelectedRows.Count > 0;
            btnDelete.Enabled = hasSelection;

            if (!hasSelection)
            {
                btnSave.Text = "Create";
                return;
            }

            var selectedItem = dgvReservations.SelectedRows[0].DataBoundItem;
            if (selectedItem == null || !(selectedItem is Reservation))
            {
                return;
            }

            var reservation = (Reservation)selectedItem;
            // Map model to UI
            txtGuestName.Text = reservation.Guest?.FullName;
            txtRoomNumber.Text = reservation.Room?.RoomNumber.ToString();
            dtpCheckIn.Value = reservation.CheckInDate;
            dtpCheckOut.Value = reservation.CheckOutDate;
            numAdults.Value = reservation.AdultCount;
            numChildren.Value = reservation.ChildrenCount;
            cmbStatus.SelectedItem = reservation.Status;
            txtBasePrice.Text = reservation.BasePrice.ToString("F2");
            txtFinalPrice.Text = reservation.FinalPrice.ToString("F2");
            cmbDiscountType.SelectedItem = reservation.DiscountType;
            numDiscountValue.Value = reservation.DiscountValue;
            txtDescription.Text = reservation.Note;

            _selectedGuest = reservation.Guest!;
            _selectedRoom = reservation.Room!;

            btnSave.Text = "Update";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;



            var reservation = new Reservation
            {
                GuestId = _selectedGuest.Id,
                Guest = _selectedGuest,
                RoomId = _selectedRoom.Id,
                Room = _selectedRoom,
                CheckInDate = dtpCheckIn.Value,
                CheckOutDate = dtpCheckOut.Value,
                AdultCount = (int)numAdults.Value,
                ChildrenCount = (int)numChildren.Value,
                BasePrice = basePrice,
                Status = (ReservationStatus)cmbStatus.SelectedItem!,
                DiscountType = (DiscountType)cmbDiscountType.SelectedItem!,
                DiscountValue = discountValue,
                Note = txtDescription.Text
            };

            if (btnSave.Text == "Update")
            {
                reservation.Id = ((Reservation)dgvReservations.SelectedRows[0].DataBoundItem!).Id;
                ReservationService.Update(reservation);
            }
            else
            {
                ReservationService.Add(reservation);
            }

            LoadReservations();
            ResetForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservations.SelectedRows.Count > 0)
                {
                    var selected = (Reservation)dgvReservations.SelectedRows[0].DataBoundItem!;
                    var confirm = MessageBox.Show("Are you sure you want to delete this reservation?",
                        "Confirm Delete", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        ReservationService.Delete(selected.Id);
                        LoadReservations();
                        ResetForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting reservation: " + ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReservations.ClearSelection();
                ResetForm();
                btnSave.Text = "Create";
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on button click - New: " + ex.Message);
            }
        }

        private bool ValidateForm()
        {
            errProvider.Clear();
            bool isValid = true;

            // 1. Check if Guest and Room are selected
            if (_selectedGuest == null)
            {
                errProvider.SetError(txtGuestName, "Please select a guest.");
                isValid = false;
            }
            if (_selectedRoom == null)
            {
                errProvider.SetError(txtRoomNumber, "Please select a room.");
                isValid = false;
            }

            // 2. Date Validation
            if (dtpCheckIn.Value.Date < DateTime.Today && btnSave.Text == "Create")
            {
                errProvider.SetError(dtpCheckIn, "Check-in date cannot be in the past.");
                isValid = false;
            }
            if (dtpCheckOut.Value.Date <= dtpCheckIn.Value.Date)
            {
                errProvider.SetError(dtpCheckOut, "Check-out must be after check-in date.");
                isValid = false;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                errProvider.SetError(cmbStatus, "Please select reservation status.");
                isValid = false;
            }

            if (_selectedRoom != null && _selectedRoom.Id == 0 && _selectedRoom.MaxOccupancy > (numAdults.Value + numChildren.Value))
            {
                errProvider.SetError(txtRoomNumber, "Room capacity reached. Please reduce adult count or select another room.");
                isValid = false;
            }

            // 3. Room Availability Check
            if (isValid)
            {
                int currentResId = (btnSave.Text == "Update") ? GetSelectedReservationId() : -1;
                bool isAvailable = ReservationService.IsRoomAvailable(_selectedRoom!.Id, dtpCheckIn.Value, dtpCheckOut.Value, currentResId);

                if (!isAvailable)
                {
                    errProvider.SetError(txtRoomNumber, "This room is already occupied.");
                    isValid = false;
                }
            }

            return isValid;
        }

        private int GetSelectedReservationId()
        {
            // Returns the ID of the row currently selected in the DataGridView
            if (dgvReservations.SelectedRows.Count > 0 && dgvReservations.SelectedRows[0].DataBoundItem is Reservation res)
            {
                return res.Id;
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

        private void btnSelectGuest_Click(object sender, EventArgs e)
        {
            try
            {
                // Pass 'false' to indicate this is a popup/management window
                var guestControl = new ucGuests(isStandalone: false);
                var selector = new frmSelector(guestControl, "Assign Guest");

                if (selector.ShowDialog() == DialogResult.OK)
                {
                    // Update the form state with the chosen object
                    _selectedGuest = guestControl.SelectedGuest;
                    txtGuestName.Text = _selectedGuest.FullName;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("btnSelectGuest_Click", ex);
            }
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            try
            {
                // Pass 'false' to indicate this is a popup/management window
                var roomControl = new ucRooms(isStandalone: false);
                var selector = new frmSelector(roomControl, "Assign Room");

                if (selector.ShowDialog() == DialogResult.OK)
                {
                    // Update the form state with the chosen object
                    _selectedRoom = roomControl.SelectedRoom;
                    txtRoomNumber.Text = _selectedRoom.RoomNumber;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("btnSelectRoom_Click", ex);
            }
        }

        private void CalculatePrice(object sender, EventArgs e)
        {
            try
            {
                if (_selectedRoom != null && dtpCheckIn.Value.Date < dtpCheckOut.Value.Date && cmbDiscountType.SelectedIndex != -1)
                {
                    int nights = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days;
                    basePrice = (int)_selectedRoom.PricePerNight * nights;
                    if ((DiscountType)cmbDiscountType.SelectedItem! == DiscountType.Percentage)
                        discountValue = (int)(basePrice * (numDiscountValue.Value / 100));
                    else if ((DiscountType)cmbDiscountType.SelectedItem! == DiscountType.None)
                    {
                        discountValue = 0;
                        numDiscountValue.Value = 0;
                    }
                    else
                        discountValue = (int)numDiscountValue.Value;

                    txtBasePrice.Text = String.Format("Base Price: {0}", basePrice);
                    txtFinalPrice.Text = String.Format("Final Price: {0}", basePrice - discountValue);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("CalculatePrice", ex);
            }
        }

        private void dgvReservations_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvReservations.ClearSelection();
            ResetForm();
        }
    }

}
