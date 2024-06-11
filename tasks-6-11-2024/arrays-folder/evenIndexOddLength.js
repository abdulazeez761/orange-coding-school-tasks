let evenIndexOddLength = (arr) => {
  let oddCouter = 0,
    evenConter = 0;
  for (let i = 0; i < arr.length; i++) {
    if (arr[i].length % 2 == 1 && i % 2 == 1 && arr[i]) return arr[i];
  }
};

//hand made log function inspired by reactjs (hooks)

function log(...args) {
  let result = evenIndexOddLength(...args);
  console.log(result);
}

log(['alex', 'mercer', 'madrasa', 'rashed2', 'emad', 'hala']);
