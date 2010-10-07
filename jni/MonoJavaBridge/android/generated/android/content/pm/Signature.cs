namespace android.content.pm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Signature : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static Signature()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.Signature), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _equals2034;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.pm.Signature._equals2034, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._equals2034, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode2035;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.Signature._hashCode2035);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._hashCode2035);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toChars2036;
		public virtual char[] toChars() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.Signature._toChars2036));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._toChars2036));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toChars2037;
		public virtual char[] toChars(char[] arg0, int[] arg1) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.Signature._toChars2037, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._toChars2037, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toByteArray2038;
		public virtual byte[] toByteArray() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.Signature._toByteArray2038));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._toByteArray2038));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel2039;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.Signature._writeToParcel2039, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._writeToParcel2039, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents2040;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.Signature._describeContents2040);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._describeContents2040);
		}
		internal static global::net.sf.jni4net.jni.MethodId _toCharsString2041;
		public virtual global::java.lang.String toCharsString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.Signature._toCharsString2041));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._toCharsString2041));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Signature2042;
		public Signature(byte[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.Signature.staticClass, global::android.content.pm.Signature._Signature2042, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Signature2043;
		public Signature(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.Signature.staticClass, global::android.content.pm.Signature._Signature2043, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR2044;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.pm.Signature.staticClass = @__class;
			global::android.content.pm.Signature._equals2034 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.pm.Signature._hashCode2035 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "hashCode", "()I");
			global::android.content.pm.Signature._toChars2036 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "toChars", "()[C");
			global::android.content.pm.Signature._toChars2037 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "toChars", "([C[I)[C");
			global::android.content.pm.Signature._toByteArray2038 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "toByteArray", "()[B");
			global::android.content.pm.Signature._writeToParcel2039 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.Signature._describeContents2040 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "describeContents", "()I");
			global::android.content.pm.Signature._toCharsString2041 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "toCharsString", "()Ljava/lang/String;");
			global::android.content.pm.Signature._Signature2042 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "<init>", "([B)V");
			global::android.content.pm.Signature._Signature2043 = @__env.GetMethodID(global::android.content.pm.Signature.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
