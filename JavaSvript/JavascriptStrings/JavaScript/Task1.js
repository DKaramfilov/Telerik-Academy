function OnButtonClick() {
    var first = jsConsole.read("#first");

    var result = Reverse(first);

    jsConsole.writeLine(result);
}
function Reverse(string) {
    var result = [];
    for (var i = 0; i < string.length; i++) {
        result[i] = string[string.length - i-1];
    }
    return result.join("");
    
}