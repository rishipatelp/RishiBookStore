Program Name: - Rishi Book Store
Program Purpose: - To create a WebApp for Book Store
Program Author: - Rishi Patel
Program Date: - 2022/10/25
______________________________________________________________________________________________________________________________________

2022/10/25
I was not able to come to the school as I was sick and didn't know about the process about for the assessment.
So as I got to know about the assessment in the next week.

______________________________________________________________________________________________________________________________________

2022/11/03
1000 - Started Creating the new project and giving the Name RishiBookStore.
1001 - Configuring the authentication, advanced and Enable the razore runtime.
1002 - So as I created the project, I created the README.txt file in the root library.
1003 - Started updating the README.
1005 - After that I changed the ssl port and commened it down.
1008 - Soon I changed the Startup.cs file and removed the Sign-In RequiredConfirmed
1010 - Going through the Startup.cs to look for all the update.
1015 - Now I will be syncing my github account to the visual studio and created new repository.
1020 - As the account is synced I started to commit the changes donw to the accessment.
1025 - I tried to run the application and I ran successfuully.
1026 - Now it's time to update the HomeController and IActionResult interface result will be the result of the action.
1033 - Next step is layout.cshtml
1035 - Changed the title for the project as Layout.cshtml is the master page of the application holdinf the refrence to the css and javascript below the footer.

1045 - After finishing and running of the aplication it's time to add the bootstrap file to appliation.
1048 - So for that Go to Bootswatch.com and I selected the Zephyr theme and downloaded the bootstrap.css file.
1059 - Paste the bootstrap file in Lib>bootstrap>dist>css
1100 - Change the existing site.css with the bootstrap.
1105 - Change in Views> Shared > Layout.cshtml name of the bootstrap.min.css tp bootstrap.css
1110 - Change the nav class from the navbar-light to navbar-dark and bg-white to bg-primary.
1115 - After running the application the bootstrap file ran successfully.
1116 - Till now I didn't got any mistakes.

1120 - Adding 3rd party tools like JQuery UI as Datapicker.
1125 - But I am not getting any update to the application and ran unsucessfull.
1126 - I tried a lot to solve the problem but didn't acted properly.
1130 - So as per the requirement for the dropdown.

______________________________________________________________________________________________________________________________________

2022/11/03
1005 - Added 3 new projects with project Class Library.
1015 - Install Microsoft.core.Relational and COre.SqlServer packages.

Problem:
1045 - I tried installing the packages but it was throwing errors.
Severity	Code	Description	Project	File	Line	Suppression State
The type or namespace name 'ApplicationDbContext' could not be found (are you missing a using directive or an assembly reference?)
Solution: 
I didn't deleted the migration folder and as soon as I deleted that folder the errors were solved.

______________________________________________________________________________________________________________________________________

2022/11/08

820 - So from today I started working on the RishiBookStore.Models while using the same folder move Models and delete the original file.
830 - Edit Error.cshtml file and create new project references as mark only .DataAccess as well as .Models
835 - Updated README
840 - Rename Models to ViewModels

Problem:
847 - Try to build the project and successfully build. but was having the problem with the bootstrap file.
Soluiton:
850 - There was the little error of link not provided and as on I added that I worked completly.

900 - In the Utlity folder create static class called SD.cs
901 - Modify the class property of the class and add project reference to the main project and in DataAccess mark Models and Utility.
915 - Add a Customer area to Area and change the startup.cs as well as ScaffoldingReadMe.txt.
920 - Add the new Admin area in Area.
925 - Delete the Controller folder
930 - Update the Github Repo and "Part 1" is ready to go.

______________________________________________________________________________________________________________________________________

2022/11/14

1117 - Started the Assessment 2 part-2 with the reviewing the Appsetting.json file to look for the ssl port for localhost.
1120 - Using NuGet Package to the migration and changed the default project to .DataAccess which will help them to run in DataAccess file.
1125 - Adding the new migration file to the DB.
		20221114153620_defaultmigration.cs migration has been added 
		20221114234359_addcategorytodb.cs has been added through migration in .dataaccess project

Problem: 
1126 - While updating the database it was showing error for wrong updating at wrong place.
Solution:
1135 - I changed the location from RishiBookStore to RishiBooks.DataAccess and the update migration ran successfully.

1145 - Now its time for viewing the SQL table in Server Object Exporer and the new table Category was successfully updated.
1159 - Updating the database in Package Manager and checking for error and there was no error in the application.

1200 - Now time to start part2 of the Assessment 2 which is creating and updating the repository.
1206 - Creating New Folder named Repository and create Repository.cs in that and update it with the code available.
1215 - Creating IRepository and updating the file. 

1845 - Now creating CategoryRepository and ICategoryRpository and write down the code and build the project agian.
The Result was successfull.
1855 - Creating ISP_Call.cs interface and Class SP_Call.cs in the respected folder.
1910 - As with that file I had to install using Dapper.

2200 - Creating IUnitOfWork.cs in IRepository folder and UnitOfWork in Repository folder.
2212 - Building the solution.
2220 - The Application ran successfully and the WebApplication was successfully edited.

2320 - Now I will be starting part2.3 Category CRUD.
2333 - Now I will be taking  break for making the dinner!!!!!!!!!!!!!! Tired...........
______________________________________________________________________________________________________________________________________

2022/11/15

0110 - Now its time to modify the Indedx.cshtml file as we are giving some update to the webapp.
0120 - Now I started following the steps from the next page.
0130 - create javascript file name category.js and copy the code from the assessment 2 file.
0145 - Creating two new file in Views>Shared named as _CreateAndBackRoListButton and _EditAndBackToListButton.
0200 - Now editting the castegory.js file so that the function can run successfully.
0210 - Adding Delete URL function code and changing the Upsert.cshtml file.
0230 - The application was uploaded successfully and I ran successfuly.
0245 - Finally all the steps was successfully finished as well as updating README file for the documentation.

