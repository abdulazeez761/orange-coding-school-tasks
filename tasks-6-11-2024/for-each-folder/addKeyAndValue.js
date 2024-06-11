let addKeyAndValue = (arr, key, value) => {
  arr.forEach((element, index) => {
    let newObject = { key };
    newObject.key = value;
    arr[index] = element = { ...element, ...newObject };
  });
  return arr;
};
function log(...args) {
  let result = addKeyAndValue(...args);
  console.log(result);
}

log(
  [{ name: 'Elie' }, { name: 'Tim' }, { name: 'Matt' }, { name: 'Colt' }],
  'title',
  'instructor'
);
