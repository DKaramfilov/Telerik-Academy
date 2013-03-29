function OnButtonClick() {
    var first = jsConsole.read("#first");

     CheckBrackets(first);
   
}
function CheckBrackets(str) {
    var countBrackets = 0;
    for (var i = 0; i < str.length; i++) {
        if (str[i] == '(') countBrackets++;
        if (str[i] == ')') countBrackets--;
        if (countBrackets < 0) {
            jsConsole.writeLine("Incorect Brackets");
           return;
        }
    }
    if (countBrackets == 0) jsConsole.writeLine("Corect Brackets");
    else jsConsole.writeLine("Incorect brackets");
}

