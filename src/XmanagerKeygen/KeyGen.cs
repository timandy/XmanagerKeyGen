using System;

namespace XmanagerKeygen
{
    public class KeyGen
    {
        private static readonly Random random = new Random();

        private static int charToInt(char ch)
        {
            return ch - '0';
        }

        private static int GetChecksum(string preProductKey)
        {
            if (preProductKey == null)
                throw new ArgumentNullException(nameof(preProductKey));
            if (preProductKey.Length < 10)
                throw new ArgumentException("length must greater than 10.", nameof(preProductKey));
            int checksum = 1;
            foreach (char item in preProductKey)
            {
                if (item != '-' && item != '8' && item != '9')
                {
                    int place = charToInt(item);
                    checksum = (9 - place) * checksum % -1000;
                }
            }
            return (checksum + charToInt(preProductKey[9])) % 1000;
        }

        public static string GenerateKey(ProductCode productCode, int version, int numberOfLicense, DateTime issueDate)
        {
            if (numberOfLicense < 0 || numberOfLicense > 999)
                throw new ArgumentException("must vary from 0 to 999.", nameof(numberOfLicense));
            if (issueDate.Year < 2002)
                throw new ArgumentException("cannot be earlier than 2002.", nameof(issueDate));
            if (issueDate > DateTime.Now.AddDays(7).Date)
                throw new ArgumentException("cannot be later than today after a week.", nameof(issueDate));

            foreach (Product item in ProductCollection.Default)
            {
                if (item == null)
                    continue;
                if (item.Code == productCode && item.Version == version)
                {
                    if (item.PublishDate > issueDate)
                        throw new ArgumentException("cannot be earlier than the publish date.", nameof(issueDate));
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
