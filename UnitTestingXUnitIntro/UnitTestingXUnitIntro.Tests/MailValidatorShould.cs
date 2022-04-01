using Xunit;
namespace UnitTestingXUnitIntro.Tests
{
    public class MailValidatorShould
    {
        //[Fact]
        //public void ValidateValidEmails()
        //{
        //    //Arrange
        //    var mailValidator = new MailValidator();
        //    string emailAddress = "thecodercaveok@gmail.com";
        //    //Act
        //    bool isValid = mailValidator.IsValidEmail(emailAddress);
        //    //Assert
        //    Assert.True(isValid,$"{emailAddress} is not valid");

        //}
        //[Fact]
        //public void InvalidateInvalidEmails()
        //{
        //    //Arrang
        //    var mailValidator = new MailValidator();
        //    string emailAddress = "invalid@gmai.com";

        //    //Act
        //    bool isValid = mailValidator.IsValidEmail(emailAddress);

        //    Assert.False(isValid, $"{emailAddress} is valid");
        //}

        //This was represents the two test up
        [Theory]
        [InlineData("invalid@invalid.invalid", false)]
        [InlineData("thecodercave@gmail.com", true)]
        public void ValidateEmail(string emailAddress, bool expected)
        {
            //Arrange
            var mailValidator = new MailValidator();

            //Act
            bool isValid = mailValidator.IsValidEmail(emailAddress);

            //Asserts
            Assert.Equal(expected, isValid);
        }

        [Theory]
        [InlineData("spam@gmail.com","INBOX")]
        [InlineData("spam@spam.com", "SPAM")]
        public void IdentifySpam(string emailAddress,string expected)
        {
            //Arrange
            var mailValidator = new MailValidator();

            //Act
            string result = mailValidator.IsSpam(emailAddress);

            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void RaiseErrorWhenEmailIsEmpty()
        {
            //Arrange
            var mailValidator = new MailValidator();
            //Act


            //Assert
            Assert.Throws<EmailNotProvidedException>(() => mailValidator.IsValidEmail(null));
        }
    }
}
