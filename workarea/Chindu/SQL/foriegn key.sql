CREATE TABLE account_job(
	user_id int REFERENCES account(user_id),
	job_id int REFERENCES JOB(job_id),
	hire_date TIMESTAMP
)