namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyguardManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyguardManager()
		{
			InitJNI();
		}
		protected KeyguardManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class KeyguardLock : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static KeyguardLock()
			{
				InitJNI();
			}
			protected KeyguardLock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _disableKeyguard1916;
			public virtual void disableKeyguard() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.KeyguardManager.KeyguardLock._disableKeyguard1916);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.KeyguardManager.KeyguardLock.staticClass, global::android.app.KeyguardManager.KeyguardLock._disableKeyguard1916);
			}
			internal static global::MonoJavaBridge.MethodId _reenableKeyguard1917;
			public virtual void reenableKeyguard() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.KeyguardManager.KeyguardLock._reenableKeyguard1917);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.KeyguardManager.KeyguardLock.staticClass, global::android.app.KeyguardManager.KeyguardLock._reenableKeyguard1917);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.KeyguardManager.KeyguardLock.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/KeyguardManager$KeyguardLock"));
				global::android.app.KeyguardManager.KeyguardLock._disableKeyguard1916 = @__env.GetMethodIDNoThrow(global::android.app.KeyguardManager.KeyguardLock.staticClass, "disableKeyguard", "()V");
				global::android.app.KeyguardManager.KeyguardLock._reenableKeyguard1917 = @__env.GetMethodIDNoThrow(global::android.app.KeyguardManager.KeyguardLock.staticClass, "reenableKeyguard", "()V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.app.KeyguardManager.OnKeyguardExitResult_))]
		public partial interface OnKeyguardExitResult  : global::MonoJavaBridge.IJavaObject 
		{
			void onKeyguardExitResult(bool arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.KeyguardManager.OnKeyguardExitResult))]
		public sealed partial class OnKeyguardExitResult_ : java.lang.Object, OnKeyguardExitResult
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnKeyguardExitResult_()
			{
				InitJNI();
			}
			internal OnKeyguardExitResult_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onKeyguardExitResult1918;
			 void android.app.KeyguardManager.OnKeyguardExitResult.onKeyguardExitResult(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.app.KeyguardManager.OnKeyguardExitResult_._onKeyguardExitResult1918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.KeyguardManager.OnKeyguardExitResult_.staticClass, global::android.app.KeyguardManager.OnKeyguardExitResult_._onKeyguardExitResult1918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.KeyguardManager.OnKeyguardExitResult_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/KeyguardManager$OnKeyguardExitResult"));
				global::android.app.KeyguardManager.OnKeyguardExitResult_._onKeyguardExitResult1918 = @__env.GetMethodIDNoThrow(global::android.app.KeyguardManager.OnKeyguardExitResult_.staticClass, "onKeyguardExitResult", "(Z)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _newKeyguardLock1919;
		public virtual global::android.app.KeyguardManager.KeyguardLock newKeyguardLock(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.KeyguardManager._newKeyguardLock1919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.KeyguardManager.KeyguardLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.KeyguardManager.staticClass, global::android.app.KeyguardManager._newKeyguardLock1919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.KeyguardManager.KeyguardLock;
		}
		internal static global::MonoJavaBridge.MethodId _inKeyguardRestrictedInputMode1920;
		public virtual bool inKeyguardRestrictedInputMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.KeyguardManager._inKeyguardRestrictedInputMode1920);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.KeyguardManager.staticClass, global::android.app.KeyguardManager._inKeyguardRestrictedInputMode1920);
		}
		internal static global::MonoJavaBridge.MethodId _exitKeyguardSecurely1921;
		public virtual void exitKeyguardSecurely(android.app.KeyguardManager.OnKeyguardExitResult arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.KeyguardManager._exitKeyguardSecurely1921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.KeyguardManager.staticClass, global::android.app.KeyguardManager._exitKeyguardSecurely1921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.KeyguardManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/KeyguardManager"));
			global::android.app.KeyguardManager._newKeyguardLock1919 = @__env.GetMethodIDNoThrow(global::android.app.KeyguardManager.staticClass, "newKeyguardLock", "(Ljava/lang/String;)Landroid/app/KeyguardManager$KeyguardLock;");
			global::android.app.KeyguardManager._inKeyguardRestrictedInputMode1920 = @__env.GetMethodIDNoThrow(global::android.app.KeyguardManager.staticClass, "inKeyguardRestrictedInputMode", "()Z");
			global::android.app.KeyguardManager._exitKeyguardSecurely1921 = @__env.GetMethodIDNoThrow(global::android.app.KeyguardManager.staticClass, "exitKeyguardSecurely", "(Landroid/app/KeyguardManager$OnKeyguardExitResult;)V");
		}
	}
}
