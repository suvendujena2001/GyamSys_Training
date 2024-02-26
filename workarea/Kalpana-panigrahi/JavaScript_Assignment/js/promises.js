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
      meaning['partOfSpeech'] = item.partOfSpeech;
      meaning['definitions'] = item.definitions;
      meaning['phonetic']=item.phonetic;
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
 meanings.forEach(meaning => {     
  const row = tableBody.insertRow();    
   
   row.innerHTML = ` 
   <td>${word}</td>       
   <td>${meaning.phonetic}</td> 
   <td>${meaning.definitions[0].definition}</td> 
   <td>${meaning.definitions[0].example}</td> `;   
  }); 
}