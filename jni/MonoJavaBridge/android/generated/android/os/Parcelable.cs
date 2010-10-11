namespace android.os
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.Parcelable_))]
	public interface Parcelable  : global::MonoJavaBridge.IJavaObject 
	{
		void writeToParcel(android.os.Parcel arg0, int arg1);
		int describeContents();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.Parcelable))]
	public sealed partial class Parcelable_ : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Parcelable_()
		{
			InitJNI();
		}
		internal Parcelable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel6662;
		 void android.os.Parcelable.writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcelable_._writeToParcel6662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcelable_.staticClass, global::android.os.Parcelable_._writeToParcel6662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents6663;
		 int android.os.Parcelable.describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcelable_._describeContents6663);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcelable_.staticClass, global::android.os.Parcelable_._describeContents6663);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Parcelable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Parcelable"));
			global::android.os.Parcelable_._writeToParcel6662 = @__env.GetMethodIDNoThrow(global::android.os.Parcelable_.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.Parcelable_._describeContents6663 = @__env.GetMethodIDNoThrow(global::android.os.Parcelable_.staticClass, "describeContents", "()I");
		}
	}
}
