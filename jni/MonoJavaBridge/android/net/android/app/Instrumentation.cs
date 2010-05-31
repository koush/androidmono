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
			internal static global::net.sf.jni4net.jni.MethodId _getFilter533; 
			public virtual global::android.content.IntentFilter getFilter() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentFilter>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor._getFilter533)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.IntentFilter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getFilter533)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getResult534; 
			public virtual global::android.app.Instrumentation.ActivityResult getResult() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityResult>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor._getResult534)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityResult>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getResult534)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isBlocking535; 
			public virtual bool isBlocking() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallBooleanMethod(this, global::android.app.Instrumentation.ActivityMonitor._isBlocking535); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._isBlocking535); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getHits536; 
			public virtual int getHits() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallIntMethod(this, global::android.app.Instrumentation.ActivityMonitor._getHits536); 
				else 
					return @__env.CallNonVirtualIntMethod(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getHits536); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getLastActivity537; 
			public virtual global::android.app.Activity getLastActivity() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor._getLastActivity537)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._getLastActivity537)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _waitForActivity538; 
			public virtual global::android.app.Activity waitForActivity() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor._waitForActivity538)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._waitForActivity538)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _waitForActivityWithTimeout539; 
			public virtual global::android.app.Activity waitForActivityWithTimeout(long arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor._waitForActivityWithTimeout539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._waitForActivityWithTimeout539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _ActivityMonitor540; 
			public ActivityMonitor(android.content.IntentFilter arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor540, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _ActivityMonitor541; 
			public ActivityMonitor(java.lang.String arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.Instrumentation.ActivityMonitor.staticClass, global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor541, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.Instrumentation.ActivityMonitor.staticClass = @__class; 
				global::android.app.Instrumentation.ActivityMonitor._getFilter533 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getFilter", "()Landroid/content/IntentFilter;"); 
				global::android.app.Instrumentation.ActivityMonitor._getResult534 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getResult", "()Landroid/app/Instrumentation$ActivityResult;"); 
				global::android.app.Instrumentation.ActivityMonitor._isBlocking535 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "isBlocking", "()Z"); 
				global::android.app.Instrumentation.ActivityMonitor._getHits536 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getHits", "()I"); 
				global::android.app.Instrumentation.ActivityMonitor._getLastActivity537 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "getLastActivity", "()Landroid/app/Activity;"); 
				global::android.app.Instrumentation.ActivityMonitor._waitForActivity538 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "waitForActivity", "()Landroid/app/Activity;"); 
				global::android.app.Instrumentation.ActivityMonitor._waitForActivityWithTimeout539 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "waitForActivityWithTimeout", "(J)Landroid/app/Activity;"); 
				global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor540 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "<init>", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)V"); 
				global::android.app.Instrumentation.ActivityMonitor._ActivityMonitor541 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityMonitor.staticClass, "<init>", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)V"); 
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
			internal static global::net.sf.jni4net.jni.MethodId _getResultCode542; 
			public int getResultCode() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return @__env.CallIntMethod(this, global::android.app.Instrumentation.ActivityResult._getResultCode542); 
				else 
					return @__env.CallNonVirtualIntMethod(this, global::android.app.Instrumentation.ActivityResult.staticClass, global::android.app.Instrumentation.ActivityResult._getResultCode542); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getResultData543; 
			public global::android.content.Intent getResultData() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation.ActivityResult._getResultData543)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Intent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.ActivityResult.staticClass, global::android.app.Instrumentation.ActivityResult._getResultData543)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _ActivityResult544; 
			public ActivityResult(int arg0, android.content.Intent arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.Instrumentation.ActivityResult.staticClass, global::android.app.Instrumentation.ActivityResult._ActivityResult544, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.Instrumentation.ActivityResult.staticClass = @__class; 
				global::android.app.Instrumentation.ActivityResult._getResultCode542 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityResult.staticClass, "getResultCode", "()I"); 
				global::android.app.Instrumentation.ActivityResult._getResultData543 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityResult.staticClass, "getResultData", "()Landroid/content/Intent;"); 
				global::android.app.Instrumentation.ActivityResult._ActivityResult544 = @__env.GetMethodID(global::android.app.Instrumentation.ActivityResult.staticClass, "<init>", "(ILandroid/content/Intent;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start545; 
		public virtual void start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._start545); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._start545); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContext546; 
		public virtual global::android.content.Context getContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._getContext546)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getContext546)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate547; 
		public virtual void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._onCreate547, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onCreate547, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStart548; 
		public virtual void onStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._onStart548); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onStart548); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy549; 
		public virtual void onDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._onDestroy549); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onDestroy549); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _finish550; 
		public virtual void finish(int arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._finish550, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._finish550, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getComponentName551; 
		public virtual global::android.content.ComponentName getComponentName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._getComponentName551)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getComponentName551)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startAllocCounting552; 
		public virtual void startAllocCounting() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._startAllocCounting552); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startAllocCounting552); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopAllocCounting553; 
		public virtual void stopAllocCounting() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._stopAllocCounting553); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._stopAllocCounting553); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onException554; 
		public virtual bool onException(java.lang.Object arg0, java.lang.Throwable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Instrumentation._onException554, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._onException554, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendStatus555; 
		public virtual void sendStatus(int arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._sendStatus555, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendStatus555, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAutomaticPerformanceSnapshots556; 
		public virtual void setAutomaticPerformanceSnapshots() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._setAutomaticPerformanceSnapshots556); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._setAutomaticPerformanceSnapshots556); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startPerformanceSnapshot557; 
		public virtual void startPerformanceSnapshot() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._startPerformanceSnapshot557); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startPerformanceSnapshot557); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _endPerformanceSnapshot558; 
		public virtual void endPerformanceSnapshot() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._endPerformanceSnapshot558); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._endPerformanceSnapshot558); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTargetContext559; 
		public virtual global::android.content.Context getTargetContext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._getTargetContext559)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.Context>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getTargetContext559)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isProfiling560; 
		public virtual bool isProfiling() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Instrumentation._isProfiling560); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._isProfiling560); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startProfiling561; 
		public virtual void startProfiling() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._startProfiling561); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startProfiling561); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopProfiling562; 
		public virtual void stopProfiling() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._stopProfiling562); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._stopProfiling562); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInTouchMode563; 
		public virtual void setInTouchMode(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._setInTouchMode563, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._setInTouchMode563, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _waitForIdle564; 
		public virtual void waitForIdle(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._waitForIdle564, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForIdle564, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _waitForIdleSync565; 
		public virtual void waitForIdleSync() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._waitForIdleSync565); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForIdleSync565); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _runOnMainSync566; 
		public virtual void runOnMainSync(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._runOnMainSync566, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._runOnMainSync566, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startActivitySync567; 
		public virtual global::android.app.Activity startActivitySync(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._startActivitySync567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._startActivitySync567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addMonitor568; 
		public virtual global::android.app.Instrumentation.ActivityMonitor addMonitor(android.content.IntentFilter arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityMonitor>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._addMonitor568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityMonitor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._addMonitor568, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addMonitor569; 
		public virtual global::android.app.Instrumentation.ActivityMonitor addMonitor(java.lang.String arg0, android.app.Instrumentation.ActivityResult arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityMonitor>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._addMonitor569, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Instrumentation.ActivityMonitor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._addMonitor569, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addMonitor570; 
		public virtual void addMonitor(android.app.Instrumentation.ActivityMonitor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._addMonitor570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._addMonitor570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkMonitorHit571; 
		public virtual bool checkMonitorHit(android.app.Instrumentation.ActivityMonitor arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Instrumentation._checkMonitorHit571, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._checkMonitorHit571, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _waitForMonitor572; 
		public virtual global::android.app.Activity waitForMonitor(android.app.Instrumentation.ActivityMonitor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._waitForMonitor572, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForMonitor572, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _waitForMonitorWithTimeout573; 
		public virtual global::android.app.Activity waitForMonitorWithTimeout(android.app.Instrumentation.ActivityMonitor arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._waitForMonitorWithTimeout573, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._waitForMonitorWithTimeout573, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeMonitor574; 
		public virtual void removeMonitor(android.app.Instrumentation.ActivityMonitor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._removeMonitor574, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._removeMonitor574, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invokeMenuActionSync575; 
		public virtual bool invokeMenuActionSync(android.app.Activity arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Instrumentation._invokeMenuActionSync575, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._invokeMenuActionSync575, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invokeContextMenuAction576; 
		public virtual bool invokeContextMenuAction(android.app.Activity arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Instrumentation._invokeContextMenuAction576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._invokeContextMenuAction576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendStringSync577; 
		public virtual void sendStringSync(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._sendStringSync577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendStringSync577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendKeySync578; 
		public virtual void sendKeySync(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._sendKeySync578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendKeySync578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendKeyDownUpSync579; 
		public virtual void sendKeyDownUpSync(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._sendKeyDownUpSync579, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendKeyDownUpSync579, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendCharacterSync580; 
		public virtual void sendCharacterSync(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._sendCharacterSync580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendCharacterSync580, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendPointerSync581; 
		public virtual void sendPointerSync(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._sendPointerSync581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendPointerSync581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendTrackballEventSync582; 
		public virtual void sendTrackballEventSync(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._sendTrackballEventSync582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._sendTrackballEventSync582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newApplication583; 
		public virtual global::android.app.Application newApplication(java.lang.ClassLoader arg0, java.lang.String arg1, android.content.Context arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._newApplication583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newApplication583, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newApplication584; 
		public static global::android.app.Application newApplication(java.lang.Class arg0, android.content.Context arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallStaticObjectMethodPtr(android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newApplication584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callApplicationOnCreate585; 
		public virtual void callApplicationOnCreate(android.app.Application arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callApplicationOnCreate585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callApplicationOnCreate585, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newActivity586; 
		public virtual global::android.app.Activity newActivity(java.lang.ClassLoader arg0, java.lang.String arg1, android.content.Intent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._newActivity586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newActivity586, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newActivity587; 
		public virtual global::android.app.Activity newActivity(java.lang.Class arg0, android.content.Context arg1, android.os.IBinder arg2, android.app.Application arg3, android.content.Intent arg4, android.content.pm.ActivityInfo arg5, java.lang.CharSequence arg6, android.app.Activity arg7, java.lang.String arg8, java.lang.Object arg9) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._newActivity587, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg9))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Activity>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._newActivity587, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg9))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnCreate588; 
		public virtual void callActivityOnCreate(android.app.Activity arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnCreate588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnCreate588, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnDestroy589; 
		public virtual void callActivityOnDestroy(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnDestroy589, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnDestroy589, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnRestoreInstanceState590; 
		public virtual void callActivityOnRestoreInstanceState(android.app.Activity arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnRestoreInstanceState590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnRestoreInstanceState590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnPostCreate591; 
		public virtual void callActivityOnPostCreate(android.app.Activity arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnPostCreate591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnPostCreate591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnNewIntent592; 
		public virtual void callActivityOnNewIntent(android.app.Activity arg0, android.content.Intent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnNewIntent592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnNewIntent592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnStart593; 
		public virtual void callActivityOnStart(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnStart593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnStart593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnRestart594; 
		public virtual void callActivityOnRestart(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnRestart594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnRestart594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnResume595; 
		public virtual void callActivityOnResume(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnResume595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnResume595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnStop596; 
		public virtual void callActivityOnStop(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnStop596, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnStop596, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnSaveInstanceState597; 
		public virtual void callActivityOnSaveInstanceState(android.app.Activity arg0, android.os.Bundle arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnSaveInstanceState597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnSaveInstanceState597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnPause598; 
		public virtual void callActivityOnPause(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnPause598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnPause598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _callActivityOnUserLeaving599; 
		public virtual void callActivityOnUserLeaving(android.app.Activity arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Instrumentation._callActivityOnUserLeaving599, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._callActivityOnUserLeaving599, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllocCounts600; 
		public virtual global::android.os.Bundle getAllocCounts() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._getAllocCounts600)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getAllocCounts600)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBinderCounts601; 
		public virtual global::android.os.Bundle getBinderCounts() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Instrumentation._getBinderCounts601)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Instrumentation.staticClass, global::android.app.Instrumentation._getBinderCounts601)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Instrumentation602; 
		public Instrumentation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Instrumentation.staticClass, global::android.app.Instrumentation._Instrumentation602, this); 
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
			global::android.app.Instrumentation._start545 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "start", "()V"); 
			global::android.app.Instrumentation._getContext546 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "getContext", "()Landroid/content/Context;"); 
			global::android.app.Instrumentation._onCreate547 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.Instrumentation._onStart548 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "onStart", "()V"); 
			global::android.app.Instrumentation._onDestroy549 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "onDestroy", "()V"); 
			global::android.app.Instrumentation._finish550 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "finish", "(ILandroid/os/Bundle;)V"); 
			global::android.app.Instrumentation._getComponentName551 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "getComponentName", "()Landroid/content/ComponentName;"); 
			global::android.app.Instrumentation._startAllocCounting552 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "startAllocCounting", "()V"); 
			global::android.app.Instrumentation._stopAllocCounting553 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "stopAllocCounting", "()V"); 
			global::android.app.Instrumentation._onException554 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "onException", "(Ljava/lang/Object;Ljava/lang/Throwable;)Z"); 
			global::android.app.Instrumentation._sendStatus555 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendStatus", "(ILandroid/os/Bundle;)V"); 
			global::android.app.Instrumentation._setAutomaticPerformanceSnapshots556 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "setAutomaticPerformanceSnapshots", "()V"); 
			global::android.app.Instrumentation._startPerformanceSnapshot557 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "startPerformanceSnapshot", "()V"); 
			global::android.app.Instrumentation._endPerformanceSnapshot558 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "endPerformanceSnapshot", "()V"); 
			global::android.app.Instrumentation._getTargetContext559 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "getTargetContext", "()Landroid/content/Context;"); 
			global::android.app.Instrumentation._isProfiling560 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "isProfiling", "()Z"); 
			global::android.app.Instrumentation._startProfiling561 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "startProfiling", "()V"); 
			global::android.app.Instrumentation._stopProfiling562 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "stopProfiling", "()V"); 
			global::android.app.Instrumentation._setInTouchMode563 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "setInTouchMode", "(Z)V"); 
			global::android.app.Instrumentation._waitForIdle564 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "waitForIdle", "(Ljava/lang/Runnable;)V"); 
			global::android.app.Instrumentation._waitForIdleSync565 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "waitForIdleSync", "()V"); 
			global::android.app.Instrumentation._runOnMainSync566 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "runOnMainSync", "(Ljava/lang/Runnable;)V"); 
			global::android.app.Instrumentation._startActivitySync567 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "startActivitySync", "(Landroid/content/Intent;)Landroid/app/Activity;"); 
			global::android.app.Instrumentation._addMonitor568 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "addMonitor", "(Landroid/content/IntentFilter;Landroid/app/Instrumentation$ActivityResult;Z)Landroid/app/Instrumentation$ActivityMonitor;"); 
			global::android.app.Instrumentation._addMonitor569 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "addMonitor", "(Ljava/lang/String;Landroid/app/Instrumentation$ActivityResult;Z)Landroid/app/Instrumentation$ActivityMonitor;"); 
			global::android.app.Instrumentation._addMonitor570 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "addMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V"); 
			global::android.app.Instrumentation._checkMonitorHit571 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "checkMonitorHit", "(Landroid/app/Instrumentation$ActivityMonitor;I)Z"); 
			global::android.app.Instrumentation._waitForMonitor572 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "waitForMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)Landroid/app/Activity;"); 
			global::android.app.Instrumentation._waitForMonitorWithTimeout573 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "waitForMonitorWithTimeout", "(Landroid/app/Instrumentation$ActivityMonitor;J)Landroid/app/Activity;"); 
			global::android.app.Instrumentation._removeMonitor574 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "removeMonitor", "(Landroid/app/Instrumentation$ActivityMonitor;)V"); 
			global::android.app.Instrumentation._invokeMenuActionSync575 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "invokeMenuActionSync", "(Landroid/app/Activity;II)Z"); 
			global::android.app.Instrumentation._invokeContextMenuAction576 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "invokeContextMenuAction", "(Landroid/app/Activity;II)Z"); 
			global::android.app.Instrumentation._sendStringSync577 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendStringSync", "(Ljava/lang/String;)V"); 
			global::android.app.Instrumentation._sendKeySync578 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendKeySync", "(Landroid/view/KeyEvent;)V"); 
			global::android.app.Instrumentation._sendKeyDownUpSync579 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendKeyDownUpSync", "(I)V"); 
			global::android.app.Instrumentation._sendCharacterSync580 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendCharacterSync", "(I)V"); 
			global::android.app.Instrumentation._sendPointerSync581 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendPointerSync", "(Landroid/view/MotionEvent;)V"); 
			global::android.app.Instrumentation._sendTrackballEventSync582 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "sendTrackballEventSync", "(Landroid/view/MotionEvent;)V"); 
			global::android.app.Instrumentation._newApplication583 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "newApplication", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Context;)Landroid/app/Application;"); 
			global::android.app.Instrumentation._newApplication584 = @__env.GetStaticMethodID(global::android.app.Instrumentation.staticClass, "newApplication", "(Ljava/lang/Class;Landroid/content/Context;)Landroid/app/Application;"); 
			global::android.app.Instrumentation._callApplicationOnCreate585 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callApplicationOnCreate", "(Landroid/app/Application;)V"); 
			global::android.app.Instrumentation._newActivity586 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "newActivity", "(Ljava/lang/ClassLoader;Ljava/lang/String;Landroid/content/Intent;)Landroid/app/Activity;"); 
			global::android.app.Instrumentation._newActivity587 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "newActivity", "(Ljava/lang/Class;Landroid/content/Context;Landroid/os/IBinder;Landroid/app/Application;Landroid/content/Intent;Landroid/content/pm/ActivityInfo;Ljava/lang/CharSequence;Landroid/app/Activity;Ljava/lang/String;Ljava/lang/Object;)Landroid/app/Activity;"); 
			global::android.app.Instrumentation._callActivityOnCreate588 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V"); 
			global::android.app.Instrumentation._callActivityOnDestroy589 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnDestroy", "(Landroid/app/Activity;)V"); 
			global::android.app.Instrumentation._callActivityOnRestoreInstanceState590 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnRestoreInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V"); 
			global::android.app.Instrumentation._callActivityOnPostCreate591 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnPostCreate", "(Landroid/app/Activity;Landroid/os/Bundle;)V"); 
			global::android.app.Instrumentation._callActivityOnNewIntent592 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnNewIntent", "(Landroid/app/Activity;Landroid/content/Intent;)V"); 
			global::android.app.Instrumentation._callActivityOnStart593 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnStart", "(Landroid/app/Activity;)V"); 
			global::android.app.Instrumentation._callActivityOnRestart594 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnRestart", "(Landroid/app/Activity;)V"); 
			global::android.app.Instrumentation._callActivityOnResume595 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnResume", "(Landroid/app/Activity;)V"); 
			global::android.app.Instrumentation._callActivityOnStop596 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnStop", "(Landroid/app/Activity;)V"); 
			global::android.app.Instrumentation._callActivityOnSaveInstanceState597 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnSaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V"); 
			global::android.app.Instrumentation._callActivityOnPause598 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnPause", "(Landroid/app/Activity;)V"); 
			global::android.app.Instrumentation._callActivityOnUserLeaving599 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "callActivityOnUserLeaving", "(Landroid/app/Activity;)V"); 
			global::android.app.Instrumentation._getAllocCounts600 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "getAllocCounts", "()Landroid/os/Bundle;"); 
			global::android.app.Instrumentation._getBinderCounts601 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "getBinderCounts", "()Landroid/os/Bundle;"); 
			global::android.app.Instrumentation._Instrumentation602 = @__env.GetMethodID(global::android.app.Instrumentation.staticClass, "<init>", "()V"); 
		} 
	} 
} 
