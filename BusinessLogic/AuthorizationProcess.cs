using System;
using System.Collections.Generic;
using WindowsFormsFinanseSystem.BaseDate;
using WindowsFormsFinanseSystem.Interfaces;

namespace WindowsFormsFinanseSystem.BusinessLogic
{
    public static class AuthorizationProcess
    {
        /// <summary>
        /// Ищет и проверяет пароль
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        public static IUser FindAndCheckPassword(string login, string password)
        {
            List<User> _users = UsersRepository.Instance.Users;
            if (_users == null || _users.Count == 0)
                return null;

            foreach (User us in _users)
            {
                if (us.CheckPassword(login, password))
                {
                    return us;
                }
            }
            return null;
        }

        /// <summary>
        /// Регистрирует ногово пользователя
        /// </summary>
        /// <param name="fio">ФИО</param>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        public static void RegisterUser(string fio, string login, string password)
        {
            string pass_hash = User.CalcHash(password);
            User user = new User(fio, login, pass_hash);

            try
            {
                UsersRepository.Instance.RegisterUser(user);
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось создать пользователя!", ex);
            }
        }
    }
}
