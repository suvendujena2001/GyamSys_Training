import classes from './App.Module.css';
import {useState} from 'react';

  const App =()=>
  {
    const BookRide=
    ["Bike",
    "Auto",
    "Mini Car",
    "Sedan Car"
    ]
    const [SelectedRide, setSelectedRide]= useState(null)
  return (
    <div className="App">
       <header>
        <h1 className='heading'>Booking Your Ride</h1>
       </header> 
       <body>
        <h1>Choose your Ride</h1>
        <div className='main'>
      { 
      BookRide.map(ride => (<p style={SelectedRide===ride?{
        background:"Grey",
        color:"white"
      }:{}} key={ride} onClick={()=>setSelectedRide(ride)}>{ride}</p>))
      }
      </div>
      <div className='Click'>
        User Select to Ride on {SelectedRide??'Not Choose Yet!!'}
        </div>
       </body>
    </div>
  );
  }
export default App;
