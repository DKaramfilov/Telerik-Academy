function OnButtonClick() {
    var first = jsConsole.read("#first");
    var second = jsConsole.read("#second");

    var shorter;
    if (first.length < second.length) {
        shorter = first;
    }
    else {
        shorter = second;
    }
    for (var i = 0; i < shorter.length; i++) {
        if (first[i] < second[i])
            bigger = true;
    }
    jsConsole.writeLine(f);
    jsConsole.writeLine(s);



}