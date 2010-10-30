namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ResultReceiver : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResultReceiver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void send(int arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.ResultReceiver.staticClass, "send", "(ILandroid/os/Bundle;)V", ref global::android.os.ResultReceiver._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.ResultReceiver.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.os.ResultReceiver._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.ResultReceiver.staticClass, "describeContents", "()I", ref global::android.os.ResultReceiver._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual void onReceiveResult(int arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.ResultReceiver.staticClass, "onReceiveResult", "(ILandroid/os/Bundle;)V", ref global::android.os.ResultReceiver._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ResultReceiver(android.os.Handler arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.ResultReceiver._m4.native == global::System.IntPtr.Zero)
				global::android.os.ResultReceiver._m4 = @__env.GetMethodIDNoThrow(global::android.os.ResultReceiver.staticClass, "<init>", "(Landroid/os/Handler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4051;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.ResultReceiver.staticClass, _CREATOR4051)) as android.os.Parcelable_Creator;
			}
		}
		static ResultReceiver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.ResultReceiver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/ResultReceiver"));
			global::android.os.ResultReceiver._CREATOR4051 = @__env.GetStaticFieldIDNoThrow(global::android.os.ResultReceiver.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
