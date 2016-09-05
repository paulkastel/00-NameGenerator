# 00-NameGenerator
First program of 100 Programming Challanges. Written in C# and containing database of almost 400 000 polish surnames,
2000 names and professions consistent with ISCO, and list of countries with their alfa codes consitent with ISO.
Also there is GUS database from 2009. All databases are provided from Piotr Zaniewicz blog ( http://piotr.eldora.pl/bazy-danych-kody-pocztowe-imiona-panstwa ).

If you want to run this program you need to download ( http://www.kastelik.com.pl/database.mdf ) and add databse to Visual Studio project. This is because of github file size limitations.

After that app is ready to publish and use. Make sure that you have SQL Server running.

# Description
Program connect with tables in database, choose random records and fills labels with all of the personal details.Later you can export data to
vCard format. Also there is an option to generate your fantasy hero name.
