package android.accounts;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class AccountManagerCallbackDelegateWrapper extends java.lang.Object implements MonoProxy, android.accounts.AccountManagerCallback
{
	static
	{
		MonoBridge.link(AccountManagerCallbackDelegateWrapper.class, "run", "(Landroid/accounts/AccountManagerFuture;)V", "android.accounts.AccountManagerFuture");

	}

	@Override
	public native void run(android.accounts.AccountManagerFuture arg0);


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
