function removeFromArray(arr, elem) {
  let i = 0;
  while (i < arr.length) {
    if (arr[i] === elem) {
      arr.splice(i, 1);
    } else {
      i++;
    }
  }
  return arr;
}

let nums = [1, 2, 3, 8, 9];
console.log(removeFromArray(nums, 8));
console.log(removeFromArray([4, 5, 6, 7], 5));
console.log(removeFromArray([10, 20, 30, 40], 25));
console.log(removeFromArray([1, 1, 2, 3], 1));
