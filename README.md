# AzureTokenMaker
## Purpose ##
The purpose of this repo is to house a simple tool for generating client and user tokens for testing applications that use Azure Active Directory for authentication/identity. This is designed ONLY for testing. I don't recommend using it with production credentials (unless you don't make use of the 'Profile' feature of the app) as they are stored in clear text on your machine in the user data folder of Windows.

It also has a Json Web Token decoder so you can see all of the claims that are in your generated tokens, or other tokens you find laying around cyberspace.

##Screenshots##
![enter image description here](https://lh3.googleusercontent.com/_gUBJAjofXV3ypxxCh3tQBAvw9WatN52Q3SI82fR3bc=s0 "A not so sexy screenshot on Windows 2008 Server R2.")
##Technologies and Dependencies##
This is a simple Windows .NET 4.5 desktop application built in C# (WinForms) and Visual Studio 2012. In addition to the full version of .NET framework v4.5 (not client profile), it uses the Active Directory Authentication Library provided by Microsoft, and the Json.Net library from Newtonsoft.