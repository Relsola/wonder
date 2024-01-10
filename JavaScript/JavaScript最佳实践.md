## 代码规范

#### 使用 const

❌

```JavaScript
var a = 10;
var b = [1, 2, 3];
```

✅

```JavaScript
// 一般情况下确定变量将来会改变则使用 let
// 否则都应该使用 const，等将来变量需要改变再改成 let
const a = 10;
const b = [1, 2, 3];
```

#### 使用花括号

❌

```JavaScript
if (num > 2) num--;

for (let i = 0; i < 3; i++) event[i].emit();
```

✅

```JavaScript
// JavaScript 中 if、for 等语句自动对下一行负责
// 但最佳实践应该是哪怕只有一行也应该使用花括号
if (num > 2) {
  num--;
}

for (let i = 0; i < 3; i++) {
  event[i].emit();
}
```

## 编码技巧

#### 使用赋值运算符

❌

```JavaScript
let a = null; // null
a = a ?? 1; // 1
a = a - 1; // 0
a = a || 1; // 1
a = a & 0; // 0
```

✅

```JavaScript
let a = null; // null
a ??= 1; // 1
a -= 1; // 0
a ||= 1; // 1
a &= 0; // 0
```

#### 解构赋值

❌

```JavaScript
const data = result.data || [];
const code = result.code || 500;
```

✅

```JavaScript
const {data = [], code = 500} = result;

// 也可以用来交换变量
let a = 1, b = 2;
[a, b] = [b, a];
console.log(a === 2 && b === 1); // true
```

#### 使用三目运算符或逻辑运算符代替简单的 if-else

❌

```JavaScript
if (num >= 1) {
  num++;
} else {
  num = 1;
}
```

✅

```JavaScript
num >= 1 ? num++ : (num = 1);

++num < 1 && (num = 1);
```
