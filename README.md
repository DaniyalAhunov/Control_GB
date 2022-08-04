# Описание итоговой проверочной работы

## _Инструкция_

1. Создать [GitHub](https://github.com/DaniyalAhunov/Control_GB.git) и добавить всю информацию в удаленный репозиторий
2. Нарисовать блок схему которая находиться в файле [файл](Algoritm_control.drawio.png)
3. Снабдить репозиторий оформленным текстом описания решения 
4. Написать саму программу которая находиться в папке [папка](Control_one)
5. Использовать контроль версий не с одним коммитом

## _Задача_ 

Написать программу, которая из имеющегося массива строк формирует массив строк, длинна которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

## _Решение_

Для создания конечного массива где будут находиться исключительно стоки у которых меньше или равны 3 символа нам необхожимо узнать сколько находиться в заданном массиве таких элементов что бы создать массив конечный. После того как мы узнали это количество переходим к его заполнению, для этого проходим опять же по массиву и проверяем длина строки меньше или равна 3м символам или нет если меньше или равна то записываем и увеличиваем индекс конечного массива на 1 если же нет то идем дальше к следующей сктоке имеющегося с начала массива
