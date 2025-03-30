namespace Framework {
	internal static class Program {
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
#pragma warning disable CA1416 // プラットフォームの互換性を検証
			Application.Run(new Form1());
#pragma warning restore CA1416 // プラットフォームの互換性を検証
		}
	}
}