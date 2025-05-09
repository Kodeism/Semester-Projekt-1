create table Køber(
	Fornavn varchar(100),
	EfterNavn varchar(100),
	Email varchar(100),
	TlfNummer varchar(50),
	KøberID int primary key identity,	
	PrisKlasse int,
	SøgeOmråde varchar(200),
	BoligType varchar(100),
	Noter varchar(3000),
	ØnsketGrundStørrelse int,
	ØnsketBoligStørrelse int
);

create table Sælger(
	SælgerID int primary key identity,
	Fornavn varchar(100),
	EfterNavn varchar(100),
	Email varchar(100),
	TlfNummer varchar(50)
);

create table Ejendomsmægler(
	EjendomsmæglerID int primary key identity,
	Fornavn varchar(100),
	EfterNavn varchar(100),
	Email varchar(100),
	TlfNummer varchar(50)
);

create table Bolig(
	BoligID int primary key identity,
	Pris int,
	Adresse varchar(500),
	BoligType varchar(100),
	BoligAreal int,
	Værelser int,
	ByggeDato DATE,
	GrundStørrelse int,
	EnergiMærke varchar(2),
	EjendomsmæglerID int FOREIGN KEY REFERENCES Ejendomsmægler(EjendomsmæglerID),
	SælgerID int FOREIGN KEY REFERENCES Sælger(SælgerID),
	Status varchar(50)
);

Create table Salg(
	SalgsID int primary key identity,
	KøberID int FOREIGN KEY REFERENCES Køber(KøberID),
	BoligID int,
	Dato DATE,
	Beløb int
);
