function OnButtonClick() {
    var first = jsConsole.readInteger("#first");
    
    for (var i = 0; i < first; i++) {
        jsConsole.writeLine(i);
    }
}