using System;
using System.Security.Cryptography;
using System.Text;
using WindowsFormsFinanseSystem.Interfaces;


namespace WindowsFormsFinanseSystem.BusinessLogic
{
    [Serializable]
    public class User : IUser
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Хэш пароля
        /// </summary>
        private string _password_hash;

        /// <summary>
        /// Возвращает объект класса User
        /// </summary>
        /// <param name="name">Имя пользователя</param>
        /// <param name="login">Логин</param>
        public User(string name, string login, string password_hash)
        {
            Name = name;
            Login = login;
            _password_hash = password_hash;
        }

        /// <summary>
        /// Присваивает паролю хэш
        /// </summary>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        public static string CalcHash(string password)
        {
                using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                    sb.Append(hashBytes[i].ToString("X2"));
                return sb.ToString();
            }
        }

        /// <summary>
        /// Проверяет логин и пароль на валидность
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        public bool CheckPassword(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login)) return false;
            if (string.IsNullOrWhiteSpace(password)) return false;
            string password_hash = CalcHash(password);
            return Login == login && _password_hash == password_hash;
        }
    }
}
