function onmouseenter1(element) {
  document.getElementById('onmouseenter').style.backgroundColor = 'red';
  console.log(element);
}

const displayFlag = () => {
  let flags = {
    Jordan:
      'data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAT4AAACfCAMAAABX0UX9AAAAmVBMVEUAAAAAej3OESb///8AbR/NAB3RDCYAfD3LAAAAfz6tDiDWACStLytCaTnWEidCBQzYV2H12dvZW2T44uTMAAvMABHMABbjjpT88fLqrbH++frYVWDooqc/BQtFBgzVAB/la3TQHzHyzc/VRlHklZvdbnftt7vSMkDhg4rwxcjTO0jppqvaYGnz0NL12tz56OnvvcHffoXlZHJFSJA/AAAEKUlEQVR4nO3cW1faQBSG4XTS0Kk92ZIgKG1FxKJibfv/f1wJGuSQw0z27MSZ/b0XLi/MWvismR2UJNHJ9wi1b/D55Effr8HjlFoDfun7VXibUgAkpBQACSm1BcQMtE+pHUCsQNuUAiAhpQBISKkjQMxA8w75AGjVMR+2sEVlfAA0rpwPgIZV8WEGGlXNhxVoUB0fABur5wNgQ018mIG1NfMBsCYTPmzhysz4AFiRKR8ASzPnwwwsyYYPK/AoOz4AHmTLB8C97PkwA3dqwwfAbe34sIWfa8sHwE3t+bCFIxofAIl84rcwlU84IJ1PNKALPsEz0A2f2BXoik8ooDs+kYAu+QTOQLd84gBd8wnbwu75RAFy8AkC5OETMwO5+ISsQD4+EYCcfAIAefmCn4HcfIED8vMFvYW74NsAhvnMhG741oA/L4dxcHXGp1SiT7/2/eu6rkO+HPBbYICd8oUH2DFfDngREGDnfGHNwB74QgLshS+cGdgTXygrsDe+ME4iPfKFsAJ75fN/BvbM5ztg73x+z0B7voQD0NcZaM03WzH4eQtoyzc6u9IMfL7OQFs+PYzVgMXPyxVozJds9mwyj+PrLP9uwDIDfTuJmPIliwudJiq9ieNHrZJM/1piBprzDe7i8c0q1efrY071fDqMz0YMfL7NQOPNqyfrnz7f/GbDx3izBpnyaQWanzpG53sHnnLs3S2gLzPQnC9b7h53y7b4NvmyAi3euOjdz2lnTO9etvkxAy02b/Lwcth4zrv68nwAND7z6sX+7JtqxuH3XKaXFS/7tWTIN0puD498vEt58cJZfcmi7Ngp5/rzAc+Ub3B3sby/2jl1jB8mZ6s5J15QZ95BMsq0viyOmmidjhK2k2+I7/vyf1YVR7G+6/Nl5eXZ8GXT9QEP+ZfffHx+zLwiG750kq87fc34B69PKy/Piu9PfLN203/jMc97Fn9mXpENnx7eb1Zduorxv76nbPiSxfOezVYzBjyfZl6R1WcdydE37vD8W3l5r+Bjcn/xXgWffyeMl3rn83PmFeEKK1K4vo8Uri4lhWubSeHKelK4r4MU7ioihXvaSOGOSlK4n5cU7iYn1eGzDP7hWQat8T58/PT+bXh18xyXHO/dmwDr4ilCweJ1wBcyHjtf2HjMfKHjsfKFj8fIJwGPjU8GHhOfFDwWPjl4DHyS8JzzycJzzCcNzymfPDyHfBLxnPHJxHPEJxXPCZ9cPAd8kvHIfLLxiHzS8Uh8wCPwAS+vJR/wnmrFB7yiFnzAe8maD3i7WfIBbz8rPuAdZsEHvOOM+YBXlumDSIBXmhEf8Koy4ANedY18wKurgQ949dXyAa+pGj7gNVfJBzyTKviAZ1YpH/BMK+EDnnlHfMCzKQIepQh4lCLgUYqARykCHqUIeJQi4FGKgEcpAh6l/0PGOJFQFSTfAAAAAElFTkSuQmCC',
    Norway:
      'data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADgAAAApCAMAAABX0hoSAAAAOVBMVEW6DC8AIFv///8AAEz6+/y2ABnnvcEAHVoAAErp6e22ABPv0tbamJ63ACCyAADYkpn57/Dy290AAE/++iCFAAAAbklEQVRIie3T2wqAIAyA4W2mZgc7vP/DFkGFE4x2URT7Lgf/hToBEk1LoUb0SNT1cIOGGv4wtIl4hkO0JeBS4xFOrgiI28MLUHHBbGE2Z8BwM658NuYAhV4IxWcU36r4HcWbI97VD/1HDTV8NlwARG0SZTghEcIAAAAASUVORK5CYII=',
  };
  let select = document.getElementById('countrySelect');
  let flagImage = document.getElementById('flagImage');
  let country = select.value;
  if (country === 'none') {
    flagImage.src = '';
    flagImage.alt = 'No country selected';
  } else {
    flagImage.src = flags[country];
    flagImage.alt = country + ' Flag';
  }
};

const validatePassword = () => {
  let password = document.getElementById('password').value;
  let confirmPassword = document.getElementById('confirmPassword').value;
  let passwordError = document.getElementById('passwordError');
  let confirmError = document.getElementById('confirmError');

  if (password.length < 6) {
    passwordError.classList.remove('hidden');
  } else {
    passwordError.classList.add('hidden');
  }

  if (password !== confirmPassword) {
    confirmError.classList.remove('hidden');
  } else {
    confirmError.classList.add('hidden');
  }
};

const hideLorem = (id, buttonId) => {
  let element = document.getElementById(id);
  let button = document.getElementById(buttonId);
  element.classList.toggle('hidden');

  button.innerText = button.innerHTML == 'remove' ? 'show' : 'remove';
};
function formatText() {
  let textArea = document.getElementById('textArea');
  let font = document.getElementById('fontSelect').value;
  let fontSize = document.getElementById('fontSizeSelect').value;
  let isBold = document.getElementById('boldCheck').checked;
  let isItalic = document.getElementById('italicCheck').checked;
  let isUnderline = document.getElementById('underlineCheck').checked;

  textArea.style.fontFamily = font;
  textArea.style.fontSize = fontSize;
  textArea.style.fontWeight = isBold ? 'bold' : 'normal';
  textArea.style.fontStyle = isItalic ? 'italic' : 'normal';
  textArea.style.textDecoration = isUnderline ? 'underline' : 'none';
}
