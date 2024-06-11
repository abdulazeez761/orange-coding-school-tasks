let minInArray = (arr) => {
  let min = arr[0];
  for (let i = 0; i < arr.length; i++) {
    arr[i] < min && (min = arr[i]);
  }
  return min;
};

//hand made log function inspired by reactjs (hooks)

function log(...args) {
  let result = minInArray(...args);
  console.log(result);
}

log([1, 2, 3, 8, 0]);
