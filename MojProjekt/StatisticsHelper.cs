namespace MojProjekt
{
    public static class StatisticsHelper
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static double CalculateAverage(int[] values)
        {
            if (values.Length == 0) return 0;

            int sum = 0;
            foreach (var v in values)
                sum += v;

            return (double)sum / values.Length;
        }

        public static int CalculateMax(int[] values)
        {
            if (values.Length == 0) return 0;

            int max = values[0];
            foreach (var v in values)
            {
                if (v > max)
                    max = v;
            }

            return max;
        }

        public static int CalculateMin(int[] values)
        {

            int min = values[0];
            foreach (var v in values)
            {
                if (v < min)
                    min = v;
            }

            return min;
        }
    }
}