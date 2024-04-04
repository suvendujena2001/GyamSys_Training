import classes from './app.module.css';
import {useState} from 'react';

const App = () => {
const [selectedTechnology,setSelectedTechnology] =  useState (null);
console.log(selectedTechnology)

 const major_technological_advancements = ["Smart Assistants like Siri, Alexa","Smartphones","VPNs(Virtual Private Networks)",
 "3D Printing", "Drones"]


  return <div style = {{
    background: 'violet',
    border: '2px solid grey',
    borderRadius: 5,
      padding: '0.5rem'
  }}> 
    <h2>Welcome to the first task of React sessions!</h2>
    <h2> List of some of the major technological advancements that have shaped the modern world are-</h2>
  
     {major_technological_advancements.map(technology => (<p style={selectedTechnology === technology ? 
     {background: 'green',
     color: 'darkblue'

     } : {}}
     className={classes.pLikeButton} key={technology} onClick={() => {setSelectedTechnology(technology);}}>---{technology} </p>))}
    <div className= {classes.technologyDiv}>
      You chose to see this technology: {selectedTechnology ?? 'Please select one first!!'}
    </div>
    
     </div>

}
export default App;