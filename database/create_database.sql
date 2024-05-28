--select table
-- select * from do_item_statuses
-- select * from do_items
-- select * from labels
-- select * from note_statuses
-- select * from notes
-- select * from pined_items
-- select * from todolist
-- select * from todolist_status
-- select * from users

--drop table
-- drop table do_item_statuses
-- drop table labels
-- drop table note_statuses
-- drop table pined_items
-- drop table todolist_status
-- drop table users
-- drop table todolist
-- drop table notes
-- drop table do_items


--create table
create table do_items_status(
	id_do_item_status serial primary key,
	do_item_status_name varchar(10) not null
)

create table pinned_items(
	id_pinned_item serial primary key,
	pinned_item_name varchar(5) not null
)

create table labels(
	id_label serial primary key,
	label_name varchar(25)
)

create table users(
	id_user serial primary key,
	username varchar(50) not null,
	password varchar(50) not null,
	email varchar(50) not null,
	time_created timestamp not null
)

create table notes_status(
	id_note_status serial primary key,
	note_status_name varchar(25) not null
)

create table todolists_status(
	id_todolist_status serial primary key,
	todolist_status_name varchar(25) not null
)

create table notes(
	id_note serial primary key,
	note_name varchar(40) not null,
	content text not null,
	image_filename varchar(100),
	time_created timestamp not null,
	id_user int,
	id_label int,
	id_pinned_item int,
	id_note_status int,
CONSTRAINT fk_users FOREIGN KEY (id_user) REFERENCES users (id_user) 
ON DELETE CASCADE,
CONSTRAINT fk_labels FOREIGN KEY (id_label) REFERENCES labels (id_label) 
ON DELETE CASCADE,
CONSTRAINT fk_pinned_items FOREIGN KEY (id_pinned_item) REFERENCES pinned_items (id_pinned_item) 
ON DELETE CASCADE,
CONSTRAINT fk_notes_status FOREIGN KEY (id_note_status) REFERENCES notes_status (id_note_status) 
ON DELETE CASCADE	
)

create table todolists(
	id_todolist serial primary key,
	todolist_name text not null,
	time_created timestamp not null,
	id_user int,
	id_todolist_status int,
	id_pinned_item int,
CONSTRAINT fk_users FOREIGN KEY (id_user) REFERENCES users (id_user) 
ON DELETE CASCADE,
CONSTRAINT fk_todolists_status FOREIGN KEY (id_todolist_status) REFERENCES todolists_status (id_todolist_status) 
ON DELETE CASCADE,
CONSTRAINT fk_pinned_items FOREIGN KEY (id_pinned_item) REFERENCES pinned_items (id_pinned_item) 
ON DELETE CASCADE
)

create table do_items(
	id_do_item serial primary key,
	do_item_name varchar(100) not null,
	id_do_item_status int,
	id_pinned_item int,
	id_todolist int,
	id_todolist_status int,
CONSTRAINT fk_do_items_status FOREIGN KEY (id_do_item_status) REFERENCES do_items_status (id_do_item_status) 
ON DELETE CASCADE,
CONSTRAINT fk_pinned_items FOREIGN KEY (id_pinned_item) REFERENCES pinned_items (id_pinned_item) 
ON DELETE CASCADE,
CONSTRAINT fk_todolists FOREIGN KEY (id_todolist) REFERENCES todolists (id_todolist) 
ON DELETE CASCADE,
CONSTRAINT fk_todolists_status FOREIGN KEY (id_todolist_status) REFERENCES todolists_status (id_todolist_status) 
ON DELETE CASCADE
)