let nameOnly = (arr) => {
  return arr.map(function (element) {
    const { first, last } = element;
    return `${first} ${last}`;
  });
};

//hand made log function inspired by reactjs (hooks)
function log(...args) {
  let result = nameOnly(...args);
  console.log(result);
}

log([
  { first: 'Elie', last: 'Schoppik' },
  { first: 'Tim', last: 'Garcia' },
  { first: 'Matt', last: 'Lane' },
  { first: 'Colt', last: 'Steele' },
]); // ['Elie Schoppik', 'Tim Garcia', 'Matt Lane', 'Colt Steele']);
