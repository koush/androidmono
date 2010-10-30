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
			private static global::MonoJavaBridge.MethodId _m0;
			void android.os.RecoverySystem.ProgressListener.onProgress(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.RecoverySystem.ProgressListener_.staticClass, "onProgress", "(I)V", ref global::android.os.RecoverySystem.ProgressListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			private static global::MonoJavaBridge.MethodId _m0;
			public ProgressListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.RecoverySystem.ProgressListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.os.RecoverySystem.ProgressListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.os.RecoverySystem.ProgressListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.RecoverySystem.ProgressListenerDelegateWrapper.staticClass, global::android.os.RecoverySystem.ProgressListenerDelegateWrapper._m0);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public static void verifyPackage(java.io.File arg0, android.os.RecoverySystem.ProgressListener arg1, java.io.File arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.RecoverySystem._m0.native == global::System.IntPtr.Zero)
				global::android.os.RecoverySystem._m0 = @__env.GetStaticMethodIDNoThrow(global::android.os.RecoverySystem.staticClass, "verifyPackage", "(Ljava/io/File;Landroid/os/RecoverySystem$ProgressListener;Ljava/io/File;)V");
			@__env.CallStaticVoidMethod(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static void verifyPackage(java.io.File arg0, global::android.os.RecoverySystem.ProgressListenerDelegate arg1, java.io.File arg2)
		{
			verifyPackage(arg0, (global::android.os.RecoverySystem.ProgressListenerDelegateWrapper)arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void installPackage(android.content.Context arg0, java.io.File arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.RecoverySystem._m1.native == global::System.IntPtr.Zero)
				global::android.os.RecoverySystem._m1 = @__env.GetStaticMethodIDNoThrow(global::android.os.RecoverySystem.staticClass, "installPackage", "(Landroid/content/Context;Ljava/io/File;)V");
			@__env.CallStaticVoidMethod(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void rebootWipeUserData(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.RecoverySystem._m2.native == global::System.IntPtr.Zero)
				global::android.os.RecoverySystem._m2 = @__env.GetStaticMethodIDNoThrow(global::android.os.RecoverySystem.staticClass, "rebootWipeUserData", "(Landroid/content/Context;)V");
			@__env.CallStaticVoidMethod(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public RecoverySystem() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.RecoverySystem._m3.native == global::System.IntPtr.Zero)
				global::android.os.RecoverySystem._m3 = @__env.GetMethodIDNoThrow(global::android.os.RecoverySystem.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._m3);
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
