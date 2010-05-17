namespace android.accounts 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface AccountManagerFuture 
	{ 
		bool cancel(bool arg0); 
		bool isCancelled(); 
		bool isDone(); 
		java.lang.Object getResult(); 
		java.lang.Object getResult(long arg0, java.util.concurrent.TimeUnit arg1); 
	} 
} 
