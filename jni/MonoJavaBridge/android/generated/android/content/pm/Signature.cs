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
		internal static global::MonoJavaBridge.MethodId _equals2188;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.pm.Signature._equals2188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._equals2188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode2189;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.Signature._hashCode2189);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._hashCode2189);
		}
		internal static global::MonoJavaBridge.MethodId _toChars2190;
		public virtual char[] toChars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.Signature._toChars2190)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._toChars2190)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _toChars2191;
		public virtual char[] toChars(char[] arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.Signature._toChars2191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._toChars2191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _toByteArray2192;
		public virtual byte[] toByteArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.Signature._toByteArray2192)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._toByteArray2192)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2193;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.Signature._writeToParcel2193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._writeToParcel2193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2194;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.Signature._describeContents2194);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._describeContents2194);
		}
		internal static global::MonoJavaBridge.MethodId _toCharsString2195;
		public virtual global::java.lang.String toCharsString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.Signature._toCharsString2195)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.Signature.staticClass, global::android.content.pm.Signature._toCharsString2195)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Signature2196;
		public Signature(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.Signature.staticClass, global::android.content.pm.Signature._Signature2196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Signature2197;
		public Signature(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.Signature.staticClass, global::android.content.pm.Signature._Signature2197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2198;
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
			global::android.content.pm.Signature.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/Signature"));
			global::android.content.pm.Signature._equals2188 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.pm.Signature._hashCode2189 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "hashCode", "()I");
			global::android.content.pm.Signature._toChars2190 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "toChars", "()[C");
			global::android.content.pm.Signature._toChars2191 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "toChars", "([C[I)[C");
			global::android.content.pm.Signature._toByteArray2192 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "toByteArray", "()[B");
			global::android.content.pm.Signature._writeToParcel2193 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.Signature._describeContents2194 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "describeContents", "()I");
			global::android.content.pm.Signature._toCharsString2195 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "toCharsString", "()Ljava/lang/String;");
			global::android.content.pm.Signature._Signature2196 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "<init>", "([B)V");
			global::android.content.pm.Signature._Signature2197 = @__env.GetMethodIDNoThrow(global::android.content.pm.Signature.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
