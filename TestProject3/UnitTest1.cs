using System.Security.Cryptography.X509Certificates;
using UserRegistrationEx;

namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
          static  void GivenUserFistName_WhenValidate_ShouldReturnTrue()
            {
                //Arrange
                ValidUser user = new ValidUser();
                string firstName = "Subodh";
                //Act
                bool result = user.ValidateFirstName(firstName);
                //Assert
                Assert.IsTrue(result);
                Console.WriteLine(result);
            }
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string lastName = "Nagalwade";
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string email = "SubodhNagalw4888@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string mobileNumber = "91 9876543210";
            //Act
            bool result = user.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string password = "Subodhl@543";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        //Sad Test Cases(Test Cases Fail The Entry)
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string firstName = "subodh";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string lastName = "nagalwde";
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string email = "Subodhnagalwade.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string mobileNumber = "91 0876543210";
            //Act
            bool result = user.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string password = "subodh@#543";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsFalse(result);

         [TestMethod]
            [DataRow("abc@yahoo.com")]
            [DataRow("abc-100@yahoo.com")]
            [DataRow("abc.100@yahoo.com")]
            [DataRow("abc111@abc.com")]
            [DataRow("abc.100@abc.com.au")]
            [DataRow("abc-100@abc.net")]
            [DataRow("abc@1.com")]
            [DataRow("abc@gmail.com.com")]
            [DataRow("abc+100@gmail.com")]
            static void GivenEmailIds_WhenValidate_ShouldReturnTrue(string email)
            {
                //Arrange
                ValidUser user = new ValidUser();
                //Act
                bool result = user.ValidateEmail2(email);
                //Assert
                Assert.IsTrue(result);
            }
        }
    }
}