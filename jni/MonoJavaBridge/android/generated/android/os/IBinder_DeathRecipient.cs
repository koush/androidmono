namespace android.os
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.IBinder_DeathRecipient_))]
	public interface IBinder_DeathRecipient  : global::MonoJavaBridge.IJavaObject 
	{
		void binderDied();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.IBinder_DeathRecipient))]
	public sealed partial class IBinder_DeathRecipient_ : java.lang.Object, IBinder_DeathRecipient
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IBinder_DeathRecipient_()
		{
			InitJNI();
		}
		internal IBinder_DeathRecipient_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _binderDied9852;
		 void android.os.IBinder_DeathRecipient.binderDied() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.IBinder_DeathRecipient_._binderDied9852);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.IBinder_DeathRecipient_.staticClass, global::android.os.IBinder_DeathRecipient_._binderDied9852);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.IBinder_DeathRecipient_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/IBinder_DeathRecipient"));
			global::android.os.IBinder_DeathRecipient_._binderDied9852 = @__env.GetMethodIDNoThrow(global::android.os.IBinder_DeathRecipient_.staticClass, "binderDied", "()V");
		}
	}
}
