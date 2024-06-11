let onlyEvenValues = (arr) => {
  let newArr = [];
  let counter = 0;
  arr.forEach((element) => {
    if (element % 2 == 0) {
      newArr[counter] = element;
      counter++;
    }
  });
  return newArr;
};
function log(...args) {
  let result = onlyEvenValues(...args);
  console.log(result);
}

log([5, 1, 2, 3, 10]);
