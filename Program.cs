namespace AlgoritmoVentas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> data = [185.50, 250.36, 163.45, 535.20, 950.22, 450.38];
            List<string> days = ["Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"];

            FindBestDay(data, days, out string best_day);
            FindWorstDay(data, days, out string worst_day);
            SundayAboveAverage(data, out bool is_above_average);

            Console.WriteLine(String.Format("{0} {1} {2}", best_day, worst_day, is_above_average ? "Si": "No"));
        }

        static void FindBestDay(List<double> data, List<string> days, out string best_day) {
            best_day = days[data.IndexOf(data.Max())];
        }
        static void FindWorstDay(List<double> data, List<string> days, out string worst_day) {
            worst_day = days[data.IndexOf(data.Min())];
        }
        static void SundayAboveAverage(List<double> data, out bool is_above_average) {
            Stack<double> data_stack = new(data);
            double sunday_data = data_stack.Pop();
            is_above_average = sunday_data > data.Average();
        }
    }
}
