/*
 * Created by Ranorex
 * User: AxT
 * Date: 29/05/2017
 * Time: 11:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Wealthings
{
    /// <summary>
    /// Description of RandomGenerate.
    /// </summary>
    [TestModule("5CACF438-02B7-4526-B47A-70B63F6F422F", ModuleType.UserCode, 1)]
    public class RandomGenerate : ITestModule
    {
    string _Output = "AXTTEST";
    [TestVariable("f4f502f9-bbba-4b55-aa9e-febdaf1e982d")]
    public string Output
    {
    	get { return _Output; }
    	set { _Output = value; }
    }
    
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RandomGenerate()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
          var random = new Random();
          var value = random.Next();
          Output = value.ToString();
        }
    }
}
