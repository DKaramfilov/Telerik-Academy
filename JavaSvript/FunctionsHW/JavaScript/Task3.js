var caseSense =false;

function OnButtonClick() {
    var first = jsConsole.read("#first");

    
    var result = Find(first);

    jsConsole.writeLine("The count of word '" + first + "' is: " + result)
}
function Find(word) {
    var text = document.getElementById("text").textContent;
    var countWords = 0;

    if (caseSense === true) {
        var startIndex = text.indexOf(word);

        while (startIndex > 0) {
            countWords++;
            startIndex = text.indexOf(word, startIndex + 1);
        }
    }
    else {
        var tempArr = text.toLowerCase().split(word.toLowerCase());

        countWords = tempArr.length -1;
    }
    return countWords;
}
