function OnButtonClick() {
    var first = jsConsole.readInteger("#first");

    var result = Reverse(first);

    jsConsole.writeLine(result);
}
function Reverse(number) {
    var num = number.toString();
    var text="";
    if (number < 0) {
        for (counter = 1; counter < num.length; counter++) {
            text = num.substring(counter, counter + 1) + text;
        }
        text = '-' + text;
    }
    else {
        for (counter = 0; counter < num.length; counter++) {
            text = num.substring(counter, counter + 1) + text;
        }
    }
    return text;
}

