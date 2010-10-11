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
		internal static global::MonoJavaBridge.MethodId _toString1192;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentProviderResult._toString1192)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._toString1192)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1193;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentProviderResult._writeToParcel1193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._writeToParcel1193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1194;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentProviderResult._describeContents1194);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._describeContents1194);
		}
		internal static global::MonoJavaBridge.MethodId _ContentProviderResult1195;
		public ContentProviderResult(android.net.Uri arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._ContentProviderResult1195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ContentProviderResult1196;
		public ContentProviderResult(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._ContentProviderResult1196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ContentProviderResult1197;
		public ContentProviderResult(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._ContentProviderResult1197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _uri1198;
		public global::android.net.Uri uri
		{
			get
			{
				return default(global::android.net.Uri);
			}
		}
		internal static global::MonoJavaBridge.FieldId _count1199;
		public global::java.lang.Integer count
		{
			get
			{
				return default(global::java.lang.Integer);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1200;
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
			global::android.content.ContentProviderResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentProviderResult"));
			global::android.content.ContentProviderResult._toString1192 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderResult.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.ContentProviderResult._writeToParcel1193 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.ContentProviderResult._describeContents1194 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderResult.staticClass, "describeContents", "()I");
			global::android.content.ContentProviderResult._ContentProviderResult1195 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderResult.staticClass, "<init>", "(Landroid/net/Uri;)V");
			global::android.content.ContentProviderResult._ContentProviderResult1196 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderResult.staticClass, "<init>", "(I)V");
			global::android.content.ContentProviderResult._ContentProviderResult1197 = @__env.GetMethodIDNoThrow(global::android.content.ContentProviderResult.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
