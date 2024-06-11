let shorterInArray = (arr) => {
  let shorter = arr[0];
  for (let i = 0; i < arr.length; i++) {
    arr[i].length < shorter.length && (shorter = arr[i]);
  }
  return shorter;
};

//hand made log function inspired by reactjs (hooks)

function log(...args) {
  let result = shorterInArray(...args);
  console.log(result);
}

log(['alex', 'mercer', 'madrasa', 'rashed2', 'emad', 'a']);
