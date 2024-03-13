let wordApiURL = "";

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
    

    let data  = dictionaryData[0];
    meanings=data.meanings;
    

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
// For Meaning
function getMeaningsStr(meaningsArr) {
 
  return meaningsArr .map((meaning) => {
      let arr = Object.entries(meaning);
      return `
      <p>${arr[0][0]}
      ${arr[0][1]
        .map((val) => {
          return `<p>${val.definition}
  </p>`;
        })
        .join("")}
      </p>
      `;
    })
    .join(" ");// change object to array
}
// For examples
function getExamples(meaningsArr) {
  let arr = [];
  return meaningsArr.map((meaning) => {
      arr = Object.entries(meaning);
      return `<p>${arr[0][0]} 
      ${arr[0][1].map((val) => {
          return `<p>${val.example?val.example:' '}</p>`;
        })
        .join("")}
      </p>`;
    })
    .join(" ");// change object to array
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
              `;// Template Literal -used for code reduce
}