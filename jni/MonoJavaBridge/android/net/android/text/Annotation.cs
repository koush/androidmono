namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Annotation : java.lang.Object, ParcelableSpan
	{ 
		internal static global::java.lang.Class staticClass; 
		static Annotation() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.Annotation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.Annotation(@__env); 
			} 
		} 
		protected Annotation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValue6403; 
		public virtual java.lang.String getValue() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Annotation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getValue6403)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.Annotation.staticClass, _getValue6403)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getKey6404; 
		public virtual java.lang.String getKey() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Annotation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getKey6404)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.Annotation.staticClass, _getKey6404)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6405; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Annotation)) 
				@__env.CallVoidMethod(this, _writeToParcel6405, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.Annotation.staticClass, _writeToParcel6405, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents6406; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Annotation)) 
				return @__env.CallIntMethod(this, _describeContents6406); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Annotation.staticClass, _describeContents6406); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId6407; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.Annotation)) 
				return @__env.CallIntMethod(this, _getSpanTypeId6407); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.Annotation.staticClass, _getSpanTypeId6407); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Annotation6408; 
		public Annotation(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.Annotation.staticClass, _Annotation6408, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Annotation6409; 
		public Annotation(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.Annotation.staticClass, _Annotation6409, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.Annotation.staticClass = @__class; 
			global::android.text.Annotation._getValue6403 = @__env.GetMethodID(global::android.text.Annotation.staticClass, "getValue", "()Ljava/lang/String;"); 
			global::android.text.Annotation._getKey6404 = @__env.GetMethodID(global::android.text.Annotation.staticClass, "getKey", "()Ljava/lang/String;"); 
			global::android.text.Annotation._writeToParcel6405 = @__env.GetMethodID(global::android.text.Annotation.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.Annotation._describeContents6406 = @__env.GetMethodID(global::android.text.Annotation.staticClass, "describeContents", "()I"); 
			global::android.text.Annotation._getSpanTypeId6407 = @__env.GetMethodID(global::android.text.Annotation.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.Annotation._Annotation6408 = @__env.GetMethodID(global::android.text.Annotation.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.text.Annotation._Annotation6409 = @__env.GetMethodID(global::android.text.Annotation.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
