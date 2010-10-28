package android.accounts;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class AccountManagerCallbackDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.accounts.AccountManagerCallback
{
	static
	{
		MonoBridge.link(AccountManagerCallbackDelegateWrapper.class, "run", "(Landroid/accounts/AccountManagerFuture;)V", "android.accounts.AccountManagerFuture");

	}

	@Override
	public native void run(android.accounts.AccountManagerFuture arg0);



}
