let repeatCharWhile = (str, char) => {
  let count = 0;
  let i = 0;
  while (i < str.length) {
    if (str[i] === char) {
      count++;
    }
    i++;
  }
  return count;
};

//hand made log function inspired by reactjs (hooks)

function log(...args) {
  let result = repeatCharWhile(...args);
  console.log(result);
}
var string = 'alex mercer madrasa rashed2 emad hala';
log(string, 'a');
