namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentProviderResult : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentProviderResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ContentProviderResult.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.ContentProviderResult._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentProviderResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.ContentProviderResult._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentProviderResult.staticClass, "describeContents", "()I", ref global::android.content.ContentProviderResult._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public ContentProviderResult(android.net.Uri arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentProviderResult._m3.native == global::System.IntPtr.Zero)
				global::android.content.ContentProviderResult._m3 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderResult.staticClass, "<init>", "(Landroid/net/Uri;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ContentProviderResult(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentProviderResult._m4.native == global::System.IntPtr.Zero)
				global::android.content.ContentProviderResult._m4 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderResult.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ContentProviderResult(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentProviderResult._m5.native == global::System.IntPtr.Zero)
				global::android.content.ContentProviderResult._m5 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderResult.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _uri1618;
		public global::android.net.Uri uri
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _uri1618)) as android.net.Uri;
			}
		}
		internal static global::MonoJavaBridge.FieldId _count1619;
		public global::java.lang.Integer count
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.GetObjectField(this.JvmHandle, _count1619)) as java.lang.Integer;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1620;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.ContentProviderResult.staticClass, _CREATOR1620)) as android.os.Parcelable_Creator;
			}
		}
		static ContentProviderResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentProviderResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProviderResult"));
			global::android.content.ContentProviderResult._uri1618 = @__env.GetFieldIDNoThrow(global::android.content.ContentProviderResult.staticClass, "uri", "Landroid/net/Uri;");
			global::android.content.ContentProviderResult._count1619 = @__env.GetFieldIDNoThrow(global::android.content.ContentProviderResult.staticClass, "count", "Ljava/lang/Integer;");
			global::android.content.ContentProviderResult._CREATOR1620 = @__env.GetStaticFieldIDNoThrow(global::android.content.ContentProviderResult.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
