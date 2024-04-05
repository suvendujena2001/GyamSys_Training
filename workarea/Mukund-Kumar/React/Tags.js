import React, { useState } from 'react';

const DivSection = () => {
  const [headings, setHeadings] = useState([
    'Early Life',
    'Education',
    'Military Career',
    'References'
  ]);

  return (
    <div>
      {headings.map((heading, index) => (
        <div key={index}>
          <h2>{heading}</h2>
        </div>
      ))}
    </div>
  );
};

export default DivSection;