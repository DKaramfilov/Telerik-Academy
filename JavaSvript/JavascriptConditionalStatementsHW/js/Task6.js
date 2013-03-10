function OnCalculate() {
    var a = jsConsole.readInteger("#coeffA");
    var b = jsConsole.readInteger("#coeffB");
    var c = jsConsole.readInteger("#coeffC");

    var discrim = (b * b) - (4 * a * c);
    if (discrim > 0) {
        x1 = (-b - Math.sqrt(discrim)) / (2 * b);
        x2 = (-b + Math.sqrt(discrim)) / (2 * b);
        jsConsole.writeLine("x1 ="+x1 +" x2="+  x2);
    }
    else if (discrim == 0) {
        jsConsole.writeLine("x1=x2=" + (-(b / (2 * a))));
    }
    else {
        jsConsole.writeLine("Quadratic equation does not have real roots");
    }
    
}