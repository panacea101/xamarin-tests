using System;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.iOS;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace ReactNativeTests
{
	public class Accounts
	{
		protected IApp app;
		//protected Platform platform;
		protected Query homeIcon;
		protected Query createWithEmail;
		protected Query createWithFacebook;
		protected Query createWithGoogle;
		protected Query signInWithExistingAccount;
		protected Query skipButton;
		protected Query sothebysPermission;
		protected Query orText;
		//protected Query emailInput;
		//protected Query passwordInput;

		public Accounts()
		{
			createWithEmail = x => x.Marked("create with email button");
			createWithFacebook = x => x.Marked("create with facebook button");
			createWithGoogle = x => x.Marked("create with google button");
			skipButton = x => x.Marked("skip button");
			signInWithExistingAccount = x => x.Marked("sign in with existing sotheby's account button");
			sothebysPermission = x => x.Marked("sothebys will never post to facebook without your permission text");
			orText = x => x.Marked("or text");
			app = AppInitializer.App;
			//emailInput = x => x.Marked("email address textinput");
			//passwordInput = x => x.Marked("password textinput");
		}

		public Accounts assertEverythingLoadedAccounts()
		{
			app.WaitForElement(createWithEmail);
			app.WaitForElement(createWithFacebook);
			app.WaitForElement(createWithGoogle);
			app.WaitForElement(skipButton);
			app.WaitForElement(sothebysPermission);
			app.WaitForElement(orText);
			app.Screenshot("account screen did load");
			return this;
		}

		public void createWithEmailTap()
		{
			app.Tap(createWithEmail);
		}

		public Accounts createWithFacebookTap() // make void
		{
			app.Tap(createWithFacebook);
			return this;

		}

		public Accounts createWithGoogleTap() // make void
		{
			app.Tap(createWithGoogle);
			return this;
		}

		public Accounts signInWithExistingTap() // make void
		{
			app.Tap(signInWithExistingAccount);
			return this;
		}

		//public Accounts enterEmailAddress()
		//{
		//	app.Tap(emailInput);
		//	app.EnterText(emailInput, "RNTest1@sothebysqa.com");
		//	app.Screenshot("email address textinput");
		//	return this;
		//}
		//public Accounts enterPassword()
		//{
		//	app.Tap(passwordInput);
		//	app.EnterText(passwordInput, "testing123");
		//	return this;
		//}
	}
}
