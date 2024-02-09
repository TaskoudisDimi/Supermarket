# About 
The following is a project concerning the management of a Supermarket.
Includes two different types of forms. Those used by administrators and those used by sellers:
* Administrators can do some operations in the database (cleaning, restoring, etc.), create sellers, and monitor products and categories.
* Sellers manage products, product categories, and bill products.

Also, most forms have the ability to export and import files (CSV, xlsx). For data entry, an [API](CallSuperMarketAPI) in order for certain products to be imported automatically.
Finally, the API is built in a different repository [https://github.com/TaskoudisDimi/APIs.git], to be able to receive or send information to some third-party software.

# Steps to run the application:
* Run the script smarket.sql or Create a new Database from SQL Server Management Studio and Restore the database with the backupfile.bak
* Open the solution [file](SupermarketTuto.sln) with an editor (e.g. visual studio 2022). Build the project.
* Run the ```SupermarketTuto.exe``` file.


