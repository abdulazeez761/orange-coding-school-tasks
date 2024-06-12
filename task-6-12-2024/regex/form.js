function registerUser() {
  let firstName = document.getElementById('firstName').value;
  let lastName = document.getElementById('lastName').value;
  let birthDate = document.getElementById('birthDate').value;
  let email = document.getElementById('email').value;
  let confirmEmail = document.getElementById('confirmEmail').value;
  let password = document.getElementById('regPassword').value;
  let confirmPassword = document.getElementById('confirmPassword').value;
  let mobileNumber = document.getElementById('mobileNumber').value;

  let firstNameError = document.getElementById('firstNameError');
  let lastNameError = document.getElementById('lastNameError');
  let birthDateError = document.getElementById('birthDateError');
  let emailError = document.getElementById('emailError');
  let confirmEmailError = document.getElementById('confirmEmailError');
  let passwordError = document.getElementById('passwordError');
  let confirmPasswordError = document.getElementById('confirmPasswordError');
  let mobileNumberError = document.getElementById('mobileNumberError');

  let nameRegex = /^[a-zA-Z]+$/;
  let emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
  let passwordRegex =
    /^(?=.*[A-Z])(?=.*\d{2,})(?=.*[!@#$%^&*])[A-Za-z\d!@#$%^&*]{8,32}$/;
  let mobileNumberRegex = /^\d{10}$/;

  let isValid = true;

  if (!nameRegex.test(firstName)) {
    firstNameError.classList.remove('hidden');
    isValid = false;
  } else {
    firstNameError.classList.add('hidden');
  }

  if (!nameRegex.test(lastName)) {
    lastNameError.classList.remove('hidden');
    isValid = false;
  } else {
    lastNameError.classList.add('hidden');
  }

  let today = new Date();
  let birthDateObj = new Date(birthDate);
  if (birthDateObj >= today || isNaN(birthDateObj.getTime())) {
    birthDateError.classList.remove('hidden');
    isValid = false;
  } else {
    birthDateError.classList.add('hidden');
  }

  if (!emailRegex.test(email)) {
    emailError.classList.remove('hidden');
    isValid = false;
  } else {
    emailError.classList.add('hidden');
  }

  if (email !== confirmEmail) {
    confirmEmailError.classList.remove('hidden');
    isValid = false;
  } else {
    confirmEmailError.classList.add('hidden');
  }

  if (!passwordRegex.test(password)) {
    passwordError.classList.remove('hidden');
    isValid = false;
  } else {
    passwordError.classList.add('hidden');
  }

  if (password !== confirmPassword) {
    confirmPasswordError.classList.remove('hidden');
    isValid = false;
  } else {
    confirmPasswordError.classList.add('hidden');
  }

  if (!mobileNumberRegex.test(mobileNumber)) {
    mobileNumberError.classList.remove('hidden');
    isValid = false;
  } else {
    mobileNumberError.classList.add('hidden');
  }

  if (isValid) {
    let user = {
      firstName: firstName,
      lastName: lastName,
      birthDate: birthDate,
      email: email,
      password: password,
      mobileNumber: mobileNumber,
    };

    localStorage.setItem(email, JSON.stringify(user));
    alert('User registered successfully');
  }
}

const checkIfUserLoggedIn = () => {
  let storedUser = localStorage.length;
  if (storedUser) return;
  document.getElementById('loginForm').style.display = 'none';
};
document.onload = checkIfUserLoggedIn();

function loginUser() {
  let loginEmail = document.getElementById('loginEmail').value;
  let loginPassword = document.getElementById('loginPassword').value;

  let storedUser = localStorage.getItem(loginEmail);

  if (storedUser) {
    let user = JSON.parse(storedUser);
    if (user.password === loginPassword && user.email === loginEmail) {
      alert('Login successful');
    } else {
      alert('Incorrect password');
    }
  } else {
    alert('No user found with this email');
  }
}
