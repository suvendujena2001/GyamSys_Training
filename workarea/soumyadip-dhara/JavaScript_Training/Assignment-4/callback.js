document.addEventListener('DOMContentLoaded', function() {
    const searchbtn = document.querySelector('.btn');
  
    function getRandomWord(callback) {
      const wordApiURL = getWordApi();
      fetch(wordApiURL)
        .then(response => {
          if (response.status == 404) {
            document.querySelector('wordis').style.display = 'none';
            document.querySelector('.error').innerText = 'Error';
          } else {
            response.json().then(data => {
              var gword = data.word;
              document.querySelector('#word').innerText = gword;
  
              const dictionaryApi = getDictionaryApiUrl() + '/' + gword;
              fetch(dictionaryApi)
                .then(dictresponse => {
                  if (dictresponse.status == 404) {
                    document.querySelector('.partofspeech').innerText = 'Part of speech : Not Found';
                    document.querySelector('.definition').innerText = 'Definition: Not Found';
                  } else {
                    dictresponse.json().then(gdata => {
                      document.querySelector('.partofspeech').innerText = 'Part of Speech: ' + gdata[0].meanings[0].partOfSpeech;
                      document.querySelector('.definition').innerHTML = 'Definition: ' + gdata[0].meanings[0].definitions[0].definition;
                    });
                  }
                });
            });
          }
        });
    }
  
    searchbtn.addEventListener('click', () => {
      getRandomWord();
    });
  });