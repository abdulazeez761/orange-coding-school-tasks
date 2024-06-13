const getFormData = () => {
  const username = document.getElementById('username').value;
  const password = document.getElementById('password').value;

  const genderElements = document.getElementsByName('gender');
  let gender;
  for (const element of genderElements) {
    if (element.checked) {
      gender = element.value;
      break;
    }
  }

  const programmingLanguagesElements = document.getElementsByName(
    'programming-language'
  );
  const programmingLanguages = [];
  for (const element of programmingLanguagesElements) {
    if (element.checked) {
      programmingLanguages.push(element.value);
    }
  }

  return {
    username,
    password,
    gender,
    programmingLanguages,
  };
};

const storFormData = (event) => {
  event.preventDefault();
  const formData = getFormData();
  for (const key in formData) {
    localStorage.setItem(key, JSON.stringify(formData[key]));
  }
  document.getElementById('loginForm').reset();
  showAllFormDataFromLocalStorage();
};

const showAllFormDataFromLocalStorage = () => {
  const username = JSON.parse(localStorage.getItem('username'));
  const password = JSON.parse(localStorage.getItem('password'));
  const gender = JSON.parse(localStorage.getItem('gender'));
  const programmingLanguages = JSON.parse(
    localStorage.getItem('programmingLanguages')
  );

  const cardContainer = document.getElementById('cardContainer');
  cardContainer.innerHTML = `
  <div class="card">
    <h3>User Data</h3>
    <p><strong>Username:</strong> ${username}</p>
    <p><strong>Password:</strong> ${password}</p>
    <p><strong>Gender:</strong> ${gender}</p>
    <p><strong>Programming Languages:</strong> ${programmingLanguages.join(
      ', '
    )}</p>
  </div>
`;
};
