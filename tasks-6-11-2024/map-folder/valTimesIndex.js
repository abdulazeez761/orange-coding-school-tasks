let elementTimesIndex = (arr) => {
  return arr.map(function (element, index) {
    return element * index;
  });
};

//hand made log function inspired by reactjs (hooks)
function log(...args) {
  let result = elementTimesIndex(...args);
  console.log(result);
}

log([1, -2, -3]);
