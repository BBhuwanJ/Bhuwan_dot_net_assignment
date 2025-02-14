
# Online Voting System with ASP.NET Core & MySql Server 

### This is .Net project of Online Voting System as a part of assignment.

### Actions I have performed:
1 - Add Identity matrics thorught Scaffolded item <br/>
2 - Add properties inside OnlineVotingSystemUser.cs like name, address, isVoter etc<br/>
3 - Create a DbInitializer Class in Models, and Set the identity of of Admin, Candidate, Voter and set the admin UserName and Password<br/>
4 - Make small changes in main Program.cs<br/>
5 - add-migration Init<br/>
6 - update-database<br/>
7 - Add all the properties into Register.cshtml.cs<br/>
8 - Created Register page and registration form in Register.cshtml<br/>
9 - Inlcude _LoginPartial components in _Layout.cshtml<br/>
10 - Then, In register.cshtml.cs we take inputs from user as in email, username, password, address and profile picture, and since we
	can't just add profile picture,we upload that picture in wwwroot>Images and give the string Imagepath to the user.ProfileImage.
	Remember: System ma jaane chai string nai ho, but upload garda kheri matra IFormFile format use garne ho since it is file.
	entype ma pani multipart/formdata user garni<br/>
11 - AddToRoleAsync, Add to role in Register.cshtml.cs<br/>
12 - Add Admin Controller into Controllers folder  and allow if only Admin, to list all the non Admin lists<br/>
13 - Create a ViewModel folder inside the project and add class to it name "ConvertApplicationUser"<br/>
14 - Add Razor page to the ViewVoters in Admin.cs<br/>


## User Identity Attribute Table (with Primary key)

![image alt](https://github.com/BBhuwanJ/Bhuwan_dot_net_assignment/blob/b82bc6c1c61effa20c43f0cba63734de15166382/Assest/Screenshot%202025-02-14%20145020.png)

# Sample Screenshots

## Candidate Register
![image alt](https://github.com/BBhuwanJ/Bhuwan_dot_net_assignment/blob/2ef5f2a74a4895e4ae744db2b178ba564e79b1d6/Assest/CandidateRegister.png)

## Voter Register
![image alt](https://github.com/BBhuwanJ/Bhuwan_dot_net_assignment/blob/2ef5f2a74a4895e4ae744db2b178ba564e79b1d6/Assest/VoterRegister.png)

## Login
![image alt](https://github.com/BBhuwanJ/Bhuwan_dot_net_assignment/blob/2ef5f2a74a4895e4ae744db2b178ba564e79b1d6/Assest/LoginPage.png)



Submitted By:<br/>
Bhuwan Prasad Joshi <br/>
21075406<br/>
Everest Engineering College<br/>

