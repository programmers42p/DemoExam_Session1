using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.model;

namespace WpfApp1.common
{
    class Levi
    {
        public static int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;
        public static int LevenshteinDistance(string firstWord, string secondWord)
        {
            Console.WriteLine("-----start levi ------------");
            Console.WriteLine(firstWord);
            Console.WriteLine(secondWord);
            Console.WriteLine("-----end levi ------------");
            var n = firstWord.Length + 1;
            var m = secondWord.Length + 1;
            var matrixD = new int[n, m];

            const int deletionCost = 1;
            const int insertionCost = 1;

            for (var i = 0; i < n; i++)
            {
                matrixD[i, 0] = i;
            }

            for (var j = 0; j < m; j++)
            {
                matrixD[0, j] = j;
            }

            for (var i = 1; i < n; i++)
            {
                for (var j = 1; j < m; j++)
                {
                    var substitutionCost = firstWord[i - 1] == secondWord[j - 1] ? 0 : 1;

                    matrixD[i, j] = Minimum(matrixD[i - 1, j] + deletionCost,          // удаление
                                            matrixD[i, j - 1] + insertionCost,         // вставка
                                            matrixD[i - 1, j - 1] + substitutionCost); // замена
                }
            }

            return matrixD[n - 1, m - 1];
        }
        public static string getNameFromObkect(object obj) {
   
            if (obj == null) {
                return "";
           }
            if (obj is User) { 
                return ((User)obj).name?.Trim().ToLower() ;
            }
            if (obj is Realtor) {
                return ((Realtor)obj).name?.Trim().ToLower();
            }
            return "";
        }
        public static string getLastNameFromObkect(object obj)
        {

            if (obj == null)
            {
                return "";
            }
            if (obj is User)
            {
                return  ((User)obj).lastName?.Trim().ToLower() ;
            }
            if (obj is Realtor)
            {
                return ((Realtor)obj).lastName?.Trim().ToLower();
            }
            return "";
        }
        public static string getPatronymicFromObkect(object obj)
        {

            if (obj == null)
            {
                return "";
            }
            if (obj is User)
            {
                return ((User)obj).patronymic?.Trim().ToLower();
            }
            if (obj is Realtor)
            {
                return ((Realtor)obj).patronymic?.Trim().ToLower();
            }
            return "";
        }
        public static string getFioFromObject(object obj)
        {

            if (obj == null)
            {
                return "";
            }
            return getLastNameFromObkect(obj) + getNameFromObkect(obj)+ getPatronymicFromObkect(obj);
        }

        public static string[] GetLeviData(string lastName, string name ,string patronymic,IFIO item) {
            string[] res = new string[2] { "",""};
            string sourse = "";
            string search = "";
            if (item == null) {
                return res;
            }

            if (lastName != null && lastName.Trim().Length != 0)
            {
                search += lastName ;
                sourse += item.lastName ?? "";
            }
            if (name != null && name.Trim().Length != 0)
            {
                search += name;
                sourse += item.name ?? "";
            }
            if (patronymic != null && patronymic.Trim().Length != 0)
            {
                search += patronymic;
                sourse += item.patronymic ?? "";
            }
            
            res[0] = search;
            res[1] = sourse;
            return res;
        }
    }
}
