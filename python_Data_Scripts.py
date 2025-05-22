import string
from faker import Faker
import random

fake = Faker('da_DK') 
boligtyper = [
    "Villa", "Lejlighed", "Rækkehus", "Andelsbolig", "Ejerlejlighed",
    "Sommerhus", "Ungdomsbolig", "Ældrebolig", "Kolonihavehus"
]

def generate_køber(n):
    for i in range(n):
        fornavn = fake.first_name().replace("'", "")
        efternavn = fake.last_name().replace("'", "")
        email = fake.email().replace("'", "")
        tlfnummer = fake.phone_number().replace("'", "")
        cprnr = fake.unique.ssn().replace("'", "")
        adresse = fake.address().replace("\n", ", ").replace("'", "")
        prisklasse = random.randint(500000, 10000000)
        søgeområde = fake.city().replace("'", "")
        boligtype = random.choice(boligtyper)
        noter = noter = fake.text(max_nb_chars=250).replace("'", "")
        ønsket_grund = random.randint(100, 1000)
        ønsket_bolig_størrelse = random.randint(40, 300)
        ønsket_værelser = random.randint(1, 7)

        sql = f"""
 (
    '{fornavn}', '{efternavn}', '{email}', '{tlfnummer}', '{cprnr}', '{adresse}',
    {prisklasse}, '{søgeområde}', '{boligtype}','{noter}',
    {ønsket_grund}, {ønsket_bolig_størrelse}, {ønsket_værelser}
),
"""
        print(sql)

#generate_køber(1000)

def generate_sælger(n):
    for i in range(n):
        fornavn = fake.first_name().replace("'", "")
        efternavn = fake.last_name().replace("'", "")
        email = fake.email().replace("'", "")
        tlfnummer = fake.phone_number().replace("'", "")
        cprnr = fake.unique.ssn().replace("'", "")
        adresse = fake.address().replace("\n", ", ").replace("'", "")

        sql = f"""
 (
    '{fornavn}', '{efternavn}', '{email}', '{tlfnummer}', '{cprnr}', '{adresse}'
),
"""
        print(sql)

#generate_sælger(1000)

def generate_Ejendomsmægler(n):
    for i in range(n):
        fornavn = fake.first_name().replace("'", "")
        efternavn = fake.last_name().replace("'", "")
        email = fake.email().replace("'", "")
        tlfnummer = fake.phone_number().replace("'", "")
        brugernavn = fake.user_name().replace("'", "")
        characters = string.ascii_letters + string.digits + string.punctuation
        password = ''.join(random.choices(characters, k=12)).replace("'", "")
        adgangsniveau = random.randint(1,2)
        sql = f"""
 (
    '{fornavn}', '{efternavn}', '{email}', '{tlfnummer}', '{brugernavn}', '{password}', '{adgangsniveau}'
),
"""
        print(sql)
#generate_Ejendomsmægler(1000)

energimærker = ["A", "B", "C", "D", "E", "F", "G"]
statusmuligheder = ["Til salg", "Solgt", "Under Behandling"]

def generate_bolig(n):
    for _ in range(n):
        pris = random.randint(100000, 10000000)
        adresse = fake.street_address().replace("'", "''").replace("'", "")
        postnummer = random.randint(1000, 9999)
        bynavn = fake.city().replace("'", "''").replace("'", "")
        boligtype = random.choice(boligtyper)
        boligareal = random.randint(40, 400)
        værelser = random.randint(1, 8)
        byggedato = fake.date_between(start_date='-100y', end_date='-1y')
        grundstørrelse = random.randint(100, 1500)
        energimærke = random.choice(energimærker)
        ejendomsmægler_id = random.randint(1, 1000)
        sælger_id = random.randint(1, 1000)
        status = random.choice(statusmuligheder)

        sql = f"""
 (
    {pris}, '{adresse}', {postnummer}, '{bynavn}', '{boligtype}', {boligareal},
    {værelser}, '{byggedato}', {grundstørrelse}, '{energimærke}',
    {ejendomsmægler_id}, {sælger_id}, '{status}'
),
"""
        print(sql)

#generate_bolig(1000)

def generate_sale(n):
    for i in range(n):
        KøberID = random.randint(1, 1000)
        dato = fake.date_between(start_date='-24y', end_date='-0y')
        beløb = random.randint(100000, 10000000)
        sælger_id = random.randint(1, 1000)  
        sql = f"""
        (
        {KøberID}, {i+1}, '{dato}', {beløb}, {sælger_id}
        ),"""
        print(sql)    

generate_sale(1000)

