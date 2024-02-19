import{PI , getArea , getCircumfernece , getVolume} from './mathutil.js'

console.log(PI);
 const circum = getCircumfernece(10);
 const area = getArea(10);
 const vol = getVolume(10);
 console.log(`${circum.toFixed(2)}cm`);
 console.log(`${area.toFixed(2)}cm`);
 console.log(`${vol.toFixed(2)}cm`);
