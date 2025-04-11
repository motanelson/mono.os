using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;
using System.Diagnostics;
using System;
namespace cmds{
	
	class monoos{
		public class Program{
                    static void Main(string[] args){
                        bool t=true;
                        int n=0;
                        int nn=0;
                        String s="";
                        Console.BackgroundColor=ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.WriteLine("mono os ");
                        while(t){
                            Console.Write(":>");
                            s=Console.ReadLine();
                            if (s.IndexOf("exit")>-1){
                                t=false;
                            }else{
                                try{
                                    ProcessStartInfo psi = new ProcessStartInfo();
	                                psi.FileName = "cmd.exe" ;
	                                psi.UseShellExecute = false;
	                                psi.Arguments ="/C "+s+ "" ;
	                                psi.RedirectStandardOutput = false;
	                                Process p = Process.Start(psi);
	                                p = Process.Start(psi);
	                                Console.WriteLine(p.StandardOutput.ReadToEnd());
	                                p.WaitForExit();
	                                p.Close();
                                }catch(Exception ee ){
	                                 Console.WriteLine("ERROR ");
	                            }
                            }
                        }
                    }
                
                }
            }
        }
    
    
