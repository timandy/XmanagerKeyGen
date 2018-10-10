using System;

namespace XmanagerKeygen
{
    public class KeyGen
    {
        private static readonly Random random = new Random();

        private static int CharToInt(char ch)
        {
            return ch - '0';
        }

        private static int GetChecksum(string preProductKey)
        {
            if (preProductKey == null)
                throw new ArgumentException($"{nameof(preProductKey)} can not be null.");
            if (preProductKey.Length < 10)
                throw new ArgumentException($"{nameof(preProductKey)}'s length cannot less than 10.");

            int checksum = 1;
            foreach (char item in preProductKey)
            {
                if (item != '-' && item != '8' && item != '9')
                {
                    int place = CharToInt(item);
                    checksum = (9 - place) * checksum % -1000;
                }
            }
            return (checksum + CharToInt(preProductKey[9])) % 1000;
        }

        public static string GenerateKey(ProductCode productCode, int version, int numberOfLicense, DateTime issueDate)
        {
            if (numberOfLicense < 0 || numberOfLicense > 999)
                throw new ArgumentException($"{nameof(numberOfLicense)} must in range from 0 to 999.");
            if (issueDate.Year < 2002)
                throw new ArgumentException($"{nameof(issueDate)} cannot be earlier than 2002.");
            if (issueDate > DateTime.Now.AddDays(7).Date)
                throw new ArgumentException($"{nameof(issueDate)} cannot be later than today after a week.");

            foreach (Product item in ProductCollection.Default)
            {
                if (item == null)
                    continue;
                if (item.Code == productCode && item.Version == version)
                {
                    if (item.PublishDate > issueDate)
                        throw new ArgumentException($"{nameof(issueDate)} cannot be earlier than the publish date.");
                    break;
                }
            }

            int rand = random.Next(0, 999);
            string preProductKey = $"{issueDate:yyMMdd}-{0x0B:D2}{(int)productCode:D1}{rand:D3}-{numberOfLicense:D3}";
            int checksum = GetChecksum(preProductKey);
            return $"{preProductKey}{checksum:D3}";
        }
    }
}
