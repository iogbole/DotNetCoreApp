# AppDynamics Sample DotNetCoreApp 

1. Install the AppDynamics.Agent.Windows NuGet package in your project. See your IDE documentation for instructions.

2. Set up your Environment Variables for your system application:

  CORECLR_ENABLE_PROFILING=1
  CORECLR_PROFILER={39AEABC1-56A5-405F-B8E7-C3668490DB4A}
  CORECLR_PROFILER_PATH_32=<actual_path>\AppDynamics.Profiler_x86.dll
  CORECLR_PROFILER_PATH_64=<actual_path>\AppDynamics.Profiler_x64.dll
  Where <actual_path> is the complete path to the AppDynamics.Profiler dll.

3a. Open the AppDynamicsConfig.json file and update the file with your AppDynamics Controller information 

OR

3b. [ Use Evironment Variables ](https://docs.appdynamics.com/display/AZURE/Install+the+AppDynamics+Azure+Site+Extension+for+.NET#InstalltheAppDynamicsAzureSiteExtensionfor.NET-envvariable)
