namespace wild_hog
{
    internal static class Program
    {
        public static string file_path;
        public static bool should_hog = false;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            while (true)
            {
                // Check if file path valid.

                // If file path valid, open the file with exclusive access.
                // Notify user if open fails.
            }
        }
    }
}