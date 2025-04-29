Vs Code da console uygulaması oluşturmak için; dotnet new console
sql server için ; dotnet add package Microsoft.EntityFrameworkCore.SqlServer
postgresql için; dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
entity framework paketleri kurulumu için; 
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet tool install --global dotnet-ef
Code First de db bağlantısı;
Host=localhost;Database=CodeFirstDb;Username=postgres;Password=sapass

Db First de SqlServer için;
Scaffold-DbContext 'Server=DENIZ\MSSQLDORUK;Database=DDS;User Id=sa;Password=sapass;TrustServerCertificate=True'  Microsoft.EntityFrameworkCore.SqlServer -ContextDir Contexts -OutputDir Data/Entities -force

Db First de PostgreeSql için;
dotnet ef dbcontext scaffold "Host=localhost;Database=DbFirstDb;Username=postgres;Password=sapass;Trust Server Certificate=True" Npgsql.EntityFrameworkCore.PostgreSQL --context-dir Contexts --output-dir Data/Entities --force
