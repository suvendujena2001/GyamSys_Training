CREATE TABLE account(
	user_id INT PRIMARY KEY,
	username VARCHAR(50) UNIQUE NOT NULL,
	password VARCHAR(50) NOT NULL,
	Email VARCHAR(250) UNIQUE NOT NULL,
	created_on TIMESTAMP not null,
	last_login TIME
)