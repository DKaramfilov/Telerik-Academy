function OnCalculate() {
    var x = jsConsole.readInteger("#width");
    var y = jsConsole.readInteger("#height");

    var distance = Math.sqrt((x*x)+(y*y));
    if (distance <= 5) {
        jsConsole.writeLine("Point is in the circle");
    }
    else {
        jsConsole.writeLine("Point is OUT of the circle");
    }
}