function OnCalculate() {
    var num = jsConsole.readInteger("#tb-first");

    if (num % 7 === 0 && num % 5  ===0) jsConsole.writeLine("Number is  divisible by 7 and 5");
    else jsConsole.writeLine("Number is NOT divisible by 7 and 5");
}