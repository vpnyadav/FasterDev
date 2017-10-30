

Note: Please does not use this package in existing project its only for new blank project .


======================================================================================================================================================
Step 1 first create a blank database in sql

step 2 Now set your connection string in webconfig as Deafultconnection like

" <add name="DefaultConnection" connectionString="Data Source=DESKTOP-VTAF1LA\SQLEXPRESS;Initial Catalog=demo7;Integrated Security=True" providerName="System.Data.SqlClient" />"

step 3 Run this project .

step 4 click to login and enter admin credentials

step 5  You see gentella admin panel and user management 
============================================================================================================================================================


if you want to sccafold master then user below steps
====================================================================================================================================================

step 1 add Model from database 

step 2 add new controller and select "MVC5 Controller with Views,using Entity framwork "

step 3 select "Model class"," model db context" and use layout page 

step 4 use layout page select "_LayoutGentelella.cshtml" in shared folder 

step 5 create controller and build and run 

step 6 run project and see your edit ,update delete,datatable,notification every thing is ready 

===========================================================================================================================================================


Default credentials for admin 

Email:admin@example.com
Password:Admin@123456