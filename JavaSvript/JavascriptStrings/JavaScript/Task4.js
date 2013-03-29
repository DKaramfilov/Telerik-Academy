function OnButtonClick() {
    var textWithTags = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>ANYTHING</lowcase> else.";
    
    jsConsole.writeLine(textWithTags);
    jsConsole.writeLine(UpCase(textWithTags));
    jsConsole.writeLine(LowCase(textWithTags));
    jsConsole.writeLine(MixCase(textWithTags));
}
function UpCase(text) {
    var indexStart = text.indexOf("<upcase>");
    while (indexStart > -1) {
        var insideText = text.substring(indexStart + 8, text.indexOf("</upcase>", indexStart))
        var upperText = insideText.toUpperCase();
        text = text.replace(insideText, upperText);
        indexStart = text.indexOf("<upcase>", indexStart + 1);
    }
    return text;
}
function LowCase(text) {
    var indexStart = text.indexOf("<lowcase>");
    while (indexStart > -1) {
        var insedeText = text.substring(indexStart + 9, text.indexOf("</lowcase>", indexStart));
        var lowerText = insedeText.toLowerCase();
        text = text.replace(insedeText, lowerText);
        indexStart = text.indexOf("<lowcase>", indexStart + 1);
    }
    return text;
}
function MixCase(text) {
    var indexStart = text.indexOf("<mixcase>");
    while (indexStart > -1) {
        var insedeText = text.substring(indexStart + 9, text.indexOf("</mixcase>", indexStart));
        var mixedText = new String(insedeText);
        for (var i = 0; i < mixedText.length ; i++) {
            if (i % 2 == 0) {
                mixedText = mixedText.replace(mixedText[i], mixedText[i].toUpperCase())
            }
            else {
                mixedText = mixedText.replace(mixedText[i], mixedText[i].toLowerCase())
            }
        }
        text = text.replace(insedeText, mixedText);
        indexStart = text.indexOf("<mixcase>", indexStart + 1);
    }
    return text;
}