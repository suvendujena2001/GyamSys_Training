let wordApiURL = '';

async function getRandomWord() {
  try {
    const wordApiURL = getWordApi();
    const wordResponse = await fetch(wordApiURL);
    const wordData = await wordResponse.json();
   
    updateDOM(wordData.word);
   
    const dictionaryApiURL = getDictionaryApiUrl() + '/' + wordData.word;
    const dictionaryResponse = await fetch(dictionaryApiURL);
    const dictionaryData = await dictionaryResponse.json();
   
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
  } catch (error) {
    console.log(error);
  }
}

function updateDOM(word) {
  var para = document.getElementById('word');
  para.innerHTML= word;
}


function updateDictionaryDetails(word,meanings) {
    let word = document.getElementById("word");
    word.querySelector("#word").innerText= '';
    word.querySelector("#meaning").innerText= meanings[0].definitions[0].definition;
    word.querySelector('#partofspeech').innerText = 'Part of Speech: '+partOfSpeech;
    word.querySelector('#definition').innerHTML = 'Definition: '+meanings[0].definitions[0].definition;
   
}
