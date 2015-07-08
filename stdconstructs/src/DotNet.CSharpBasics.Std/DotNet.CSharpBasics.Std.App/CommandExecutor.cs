/*
 * CommandExecutor.cs
 * 
 * Contains a definition of simple class: CommandExecutor.
 * 
 * This code is intended for demonstration purposes, to help
 * students in studying courses like Computer Programming 
 * Basics and/or System Programming Basics.
 * Code should not be seriously considered for production use.
 * 
 * Author: Denis Belikov
 * 
**/

using System;

namespace DotNet.CSharpBasics.Std.App
{
    /// <summary>
    /// This is a docstring for <see cref="CommandExecutor"/> class.
    /// </summary>
    public class CommandExecutor
    {
        /// <summary>
        /// This is a docstring for GetCurrentDate() method.
        /// </summary>
        /// <returns><see cref="System.String"/> Long representation of current date.</returns>
        public string GetCurrentDate()
        {
            return DateTime.Now.ToLongDateString();
        }
        /// <summary>
        /// This is a docstring for GetComputerName() method.
        /// </summary>
        /// <returns><see cref="System.String"/> NetBIOS name of local computer.</returns>
        public string GetComputerName()
        {
            return Environment.MachineName;
        }
        /// <summary>
        /// This is a docstring for GetOperatingSystemName() method.
        /// </summary>
        /// <returns><see cref="System.String"/> Combined value of OS platform identifier, version and service pack info.</returns>
        public string GetOperatingSystemName()
        {
            return Environment.OSVersion.VersionString;
        }
    }
}
