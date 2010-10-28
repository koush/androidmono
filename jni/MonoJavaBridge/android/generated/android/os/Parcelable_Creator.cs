namespace android.os
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.os.Parcelable_Creator_))]
	public partial interface Parcelable_Creator  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object[] newArray(int arg0);
		global::java.lang.Object createFromParcel(android.os.Parcel arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.Parcelable_Creator))]
	internal sealed partial class Parcelable_Creator_ : java.lang.Object, Parcelable_Creator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Parcelable_Creator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newArray10111;
		global::java.lang.Object[] android.os.Parcelable_Creator.newArray(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcelable_Creator_._newArray10111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcelable_Creator_.staticClass, global::android.os.Parcelable_Creator_._newArray10111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _createFromParcel10112;
		global::java.lang.Object android.os.Parcelable_Creator.createFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcelable_Creator_._createFromParcel10112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcelable_Creator_.staticClass, global::android.os.Parcelable_Creator_._createFromParcel10112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		static Parcelable_Creator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Parcelable_Creator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Parcelable$Creator"));
			global::android.os.Parcelable_Creator_._newArray10111 = @__env.GetMethodIDNoThrow(global::android.os.Parcelable_Creator_.staticClass, "newArray", "(I)[Ljava/lang/Object;");
			global::android.os.Parcelable_Creator_._createFromParcel10112 = @__env.GetMethodIDNoThrow(global::android.os.Parcelable_Creator_.staticClass, "createFromParcel", "(Landroid/os/Parcel;)Ljava/lang/Object;");
		}
		internal static void InitJNI()
		{
		}
	}
}
