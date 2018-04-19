/*
 * Created by Ranorex
 * User: Fahad Shah
 * Date: 4/18/2018
 * Time: 2:31 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
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
using System.Linq;

namespace PMI_MerchandisingPanel.CustomCodeCollection
{
    /// <summary>
    /// Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class CustomCode
    {
    	public static PMI_MerchandisingPanel.PMI_MerchandisingPanelRepository repo = PMI_MerchandisingPanel.PMI_MerchandisingPanelRepository.Instance;
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void launchBrowserWithUrl(string url)
    	{
    		Host.Current.OpenBrowser(url, "Chrome", "", false, true, false, false, false);
    		Delay.Seconds(5);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void pressLoginButton()
    	{
    		repo.PmiMerchandisingPanel.LoginButton.Touch();
    		Delay.Seconds(5);
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void findConfirmationDialogBox()
    	{
    		try{
    			Validate.Exists(repo.GoogleChromeDialogPopUp.ConfimationPopUpDialog);
    			Delay.Seconds(1);
    			repo.GoogleChromeDialogPopUp.NeverButton.Touch();
    			Delay.Seconds(1);
    		}
    		catch{
    		}
    	}
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void setDates(string startdate , string enddate)
    	{
    		string startingdate = Convert.ToDateTime(startdate).ToString("yyyy-MM-dd");
    		string endingdate = Convert.ToDateTime(enddate).ToString("yyyy-MM-dd");
    		repo.PmiMerchandisingPanel.StartDate.Element.SetAttributeValue("Value",startingdate);
    		Delay.Seconds(1);
    		repo.PmiMerchandisingPanel.EndDate.Element.SetAttributeValue("Value",endingdate);
    		Delay.Seconds(1);
    	}
    }
}
