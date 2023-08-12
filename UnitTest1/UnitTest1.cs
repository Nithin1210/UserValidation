using UserValidation;

namespace UserRegistrationTest
{
    public class Tests
    {
        static string[] Allemails = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };

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
                [Test]
        public void TestSampleEmails()
        {
            ValidationUser userReg = new ValidationUser();
            foreach (string s in Allemails)
            {
                bool valid = userReg.uc3Validation(s);
                Assert.IsTrue(valid);
            }
        }
    }
}