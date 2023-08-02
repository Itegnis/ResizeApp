namespace VideoApp
{
    public class ResizeApp
    {
        public static void Resize<T>(ref T[] array, int newSize)
        {
             T[] newArray = new T[newSize];

            for (int i = 0; i < newSize && i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
        static void Main(string[] args)
        { 
            int[] MyArray = { 1, 2, 3, 4, 5 };
            //string[] MyArray = { "a", "b", "c" };
            Resize(ref MyArray, 2);
            Console.WriteLine();
        }
    }
}