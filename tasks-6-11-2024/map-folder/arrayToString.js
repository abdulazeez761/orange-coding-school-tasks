let arrayToString = (arr) => {
  return arr.map(function (element) {
    return element.toString();
  });
};

//hand made log function inspired by reactjs (hooks)
function log(...args) {
  let result = arrayToString(...args);
  console.log(result);
}

log([2, 5, 100]);
