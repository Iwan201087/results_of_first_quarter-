# Описательная часть проекта
Данная работа является итоговой для блока "Выбор специализации" первой четверти обучения. В рамках данной работы будет необходимо:  
1. Создать новый репозиторий на GitHub.  
2. Составить блок схему алгоритма основной задачи.  
3. Добавить в репозиторий файл с описанием README.md  
4. Написать программу для решения основной задачи.  
5. Использовать контроль версии при работе с данным проектом (создать несколько коммитов).  

Описание основной задачи: Написать программу, которая из имеющегося массива строк формирует массив строк, меньше или равна 3 символам. Первоночальный массив вводится с клавиатуры или задается на старте выполнения алгоритма.  

Определимся с основными нюансами работы над данным проектом:  
 - блок схема будет прекреплена в файле README.md  
 - основная программа будет написана на языке С#  
 - первоначальный массив не будет вводится с клавиатуры, а будет задан на старте. Для примера возьмем три массива предложенные преподователями:  
 [“Hello”, “2”, “world”, “:-)”]   

   [“1234”, “1567”, “-2”, “computer science”]   

   [“Russia”, “Denmark”, “Kazan”]     


 Закончив с описательной частью, пристипим к выполнению задания.  

 # Практическая часть
 ## 1. Составим блок схему алгоритма решения основной задачи   


 ![ Блок схема программы ](/image/Algoritm1.jpg)  

 ![Блок схема программы](https://github.com/Iwan201087/results_of_first_quarter-.git/raw/main/image/Algoritm1.jpg)  

## 2. Описание методов, использованных в программе  
При написании программы были использованны три метода ArreayShortWords, PrintArray, PrintTask.  
 - Метод ArreayShortWords находит в веденном массиве элементы с длинной не более трех символов, и выводит этот их в новый массив. Если таких элементов оказалось несколько, то будут все элементы, которые попали под условие цикла.
-  Метод PrintArray служит для печати одномерного массива, а так же проводит проверку на наличие в исходном массиве элементов с количеством не более трех символов, и если все элементы более трех символов, выводит сообщение : "Искомый массив пустой, в исходном массиве все слова длинной более трех символов"
 - Метод PrintTask служит для вывода искомого массива, который он получил от метода ArreayShortWords.
