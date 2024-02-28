let wordApiURL = '';

function getRandomWord() {
  wordApiURL = getWordApi();
  fetch(wordApiURL)
    .then(wordResponse => wordResponse.json())
    .then((wordData) => {
      updateDOM(wordData.word)
      return fetch(getDictionaryApiUrl() + '/' +wordData.word);
    })
    .then(dictionaryResponse => dictionaryResponse.json())
    .then(dictionaryData => {
      const dictionaryInfo = dictionaryData[0];
      const meaningLength = dictionaryInfo.meanings.length;
      let meaningsToPrint = [];
      //let meaning = {};
      /*dictionaryInfo.meanings.map(item => {
        meaning[item.partOfSpeech] = item.partOfSpeech;
        meaning['definitions'] = item.definitions;
        meaning['example']=item.definitions[0].example;
        meaningsToPrint.push(meaning);
  
        //updateDOM(dictionaryInfo.word);
        //console.log(dictionaryInfo.phonetic)
        //console.log(meaningsToPrint)
      });*/
      const extracted = {};
      for (let i = 0; i < meaningLength; i++) {
        const partOfSpeech = dictionaryInfo.meanings[i].partOfSpeech;
        const definitions = dictionaryInfo.meanings[i].definitions.map(function (def) {
          return { definition: def.definition, example: def.example }
        });
        extracted[partOfSpeech] = definitions;
      }
      console.log(dictionaryInfo)
      console.log(dictionaryInfo.phonetics[0].audio);
      //console.log(dictionaryInfo);
      updateDictionaryDetails(dictionaryInfo.word, dictionaryInfo, extracted);
    })
    .catch(error => console.log(error));
}


// function using ajax
/*

function getRandomWord() {
  const xhr = new XMLHttpRequest();
  wordApiURL = getWordApi();
  // Step 1: Create a new XMLHttpRequest object
  xhr.open('GET', wordApiURL); // Replace with your word API URL
  xhr.responseType = 'json';

  // Step 2: Listen for the 'load' event
   xhr.onload =function () {
     if (xhr.status >= 200 && xhr.status < 300) {
       const wordData = xhr.response;
 
       console.log(wordData);
 
       updateDOM(wordData.word);
 
       
       xhr.open('GET', getDictionaryApiUrl() + '/' + wordData.word);
       xhr.responseType = 'json';
       xhr.onload = function () {
         if (xhr.status >= 200 && xhr.status < 300) {
           const dictionaryData = xhr.response;
           console.log(dictionaryData);
 
           const dictionaryInfo = dictionaryData[0];
           const meaningLength = dictionaryInfo.meanings.length;
           const extracted = {};
           for (let i = 0; i < meaningLength; i++) {
             const partOfSpeech = dictionaryInfo.meanings[i].partOfSpeech;
             const definitions = dictionaryInfo.meanings[i].definitions.map(function (def) {
               return { definition: def.definition, example: def.example }
             });
             extracted[partOfSpeech] = definitions;
           }
           console.log(extracted);
           //console.log(dictionaryInfo);
           updateDictionaryDetails(dictionaryInfo.word, dictionaryInfo.phonetic, extracted);
 
           updateDOM(wordData.word);
 
         } else {
           console.log('error');
         }
       }
       xhr.send();
     } else {
       alert('Network Error');
     }
   };
 
   xhr.send();
 }
 */

// async and await function


/* async function getRandomWord() {
   try {
     const wordApiURL = getWordApi();
     const wordResponse = await fetch(wordApiURL);

     if (!wordResponse.ok) {
       throw new Error('Network response was not ok');
     }

     const wordData = await wordResponse.json();
     console.log(wordData);
     updateDOM(wordData.word);

     const dictionaryApiURL = getDictionaryApiUrl() + '/' + wordData.word;
     const dictionaryResponse = await fetch(dictionaryApiURL);

     if (!dictionaryResponse.ok) {
       throw new Error('Network response was not ok');
     }

     const dictionaryData = await dictionaryResponse.json();
     console.log(dictionaryData);

     const dictionaryInfo = dictionaryData[0];
     const meaningLength = dictionaryInfo.meanings.length;
     const extracted = {};

     for (let i = 0; i < meaningLength; i++) {
       const partOfSpeech = dictionaryInfo.meanings[i].partOfSpeech;
       const definitions = dictionaryInfo.meanings[i].definitions.map(def => ({
         definition: def.definition,
         example: def.example
       }));
       extracted[partOfSpeech] = definitions;
     }

     console.log(dictionaryInfo.phonetic[0].audio);
     updateDictionaryDetails(dictionaryInfo.word, dictionaryInfo.phonetic, extracted);
     updateDOM(wordData.word);
   } catch (error) {
     console.error('Error:', error);
     alert('Network Error');
   }
 }
*/




//updating the dom
function updateDOM(word) {
  var para = document.getElementById('word');
  para.innerText = word;

}


function updateDictionaryDetails(word, dictionaryInfo, extracted) {

  // Write your code here
  var updatedword = document.getElementById('word1');
  updatedword.innerText = word;

  var pronunciationtpdoiplay = document.getElementById('pronunciation');

  pronunciationtpdoiplay.innerHTML = `${dictionaryInfo.phonetic} <audio controls> 
  <source src=${dictionaryInfo.phonetics[0].audio} type="audio/mp4"><source src="" type="audio/mp4">
</audio>`
;


  //console.log(meanings);

  //meaningsLength=meanings.length;

  //var meaningTodisplay='';
  //meanings[0].definitions[0].definition;
  //console.log(meanings[0].definitions[0].definition);

  //meanings[0].definitions.map(item=>{
  //meaningTodisplay+=item.definition+'<br>';

  /*
  var updatedmeaning=document.getElementById('meaning');
  updatedmeaning.innerText=item.definition; 
  console.log(item.definition);*/
  //})
  var updatedmeaning = document.getElementById('meaning');
  //updatedmeaning.innerHTML=`${meaningTodisplay}`;  
  //console.log(meanings[0].example);

  var exampletodsplay = document.getElementById('example');
  //exampletodsplay.innerText+=meanings[0].example
  exampletodsplay.innerHTML = "";
  updatedmeaning.innerHTML = "";




  for (const partOfSpeech in extracted) {
    if (extracted.hasOwnProperty(partOfSpeech)) {


      const partOfSpeechCell = document.createElement('a');
      partOfSpeechCell.textContent = partOfSpeech;
      console.log(partOfSpeech);

      const meaningscell = document.createElement('td');
      const examplecell = document.createElement('td');

      meaningscell.appendChild(partOfSpeechCell);
      examplecell.innerHTML = `${partOfSpeech} examples <br>`;


      const listofdef = document.createElement('ul');
      const listofexm = document.createElement('ul');

      extracted[partOfSpeech].forEach(function (meaning) {
        const listitemfordefination = document.createElement('li');
        const listitemforexample = document.createElement('li');

        const definationspan = document.createElement('span');
        definationspan.textContent = `${meaning.definition}`;

        const examplespan = document.createElement('span');
        examplespan.textContent = `${meaning.example}`;

        listitemfordefination.appendChild(definationspan);
        listitemfordefination.appendChild(document.createElement('br'));
        listitemforexample.appendChild(examplespan);
        listitemforexample.appendChild(document.createElement('br'));

        listofdef.appendChild(listitemfordefination);
        listofexm.appendChild(listitemforexample);


      });
      meaningscell.appendChild(listofdef);
      examplecell.appendChild(listofexm);
      updatedmeaning.appendChild(meaningscell);
      exampletodsplay.appendChild(examplecell)


    }
  }
}