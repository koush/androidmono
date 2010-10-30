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
			internal static global::MonoJavaBridge.MethodId _disableKeyguard1919;
			public virtual void disableKeyguard()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.KeyguardManager.KeyguardLock.staticClass, global::android.app.KeyguardManager.KeyguardLock._disableKeyguard1919);
			}
			internal static global::MonoJavaBridge.MethodId _reenableKeyguard1920;
			public virtual void reenableKeyguard()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.KeyguardManager.KeyguardLock.staticClass, global::android.app.KeyguardManager.KeyguardLock._reenableKeyguard1920);
			}
			static KeyguardLock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.KeyguardManager.KeyguardLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/KeyguardManager$KeyguardLock"));
				global::android.app.KeyguardManager.KeyguardLock._disableKeyguard1919 = @__env.GetMethodIDNoThrow(global::android.app.KeyguardManager.KeyguardLock.staticClass, "disableKeyguard", "()V");
				global::android.app.KeyguardManager.KeyguardLock._reenableKeyguard1920 = @__env.GetMethodIDNoThrow(global::android.app.KeyguardManager.KeyguardLock.staticClass, "reenableKeyguard", "()V");
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
			internal static global::MonoJavaBridge.MethodId _onKeyguardExitResult1921;
			void android.app.KeyguardManager.OnKeyguardExitResult.onKeyguardExitResult(bool arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.KeyguardManager.OnKeyguardExitResult_._onKeyguardExitResult1921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnKeyguardExitResult_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.KeyguardManager.OnKeyguardExitResult_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/KeyguardManager$OnKeyguardExitResult"));
				global::android.app.KeyguardManager.OnKeyguardExitResult_._onKeyguardExitResult1921 = @__env.GetMethodIDNoThrow(global::android.app.KeyguardManager.OnKeyguardExitResult_.staticClass, "onKeyguardExitResult", "(Z)V");
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
			internal static global::MonoJavaBridge.MethodId _OnKeyguardExitResultDelegateWrapper1922;
			public OnKeyguardExitResultDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.KeyguardManager.OnKeyguardExitResultDelegateWrapper.staticClass, global::android.app.KeyguardManager.OnKeyguardExitResultDelegateWrapper._OnKeyguardExitResultDelegateWrapper1922);
				Init(@__env, handle);
			}
			static OnKeyguardExitResultDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.KeyguardManager.OnKeyguardExitResultDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/KeyguardManager_OnKeyguardExitResultDelegateWrapper"));
				global::android.app.KeyguardManager.OnKeyguardExitResultDelegateWrapper._OnKeyguardExitResultDelegateWrapper1922 = @__env.GetMethodIDNoThrow(global::android.app.KeyguardManager.OnKeyguardExitResultDelegateWrapper.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _newKeyguardLock1923;
		public virtual global::android.app.KeyguardManager.KeyguardLock newKeyguardLock(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.KeyguardManager.staticClass, global::android.app.KeyguardManager._newKeyguardLock1923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.KeyguardManager.KeyguardLock;
		}
		internal static global::MonoJavaBridge.MethodId _inKeyguardRestrictedInputMode1924;
		public virtual bool inKeyguardRestrictedInputMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.KeyguardManager.staticClass, global::android.app.KeyguardManager._inKeyguardRestrictedInputMode1924);
		}
		internal static global::MonoJavaBridge.MethodId _exitKeyguardSecurely1925;
		public virtual void exitKeyguardSecurely(android.app.KeyguardManager.OnKeyguardExitResult arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.KeyguardManager.staticClass, global::android.app.KeyguardManager._exitKeyguardSecurely1925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void exitKeyguardSecurely(global::android.app.KeyguardManager.OnKeyguardExitResultDelegate arg0)
		{
			exitKeyguardSecurely((global::android.app.KeyguardManager.OnKeyguardExitResultDelegateWrapper)arg0);
		}
		static KeyguardManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.KeyguardManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/KeyguardManager"));
			global::android.app.KeyguardManager._newKeyguardLock1923 = @__env.GetMethodIDNoThrow(global::android.app.KeyguardManager.staticClass, "newKeyguardLock", "(Ljava/lang/String;)Landroid/app/KeyguardManager$KeyguardLock;");
			global::android.app.KeyguardManager._inKeyguardRestrictedInputMode1924 = @__env.GetMethodIDNoThrow(global::android.app.KeyguardManager.staticClass, "inKeyguardRestrictedInputMode", "()Z");
			global::android.app.KeyguardManager._exitKeyguardSecurely1925 = @__env.GetMethodIDNoThrow(global::android.app.KeyguardManager.staticClass, "exitKeyguardSecurely", "(Landroid/app/KeyguardManager$OnKeyguardExitResult;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
