namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RecoverySystem : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RecoverySystem(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.RecoverySystem.ProgressListener_))]
		public partial interface ProgressListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onProgress(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.RecoverySystem.ProgressListener))]
		internal sealed partial class ProgressListener_ : java.lang.Object, ProgressListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ProgressListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onProgress10178;
			void android.os.RecoverySystem.ProgressListener.onProgress(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.RecoverySystem.ProgressListener_._onProgress10178.native == global::System.IntPtr.Zero)
					global::android.os.RecoverySystem.ProgressListener_._onProgress10178 = @__env.GetMethodIDNoThrow(global::android.os.RecoverySystem.ProgressListener_.staticClass, "onProgress", "(I)V");
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.RecoverySystem.ProgressListener_._onProgress10178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static ProgressListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.RecoverySystem.ProgressListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/RecoverySystem$ProgressListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void ProgressListenerDelegate(int arg0);

		internal partial class ProgressListenerDelegateWrapper : java.lang.Object, ProgressListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ProgressListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _ProgressListenerDelegateWrapper10179;
			public ProgressListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.RecoverySystem.ProgressListenerDelegateWrapper._ProgressListenerDelegateWrapper10179.native == global::System.IntPtr.Zero)
					global::android.os.RecoverySystem.ProgressListenerDelegateWrapper._ProgressListenerDelegateWrapper10179 = @__env.GetMethodIDNoThrow(global::android.os.RecoverySystem.ProgressListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.RecoverySystem.ProgressListenerDelegateWrapper.staticClass, global::android.os.RecoverySystem.ProgressListenerDelegateWrapper._ProgressListenerDelegateWrapper10179);
				Init(@__env, handle);
			}
			static ProgressListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.RecoverySystem.ProgressListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/RecoverySystem_ProgressListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class ProgressListenerDelegateWrapper
		{
			private ProgressListenerDelegate myDelegate;
			public void onProgress(int arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator ProgressListenerDelegateWrapper(ProgressListenerDelegate d)
			{
				global::android.os.RecoverySystem.ProgressListenerDelegateWrapper ret = new global::android.os.RecoverySystem.ProgressListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _verifyPackage10180;
		public static void verifyPackage(java.io.File arg0, android.os.RecoverySystem.ProgressListener arg1, java.io.File arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.RecoverySystem._verifyPackage10180.native == global::System.IntPtr.Zero)
				global::android.os.RecoverySystem._verifyPackage10180 = @__env.GetStaticMethodIDNoThrow(global::android.os.RecoverySystem.staticClass, "verifyPackage", "(Ljava/io/File;Landroid/os/RecoverySystem$ProgressListener;Ljava/io/File;)V");
			@__env.CallStaticVoidMethod(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._verifyPackage10180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static void verifyPackage(java.io.File arg0, global::android.os.RecoverySystem.ProgressListenerDelegate arg1, java.io.File arg2)
		{
			verifyPackage(arg0, (global::android.os.RecoverySystem.ProgressListenerDelegateWrapper)arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _installPackage10181;
		public static void installPackage(android.content.Context arg0, java.io.File arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.RecoverySystem._installPackage10181.native == global::System.IntPtr.Zero)
				global::android.os.RecoverySystem._installPackage10181 = @__env.GetStaticMethodIDNoThrow(global::android.os.RecoverySystem.staticClass, "installPackage", "(Landroid/content/Context;Ljava/io/File;)V");
			@__env.CallStaticVoidMethod(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._installPackage10181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rebootWipeUserData10182;
		public static void rebootWipeUserData(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.RecoverySystem._rebootWipeUserData10182.native == global::System.IntPtr.Zero)
				global::android.os.RecoverySystem._rebootWipeUserData10182 = @__env.GetStaticMethodIDNoThrow(global::android.os.RecoverySystem.staticClass, "rebootWipeUserData", "(Landroid/content/Context;)V");
			@__env.CallStaticVoidMethod(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._rebootWipeUserData10182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RecoverySystem10183;
		public RecoverySystem() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.RecoverySystem._RecoverySystem10183.native == global::System.IntPtr.Zero)
				global::android.os.RecoverySystem._RecoverySystem10183 = @__env.GetMethodIDNoThrow(global::android.os.RecoverySystem.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._RecoverySystem10183);
			Init(@__env, handle);
		}
		static RecoverySystem()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.RecoverySystem.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/RecoverySystem"));
		}
		internal static void InitJNI()
		{
		}
	}
}
