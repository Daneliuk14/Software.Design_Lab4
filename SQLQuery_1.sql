create schema if not exists Keyboard;

drop table if exists Keyboard.Products;
drop table if exists Keyboard.Manufacturers;

create table Keyboard.Manufacturers(
    id serial not null,
    primary key(id),
    name varchar(30),
    location varchar(30),
    topclient varchar(40),
    export int
);

insert into Keyboard.Manufacturers(name, location, topclient, export)
values('LITEON SINGAPORE PTE LTD','China (Mainland)','LITE ON TRADING USA (4189 orders)', 4458),
('PRIMAX ELECTRONICS LTD','China (Mainland)','BOSE TOLLESON AZ (2029 orders)',6458),
('CHICONY GLOBAL INC','China (Mainland)','CHICONY AMERICA (243 orders)',1645);

select * from Keyboard.Manufacturers;



create table Keyboard.Products(
    id serial not null,
    primary key(id),
    manufacturerid int,
    name varchar(30),
    backlight boolean,
    colour varchar(10),
    
    constraint fk_manufacturerid
    foreign key(manufacturerid)
    references Keyboard.Manufacturers(id)
);

insert into Keyboard.Products(name, manufacturerid, backlight, colour)
values('COMPUTER KEYBOARD LITEON XUA',1,true,'white'),
('Primax Notebook  keyboard',2,true,'black'),
('Chicony - Keyboard ',3,false,'black');

select * from Keyboard.Products;