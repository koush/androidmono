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
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual global::android.content.IntentFilter getFilter()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, "getFilter", "()Landroid/content/IntentFilter;", ref global::android.app.Instrumentation.ActivityMonitor._m0) as android.content.IntentFilter;
			}
			public new global::android.app.Instrumentation.ActivityResult Result
			{
				get
				{
					return getResult();
				}
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual global::android.app.Instrumentation.ActivityResult getResult()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.app.Instrumentation.ActivityResult>(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, "getResult", "()Landroid/app/Instrumentation$ActivityResult;", ref global::android.app.Instrumentation.ActivityMonitor._m1) as android.app.Instrumentation.ActivityResult;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual bool isBlocking()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, "isBlocking", "()Z", ref global::android.app.Instrumentation.ActivityMonitor._m2);
			}
			public new int Hits
			{
				get
				{
					return getHits();
				}
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual int getHits()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, "getHits", "()I", ref global::android.app.Instrumentation.ActivityMonitor._m3);
			}
			public new global::android.app.Activity LastActivity
			{
				get
				{
					return getLastActivity();
				}
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual global::android.app.Activity getLastActivity()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, "getLastActivity", "()Landroid/app/Activity;", ref global::android.app.Instrumentation.ActivityMonitor._m4) as android.app.Activity;
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual global::android.app.Activity waitForActivity()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, "waitForActivity", "()Landroid/app/Activity;", ref global::android.app.Instrumentation.ActivityMonitor._m5) as android.app.Activity;
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public virtual global::android.app.Activity waitForActivityWithTimeout(long arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, "waitForActivityWithTimeout", "(J)Landroid/app/Activity;", ref global::android.app.Instrumentation.ActivityMonitor._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.Activity;
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public ActivityMonitor(android.content.IntentFilter arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.Instrumentation.ActivityMonitor._m7.native == global::System.IntPtr.Zero)
					global::android.app.Instrumentation.ActivityMonitor._m7 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "<init>", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public ActivityMonitor(java.lang.String arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.Instrumentation.ActivityMonitor._m8.native == global::System.IntPtr.Zero)
					global::android.app.Instrumentation.ActivityMonitor._m8 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityMonitor.staticClass, "<init>", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			static ActivityMonitor()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.Instrumentation.ActivityMonitor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Instrumentation$ActivityMonitor"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			public int getResultCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Instrumentation.ActivityResult.staticClass, "getResultCode", "()I", ref global::android.app.Instrumentation.ActivityResult._m0);
			}
			public new global::android.content.Intent ResultData
			{
				get
				{
					return getResultData();
				}
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public global::android.content.Intent getResultData()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.ActivityResult.staticClass, "getResultData", "()Landroid/content/Intent;", ref global::android.app.Instrumentation.ActivityResult._m1) as android.content.Intent;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public ActivityResult(int arg0, android.content.Intent arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.Instrumentation.ActivityResult._m2.native == global::System.IntPtr.Zero)
					global::android.app.Instrumentation.ActivityResult._m2 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.ActivityResult.staticClass, "<init>", "(ILandroid/content/Intent;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.ActivityResult.staticClass, global::android.app.Instrumentation.ActivityResult._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			static ActivityResult()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.Instrumentation.ActivityResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Instrumentation$ActivityResult"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "start", "()V", ref global::android.app.Instrumentation._m0);
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.content.Context getContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "getContext", "()Landroid/content/Context;", ref global::android.app.Instrumentation._m1) as android.content.Context;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "onCreate", "(Landroid/os/Bundle;)V", ref global::android.app.Instrumentation._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void onStart()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "onStart", "()V", ref global::android.app.Instrumentation._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "onDestroy", "()V", ref global::android.app.Instrumentation._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void finish(int arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "finish", "(ILandroid/os/Bundle;)V", ref global::android.app.Instrumentation._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.content.ComponentName ComponentName
		{
			get
			{
				return getComponentName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.content.ComponentName getComponentName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.app.Instrumentation.staticClass, "getComponentName", "()Landroid/content/ComponentName;", ref global::android.app.Instrumentation._m6) as android.content.ComponentName;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void startAllocCounting()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "startAllocCounting", "()V", ref global::android.app.Instrumentation._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void stopAllocCounting()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "stopAllocCounting", "()V", ref global::android.app.Instrumentation._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool onException(java.lang.Object arg0, java.lang.Throwable arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Instrumentation.staticClass, "onException", "(Ljava/lang/Object;Ljava/lang/Throwable;)Z", ref global::android.app.Instrumentation._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void sendStatus(int arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "sendStatus", "(ILandroid/os/Bundle;)V", ref global::android.app.Instrumentation._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setAutomaticPerformanceSnapshots()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "setAutomaticPerformanceSnapshots", "()V", ref global::android.app.Instrumentation._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void startPerformanceSnapshot()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "startPerformanceSnapshot", "()V", ref global::android.app.Instrumentation._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void endPerformanceSnapshot()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "endPerformanceSnapshot", "()V", ref global::android.app.Instrumentation._m13);
		}
		public new global::android.content.Context TargetContext
		{
			get
			{
				return getTargetContext();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::android.content.Context getTargetContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "getTargetContext", "()Landroid/content/Context;", ref global::android.app.Instrumentation._m14) as android.content.Context;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool isProfiling()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Instrumentation.staticClass, "isProfiling", "()Z", ref global::android.app.Instrumentation._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void startProfiling()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "startProfiling", "()V", ref global::android.app.Instrumentation._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void stopProfiling()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "stopProfiling", "()V", ref global::android.app.Instrumentation._m17);
		}
		public new bool InTouchMode
		{
			set
			{
				setInTouchMode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setInTouchMode(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "setInTouchMode", "(Z)V", ref global::android.app.Instrumentation._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void waitForIdle(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "waitForIdle", "(Ljava/lang/Runnable;)V", ref global::android.app.Instrumentation._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void waitForIdle(global::java.lang.RunnableDelegate arg0)
		{
			waitForIdle((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void waitForIdleSync()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "waitForIdleSync", "()V", ref global::android.app.Instrumentation._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void runOnMainSync(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "runOnMainSync", "(Ljava/lang/Runnable;)V", ref global::android.app.Instrumentation._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void runOnMainSync(global::java.lang.RunnableDelegate arg0)
		{
			runOnMainSync((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::android.app.Activity startActivitySync(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "startActivitySync", "(Landroid/content/Intent;)Landroid/app/Activity;", ref global::android.app.Instrumentation._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.Activity;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::android.app.Instrumentation.ActivityMonitor addMonitor(android.content.IntentFilter arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "addMonitor", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)Landroid/app/Instrumentation$ActivityMonitor;", ref global::android.app.Instrumentation._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.Instrumentation.ActivityMonitor;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual global::android.app.Instrumentation.ActivityMonitor addMonitor(java.lang.String arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "addMonitor", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)Landroid/app/Instrumentation$ActivityMonitor;", ref global::android.app.Instrumentation._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.Instrumentation.ActivityMonitor;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void addMonitor(android.app.Instrumentation.ActivityMonitor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "addMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V", ref global::android.app.Instrumentation._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool checkMonitorHit(android.app.Instrumentation.ActivityMonitor arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Instrumentation.staticClass, "checkMonitorHit", "(Landroid/app/Instrumentation$ActivityMonitor;I)Z", ref global::android.app.Instrumentation._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::android.app.Activity waitForMonitor(android.app.Instrumentation.ActivityMonitor arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "waitForMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)Landroid/app/Activity;", ref global::android.app.Instrumentation._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.Activity;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::android.app.Activity waitForMonitorWithTimeout(android.app.Instrumentation.ActivityMonitor arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "waitForMonitorWithTimeout", "(Landroid/app/Instrumentation$ActivityMonitor;J)Landroid/app/Activity;", ref global::android.app.Instrumentation._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.app.Activity;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void removeMonitor(android.app.Instrumentation.ActivityMonitor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "removeMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V", ref global::android.app.Instrumentation._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual bool invokeMenuActionSync(android.app.Activity arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Instrumentation.staticClass, "invokeMenuActionSync", "(Landroid/app/Activity;II)Z", ref global::android.app.Instrumentation._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual bool invokeContextMenuAction(android.app.Activity arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Instrumentation.staticClass, "invokeContextMenuAction", "(Landroid/app/Activity;II)Z", ref global::android.app.Instrumentation._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void sendStringSync(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "sendStringSync", "(Ljava/lang/String;)V", ref global::android.app.Instrumentation._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void sendKeySync(android.view.KeyEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "sendKeySync", "(Landroid/view/KeyEvent;)V", ref global::android.app.Instrumentation._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void sendKeyDownUpSync(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "sendKeyDownUpSync", "(I)V", ref global::android.app.Instrumentation._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void sendCharacterSync(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "sendCharacterSync", "(I)V", ref global::android.app.Instrumentation._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void sendPointerSync(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "sendPointerSync", "(Landroid/view/MotionEvent;)V", ref global::android.app.Instrumentation._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void sendTrackballEventSync(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "sendTrackballEventSync", "(Landroid/view/MotionEvent;)V", ref global::android.app.Instrumentation._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual global::android.app.Application newApplication(java.lang.ClassLoader arg0, java.lang.String arg1, android.content.Context arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "newApplication", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Context;)Landroid/app/Application;", ref global::android.app.Instrumentation._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.Application;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public static global::android.app.Application newApplication(java.lang.Class arg0, android.content.Context arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Instrumentation._m39.native == global::System.IntPtr.Zero)
				global::android.app.Instrumentation._m39 = @__env.GetStaticMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "newApplication", "(Ljava/lang/Class;Landroid/content/Context;)Landroid/app/Application;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.Instrumentation.staticClass, global::android.app.Instrumentation._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.Application;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual void callApplicationOnCreate(android.app.Application arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callApplicationOnCreate", "(Landroid/app/Application;)V", ref global::android.app.Instrumentation._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual global::android.app.Activity newActivity(java.lang.ClassLoader arg0, java.lang.String arg1, android.content.Intent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "newActivity", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Intent;)Landroid/app/Activity;", ref global::android.app.Instrumentation._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.Activity;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual global::android.app.Activity newActivity(java.lang.Class arg0, android.content.Context arg1, android.os.IBinder arg2, android.app.Application arg3, android.content.Intent arg4, android.content.pm.ActivityInfo arg5, java.lang.CharSequence arg6, android.app.Activity arg7, java.lang.String arg8, java.lang.Object arg9)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Instrumentation.staticClass, "newActivity", "(Ljava/lang/Class;Landroid/content/Context;Landroid/os/IBinder;Landroid/app/Application;Landroid/content/Intent;Landroid/content/pm/ActivityInfo;Ljava/lang/CharSequence;Landroid/app/Activity;Ljava/lang/String;Ljava/lang/Object;)Landroid/app/Activity;", ref global::android.app.Instrumentation._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9)) as android.app.Activity;
		}
		public android.app.Activity newActivity(java.lang.Class arg0, android.content.Context arg1, android.os.IBinder arg2, android.app.Application arg3, android.content.Intent arg4, android.content.pm.ActivityInfo arg5, string arg6, android.app.Activity arg7, java.lang.String arg8, java.lang.Object arg9)
		{
			return newActivity(arg0, arg1, arg2, arg3, arg4, arg5, (global::java.lang.CharSequence)(global::java.lang.String)arg6, arg7, arg8, arg9);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual void callActivityOnCreate(android.app.Activity arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V", ref global::android.app.Instrumentation._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual void callActivityOnDestroy(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnDestroy", "(Landroid/app/Activity;)V", ref global::android.app.Instrumentation._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual void callActivityOnRestoreInstanceState(android.app.Activity arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnRestoreInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", ref global::android.app.Instrumentation._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual void callActivityOnPostCreate(android.app.Activity arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnPostCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V", ref global::android.app.Instrumentation._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual void callActivityOnNewIntent(android.app.Activity arg0, android.content.Intent arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnNewIntent", "(Landroid/app/Activity;Landroid/content/Intent;)V", ref global::android.app.Instrumentation._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual void callActivityOnStart(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnStart", "(Landroid/app/Activity;)V", ref global::android.app.Instrumentation._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual void callActivityOnRestart(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnRestart", "(Landroid/app/Activity;)V", ref global::android.app.Instrumentation._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual void callActivityOnResume(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnResume", "(Landroid/app/Activity;)V", ref global::android.app.Instrumentation._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual void callActivityOnStop(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnStop", "(Landroid/app/Activity;)V", ref global::android.app.Instrumentation._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public virtual void callActivityOnSaveInstanceState(android.app.Activity arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnSaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", ref global::android.app.Instrumentation._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public virtual void callActivityOnPause(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnPause", "(Landroid/app/Activity;)V", ref global::android.app.Instrumentation._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public virtual void callActivityOnUserLeaving(android.app.Activity arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Instrumentation.staticClass, "callActivityOnUserLeaving", "(Landroid/app/Activity;)V", ref global::android.app.Instrumentation._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.os.Bundle AllocCounts
		{
			get
			{
				return getAllocCounts();
			}
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public virtual global::android.os.Bundle getAllocCounts()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.app.Instrumentation.staticClass, "getAllocCounts", "()Landroid/os/Bundle;", ref global::android.app.Instrumentation._m55) as android.os.Bundle;
		}
		public new global::android.os.Bundle BinderCounts
		{
			get
			{
				return getBinderCounts();
			}
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public virtual global::android.os.Bundle getBinderCounts()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.app.Instrumentation.staticClass, "getBinderCounts", "()Landroid/os/Bundle;", ref global::android.app.Instrumentation._m56) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public Instrumentation() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Instrumentation._m57.native == global::System.IntPtr.Zero)
				global::android.app.Instrumentation._m57 = @__env.GetMethodIDNoThrow(global::android.app.Instrumentation.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Instrumentation.staticClass, global::android.app.Instrumentation._m57);
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
	}
}
