using System.ComponentModel.DataAnnotations;

namespace ProvidersDomain.Extensions.ValidationAttributes
{
    public class INNAttribute : ValidationAttribute
    {
        private readonly int[] arrMul10 = { 2, 4, 10, 3, 5, 9, 4, 6, 8 };
        private readonly int[] arrMul121 = { 7, 2, 4, 10, 3, 5, 9, 4, 6, 8 };
        private readonly int[] arrMul122 = { 3, 7, 2, 4, 10, 3, 5, 9, 4, 6, 8 };
        public override bool IsValid(object value)
        {
            if (!long.TryParse(value as string, out var inn)) return false;
            
            if (inn < 1000000000 || inn >= 1000000000000)
                return false;

            int digits = (int)Math.Log10(inn) + 1;
            if (!(digits == 10 || digits == 12))
                return false;

            // вычисляем контрольную сумму
            string s = inn.ToString("D" + digits.ToString());
            int[] factors = digits == 10 ? arrMul10 : arrMul122;

        startCheck:

            long sum = 0;
            for (int i = 0; i < factors.Length; i++)
                sum += byte.Parse(s[i].ToString()) * factors[i];
            sum %= 11;
            sum %= 10;
            if (sum != byte.Parse(s[factors.Length].ToString()))
                return false;
            else if (digits == 12)
            {
                // используется маленький трюк:
                // запускается повторная проверка, начиная с метки startCheck,
                // но с другими коэффициентами, а чтобы исключить повторный вход 
                // в эту ветку, сбрасываем digits
                factors = arrMul121;
                digits = 0;
                goto startCheck;
            }
            else
                return true;
        }
    }
}
