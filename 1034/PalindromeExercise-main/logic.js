
function isPalindrome(text) {
    let cleanTextArray = cleanText(text)
    let cleanTextString = cleanTextArray.join('')
    let array = []

    for (let word of cleanTextArray) {
        array.unshift(reverseText(word))
    }

    array = (array.join(''))
    
    if(cleanTextString==array){
        return true
    }
    else{
      return  false
    }
}


function reverseText(str) {
    return str.split('').reverse().join('');
}

function cleanText(text) {
    let textArray = text.toLowerCase().split(' ')
    for (let i = 0; i < textArray.length; i++) {
        for (let j = 0; j < textArray[i].length; j++) {
            const currentLetter = textArray[i][j];
            if (!isLetter(currentLetter)) {
                textArray[i] = textArray[i].replaceAll(currentLetter, '')
            }
        }
    }
     textArray = textArray.filter(elem => elem) 
     return textArray
}

function isLetter(c) {
    return c.toLowerCase() != c.toUpperCase();
}