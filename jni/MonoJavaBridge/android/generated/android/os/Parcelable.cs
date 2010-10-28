namespace android.os
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.Parcelable_))]
	public partial interface Parcelable  : global::MonoJavaBridge.IJavaObject 
	{
		void writeToParcel(android.os.Parcel arg0, int arg1);
		int describeContents();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.Parcelable))]
	internal sealed partial class Parcelable_ : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Parcelable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel10113;
		void android.os.Parcelable.writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcelable_._writeToParcel10113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcelable_.staticClass, global::android.os.Parcelable_._writeToParcel10113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents10114;
		int android.os.Parcelable.describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcelable_._describeContents10114);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcelable_.staticClass, global::android.os.Parcelable_._describeContents10114);
		}
		static Parcelable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Parcelable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Parcelable"));
			global::android.os.Parcelable_._writeToParcel10113 = @__env.GetMethodIDNoThrow(global::android.os.Parcelable_.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.Parcelable_._describeContents10114 = @__env.GetMethodIDNoThrow(global::android.os.Parcelable_.staticClass, "describeContents", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}
