namespace HomeWork_14.Practice
{
    internal class BirdCount
    {
        private int[] birdsPerDay;

        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public int BusyDays()
        {
            int busyDayCount = 0;
            foreach (int count in birdsPerDay)
            {
                if (count >= 5)
                {
                    busyDayCount++;
                }
            }
            return busyDayCount;
        }

        public static int[] LastWeek()
        {
            return new int[] { 0, 2, 5, 3, 7, 8, 4 };
        }
    }
}
