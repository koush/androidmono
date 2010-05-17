namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Instrumentation : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Instrumentation() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.Instrumentation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.Instrumentation.ActivityMonitor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _getFilter525; 
			public virtual android.content.IntentFilter getFilter() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.Instrumentation.ActivityMonitor)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentFilter>(@__env, @__env.CallObjectMethodPtr(this, _getFilter525)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.ActivityMonitor.staticClass, _getFilter525)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getResult526; 
			public virtual android.app.Instrumentation.ActivityResult getResult() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.Instrumentation.ActivityMonitor)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityResult>(@__env, @__env.CallObjectMethodPtr(this, _getResult526)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.ActivityMonitor.staticClass, _getResult526)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isBlocking527; 
			public virtual bool isBlocking() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.Instrumentation.ActivityMonitor)) 
					return @__env.CallBooleanMethod(this, _isBlocking527); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.app.Instrumentation.ActivityMonitor.staticClass, _isBlocking527); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getHits528; 
			public virtual int getHits() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.Instrumentation.ActivityMonitor)) 
					return @__env.CallIntMethod(this, _getHits528); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.app.Instrumentation.ActivityMonitor.staticClass, _getHits528); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getLastActivity529; 
			public virtual android.app.Activity getLastActivity() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.Instrumentation.ActivityMonitor)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, _getLastActivity529)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.ActivityMonitor.staticClass, _getLastActivity529)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _waitForActivity530; 
			public virtual android.app.Activity waitForActivity() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.Instrumentation.ActivityMonitor)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, _waitForActivity530)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.ActivityMonitor.staticClass, _waitForActivity530)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _waitForActivityWithTimeout531; 
			public virtual android.app.Activity waitForActivityWithTimeout(long arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.Instrumentation.ActivityMonitor)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, _waitForActivityWithTimeout531, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.ActivityMonitor.staticClass, _waitForActivityWithTimeout531, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _ActivityMonitor532; 
			public ActivityMonitor(android.content.IntentFilter arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.Instrumentation.ActivityMonitor.staticClass, _ActivityMonitor532, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _ActivityMonitor533; 
			public ActivityMonitor(java.lang.String arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.Instrumentation.ActivityMonitor.staticClass, _ActivityMonitor533, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.Instrumentation.ActivityMonitor.staticClass = @__class; 
				global::android.app.Instrumentation.ActivityMonitor._getFilter525 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getFilter", "()Landroid/content/IntentFilter;"); 
				global::android.app.Instrumentation.ActivityMonitor._getResult526 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getResult", "()Landroid/app/Instrumentation$ActivityResult;"); 
				global::android.app.Instrumentation.ActivityMonitor._isBlocking527 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "isBlocking", "()Z"); 
				global::android.app.Instrumentation.ActivityMonitor._getHits528 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getHits", "()I"); 
				global::android.app.Instrumentation.ActivityMonitor._getLastActivity529 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getLastActivity", "()Landroid/app/Activity;"); 
				global::android.app.Instrumentation.ActivityMonitor._waitForActivity530 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "waitForActivity", "()Landroid/app/Activity;"); 
				global::android.app.Instrumentation.ActivityMonitor._waitForActivityWithTimeout531 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "waitForActivityWithTimeout", "(J)Landroid/app/Activity;"); 
				global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor532 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "<init>", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)V"); 
				global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor533 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "<init>", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class ActivityResult : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static ActivityResult() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.Instrumentation.ActivityResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _getResultCode534; 
			public int getResultCode() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.Instrumentation.ActivityResult)) 
					return @__env.CallIntMethod(this, _getResultCode534); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.app.Instrumentation.ActivityResult.staticClass, _getResultCode534); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getResultData535; 
			public android.content.Intent getResultData() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.Instrumentation.ActivityResult)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, _getResultData535)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.ActivityResult.staticClass, _getResultData535)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _ActivityResult536; 
			public ActivityResult(int arg0, android.content.Intent arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.Instrumentation.ActivityResult.staticClass, _ActivityResult536, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.Instrumentation.ActivityResult.staticClass = @__class; 
				global::android.app.Instrumentation.ActivityResult._getResultCode534 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityResult.staticClass, "getResultCode", "()I"); 
				global::android.app.Instrumentation.ActivityResult._getResultData535 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityResult.staticClass, "getResultData", "()Landroid/content/Intent;"); 
				global::android.app.Instrumentation.ActivityResult._ActivityResult536 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityResult.staticClass, "<init>", "(ILandroid/content/Intent;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start537; 
		public virtual void start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _start537); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _start537); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContext538; 
		public virtual android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, _getContext538)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.staticClass, _getContext538)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate539; 
		public virtual void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _onCreate539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _onCreate539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStart540; 
		public virtual void onStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _onStart540); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _onStart540); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy541; 
		public virtual void onDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _onDestroy541); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _onDestroy541); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finish542; 
		public virtual void finish(int arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _finish542, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _finish542, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getComponentName543; 
		public virtual android.content.ComponentName getComponentName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, _getComponentName543)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.staticClass, _getComponentName543)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startAllocCounting544; 
		public virtual void startAllocCounting() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _startAllocCounting544); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _startAllocCounting544); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopAllocCounting545; 
		public virtual void stopAllocCounting() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _stopAllocCounting545); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _stopAllocCounting545); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onException546; 
		public virtual bool onException(java.lang.Object arg0, java.lang.Throwable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return @__env.CallBooleanMethod(this, _onException546, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Instrumentation.staticClass, _onException546, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendStatus547; 
		public virtual void sendStatus(int arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _sendStatus547, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _sendStatus547, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAutomaticPerformanceSnapshots548; 
		public virtual void setAutomaticPerformanceSnapshots() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _setAutomaticPerformanceSnapshots548); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _setAutomaticPerformanceSnapshots548); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startPerformanceSnapshot549; 
		public virtual void startPerformanceSnapshot() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _startPerformanceSnapshot549); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _startPerformanceSnapshot549); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _endPerformanceSnapshot550; 
		public virtual void endPerformanceSnapshot() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _endPerformanceSnapshot550); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _endPerformanceSnapshot550); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTargetContext551; 
		public virtual android.content.Context getTargetContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, _getTargetContext551)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.staticClass, _getTargetContext551)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isProfiling552; 
		public virtual bool isProfiling() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return @__env.CallBooleanMethod(this, _isProfiling552); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Instrumentation.staticClass, _isProfiling552); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startProfiling553; 
		public virtual void startProfiling() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _startProfiling553); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _startProfiling553); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopProfiling554; 
		public virtual void stopProfiling() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _stopProfiling554); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _stopProfiling554); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInTouchMode555; 
		public virtual void setInTouchMode(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _setInTouchMode555, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _setInTouchMode555, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _waitForIdle556; 
		public virtual void waitForIdle(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _waitForIdle556, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _waitForIdle556, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _waitForIdleSync557; 
		public virtual void waitForIdleSync() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _waitForIdleSync557); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _waitForIdleSync557); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _runOnMainSync558; 
		public virtual void runOnMainSync(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _runOnMainSync558, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _runOnMainSync558, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startActivitySync559; 
		public virtual android.app.Activity startActivitySync(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, _startActivitySync559, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.staticClass, _startActivitySync559, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addMonitor560; 
		public virtual android.app.Instrumentation.ActivityMonitor addMonitor(android.content.IntentFilter arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityMonitor>(@__env, @__env.CallObjectMethodPtr(this, _addMonitor560, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityMonitor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.staticClass, _addMonitor560, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addMonitor561; 
		public virtual android.app.Instrumentation.ActivityMonitor addMonitor(java.lang.String arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityMonitor>(@__env, @__env.CallObjectMethodPtr(this, _addMonitor561, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityMonitor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.staticClass, _addMonitor561, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addMonitor562; 
		public virtual void addMonitor(android.app.Instrumentation.ActivityMonitor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _addMonitor562, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _addMonitor562, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkMonitorHit563; 
		public virtual bool checkMonitorHit(android.app.Instrumentation.ActivityMonitor arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return @__env.CallBooleanMethod(this, _checkMonitorHit563, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Instrumentation.staticClass, _checkMonitorHit563, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _waitForMonitor564; 
		public virtual android.app.Activity waitForMonitor(android.app.Instrumentation.ActivityMonitor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, _waitForMonitor564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.staticClass, _waitForMonitor564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _waitForMonitorWithTimeout565; 
		public virtual android.app.Activity waitForMonitorWithTimeout(android.app.Instrumentation.ActivityMonitor arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, _waitForMonitorWithTimeout565, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.staticClass, _waitForMonitorWithTimeout565, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeMonitor566; 
		public virtual void removeMonitor(android.app.Instrumentation.ActivityMonitor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _removeMonitor566, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _removeMonitor566, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invokeMenuActionSync567; 
		public virtual bool invokeMenuActionSync(android.app.Activity arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return @__env.CallBooleanMethod(this, _invokeMenuActionSync567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Instrumentation.staticClass, _invokeMenuActionSync567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invokeContextMenuAction568; 
		public virtual bool invokeContextMenuAction(android.app.Activity arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return @__env.CallBooleanMethod(this, _invokeContextMenuAction568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Instrumentation.staticClass, _invokeContextMenuAction568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendStringSync569; 
		public virtual void sendStringSync(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _sendStringSync569, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _sendStringSync569, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendKeySync570; 
		public virtual void sendKeySync(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _sendKeySync570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _sendKeySync570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendKeyDownUpSync571; 
		public virtual void sendKeyDownUpSync(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _sendKeyDownUpSync571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _sendKeyDownUpSync571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendCharacterSync572; 
		public virtual void sendCharacterSync(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _sendCharacterSync572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _sendCharacterSync572, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendPointerSync573; 
		public virtual void sendPointerSync(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _sendPointerSync573, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _sendPointerSync573, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendTrackballEventSync574; 
		public virtual void sendTrackballEventSync(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _sendTrackballEventSync574, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _sendTrackballEventSync574, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newApplication575; 
		public virtual android.app.Application newApplication(java.lang.ClassLoader arg0, java.lang.String arg1, android.content.Context arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallObjectMethodPtr(this, _newApplication575, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.staticClass, _newApplication575, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newApplication576; 
		public static android.app.Application newApplication(java.lang.Class arg0, android.content.Context arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallStaticObjectMethodPtr(android.app.Instrumentation.staticClass, _newApplication576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callApplicationOnCreate577; 
		public virtual void callApplicationOnCreate(android.app.Application arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _callApplicationOnCreate577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _callApplicationOnCreate577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newActivity578; 
		public virtual android.app.Activity newActivity(java.lang.ClassLoader arg0, java.lang.String arg1, android.content.Intent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, _newActivity578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.staticClass, _newActivity578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newActivity579; 
		public virtual android.app.Activity newActivity(java.lang.Class arg0, android.content.Context arg1, android.os.IBinder arg2, android.app.Application arg3, android.content.Intent arg4, android.content.pm.ActivityInfo arg5, java.lang.CharSequence arg6, android.app.Activity arg7, java.lang.String arg8, java.lang.Object arg9) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, _newActivity579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg9))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.staticClass, _newActivity579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg9))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnCreate580; 
		public virtual void callActivityOnCreate(android.app.Activity arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _callActivityOnCreate580, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _callActivityOnCreate580, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnDestroy581; 
		public virtual void callActivityOnDestroy(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _callActivityOnDestroy581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _callActivityOnDestroy581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnRestoreInstanceState582; 
		public virtual void callActivityOnRestoreInstanceState(android.app.Activity arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _callActivityOnRestoreInstanceState582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _callActivityOnRestoreInstanceState582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnPostCreate583; 
		public virtual void callActivityOnPostCreate(android.app.Activity arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _callActivityOnPostCreate583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _callActivityOnPostCreate583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnNewIntent584; 
		public virtual void callActivityOnNewIntent(android.app.Activity arg0, android.content.Intent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _callActivityOnNewIntent584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _callActivityOnNewIntent584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnStart585; 
		public virtual void callActivityOnStart(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _callActivityOnStart585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _callActivityOnStart585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnRestart586; 
		public virtual void callActivityOnRestart(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _callActivityOnRestart586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _callActivityOnRestart586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnResume587; 
		public virtual void callActivityOnResume(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _callActivityOnResume587, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _callActivityOnResume587, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnStop588; 
		public virtual void callActivityOnStop(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _callActivityOnStop588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _callActivityOnStop588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnSaveInstanceState589; 
		public virtual void callActivityOnSaveInstanceState(android.app.Activity arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _callActivityOnSaveInstanceState589, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _callActivityOnSaveInstanceState589, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnPause590; 
		public virtual void callActivityOnPause(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _callActivityOnPause590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _callActivityOnPause590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnUserLeaving591; 
		public virtual void callActivityOnUserLeaving(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				@__env.CallVoidMethod(this, _callActivityOnUserLeaving591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Instrumentation.staticClass, _callActivityOnUserLeaving591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllocCounts592; 
		public virtual android.os.Bundle getAllocCounts() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _getAllocCounts592)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.staticClass, _getAllocCounts592)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBinderCounts593; 
		public virtual android.os.Bundle getBinderCounts() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Instrumentation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _getBinderCounts593)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Instrumentation.staticClass, _getBinderCounts593)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Instrumentation594; 
		public Instrumentation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Instrumentation.staticClass, _Instrumentation594, this); 
		} 
		public static java.lang.String REPORT_KEY_IDENTIFIER
		{ 
			get 
			{ 
				return "id"; 
			} 
		} 
		public static java.lang.String REPORT_KEY_STREAMRESULT
		{ 
			get 
			{ 
				return "stream"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.Instrumentation.staticClass = @__class; 
			global::android.app.Instrumentation._start537 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "start", "()V"); 
			global::android.app.Instrumentation._getContext538 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.app.Instrumentation._onCreate539 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.Instrumentation._onStart540 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "onStart", "()V"); 
			global::android.app.Instrumentation._onDestroy541 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "onDestroy", "()V"); 
			global::android.app.Instrumentation._finish542 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "finish", "(ILandroid/os/Bundle;)V"); 
			global::android.app.Instrumentation._getComponentName543 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "getComponentName", "()Landroid/content/ComponentName;"); 
			global::android.app.Instrumentation._startAllocCounting544 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "startAllocCounting", "()V"); 
			global::android.app.Instrumentation._stopAllocCounting545 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "stopAllocCounting", "()V"); 
			global::android.app.Instrumentation._onException546 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "onException", "(Ljava/lang/Object;Ljava/lang/Throwable;)Z"); 
			global::android.app.Instrumentation._sendStatus547 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendStatus", "(ILandroid/os/Bundle;)V"); 
			global::android.app.Instrumentation._setAutomaticPerformanceSnapshots548 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "setAutomaticPerformanceSnapshots", "()V"); 
			global::android.app.Instrumentation._startPerformanceSnapshot549 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "startPerformanceSnapshot", "()V"); 
			global::android.app.Instrumentation._endPerformanceSnapshot550 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "endPerformanceSnapshot", "()V"); 
			global::android.app.Instrumentation._getTargetContext551 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "getTargetContext", "()Landroid/content/Context;"); 
			global::android.app.Instrumentation._isProfiling552 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "isProfiling", "()Z"); 
			global::android.app.Instrumentation._startProfiling553 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "startProfiling", "()V"); 
			global::android.app.Instrumentation._stopProfiling554 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "stopProfiling", "()V"); 
			global::android.app.Instrumentation._setInTouchMode555 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "setInTouchMode", "(Z)V"); 
			global::android.app.Instrumentation._waitForIdle556 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "waitForIdle", "(Ljava/lang/Runnable;)V"); 
			global::android.app.Instrumentation._waitForIdleSync557 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "waitForIdleSync", "()V"); 
			global::android.app.Instrumentation._runOnMainSync558 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "runOnMainSync", "(Ljava/lang/Runnable;)V"); 
			global::android.app.Instrumentation._startActivitySync559 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "startActivitySync", "(Landroid/content/Intent;)Landroid/app/Activity;"); 
			global::android.app.Instrumentation._addMonitor560 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "addMonitor", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)Landroid/app/Instrumentation$ActivityMonitor;"); 
			global::android.app.Instrumentation._addMonitor561 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "addMonitor", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)Landroid/app/Instrumentation$ActivityMonitor;"); 
			global::android.app.Instrumentation._addMonitor562 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "addMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V"); 
			global::android.app.Instrumentation._checkMonitorHit563 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "checkMonitorHit", "(Landroid/app/Instrumentation$ActivityMonitor;I)Z"); 
			global::android.app.Instrumentation._waitForMonitor564 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "waitForMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)Landroid/app/Activity;"); 
			global::android.app.Instrumentation._waitForMonitorWithTimeout565 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "waitForMonitorWithTimeout", "(Landroid/app/Instrumentation$ActivityMonitor;J)Landroid/app/Activity;"); 
			global::android.app.Instrumentation._removeMonitor566 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "removeMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V"); 
			global::android.app.Instrumentation._invokeMenuActionSync567 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "invokeMenuActionSync", "(Landroid/app/Activity;II)Z"); 
			global::android.app.Instrumentation._invokeContextMenuAction568 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "invokeContextMenuAction", "(Landroid/app/Activity;II)Z"); 
			global::android.app.Instrumentation._sendStringSync569 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendStringSync", "(Ljava/lang/String;)V"); 
			global::android.app.Instrumentation._sendKeySync570 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendKeySync", "(Landroid/view/KeyEvent;)V"); 
			global::android.app.Instrumentation._sendKeyDownUpSync571 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendKeyDownUpSync", "(I)V"); 
			global::android.app.Instrumentation._sendCharacterSync572 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendCharacterSync", "(I)V"); 
			global::android.app.Instrumentation._sendPointerSync573 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendPointerSync", "(Landroid/view/MotionEvent;)V"); 
			global::android.app.Instrumentation._sendTrackballEventSync574 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendTrackballEventSync", "(Landroid/view/MotionEvent;)V"); 
			global::android.app.Instrumentation._newApplication575 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "newApplication", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Context;)Landroid/app/Application;"); 
			global::android.app.Instrumentation._newApplication576 = @__env.GetStaticMethodID(global::android.app.Instrumentation.staticClass, "newApplication", "(Ljava/lang/Class;Landroid/content/Context;)Landroid/app/Application;"); 
			global::android.app.Instrumentation._callApplicationOnCreate577 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callApplicationOnCreate", "(Landroid/app/Application;)V"); 
			global::android.app.Instrumentation._newActivity578 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "newActivity", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Intent;)Landroid/app/Activity;"); 
			global::android.app.Instrumentation._newActivity579 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "newActivity", "(Ljava/lang/Class;Landroid/content/Context;Landroid/os/IBinder;Landroid/app/Application;Landroid/content/Intent;Landroid/content/pm/ActivityInfo;Ljava/lang/CharSequence;Landroid/app/Activity;Ljava/lang/String;Ljava/lang/Object;)Landroid/app/Activity;"); 
			global::android.app.Instrumentation._callActivityOnCreate580 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V"); 
			global::android.app.Instrumentation._callActivityOnDestroy581 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnDestroy", "(Landroid/app/Activity;)V"); 
			global::android.app.Instrumentation._callActivityOnRestoreInstanceState582 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnRestoreInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V"); 
			global::android.app.Instrumentation._callActivityOnPostCreate583 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnPostCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V"); 
			global::android.app.Instrumentation._callActivityOnNewIntent584 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnNewIntent", "(Landroid/app/Activity;Landroid/content/Intent;)V"); 
			global::android.app.Instrumentation._callActivityOnStart585 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnStart", "(Landroid/app/Activity;)V"); 
			global::android.app.Instrumentation._callActivityOnRestart586 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnRestart", "(Landroid/app/Activity;)V"); 
			global::android.app.Instrumentation._callActivityOnResume587 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnResume", "(Landroid/app/Activity;)V"); 
			global::android.app.Instrumentation._callActivityOnStop588 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnStop", "(Landroid/app/Activity;)V"); 
			global::android.app.Instrumentation._callActivityOnSaveInstanceState589 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnSaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V"); 
			global::android.app.Instrumentation._callActivityOnPause590 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnPause", "(Landroid/app/Activity;)V"); 
			global::android.app.Instrumentation._callActivityOnUserLeaving591 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnUserLeaving", "(Landroid/app/Activity;)V"); 
			global::android.app.Instrumentation._getAllocCounts592 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "getAllocCounts", "()Landroid/os/Bundle;"); 
			global::android.app.Instrumentation._getBinderCounts593 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "getBinderCounts", "()Landroid/os/Bundle;"); 
			global::android.app.Instrumentation._Instrumentation594 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "<init>", "()V"); 
		} 
	} 
} 
