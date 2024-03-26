


async function getRandomWord() {
  try {
    const word = await fetchRandomWord();
    updateDOM(word);

    const meanings = await fetchWordMeanings(word);
    updateDictionaryDetails(word, meanings);
  } catch (error) {
    console.log(error);
  }
}

async function fetchRandomWord() {
  const wordApiURL = getWordApi();
  console.log("Word API URL:", wordApiURL);
  const response = await fetch(wordApiURL);
  const data = await response.json();
  console.log("Word Data:", data);
  return data.word;
}

async function fetchWordMeanings(word) {
  const apiUrl = getDictionaryApiUrl() +'/'+ word;
  console.log("Dictionary API URL:", apiUrl);
  const response = await fetch(apiUrl);
  const data = await response.json();
  console.log("Dictionary Data:", data);
  
  const dictionaryInfo = data[0];
  return dictionaryInfo.meanings.map(item => {
    return {
      partOfSpeech: item.partOfSpeech,
      definitions: item.definitions.map(def => def.definition).join(', ')
    };
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