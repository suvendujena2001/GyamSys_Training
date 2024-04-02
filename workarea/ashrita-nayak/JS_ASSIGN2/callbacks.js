function getRandomWord() {
    fetchRandomWord((word, error) => {
      if (error) {
        console.log(error);
      } else {
        updateDOM(word);
        fetchWordMeanings(word, (meanings, error) => {
          if (error) {
            console.log(error);
          } else {
            updateDictionaryDetails(word, meanings);
          }
        });
      }
    });
  }
  
  function fetchRandomWord(callback) {
    const wordApiURL = getWordApi();
    console.log("Word API URL:", wordApiURL);
    fetch(wordApiURL)
      .then(response => response.json())
      .then(data => {
        console.log("Word Data:", data);
        callback(data.word, null);
      })
      .catch(error => {
        callback(null, error);
      });
  }
  
  function fetchWordMeanings(word, callback) {
    const apiUrl = getDictionaryApiUrl() + '/' + word;
    console.log("Dictionary API URL:", apiUrl);
    fetch(apiUrl)
      .then(response => response.json())
      .then(data => {
        console.log("Dictionary Data:", data);
        const dictionaryInfo = data[0];
        const meanings = dictionaryInfo.meanings.map(item => {
          return {
            partOfSpeech: item.partOfSpeech,
            definitions: item.definitions.map(def => def.definition).join(', ')
          };
        });
        callback(meanings, null);
      })
      .catch(error => {
        callback(null, error);
      });
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
  