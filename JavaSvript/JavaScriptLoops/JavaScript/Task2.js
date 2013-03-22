function OnButtonClick() {
    var first = jsConsole.readInteger("#first");

    for (var i = 0; i < first; i++) {
        var temp = parseInt(i)
        if(temp % 21 ==0)
            jsConsole.writeLine(i);
    }
}