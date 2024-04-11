import { Profiler } from 'react';
import './App.css';
import './Profile.css';
import { Gallery } from './Gallery';
import { Profile } from './Profile';
import {About} from './About';
import './Tags.js';



export default function App(){
    return (
       <div>
        <Gallery/>
        <Profile/>
        <DivSection/>
        <About/>
       </div>
    );
}


