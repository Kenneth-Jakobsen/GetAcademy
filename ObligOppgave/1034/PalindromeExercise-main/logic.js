
function isPalindrome(text) {
    let cleanedText = cleanText(text)
    let reversedText = reverseText(cleanedText)

    return reversedText==cleanedText
  
    if(reversedText==cleanedText){
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
    let lowerCaseText = text.toLowerCase()
    let newText = ''
        for (let j = 0; j < lowerCaseText.length; j++) {
            const currentLetter = lowerCaseText[j];
            if (isLetter(currentLetter)) {
                newText += currentLetter
            }
        }
     return newText
}

function isLetter(c) {
    return c.toLowerCase() != c.toUpperCase();
}