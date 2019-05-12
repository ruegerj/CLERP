export class Employee{
    public LastName : string;
    public FirstName : string;
    public Email : string;
    public PhoneNr : string;
    public Birthday : string;
    public Username: string;
    public Password : string;

    

    constructor(lastName : string, firstName : string, email : string, 
        phoneNr : string, birthday : string, 
        username : string, password : string = null)
    {
        this.LastName = lastName;
        this.FirstName = firstName;
        this.Email = email;
        this.PhoneNr = phoneNr;
        this.Birthday = birthday;
        this.Username = username;
        this.Password = password;
    }
}