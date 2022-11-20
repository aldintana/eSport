# eSport

DOCKER SQL IMAGE https://hub.docker.com/_/microsoft-mssql-server  
    docker pull mcr.microsoft.com/mssql/server:2019-latest  
    docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=eSport123" -p 1435:1433 -d mcr.microsoft.com/mssql/server:2019-latest  

EF CORE
    https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-5.0

Automapper https://code-maze.com/automapper-net-core/

Pristupni podaci:  
    - Admin (desktop):  
        Username: Admin, Password: Sifra123!  
    - Klijent (mobile):  
        Username: Klijent, Password: Sifra123!  
