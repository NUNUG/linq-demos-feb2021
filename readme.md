# Linq From Zero To Sixty Presentation Source
This is the source code from the Feb 2021 NUNUG Meeting.

## Content
There are 3 directories here.

- LinqDemos
- EFCoreApp1
- data

### LinkDemos
This is the best place to start.  There are demos for all the Linq methods in here.  Open the .SLN file in Visual Studio and navigate to the Program.cs file.  In the Execute() method, uncomment any one line for the demo that you want to see.  Comment it out and uncomment the next that you want to see.

If your Visual Studio isn't configured to keep the output window open when the program ends, add a `Console.ReadLine();` to the end of the Main() method.

### EFCoreApp1
To be extra helpful, I created an actual database in Sqlite3.  It matches the schema in the objects I used in the LinqDemos project.  The EFCoreApp1 project is set up to work with that database using EF Core.  See the comments for instructions.

### Data
This is the Sqlite3 database which is consumed by the EFCoreaApp1 project.  You can download a Sqlite3 client to open the db file if you wish.  You can also see the schema easily enough by looking at the .SQL script.

Download Sqlite3 for Windows here:
(32-bit)
https://www.sqlite.org/2021/sqlite-dll-win32-x86-3340100.zip

(64-bit)
https://www.sqlite.org/2021/sqlite-dll-win64-x64-3340100.zip

(Mac)
https://www.sqlite.org/2021/sqlite-tools-osx-x86-3340100.zip

(Android)
https://www.sqlite.org/2021/sqlite-android-3340100.aar

## Slides
There is also a slideshow.  You can view it here.

https://docs.google.com/presentation/d/1cB9L0M6eULC8g84B8oGC5-VePgxysiwrrVP7sMh8dzY/edit?usp=sharing

