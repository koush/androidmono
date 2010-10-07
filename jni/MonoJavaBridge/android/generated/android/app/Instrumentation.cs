namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Instrumentation : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Instrumentation()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.Instrumentation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.Instrumentation(@__env);
			}
		}
		protected Instrumentation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class ActivityMonitor : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static ActivityMonitor()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.Instrumentation.ActivityMonitor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.app.Instrumentation.ActivityMonitor(@__env);
				}
			}
			protected ActivityMonitor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _getFilter542;
			public virtual global::android.content.IntentFilter getFilter() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentFilter>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor._getFilter542));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getFilter542));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getResult543;
			public virtual global::android.app.Instrumentation.ActivityResult getResult() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityResult>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor._getResult543));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getResult543));
			}
			internal static global::net.sf.jni4net.jni.MethodId _isBlocking544;
			public virtual bool isBlocking() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.app.Instrumentation.ActivityMonitor._isBlocking544);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._isBlocking544);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getHits545;
			public virtual int getHits() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.app.Instrumentation.ActivityMonitor._getHits545);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getHits545);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getLastActivity546;
			public virtual global::android.app.Activity getLastActivity() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor._getLastActivity546));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getLastActivity546));
			}
			internal static global::net.sf.jni4net.jni.MethodId _waitForActivity547;
			public virtual global::android.app.Activity waitForActivity() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor._waitForActivity547));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._waitForActivity547));
			}
			internal static global::net.sf.jni4net.jni.MethodId _waitForActivityWithTimeout548;
			public virtual global::android.app.Activity waitForActivityWithTimeout(long arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor._waitForActivityWithTimeout548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._waitForActivityWithTimeout548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _ActivityMonitor549;
			public ActivityMonitor(android.content.IntentFilter arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor549, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _ActivityMonitor550;
			public ActivityMonitor(java.lang.String arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor550, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.Instrumentation.ActivityMonitor.staticClass = @__class;
				global::android.app.Instrumentation.ActivityMonitor._getFilter542 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getFilter", "()Landroid/content/IntentFilter;");
				global::android.app.Instrumentation.ActivityMonitor._getResult543 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getResult", "()Landroid/app/Instrumentation$ActivityResult;");
				global::android.app.Instrumentation.ActivityMonitor._isBlocking544 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "isBlocking", "()Z");
				global::android.app.Instrumentation.ActivityMonitor._getHits545 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getHits", "()I");
				global::android.app.Instrumentation.ActivityMonitor._getLastActivity546 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getLastActivity", "()Landroid/app/Activity;");
				global::android.app.Instrumentation.ActivityMonitor._waitForActivity547 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "waitForActivity", "()Landroid/app/Activity;");
				global::android.app.Instrumentation.ActivityMonitor._waitForActivityWithTimeout548 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "waitForActivityWithTimeout", "(J)Landroid/app/Activity;");
				global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor549 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "<init>", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)V");
				global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor550 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "<init>", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class ActivityResult : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static ActivityResult()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.Instrumentation.ActivityResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.app.Instrumentation.ActivityResult(@__env);
				}
			}
			internal ActivityResult(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _getResultCode551;
			public int getResultCode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.app.Instrumentation.ActivityResult._getResultCode551);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.app.Instrumentation.ActivityResult.staticClass, global::android.app.Instrumentation.ActivityResult._getResultCode551);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getResultData552;
			public global::android.content.Intent getResultData() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation.ActivityResult._getResultData552));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.ActivityResult.staticClass, global::android.app.Instrumentation.ActivityResult._getResultData552));
			}
			internal static global::net.sf.jni4net.jni.MethodId _ActivityResult553;
			public ActivityResult(int arg0, android.content.Intent arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.Instrumentation.ActivityResult.staticClass, global::android.app.Instrumentation.ActivityResult._ActivityResult553, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.Instrumentation.ActivityResult.staticClass = @__class;
				global::android.app.Instrumentation.ActivityResult._getResultCode551 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityResult.staticClass, "getResultCode", "()I");
				global::android.app.Instrumentation.ActivityResult._getResultData552 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityResult.staticClass, "getResultData", "()Landroid/content/Intent;");
				global::android.app.Instrumentation.ActivityResult._ActivityResult553 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityResult.staticClass, "<init>", "(ILandroid/content/Intent;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _start554;
		public virtual void start() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._start554);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._start554);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getContext555;
		public virtual global::android.content.Context getContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._getContext555));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getContext555));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreate556;
		public virtual void onCreate(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._onCreate556, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onCreate556, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStart557;
		public virtual void onStart() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._onStart557);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onStart557);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy558;
		public virtual void onDestroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._onDestroy558);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onDestroy558);
		}
		internal static global::net.sf.jni4net.jni.MethodId _finish559;
		public virtual void finish(int arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._finish559, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._finish559, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getComponentName560;
		public virtual global::android.content.ComponentName getComponentName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._getComponentName560));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getComponentName560));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startAllocCounting561;
		public virtual void startAllocCounting() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._startAllocCounting561);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startAllocCounting561);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopAllocCounting562;
		public virtual void stopAllocCounting() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._stopAllocCounting562);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._stopAllocCounting562);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onException563;
		public virtual bool onException(java.lang.Object arg0, java.lang.Throwable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Instrumentation._onException563, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onException563, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendStatus564;
		public virtual void sendStatus(int arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._sendStatus564, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendStatus564, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAutomaticPerformanceSnapshots565;
		public virtual void setAutomaticPerformanceSnapshots() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._setAutomaticPerformanceSnapshots565);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._setAutomaticPerformanceSnapshots565);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startPerformanceSnapshot566;
		public virtual void startPerformanceSnapshot() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._startPerformanceSnapshot566);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startPerformanceSnapshot566);
		}
		internal static global::net.sf.jni4net.jni.MethodId _endPerformanceSnapshot567;
		public virtual void endPerformanceSnapshot() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._endPerformanceSnapshot567);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._endPerformanceSnapshot567);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTargetContext568;
		public virtual global::android.content.Context getTargetContext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._getTargetContext568));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getTargetContext568));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isProfiling569;
		public virtual bool isProfiling() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Instrumentation._isProfiling569);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._isProfiling569);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startProfiling570;
		public virtual void startProfiling() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._startProfiling570);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startProfiling570);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopProfiling571;
		public virtual void stopProfiling() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._stopProfiling571);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._stopProfiling571);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInTouchMode572;
		public virtual void setInTouchMode(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._setInTouchMode572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._setInTouchMode572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _waitForIdle573;
		public virtual void waitForIdle(java.lang.Runnable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._waitForIdle573, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForIdle573, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _waitForIdleSync574;
		public virtual void waitForIdleSync() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._waitForIdleSync574);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForIdleSync574);
		}
		internal static global::net.sf.jni4net.jni.MethodId _runOnMainSync575;
		public virtual void runOnMainSync(java.lang.Runnable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._runOnMainSync575, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._runOnMainSync575, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startActivitySync576;
		public virtual global::android.app.Activity startActivitySync(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._startActivitySync576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startActivitySync576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addMonitor577;
		public virtual global::android.app.Instrumentation.ActivityMonitor addMonitor(android.content.IntentFilter arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityMonitor>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._addMonitor577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityMonitor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._addMonitor577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addMonitor578;
		public virtual global::android.app.Instrumentation.ActivityMonitor addMonitor(java.lang.String arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityMonitor>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._addMonitor578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityMonitor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._addMonitor578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addMonitor579;
		public virtual void addMonitor(android.app.Instrumentation.ActivityMonitor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._addMonitor579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._addMonitor579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkMonitorHit580;
		public virtual bool checkMonitorHit(android.app.Instrumentation.ActivityMonitor arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Instrumentation._checkMonitorHit580, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._checkMonitorHit580, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _waitForMonitor581;
		public virtual global::android.app.Activity waitForMonitor(android.app.Instrumentation.ActivityMonitor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._waitForMonitor581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForMonitor581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _waitForMonitorWithTimeout582;
		public virtual global::android.app.Activity waitForMonitorWithTimeout(android.app.Instrumentation.ActivityMonitor arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._waitForMonitorWithTimeout582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForMonitorWithTimeout582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeMonitor583;
		public virtual void removeMonitor(android.app.Instrumentation.ActivityMonitor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._removeMonitor583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._removeMonitor583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invokeMenuActionSync584;
		public virtual bool invokeMenuActionSync(android.app.Activity arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Instrumentation._invokeMenuActionSync584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._invokeMenuActionSync584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invokeContextMenuAction585;
		public virtual bool invokeContextMenuAction(android.app.Activity arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Instrumentation._invokeContextMenuAction585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._invokeContextMenuAction585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendStringSync586;
		public virtual void sendStringSync(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._sendStringSync586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendStringSync586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendKeySync587;
		public virtual void sendKeySync(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._sendKeySync587, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendKeySync587, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendKeyDownUpSync588;
		public virtual void sendKeyDownUpSync(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._sendKeyDownUpSync588, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendKeyDownUpSync588, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendCharacterSync589;
		public virtual void sendCharacterSync(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._sendCharacterSync589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendCharacterSync589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendPointerSync590;
		public virtual void sendPointerSync(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._sendPointerSync590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendPointerSync590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _sendTrackballEventSync591;
		public virtual void sendTrackballEventSync(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._sendTrackballEventSync591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendTrackballEventSync591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newApplication592;
		public virtual global::android.app.Application newApplication(java.lang.ClassLoader arg0, java.lang.String arg1, android.content.Context arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._newApplication592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newApplication592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newApplication593;
		public static global::android.app.Application newApplication(java.lang.Class arg0, android.content.Context arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallStaticObjectMethodPtr(android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newApplication593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _callApplicationOnCreate594;
		public virtual void callApplicationOnCreate(android.app.Application arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callApplicationOnCreate594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callApplicationOnCreate594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newActivity595;
		public virtual global::android.app.Activity newActivity(java.lang.ClassLoader arg0, java.lang.String arg1, android.content.Intent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._newActivity595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newActivity595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newActivity596;
		public virtual global::android.app.Activity newActivity(java.lang.Class arg0, android.content.Context arg1, android.os.IBinder arg2, android.app.Application arg3, android.content.Intent arg4, android.content.pm.ActivityInfo arg5, java.lang.CharSequence arg6, android.app.Activity arg7, java.lang.String arg8, java.lang.Object arg9) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._newActivity596, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg9)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newActivity596, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg9)));
		}
		public android.app.Activity newActivity(java.lang.Class arg0, android.content.Context arg1, android.os.IBinder arg2, android.app.Application arg3, android.content.Intent arg4, android.content.pm.ActivityInfo arg5, string arg6, android.app.Activity arg7, java.lang.String arg8, java.lang.Object arg9)
		{
			return newActivity(arg0, arg1, arg2, arg3, arg4, arg5, (global::java.lang.CharSequence)(global::java.lang.String)arg6, arg7, arg8, arg9);
		}
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnCreate597;
		public virtual void callActivityOnCreate(android.app.Activity arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnCreate597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnCreate597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnDestroy598;
		public virtual void callActivityOnDestroy(android.app.Activity arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnDestroy598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnDestroy598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnRestoreInstanceState599;
		public virtual void callActivityOnRestoreInstanceState(android.app.Activity arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnRestoreInstanceState599, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnRestoreInstanceState599, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnPostCreate600;
		public virtual void callActivityOnPostCreate(android.app.Activity arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnPostCreate600, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnPostCreate600, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnNewIntent601;
		public virtual void callActivityOnNewIntent(android.app.Activity arg0, android.content.Intent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnNewIntent601, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnNewIntent601, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnStart602;
		public virtual void callActivityOnStart(android.app.Activity arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnStart602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnStart602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnRestart603;
		public virtual void callActivityOnRestart(android.app.Activity arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnRestart603, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnRestart603, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnResume604;
		public virtual void callActivityOnResume(android.app.Activity arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnResume604, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnResume604, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnStop605;
		public virtual void callActivityOnStop(android.app.Activity arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnStop605, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnStop605, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnSaveInstanceState606;
		public virtual void callActivityOnSaveInstanceState(android.app.Activity arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnSaveInstanceState606, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnSaveInstanceState606, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnPause607;
		public virtual void callActivityOnPause(android.app.Activity arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnPause607, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnPause607, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnUserLeaving608;
		public virtual void callActivityOnUserLeaving(android.app.Activity arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnUserLeaving608, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnUserLeaving608, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAllocCounts609;
		public virtual global::android.os.Bundle getAllocCounts() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._getAllocCounts609));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getAllocCounts609));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBinderCounts610;
		public virtual global::android.os.Bundle getBinderCounts() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._getBinderCounts610));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getBinderCounts610));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Instrumentation611;
		public Instrumentation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.Instrumentation.staticClass, global::android.app.Instrumentation._Instrumentation611, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.Instrumentation.staticClass = @__class;
			global::android.app.Instrumentation._start554 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "start", "()V");
			global::android.app.Instrumentation._getContext555 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.app.Instrumentation._onCreate556 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.Instrumentation._onStart557 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "onStart", "()V");
			global::android.app.Instrumentation._onDestroy558 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "onDestroy", "()V");
			global::android.app.Instrumentation._finish559 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "finish", "(ILandroid/os/Bundle;)V");
			global::android.app.Instrumentation._getComponentName560 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "getComponentName", "()Landroid/content/ComponentName;");
			global::android.app.Instrumentation._startAllocCounting561 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "startAllocCounting", "()V");
			global::android.app.Instrumentation._stopAllocCounting562 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "stopAllocCounting", "()V");
			global::android.app.Instrumentation._onException563 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "onException", "(Ljava/lang/Object;Ljava/lang/Throwable;)Z");
			global::android.app.Instrumentation._sendStatus564 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendStatus", "(ILandroid/os/Bundle;)V");
			global::android.app.Instrumentation._setAutomaticPerformanceSnapshots565 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "setAutomaticPerformanceSnapshots", "()V");
			global::android.app.Instrumentation._startPerformanceSnapshot566 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "startPerformanceSnapshot", "()V");
			global::android.app.Instrumentation._endPerformanceSnapshot567 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "endPerformanceSnapshot", "()V");
			global::android.app.Instrumentation._getTargetContext568 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "getTargetContext", "()Landroid/content/Context;");
			global::android.app.Instrumentation._isProfiling569 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "isProfiling", "()Z");
			global::android.app.Instrumentation._startProfiling570 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "startProfiling", "()V");
			global::android.app.Instrumentation._stopProfiling571 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "stopProfiling", "()V");
			global::android.app.Instrumentation._setInTouchMode572 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "setInTouchMode", "(Z)V");
			global::android.app.Instrumentation._waitForIdle573 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "waitForIdle", "(Ljava/lang/Runnable;)V");
			global::android.app.Instrumentation._waitForIdleSync574 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "waitForIdleSync", "()V");
			global::android.app.Instrumentation._runOnMainSync575 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "runOnMainSync", "(Ljava/lang/Runnable;)V");
			global::android.app.Instrumentation._startActivitySync576 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "startActivitySync", "(Landroid/content/Intent;)Landroid/app/Activity;");
			global::android.app.Instrumentation._addMonitor577 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "addMonitor", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)Landroid/app/Instrumentation$ActivityMonitor;");
			global::android.app.Instrumentation._addMonitor578 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "addMonitor", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)Landroid/app/Instrumentation$ActivityMonitor;");
			global::android.app.Instrumentation._addMonitor579 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "addMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V");
			global::android.app.Instrumentation._checkMonitorHit580 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "checkMonitorHit", "(Landroid/app/Instrumentation$ActivityMonitor;I)Z");
			global::android.app.Instrumentation._waitForMonitor581 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "waitForMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)Landroid/app/Activity;");
			global::android.app.Instrumentation._waitForMonitorWithTimeout582 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "waitForMonitorWithTimeout", "(Landroid/app/Instrumentation$ActivityMonitor;J)Landroid/app/Activity;");
			global::android.app.Instrumentation._removeMonitor583 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "removeMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V");
			global::android.app.Instrumentation._invokeMenuActionSync584 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "invokeMenuActionSync", "(Landroid/app/Activity;II)Z");
			global::android.app.Instrumentation._invokeContextMenuAction585 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "invokeContextMenuAction", "(Landroid/app/Activity;II)Z");
			global::android.app.Instrumentation._sendStringSync586 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendStringSync", "(Ljava/lang/String;)V");
			global::android.app.Instrumentation._sendKeySync587 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendKeySync", "(Landroid/view/KeyEvent;)V");
			global::android.app.Instrumentation._sendKeyDownUpSync588 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendKeyDownUpSync", "(I)V");
			global::android.app.Instrumentation._sendCharacterSync589 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendCharacterSync", "(I)V");
			global::android.app.Instrumentation._sendPointerSync590 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendPointerSync", "(Landroid/view/MotionEvent;)V");
			global::android.app.Instrumentation._sendTrackballEventSync591 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendTrackballEventSync", "(Landroid/view/MotionEvent;)V");
			global::android.app.Instrumentation._newApplication592 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "newApplication", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Context;)Landroid/app/Application;");
			global::android.app.Instrumentation._newApplication593 = @__env.GetStaticMethodID(global::android.app.Instrumentation.staticClass, "newApplication", "(Ljava/lang/Class;Landroid/content/Context;)Landroid/app/Application;");
			global::android.app.Instrumentation._callApplicationOnCreate594 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callApplicationOnCreate", "(Landroid/app/Application;)V");
			global::android.app.Instrumentation._newActivity595 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "newActivity", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Intent;)Landroid/app/Activity;");
			global::android.app.Instrumentation._newActivity596 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "newActivity", "(Ljava/lang/Class;Landroid/content/Context;Landroid/os/IBinder;Landroid/app/Application;Landroid/content/Intent;Landroid/content/pm/ActivityInfo;Ljava/lang/CharSequence;Landroid/app/Activity;Ljava/lang/String;Ljava/lang/Object;)Landroid/app/Activity;");
			global::android.app.Instrumentation._callActivityOnCreate597 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			global::android.app.Instrumentation._callActivityOnDestroy598 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnDestroy", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnRestoreInstanceState599 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnRestoreInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			global::android.app.Instrumentation._callActivityOnPostCreate600 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnPostCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			global::android.app.Instrumentation._callActivityOnNewIntent601 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnNewIntent", "(Landroid/app/Activity;Landroid/content/Intent;)V");
			global::android.app.Instrumentation._callActivityOnStart602 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnStart", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnRestart603 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnRestart", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnResume604 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnResume", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnStop605 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnStop", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnSaveInstanceState606 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnSaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V");
			global::android.app.Instrumentation._callActivityOnPause607 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnPause", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._callActivityOnUserLeaving608 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnUserLeaving", "(Landroid/app/Activity;)V");
			global::android.app.Instrumentation._getAllocCounts609 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "getAllocCounts", "()Landroid/os/Bundle;");
			global::android.app.Instrumentation._getBinderCounts610 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "getBinderCounts", "()Landroid/os/Bundle;");
			global::android.app.Instrumentation._Instrumentation611 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "<init>", "()V");
		}
	}
}
