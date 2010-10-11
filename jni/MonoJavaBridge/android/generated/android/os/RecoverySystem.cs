namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RecoverySystem : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RecoverySystem()
		{
			InitJNI();
		}
		protected RecoverySystem(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.RecoverySystem.ProgressListener_))]
		public interface ProgressListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onProgress(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.RecoverySystem.ProgressListener))]
		public sealed partial class ProgressListener_ : java.lang.Object, ProgressListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ProgressListener_()
			{
				InitJNI();
			}
			internal ProgressListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onProgress6698;
			 void android.os.RecoverySystem.ProgressListener.onProgress(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.os.RecoverySystem.ProgressListener_._onProgress6698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.RecoverySystem.ProgressListener_.staticClass, global::android.os.RecoverySystem.ProgressListener_._onProgress6698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.RecoverySystem.ProgressListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/RecoverySystem$ProgressListener"));
				global::android.os.RecoverySystem.ProgressListener_._onProgress6698 = @__env.GetMethodIDNoThrow(global::android.os.RecoverySystem.ProgressListener_.staticClass, "onProgress", "(I)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _verifyPackage6699;
		public static void verifyPackage(java.io.File arg0, android.os.RecoverySystem.ProgressListener arg1, java.io.File arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._verifyPackage6699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _installPackage6700;
		public static void installPackage(android.content.Context arg0, java.io.File arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._installPackage6700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rebootWipeUserData6701;
		public static void rebootWipeUserData(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._rebootWipeUserData6701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RecoverySystem6702;
		public RecoverySystem()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._RecoverySystem6702);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.RecoverySystem.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/RecoverySystem"));
			global::android.os.RecoverySystem._verifyPackage6699 = @__env.GetStaticMethodIDNoThrow(global::android.os.RecoverySystem.staticClass, "verifyPackage", "(Ljava/io/File;Landroid/os/RecoverySystem$ProgressListener;Ljava/io/File;)V");
			global::android.os.RecoverySystem._installPackage6700 = @__env.GetStaticMethodIDNoThrow(global::android.os.RecoverySystem.staticClass, "installPackage", "(Landroid/content/Context;Ljava/io/File;)V");
			global::android.os.RecoverySystem._rebootWipeUserData6701 = @__env.GetStaticMethodIDNoThrow(global::android.os.RecoverySystem.staticClass, "rebootWipeUserData", "(Landroid/content/Context;)V");
			global::android.os.RecoverySystem._RecoverySystem6702 = @__env.GetMethodIDNoThrow(global::android.os.RecoverySystem.staticClass, "<init>", "()V");
		}
	}
}
