\# 🗄️ Database Schema and ERD Designs



Welcome to the Database Designs folder! 

This directory contains Entity-Relationship Diagrams (ERD) and database schema structures for various projects.



\---



\## ⚠️ How to View These Files



The files in this folder are saved in the `.drawio` format. Since GitHub natively displays these files as XML code, you can view the actual visual diagrams by following one of the two methods below:



\### 🔹 Method 1: Drag \& Drop (Fastest)

1\. \*\*Download\*\* the `.drawio` file you want to view to your local machine.

2\. \*\*Open\*\* \[app.diagrams.net](https://app.diagrams.net/) in your web browser.

3\. \*\*Drag and drop\*\* the downloaded file directly onto the website's canvas to view the diagram instantly.



\### 🔹 Method 2: Open from the Website

1\. \*\*Download\*\* the desired `.drawio` file to your local machine.

2\. \*\*Navigate\*\* to \[app.diagrams.net](https://app.diagrams.net/).

3\. On the start screen, click on \*\*"Open Existing Diagram"\*\*.

4\. \*\*select
VehicleDetails.ID,
VehicleDetails.MakeID,Makes.Make,
VehicleDetails.ModelID, MakeModels.ModelName,
VehicleDetails.SubModelID, SubModels.SubModelName,
VehicleDetails.BodyID,Bodies.BodyName,
VehicleDetails.Vehicle_Display_Name,
VehicleDetails.Year,
VehicleDetails.DriveTypeID,DriveTypes.DriveTypeName,
VehicleDetails.Engine,
VehicleDetails.Engine_CC,
VehicleDetails.Engine_Cylinders,VehicleDetails.Engine_Liter_Display,
VehicleDetails.FuelTypeID,FuelTypes.FuelTypeName,
VehicleDetails.NumDoors 
from VehicleDetails
join Makes on VehicleDetails.MakeID=Makes.MakeID
join MakeModels on MakeModels.ModelID=VehicleDetails.ModelID
join SubModels on SubModels.SubModelID=VehicleDetails.SubModelID
join Bodies on Bodies.BodyID=VehicleDetails.BodyID
join DriveTypes on DriveTypes.DriveTypeID=VehicleDetails.DriveTypeID 
join FuelTypes on FuelTypes.FuelTypeID=VehicleDetails.FuelTypeID;Select\*\* the downloaded file from your device and click Open.

