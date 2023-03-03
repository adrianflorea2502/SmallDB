Proiect BD2 - Platforma web Jocuri PC - Florea Adrian 342C3

Reqs:
Entity Framework Core
Docker
ASP.NET Core Web Application MVC 

Pasi:

1) Pornire server sql pe docker: docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=parolaAiaPuternic4!" -p 1433:1433 --name proiectBD -h proiectBD -d mcr.microsoft.com/mssql/server:2019-latest

2) Login la baza de date pornita

3) Rulare scripturi creare tabele si creare functii / proceduri
	create#Table.sql
	getGamesByPublisher.sql
	getGamesLowerThan.sql
    !!! trigger.sql  -> acest trigger este posibil sa fie scris prost, desi fac o verificare
			naiva pentru null acesta introduce unde nu ar trebui valori de tip NULL
	procedure1.sql
	procedure2.sql
	alter.sql
	
4) Populare tabele
	InsertToTables.sql

5) Creare proiect VS Web App MVC cu .NET5 si numele ProiectBD / Folosirea arhivei cu totul

6) Din powershell in folder-ul proiectului (pentru a realiza conexiunea):
	dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.12
	dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 5.0.12
	dotnet ef dbcontext scaffold "Data Source=localhost,1433;Initial Catalog=proiect;Persist Security Info=True;User ID=SA;Password=parolaAiaPuternic4!" Microsoft.EntityFrameworkCore.SqlServer -o DB --force

7) Se inlocuiesc fisierele Sursa cu cele din arhiva

8) Execute project...

