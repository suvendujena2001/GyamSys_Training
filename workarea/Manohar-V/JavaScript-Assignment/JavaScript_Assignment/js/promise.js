let wordApiURL = '';

function getRandomWord() {
  wordApiURL = getWordApi();
  fetch(wordApiURL)
  .then(wordResponse => wordResponse.json())
  .then((wordData) => {
    updateDOM(wordData.word)
    
    return fetch(getDictionaryApiUrl()+'/'+wordData.word);
  })
  .then(dictionaryResponse => dictionaryResponse.json())
  .then(dictionaryData => {
    console.log(dictionaryData);
    const dictionaryInfo = dictionaryData[0];
    const meaningLength = dictionaryInfo.meanings.length;
    let meaningsToPrint = [];
    let meaning = {};
    dictionaryInfo.meanings.map(item => {
      meaning[item.partOfSpeech] = item.partOfSpeech;
      meaning['definitions'] = item.definitions;
      meaningsToPrint.push(meaning);
    });
    updateDictionaryDetails(dictionaryInfo, meaningsToPrint);
    
  })
  
  .catch(error => console.log(error));
}

function updateDOM(word) {
  var para = document.getElementById('word');
  para.innerHTML= word;
}


function updateDictionaryDetails(info,meanings) {

  let word_details = document.getElementById("word-details");
  console.log(info);
  console.log(meanings);
  word_details.querySelector("#word").innerText= info.word;
  word_details.querySelector("#pronunciation").innerText= info.phonetic;
  word_details.querySelector("#meaning").innerText= meanings[0].definitions[0].definition;
  word_details.querySelector("#example").innerText= info.word;
  // Write your code here
  
}