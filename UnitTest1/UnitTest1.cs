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
            try
            {
                bool invalid = userReg.uc1Validation("qwerty88");
            }
            catch (UserRegistrationException ex)
            {
                Assert.IsFalse(ex.valid);
            }
        }
    
        [Test]
        public void TestLastName()
        {
            ValidationUser userReg = new ValidationUser();
            bool valid = userReg.uc2Validation("Reddy");
            Assert.IsTrue(valid);
            try
            {
                bool invalid = userReg.uc2Validation("reddY70");

            }
            catch (UserRegistrationException ex)
            {
                Assert.IsFalse(ex.valid);
            }



        }
        [Test]
        public void TestEmail()
        {
            ValidationUser userReg = new ValidationUser();
            bool valid = userReg.uc3Validation("abc@yahoo.com");
            Assert.IsTrue(valid);
            try
            {
                bool invalid = userReg.uc3Validation("abc@.cddd");

            }
            catch (UserRegistrationException ex)
            {
                Assert.IsFalse(ex.valid);
            }

        }
        [Test]
        public void TestPhoneNumber()
        {
            ValidationUser userReg = new ValidationUser();
            bool valid = userReg.uc4Validation("91 1234567890");
            Assert.IsTrue(valid);
            try
            {
                bool invalid = userReg.uc4Validation("5687687732");
            }
            catch (UserRegistrationException ex)
            {
                Assert.IsFalse(ex.valid);
            }
        }
        [Test]
        public void TestPassword()
        {
            ValidationUser userReg = new ValidationUser();
            bool valid = userReg.uc5Validation("Qwertyuiop@123");
            Assert.IsTrue(valid);
            try
            {
                bool invalid = userReg.uc5Validation("abcdE");
            }
            catch (UserRegistrationException ex)
            {
                Assert.IsFalse(ex.valid);
            }
        }
                [Test]
        public void TestSampleEmails()
        {
            ValidationUser userReg = new ValidationUser();
            foreach (string all in Allemails)
            {
                bool valid = userReg.uc3Validation(all);
                Assert.IsTrue(valid);
            }
        }
    }
}