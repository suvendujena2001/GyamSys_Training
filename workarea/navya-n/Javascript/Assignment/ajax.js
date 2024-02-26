function getRandomWord() {
    const wordApiURL = getWordApi();
    const xhr = new XMLHttpRequest();
    xhr.open('GET', wordApiURL, true);
    xhr.onload = function() {
      if (xhr.status === 200) {
        const wordData = JSON.parse(xhr.responseText);
        updateDOM(wordData.word);
  
        const dictionaryApiUrl = getDictionaryApiUrl();
        const dictionaryUrl = dictionaryApiUrl + '/' + wordData.word;
        const xhr2 = new XMLHttpRequest();
        xhr2.open('GET', dictionaryUrl, true);
        xhr2.onload = function() {
          if (xhr2.status === 200) {
            const dictionaryData = JSON.parse(xhr2.responseText);
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
          } else {
            console.log('Error: ' + xhr2.status);
          }
        };
        xhr2.onerror = function() {
          console.log('Error: ' + xhr2.status);
        };
        xhr2.send();
      } else {
        console.log('Error: ' + xhr.status);
      }
    };
    xhr.onerror = function() {
      console.log('Error: ' + xhr.status);
    };
    xhr.send();
  }
  
  function updateDOM(word) {
    var para = document.getElementById('word');
    para.innerHTML = word;
  }
  
  function updateDictionaryDetails(word, meanings) {
    const tablebody = document.querySelector('#word-details');
    tablebody.innerHTML='';
  
    // inserting the values in the table...
    meanings.forEach(meanings => {
      const row = tablebody.insertRow();
      const wordCell = row.insertCell(0);
      const pronunciationCell = row.insertCell(1);
      const meaningCell = row.insertCell(2);
      const exampleCell = row.insertCell(3);
  
  
      wordCell.textContent = word;
      pronunciationCell.textContent = meanings.partOfSpeech; 
      meaningCell.textContent = meanings.definitions[0].definition; 
      exampleCell.textContent = meanings.definitions[0].example; 
    })
  }
