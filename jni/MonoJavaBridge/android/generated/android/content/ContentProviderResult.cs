namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentProviderResult : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentProviderResult()
		{
			InitJNI();
		}
		protected ContentProviderResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString2697;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderResult._toString2697)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._toString2697)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2698;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentProviderResult._writeToParcel2698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._writeToParcel2698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2699;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentProviderResult._describeContents2699);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._describeContents2699);
		}
		internal static global::MonoJavaBridge.MethodId _ContentProviderResult2700;
		public ContentProviderResult(android.net.Uri arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._ContentProviderResult2700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ContentProviderResult2701;
		public ContentProviderResult(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._ContentProviderResult2701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ContentProviderResult2702;
		public ContentProviderResult(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._ContentProviderResult2702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _uri2703;
		public global::android.net.Uri uri
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _uri2703)) as android.net.Uri;
			}
		}
		internal static global::MonoJavaBridge.FieldId _count2704;
		public global::java.lang.Integer count
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.GetObjectField(this.JvmHandle, _count2704)) as java.lang.Integer;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2705;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.ContentProviderResult.staticClass, _CREATOR2705)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentProviderResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProviderResult"));
			global::android.content.ContentProviderResult._toString2697 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderResult.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.ContentProviderResult._writeToParcel2698 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.ContentProviderResult._describeContents2699 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderResult.staticClass, "describeContents", "()I");
			global::android.content.ContentProviderResult._ContentProviderResult2700 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderResult.staticClass, "<init>", "(Landroid/net/Uri;)V");
			global::android.content.ContentProviderResult._ContentProviderResult2701 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderResult.staticClass, "<init>", "(I)V");
			global::android.content.ContentProviderResult._ContentProviderResult2702 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderResult.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.content.ContentProviderResult._uri2703 = @__env.GetFieldIDNoThrow(global::android.content.ContentProviderResult.staticClass, "uri", "Landroid/net/Uri;");
			global::android.content.ContentProviderResult._count2704 = @__env.GetFieldIDNoThrow(global::android.content.ContentProviderResult.staticClass, "count", "Ljava/lang/Integer;");
			global::android.content.ContentProviderResult._CREATOR2705 = @__env.GetStaticFieldIDNoThrow(global::android.content.ContentProviderResult.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
