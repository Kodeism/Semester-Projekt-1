INSERT INTO Ejendomsm�gler (Fornavn, EfterNavn, Email, TlfNummer) VALUES
('Anna', 'Jensen', 'anna.jensen@boligm�gler.dk', '20101010'),
('Thomas', 'Nielsen', 'thomas.nielsen@boligsalg.dk', '22223333'),
('Lise', 'Poulsen', 'lise.p@ejendom.dk', '30304444');

INSERT INTO S�lger (Fornavn, EfterNavn, Email, TlfNummer) VALUES
('Henrik', 'Andersen', 'henrik.a@email.dk', '50505050'),
('Maria', 'Larsen', 'maria.larsen@email.dk', '60606060'),
('Ole', 'Madsen', 'ole.madsen@email.dk', '70707070');

INSERT INTO Bolig (Pris, Adresse, Postnummer, ByNavn, BoligType, BoligAreal, V�relser, ByggeDato, GrundSt�rrelse, EnergiM�rke, Ejendomsm�glerID, S�lgerID, Status) VALUES
(3200000, 'Birkevej 12', 8000, 'Aarhus', 'Villa', 140, 5, '1995-05-12', 750, 'B', 1, 1, 'Til salg'),
(2650000, 'Rosenvej 3',9000,'Aalborg', 'R�kkehus', 110, 4, '2001-08-23', 400, 'C', 2, 2, 'Solgt'),
(1800000, 'Linde All� 9', 6700, 'Esbjerg', 'Lejlighed', 85, 3, '2010-03-01', 0, 'A', 3, 3, 'Til salg');

INSERT INTO K�ber (Fornavn, EfterNavn, Email, TlfNummer, PrisKlasse, S�geOmr�de, BoligType, Noter, �nsketGrundSt�rrelse, �nsketBoligSt�rrelse) VALUES
('Sofie', 'Kristensen', 'sofie.k@email.dk', '11112222', 3000000, 'Aarhus, Sk�de, H�jbjerg', 'Villa', 'Skal have stor have til b�rnene', 700, 130),
('Mikkel', 'Hansen', 'mikkel.h@email.dk', '33334444', 2800000, 'Aalborg SV', 'R�kkehus', 'T�t p� skole og offentlig transport', 500, 110),
('Emma', 'Mortensen', 'emma.m@email.dk', '55556666', 2000000, 'Esbjerg C', 'Lejlighed', 'Maksimal energieffektivitet vigtigt', 0, 80);

INSERT INTO Salg (K�berID, BoligID, Dato, Bel�b) VALUES
(2, 2, '2024-11-01', 2600000);  -- Mikkel k�bte boligen i Aalborg
