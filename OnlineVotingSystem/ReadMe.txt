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
11 - 