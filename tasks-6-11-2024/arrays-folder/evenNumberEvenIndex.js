let evenNumberEvenIndex = (arr) => {
  let newArr = [],
    currentIndex = 0;

  for (let i = 0; i < arr.length; i++) {
    if (arr[i] % 2 == 0 && i % 2 == 0 && arr[i]) {
      newArr[currentIndex] = arr[i];
      currentIndex++;
    }
  }
  return newArr;
};

//hand made log function inspired by reactjs (hooks)

function log(...args) {
  let result = evenNumberEvenIndex(...args);
  console.log(result);
}

log([5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1]);
