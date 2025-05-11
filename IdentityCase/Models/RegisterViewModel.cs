namespace IdentityCase.Models
{
    // AppUser Tablosundan register işlemi sırasında kayıt olurken mutlaka girilmesi gereken değerler
    //İhtiyacımız olmayan propertyleri çağırmak zorunda kalmadık. Sadece üzerinde işlem yapacağımız propertyleri çağırdık

    // Solid Prensibi Neye ihtiyacın varsa onu çağır, çağırdığını kullan!!
    //clean code
    public class RegisterViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        
    }
}
