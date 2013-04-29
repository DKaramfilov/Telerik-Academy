var tags = [
    "cms", "javascript", "js", "ASP.NET MVC", ".net", ".net",
    "css", "wordpress", "xaml", "js", "http", "web", "asp.net",
    "asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js", "cms",
    "html", "javascript", "http", "http", "CMS"
];
function onLoad() {
    var tagCloud = generateTagCloud(tags, 17, 42);
    document.body.appendChild(tagCloud);
}

function generateTagCloud(tags, minFontSize, maxFontSize) {
    var tagsLength = tags.length;
    var tagsOccurances = {};

    for (var i = 0; i < tagsLength; i++) {
        var currentTag = tags[i].toUpperCase();
        if (!tagsOccurances[currentTag]) {
            tagsOccurances[currentTag] = { count: 1, used: false };
        }
        else {
            tagsOccurances[currentTag].count++;
        }
    }

    var maxCount = Number.MIN_VALUE;
    var minCount = Number.MAX_VALUE;

    for (var j = 0; j < tagsLength; j++) {
        var key = tags[j].toUpperCase();
        if (minCount > tagsOccurances[key].count) {
            minCount = tagsOccurances[key].count;
        }

        if (maxCount < tagsOccurances[key].count) {
            maxCount = tagsOccurances[key].count;
        }
    }
 
    var fontSizesRange = maxFontSize - minFontSize;
    var occurrencesRange = maxCount - minCount;
    var fontSizeIncrement = parseInt(fontSizesRange / occurrencesRange ) ;

    var tagDiv = document.createElement("div");
    tagDiv.style.width = "300px";
    tagDiv.style.border = "1px solid black";

    for (var tag in tagsOccurances) {
        var span = document.createElement("span");
        
        span.style.fontSize = (maxFontSize) -( fontSizeIncrement * (tagsOccurances[tag].count- minCount)) + "px";
        
        span.innerText = tag + " ";
        tagDiv.appendChild(span);
    }
    return tagDiv;
}
