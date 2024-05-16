SELECT TOP (1000) [ISBN]
      ,[BookTitle]
      ,[BookAuthor]
      ,[YearOfPublication]
      ,[Publisher]
      ,[ImageUrl_S]
      ,[ImageUrl_M]
      ,[ImageUrl_L]
  FROM [BooksDB].[dbo].[Books]
  INSERT INTO Books (ISBN, BookTitle, BookAuthor, YearOfPublication, Publisher, ImageUrl_S, ImageUrl_M, ImageUrl_L) 
VALUES 
('0195153448', 'Classical Mythology', 'Mark P. O. Morford', '2002', 'Oxford University Press', 'http://images.amazon.com/images/P/0195153448.01.THUMBZZZ.jpg', 'http://images.amazon.com/images/P/0195153448.01.MZZZZZZZ.jpg', 'http://images.amazon.com/images/P/0195153448.01.LZZZZZZZ.jpg'),
('0002005018', 'Clara Callan', 'Richard Bruce Wright', '2001', 'HarperFlamingo Canada', 'http://images.amazon.com/images/P/0002005018.01.THUMBZZZ.jpg', 'http://images.amazon.com/images/P/0002005018.01.MZZZZZZZ.jpg', 'http://images.amazon.com/images/P/0002005018.01.LZZZZZZZ.jpg'),
('0060973129', 'Decision in Normandy', 'Carlo DEste', '1991', 'HarperPerennial', 'http://images.amazon.com/images/P/0060973129.01.THUMBZZZ.jpg', 'http://images.amazon.com/images/P/0060973129.01.MZZZZZZZ.jpg', 'http://images.amazon.com/images/P/0060973129.01.LZZZZZZZ.jpg'),
('0374157065', 'Flu: The Story of the Great Influenza Pandemic of 1918 and the Search for the Virus That Caused It', 'Gina Bari Kolata', '1999', 'Farrar Straus Giroux', 'http://images.amazon.com/images/P/0374157065.01.THUMBZZZ.jpg', 'http://images.amazon.com/images/P/0374157065.01.MZZZZZZZ.jpg', 'http://images.amazon.com/images/P/0374157065.01.LZZZZZZZ.jpg'),
('0393045218', 'The Mummies of Urumchi', 'E. J. W. Barber', '1999', 'W. W. Norton &amp; Company', 'http://images.amazon.com/images/P/0393045218.01.THUMBZZZ.jpg', 'http://images.amazon.com/images/P/0393045218.01.MZZZZZZZ.jpg', 'http://images.amazon.com/images/P/0393045218.01.LZZZZZZZ.jpg'),
('0399135782', 'The Kitchen Gods Wife', 'Amy Tan', '1991', 'Putnam Pub Group', 'http://images.amazon.com/images/P/0399135782.01.THUMBZZZ.jpg', 'http://images.amazon.com/images/P/0399135782.01.MZZZZZZZ.jpg', 'http://images.amazon.com/images/P/0399135782.01.LZZZZZZZ.jpg'),
('0425176428', 'What If?: The Worlds Foremost Military Historians Imagine What Might Have Been', 'Robert Cowley', '2000', 'Berkley Publishing Group', 'http://images.amazon.com/images/P/0425176428.01.THUMBZZZ.jpg', 'http://images.amazon.com/images/P/0425176428.01.MZZZZZZZ.jpg', 'http://images.amazon.com/images/P/0425176428.01.LZZZZZZZ.jpg'),
('0671870432', 'PLEADING GUILTY', 'Scott Turow', '1993', 'Audioworks', 'http://images.amazon.com/images/P/0671870432.01.THUMBZZZ.jpg', 'http://images.amazon.com/images/P/0671870432.01.MZZZZZZZ.jpg', 'http://images.amazon.com/images/P/0671870432.01.LZZZZZZZ.jpg'),
('0679425608', 'Under the Black Flag: The Romance and the Reality of Life Among the Pirates', 'David Cordingly', '1996', 'Random House', 'http://images.amazon.com/images/P/0679425608.01.THUMBZZZ.jpg', 'http://images.amazon.com/images/P/0679425608.01.MZZZZZZZ.jpg', 'http://images.amazon.com/images/P/0679425608.01.LZZZZZZZ.jpg'),
('074322678X', 'Where You will Find Me: And Other Stories', 'Ann Beattie', '2002', 'Scribner', 'http://images.amazon.com/images/P/074322678X.01.THUMBZZZ.jpg', 'http://images.amazon.com/images/P/074322678X.01.MZZZZZZZ.jpg', 'http://images.amazon.com/images/P/074322678X.01.LZZZZZZZ.jpg'),
('0771074670', 'Nights Below Station Street', 'David Adams Richards', '1988', 'Emblem Editions', 'http://images.amazon.com/images/P/0771074670.01.THUMBZZZ.jpg', 'http://images.amazon.com/images/P/0771074670.01.MZZZZZZZ.jpg', 'http://images.amazon.com/images/P/0771074670.01.LZZZZZZZ.jpg'),
('080652121X', 'Hitlers Secret Bankers: The Myth of Swiss Neutrality During the Holocaust', 'Adam Lebor', '2000', 'Citadel Press', 'http://images.amazon.com/images/P/080652121X.01.THUMBZZZ.jpg', 'http://images.amazon.com/images/P/080652121X.01.MZZZZZZZ.jpg', 'http://images.amazon.com/images/P/080652121X.01.LZZZZZZZ.jpg'),
('0887841740', 'The Middle Stories', 'Sheila Heti', '2004', 'House of Anansi Press', 'http://images.amazon.com/images/P/0887841740.01.THUMBZZZ.jpg', 'http://images.amazon.com/images/P/0887841740.01.MZZZZZZZ.jpg', 'http://images.amazon.com/images/P/0887841740.01.LZZZZZZZ.jpg'),
('1552041778', 'Jane Doe', 'Nora Roberts', '2003', 'Jove', 'http://images.amazon.com/images/P/1552041778.01.THUMBZZZ.jpg', 'http://images.amazon.com/images/P/1552041778.01.MZZZZZZZ.jpg', 'http://images.amazon.com/images/P/1552041778.01.LZZZZZZZ.jpg');