function onLoad() {

    window.requestAnimationFrame = function () { return window.requestAnimationFrame || window.webkitRequestAnimationFrame || window.mozRequestAnimationFrame || function (a) { window.setTimeout(a, 1E3 / 60) } }();

    var circle = document.querySelector('.circle');

    var angle = 0;

    !function loop() {
        circle.style.left = Math.cos(angle) + 'em';
        circle.style.top = Math.sin(angle) + 'em';

        angle += 0.1
        angle %= (2 * Math.PI)

        window.requestAnimationFrame(loop)
    }()
}