// Вариант 4)	Создать страницу со скриптом, 
// который бы средствами скрипта, по нажатию 
// кнопки выводил abs(x), где x – числовая 
// переменная, которая вводится в форме.

function run() {
    var number = document.getElementById('num').value;

    if (!isNaN(number)){
        parseFloat(number);
        document.getElementById("res").innerHTML = Math.abs(number);
    } else {
        document.getElementById("res").innerHTML = 'Введены неверные данные!';
    }
}

function bindUIActions() {
    window.addEventListener('keydown', function (k) {
        console.log(k.code);
        if(k.code === 'Enter') { 
            run();
        }
    });
}

window.onload = function () {
    console.log('hello');
    bindUIActions();
}