let wordApiURL = "";
//async await function
async function getRandomWord() {
  try {
    wordApiURL = getWordApi();
    const response = await fetch(wordApiURL);
    const { word } = await response.json();

    updateDOM(word);
    const dictionaryResponse = await fetch(
      `${getDictionaryApiUrl()}/${word}`
    );
    const dictionaryData = await dictionaryResponse.json();
    console.log(dictionaryData);

    const { meanings, phonetics } = dictionaryData[0];
    console.log(phonetics[0].audio);

    const meaningsArr = meanings.map((meaning) => ({
      [meaning.partOfSpeech]: meaning.definitions,
    }));

    updateDictionaryDetails(word, meaningsArr);
  } catch (error) {
    updateDOM();
    updateDictionaryDetails();
    alert(error);
  }
}

function getMeaningsStr(meaningsArr) {
  let arr = [];
  return meaningsArr
    .map((meaning) => {
      arr = Object.entries(meaning);
      return `
      <p><span class='font-weight-bold'>${arr[0][0]}:</span> 
      ${arr[0][1]
        .map((val) => {
          return `<p>${val.definition}
  </p>`;
        })
        .join("")}
      </p>
      `;
    })
    .join("");
}

function getExamples(meaningsArr) {
  let arr = [];
  return meaningsArr
    .map((meaning) => {
      arr = Object.entries(meaning);
      return `<p><span class='font-weight-bold'>${arr[0][0]}:</span> 
      ${arr[0][1]
        .map((val) => {
          return `<p>${val.example}
  </p>`;
        })
        .join("")}
      `;
    })
    .join("");
}

function updateDOM(word) {
  var para = document.getElementById("word");
  para.innerHTML = word;
}

function updateDictionaryDetails(word, meanings) {
  // Write your code here
  const wordDetails = document.querySelector("#word-details");

  wordDetails.innerHTML = "";
  wordDetails.innerHTML = `
                <td id="word">${word}</td>
                <td id="pronunciation"></td>
                <td id="meaning">${getMeaningsStr(meanings)}</td>
                <td id="example">${getExamples(meanings)}</td>
              `;
}
