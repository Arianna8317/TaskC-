Задание
Создать программу, которая из имеющегося массива строк формирует массив строк,
создержащий только строки длины <= 3.

Решение.
Функция ChooseShirterStrings получает на вход массив строк и необходимую максимальную длину строки для выборки
Сначала исходный массив анализируется на предмет наличия этих строк и их количества.
Далее фоормируется другой массив строк, в который записываются только строки с длиной меньшей или
равной максимальной.
Пустые строки игнорируются.

 Можно было бы и сразу в одном цикле формировать массив из коротких строк, но тогда пришлось бы его создать заранее и смириться с наличием пустых строк. 