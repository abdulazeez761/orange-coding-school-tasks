let doubleOfFirst = (arr) => {
  let firstElement = arr[0];

  return arr.map(function (element) {
    return element * this;
  }, firstElement);
};

//hand made log function inspired by reactjs (hooks)
function log(...args) {
  let result = doubleOfFirst(...args);
  console.log(result);
}

log([2, 5, 100]);
