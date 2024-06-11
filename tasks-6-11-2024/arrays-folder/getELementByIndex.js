let getELementByIndex = (arr, index) => {
  return arr[index];
};

//hand made log function inspired by reactjs (hooks)
function log(...args) {
  let result = getELementByIndex(...args);
  console.log(result);
}

log([1, 2, 3, 8, 9], 2);
