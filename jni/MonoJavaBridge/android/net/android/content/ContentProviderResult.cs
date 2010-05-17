namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ContentProviderResult : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static ContentProviderResult() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.ContentProviderResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString1021; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderResult)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1021)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentProviderResult.staticClass, _toString1021)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1022; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderResult)) 
				@__env.CallVoidMethod(this, _writeToParcel1022, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentProviderResult.staticClass, _writeToParcel1022, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1023; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentProviderResult)) 
				return @__env.CallIntMethod(this, _describeContents1023); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ContentProviderResult.staticClass, _describeContents1023); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentProviderResult1024; 
		public ContentProviderResult(android.net.Uri arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ContentProviderResult.staticClass, _ContentProviderResult1024, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentProviderResult1025; 
		public ContentProviderResult(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ContentProviderResult.staticClass, _ContentProviderResult1025, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentProviderResult1026; 
		public ContentProviderResult(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ContentProviderResult.staticClass, _ContentProviderResult1026, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _uri1027; 
		public android.net.Uri uri
		{ 
			get 
			{ 
				return default(android.net.Uri); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _count1028; 
		public java.lang.Integer count
		{ 
			get 
			{ 
				return default(java.lang.Integer); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1029; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.ContentProviderResult.staticClass = @__class; 
			global::android.content.ContentProviderResult._toString1021 = @__env.GetMethodID(global::android.content.ContentProviderResult.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.ContentProviderResult._writeToParcel1022 = @__env.GetMethodID(global::android.content.ContentProviderResult.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.ContentProviderResult._describeContents1023 = @__env.GetMethodID(global::android.content.ContentProviderResult.staticClass, "describeContents", "()I"); 
			global::android.content.ContentProviderResult._ContentProviderResult1024 = @__env.GetMethodID(global::android.content.ContentProviderResult.staticClass, "<init>", "(Landroid/net/Uri;)V"); 
			global::android.content.ContentProviderResult._ContentProviderResult1025 = @__env.GetMethodID(global::android.content.ContentProviderResult.staticClass, "<init>", "(I)V"); 
			global::android.content.ContentProviderResult._ContentProviderResult1026 = @__env.GetMethodID(global::android.content.ContentProviderResult.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
