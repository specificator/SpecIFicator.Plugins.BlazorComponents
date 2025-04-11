function getSvgTextDimensionsBeforeRender(textContent) {
    const svg = document.createElementNS("http://www.w3.org/2000/svg", "svg");
    const text = document.createElementNS("http://www.w3.org/2000/svg", "text");
    text.textContent = textContent;
    svg.appendChild(text);
    document.body.appendChild(svg);
    const bbox = text.getBBox();
    document.body.removeChild(svg);
    return { width: bbox.width, height: bbox.height };
}

window.measureSvgTextSync = function (text, fontFamily, fontSize) {
    const svg = `<svg xmlns="http://www.w3.org/2000/svg" style="position:absolute; visibility:hidden;">
                    <text font-family="${fontFamily}" font-size="${fontSize}">${text}</text>
                 </svg>`;
    const el = document.createElement("div");
    el.innerHTML = svg;
    document.body.appendChild(el);
    const textElement = el.querySelector("text");
    const bbox = textElement.getBBox();
    document.body.removeChild(el);
    return { x: bbox.width, y: bbox.height };
};
