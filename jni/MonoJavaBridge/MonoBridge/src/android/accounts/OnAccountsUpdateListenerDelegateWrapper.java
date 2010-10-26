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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
