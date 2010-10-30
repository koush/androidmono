namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Signature : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Signature(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals4054;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.pm.Signature.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.content.pm.Signature._equals4054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode4055;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.Signature.staticClass, "hashCode", "()I", ref global::android.content.pm.Signature._hashCode4055);
		}
		internal static global::MonoJavaBridge.MethodId _toChars4056;
		public virtual char[] toChars()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.content.pm.Signature.staticClass, "toChars", "()[C", ref global::android.content.pm.Signature._toChars4056) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _toChars4057;
		public virtual char[] toChars(char[] arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.content.pm.Signature.staticClass, "toChars", "([C[I)[C", ref global::android.content.pm.Signature._toChars4057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray4058;
		public virtual byte[] toByteArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.content.pm.Signature.staticClass, "toByteArray", "()[B", ref global::android.content.pm.Signature._toByteArray4058) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4059;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.Signature.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.Signature._writeToParcel4059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4060;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.Signature.staticClass, "describeContents", "()I", ref global::android.content.pm.Signature._describeContents4060);
		}
		internal static global::MonoJavaBridge.MethodId _toCharsString4061;
		public virtual global::java.lang.String toCharsString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.Signature.staticClass, "toCharsString", "()Ljava/lang/String;", ref global::android.content.pm.Signature._toCharsString4061) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Signature4062;
		public Signature(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.Signature._Signature4062.native == global::System.IntPtr.Zero)
				global::android.content.pm.Signature._Signature4062 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.Signature.staticClass, global::android.content.pm.Signature._Signature4062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Signature4063;
		public Signature(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.Signature._Signature4063.native == global::System.IntPtr.Zero)
				global::android.content.pm.Signature._Signature4063 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.Signature.staticClass, global::android.content.pm.Signature._Signature4063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4064;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.Signature.staticClass, _CREATOR4064)) as android.os.Parcelable_Creator;
			}
		}
		static Signature()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.Signature.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/Signature"));
			global::android.content.pm.Signature._CREATOR4064 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.Signature.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
