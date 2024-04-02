let wordApiURL ='';

function getRandomWord(){
    wordApiURL = getWordApi();

    const xhr = new XMLHttpRequest();

    xhr.onreadystatechange = function(){
        if(xhr.readyState ==4 && xhr.status==200){
            const wordData = JSON.parse(xhr.responseText);
            updateDOM(wordData.word);

            const dictionaryUrl = getDictionaryApiUrl() + '/' + wordData.word;
            getDictionaryData(dictionaryUrl);

        }else{
            console.log('Error in fetching' , xhr.status);
        
        }
    }
    xhr.open('GET' , wordApiURL);

    xhr.send();

};

function getDictionaryData(url){
    const xhr = new XMLHttpRequest();

    xhr.onreadystatechange = function(){
        if(xhr.readyState == XMLHttpRequest.DONE){
            if(xhr.status == 200){
                const dictionaryData = JSON.parse(xhr.responseText);
                const dictionaryInfo = dictionaryData[0];
                const meaningLength = dictionaryInfo.meanings.length;
                let meaningsToPrint =[];
                dictionaryInfo.meanings.forEach(item => {
                    meaningsToPrint.push({
                        partsOfSpeech : item.partsOfSpeech,
                        definitions : item.definitions
                    }); 
                });
                updateDictionaryDetails(dictionaryInfo.word,meaningsToPrint);
            }else{
                console.error('Error' , xhr.status);
            }
        }
    };
    xhr.open('GET' , url);

    xhr.send();
}
function updateDOM(word){
    var para = document.getElementById('word');
    para.innerHTML = word;
}



function updateDictionaryDetails(word, meanings){
    const tableBody = document.getElementById('word-details');
    tableBody.innerHTML ='';

    // iterate through the table data...
    meanings.forEach(meaning => {
        const row = tableBody.insertRow();
        const wordCell = row.insertCell(0);
        const pronunciationCell = row.insertCell(1);
        const meaningCell = row.insertCell(2);
        const exampleCell = row.insertCell(3);
    
        wordCell.textContent = word;
        pronunciationCell.textContent = meaning.partOfSpeech;
        meaningCell.textContent = meaning.definitions[0].definition;
        exampleCell.textContent = meaning.definitions[0].example;
      });

}


