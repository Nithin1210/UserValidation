using UserValidation;

namespace UserRegistrationTest
{
    public class Tests
    {

        [Test]
        public void TestFirstName()
        {
            ValidationUser userReg = new ValidationUser();
            bool valid = userReg.uc1Validation("Nithin");
            Assert.IsTrue(valid);
            bool invalid = userReg.uc1Validation("ASDAdeR#4565657");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestLastName()
        {
            ValidationUser userReg = new ValidationUser();
            bool valid = userReg.uc2Validation("Reddy");
            Assert.IsTrue(valid);
            bool invalid = userReg.uc2Validation("reddY70");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestEmail()
        {
            ValidationUser userReg = new ValidationUser();
            bool valid = userReg.uc3Validation("abc@yahoo.com");
            Assert.IsTrue(valid);
            bool invalid = userReg.uc3Validation("abc@.csadol");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestPhoneNumber()
        {
            ValidationUser userReg = new ValidationUser();
            bool valid = userReg.uc4Validation("91 1234567890");
            Assert.IsTrue(valid);
            bool invalid = userReg.uc4Validation ("5687687732");
            Assert.IsFalse(invalid);
        }
        [Test]
        public void TestPassword()
        {
            ValidationUser userReg = new ValidationUser();
            bool valid = userReg.uc5Validation("Qwertyuiop@123");
            Assert.IsTrue(valid);
            bool invalid = userReg.uc5Validation("abcdE");
            Assert.IsFalse(invalid);
        }
    }
}