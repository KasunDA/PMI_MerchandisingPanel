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

namespace PMI_MerchandisingPanel.TestCases.Login
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Login recording.
    /// </summary>
    [TestModule("d0e013fa-dd97-485a-8f62-3423d7f6be99", ModuleType.Recording, 1)]
    public partial class Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PMI_MerchandisingPanel.PMI_MerchandisingPanelRepository repository.
        /// </summary>
        public static PMI_MerchandisingPanel.PMI_MerchandisingPanelRepository repo = PMI_MerchandisingPanel.PMI_MerchandisingPanelRepository.Instance;

        static Login instance = new Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Login()
        {
            varUserName = "0000000";
            varPassword = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Login Instance
        {
            get { return instance; }
        }

#region Variables

        string _varUserName;

        /// <summary>
        /// Gets or sets the value of variable varUserName.
        /// </summary>
        [TestVariable("95de8b71-b4eb-4052-ab40-241ca7a95d56")]
        public string varUserName
        {
            get { return _varUserName; }
            set { _varUserName = value; }
        }

        string _varPassword;

        /// <summary>
        /// Gets or sets the value of variable varPassword.
        /// </summary>
        [TestVariable("b8fbda3a-7daf-4ad3-82f9-64488c3d7b5d")]
        public string varPassword
        {
            get { return _varPassword; }
            set { _varPassword = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'PmiMerchandisingPanel.Validate_LoginScreen'.", repo.PmiMerchandisingPanel.Validate_LoginScreenInfo, new RecordItemIndex(0));
            Validate.Exists(repo.PmiMerchandisingPanel.Validate_LoginScreenInfo);
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$varUserName' on item 'PmiMerchandisingPanel.UserName'.", repo.PmiMerchandisingPanel.UserNameInfo, new RecordItemIndex(1));
            repo.PmiMerchandisingPanel.UserName.Element.SetAttributeValue("Value", varUserName);
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$varPassword' on item 'PmiMerchandisingPanel.Password'.", repo.PmiMerchandisingPanel.PasswordInfo, new RecordItemIndex(2));
            repo.PmiMerchandisingPanel.Password.Element.SetAttributeValue("Value", varPassword);
            Delay.Milliseconds(1000);
            
            CustomCodeCollection.CustomCode.pressLoginButton();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
