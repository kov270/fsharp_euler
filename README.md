## Лабораторная №1 

### Вариант 3, 28

<b>Выполнил:</b> Коваленко Илья Русланович \
<b>Группа:</b> p34102 \
<b>Преподаватель:</b> Пенской Александр Владимирович

### Задача 3
<b>Условие</b> \
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?

### Описание решения 
#### 0) На Python
решение в лоб, ищем наибольший делитель, щагаем по 2 т.к. четные чтоно не простые
```python
d, n = 3, 600851475143
while (d * d < n):
    if n % d == 0: n //= d
    else: d += 2
print(n)

```
#### 1) хвостовая рекурсия
практический полный аналог, но место цикла использветься хвостовая рекурсия
```f#
let rec rec31 (n: uint64) (d: uint64) : uint64 =
    match d * d with
    | n' when n' >= n -> n
    | _ -> 
        match n % d with
        | 0UL -> rec31 (n / d) d
        | _ -> rec31 n (d + uint64 2)

```
#### 2) рекурсия
чтоб оправдать необходимость рекурсии факторизуем число и берём наибольшее
```f#
let rec private f32 (n: uint64) x a =
    match x with
    | n' when n' = n -> x :: a
    | _ -> 
        match n % x with
        | 0UL -> f32 (n / x) x (x :: a)
        | _ -> f32 n (x + uint64 1) a


let factorise (n: uint64) = f32 n (uint64 2) []

```
#### 3) fold
мы через анаморфизм генерируем последовательность где только делители не заменены на 0, потом применяем fold, который делит изнчальное число на все делители пока не останеться один искомый
```f#
let private factors d n =
    Seq.unfold
        (fun (d, n) ->
            match d * d > n with
            | true -> None
            | false -> 
                match n % d with
                | 0UL -> Some(d, (d, n / d))
                | _ -> Some(d, (d + uint64 2, n)))
        (d, n)


let resultFactors d n =
    Seq.fold (fun acc d -> if acc % d = uint64 0 then acc / d else acc) n (factors d n)

let factRes = resultFactors (uint64 3) (uint64 "600851475143")
```

### Задача 28
<b>Условие</b> \
Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:

```
21 22 23 24 25
20  7  8  9 10
19  6  1  2 11
18  5  4  3 12
17 16 15 14 13
```

It can be verified that the sum of the numbers on the diagonals is 101.

What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?

### Описание решения 
#### 0) На Python
решение в лоб, бежим шагаем 4 раза с инкриментом, потом нам это поможет
```python
s = 2
ans = 1
i = 1
while i < 1001*1001:
    for _ in range(4):
        i += s
        ans += i
    s += 2

print(ans)

```
#### 1) Рекурсия хвостовая
понимаем, что в углаз хвадрата степени его разера, и просто суммируем
```f#
let rec tailRec28 i a =
    match i > 1001 with
    | true -> a
    // sum i^2, i^2-i+1, i^2-2i+2, i^2-3i+3
    | _ -> tailRec28 (i + 2) (a + i * i * 4 - 6 * i + 6)

```

#### 2) Map-module + разные способы генерации последовательности
генерируем последовательность для `n*2+1` и сфорачиваем её суммой, последовательности генерируються специфичным для языка способом в `module281` и  черезм map в `module282`
```f#
let module28 lt =
    lt
    |> Seq.sumBy (fun n -> 4 * (n - 2) * (n - 2) + 10 * (n - 1))
    // like Seq.map Seq.fold ( + ) 0 but linter
    |> fun sum -> sum + 1


let module281 =
    module28 [ for a in 1 .. 500 do yield (a * 2+1) ]

let module282 =
    module28 ([ 1 .. 500] |> Seq.map (fun n -> n* 2+1))

```

### Выводы
В ходе написания лабораторной работы были выполены все пунты от А до Б, я не был удивлен F#. Как средство от MS оно оставляло необьяснимое неприятное впечатление. При этом парадигма функционального программирования заставила перенастроиться и работать с новыми категориями, что не может не радовать. Некоторые принципы, которые раньше были принципиальны, на самом деле были непринципиальны. Изящность парадигмы позволяет по новому взглянуть на задачи, и я собираюсь чаще использовать полученные знания в мультипарадигменных языках, где это применимо.
