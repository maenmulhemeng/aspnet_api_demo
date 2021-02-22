# aspnet_api_demo
It is demo of an ASP.NET Core 3.1 demo as a code challenge.   

# AWS  
According to the question of AWS. I have to mention that we don't have an AWS account in our company. However, I am familiar with deploying the projects from GitHub to Azure App Service using GitHub Actions as well as deplying to GCP.  
It is not a big deal to handle the deployment to AWS in case you prefer it.

# The projects

You can find in the composer file that I build the API and set the Console as comment. My machine configured to Docker Host Server for Linux so I got an error because of the collision in the configurateion. 
Well, if you can build it on your machine so please just un-comment the lines in the Docker Composer files and it must be built successfully. 

## The Console application
It has the Switch statment question

## The APi web application

I build it with repect to a scpific structure:  
1- Controllers  
2- Business Layers  
3- Access Layers   
4- Models   
5- Vistual Database in the service folder  

I added two models, two access layers classes, two businesss layers classes and of course one controller. Of course we can use Entity Framework but I just solved like this to open the question of the architecture. 

# Thanks

Thank you for your time
