namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.ParcelableSpan_))]
	public partial interface ParcelableSpan : android.os.Parcelable
	{
		int getSpanTypeId();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.ParcelableSpan))]
	internal sealed partial class ParcelableSpan_ : java.lang.Object, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ParcelableSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId12903;
		int android.text.ParcelableSpan.getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.ParcelableSpan_.staticClass, "getSpanTypeId", "()I", ref global::android.text.ParcelableSpan_._getSpanTypeId12903);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel12904;
		void android.os.Parcelable.writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.ParcelableSpan_.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.text.ParcelableSpan_._writeToParcel12904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents12905;
		int android.os.Parcelable.describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.ParcelableSpan_.staticClass, "describeContents", "()I", ref global::android.text.ParcelableSpan_._describeContents12905);
		}
		static ParcelableSpan_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.ParcelableSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/ParcelableSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
