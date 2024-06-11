let calculatePower = (number, power) => {
  let powerdNumber = 1;
  for (let i = 0; i < power; i++) {
    powerdNumber *= number;
  }
  return powerdNumber;
};

let powerElementIndex = (arr) => {
  for (let i = 0; i < arr.length; i++) {
    arr[i] = calculatePower(arr[i], i);
  }
  return arr;
};

//hand made log function inspired by reactjs (hooks)

function log(...args) {
  let result = powerElementIndex(...args);
  console.log(result);
}

log([44, 5, 4, 3, 2, 10]);
