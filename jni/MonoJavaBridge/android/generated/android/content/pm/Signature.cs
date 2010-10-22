namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Signature : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Signature()
		{
			InitJNI();
		}
		protected Signature(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals4037;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.pm.Signature._equals4037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._equals4037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode4038;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.Signature._hashCode4038);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._hashCode4038);
		}
		internal static global::MonoJavaBridge.MethodId _toChars4039;
		public virtual char[] toChars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.Signature._toChars4039)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._toChars4039)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _toChars4040;
		public virtual char[] toChars(char[] arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.Signature._toChars4040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._toChars4040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray4041;
		public virtual byte[] toByteArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.Signature._toByteArray4041)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._toByteArray4041)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4042;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.Signature._writeToParcel4042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._writeToParcel4042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4043;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.Signature._describeContents4043);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._describeContents4043);
		}
		internal static global::MonoJavaBridge.MethodId _toCharsString4044;
		public virtual global::java.lang.String toCharsString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.Signature._toCharsString4044)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._toCharsString4044)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Signature4045;
		public Signature(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.Signature.staticClass, global::android.content.pm.Signature._Signature4045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Signature4046;
		public Signature(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.Signature.staticClass, global::android.content.pm.Signature._Signature4046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4047;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.Signature.staticClass, _CREATOR4047)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.Signature.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/Signature"));
			global::android.content.pm.Signature._equals4037 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.pm.Signature._hashCode4038 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "hashCode", "()I");
			global::android.content.pm.Signature._toChars4039 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "toChars", "()[C");
			global::android.content.pm.Signature._toChars4040 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "toChars", "([C[I)[C");
			global::android.content.pm.Signature._toByteArray4041 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "toByteArray", "()[B");
			global::android.content.pm.Signature._writeToParcel4042 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.Signature._describeContents4043 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "describeContents", "()I");
			global::android.content.pm.Signature._toCharsString4044 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "toCharsString", "()Ljava/lang/String;");
			global::android.content.pm.Signature._Signature4045 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "<init>", "([B)V");
			global::android.content.pm.Signature._Signature4046 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.content.pm.Signature._CREATOR4047 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.Signature.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
