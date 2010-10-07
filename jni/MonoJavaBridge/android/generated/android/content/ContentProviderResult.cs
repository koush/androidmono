namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ContentProviderResult : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static ContentProviderResult()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.ContentProviderResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.ContentProviderResult(@__env);
			}
		}
		protected ContentProviderResult(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1169;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.ContentProviderResult._toString1169));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._toString1169));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1170;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.ContentProviderResult._writeToParcel1170, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._writeToParcel1170, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1171;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.ContentProviderResult._describeContents1171);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._describeContents1171);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ContentProviderResult1172;
		public ContentProviderResult(android.net.Uri arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._ContentProviderResult1172, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ContentProviderResult1173;
		public ContentProviderResult(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._ContentProviderResult1173, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ContentProviderResult1174;
		public ContentProviderResult(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.ContentProviderResult.staticClass, global::android.content.ContentProviderResult._ContentProviderResult1174, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _uri1175;
		public global::android.net.Uri uri
		{
			get
			{
				return default(global::android.net.Uri);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _count1176;
		public global::java.lang.Integer count
		{
			get
			{
				return default(global::java.lang.Integer);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1177;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.ContentProviderResult.staticClass = @__class;
			global::android.content.ContentProviderResult._toString1169 = @__env.GetMethodID(global::android.content.ContentProviderResult.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.ContentProviderResult._writeToParcel1170 = @__env.GetMethodID(global::android.content.ContentProviderResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.ContentProviderResult._describeContents1171 = @__env.GetMethodID(global::android.content.ContentProviderResult.staticClass, "describeContents", "()I");
			global::android.content.ContentProviderResult._ContentProviderResult1172 = @__env.GetMethodID(global::android.content.ContentProviderResult.staticClass, "<init>", "(Landroid/net/Uri;)V");
			global::android.content.ContentProviderResult._ContentProviderResult1173 = @__env.GetMethodID(global::android.content.ContentProviderResult.staticClass, "<init>", "(I)V");
			global::android.content.ContentProviderResult._ContentProviderResult1174 = @__env.GetMethodID(global::android.content.ContentProviderResult.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
