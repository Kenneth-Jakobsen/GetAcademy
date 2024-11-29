let filteredWebColorNames = filterByText(webColorNames, 'a');
let paginatedWebColorNames = skipAndTake(filteredWebColorNames, 2, 10);
showColors(paginatedWebColorNames);


function showColors(colors) {
    let html = '';
    for (let colorName of colors) {
        html += /*HTML*/`
            <li>
                <button style="background-color: ${colorName}">${colorName}</button>
            </li>
        `;
    }
    document.body.innerHTML = html;
}

function sortReversed(values) {
    let newValues = [...values];
    newValues.sort();
    newValues.reverse();
    return newValues;
}

function sortByLength(values) {
    let newValues = [...values];
    newValues.sort(myCompareByLength);
    return newValues;
}

function myCompareByLength(a, b) {
    if (a.length === b.length) return 0;
    return a.length > b.length ? 1 : -1;
}

function skipAndTake(values, pageIndex, pageSize) {
    let newValues = [];
    let skipCount = pageIndex * pageSize;
    let takeCount = pageSize;
    for (let value of values) {
        skipCount--;
        if (skipCount >= 0) continue;
        if (takeCount <= 0) break;
        takeCount--;
        newValues.push(value);
    }
    return newValues;
}

function filterByText(colors, text) {
    let filteredColors = [];
    text = text.toLowerCase();
    for (let colorName of colors) {
        if (colorName.toLowerCase().includes(text)) {
            filteredColors.push(colorName)
        }
    }
    return filteredColors;
}

function findFirstColorNameOfLength(colors, length) {
    for (let colorName of colors) {
        if (colorName.length === length) return colorName;
    }
    return null;
}


function hasColorNameOfLength(colors, length) {
    for (let colorName of colors) {
        if (colorName.length === length) return true;
    }
    return false;
}

function findFirstColorName(colors, criteriaFunction) {
    for (let colorName of colors) {
        if (criteriaFunction(colorName)) return colorName;
    }
    return null;
}
