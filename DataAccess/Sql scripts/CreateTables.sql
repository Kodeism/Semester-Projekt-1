create table K�ber(
	Fornavn varchar(100),
	EfterNavn varchar(100),
	Email varchar(100),
	TlfNummer varchar(50),
	CprNr varchar(50),
	Adresse varchar(100),
	K�berID int primary key identity,	
	PrisKlasse int,
	S�geOmr�de varchar(200),
	BoligType varchar(100),
	Noter varchar(3000),
	�nsketGrundSt�rrelse int,
	�nsketBoligSt�rrelse int 
);

create table S�lger(
	S�lgerID int primary key identity,
	Fornavn varchar(100),
	EfterNavn varchar(100),
	Email varchar(100),
	TlfNummer varchar(50),
	Adresse varchar(100),
    CprNummer varchar(50)
);

create table Ejendomsm�gler(
	Ejendomsm�glerID int primary key identity,
	Fornavn varchar(100),
	EfterNavn varchar(100),
	Email varchar(100),
	TlfNummer varchar(50),
	Brugernavn varchar(50),
	Password varchar(50),
	Adgangsniveau int -- 1 or 2. Level 2 giver admin privilegier.
);

create table Bolig(
	BoligID int primary key identity,
	Pris int,
	Adresse varchar(500),
	Postnummer int,
	ByNavn varchar(500),
	BoligType varchar(100),
	BoligAreal int,
	V�relser int,
	ByggeDato DATE,
	GrundSt�rrelse int,
	EnergiM�rke varchar(2),
	Ejendomsm�glerID int FOREIGN KEY REFERENCES Ejendomsm�gler(Ejendomsm�glerID),
	S�lgerID int FOREIGN KEY REFERENCES S�lger(S�lgerID),
	Status varchar(50)
);

Create table Salg(
	SalgsID int primary key identity,
	K�berID int FOREIGN KEY REFERENCES K�ber(K�berID),
	BoligID int,
	Dato DATE,
	Bel�b int
);
