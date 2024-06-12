let sliderImages = document.querySelectorAll('.slide'),
  arrowLeft = document.querySelector('#arrow-left'),
  arrowRight = document.querySelector('#arrow-right'),
  current = 0;

const reset = () => {
  for (let i = 0; i < sliderImages.length; i++) {
    sliderImages[i].style.display = 'none';
  }
  if (sliderImages[current]) sliderImages[current].style.display = 'block';
  else {
    current = 0;
    sliderImages[current].style.display = 'block';
  }
};
const goToNextImage = () => {
  reset();
  sliderImages[current++].style.display = 'block';
};
const goToPrevImage = () => {
  reset();
  sliderImages[current++].style.display = 'block';
};

document.onload(reset());
