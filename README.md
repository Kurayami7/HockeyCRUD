# HockeyCRUD - MVC 

## Recreation guide:
Create controller and views for the model you scaffold using Visual Studio (look below if you need help scaffolding).
   Resource: https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/database-first-development/generating-views
   - In the view that you generate, display the image from the database within an \<img src\> tag. By default, your image may be shown simply as an URL. But make sure you embed it within an img tag to be displayed as an image.
     
## Scaffolding
After you create your project successfully, right click the controller folder and choose 'add scaffolded item'.

## Connecting to MySQL
`Scaffold-DbContext "server=127.0.0.1;uid=root;database=[DatabaseNameWithoutSquareBrackets];port=[portNoWithoutBrackets]”MySql.EntityFrameworkCore -OutputDir Models -f`

## Video Demo:

https://github.com/Kurayami7/HockeyCRUD/assets/124408792/4478115d-dab0-4f7d-86bf-219dc75a4864

