namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyguardManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyguardManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class KeyguardLock : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected KeyguardLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void disableKeyguard()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.KeyguardManager.KeyguardLock.staticClass, "disableKeyguard", "()V", ref global::android.app.KeyguardManager.KeyguardLock._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual void reenableKeyguard()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.KeyguardManager.KeyguardLock.staticClass, "reenableKeyguard", "()V", ref global::android.app.KeyguardManager.KeyguardLock._m1);
			}
			static KeyguardLock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.KeyguardManager.KeyguardLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/KeyguardManager$KeyguardLock"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.app.KeyguardManager.OnKeyguardExitResult_))]
		public partial interface OnKeyguardExitResult  : global::MonoJavaBridge.IJavaObject 
		{
			void onKeyguardExitResult(bool arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.KeyguardManager.OnKeyguardExitResult))]
		internal sealed partial class OnKeyguardExitResult_ : java.lang.Object, OnKeyguardExitResult
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnKeyguardExitResult_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.app.KeyguardManager.OnKeyguardExitResult.onKeyguardExitResult(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.KeyguardManager.OnKeyguardExitResult_.staticClass, "onKeyguardExitResult", "(Z)V", ref global::android.app.KeyguardManager.OnKeyguardExitResult_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnKeyguardExitResult_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.KeyguardManager.OnKeyguardExitResult_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/KeyguardManager$OnKeyguardExitResult"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnKeyguardExitResultDelegate(bool arg0);

		internal partial class OnKeyguardExitResultDelegateWrapper : java.lang.Object, OnKeyguardExitResult
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnKeyguardExitResultDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnKeyguardExitResultDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.KeyguardManager.OnKeyguardExitResultDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.app.KeyguardManager.OnKeyguardExitResultDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.app.KeyguardManager.OnKeyguardExitResultDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.KeyguardManager.OnKeyguardExitResultDelegateWrapper.staticClass, global::android.app.KeyguardManager.OnKeyguardExitResultDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnKeyguardExitResultDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.KeyguardManager.OnKeyguardExitResultDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/KeyguardManager_OnKeyguardExitResultDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnKeyguardExitResultDelegateWrapper
		{
			private OnKeyguardExitResultDelegate myDelegate;
			public void onKeyguardExitResult(bool arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnKeyguardExitResultDelegateWrapper(OnKeyguardExitResultDelegate d)
			{
				global::android.app.KeyguardManager.OnKeyguardExitResultDelegateWrapper ret = new global::android.app.KeyguardManager.OnKeyguardExitResultDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.app.KeyguardManager.KeyguardLock newKeyguardLock(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.KeyguardManager.staticClass, "newKeyguardLock", "(Ljava/lang/String;)Landroid/app/KeyguardManager$KeyguardLock;", ref global::android.app.KeyguardManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.KeyguardManager.KeyguardLock;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool inKeyguardRestrictedInputMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.KeyguardManager.staticClass, "inKeyguardRestrictedInputMode", "()Z", ref global::android.app.KeyguardManager._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void exitKeyguardSecurely(android.app.KeyguardManager.OnKeyguardExitResult arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.KeyguardManager.staticClass, "exitKeyguardSecurely", "(Landroid/app/KeyguardManager$OnKeyguardExitResult;)V", ref global::android.app.KeyguardManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void exitKeyguardSecurely(global::android.app.KeyguardManager.OnKeyguardExitResultDelegate arg0)
		{
			exitKeyguardSecurely((global::android.app.KeyguardManager.OnKeyguardExitResultDelegateWrapper)arg0);
		}
		static KeyguardManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.KeyguardManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/KeyguardManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
