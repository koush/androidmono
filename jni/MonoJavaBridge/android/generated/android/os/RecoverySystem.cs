namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class RecoverySystem : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static RecoverySystem()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.RecoverySystem), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.os.RecoverySystem(@__env);
			}
		}
		protected RecoverySystem(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface ProgressListener 
		{
			void onProgress(int arg0);
		}

		public partial class ProgressListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __ProgressListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __ProgressListener : java.lang.Object, ProgressListener
		{
			internal static global::java.lang.Class staticClass;
			static __ProgressListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.RecoverySystem.__ProgressListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.os.RecoverySystem.__ProgressListener(@__env);
				}
			}
			internal __ProgressListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onProgress6425;
			 void android.os.RecoverySystem.ProgressListener.onProgress(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.os.RecoverySystem.__ProgressListener._onProgress6425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.os.RecoverySystem.__ProgressListener.staticClass, global::android.os.RecoverySystem.__ProgressListener._onProgress6425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.os.RecoverySystem.__ProgressListener.staticClass = @__class;
				global::android.os.RecoverySystem.__ProgressListener._onProgress6425 = @__env.GetMethodID(global::android.os.RecoverySystem.__ProgressListener.staticClass, "android.os.RecoverySystem.ProgressListener.onProgress", "(I)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _verifyPackage6426;
		public static void verifyPackage(java.io.File arg0, android.os.RecoverySystem.ProgressListener arg1, java.io.File arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._verifyPackage6426, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _installPackage6427;
		public static void installPackage(android.content.Context arg0, java.io.File arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._installPackage6427, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rebootWipeUserData6428;
		public static void rebootWipeUserData(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._rebootWipeUserData6428, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RecoverySystem6429;
		public RecoverySystem()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.RecoverySystem.staticClass, global::android.os.RecoverySystem._RecoverySystem6429, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.RecoverySystem.staticClass = @__class;
			global::android.os.RecoverySystem._verifyPackage6426 = @__env.GetStaticMethodID(global::android.os.RecoverySystem.staticClass, "verifyPackage", "(Ljava/io/File;Landroid/os/RecoverySystem$ProgressListener;Ljava/io/File;)V");
			global::android.os.RecoverySystem._installPackage6427 = @__env.GetStaticMethodID(global::android.os.RecoverySystem.staticClass, "installPackage", "(Landroid/content/Context;Ljava/io/File;)V");
			global::android.os.RecoverySystem._rebootWipeUserData6428 = @__env.GetStaticMethodID(global::android.os.RecoverySystem.staticClass, "rebootWipeUserData", "(Landroid/content/Context;)V");
			global::android.os.RecoverySystem._RecoverySystem6429 = @__env.GetMethodID(global::android.os.RecoverySystem.staticClass, "<init>", "()V");
		}
	}
}
