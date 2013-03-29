function OnButtonClick() {
    var url = jsConsole.read("#textURL");
    
    var mailRegex = /(\w+@\w+\.\w+)/;

    var result = mailRegex.exec(url);

    while (result != null) {
        jsConsole.writeLine(result[0]);
        url = url.replace(mailRegex, '');
        result = mailRegex.exec(url);
        
    }
    


}
