let middel = (arr) => {
  let middelIndex = Math.floor(arr.length / 2);
  return arr[middelIndex];
};

//hand made log function inspired by reactjs (hooks)
function log(...args) {
  let result = middel(...args);
  console.log(result);
}

log([2, 5, 100]);
