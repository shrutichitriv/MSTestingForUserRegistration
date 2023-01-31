using MsTestUserRegistration;

namespace UserTest
{
    [TestClass]
    public class UnitTest1
    {
        UserRegistrationDetails user;
        [TestMethod]
        public void Setup()
        {
            user = new UserRegistrationDetails();
        }
       
        [TestMethod]
        public void FirstName()
        {
            // Arrange 
            bool expected = true;
            string name = "Shruti";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateFirstName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void LastName()
        {
            // Arrange 
            bool expected = true;
            string name = "Chitriv";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateLastName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Email()
        {
            // Arrange 
            bool expected = true;
            string email = "shrutichitriv@gmail.com";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MobileNumber()
        {
            // Arrange 
            bool expected = true;
            string mobile = "91 7773456789";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateMobileNumber(mobile);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Password()
        {
            // Arrange 
            bool expected = true;
            string password = "abcdfghihgE1@";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}