const storeRegistrationData = (event) => {
  event.preventDefault();
  const firstName = document.getElementById('firstName').value;
  const lastName = document.getElementById('lastName').value;
  const email = document.getElementById('email').value;
  const password = document.getElementById('regPassword').value;

  const userData = {
    firstName,
    lastName,
    email,
    password,
  };

  localStorage.setItem('user', JSON.stringify(userData));
  alert('Registration successful!');
};

const authenticateUser = (event) => {
  event.preventDefault();
  const loginEmail = document.getElementById('loginEmail').value;
  const loginPassword = document.getElementById('loginPassword').value;

  const storedUserData = JSON.parse(localStorage.getItem('user'));

  if (
    storedUserData &&
    storedUserData.email === loginEmail &&
    storedUserData.password === loginPassword
  ) {
    alert('Login successful!');
    displayUserData(storedUserData);
  } else {
    alert('Invalid email or password.');
  }
};

const displayUserData = (userData) => {
  const cardContainer = document.getElementById('cardContainer');
  cardContainer.innerHTML = `
    <div class="card">
      <h3>User Data</h3>
      <p><strong>First Name:</strong> ${userData.firstName}</p>
      <p><strong>Last Name:</strong> ${userData.lastName}</p>
      <p><strong>Email:</strong> ${userData.email}</p>
    </div>
  `;
};
