function OnButtonClick() {
    var text = jsConsole.read("#text");
    var words = text.split(' ');

    for (var i = 0; i < words.length; i++) {

        if (IsPalindrome(words[i])==true) {
            jsConsole.writeLine(words[i]);
        }
    }
}
function IsPalindrome(word) {
    var sb = new String();
    for (var i = word.length - 1; i >= 0 ; i--) {
        sb += (word[i]);
    }
    return (word == sb);
}