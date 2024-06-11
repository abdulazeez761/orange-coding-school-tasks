let vowelCount = (text) => {
  let vowelChars = {};
  let vowels = 'aeiou';

  text = text.toLowerCase().split('');

  text.forEach((element) => {
    if (vowels.includes(element)) {
      vowelChars[element] = vowelChars[element] ? vowelChars[element] + 1 : 1;
    }
  });
  return vowelChars;
};
function log(...args) {
  let result = vowelCount(...args);
  console.log(result);
}

log('Elie');

log('Tim');

log('Matt');

log('hmmm');

log('I Am awesome and so are you');
