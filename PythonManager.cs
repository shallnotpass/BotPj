using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotProject
{
    public class PythonManager
    {
        String cmd = @"-u C:/Users/User/Desktop/практика/ChatBotProject/ChatBotProject/ConsolePy/bin/Debug/netcoreapp3.1/pyscript2.py";
        public PythonManager()
        {
            /*
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Users\User\AppData\Local\Programs\Python\Python38\python.exe",
                    Arguments = string.Format("{0} {1}", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pyscript2.py"), "who are you?"),
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false
                },
                EnableRaisingEvents = true
            };
            process.ErrorDataReceived += Process_OutputDataReceived;
            process.OutputDataReceived += Process_OutputDataReceived;

            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            //process.WaitForExit();
            Console.Read();*/
        }
        public String SendMessage(String input)
        {
                System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
                start.FileName = @"C:\Users\User\AppData\Local\Programs\Python\Python38\python.exe";
                start.Arguments = string.Format("{0} {1}", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "new.py"), input);
                start.UseShellExecute = false;
                start.CreateNoWindow = true; 
                start.RedirectStandardOutput = true;
                start.RedirectStandardError = true; 
                start.LoadUserProfile = true;
                using (System.Diagnostics.Process process = System.Diagnostics.Process.Start(start))
                {
                    string stderr = process.StandardError.ReadToEnd(); 
                    string result = process.StandardOutput.ReadToEnd(); 
                    return result;
                }
        }
    }
}
