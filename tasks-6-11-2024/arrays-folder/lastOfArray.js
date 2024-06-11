let latOfArray = (arr) => {
  return arr[arr.length - 1];
};

//hand made log function inspired by reactjs (hooks)
function log(...args) {
  let result = latOfArray(...args);
  console.log(result);
}

log([2, 5, 100]);
