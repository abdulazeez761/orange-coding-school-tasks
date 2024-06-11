let firstOfArray = (arr) => {
  return arr[0];
};

//hand made log function inspired by reactjs (hooks)
function log(...args) {
  let result = firstOfArray(...args);
  console.log(result);
}

log([2, 5, 100]);
