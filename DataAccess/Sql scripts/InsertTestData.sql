INSERT INTO Ejendomsm�gler (Fornavn, EfterNavn, Email, TlfNummer, Brugernavn, Password, Adgangsniveau) VALUES
('Anna', 'Jensen', 'anna.jensen@boligm�gler.dk', '20101010', 'adm-test', '1234', 2), --admin user
('Thomas', 'Nielsen', 'thomas.nielsen@boligsalg.dk', '22223333', 'normal-test', '1234', 1),
('Lise', 'Poulsen', 'lise.p@ejendom.dk', '30304444', 'test', '1234', 1);

INSERT INTO S�lger (Fornavn, EfterNavn, Email, TlfNummer, Adresse, CprNummer) VALUES
('Henrik', 'Andersen', 'henrik.a@email.dk', '50505050', 'Testvej 22', '021201-22'),
('Maria', 'Larsen', 'maria.larsen@email.dk', '60606060', 'Testvej 22', '021201-22'),
('Ole', 'Madsen', 'ole.madsen@email.dk', '70707070', 'Testvej 22', '021201-22');

INSERT INTO Bolig (Pris, Adresse, Postnummer, ByNavn, BoligType, BoligAreal, V�relser, ByggeDato, GrundSt�rrelse, EnergiM�rke, Ejendomsm�glerID, S�lgerID, Status) VALUES
(3200000, 'Birkevej 12', 8000, 'Aarhus', 'Villa', 140, 5, '1995-05-12', 750, 'B', 1, 1, 'Til salg'),
(2650000, 'Rosenvej 3',9000,'Aalborg', 'R�kkehus', 110, 4, '2001-08-23', 400, 'C', 2, 2, 'Solgt'),
(1800000, 'Linde All� 9', 6700, 'Esbjerg', 'Lejlighed', 85, 3, '2010-03-01', 0, 'A', 3, 3, 'Til salg');

INSERT INTO K�ber (Fornavn, EfterNavn, Email, TlfNummer, CprNr, Adresse, PrisKlasse, S�geOmr�de, BoligType, Noter, �nsketGrundSt�rrelse, �nsketBoligSt�rrelse) VALUES
('Sofie', 'Kristensen', 'sofie.k@email.dk', '11112222', '101022-44', 'K�bervej 19', 3000000, 'Aarhus, Sk�de, H�jbjerg', 'Villa', 'Skal have stor have til b�rnene', 700, 130),
('Mikkel', 'Hansen', 'mikkel.h@email.dk', '33334444', '101022-44', 'K�bervej 19', 2800000, 'Aalborg SV', 'R�kkehus', 'T�t p� skole og offentlig transport', 500, 110),
('Emma', 'Mortensen', 'emma.m@email.dk', '55556666', '101022-44', 'K�bervej 19', 2000000, 'Esbjerg C', 'Lejlighed', 'Maksimal energieffektivitet vigtigt', 0, 80);

INSERT INTO Salg (K�berID, BoligID, Dato, Bel�b) VALUES
(2, 2, '2024-11-01', 2600000);  -- Mikkel k�bte boligen i Aalborg
