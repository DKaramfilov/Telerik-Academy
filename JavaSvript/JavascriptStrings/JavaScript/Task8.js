function OnButtonClick() {
    var text = '<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
    var index = text.indexOf("<a");

    while (index != -1) {
        text = text.replace('<a href="', "[URL=");
        text = text.replace('">', "]");
        text = text.replace("</a>", "[/URL]");
        index = text.indexOf('<a', index + 1);
    }
    
    jsConsole.writeLine(text);
    
}