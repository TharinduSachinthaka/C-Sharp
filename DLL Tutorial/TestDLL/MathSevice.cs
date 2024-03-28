namespace TestDLL
{
    public static class MathService
    {
        public static int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }

        public static int Multiply(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("At least one number must be provided.");
            }

            int result = 1;
            foreach (int num in numbers)
            {
                result *= num;
            }
            return result;
        }

        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public static int Subtract(int minuend, params int[] subtrahends)
        {
            foreach (int num in subtrahends)
            {
                minuend -= num;
            }
            return minuend;
        }
    }
}
