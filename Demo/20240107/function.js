// arguments.callee 指向 arguments 所在函数的指针
function sum(num) {
  return num <= 1 ? num : num * arguments.callee(num - 1);
}

// 尾调用优化斐波那契数列
function fib(n) {
  return fibImpl(0, 1, n);
}

function fibImpl(a, b, n) {
  if (n === 0) {
    return a;
  }
  return fibImpl(b, a + b, --n);
}

// 立即执行函数模拟块级作用域
for (var i = 0; i < 5; i++) {
  setTimeout(() => console.log(i));
}

for (var i = 0; i < 5; i++) {
  (i => setTimeout(() => console.log(i)))(i);
}

for (var i = 0; i < 5; i++) {
  setTimeout(i => console.log(i), 0, i);
}
