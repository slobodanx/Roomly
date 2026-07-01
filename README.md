<h1>Roomly: Hotel Reservation and Management System</h1>

<h2>1. Project Description</h2>
<p><strong>Roomly</strong> is a desktop application developed for the <em>Visual Programming</em> course at <strong>FINKI</strong>. It serves as a comprehensive management tool for hotel staff, specifically receptionists, to handle core daily operations.</p>

<h3>Key Functionalities</h3>
<ul>
  <li><strong>Guest Management</strong>: CRUD operations for managing guest profiles, including search functionality by phone, name, or email to ensure fast check-ins.</li>
  <li><strong>Room Inventory</strong>: A centralized system to manage room availability and details.</li>
  <li><strong>Data Validation</strong>: Integrated checks for document identification, birth dates, and room numbers to ensure data integrity and prevent duplicates.</li>
  <li><strong>Authentication</strong>: Secure login system with role-based access.</li>
</ul>

<hr>

<h2>2. Solution & Technical Architecture</h2>
<p>The application follows a <strong>service-oriented architecture</strong>, separating the UI layer from the data access layer to ensure maintainability.</p>
<ul>
  <li><strong>Data Structures</strong>: We use <code>Entity Framework Core</code> with <code>SQLite</code> for data persistence.</li>
  <li><strong>Key Classes</strong>:
    <ul>
      <li><code>Guest</code>: Holds personal info (Name, Phone, Email, Document details).</li>
      <li><code>Room</code>: Manages room status and identification.</li>
      <li><code>GuestService / RoomService</code>: Handle the logic for querying the database, including the search algorithm for filtering guests by phone or name.</li>
    </ul>
  </li>
</ul>

<hr>

<h2>3. Usage Manual</h2>
<ol>
  <li><strong>Login</strong>: Enter your credentials to access the dashboard.</li>
  <li><strong>Dashboard</strong>: Navigate between the "Guests" and "Rooms" tabs using the main menu.</li>
  <li><strong>Guest Search</strong>: Use the search bar in the <code>ucGuests</code> control. The system filters results in real-time as you type, matching your input against <code>Phone</code>, <code>FirstName</code>, or <code>LastName</code>.</li>
  <li><strong>Data Entry</strong>: When adding a new guest, the system validates that the document number is unique for the selected document type to prevent duplicate records.</li>
</ol>

<hr>

<h2>4. Generative AI Usage</h2>
<p>This project utilized generative AI to assist with:</p>
<ul>
  <li><strong>Architecture Planning</strong>: Structuring the service-oriented approach to keep the UI (<code>ucGuests</code>, <code>ucRooms</code>) clean.</li>
  <li><strong>Code Implementation</strong>: Generating efficient <code>LINQ</code> queries for the guest search functionality and implementing <code>ErrorProvider</code> logic for form validation.</li>
</ul>

<hr>
<p><em>Developed by <strong>Slobodan Spasovski, Mario Markovski and Monika Spasovska</strong> for Visual Programming, <strong>FINKI 2026</strong>.</em></p>
