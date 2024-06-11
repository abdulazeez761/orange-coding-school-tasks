let showFirstAndLast = (arr) => {
  arr.forEach((element, index, arr) => {
    let firstChar = element[0],
      lastChar = element[element.length - 1];

    arr[index] = firstChar + lastChar;
  });
  return arr;
};
function log(...args) {
  let result = showFirstAndLast(...args);
  console.log(result);
}

log(['colt', 'matt', 'tim', 'udemy']);
