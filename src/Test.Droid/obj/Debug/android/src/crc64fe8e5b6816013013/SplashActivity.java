package crc64fe8e5b6816013013;


public class SplashActivity
	extends crc6426126fc9ed8a1cca.MvxFormsSplashScreenActivity_3
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Test.Droid.Views.SplashActivity, Test.Android", SplashActivity.class, __md_methods);
	}


	public SplashActivity ()
	{
		super ();
		if (getClass () == SplashActivity.class) {
			mono.android.TypeManager.Activate ("Test.Droid.Views.SplashActivity, Test.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public SplashActivity (int p0)
	{
		super (p0);
		if (getClass () == SplashActivity.class) {
			mono.android.TypeManager.Activate ("Test.Droid.Views.SplashActivity, Test.Android", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
		}
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
