let sumArray = (arr) => {
  let sum = 0;
  for (let i = 0; i < arr.length; i++) {
    sum += arr[i];
  }
  return sum;
};

//hand made log function inspired by reactjs (hooks)

function log(...args) {
  let result = sumArray(...args);
  console.log(result);
}

log([2, 5, 100]);
