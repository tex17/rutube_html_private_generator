# RUTUBE PRIVATE URL TO HTML GENERATOR
![rutube-private-url-to-html-generator-interface-scr](https://github.com/user-attachments/assets/9b3dd44f-a20f-415c-8c2e-32fc50b9974c)

Формирует правильный код, для отображения роликов с доступом по ссылке без ошибок. Костыль для бага, который существует много лет на Rutube.
# How to use
1. В поле "Исходная ссылка" вставляется ссылка на видео.
2. Нажимаем кнопку "Генерировать ссылку".
3. Поля "Код для вставки" и "Код с текстом для вставки" заполнятся html-кодом.
В первом поле генерируется просто валидный html-код, с уже добавленным приватным ключом. Во втором поле генерируется тот же валидный код, но к нему добавлена приписка с прямой ссылкой на видео.
Это мера предосторожности, на случай, если разработчики rutube изменят логику встраиваемого плеера, когда будут исправлять существующую проблему. Вероятность же изменения прямой ссылки на видео стремится к нулю.

**Внимание!** Программа работает только на windows. В поле ввода отсутствует валидация вводимых данных, лишь проверка на пустоту. Попытка генерации кода не из приватной ссылки на rutube-видео, скорее всего приведёт к вылету программы.

