using System;
using System.Collections.Generic;
using System.Text;

namespace Register
{
    public class RegisterService
    {
        public bool IsRegisterModelValid(RegisterModel registerModel)
        {
            if (string.IsNullOrEmpty(registerModel.FirstName) || 
                string.IsNullOrEmpty(registerModel.LastName) || 
                string.IsNullOrEmpty(registerModel.DateOfBirth.ToString()) ||
                string.IsNullOrEmpty(registerModel.Address) ||
                registerModel.CountryFrom == 0 || 
                string.IsNullOrEmpty(registerModel.Identification)
                )
            {
                return false;
            }
            return true;
        }

        public bool SaveRegisterModel(RegisterModel registerModel)
        {
            if (IsRegisterModelValid(registerModel))
            {
                SaveModel(registerModel);
                return true;
            }
            else
            {
                throw new Exception("La Entidad Registro no es correcta");
            }
        }

        private void SaveModel(RegisterModel registerModel)
        {
            Console.WriteLine("Guardado!");
        }
    }
}
