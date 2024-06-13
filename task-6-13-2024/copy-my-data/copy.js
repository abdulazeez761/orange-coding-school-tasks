document.addEventListener('DOMContentLoaded', function () {
  // On load, fetch data from localStorage
  loadFromLocalStorage();
});

document.getElementById('loginForm').addEventListener('submit', function (e) {
  e.preventDefault();

  const username = document.getElementById('username').value;
  const password = document.getElementById('password').value;
  const currentData = document.getElementById('current-info');
  const addedData = document.getElementById('added-info');

  updateCurrentData(currentData, username, 'class1');
  updateCurrentData(currentData, password, 'class2');
  addInfoToTable(addedData, username, password);

  document.getElementById('username').value = '';
  document.getElementById('password').value = '';
});

function updateCurrentData(currentData, text, clssName) {
  let span = document.createElement('span');
  span.classList.add(clssName);
  span.innerHTML = text;

  let spanToReplace = document.querySelector(`.${clssName}`);
  if (spanToReplace) {
    currentData.replaceChild(span, spanToReplace);
  } else {
    currentData.appendChild(span);
  }
  addToLocalStorage();
}

function addInfoToTable(addedData, name, password) {
  addedData.innerHTML += `
      <tr>
        <td>${name}</td>
        <td>${password}</td>
      </tr>
    `;
  addToLocalStorage();
}

function getTableData() {
  let currentValues = [];
  let tableData = [];

  document.querySelectorAll('#current-info span').forEach((span) => {
    currentValues.push(span.innerText);
  });

  document.querySelectorAll('#added-info tr').forEach((tr) => {
    let tds = tr.querySelectorAll('td');

    tds.length > 0 && tableData.push([tds[0].innerText, tds[1].innerText]);
  });

  return [currentValues, tableData];
}

function addToLocalStorage() {
  let [currentValues, tableData] = getTableData();
  localStorage.setItem('currentData', JSON.stringify(currentValues));
  localStorage.setItem('tableData', JSON.stringify(tableData));
}

function loadFromLocalStorage() {
  let currentData = JSON.parse(localStorage.getItem('currentData'));
  let tableData = JSON.parse(localStorage.getItem('tableData'));

  const currentInfo = document.getElementById('current-info');
  const addedInfo = document.getElementById('added-info');

  if (currentData) {
    currentData.forEach((data, index) => {
      updateCurrentData(currentInfo, data, `class${index + 1}`);
    });
  }

  if (tableData) {
    tableData.forEach((row) => {
      addInfoToTable(addedInfo, row[0], row[1]);
    });
  }
}
