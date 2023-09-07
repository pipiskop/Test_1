using System.Linq;

namespace ParolTest
{
    public class Parol
    {
        public int Check(string Parol)
        {
            int Ochko = 0;

            if (CheckSmallSymbol(Parol))
                Ochko++;

            if (CheckBigSymbol(Parol))
                Ochko++;

            if (CheckNumbers(Parol))
                Ochko++;

            if (CheskSpecial(Parol))
                Ochko++;

            if (CheckDlina(Parol))
                Ochko++;

            return Ochko;
        }

        private bool CheckSmallSymbol(string Parol)
        {
            return Parol.Any(m => char.IsLower(m));
        }

        private bool CheckBigSymbol(string Parol)
        {
            return Parol.Any(m => char.IsUpper(m));
        }

        private bool CheckNumbers(string Parol)
        {
            return Parol.Any(m => char.IsDigit(m));
        }

        private bool CheskSpecial(string Parol)
        {
            return Parol.Any(m => !char.IsLetterOrDigit(m));
        }

        private bool CheckDlina(string Parol)
        {
            return Parol.Length >= 7;
        }
    }
}
