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
			internal static global::MonoJavaBridge.MethodId _getFilter551;
			public virtual global::android.content.IntentFilter getFilter() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor._getFilter551)) as android.content.IntentFilter;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getFilter551)) as android.content.IntentFilter;
			}
			public new global::android.app.Instrumentation.ActivityResult Result
			{
				get
				{
					return getResult();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getResult552;
			public virtual global::android.app.Instrumentation.ActivityResult getResult() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor._getResult552)) as android.app.Instrumentation.ActivityResult;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getResult552)) as android.app.Instrumentation.ActivityResult;
			}
			internal static global::MonoJavaBridge.MethodId _isBlocking553;
			public virtual bool isBlocking() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor._isBlocking553);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._isBlocking553);
			}
			public new int Hits
			{
				get
				{
					return getHits();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHits554;
			public virtual int getHits() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor._getHits554);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getHits554);
			}
			public new global::android.app.Activity LastActivity
			{
				get
				{
					return getLastActivity();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getLastActivity555;
			public virtual global::android.app.Activity getLastActivity() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor._getLastActivity555)) as android.app.Activity;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getLastActivity555)) as android.app.Activity;
			}
			internal static global::MonoJavaBridge.MethodId _waitForActivity556;
			public virtual global::android.app.Activity waitForActivity() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor._waitForActivity556)) as android.app.Activity;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._waitForActivity556)) as android.app.Activity;
			}
			internal static global::MonoJavaBridge.MethodId _waitForActivityWithTimeout557;
			public virtual global::android.app.Activity waitForActivityWithTimeout(long arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor._waitForActivityWithTimeout557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._waitForActivityWithTimeout557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
			}
			internal static global::MonoJavaBridge.MethodId _ActivityMonitor558;
			public ActivityMonitor(android.content.IntentFilter arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _ActivityMonitor559;
			public ActivityMonitor(java.lang.String arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.Instrumentation.ActivityMonitor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Instrumentation$ActivityMonitor"));
				global::android.app.Instrumentation.ActivityMonitor._getFilter551 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getFilter", "()Landroid/content/IntentFilter;");
				global::android.app.Instrumentation.ActivityMonitor._getResult552 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getResult", "()Landroid/app/Instrumentation$ActivityResult;");
				global::android.app.Instrumentation.ActivityMonitor._isBlocking553 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "isBlocking", "()Z");
				global::android.app.Instrumentation.ActivityMonitor._getHits554 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getHits", "()I");
				global::android.app.Instrumentation.ActivityMonitor._getLastActivity555 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getLastActivity", "()Landroid/app/Activity;");
				global::android.app.Instrumentation.ActivityMonitor._waitForActivity556 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "waitForActivity", "()Landroid/app/Activity;");
				global::android.app.Instrumentation.ActivityMonitor._waitForActivityWithTimeout557 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "waitForActivityWithTimeout", "(J)Landroid/app/Activity;");
				global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor558 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "<init>", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)V");
				global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor559 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "<init>", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)V");
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
			internal static global::MonoJavaBridge.MethodId _getResultCode560;
			public int getResultCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityResult._getResultCode560);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityResult.staticClass, global::android.app.Instrumentation.ActivityResult._getResultCode560);
			}
			public new global::android.content.Intent ResultData
			{
				get
				{
					return getResultData();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getResultData561;
			public global::android.content.Intent getResultData() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityResult._getResultData561)) as android.content.Intent;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.ActivityResult.staticClass, global::android.app.Instrumentation.ActivityResult._getResultData561)) as android.content.Intent;
			}
			internal static global::MonoJavaBridge.MethodId _ActivityResult562;
			public ActivityResult(int arg0, android.content.Intent arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.ActivityResult.staticClass, global::android.app.Instrumentation.ActivityResult._ActivityResult562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.Instrumentation.ActivityResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Instrumentation$ActivityResult"));
				global::android.app.Instrumentation.ActivityResult._getResultCode560 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityResult.staticClass, "getResultCode", "()I");
				global::android.app.Instrumentation.ActivityResult._getResultData561 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityResult.staticClass, "getResultData", "()Landroid/content/Intent;");
				global::android.app.Instrumentation.ActivityResult._ActivityResult562 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityResult.staticClass, "<init>", "(ILandroid/content/Intent;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _start563;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._start563);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._start563);
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext564;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._getContext564)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getContext564)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _onCreate565;
		public virtual void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._onCreate565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onCreate565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStart566;
		public virtual void onStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._onStart566);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onStart566);
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy567;
		public virtual void onDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._onDestroy567);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onDestroy567);
		}
		internal static global::MonoJavaBridge.MethodId _finish568;
		public virtual void finish(int arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._finish568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._finish568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.content.ComponentName ComponentName
		{
			get
			{
				return getComponentName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComponentName569;
		public virtual global::android.content.ComponentName getComponentName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._getComponentName569)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getComponentName569)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _startAllocCounting570;
		public virtual void startAllocCounting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._startAllocCounting570);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startAllocCounting570);
		}
		internal static global::MonoJavaBridge.MethodId _stopAllocCounting571;
		public virtual void stopAllocCounting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._stopAllocCounting571);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._stopAllocCounting571);
		}
		internal static global::MonoJavaBridge.MethodId _onException572;
		public virtual bool onException(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Instrumentation._onException572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onException572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sendStatus573;
		public virtual void sendStatus(int arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._sendStatus573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendStatus573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAutomaticPerformanceSnapshots574;
		public virtual void setAutomaticPerformanceSnapshots() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._setAutomaticPerformanceSnapshots574);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._setAutomaticPerformanceSnapshots574);
		}
		internal static global::MonoJavaBridge.MethodId _startPerformanceSnapshot575;
		public virtual void startPerformanceSnapshot() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._startPerformanceSnapshot575);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startPerformanceSnapshot575);
		}
		internal static global::MonoJavaBridge.MethodId _endPerformanceSnapshot576;
		public virtual void endPerformanceSnapshot() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._endPerformanceSnapshot576);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._endPerformanceSnapshot576);
		}
		public new global::android.content.Context TargetContext
		{
			get
			{
				return getTargetContext();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTargetContext577;
		public virtual global::android.content.Context getTargetContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._getTargetContext577)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getTargetContext577)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _isProfiling578;
		public virtual bool isProfiling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Instrumentation._isProfiling578);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._isProfiling578);
		}
		internal static global::MonoJavaBridge.MethodId _startProfiling579;
		public virtual void startProfiling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._startProfiling579);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startProfiling579);
		}
		internal static global::MonoJavaBridge.MethodId _stopProfiling580;
		public virtual void stopProfiling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._stopProfiling580);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._stopProfiling580);
		}
		internal static global::MonoJavaBridge.MethodId _setInTouchMode581;
		public virtual void setInTouchMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._setInTouchMode581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._setInTouchMode581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _waitForIdle582;
		public virtual void waitForIdle(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._waitForIdle582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForIdle582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _waitForIdleSync583;
		public virtual void waitForIdleSync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._waitForIdleSync583);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForIdleSync583);
		}
		internal static global::MonoJavaBridge.MethodId _runOnMainSync584;
		public virtual void runOnMainSync(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._runOnMainSync584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._runOnMainSync584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startActivitySync585;
		public virtual global::android.app.Activity startActivitySync(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._startActivitySync585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startActivitySync585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _addMonitor586;
		public virtual global::android.app.Instrumentation.ActivityMonitor addMonitor(android.content.IntentFilter arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._addMonitor586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Instrumentation.ActivityMonitor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._addMonitor586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Instrumentation.ActivityMonitor;
		}
		internal static global::MonoJavaBridge.MethodId _addMonitor587;
		public virtual global::android.app.Instrumentation.ActivityMonitor addMonitor(java.lang.String arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._addMonitor587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Instrumentation.ActivityMonitor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._addMonitor587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Instrumentation.ActivityMonitor;
		}
		internal static global::MonoJavaBridge.MethodId _addMonitor588;
		public virtual void addMonitor(android.app.Instrumentation.ActivityMonitor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._addMonitor588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._addMonitor588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _checkMonitorHit589;
		public virtual bool checkMonitorHit(android.app.Instrumentation.ActivityMonitor arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Instrumentation._checkMonitorHit589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._checkMonitorHit589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _waitForMonitor590;
		public virtual global::android.app.Activity waitForMonitor(android.app.Instrumentation.ActivityMonitor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._waitForMonitor590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForMonitor590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _waitForMonitorWithTimeout591;
		public virtual global::android.app.Activity waitForMonitorWithTimeout(android.app.Instrumentation.ActivityMonitor arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._waitForMonitorWithTimeout591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForMonitorWithTimeout591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _removeMonitor592;
		public virtual void removeMonitor(android.app.Instrumentation.ActivityMonitor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._removeMonitor592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._removeMonitor592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invokeMenuActionSync593;
		public virtual bool invokeMenuActionSync(android.app.Activity arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Instrumentation._invokeMenuActionSync593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._invokeMenuActionSync593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _invokeContextMenuAction594;
		public virtual bool invokeContextMenuAction(android.app.Activity arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Instrumentation._invokeContextMenuAction594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._invokeContextMenuAction594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _sendStringSync595;
		public virtual void sendStringSync(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._sendStringSync595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendStringSync595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeySync596;
		public virtual void sendKeySync(android.view.KeyEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._sendKeySync596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendKeySync596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendKeyDownUpSync597;
		public virtual void sendKeyDownUpSync(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._sendKeyDownUpSync597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendKeyDownUpSync597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendCharacterSync598;
		public virtual void sendCharacterSync(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._sendCharacterSync598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendCharacterSync598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendPointerSync599;
		public virtual void sendPointerSync(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._sendPointerSync599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendPointerSync599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sendTrackballEventSync600;
		public virtual void sendTrackballEventSync(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._sendTrackballEventSync600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendTrackballEventSync600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newApplication601;
		public virtual global::android.app.Application newApplication(java.lang.ClassLoader arg0, java.lang.String arg1, android.content.Context arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._newApplication601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Application;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newApplication601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _newApplication602;
		public static global::android.app.Application newApplication(java.lang.Class arg0, android.content.Context arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newApplication602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _callApplicationOnCreate603;
		public virtual void callApplicationOnCreate(android.app.Application arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callApplicationOnCreate603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callApplicationOnCreate603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _newActivity604;
		public virtual global::android.app.Activity newActivity(java.lang.ClassLoader arg0, java.lang.String arg1, android.content.Intent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._newActivity604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newActivity604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _newActivity605;
		public virtual global::android.app.Activity newActivity(java.lang.Class arg0, android.content.Context arg1, android.os.IBinder arg2, android.app.Application arg3, android.content.Intent arg4, android.content.pm.ActivityInfo arg5, java.lang.CharSequence arg6, android.app.Activity arg7, java.lang.String arg8, java.lang.Object arg9) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._newActivity605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9))) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newActivity605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9))) as android.app.Activity;
		}
		public android.app.Activity newActivity(java.lang.Class arg0, android.content.Context arg1, android.os.IBinder arg2, android.app.Application arg3, android.content.Intent arg4, android.content.pm.ActivityInfo arg5, string arg6, android.app.Activity arg7, java.lang.String arg8, java.lang.Object arg9)
		{
			return newActivity(arg0, arg1, arg2, arg3, arg4, arg5, (global::java.lang.CharSequence)(global::java.lang.String)arg6, arg7, arg8, arg9);
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnCreate606;
		public virtual void callActivityOnCreate(android.app.Activity arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnCreate606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnCreate606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnDestroy607;
		public virtual void callActivityOnDestroy(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnDestroy607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnDestroy607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnRestoreInstanceState608;
		public virtual void callActivityOnRestoreInstanceState(android.app.Activity arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnRestoreInstanceState608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnRestoreInstanceState608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnPostCreate609;
		public virtual void callActivityOnPostCreate(android.app.Activity arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnPostCreate609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnPostCreate609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnNewIntent610;
		public virtual void callActivityOnNewIntent(android.app.Activity arg0, android.content.Intent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnNewIntent610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnNewIntent610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnStart611;
		public virtual void callActivityOnStart(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnStart611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnStart611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnRestart612;
		public virtual void callActivityOnRestart(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnRestart612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnRestart612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnResume613;
		public virtual void callActivityOnResume(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnResume613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnResume613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnStop614;
		public virtual void callActivityOnStop(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnStop614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnStop614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnSaveInstanceState615;
		public virtual void callActivityOnSaveInstanceState(android.app.Activity arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnSaveInstanceState615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnSaveInstanceState615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnPause616;
		public virtual void callActivityOnPause(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnPause616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnPause616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _callActivityOnUserLeaving617;
		public virtual void callActivityOnUserLeaving(android.app.Activity arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Instrumentation._callActivityOnUserLeaving617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnUserLeaving617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.os.Bundle AllocCounts
		{
			get
			{
				return getAllocCounts();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllocCounts618;
		public virtual global::android.os.Bundle getAllocCounts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._getAllocCounts618)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getAllocCounts618)) as android.os.Bundle;
		}
		public new global::android.os.Bundle BinderCounts
		{
			get
			{
				return getBinderCounts();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBinderCounts619;
		public virtual global::android.os.Bundle getBinderCounts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Instrumentation._getBinderCounts619)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getBinderCounts619)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _Instrumentation620;
		public Instrumentation()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.staticClass, global::android.app.Instrumentation._Instrumentation620);
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
			global::android.app.Instrumentation._start563 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "start", "()V");
			global::android.app.Instrumentation._getContext564 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.app.Instrumentation._onCreate565 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Instrumentation._onStart566 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "onStart", "()V");
			global::android.app.Instrumentation._onDestroy567 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "onDestroy", "()V");
			global::android.app.Instrumentation._finish568 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "finish", "(ILandroid/os/Bundle;)V");
			global::android.app.Instrumentation._getComponentName569 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "getComponentName", "()Landroid/content/ComponentName;");
			global::android.app.Instrumentation._startAllocCounting570 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "startAllocCounting", "()V");
			global::android.app.Instrumentation._stopAllocCounting571 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "stopAllocCounting", "()V");
			global::android.app.Instrumentation._onException572 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "onException", "(Ljava/lang/Object;Ljava/lang/Throwable;)Z");
			global::android.app.Instrumentation._sendStatus573 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "sendStatus", "(ILandroid/os/Bundle;)V");
			global::android.app.Instrumentation._setAutomaticPerformanceSnapshots574 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "setAutomaticPerformanceSnapshots", "()V");
			global::android.app.Instrumentation._startPerformanceSnapshot575 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "startPerformanceSnapshot", "()V");
			global::android.app.Instrumentation._endPerformanceSnapshot576 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "endPerformanceSnapshot", "()V");
			global::android.app.Instrumentation._getTargetContext577 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "getTargetContext", "()Landroid/content/Context;");
			global::android.app.Instrumentation._isProfiling578 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "isProfiling", "()Z");
			global::android.app.Instrumentation._startProfiling579 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "startProfiling", "()V");
			global::android.app.Instrumentation._stopProfiling580 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "stopProfiling", "()V");
			global::android.app.Instrumentation._setInTouchMode581 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "setInTouchMode", "(Z)V");
			global::android.app.Instrumentation._waitForIdle582 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "waitForIdle", "(Ljava/lang/Runnable;)V");
			global::android.app.Instrumentation._waitForIdleSync583 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "waitForIdleSync", "()V");
			global::android.app.Instrumentation._runOnMainSync584 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "runOnMainSync", "(Ljava/lang/Runnable;)V");
			global::android.app.Instrumentation._startActivitySync585 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "startActivitySync", "(Landroid/content/Intent;)Landroid/app/Activity;");
			global::android.app.Instrumentation._addMonitor586 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "addMonitor", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)Landroid/app/Instrumentation$ActivityMonitor;");
			global::android.app.Instrumentation._addMonitor587 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "addMonitor", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)Landroid/app/Instrumentation$ActivityMonitor;");
			global::android.app.Instrumentation._addMonitor588 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "addMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V");
			global::android.app.Instrumentation._checkMonitorHit589 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "checkMonitorHit", "(Landroid/app/Instrumentation$ActivityMonitor;I)Z");
			global::android.app.Instrumentation._waitForMonitor590 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "waitForMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)Landroid/app/Activity;");
			global::android.app.Instrumentation._waitForMonitorWithTimeout591 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "waitForMonitorWithTimeout", "(Landroid/app/Instrumentation$ActivityMonitor;J)Landroid/app/Activity;");
			global::android.app.Instrumentation._removeMonitor592 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "removeMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V");
			global::android.app.Instrumentation._invokeMenuActionSync593 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "invokeMenuActionSync", "(Landroid/app/Activity;II)Z");
			global::android.app.Instrumentation._invokeContextMenuAction594 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "invokeContextMenuAction", "(Landroid/app/Activity;II)Z");
			global::android.app.Instrumentation._sendStringSync595 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "sendStringSync", "(Ljava/lang/String;)V");
			global::android.app.Instrumentation._sendKeySync596 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "sendKeySync", "(Landroid/view/KeyEvent;)V");
			global::android.app.Instrumentation._sendKeyDownUpSync597 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "sendKeyDownUpSync", "(I)V");
			global::android.app.Instrumentation._sendCharacterSync598 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "sendCharacterSync", "(I)V");
			global::android.app.Instrumentation._sendPointerSync599 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "sendPointerSync", "(Landroid/view/MotionEvent;)V");
			global::android.app.Instrumentation._sendTrackballEventSync600 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "sendTrackballEventSync", "(Landroid/view/MotionEvent;)V");
			global::android.app.Instrumentation._newApplication601 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "newApplication", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Context;)Landroid/app/Application;");
			global::android.app.Instrumentation._newApplication602 = @__env.GetStaticMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "newApplication", "(Ljava/lang/Class;Landroid/content/Context;)Landroid/app/Application;");
			global::android.app.Instrumentation._callApplicationOnCreate603 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callApplicationOnCreate", "(Landroid/app/Application;)V");
			global::android.app.Instrumentation._newActivity604 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "newActivity", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Intent;)Landroid/app/Activity;");
			global::android.app.Instrumentation._newActivity605 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "newActivity", "(Ljava/lang/Class;Landroid/content/Context;Landroid/os/IBinder;Landroid/app/Application;Landroid/content/Intent;Landroid/content/pm/ActivityInfo;Ljava/lang/CharSequence;Landroid/app/Activity;Ljava/lang/String;Ljava/lang/Object;)Landroid/app/Activity;");
			global::android.app.Instrumentation._callActivityOnCreate606 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			global::android.app.Instrumentation._callActivityOnDestroy607 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnDestroy", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnRestoreInstanceState608 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnRestoreInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			global::android.app.Instrumentation._callActivityOnPostCreate609 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnPostCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			global::android.app.Instrumentation._callActivityOnNewIntent610 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnNewIntent", "(Landroid/app/Activity;Landroid/content/Intent;)V");
			global::android.app.Instrumentation._callActivityOnStart611 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnStart", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnRestart612 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnRestart", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnResume613 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnResume", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnStop614 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnStop", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnSaveInstanceState615 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnSaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			global::android.app.Instrumentation._callActivityOnPause616 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnPause", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnUserLeaving617 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "callActivityOnUserLeaving", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._getAllocCounts618 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "getAllocCounts", "()Landroid/os/Bundle;");
			global::android.app.Instrumentation._getBinderCounts619 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "getBinderCounts", "()Landroid/os/Bundle;");
			global::android.app.Instrumentation._Instrumentation620 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "<init>", "()V");
		}
	}
}
