function OnButtonClick() {
    var url = jsConsole.read("#textURL");
    var urlObject = ParseURL(url);

    jsConsole.writeLine("Protokol :" + urlObject.Protokol);
    jsConsole.writeLine("Server :" +   urlObject.Server);
    jsConsole.writeLine("Resource :" + urlObject.Resource);
}
function ParseURL(text) {
    var protokol = text.substring(0, text.indexOf(":"));
    var server = text.substring(text.indexOf(":") + 3, text.indexOf("/", text.indexOf(":") + 3));
    var resource = text.substr(text.indexOf("/", text.indexOf(":") + 3) + 1);

    return { "Protokol": protokol, "Server": server, "Resource": resource };
}