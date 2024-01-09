## 代码规范

#### 使用花括号

❌

```JavaScript
if (num > 2) num--;

for (let i = 0; i < 3; i++) element[i].emit();
```

✅

```JavaScript
// JavaScript 中 if、for 等语句自动对下一行负责
// 但最佳实践应该是哪怕只有一行也应该使用花括号
if (num > 2) {
  num--;
}

for (let i = 0; i < 3; i++) {
  element[i].emit();
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
const [data = [], code = 500] = result;

// 也可以用来交换变量
let a = 1, b = 2;
[a, b] = [b, a];
console.log(a === 2 && b === 1); // true
```
