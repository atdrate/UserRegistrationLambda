namespace UserRegistrationEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option:\n1.Valid first name\n2.Valid last name\n3.Valid Email\n4.Valid Mobile number(+91 7234567890)\n5.Minimum 8 characters\n6.At least 1 upper case\n7.At least 1 numberic value\n8.At least 1 special character\n9.Email sample");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ValidFirstName.ValidateFirstName();
                    break;
                case 2:
                    ValidLastName.ValidateLastName();
                    break;
                case 3:
                    ValidEmail.ValidateEmail();
                    break;
                case 4:
                    ValidPhone.ValidateMobileNumber();
                    break;
                case 5:
                    Rule1.ValidatePassword();
                    break;
                case 6:
                    Rule2.ValidatePassword();
                    break;
                case 7:
                    Rule3.ValidatePassword();
                    break;
                case 8:
                    Rule4.ValidatePassword();
                    break;
                case 9:
                    ValidEmailSample validate = new ValidEmailSample();
                    foreach (string mail in validate.GetList())
                    {
                        Console.Write(mail + " : ");
                        validate.PrintResult(validate.ValidateEmail2(mail));
                    }
                    break;
                case 13:
                    List<ValidUserLambda> listPerson = new List<ValidUserLambda>();
                    ValidUserLambda.AddRecords(listPerson);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
        }
    }
}