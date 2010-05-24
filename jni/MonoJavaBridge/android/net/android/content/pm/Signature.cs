namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Signature : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Signature() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.Signature), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.pm.Signature(@__env); 
			} 
		} 
		protected Signature(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode1856; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.Signature)) 
				return @__env.CallIntMethod(this, _hashCode1856); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.Signature.staticClass, _hashCode1856); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals1857; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.Signature)) 
				return @__env.CallBooleanMethod(this, _equals1857, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.pm.Signature.staticClass, _equals1857, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toChars1858; 
		public virtual char[] toChars() 
		{ 
			if (GetType() == typeof(android.content.pm.Signature)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _toChars1858)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.Signature.staticClass, _toChars1858)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toChars1859; 
		public virtual char[] toChars(char[] arg0, int[] arg1) 
		{ 
			if (GetType() == typeof(android.content.pm.Signature)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _toChars1859, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.Signature.staticClass, _toChars1859, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toByteArray1860; 
		public virtual byte[] toByteArray() 
		{ 
			if (GetType() == typeof(android.content.pm.Signature)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _toByteArray1860)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.Signature.staticClass, _toByteArray1860)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1861; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.Signature)) 
				@__env.CallVoidMethod(this, _writeToParcel1861, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.Signature.staticClass, _writeToParcel1861, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1862; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.Signature)) 
				return @__env.CallIntMethod(this, _describeContents1862); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.Signature.staticClass, _describeContents1862); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toCharsString1863; 
		public virtual java.lang.String toCharsString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.Signature)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toCharsString1863)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.Signature.staticClass, _toCharsString1863)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Signature1864; 
		public Signature(byte[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.Signature.staticClass, _Signature1864, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Signature1865; 
		public Signature(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.Signature.staticClass, _Signature1865, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1866; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.Signature.staticClass = @__class; 
			global::android.content.pm.Signature._hashCode1856 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "hashCode", "()I"); 
			global::android.content.pm.Signature._equals1857 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.content.pm.Signature._toChars1858 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "toChars", "()[C"); 
			global::android.content.pm.Signature._toChars1859 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "toChars", "([C[I)[C"); 
			global::android.content.pm.Signature._toByteArray1860 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "toByteArray", "()[B"); 
			global::android.content.pm.Signature._writeToParcel1861 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.Signature._describeContents1862 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "describeContents", "()I"); 
			global::android.content.pm.Signature._toCharsString1863 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "toCharsString", "()Ljava/lang/String;"); 
			global::android.content.pm.Signature._Signature1864 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "<init>", "([B)V"); 
			global::android.content.pm.Signature._Signature1865 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
