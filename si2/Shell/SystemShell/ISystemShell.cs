
namespace Shell.SystemShell {
	internal interface ISystemShell :IDisposable {
		internal ESystemShellType ShellType{ get; }
		/// <summary>
		///アプリ内での管理名
		/// </summary>
		internal string Name{ get; }
		internal IScriptResult Exec(ICommandLine commandLine);
		internal IScriptResult Exec(IScript script);
		internal new void Dispose();
	}
}
