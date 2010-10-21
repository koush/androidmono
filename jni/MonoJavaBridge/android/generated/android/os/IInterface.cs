namespace android.os
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.IInterface_))]
	public interface IInterface  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.os.IBinder asBinder();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.IInterface))]
	public sealed partial class IInterface_ : java.lang.Object, IInterface
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IInterface_()
		{
			InitJNI();
		}
		internal IInterface_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _asBinder9867;
		 global::android.os.IBinder android.os.IInterface.asBinder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.IInterface_._asBinder9867)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.IInterface_.staticClass, global::android.os.IInterface_._asBinder9867)) as android.os.IBinder;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.IInterface_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/IInterface"));
			global::android.os.IInterface_._asBinder9867 = @__env.GetMethodIDNoThrow(global::android.os.IInterface_.staticClass, "asBinder", "()Landroid/os/IBinder;");
		}
	}
}
