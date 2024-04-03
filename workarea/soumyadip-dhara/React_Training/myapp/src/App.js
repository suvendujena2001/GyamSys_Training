import logo from './logo.svg';
import './App.css';
import { useState } from 'react';

function App() {
  const topics=["Quick Start","Creating and nesting components",
                 "Writing markup with JSX"];
  const topicdefinition={"Quick Start":"Welcome to the React documentation! This page will give you an introduction to the 80% of React concepts that you will use on a daily basis.",
                        "Creating and nesting components":"React apps are made out of components. A component is a piece of the UI (user interface) that has its own logic and appearance. A component can be as small as a button, or as large as an entire page.",
                        "Writing markup with JSX":"The markup syntax you’ve seen above is called JSX. It is optional, but most React projects use JSX for its convenience. All of the tools we recommend for local development support JSX out of the box."
                        }
  const [selectedtopic,setselectedtopic]=useState(null);
  return <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <h1>
          Welcome to React App
        </h1>
        {topics.map(t=>(<p style={ selectedtopic===t ?{
          background:'green',
          color:'black'
        }:
        {}
      } className="App-btn" key={t} onClick={()=>{
          setselectedtopic(t);
        }}>---{t}</p>))}
          <h3>
            Selected Topic is: {selectedtopic}
          </h3>
          <h4>Topic Description--</h4>
          <p className='App-body-content'>
            {selectedtopic && topicdefinition[selectedtopic]}
          </p>
      </header>
    </div>
  
}

export default App;
