using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsFinanseSystem.BaseDate;
using WindowsFormsFinanseSystem.Interfaces;

namespace WindowsFormsFinanseSystem.BusinessLogic
{
    [Serializable]
    static class FamilyMemberService
    {
        /// <summary>
        /// Получает члена семьи из репозитория
        /// </summary>
        /// <returns></returns>
        public static List<IFamilyMember> GetFamilyMember()
        {
            return FamilyMemberRepository.Instance.BankAccount.Select(t => t as IFamilyMember).ToList();
        }

        /// <summary>
        /// Добавляет члена семьи в репозиторий
        /// </summary>
        /// <returns></returns>
        public static void AddFamilyMember(string name, string typeFamily)
        {
            FamilyMember tran = new FamilyMember(name, typeFamily);
            try
            {
                FamilyMemberRepository.Instance.AddFamilyMember(tran);
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось добавить члена семьи!", ex);
            }
        }

        /// <summary>
        /// Удаляет члена семьи из репозитория
        /// </summary>
        /// <returns></returns>
        public static void RemoveFamilyMember(IFamilyMember account)
        {
            try
            {
                FamilyMemberRepository.Instance.RemoveBankAccount(account as FamilyMember);
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось удалить транзацию!", ex);
            }
        }

        /// <summary>
        /// Изменяет члена семьи
        /// </summary>
        /// <returns></returns>
        public static void EditFamilyMember()
        {
            FamilyMemberRepository.Instance.EditFamilyMember();
        }
    }
}
