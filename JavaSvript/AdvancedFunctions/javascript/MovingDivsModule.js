var movingShapes = (function () {
    function CreateDiv(borderRadius) {//set border radius to 0 for rect or "50%" for circle
        var currentDiv = document.createElement('div');
        style = currentDiv.style;
       
        style.width = '50px';
        style.height = '50px';

        style.backgroundColor = MakeRandomColor();
        style.color = MakeRandomColor();

        style.position = "absolute";

        style.borderRadius = borderRadius;
        style.borderColor = MakeRandomColor();
        style.borderWidth = '2px';
        style.borderStyle = 'solid';

        style.textContent = "div";

        return currentDiv;
    }

    function MakeRandomColor() {
        var red = ((Math.random() * 256) | 0);
        var green = ((Math.random() * 256) | 0);
        var blue = ((Math.random() * 256) | 0);
        return "rgb(" + red + "," + green + "," + blue + ")";
    }

    function MoveInRectangle(top, left, width, height) {



    }
    function MoveInCircle(xCenter, yCenter, radius) {

        var container = document.createElement('div');
        var style = container.style;
        var childs = [];

        style.width = radius * 2 + 'px';
        style.height = radius * 2 + 'px';

        style.position = 'absolute';
        style.borderRadius = "50%";

        this.addElement = function (element) {
            container.appendChild(element);
            childs.push(elelement);
            container.setAttribute("data-degees", 0);
            return this;
        }
        this.moveElements = function () {
            var elementsCount = childs.length;

            for (var i = 0; i < elementsCount; i += 1) {
                var currentElement = childs[i];
                var angle = (parseFloat(currentElement.getAttribute('data-degrees')) + 1) % 360;

                currentElement.setAttribute('data-degrees', angle);

                var x = radius * Math.cos(degrees * Math.PI / 180);
                var y = radius * Math.sin(degrees * Math.PI / 180);

                currentElement.style.left = x - parseInt(currentElement.style.width, 10) / 2 + radius + 'px';
                currentElement.style.top = y - parseInt( currentElement.style.height, 10) / 2 + radius + 'px';
            }

            this.render = function () {
                document.body.appendChild(container);
                return this;
            }
        }
    }
    return {
        CreateDiv: CreateDiv,
        Circle: MoveInCircle

    }

})();

var circle = new movingShapes.Circle(200, 200, 100).addElement(movingShapes.CreateDiv()).render()

window.requestAnimFrame = window.requestAnimationFrame ||
   window.webkitRequestAnimationFrame ||
   window.mozRequestAnimationFrame;

(function animloop() {
    window.requestAnimFrame(animloop);
    render();
})();

function render() {
    circle.moveElements();
   // rectangle.moveElements();
}