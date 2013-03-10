function OnCalculate() {
    var N = jsConsole.readInteger("#tb-first");

    hundreds = parseInt( (N / 100)%10);

    if (hundreds === 7) jsConsole.writeLine("Third number is 7");
    else jsConsole.writeLine("Third number is NOT 7");
}