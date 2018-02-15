package md5524ddaf70d2cac71db297e7399793e42;


public class BaseFragment
	extends android.app.Fragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DesislavsHotDogs.Fragments.BaseFragment, DesislavsHotDogs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BaseFragment.class, __md_methods);
	}


	public BaseFragment ()
	{
		super ();
		if (getClass () == BaseFragment.class)
			mono.android.TypeManager.Activate ("DesislavsHotDogs.Fragments.BaseFragment, DesislavsHotDogs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
