function OnCalculate() {
    var N = jsConsole.readInteger("#tb-first");
    var bit = N>>3 &1;
    

    if (bit === 1) jsConsole.writeLine("Third bit is one");
    else jsConsole.writeLine("Third bit is zero");
}