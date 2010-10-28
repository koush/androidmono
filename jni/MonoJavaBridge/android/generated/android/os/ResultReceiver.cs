namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ResultReceiver : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResultReceiver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _send10196;
		public virtual void send(int arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.ResultReceiver._send10196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._send10196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel10197;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.ResultReceiver._writeToParcel10197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._writeToParcel10197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents10198;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.ResultReceiver._describeContents10198);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._describeContents10198);
		}
		internal static global::MonoJavaBridge.MethodId _onReceiveResult10199;
		protected virtual void onReceiveResult(int arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.ResultReceiver._onReceiveResult10199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._onReceiveResult10199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ResultReceiver10200;
		public ResultReceiver(android.os.Handler arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._ResultReceiver10200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR10201;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.ResultReceiver.staticClass, _CREATOR10201)) as android.os.Parcelable_Creator;
			}
		}
		static ResultReceiver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.ResultReceiver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/ResultReceiver"));
			global::android.os.ResultReceiver._send10196 = @__env.GetMethodIDNoThrow(global::android.os.ResultReceiver.staticClass, "send", "(ILandroid/os/Bundle;)V");
			global::android.os.ResultReceiver._writeToParcel10197 = @__env.GetMethodIDNoThrow(global::android.os.ResultReceiver.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.ResultReceiver._describeContents10198 = @__env.GetMethodIDNoThrow(global::android.os.ResultReceiver.staticClass, "describeContents", "()I");
			global::android.os.ResultReceiver._onReceiveResult10199 = @__env.GetMethodIDNoThrow(global::android.os.ResultReceiver.staticClass, "onReceiveResult", "(ILandroid/os/Bundle;)V");
			global::android.os.ResultReceiver._ResultReceiver10200 = @__env.GetMethodIDNoThrow(global::android.os.ResultReceiver.staticClass, "<init>", "(Landroid/os/Handler;)V");
			global::android.os.ResultReceiver._CREATOR10201 = @__env.GetStaticFieldIDNoThrow(global::android.os.ResultReceiver.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
