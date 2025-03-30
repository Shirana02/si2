using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace Shell.SystemShell.PowerShell {
	internal class PSWrapper {
		Runspace r;
		internal PSWrapper(){
			r = RunspaceFactory.CreateRunspace();
			r.Dispose();
		}
	}
}
