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

namespace PMI_MerchandisingPanel.TestCases.LaunchingPanel
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LaunchPanel recording.
    /// </summary>
    [TestModule("42af3ed7-5c62-44aa-837b-161acebf94eb", ModuleType.Recording, 1)]
    public partial class LaunchPanel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PMI_MerchandisingPanel.PMI_MerchandisingPanelRepository repository.
        /// </summary>
        public static PMI_MerchandisingPanel.PMI_MerchandisingPanelRepository repo = PMI_MerchandisingPanel.PMI_MerchandisingPanelRepository.Instance;

        static LaunchPanel instance = new LaunchPanel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LaunchPanel()
        {
            varWebURL = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LaunchPanel Instance
        {
            get { return instance; }
        }

#region Variables

        string _varWebURL;

        /// <summary>
        /// Gets or sets the value of variable varWebURL.
        /// </summary>
        [TestVariable("6adc9fc3-3809-4565-ae9f-987fdec25bef")]
        public string varWebURL
        {
            get { return _varWebURL; }
            set { _varWebURL = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            CustomCodeCollection.CustomCode.launchBrowserWithUrl(varWebURL);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
