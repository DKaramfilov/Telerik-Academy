function OnButtonClick() {
    var text = "<html><head><title>News</title></head><body><p><a href='http://academy.telerik.com'>TelerikAcademy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";

    //extract title
    var startTitle = text.indexOf("<title>");
    var endTitile = text.indexOf("</title>");
    var title = new String();

    if (startTitle != -1 && endTitile != -1) {
        for (var i = startTitle + 7; i < endTitile; i++) {
            title += text[i];
        }
    }
    jsConsole.writeLine("Title: " + title);

    var finalText = new String();
    var endTag = text.indexOf("<body>");

    for ( i = 0; i < text.length; i++) {
        endTag = text.indexOf('>', endTag + 1);
        i = endTag;
        while (i < text.length - 1 && endTag != 0 && text[i + 1] !== '<') {
            finalText += text[i + 1];
            i++;
        }
        finalText += " ";
    }
    jsConsole.writeLine("Text:" + finalText);
}
