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
    const dictionaryInfo = dictionaryData[0];
    const meaningLength = dictionaryInfo.meanings.length;
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
  const tableBody = document.getElementById('word-details');
  tableBody.innerHTML='';

  // inserting the values in the table...
  meanings.forEach(meaning => {
    const row = tableBody.insertRow();
    const wordCell = row.insertCell(0);
    const pronunciationCell = row.insertCell(1);
    const meaningCell = row.insertCell(2);
    const exampleCell = row.insertCell(3);


    wordCell.textContent = word;
    pronunciationCell.textContent = meaning.partOfSpeech; 
    meaningCell.textContent = meaning.definitions[0].definition; 
    exampleCell.textContent = meaning.definitions[0].example; 
  })

  
}