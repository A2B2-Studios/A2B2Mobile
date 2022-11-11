var GENERIC = "tick1.ogg";
var GENERIC_NOTIFY = "notify3.ogg";
var DENY = "wet1.ogg";

var soundClassMap = new Map([
    ["nav-link", GENERIC],
    ["HREF", GENERIC],
    ["A", GENERIC],
    ["post-display-title", GENERIC],
    ["btn btn-danger", DENY],
    ["btn btn-secondary", DENY]
])

window.ShouldPlaySfx = (CurX, CurY) => {
    var elements = document.elementsFromPoint(CurX, CurY);

    for (let i = 0; i < elements.length; i++) {
        if (soundClassMap.has(elements[i].className)) {
            return soundClassMap.get(elements[i].className);
        }

        if (soundClassMap.has(elements[i].tagName)) {
            return soundClassMap.get(elements[i].tagName)
        }
    }

    return "false";
}
