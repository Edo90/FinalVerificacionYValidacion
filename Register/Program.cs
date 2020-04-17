using System;

namespace Register
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterModel registerModel = new RegisterModel();
            registerModel.FirstName = "test";
            registerModel.LastName = "test2";
            registerModel.DateOfBirth = DateTime.Now;
            RegisterService service = new RegisterService();

            if (service.IsRegisterModelValid(registerModel))
            {
                Console.WriteLine("El modelo es valido");
            }
            else
            {
                throw new Exception("Modelo invalido");
            }
            
        }
    }
}
