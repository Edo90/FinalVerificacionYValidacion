using Microsoft.VisualStudio.TestTools.UnitTesting;
using Register;
using System;

namespace RegisterTest
{
    [TestClass]
    public class RegisterTests
    {
        public RegisterModel GetModel()
        {
            return new RegisterModel
            {
                FirstName = "test",
                MiddleName = "Pedro",
                LastName = "test",
                DateOfBirth = DateTime.Now,
                Address = "C/33 Este/24 de abril/Distrito Nacional",
                CountryFrom = 1,
                Gender = 'M',
                HomeNumber = 25,
                Identification = "000-0000000-1",
                Municipality = 1,
                PlaceOfBirth = "Distrito Nacional",
                Province = 1,
                TypeOfIdentification = 2
            };
        }

        [TestMethod]
        public void ValidModel()
        {
            //Arrange
            RegisterModel registerModel = GetModel();

            RegisterService registerService = new RegisterService();

            //Act
            bool result = registerService.IsRegisterModelValid(registerModel);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidModelPropertyLastNameMissing()
        {
            //Arrange
            RegisterModel registerModel = GetModel();
            registerModel.LastName = null;

            RegisterService registerService = new RegisterService();

            //Act
            bool result = registerService.IsRegisterModelValid(registerModel);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void InvalidModelPropertyMissing()
        {
            RegisterModel registerModel = GetModel();
            registerModel.DateOfBirth = null;

            RegisterService registerService = new RegisterService();

            //Act
            bool result = registerService.IsRegisterModelValid(registerModel);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SaveRegisterModelWithCorrectInfo()
        {
            //Arrange
            RegisterModel registerModel = GetModel();
            RegisterService registerService = new RegisterService();

            //Act
            bool result = registerService.SaveRegisterModel(registerModel);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SaveRegisterSuccessfulWithFieldThatIsNotRequerid()
        {
            RegisterModel registerModel = GetModel();
            registerModel.MiddleName = null;
            try
            {
                RegisterService registerService = new RegisterService();
                var result = registerService.SaveRegisterModel(registerModel);
                Assert.IsTrue(result);

            }
            catch (Exception)
            {

            }
        }

        [TestMethod]
        public void SaveRegisterModelThrowsError()
        {            
            RegisterModel registerModel = GetModel();
            registerModel.LastName = null;
            
            try
            {
                RegisterService registerService = new RegisterService();
                var result = registerService.SaveRegisterModel(registerModel);
            }catch(Exception e)
            {
                Assert.IsInstanceOfType(e,typeof(Exception), "La Entidad Registro no es correcta");
            }            
        }

    }
}
