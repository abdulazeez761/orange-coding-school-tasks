let doubleValue = (arr) => {
  return arr.map(function (element) {
    return element * this;
  }, 2);
};

//hand made log function inspired by reactjs (hooks)
function log(...args) {
  let result = doubleValue(...args);
  console.log(result);
}

log([2, -4, -6]);
