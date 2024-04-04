import classes from './App.module.css';
import {useState} from 'react';
const App =() =>{

  const [selectedTopic,setSelectedTopic]=useState(null);
  const topicsToCover =[" React Basics",
  "classes and stylings react components",
  "Hooks: adds interactivity to the components",
  "Props and state"]

  return <div className ={classes.divstyles}
  >
    <h2>My React Learning</h2>
    <p>Description about my learning.</p>

    <h3>Now we will list down some of my learning</h3>
   
    {
      topicsToCover.map(topic =>(<p style ={selectedTopic === topic ? {
        background:'green',
        color:'white'
      }:{
      }}className ={classes.pLikeButton} key ={topic} onClick={()=>{
        setSelectedTopic(topic);
      }}>---{topic}</p>))
    }

    <div className={classes.topicDiv}>
      You Have clicked on :{selectedTopic ?? 'Nothing...'}
    </div>
  </div>
}



export default App;
