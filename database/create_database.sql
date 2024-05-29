-- Select from all tables

SELECT * FROM labels;
SELECT * FROM users;
SELECT * FROM statuses;
SELECT * FROM notes;
SELECT * FROM todolists;
SELECT * FROM do_items;

-- Drop tables in reverse order of creation to handle dependencies

DROP TABLE IF EXISTS do_items;
DROP TABLE IF EXISTS todolists;
DROP TABLE IF EXISTS notes;
DROP TABLE IF EXISTS statuses;
DROP TABLE IF EXISTS users;
DROP TABLE IF EXISTS labels;

-- Recreate tables

CREATE TABLE labels (
    id_label serial PRIMARY KEY,
    label_name VARCHAR(25)
);

CREATE TABLE users (
    id_user serial PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL,
    time_created TIMESTAMP NOT NULL
);

CREATE TABLE statuses (
    id_status serial PRIMARY KEY,
    status_name VARCHAR(15) NOT NULL
);

CREATE TABLE notes (
    id_note serial PRIMARY KEY,
    note_name VARCHAR(40) NOT NULL,
    content TEXT NOT NULL,
    image_url VARCHAR(255),
    time_created TIMESTAMP NOT NULL,
    pinned BOOLEAN,
    id_user INT,
    id_label INT,
    id_status INT,
    CONSTRAINT fk_user FOREIGN KEY (id_user) REFERENCES users (id_user)
        ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT fk_label FOREIGN KEY (id_label) REFERENCES labels (id_label)
        ON DELETE SET NULL ON UPDATE CASCADE,
    CONSTRAINT fk_note_status FOREIGN KEY (id_status) REFERENCES statuses (id_status)
        ON DELETE RESTRICT ON UPDATE CASCADE
);

CREATE TABLE todolists (
    id_todolist serial PRIMARY KEY,
    todolist_name TEXT NOT NULL,
    time_created TIMESTAMP NOT NULL,
    id_user INT,
    id_status INT,
    pinned BOOLEAN,
    CONSTRAINT fk_user FOREIGN KEY (id_user) REFERENCES users (id_user)
        ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT fk_todolist_status FOREIGN KEY (id_status) REFERENCES statuses (id_status)
        ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE do_items (
    id_do_item serial PRIMARY KEY,
    do_item_name VARCHAR(100) NOT NULL,
    checked BOOLEAN,
    id_todolist INT,
    CONSTRAINT fk_todolist FOREIGN KEY (id_todolist) REFERENCES todolists (id_todolist)
        ON DELETE CASCADE ON UPDATE CASCADE
);


-- Insert Default Values

insert into users (id_user, username, password, email, time_created)
Values (1, 'fauzan', 'fauzan123', 'bukan@gmail.com', now());

INSERT INTO statuses (id_status, status_name) VALUES
(1, 'default'),
(2, 'trashed'),
(3, 'archived'),
(4, 'drafted');

