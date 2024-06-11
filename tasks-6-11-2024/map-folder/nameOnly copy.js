let nameOnly = (arr, approval, rejection) => {
  return arr.map(function (element) {
    const { name, age } = element;
    let newElement = name + (age >= 20 ? approval : rejection);
    return newElement;
  });
};

//hand made log function inspired by reactjs (hooks)
function log(...args) {
  let result = nameOnly(...args);
  console.log(result);
}

log(
  [
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
  ],
  (canGoTOtheMatrix = ' can go to the matrix lesgo'),
  (canNotGoTOtheMatrix = ' is under age!!')
);
