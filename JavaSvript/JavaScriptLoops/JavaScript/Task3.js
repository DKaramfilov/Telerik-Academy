function OnButtonClick() {
    var first = jsConsole.read("#first");
    var arr = first.split(' ');

    var min = parseInt( arr[0]);
    var max = parseInt( arr[0]);
    

    for (var i = 1; i < arr.length; i++) {
        if (parseInt(arr[i]) > max) {
            max = arr[i];
        }
        if (parseInt(arr[i]) < min) {
            min = arr[i];
        }

    }
    jsConsole.writeLine("Min =" + min);
    jsConsole.writeLine("Max =" + max);

}