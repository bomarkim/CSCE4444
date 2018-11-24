# CSCE4444
Group project - Music store library


To connect SQL backend there are several methods:
1. Direct ADO.net (just uses c#; VERY complex)
2. Microsoft Entity Framework (ORM; works well when it works)
3. Dapper (want to look into this method; built by StackOverflow; open sourced)

Tim Corey has tutorial/info on dapper configuration
https://youtu.be/Et2khGnrIqc

/////
Current Stack: SQL Server 2017 Developer Edition, Visual Studio 2017 Community Edition, Microsoft Sequel Server Management Service.
C#, ASP.NET -> SQL
/////


//// TABLES 
Current DB has Product Table with six (6) attributes and Customer Table with two (2) Attributes (for now).

Product Table:

Product_ID(int)
Product(name of product - max of 50 chars)
Artist(name of artist - max of 40 chars)
Price(int/Money)
code(product code - max of 20 chars)
Genre(product's genre - max of 20 chars)


Customer Table:
Customer_ID(int)
Name(customer's name - max of 40 chars)

To install: (will need to do this to test server locally)

1. Download SQL Server Developer Editon and install (will take forever) - https://www.microsoft.com/en-us/sql-server/sql-server-downloads
2. After installation is complete, DO NOT CLOSE WINDOW -> install SMSS from same window. (will link to site, and select installation. Will also take forever)
3. After SSMS is installed, close window and find 'Microsoft Sequel Server Management Studio' in start menu. Select it. 
4. In SSMS window, copy the 'SQL ADMINISTRATORS' field, and click 'Install SSMS' again.
5. Window should pop up displaying previous 'SQL ADMINISTRATORS' field, leave all defaults and click connect.
6. DONE


Tutorial:
In visual studio 2017 Community Edition:
1. Click 'View' in menu bar -> Server Explorer
2. To Create own server: Server Explorer Toolbar should pop up on left. Right click 'Data Connections' and select 'Create New SQL Server Database'
- May need to update packages, will notify if it does and just install it. Restart Visual Studio.

2. To Connect to preexsisting server: Server Explorer Toolbar should pop up on left. Right click 'Data Connections' and select the connection.

3. Visual Studio will preload new file.
4. To add new table: click on newly created server connection and right click the 'Tables' folder, and select 'Add New Table'. (be sure to change the table name to 'Products' in the actual code)
5. Edit table the way you want and click 'Update' at top of text area. -> then click 'Update Database'
6. To add more products, right click 'Products' under 'Table' folder. -> select 'Show Table Data' option.

//To connect to DATABASE
7. 