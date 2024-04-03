import React, { useState } from 'react';

function App() {
  const [name, setName] = useState('');
  const [email, setEmail] = useState('');
  const [submittedData, setSubmittedData] = useState([]);

  const handleSubmit = (e) => {
    e.preventDefault();
    setSubmittedData([...submittedData, { name, email }]);
    setName('');
    setEmail('');
  };

  return (
    <div className="container">
      <form onSubmit={handleSubmit}>
        <div>
          <label htmlFor="name">Name:</label>
          <input
            type="text"
            id="name"
            value={name}
            onChange={(e) => setName(e.target.value)}
          />
        </div>
        <div>
          <label htmlFor="email">Email:</label>
          <input
            type="email"
            id="email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
          />
        </div>
        <button type="submit" className="submit-button">Submit</button>
      </form>
      {submittedData.length > 0 && (
        <div>
          <h2>Submitted Data:</h2>
          {submittedData.map((data, index) => (
            <div key={index}>
              <p>Name: {data.name}</p>
              <p>Email: {data.email}</p>
            </div>
          ))}
        </div>
      )}
    </div>
  );
}

export default App;
