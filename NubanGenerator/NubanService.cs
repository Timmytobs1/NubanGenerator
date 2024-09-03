namespace NubanGenerator
{
    public class NubanService
    {
        public int CalculateNubanCheckDigit(string institutionCode, string accountSerialNumber)
        {
            if (institutionCode.Length != 6 || accountSerialNumber.Length != 9)
                throw new ArgumentException("Invalid institution code or account serial number length.");

            string nuban = institutionCode + accountSerialNumber;
            int[] multipliers = { 3, 7, 3, 3, 7, 3, 3, 7, 3, 3, 7, 3, 3, 7, 3 };
            int sum = 0;

            for (int i = 0; i < nuban.Length; i++)
            {
                sum += (nuban[i] - '0') * multipliers[i];
            }

            int mod = sum % 10;
            int checkDigit = 10 - mod;
            return checkDigit == 10 ? 0 : checkDigit;
        }

        public string GenerateNuban(string institutionCode, string accountSerialNumber)
        {
            int checkDigit = CalculateNubanCheckDigit(institutionCode, accountSerialNumber);
            return accountSerialNumber + checkDigit.ToString();
        }
    }
}
