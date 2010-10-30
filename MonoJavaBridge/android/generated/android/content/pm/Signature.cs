namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Signature : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Signature(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.pm.Signature.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.content.pm.Signature._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.Signature.staticClass, "hashCode", "()I", ref global::android.content.pm.Signature._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual char[] toChars()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.content.pm.Signature.staticClass, "toChars", "()[C", ref global::android.content.pm.Signature._m2) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual char[] toChars(char[] arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.content.pm.Signature.staticClass, "toChars", "([C[I)[C", ref global::android.content.pm.Signature._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual byte[] toByteArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.content.pm.Signature.staticClass, "toByteArray", "()[B", ref global::android.content.pm.Signature._m4) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.Signature.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.Signature._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.Signature.staticClass, "describeContents", "()I", ref global::android.content.pm.Signature._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String toCharsString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.Signature.staticClass, "toCharsString", "()Ljava/lang/String;", ref global::android.content.pm.Signature._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public Signature(byte[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.Signature._m8.native == global::System.IntPtr.Zero)
				global::android.content.pm.Signature._m8 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "<init>", "([B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.Signature.staticClass, global::android.content.pm.Signature._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public Signature(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.Signature._m9.native == global::System.IntPtr.Zero)
				global::android.content.pm.Signature._m9 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.Signature.staticClass, global::android.content.pm.Signature._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2128;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.Signature.staticClass, _CREATOR2128)) as android.os.Parcelable_Creator;
			}
		}
		static Signature()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.Signature.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/Signature"));
			global::android.content.pm.Signature._CREATOR2128 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.Signature.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
