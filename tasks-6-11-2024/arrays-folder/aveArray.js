let aveArray = (arr) => {
  let sum = 0;
  for (let i = 0; i < arr.length; i++) {
    sum += arr[i];
  }
  return sum / arr.length;
};

//hand made log function inspired by reactjs (hooks)

function log(...args) {
  let result = aveArray(...args);
  console.log(result);
}

log([2, 5, 100]);
