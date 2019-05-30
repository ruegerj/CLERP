export class User {
    Id: string;
    Username: string;
    Roles: string[];
    Token?: string;

    constructor( id: string, username: string, roles: string[], token?: string){
        this.Id = id;
        this.Username = username;
        this.Roles = roles;
        this.Token = token;
    }
}