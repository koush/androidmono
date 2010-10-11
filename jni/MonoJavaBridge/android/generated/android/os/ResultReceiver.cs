namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ResultReceiver : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ResultReceiver()
		{
			InitJNI();
		}
		protected ResultReceiver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _send6715;
		public virtual void send(int arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.ResultReceiver._send6715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._send6715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel6716;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.ResultReceiver._writeToParcel6716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._writeToParcel6716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents6717;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.ResultReceiver._describeContents6717);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._describeContents6717);
		}
		internal static global::MonoJavaBridge.MethodId _onReceiveResult6718;
		protected virtual void onReceiveResult(int arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.ResultReceiver._onReceiveResult6718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._onReceiveResult6718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ResultReceiver6719;
		public ResultReceiver(android.os.Handler arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ResultReceiver.staticClass, global::android.os.ResultReceiver._ResultReceiver6719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR6720;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.ResultReceiver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/ResultReceiver"));
			global::android.os.ResultReceiver._send6715 = @__env.GetMethodIDNoThrow(global::android.os.ResultReceiver.staticClass, "send", "(ILandroid/os/Bundle;)V");
			global::android.os.ResultReceiver._writeToParcel6716 = @__env.GetMethodIDNoThrow(global::android.os.ResultReceiver.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.ResultReceiver._describeContents6717 = @__env.GetMethodIDNoThrow(global::android.os.ResultReceiver.staticClass, "describeContents", "()I");
			global::android.os.ResultReceiver._onReceiveResult6718 = @__env.GetMethodIDNoThrow(global::android.os.ResultReceiver.staticClass, "onReceiveResult", "(ILandroid/os/Bundle;)V");
			global::android.os.ResultReceiver._ResultReceiver6719 = @__env.GetMethodIDNoThrow(global::android.os.ResultReceiver.staticClass, "<init>", "(Landroid/os/Handler;)V");
		}
	}
}
