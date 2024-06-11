let nameOnly = (arr) => {
  return arr.map(function (element) {
    return element.name;
  });
};

//hand made log function inspired by reactjs (hooks)
function log(...args) {
  let result = nameOnly(...args);
  console.log(result);
}

log([
  {
    name: 'Angelina Jolie',
    age: 80,
  },
  {
    name: 'Eric Jones',
    age: 2,
  },
  {
    name: 'Paris Hilton',
    age: 5,
  },
  {
    name: 'Kayne West',
    age: 16,
  },
  {
    name: 'Bob Ziroll',
    age: 100,
  },
]);
