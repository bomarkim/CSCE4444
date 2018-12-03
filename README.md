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
7. USE ENTITY FRAMEWORKS (which is the worst damn thing ever)
- If you get an error about connections missing, I am SO sorry but you'll have to do this
- If nothing is wrong when building the program, then skip part 8 completely.

8. Building Connection - Entity Framework
- Open Package Manager Console (Tools > NuGet Package Manager > Package Manager Console)
- Type Add-Migration <name> (you gotta name it.)

////////IF ERROR OCCURS CHECK THIS SECTION///////
Source: https://docs.microsoft.com/en-us/ef/core/get-started/aspnetcore/new-db?tabs=visual-studio

or you can watch the video I found after I typed this all out!! :))))))
Source: https://youtu.be/Ng_8uMdsqps

ERROR TIME! If you get this error: "No DbContext was found in assembly 'RecordShop'. Ensure that you're using the correct assembly and that the type is neither abstract nor generic."

Run these commands in the Package Manager Console:
'Install-Package Microsoft.EntityFrameworkCore.SqlServer'
'Install-Package Microsoft.EntityFrameworkCore.Tools'
'Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design'

(If you get an error while installing these packages, God help you.)

NOW CHECK TO SEE IF IT WILL ADD THE MIGRATION!!!!
IF IT DOESN'T LMAO CONTINUE


**Do this next section only if you are completely sure that building/migrating is not possible after following the previous steps. If you overwrite some of these next steps incorrectly, you will kill any previous Database configuration settings**

Now create a model for the entire DB (YUP THATS RIGHT!!!!) 
- right-click Models > Add > Class and name it something like "DbContextModel"
be sure to include "using Microsoft.EntityFrameworkCore;" at top
now INSIDE the generated public class paste this and change the public DbSet<NAME> NAME {get; set;}:


public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        { }

        public DbSet<Blog> Blogs { get; set; }   
        public DbSet<Post> Posts { get; set; }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public ICollection<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }

Delete any classes you don't need and update them accordingly.

Part 2!
Register your context with dependancy injection
- go to Startup.cs
- add these to top: 
'using EFGetStarted.AspNetCore.NewDb.Models;'  
'using static RecordShop.Models.DbContextModel;' 

-inside 'ConfigureServices(IServiceCollection services)" under the services.AddMvc() 
add the following code: 
var connection = @"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";
    services.AddDbContext<BloggingContext>
        (options => options.UseSqlServer(connection));

-change "<BloggingContext>" to "<RecordShop_Context>"

Part 3!
Add KEY attribute to all things wanting a database
-go back to any models that require a class (i.e. customers.cs)
-inside the public class, above the first attribute add '[Key]'
-add 'using System.ComponentModel.DataAnnotations;' to the top.

you *SHOULD* be able to create the migration now. (JESUS CHRIST)
check the solutions explorer for a "Migrations" folder
/////ERROR SECTION END /////////////

8. (cont) 
- if no errors occur > type "Update-Database" in console
- check side panels for "SQL Server Object Explorer" or View > SQL Server Object Explorer
- SQL Server > localdb > Databases > (database name) > Tables > see the tables
- create/edit database (if you want or if you dont have one) Right-click DB > view data

- every time you add something to a model that interacts with a DB you MUST add a new migration!!
- Package Manager Console > Add-Migration <name of migration> > Update-Database
