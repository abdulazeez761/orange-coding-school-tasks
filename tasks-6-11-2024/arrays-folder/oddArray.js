let oddArray = (arr) => {
  let oddCouter = 0,
    evenConter = 0;
  for (let i = 0; i < arr.length; i++) {
    arr[i] % 2 == 0 ? evenConter++ : oddCouter++;
  }
  return oddCouter > evenConter ? 'odd array' : 'even array';
};

//hand made log function inspired by reactjs (hooks)

function log(...args) {
  let result = oddArray(...args);
  console.log(result);
}

log([2, 5, 100]);
