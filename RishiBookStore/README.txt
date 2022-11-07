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

