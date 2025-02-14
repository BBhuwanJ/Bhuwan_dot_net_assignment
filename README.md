
# Online Voting System with ASP.NET Core & MySql Server 

### This is .Net project of Online Voting System as a part of assignment.

### Actions I have performed:
1 - Add Identity matrics thorught Scaffolded item 
2 - Add properties inside OnlineVotingSystemUser.cs like name, address, isVoter etc
3 - Create a DbInitializer Class in Models, and Set the identity of of Admin, Candidate, Voter and set the admin UserName and Password
4 - Make small changes in main Program.cs
5 - add-migration Init
6 - update-database
7 - Add all the properties into Register.cshtml.cs
8 - Created Register page and registration form in Register.cshtml
9 - Inlcude _LoginPartial components in _Layout.cshtml
10 - Then, In register.cshtml.cs we take inputs from user as in email, username, password, address and profile picture, and since we
	can't just add profile picture,we upload that picture in wwwroot>Images and give the string Imagepath to the user.ProfileImage.
	Remember: System ma jaane chai string nai ho, but upload garda kheri matra IFormFile format use garne ho since it is file.
	entype ma pani multipart/formdata user garni
11 - AddToRoleAsync, Add to role in Register.cshtml.cs
12 - Add Admin Controller into Controllers folder  and allow if only Admin, to list all the non Admin lists
13 - Create a ViewModel folder inside the project and add class to it name "ConvertApplicationUser"
14 - Add Razor page to the ViewVoters in Admin.cs


## User Identity Attribute Table (with Primary key)

![image alt](https://github.com/BBhuwanJ/Bhuwan_dot_net_assignment/blob/b82bc6c1c61effa20c43f0cba63734de15166382/Assest/Screenshot%202025-02-14%20145020.png)

# Program Screenshots

## Home Page
![image alt](https://github.com/BBhuwanJ/Bhuwan_dot_net_assignment/blob/aefda63dd2f582ee9ab6748e4f91b5a19e23396b/Assest/Screenshot%202025-02-14%20141642.png)


Submitted By:<br/>
Bhuwan Prasad Joshi <br/>
21075406<br/>
Everest Engineering College<br/>

