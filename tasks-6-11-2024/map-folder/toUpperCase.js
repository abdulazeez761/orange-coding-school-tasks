let arrayToUpperCase = (arr) => {
  return arr.map(function (element) {
    //https://stackoverflow.com/questions/1026069/how-do-i-make-the-first-letter-of-a-string-uppercase-in-javascript thanks to this guy
    return element.charAt(0).toUpperCase() + element.slice(1);
  });
};

//hand made log function inspired by reactjs (hooks)
function log(...args) {
  let result = arrayToUpperCase(...args);
  console.log(result);
}

log(['John', 'Jacob', 'Jingleheimer', 'Schmidt']);
