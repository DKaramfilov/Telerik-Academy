function OnCalculate() {
    var a= jsConsole.readInteger("#a");
    var b= jsConsole.readInteger("#b");
    var h = jsConsole.readInteger("#h");

    jsConsole.writeLine("Trapezoid's area is "+(((a+b)/2)*h));
    
}