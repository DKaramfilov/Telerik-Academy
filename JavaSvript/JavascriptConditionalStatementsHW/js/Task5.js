function OnDisplayNameClick() {
    var num = jsConsole.readInteger("#tb-first");
    var numName;

    switch (num) {
        case 1: numName = "one"; break;
        case 2: numName = "two"; break;
        case 3: numName = "three"; break;
        case 4: numName = "four"; break;
        case 5: numName = "five"; break;
        case 6: numName = "six"; break;
        case 7: numName = "seven"; break;
        case 8: numName = "eight"; break;
        case 9: numName = "nine"; break;
        case 0: numName = "zero"; break;

    }
    jsConsole.writeLine(numName);
}