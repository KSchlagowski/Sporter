Requirements:
	.NET 5.0
	SQL Server

To configure project through terminal do:
    Backend/Sporter.Test 	-> dotnet restore
	Backend/Sporter.API 	-> dotnet restore
	. 						-> dotnet tool install --global dotnet-ef
	. 						-> dotnet-ef database update
	. 	                    -> dotnet run