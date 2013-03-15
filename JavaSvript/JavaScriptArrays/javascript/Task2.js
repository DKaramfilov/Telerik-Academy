function OnButtonClick() {
    var first = jsConsole.read("#first");
    var second = jsConsole.read("#second");
    var equal = true;
    
    if (first.length < second.length || first.length > second.length) {
        equal = false;
        
    }
    else {
        for (var i = 0; i < first.length; i++) {
            if (first[i] != second[i]) {
                equal = false;
            }
        }
    }
    
    if (equal == true) {
        jsConsole.writeLine("Arrays are equal");
    }
    else {
        jsConsole.writeLine("Arrays are not equal");
    }
    



}