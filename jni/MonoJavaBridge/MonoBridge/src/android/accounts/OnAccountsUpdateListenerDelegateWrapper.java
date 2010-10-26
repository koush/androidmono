package android.accounts;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class OnAccountsUpdateListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.accounts.OnAccountsUpdateListener
{
	static
	{
		MonoBridge.link(OnAccountsUpdateListenerDelegateWrapper.class, "onAccountsUpdated", "([Landroid/accounts/Account[];)V", "android.accounts.Account[]");

	}

	@Override
	public native void onAccountsUpdated(android.accounts.Account[] arg0);


	long myGCHandle;
	public long getGCHandle() {
		return myGCHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGCHandle = gcHandle;
	}

	@Override
	protected void finalize() throws Throwable {
	    super.finalize();
	    MonoBridge.releaseGCHandle(myGCHandle);
	}
}
