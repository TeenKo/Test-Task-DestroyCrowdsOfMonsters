# Test-Task-DestroyCrowdsOfMonsters
Test Task
Тестовое задание:
Необходимо сделать прототип игры про персонажа, уничтожающий толпы
монстров.
Персонаж:
1) На сцене располагается треугольный персонаж (либо любая модель /
спрайт по своему усмотрению).
2) Поворот осуществляется мышкой, бег на WASD, есть прицел.
Стрельба левой кнопкой мыши.
Монстры:
1) Монстры должны быть нескольких видов (с разным внешним видом,
количеством здоровья, урона, защиты и скоростью передвижения).
Желательно сделать хотя бы 2 вида монстров.
2) Монстры должны рождаться рандомно за сценой и направляться к
персонажу
3) На сцене единовременно должно располагаться не более 100
монстров, при смерти одного должен рождаться следующий
4) При попадании пули в монстра его здоровье должно уменьшаться
соответственно урону от пули и защите монстра
5) При коллизии с персонажем, его здоровье должно уменьшаться
соответственно защите персонажа и урона от монстра
● Расчет урона: здоровье = здоровье - урон * защита(0...1).
● На графическую составляющую не стоит тратить много
времени, она не влияет на оценку решения. Можно
использовать готовые ассеты или простые фигуры.
● В UI необходимо сделать индикатор здоровья персонажа,
счетчик убитых врагов и экран проигрыша с кнопкой рестарта.
Остальное по своему усмотрению.
● В коде необходимо использовать любую ECS систему (Entitas,
LeoECS, DOTS и т.д.).
В процессе выполнения тестового задания не забывайте о
расширяемости и сложности поддержки. А также о
производительности полученного решения. Итоговый результат
должен обладать свойствами продакшн кода, насколько это возможно
в условиях лимитированного времени.
Если не получилось устранить все проблемы из-за нехватки
времени, опишите, как от них избавиться, если бы это был продакшн код.
