namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Instrumentation : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Instrumentation()
		{
			InitJNI();
		}
		protected Instrumentation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class ActivityMonitor : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ActivityMonitor()
			{
				InitJNI();
			}
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
			internal static global::MonoJavaBridge.MethodId _getFilter1835;
			public virtual global::android.content.IntentFilter getFilter() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor._getFilter1835)) as android.content.IntentFilter;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getFilter1835)) as android.content.IntentFilter;
			}
			public new global::android.app.Instrumentation.ActivityResult Result
			{
				get
				{
					return getResult();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getResult1836;
			public virtual global::android.app.Instrumentation.ActivityResult getResult() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.Instrumentation.ActivityResult>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor._getResult1836)) as android.app.Instrumentation.ActivityResult;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.app.Instrumentation.ActivityResult>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getResult1836)) as android.app.Instrumentation.ActivityResult;
			}
			internal static global::MonoJavaBridge.MethodId _isBlocking1837;
			public virtual bool isBlocking() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor._isBlocking1837);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._isBlocking1837);
			}
			public new int Hits
			{
				get
				{
					return getHits();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHits1838;
			public virtual int getHits() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor._getHits1838);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getHits1838);
			}
			public new global::android.app.Activity LastActivity
			{
				get
				{
					return getLastActivity();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getLastActivity1839;
			public virtual global::android.app.Activity getLastActivity() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor._getLastActivity1839)) as android.app.Activity;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getLastActivity1839)) as android.app.Activity;
			}
			internal static global::MonoJavaBridge.MethodId _waitForActivity1840;
			public virtual global::android.app.Activity waitForActivity() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor._waitForActivity1840)) as android.app.Activity;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._waitForActivity1840)) as android.app.Activity;
			}
			internal static global::MonoJavaBridge.MethodId _waitForActivityWithTimeout1841;
			public virtual global::android.app.Activity waitForActivityWithTimeout(long arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor._waitForActivityWithTimeout1841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._waitForActivityWithTimeout1841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
			}
			internal static global::MonoJavaBridge.MethodId _ActivityMonitor1842;
			public ActivityMonitor(android.content.IntentFilter arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor1842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _ActivityMonitor1843;
			public ActivityMonitor(java.lang.String arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor1843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.Instrumentation.ActivityMonitor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Instrumentation$ActivityMonitor"));
				global::android.app.Instrumentation.ActivityMonitor._getFilter1835 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getFilter", "()Landroid/content/IntentFilter;");
				global::android.app.Instrumentation.ActivityMonitor._getResult1836 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getResult", "()Landroid/app/Instrumentation$ActivityResult;");
				global::android.app.Instrumentation.ActivityMonitor._isBlocking1837 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "isBlocking", "()Z");
				global::android.app.Instrumentation.ActivityMonitor._getHits1838 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getHits", "()I");
				global::android.app.Instrumentation.ActivityMonitor._getLastActivity1839 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getLastActivity", "()Landroid/app/Activity;");
				global::android.app.Instrumentation.ActivityMonitor._waitForActivity1840 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "waitForActivity", "()Landroid/app/Activity;");
				global::android.app.Instrumentation.ActivityMonitor._waitForActivityWithTimeout1841 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "waitForActivityWithTimeout", "(J)Landroid/app/Activity;");
				global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor1842 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "<init>", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)V");
				global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor1843 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "<init>", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class ActivityResult : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ActivityResult()
			{
				InitJNI();
			}
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
			internal static global::MonoJavaBridge.MethodId _getResultCode1844;
			public int getResultCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityResult._getResultCode1844);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityResult.staticClass, global::android.app.Instrumentation.ActivityResult._getResultCode1844);
			}
			public new global::android.content.Intent ResultData
			{
				get
				{
					return getResultData();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getResultData1845;
			public global::android.content.Intent getResultData() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityResult._getResultData1845)) as android.content.Intent;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityResult.staticClass, global::android.app.Instrumentation.ActivityResult._getResultData1845)) as android.content.Intent;
			}
			internal static global::MonoJavaBridge.MethodId _ActivityResult1846;
			public ActivityResult(int arg0, android.content.Intent arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.ActivityResult.staticClass, global::android.app.Instrumentation.ActivityResult._ActivityResult1846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.Instrumentation.ActivityResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Instrumentation$ActivityResult"));
				global::android.app.Instrumentation.ActivityResult._getResultCode1844 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityResult.staticClass, "getResultCode", "()I");
				global::android.app.Instrumentation.ActivityResult._getResultData1845 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityResult.staticClass, "getResultData", "()Landroid/content/Intent;");
				global::android.app.Instrumentation.ActivityResult._ActivityResult1846 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityResult.staticClass, "<init>", "(ILandroid/content/Intent;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _start1847;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._start1847);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._start1847);
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext1848;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._getContext1848)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getContext1848)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1849;
		public virtual void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._onCreate1849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onCreate1849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStart1850;
		public virtual void onStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._onStart1850);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onStart1850);
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy1851;
		public virtual void onDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._onDestroy1851);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onDestroy1851);
		}
		internal static global::MonoJavaBridge.MethodId _finish1852;
		public virtual void finish(int arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._finish1852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._finish1852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.content.ComponentName ComponentName
		{
			get
			{
				return getComponentName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComponentName1853;
		public virtual global::android.content.ComponentName getComponentName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._getComponentName1853)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getComponentName1853)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _startAllocCounting1854;
		public virtual void startAllocCounting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._startAllocCounting1854);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startAllocCounting1854);
		}
		internal static global::MonoJavaBridge.MethodId _stopAllocCounting1855;
		public virtual void stopAllocCounting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._stopAllocCounting1855);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._stopAllocCounting1855);
		}
		internal static global::MonoJavaBridge.MethodId _onException1856;
		public virtual bool onException(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Instrumentation._onException1856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onException1856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendStatus1857;
		public virtual void sendStatus(int arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._sendStatus1857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendStatus1857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAutomaticPerformanceSnapshots1858;
		public virtual void setAutomaticPerformanceSnapshots() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._setAutomaticPerformanceSnapshots1858);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._setAutomaticPerformanceSnapshots1858);
		}
		internal static global::MonoJavaBridge.MethodId _startPerformanceSnapshot1859;
		public virtual void startPerformanceSnapshot() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._startPerformanceSnapshot1859);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startPerformanceSnapshot1859);
		}
		internal static global::MonoJavaBridge.MethodId _endPerformanceSnapshot1860;
		public virtual void endPerformanceSnapshot() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._endPerformanceSnapshot1860);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._endPerformanceSnapshot1860);
		}
		public new global::android.content.Context TargetContext
		{
			get
			{
				return getTargetContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetContext1861;
		public virtual global::android.content.Context getTargetContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._getTargetContext1861)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getTargetContext1861)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _isProfiling1862;
		public virtual bool isProfiling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Instrumentation._isProfiling1862);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._isProfiling1862);
		}
		internal static global::MonoJavaBridge.MethodId _startProfiling1863;
		public virtual void startProfiling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._startProfiling1863);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startProfiling1863);
		}
		internal static global::MonoJavaBridge.MethodId _stopProfiling1864;
		public virtual void stopProfiling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._stopProfiling1864);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._stopProfiling1864);
		}
		internal static global::MonoJavaBridge.MethodId _setInTouchMode1865;
		public virtual void setInTouchMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._setInTouchMode1865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._setInTouchMode1865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _waitForIdle1866;
		public virtual void waitForIdle(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._waitForIdle1866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForIdle1866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _waitForIdleSync1867;
		public virtual void waitForIdleSync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._waitForIdleSync1867);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForIdleSync1867);
		}
		internal static global::MonoJavaBridge.MethodId _runOnMainSync1868;
		public virtual void runOnMainSync(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._runOnMainSync1868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._runOnMainSync1868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startActivitySync1869;
		public virtual global::android.app.Activity startActivitySync(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._startActivitySync1869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startActivitySync1869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _addMonitor1870;
		public virtual global::android.app.Instrumentation.ActivityMonitor addMonitor(android.content.IntentFilter arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._addMonitor1870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Instrumentation.ActivityMonitor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._addMonitor1870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Instrumentation.ActivityMonitor;
		}
		internal static global::MonoJavaBridge.MethodId _addMonitor1871;
		public virtual global::android.app.Instrumentation.ActivityMonitor addMonitor(java.lang.String arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._addMonitor1871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Instrumentation.ActivityMonitor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._addMonitor1871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Instrumentation.ActivityMonitor;
		}
		internal static global::MonoJavaBridge.MethodId _addMonitor1872;
		public virtual void addMonitor(android.app.Instrumentation.ActivityMonitor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._addMonitor1872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._addMonitor1872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkMonitorHit1873;
		public virtual bool checkMonitorHit(android.app.Instrumentation.ActivityMonitor arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Instrumentation._checkMonitorHit1873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._checkMonitorHit1873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _waitForMonitor1874;
		public virtual global::android.app.Activity waitForMonitor(android.app.Instrumentation.ActivityMonitor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._waitForMonitor1874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForMonitor1874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _waitForMonitorWithTimeout1875;
		public virtual global::android.app.Activity waitForMonitorWithTimeout(android.app.Instrumentation.ActivityMonitor arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._waitForMonitorWithTimeout1875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForMonitorWithTimeout1875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _removeMonitor1876;
		public virtual void removeMonitor(android.app.Instrumentation.ActivityMonitor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._removeMonitor1876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._removeMonitor1876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invokeMenuActionSync1877;
		public virtual bool invokeMenuActionSync(android.app.Activity arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Instrumentation._invokeMenuActionSync1877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._invokeMenuActionSync1877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _invokeContextMenuAction1878;
		public virtual bool invokeContextMenuAction(android.app.Activity arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Instrumentation._invokeContextMenuAction1878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._invokeContextMenuAction1878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sendStringSync1879;
		public virtual void sendStringSync(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._sendStringSync1879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendStringSync1879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeySync1880;
		public virtual void sendKeySync(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._sendKeySync1880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendKeySync1880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeyDownUpSync1881;
		public virtual void sendKeyDownUpSync(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._sendKeyDownUpSync1881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendKeyDownUpSync1881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendCharacterSync1882;
		public virtual void sendCharacterSync(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._sendCharacterSync1882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendCharacterSync1882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendPointerSync1883;
		public virtual void sendPointerSync(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._sendPointerSync1883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendPointerSync1883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendTrackballEventSync1884;
		public virtual void sendTrackballEventSync(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._sendTrackballEventSync1884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendTrackballEventSync1884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newApplication1885;
		public virtual global::android.app.Application newApplication(java.lang.ClassLoader arg0, java.lang.String arg1, android.content.Context arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._newApplication1885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Application;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newApplication1885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _newApplication1886;
		public static global::android.app.Application newApplication(java.lang.Class arg0, android.content.Context arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newApplication1886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _callApplicationOnCreate1887;
		public virtual void callApplicationOnCreate(android.app.Application arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callApplicationOnCreate1887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callApplicationOnCreate1887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newActivity1888;
		public virtual global::android.app.Activity newActivity(java.lang.ClassLoader arg0, java.lang.String arg1, android.content.Intent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._newActivity1888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newActivity1888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _newActivity1889;
		public virtual global::android.app.Activity newActivity(java.lang.Class arg0, android.content.Context arg1, android.os.IBinder arg2, android.app.Application arg3, android.content.Intent arg4, android.content.pm.ActivityInfo arg5, java.lang.CharSequence arg6, android.app.Activity arg7, java.lang.String arg8, java.lang.Object arg9) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._newActivity1889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newActivity1889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9))) as android.app.Activity;
		}
		public android.app.Activity newActivity(java.lang.Class arg0, android.content.Context arg1, android.os.IBinder arg2, android.app.Application arg3, android.content.Intent arg4, android.content.pm.ActivityInfo arg5, string arg6, android.app.Activity arg7, java.lang.String arg8, java.lang.Object arg9)
		{
			return newActivity(arg0, arg1, arg2, arg3, arg4, arg5, (global::java.lang.CharSequence)(global::java.lang.String)arg6, arg7, arg8, arg9);
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnCreate1890;
		public virtual void callActivityOnCreate(android.app.Activity arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnCreate1890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnCreate1890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnDestroy1891;
		public virtual void callActivityOnDestroy(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnDestroy1891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnDestroy1891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnRestoreInstanceState1892;
		public virtual void callActivityOnRestoreInstanceState(android.app.Activity arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnRestoreInstanceState1892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnRestoreInstanceState1892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnPostCreate1893;
		public virtual void callActivityOnPostCreate(android.app.Activity arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnPostCreate1893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnPostCreate1893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnNewIntent1894;
		public virtual void callActivityOnNewIntent(android.app.Activity arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnNewIntent1894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnNewIntent1894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnStart1895;
		public virtual void callActivityOnStart(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnStart1895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnStart1895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnRestart1896;
		public virtual void callActivityOnRestart(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnRestart1896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnRestart1896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnResume1897;
		public virtual void callActivityOnResume(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnResume1897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnResume1897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnStop1898;
		public virtual void callActivityOnStop(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnStop1898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnStop1898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnSaveInstanceState1899;
		public virtual void callActivityOnSaveInstanceState(android.app.Activity arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnSaveInstanceState1899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnSaveInstanceState1899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnPause1900;
		public virtual void callActivityOnPause(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnPause1900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnPause1900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnUserLeaving1901;
		public virtual void callActivityOnUserLeaving(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnUserLeaving1901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnUserLeaving1901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.os.Bundle AllocCounts
		{
			get
			{
				return getAllocCounts();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllocCounts1902;
		public virtual global::android.os.Bundle getAllocCounts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._getAllocCounts1902)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getAllocCounts1902)) as android.os.Bundle;
		}
		public new global::android.os.Bundle BinderCounts
		{
			get
			{
				return getBinderCounts();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderCounts1903;
		public virtual global::android.os.Bundle getBinderCounts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._getBinderCounts1903)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getBinderCounts1903)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _Instrumentation1904;
		public Instrumentation()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.staticClass, global::android.app.Instrumentation._Instrumentation1904);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Instrumentation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Instrumentation"));
			global::android.app.Instrumentation._start1847 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "start", "()V");
			global::android.app.Instrumentation._getContext1848 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.app.Instrumentation._onCreate1849 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Instrumentation._onStart1850 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "onStart", "()V");
			global::android.app.Instrumentation._onDestroy1851 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "onDestroy", "()V");
			global::android.app.Instrumentation._finish1852 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "finish", "(ILandroid/os/Bundle;)V");
			global::android.app.Instrumentation._getComponentName1853 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "getComponentName", "()Landroid/content/ComponentName;");
			global::android.app.Instrumentation._startAllocCounting1854 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "startAllocCounting", "()V");
			global::android.app.Instrumentation._stopAllocCounting1855 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "stopAllocCounting", "()V");
			global::android.app.Instrumentation._onException1856 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "onException", "(Ljava/lang/Object;Ljava/lang/Throwable;)Z");
			global::android.app.Instrumentation._sendStatus1857 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "sendStatus", "(ILandroid/os/Bundle;)V");
			global::android.app.Instrumentation._setAutomaticPerformanceSnapshots1858 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "setAutomaticPerformanceSnapshots", "()V");
			global::android.app.Instrumentation._startPerformanceSnapshot1859 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "startPerformanceSnapshot", "()V");
			global::android.app.Instrumentation._endPerformanceSnapshot1860 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "endPerformanceSnapshot", "()V");
			global::android.app.Instrumentation._getTargetContext1861 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "getTargetContext", "()Landroid/content/Context;");
			global::android.app.Instrumentation._isProfiling1862 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "isProfiling", "()Z");
			global::android.app.Instrumentation._startProfiling1863 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "startProfiling", "()V");
			global::android.app.Instrumentation._stopProfiling1864 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "stopProfiling", "()V");
			global::android.app.Instrumentation._setInTouchMode1865 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "setInTouchMode", "(Z)V");
			global::android.app.Instrumentation._waitForIdle1866 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "waitForIdle", "(Ljava/lang/Runnable;)V");
			global::android.app.Instrumentation._waitForIdleSync1867 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "waitForIdleSync", "()V");
			global::android.app.Instrumentation._runOnMainSync1868 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "runOnMainSync", "(Ljava/lang/Runnable;)V");
			global::android.app.Instrumentation._startActivitySync1869 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "startActivitySync", "(Landroid/content/Intent;)Landroid/app/Activity;");
			global::android.app.Instrumentation._addMonitor1870 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "addMonitor", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)Landroid/app/Instrumentation$ActivityMonitor;");
			global::android.app.Instrumentation._addMonitor1871 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "addMonitor", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)Landroid/app/Instrumentation$ActivityMonitor;");
			global::android.app.Instrumentation._addMonitor1872 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "addMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V");
			global::android.app.Instrumentation._checkMonitorHit1873 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "checkMonitorHit", "(Landroid/app/Instrumentation$ActivityMonitor;I)Z");
			global::android.app.Instrumentation._waitForMonitor1874 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "waitForMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)Landroid/app/Activity;");
			global::android.app.Instrumentation._waitForMonitorWithTimeout1875 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "waitForMonitorWithTimeout", "(Landroid/app/Instrumentation$ActivityMonitor;J)Landroid/app/Activity;");
			global::android.app.Instrumentation._removeMonitor1876 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "removeMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V");
			global::android.app.Instrumentation._invokeMenuActionSync1877 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "invokeMenuActionSync", "(Landroid/app/Activity;II)Z");
			global::android.app.Instrumentation._invokeContextMenuAction1878 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "invokeContextMenuAction", "(Landroid/app/Activity;II)Z");
			global::android.app.Instrumentation._sendStringSync1879 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "sendStringSync", "(Ljava/lang/String;)V");
			global::android.app.Instrumentation._sendKeySync1880 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "sendKeySync", "(Landroid/view/KeyEvent;)V");
			global::android.app.Instrumentation._sendKeyDownUpSync1881 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "sendKeyDownUpSync", "(I)V");
			global::android.app.Instrumentation._sendCharacterSync1882 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "sendCharacterSync", "(I)V");
			global::android.app.Instrumentation._sendPointerSync1883 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "sendPointerSync", "(Landroid/view/MotionEvent;)V");
			global::android.app.Instrumentation._sendTrackballEventSync1884 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "sendTrackballEventSync", "(Landroid/view/MotionEvent;)V");
			global::android.app.Instrumentation._newApplication1885 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "newApplication", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Context;)Landroid/app/Application;");
			global::android.app.Instrumentation._newApplication1886 = @__env.GetStaticMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "newApplication", "(Ljava/lang/Class;Landroid/content/Context;)Landroid/app/Application;");
			global::android.app.Instrumentation._callApplicationOnCreate1887 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callApplicationOnCreate", "(Landroid/app/Application;)V");
			global::android.app.Instrumentation._newActivity1888 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "newActivity", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Intent;)Landroid/app/Activity;");
			global::android.app.Instrumentation._newActivity1889 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "newActivity", "(Ljava/lang/Class;Landroid/content/Context;Landroid/os/IBinder;Landroid/app/Application;Landroid/content/Intent;Landroid/content/pm/ActivityInfo;Ljava/lang/CharSequence;Landroid/app/Activity;Ljava/lang/String;Ljava/lang/Object;)Landroid/app/Activity;");
			global::android.app.Instrumentation._callActivityOnCreate1890 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			global::android.app.Instrumentation._callActivityOnDestroy1891 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnDestroy", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnRestoreInstanceState1892 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnRestoreInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			global::android.app.Instrumentation._callActivityOnPostCreate1893 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnPostCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			global::android.app.Instrumentation._callActivityOnNewIntent1894 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnNewIntent", "(Landroid/app/Activity;Landroid/content/Intent;)V");
			global::android.app.Instrumentation._callActivityOnStart1895 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnStart", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnRestart1896 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnRestart", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnResume1897 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnResume", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnStop1898 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnStop", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnSaveInstanceState1899 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnSaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			global::android.app.Instrumentation._callActivityOnPause1900 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnPause", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnUserLeaving1901 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnUserLeaving", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._getAllocCounts1902 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "getAllocCounts", "()Landroid/os/Bundle;");
			global::android.app.Instrumentation._getBinderCounts1903 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "getBinderCounts", "()Landroid/os/Bundle;");
			global::android.app.Instrumentation._Instrumentation1904 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "<init>", "()V");
		}
	}
}
