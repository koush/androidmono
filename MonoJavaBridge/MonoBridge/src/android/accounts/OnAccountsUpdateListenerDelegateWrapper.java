package android.accounts;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class OnAccountsUpdateListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.accounts.OnAccountsUpdateListener
{
	static
	{
		MonoBridge.link(OnAccountsUpdateListenerDelegateWrapper.class, "onAccountsUpdated", "([Landroid/accounts/Account[];)V", "android.accounts.Account[]");

	}

	public native void onAccountsUpdated(android.accounts.Account[] arg0);



}
