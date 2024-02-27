document.addEventListener('DOMContentLoaded', function() {
    const searchbtn = document.querySelector('.btn');
  
    function getRandomWord() {
      const wordApiURL = getWordApi();
      let response;
      fetch(wordApiURL)
        .then(res => {
          response = res;
          if (response.status == 404) {
            document.querySelector('wordis').style.display = 'none';
            document.querySelector('.error').innerText = 'Error';
          } else {
            return response.json();
          }
        })
        .then(data => {
          var gword = data.word;
          document.querySelector('#word').innerText = gword;
  
          const dictionaryApi = getDictionaryApiUrl() + '/' + gword;
          let dictresponse;
          fetch(dictionaryApi)
            .then(res => {
              dictresponse = res;
              if (dictresponse.status == 404) {
                document.querySelector('.partofspeech').innerText = 'Part of speech : Not Found';
                document.querySelector('.definition').innerText = 'Definition: Not Found';
              } else {
                return dictresponse.json();
              }
            })
            .then(gdata => {
              document.querySelector('.partofspeech').innerText = 'Part of Speech: ' + gdata[0].meanings[0].partOfSpeech;
              document.querySelector('.definition').innerHTML = 'Definition: ' + gdata[0].meanings[0].definitions[0].definition;
            })
            .catch(error => console.error(error));
        })
        .catch(error => console.error(error));
    }
  
    searchbtn.addEventListener('click', () => {
      getRandomWord();
    });
  });