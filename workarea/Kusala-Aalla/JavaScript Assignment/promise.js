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
    const meaningLength= dictionaryInfo.meanings.length;
    let meaningsToPrint = [];
    let meaning = {};
    dictionaryInfo.meanings.map(item => {
      meaning[item.partOfSpeech] = item.partOfSpeech;
      meaning['definitions'] = item.definitions;
      meaningsToPrint.push(meaning);
    });
    updateDictionaryDetails(dictionaryInfo.word, meaningsToPrint);
  })
  .catch(error => console.log(error));
}

function updateDOM(word) {
  var para = document.getElementById('word');
  para.innerHTML= word;
}


function updateDictionaryDetails(word,meanings) {

  // Write your code here
   let word = document.getElementById("word");
   word.querySelector("#word").innerText='';
   word.querySelector("#meaning").innerText= meanings[0].definitions[0].definition;
   word.querySelector('#partofspeech').innerText = 'Part of Speech: '+partOfSpeech;
   word.querySelector('#definition').innerHTML = 'Definition: '+meanings[0].definitions[0].definition;
   
}
  
