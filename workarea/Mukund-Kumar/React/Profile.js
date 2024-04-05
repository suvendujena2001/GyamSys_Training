import image from './images.jpeg';
import './Profile.css';
export function Profile() {
    return (
        <div className="profile">
      <img class="profilepic" 
        src={image}
        alt="Field Marshal Sam Manekshaw"
      />
      </div>
    );
  }