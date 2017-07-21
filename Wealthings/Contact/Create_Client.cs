﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace Wealthings.Contact
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Create_Client recording.
    /// </summary>
    [TestModule("ca603635-c914-4344-b461-6b610572e055", ModuleType.Recording, 1)]
    public partial class Create_Client : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Wealthings.WealthingsRepository repository.
        /// </summary>
        public static Wealthings.WealthingsRepository repo = Wealthings.WealthingsRepository.Instance;

        static Create_Client instance = new Create_Client();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Create_Client()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Create_Client Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://test.wealthings.net/' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://test.wealthings.net/", "chrome", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WealthingsCom.Root.IconContacts' at 20;3.", repo.WealthingsCom.Root.IconContactsInfo, new RecordItemIndex(1));
            repo.WealthingsCom.Root.IconContacts.Click("20;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WealthingsCom.Root.AddNewContact' at 48;6.", repo.WealthingsCom.Root.AddNewContactInfo, new RecordItemIndex(2));
            repo.WealthingsCom.Root.AddNewContact.Click("48;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WealthingsCom.Root.LastName' at 157;5.", repo.WealthingsCom.Root.LastNameInfo, new RecordItemIndex(3));
            repo.WealthingsCom.Root.LastName.Click("157;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}N{LShiftKey up}ame{Space}1{Space}{LShiftKey down}C{LShiftKey up}Lient' with focus on 'WealthingsCom.Root.LastName'.", repo.WealthingsCom.Root.LastNameInfo, new RecordItemIndex(4));
            repo.WealthingsCom.Root.LastName.PressKeys("{LShiftKey down}N{LShiftKey up}ame{Space}1{Space}{LShiftKey down}C{LShiftKey up}Lient");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WealthingsCom.Root.FirstName' at 144;6.", repo.WealthingsCom.Root.FirstNameInfo, new RecordItemIndex(5));
            repo.WealthingsCom.Root.FirstName.Click("144;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}F{LShiftKey up}Is' with focus on 'WealthingsCom.Root.FirstName'.", repo.WealthingsCom.Root.FirstNameInfo, new RecordItemIndex(6));
            repo.WealthingsCom.Root.FirstName.PressKeys("{LShiftKey down}F{LShiftKey up}Is");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 't{Space}name{Space}client' with focus on 'WealthingsCom.Root.FirstName'.", repo.WealthingsCom.Root.FirstNameInfo, new RecordItemIndex(7));
            repo.WealthingsCom.Root.FirstName.PressKeys("t{Space}name{Space}client");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WealthingsCom.Root.ICheckHelper1' at 2;3.", repo.WealthingsCom.Root.ICheckHelper1Info, new RecordItemIndex(8));
            repo.WealthingsCom.Root.ICheckHelper1.Click("2;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WealthingsCom.Root.Save' at 12;6.", repo.WealthingsCom.Root.SaveInfo, new RecordItemIndex(9));
            repo.WealthingsCom.Root.Save.Click("12;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'WealthingsCom.ErrorMsgPopup'.", repo.WealthingsCom.ErrorMsgPopupInfo, new RecordItemIndex(10));
            Validate.NotExists(repo.WealthingsCom.ErrorMsgPopupInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}