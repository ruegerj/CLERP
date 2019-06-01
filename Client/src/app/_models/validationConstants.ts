export class ValidationConstans{
    public static MinNameLength: number = 2;
    public static MaxNameLength: number = 100;
    public static MinUsernameLength: number = 5;
    public static MaxUsernameLength: number = 15;    
    public static  MinPasswordLength: number = 10;
    public static  MaxPasswordLength: number = 50;
    public static PhoneNumberRegex: string = '^([\+][0-9]{1,3}([ \.\-])?)?([\(]{1}[0-9]{3}[\)])?([0-9A-Z \.\-]{1,32})((x|ext|extension)?[0-9]{1,4}?)$';
}