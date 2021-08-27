<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128606529/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2868)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/Testapp/MainPage.xaml) (VB: [MainPage.xaml](./VB/Testapp/MainPage.xaml))
* [MainPage.xaml.cs](./CS/Testapp/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/Testapp/MainPage.xaml.vb))
* [SpellCheckerHelper.cs](./CS/Testapp/SpellCheckerHelper.cs) (VB: [SpellCheckerHelper.vb](./VB/Testapp/SpellCheckerHelper.vb))
<!-- default file list end -->
# How to configure spell check in the RichEditControl


<p>This example illustrates how to use <a href="http://documentation.devexpress.com/#Silverlight/CustomDocument4949"><strong><u>DXSpellChecker for Silverlight</u></strong></a> to check spelling of the document loaded in the RichEditControl using the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXtraSpellCheckerSpellCheckModeEnumtopic"><strong><u>Check As You Type</u></strong></a> mode.<br />
Previously you have to reference the <strong>DevExpress.Xpf.RichEdit.x.Y.Extensions.dll</strong> assembly in your project to obtain the SpellCheckerHelper class. It provided you with American English dictionary by default so the spelling check capabilities for RichEditControl has been automatically included.<br />
From v2010 vol.2 you are advised not to use the Extensions assembly. Other libraries will implement the functionality contained within this assembly.<br />
This example illustrates the <strong>SpellCheckerHelper</strong> class implementation that, being included in your application, provides more flexibility than the class of the same name in the Extensions assembly. You are free to modify it to suite your particular needs.</p><p><strong>NOTE:</strong> If you wish, in addition, make sure that the <strong>Spelling </strong>dialog displays correctly when the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfSpellCheckerSpellChecker_Checktopic"><u>SpellChecker.Check Method</u></a> is called, it is necessary to add the corresponding registration code to your application, as described in the <a href="https://www.devexpress.com/Support/Center/p/Q491910">Spell Check dialog not opening from context menu or button</a> ticket.</p>

<br/>


