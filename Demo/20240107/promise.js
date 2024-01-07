function double(value) {
  setTimeout(() => setTimeout(console.log, 1000, value * 2));
}

// 早期回调地狱
function double(value, success, failure) {
  setTimeout(() => {
    try {
      if (typeof value !== 'number') {
        throw 'Must provide number as first argument';
      }
      success(value * 2);
    } catch (error) {
      failure(error);
    }
  }, 1000);
}

const successCallback = value => double(value, console.log, console.log);

double(3, successCallback, console.log);
double('3', successCallback, console.log);
