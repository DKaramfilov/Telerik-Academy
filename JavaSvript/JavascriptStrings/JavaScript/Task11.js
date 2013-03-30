function OnButtonClick() {
    var str = stringFormat("Hello {0}!", "Peter");
    jsConsole.writeLine(str);
    var format = "{0}, {1}, {0} text {2}";
    str = stringFormat(format, 1, "Pesho", "Gosho");
    //str = "1, Pesho, 1 text Gosho"
    jsConsole.writeLine(str);

}
function stringFormat(format) {
    var index = format.indexOf("{");
    var sb = String();
    var start = 0;

    while (index != -1) {
        
        var count = parseInt(format.substr(index + 1, 1));
        sb += format.substring(start, index - 1) +' ';
        sb +=(arguments[count+1]);

        start = index + 3;
        index = format.indexOf("{", index + 1);
    }
    return sb;
}
