function OnCalculate() {
    var num = jsConsole.readInteger("#tb-first");
    if (num % 2 === 0) jsConsole.writeLine("Number is even");
    else jsConsole.writeLine("Number is odd");
}