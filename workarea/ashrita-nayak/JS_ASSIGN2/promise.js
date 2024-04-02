(function () {
  fetch('/JavaScript_Assignment/config/word-config.json')
    .then(response => response.json())
    .then((result) => {
      wordApiConfiguration = result;
      console.log("Word API Configuration:", wordApiConfiguration);
      // Call getRandomWord after wordApiConfiguration is fetched
      getRandomWord(); 
    });

  fetch('/JavaScript_Assignment/config/dictionary-config.json')
    .then(response => response.json())
    .then((result) => {
      dictionaryApiConfiguration = result;
      console.log("Dictionary API Configuration:", dictionaryApiConfiguration);
      // Call getRandomWord after dictionaryApiConfiguration is fetched
      getRandomWord(); 
    });
})();

function getRandomWord() {
  let wordApiURL = getWordApi();
  console.log("Word API URL:", wordApiURL);
  fetch(wordApiURL)
    .then(wordResponse => wordResponse.json())
    .then((wordData) => {
      console.log("Word Data:", wordData);
      updateDOM(wordData.word);
      return fetch(getDictionaryApiUrl() + '/'+wordData.word);
    })
    .then(dictionaryResponse => dictionaryResponse.json())
    .then(dictionaryData => {
      console.log("Dictionary Data:", dictionaryData);
      const dictionaryInfo = dictionaryData[0];
      const meaningsToPrint = dictionaryInfo.meanings.map(item => {
        return {
          partOfSpeech: item.partOfSpeech,
          definitions: item.definitions.map(def => def.definition).join(', ')
        };
      });
      updateDictionaryDetails(dictionaryInfo.word, meaningsToPrint);
    })
   // .catch(error => console.log(error));
}

function updateDOM(word) {
  var para = document.getElementById('word');
  para.innerHTML = word;
}

function updateDictionaryDetails(word, meanings) {
  var detailsContainer = document.getElementById('word-details');
  // Clear previous details
  detailsContainer.innerHTML = '';

  // Iterate through meanings
  meanings.forEach(meaning => {
    var row = document.createElement('tr');

    var wordCell = document.createElement('td');
    wordCell.textContent = word;
    row.appendChild(wordCell);

    var partOfSpeechCell = document.createElement('td');
    partOfSpeechCell.textContent = meaning.partOfSpeech;
    row.appendChild(partOfSpeechCell);

    var definitionsCell = document.createElement('td');
    definitionsCell.textContent = meaning.definitions;
    row.appendChild(definitionsCell);

    detailsContainer.appendChild(row);
  });
}