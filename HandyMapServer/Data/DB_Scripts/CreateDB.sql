create table Client
(
    client_id INTEGER NOT NULL IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(255),
    surname VARCHAR(255),
    email VARCHAR(255) UNIQUE,
    password VARCHAR(255),
    contact_number CHAR(10),
	profile_picure varBinary(MAX)
);
create table Worker
(
    worker_id INTEGER NOT NULL IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(255),
    surname VARCHAR(255),
    email VARCHAR(255),
    password VARCHAR(255),
    contact_number CHAR(10),
    rating DECIMAL(5, 2),
	profile_picture varBinary(MAX)
);
create table Skills
(
    skill_id    integer primary key not null IDENTITY(1,1),
    skill_name  VARCHAR(255)
);
create table Worker_Skills
(
    worker_id INTEGER NOT NULL,
    skill_id INTEGER not null PRIMARY KEY,
	CONSTRAINT 
	fk_worker_id
		FOREIGN KEY (worker_id) references Worker(worker_id),
	CONSTRAINT
	fk_skill_id
		FOREIGN KEY (skill_id) references Skills(skill_id)
);
create table Job
(
    job_id INTEGER NOT NULL IDENTITY(1,1) PRIMARY KEY,
    client_id INTEGER NOT NULL,
    worker_id INTEGER NOT NULL,
    title VARCHAR(255),
    description VARCHAR(255),
    start_datetime DATETIME,
    end_datetime DATETIME,
	job_status INT NOT NULL,
	CONSTRAINT
		fk_client_id FOREIGN KEY(client_id) references Client(client_id),
	CONSTRAINT
		fk2_worker_id FOREIGN KEY(worker_id) references Worker(worker_id)
);
create table Address
(
    job_id INTEGER NOT NULL,
    client_id INTEGER NOT NULL,
    address_line_1 VARCHAR(255),
    address_line_2 VARCHAR(255),
    address_line_3 VARCHAR(255),
    province VARCHAR(50),
    city VARCHAR(255),
    zip_code CHAR(4),
	CONSTRAINT
		fk_job_id FOREIGN KEY(job_id) references Job(job_id),
	CONSTRAINT
		fk2_client_id FOREIGN KEY(client_id) references Client(client_id)
)