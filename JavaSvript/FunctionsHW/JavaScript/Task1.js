function OnButtonClick() {
    var first = jsConsole.readInteger("#first");

    var result =LastDigit(first);

    jsConsole.writeLine(result);
}
function LastDigit(number) {
    var digit = number % 10;
    switch (digit) {
        case 1:
            return "one";
        case 2:
            return "two";
        case 3:
            return "tree";
        case 4:
            return "four";
        case 5:
            return "five";
        case 6:
            return "six";
        case 7:
            return "seven";
        case 8:
            return "eight";
        case 9:
            return "nine";
        case 0:
            return "zero";
        default:
            return "Not Valid Number";

    }
    
}