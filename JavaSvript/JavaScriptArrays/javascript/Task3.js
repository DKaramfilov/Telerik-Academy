function OnButtonClick() {
    var first = jsConsole.read("#first");
    var arr = first.split(' ');

    var bestLen = 0;
    var bestStart = 0;
    var index = 0;

    for (var i = 1; i < arr.length; i++) {
        var len = 1;
        index = i - 1;
        while (i < arr.length && arr[i - 1] == arr[i]) {
            len++;
            i++;
        }
        if (bestLen < len) {
            bestLen = len;
            bestStart = index;
        }
    }
    jsConsole.writeLine("Best length =" + bestLen);
    jsConsole.writeLine("Starts at index:" + bestStart);

}