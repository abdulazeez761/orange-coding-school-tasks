let addToEnd = (arr, number) => {
  arr.push(number);
  return arr;
};

//hand made log function inspired by reactjs (hooks)
function log(...args) {
  let result = addToEnd(...args);
  console.log(result);
}

log([1, 2, 3, 8, 9], 2);
