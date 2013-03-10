function OnCalculate() {
    var pointX = jsConsole.readInteger("#width");
    var pointY = jsConsole.readInteger("#height");
    
    var circleRadius = 3;
    var circleCenterY = 1;
    var circleCenterX = 1;
    
    var rectTop= 1;
    var rectBottom= rectTop - 2;
    var rectLeft= -1;
    var rectRight =rectLeft + 6;

    if ((pointY > rectTop || pointY < rectBottom) || (pointX < rectLeft || pointX > rectRight)) {
        jsConsole.writeLine('Point is OUT of the rectangle');
    }
    else {
        jsConsole.writeLine('Point is IN the rectangle');
    }

    if ((circleRadius * circleRadius) >= (Math.pow(pointX - circleCenterX, 2) + (Math.pow(pointY - circleCenterY, 2)))) {
        jsConsole.writeLine('Point is IN circle');
    }
    else jsConsole.writeLine('Point is NOT in circle.');
   
}