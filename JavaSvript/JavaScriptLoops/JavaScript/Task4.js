(function onload() {
    getMin(document);
    getMax(document);
    getMin(window);
    getMax(window);
    getMin(navigator);
    getMax(navigator);
    

    function getMin(collection) {
        var smallest = 'z';
        for (var property in collection) {
            if (property<smallest) {
                smallest = property;
            }
        }
        jsConsole.writeLine("The smallest lexicographically property in "+collection+ " is "+smallest);
    }
    function getMax(collection) {
        var biggest = 'a';
        for (var property in collection) {
            if (property > biggest) {
                biggest = property;
            }
        }
        jsConsole.writeLine("The biggest lexicographically property in " + collection + " is " + biggest);
    }

}).call(this);