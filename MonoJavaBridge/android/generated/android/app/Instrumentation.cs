namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Instrumentation : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Instrumentation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ActivityMonitor : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ActivityMonitor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public new global::android.content.IntentFilter Filter
			{
				get
				{
					return getFilter();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getFilter1838;
			public virtual global::android.content.IntentFilter getFilter()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, "getFilter", "()Landroid/content/IntentFilter;", ref global::android.app.Instrumentation.ActivityMonitor._getFilter1838) as android.content.IntentFilter;
			}
			public new global::android.app.Instrumentation.ActivityResult Result
			{
				get
				{
					return getResult();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getResult1839;
			public virtual global::android.app.Instrumentation.ActivityResult getResult()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.app.Instrumentation.ActivityResult>(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, "getResult", "()Landroid/app/Instrumentation$ActivityResult;", ref global::android.app.Instrumentation.ActivityMonitor._getResult1839) as android.app.Instrumentation.ActivityResult;
			}
			internal static global::MonoJavaBridge.MethodId _isBlocking1840;
			public virtual bool isBlocking()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, "isBlocking", "()Z", ref global::android.app.Instrumentation.ActivityMonitor._isBlocking1840);
			}
			public new int Hits
			{
				get
				{
					return getHits();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHits1841;
			public virtual int getHits()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, "getHits", "()I", ref global::android.app.Instrumentation.ActivityMonitor._getHits1841);
			}
			public new global::android.app.Activity LastActivity
			{
				get
				{
					return getLastActivity();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getLastActivity1842;
			public virtual global::android.app.Activity getLastActivity()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, "getLastActivity", "()Landroid/app/Activity;", ref global::android.app.Instrumentation.ActivityMonitor._getLastActivity1842) as android.app.Activity;
			}
			internal static global::MonoJavaBridge.MethodId _waitForActivity1843;
			public virtual global::android.app.Activity waitForActivity()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, "waitForActivity", "()Landroid/app/Activity;", ref global::android.app.Instrumentation.ActivityMonitor._waitForActivity1843) as android.app.Activity;
			}
			internal static global::MonoJavaBridge.MethodId _waitForActivityWithTimeout1844;
			public virtual global::android.app.Activity waitForActivityWithTimeout(long arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, "waitForActivityWithTimeout", "(J)Landroid/app/Activity;", ref global::android.app.Instrumentation.ActivityMonitor._waitForActivityWithTimeout1844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.Activity;
			}
			internal static global::MonoJavaBridge.MethodId _ActivityMonitor1845;
			public ActivityMonitor(android.content.IntentFilter arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor1845.native == global::System.IntPtr.Zero)
					global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor1845 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "<init>", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor1845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _ActivityMonitor1846;
			public ActivityMonitor(java.lang.String arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor1846.native == global::System.IntPtr.Zero)
					global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor1846 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "<init>", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor1846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			static ActivityMonitor()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.Instrumentation.ActivityMonitor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Instrumentation$ActivityMonitor"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class ActivityResult : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ActivityResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			public new int ResultCode
			{
				get
				{
					return getResultCode();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getResultCode1847;
			public int getResultCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Instrumentation.ActivityResult.staticClass, "getResultCode", "()I", ref global::android.app.Instrumentation.ActivityResult._getResultCode1847);
			}
			public new global::android.content.Intent ResultData
			{
				get
				{
					return getResultData();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getResultData1848;
			public global::android.content.Intent getResultData()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.ActivityResult.staticClass, "getResultData", "()Landroid/content/Intent;", ref global::android.app.Instrumentation.ActivityResult._getResultData1848) as android.content.Intent;
			}
			internal static global::MonoJavaBridge.MethodId _ActivityResult1849;
			public ActivityResult(int arg0, android.content.Intent arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.Instrumentation.ActivityResult._ActivityResult1849.native == global::System.IntPtr.Zero)
					global::android.app.Instrumentation.ActivityResult._ActivityResult1849 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityResult.staticClass, "<init>", "(ILandroid/content/Intent;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.ActivityResult.staticClass, global::android.app.Instrumentation.ActivityResult._ActivityResult1849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			static ActivityResult()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.Instrumentation.ActivityResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Instrumentation$ActivityResult"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _start1850;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "start", "()V", ref global::android.app.Instrumentation._start1850);
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext1851;
		public virtual global::android.content.Context getContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "getContext", "()Landroid/content/Context;", ref global::android.app.Instrumentation._getContext1851) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1852;
		public virtual void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "onCreate", "(Landroid/os/Bundle;)V", ref global::android.app.Instrumentation._onCreate1852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStart1853;
		public virtual void onStart()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "onStart", "()V", ref global::android.app.Instrumentation._onStart1853);
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy1854;
		public virtual void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "onDestroy", "()V", ref global::android.app.Instrumentation._onDestroy1854);
		}
		internal static global::MonoJavaBridge.MethodId _finish1855;
		public virtual void finish(int arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "finish", "(ILandroid/os/Bundle;)V", ref global::android.app.Instrumentation._finish1855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.content.ComponentName ComponentName
		{
			get
			{
				return getComponentName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComponentName1856;
		public virtual global::android.content.ComponentName getComponentName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.app.Instrumentation.staticClass, "getComponentName", "()Landroid/content/ComponentName;", ref global::android.app.Instrumentation._getComponentName1856) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _startAllocCounting1857;
		public virtual void startAllocCounting()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "startAllocCounting", "()V", ref global::android.app.Instrumentation._startAllocCounting1857);
		}
		internal static global::MonoJavaBridge.MethodId _stopAllocCounting1858;
		public virtual void stopAllocCounting()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "stopAllocCounting", "()V", ref global::android.app.Instrumentation._stopAllocCounting1858);
		}
		internal static global::MonoJavaBridge.MethodId _onException1859;
		public virtual bool onException(java.lang.Object arg0, java.lang.Throwable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Instrumentation.staticClass, "onException", "(Ljava/lang/Object;Ljava/lang/Throwable;)Z", ref global::android.app.Instrumentation._onException1859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendStatus1860;
		public virtual void sendStatus(int arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "sendStatus", "(ILandroid/os/Bundle;)V", ref global::android.app.Instrumentation._sendStatus1860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAutomaticPerformanceSnapshots1861;
		public virtual void setAutomaticPerformanceSnapshots()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "setAutomaticPerformanceSnapshots", "()V", ref global::android.app.Instrumentation._setAutomaticPerformanceSnapshots1861);
		}
		internal static global::MonoJavaBridge.MethodId _startPerformanceSnapshot1862;
		public virtual void startPerformanceSnapshot()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "startPerformanceSnapshot", "()V", ref global::android.app.Instrumentation._startPerformanceSnapshot1862);
		}
		internal static global::MonoJavaBridge.MethodId _endPerformanceSnapshot1863;
		public virtual void endPerformanceSnapshot()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "endPerformanceSnapshot", "()V", ref global::android.app.Instrumentation._endPerformanceSnapshot1863);
		}
		public new global::android.content.Context TargetContext
		{
			get
			{
				return getTargetContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetContext1864;
		public virtual global::android.content.Context getTargetContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "getTargetContext", "()Landroid/content/Context;", ref global::android.app.Instrumentation._getTargetContext1864) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _isProfiling1865;
		public virtual bool isProfiling()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Instrumentation.staticClass, "isProfiling", "()Z", ref global::android.app.Instrumentation._isProfiling1865);
		}
		internal static global::MonoJavaBridge.MethodId _startProfiling1866;
		public virtual void startProfiling()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "startProfiling", "()V", ref global::android.app.Instrumentation._startProfiling1866);
		}
		internal static global::MonoJavaBridge.MethodId _stopProfiling1867;
		public virtual void stopProfiling()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "stopProfiling", "()V", ref global::android.app.Instrumentation._stopProfiling1867);
		}
		public new bool InTouchMode
		{
			set
			{
				setInTouchMode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setInTouchMode1868;
		public virtual void setInTouchMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "setInTouchMode", "(Z)V", ref global::android.app.Instrumentation._setInTouchMode1868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _waitForIdle1869;
		public virtual void waitForIdle(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "waitForIdle", "(Ljava/lang/Runnable;)V", ref global::android.app.Instrumentation._waitForIdle1869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void waitForIdle(global::java.lang.RunnableDelegate arg0)
		{
			waitForIdle((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _waitForIdleSync1870;
		public virtual void waitForIdleSync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "waitForIdleSync", "()V", ref global::android.app.Instrumentation._waitForIdleSync1870);
		}
		internal static global::MonoJavaBridge.MethodId _runOnMainSync1871;
		public virtual void runOnMainSync(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "runOnMainSync", "(Ljava/lang/Runnable;)V", ref global::android.app.Instrumentation._runOnMainSync1871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void runOnMainSync(global::java.lang.RunnableDelegate arg0)
		{
			runOnMainSync((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _startActivitySync1872;
		public virtual global::android.app.Activity startActivitySync(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "startActivitySync", "(Landroid/content/Intent;)Landroid/app/Activity;", ref global::android.app.Instrumentation._startActivitySync1872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _addMonitor1873;
		public virtual global::android.app.Instrumentation.ActivityMonitor addMonitor(android.content.IntentFilter arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "addMonitor", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)Landroid/app/Instrumentation$ActivityMonitor;", ref global::android.app.Instrumentation._addMonitor1873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.Instrumentation.ActivityMonitor;
		}
		internal static global::MonoJavaBridge.MethodId _addMonitor1874;
		public virtual global::android.app.Instrumentation.ActivityMonitor addMonitor(java.lang.String arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "addMonitor", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)Landroid/app/Instrumentation$ActivityMonitor;", ref global::android.app.Instrumentation._addMonitor1874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.Instrumentation.ActivityMonitor;
		}
		internal static global::MonoJavaBridge.MethodId _addMonitor1875;
		public virtual void addMonitor(android.app.Instrumentation.ActivityMonitor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "addMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V", ref global::android.app.Instrumentation._addMonitor1875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkMonitorHit1876;
		public virtual bool checkMonitorHit(android.app.Instrumentation.ActivityMonitor arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Instrumentation.staticClass, "checkMonitorHit", "(Landroid/app/Instrumentation$ActivityMonitor;I)Z", ref global::android.app.Instrumentation._checkMonitorHit1876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _waitForMonitor1877;
		public virtual global::android.app.Activity waitForMonitor(android.app.Instrumentation.ActivityMonitor arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "waitForMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)Landroid/app/Activity;", ref global::android.app.Instrumentation._waitForMonitor1877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _waitForMonitorWithTimeout1878;
		public virtual global::android.app.Activity waitForMonitorWithTimeout(android.app.Instrumentation.ActivityMonitor arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "waitForMonitorWithTimeout", "(Landroid/app/Instrumentation$ActivityMonitor;J)Landroid/app/Activity;", ref global::android.app.Instrumentation._waitForMonitorWithTimeout1878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _removeMonitor1879;
		public virtual void removeMonitor(android.app.Instrumentation.ActivityMonitor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "removeMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V", ref global::android.app.Instrumentation._removeMonitor1879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invokeMenuActionSync1880;
		public virtual bool invokeMenuActionSync(android.app.Activity arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Instrumentation.staticClass, "invokeMenuActionSync", "(Landroid/app/Activity;II)Z", ref global::android.app.Instrumentation._invokeMenuActionSync1880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _invokeContextMenuAction1881;
		public virtual bool invokeContextMenuAction(android.app.Activity arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Instrumentation.staticClass, "invokeContextMenuAction", "(Landroid/app/Activity;II)Z", ref global::android.app.Instrumentation._invokeContextMenuAction1881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sendStringSync1882;
		public virtual void sendStringSync(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "sendStringSync", "(Ljava/lang/String;)V", ref global::android.app.Instrumentation._sendStringSync1882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeySync1883;
		public virtual void sendKeySync(android.view.KeyEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "sendKeySync", "(Landroid/view/KeyEvent;)V", ref global::android.app.Instrumentation._sendKeySync1883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeyDownUpSync1884;
		public virtual void sendKeyDownUpSync(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "sendKeyDownUpSync", "(I)V", ref global::android.app.Instrumentation._sendKeyDownUpSync1884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendCharacterSync1885;
		public virtual void sendCharacterSync(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "sendCharacterSync", "(I)V", ref global::android.app.Instrumentation._sendCharacterSync1885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendPointerSync1886;
		public virtual void sendPointerSync(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "sendPointerSync", "(Landroid/view/MotionEvent;)V", ref global::android.app.Instrumentation._sendPointerSync1886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendTrackballEventSync1887;
		public virtual void sendTrackballEventSync(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "sendTrackballEventSync", "(Landroid/view/MotionEvent;)V", ref global::android.app.Instrumentation._sendTrackballEventSync1887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newApplication1888;
		public virtual global::android.app.Application newApplication(java.lang.ClassLoader arg0, java.lang.String arg1, android.content.Context arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "newApplication", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Context;)Landroid/app/Application;", ref global::android.app.Instrumentation._newApplication1888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _newApplication1889;
		public static global::android.app.Application newApplication(java.lang.Class arg0, android.content.Context arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Instrumentation._newApplication1889.native == global::System.IntPtr.Zero)
				global::android.app.Instrumentation._newApplication1889 = @__env.GetStaticMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "newApplication", "(Ljava/lang/Class;Landroid/content/Context;)Landroid/app/Application;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newApplication1889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _callApplicationOnCreate1890;
		public virtual void callApplicationOnCreate(android.app.Application arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callApplicationOnCreate", "(Landroid/app/Application;)V", ref global::android.app.Instrumentation._callApplicationOnCreate1890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newActivity1891;
		public virtual global::android.app.Activity newActivity(java.lang.ClassLoader arg0, java.lang.String arg1, android.content.Intent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "newActivity", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Intent;)Landroid/app/Activity;", ref global::android.app.Instrumentation._newActivity1891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _newActivity1892;
		public virtual global::android.app.Activity newActivity(java.lang.Class arg0, android.content.Context arg1, android.os.IBinder arg2, android.app.Application arg3, android.content.Intent arg4, android.content.pm.ActivityInfo arg5, java.lang.CharSequence arg6, android.app.Activity arg7, java.lang.String arg8, java.lang.Object arg9)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "newActivity", "(Ljava/lang/Class;Landroid/content/Context;Landroid/os/IBinder;Landroid/app/Application;Landroid/content/Intent;Landroid/content/pm/ActivityInfo;Ljava/lang/CharSequence;Landroid/app/Activity;Ljava/lang/String;Ljava/lang/Object;)Landroid/app/Activity;", ref global::android.app.Instrumentation._newActivity1892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9)) as android.app.Activity;
		}
		public android.app.Activity newActivity(java.lang.Class arg0, android.content.Context arg1, android.os.IBinder arg2, android.app.Application arg3, android.content.Intent arg4, android.content.pm.ActivityInfo arg5, string arg6, android.app.Activity arg7, java.lang.String arg8, java.lang.Object arg9)
		{
			return newActivity(arg0, arg1, arg2, arg3, arg4, arg5, (global::java.lang.CharSequence)(global::java.lang.String)arg6, arg7, arg8, arg9);
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnCreate1893;
		public virtual void callActivityOnCreate(android.app.Activity arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V", ref global::android.app.Instrumentation._callActivityOnCreate1893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnDestroy1894;
		public virtual void callActivityOnDestroy(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnDestroy", "(Landroid/app/Activity;)V", ref global::android.app.Instrumentation._callActivityOnDestroy1894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnRestoreInstanceState1895;
		public virtual void callActivityOnRestoreInstanceState(android.app.Activity arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnRestoreInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", ref global::android.app.Instrumentation._callActivityOnRestoreInstanceState1895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnPostCreate1896;
		public virtual void callActivityOnPostCreate(android.app.Activity arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnPostCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V", ref global::android.app.Instrumentation._callActivityOnPostCreate1896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnNewIntent1897;
		public virtual void callActivityOnNewIntent(android.app.Activity arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnNewIntent", "(Landroid/app/Activity;Landroid/content/Intent;)V", ref global::android.app.Instrumentation._callActivityOnNewIntent1897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnStart1898;
		public virtual void callActivityOnStart(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnStart", "(Landroid/app/Activity;)V", ref global::android.app.Instrumentation._callActivityOnStart1898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnRestart1899;
		public virtual void callActivityOnRestart(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnRestart", "(Landroid/app/Activity;)V", ref global::android.app.Instrumentation._callActivityOnRestart1899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnResume1900;
		public virtual void callActivityOnResume(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnResume", "(Landroid/app/Activity;)V", ref global::android.app.Instrumentation._callActivityOnResume1900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnStop1901;
		public virtual void callActivityOnStop(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnStop", "(Landroid/app/Activity;)V", ref global::android.app.Instrumentation._callActivityOnStop1901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnSaveInstanceState1902;
		public virtual void callActivityOnSaveInstanceState(android.app.Activity arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnSaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", ref global::android.app.Instrumentation._callActivityOnSaveInstanceState1902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnPause1903;
		public virtual void callActivityOnPause(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnPause", "(Landroid/app/Activity;)V", ref global::android.app.Instrumentation._callActivityOnPause1903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnUserLeaving1904;
		public virtual void callActivityOnUserLeaving(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnUserLeaving", "(Landroid/app/Activity;)V", ref global::android.app.Instrumentation._callActivityOnUserLeaving1904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.os.Bundle AllocCounts
		{
			get
			{
				return getAllocCounts();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllocCounts1905;
		public virtual global::android.os.Bundle getAllocCounts()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.app.Instrumentation.staticClass, "getAllocCounts", "()Landroid/os/Bundle;", ref global::android.app.Instrumentation._getAllocCounts1905) as android.os.Bundle;
		}
		public new global::android.os.Bundle BinderCounts
		{
			get
			{
				return getBinderCounts();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderCounts1906;
		public virtual global::android.os.Bundle getBinderCounts()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.app.Instrumentation.staticClass, "getBinderCounts", "()Landroid/os/Bundle;", ref global::android.app.Instrumentation._getBinderCounts1906) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _Instrumentation1907;
		public Instrumentation() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Instrumentation._Instrumentation1907.native == global::System.IntPtr.Zero)
				global::android.app.Instrumentation._Instrumentation1907 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.staticClass, global::android.app.Instrumentation._Instrumentation1907);
			Init(@__env, handle);
		}
		public static global::java.lang.String REPORT_KEY_IDENTIFIER
		{
			get
			{
				return "id";
			}
		}
		public static global::java.lang.String REPORT_KEY_STREAMRESULT
		{
			get
			{
				return "stream";
			}
		}
		static Instrumentation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Instrumentation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Instrumentation"));
		}
		internal static void InitJNI()
		{
		}
	}
}
