let wordApiURL = "";

async function getRandomWord() {
  wordApiURL = getWordApi();
  console.log(fetch(wordApiURL));
  try {
    let wordResponse = await fetch(wordApiURL);
    let wordData = await wordResponse.json();
    console.log(wordData);
    updateDOM(wordData.word);
    let dictionaryResponse = await fetch(
      getDictionaryApiUrl() + "/" + wordData.word
    );
    let dictionaryData = await dictionaryResponse.json();
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
  } catch (e) {
    console.log(e);
  }
}


function updateDOM(word) {
  var para = document.getElementById("word");
  para.innerHTML = word;
}

function updateDictionaryDetails(info, meanings) {
  let word_details = document.getElementById("word-details");
  console.log(info);
  console.log(meanings);
  word_details.querySelector("#word").innerText = info.word;
  word_details.querySelector("#pronunciation").innerText = info.phonetic;
  word_details.querySelector("#meaning").innerText =
    meanings[0].definitions[0].definition;
  word_details.querySelector("#example").innerText = info.word;
}
