using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ReactNativeTests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class AccountsTest
	{
		Platform platform;

		public AccountsTest(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			AppInitializer.App = AppInitializer.StartApp(platform);
		}

		[Test]
		public void RunRepl()
		{
			AppInitializer.App.Repl();

		}


		//[Test]
		//public void signInExistingAccount()
		//{
		//	new Accounts()
		//		.signInWithExistingTap()
		//		.enterEmailAddress()
		//		.enterPassword();
		//}

	//	["continuousIntegration"]
		[Test]
		public void tapCreateWithFacebook()
		{
			new Accounts()
				.assertEverythingLoadedAccounts()
				.createWithEmailTap();
		}

	//	["continuousIntegration"]
		[Test]
		public void tapCreateWithGoogle()
		{
			new Accounts()
				.assertEverythingLoadedAccounts()
				.createWithGoogleTap();
		}

		[Test]
		public void tapCreateWithEmail()
		{
			new Accounts()
				.assertEverythingLoadedAccounts()
				.createWithEmailTap();
		}
	}
}
