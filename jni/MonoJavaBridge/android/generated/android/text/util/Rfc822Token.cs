namespace android.text.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Rfc822Token : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Rfc822Token()
		{
			InitJNI();
		}
		protected Rfc822Token(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals8418;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.util.Rfc822Token._equals8418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._equals8418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString8419;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token._toString8419)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._toString8419)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode8420;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.util.Rfc822Token._hashCode8420);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._hashCode8420);
		}
		internal static global::MonoJavaBridge.MethodId _getAddress8421;
		public virtual global::java.lang.String getAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token._getAddress8421)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._getAddress8421)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getName8422;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token._getName8422)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._getName8422)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setName8423;
		public virtual void setName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token._setName8423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._setName8423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setComment8424;
		public virtual void setComment(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token._setComment8424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._setComment8424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getComment8425;
		public virtual global::java.lang.String getComment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token._getComment8425)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._getComment8425)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setAddress8426;
		public virtual void setAddress(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token._setAddress8426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._setAddress8426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _quoteNameIfNecessary8427;
		public static global::java.lang.String quoteNameIfNecessary(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._quoteNameIfNecessary8427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _quoteName8428;
		public static global::java.lang.String quoteName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._quoteName8428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _quoteComment8429;
		public static global::java.lang.String quoteComment(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._quoteComment8429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Rfc822Token8430;
		public Rfc822Token(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._Rfc822Token8430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.util.Rfc822Token.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/util/Rfc822Token"));
			global::android.text.util.Rfc822Token._equals8418 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.text.util.Rfc822Token._toString8419 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._hashCode8420 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "hashCode", "()I");
			global::android.text.util.Rfc822Token._getAddress8421 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "getAddress", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._getName8422 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "getName", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._setName8423 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "setName", "(Ljava/lang/String;)V");
			global::android.text.util.Rfc822Token._setComment8424 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::android.text.util.Rfc822Token._getComment8425 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "getComment", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._setAddress8426 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "setAddress", "(Ljava/lang/String;)V");
			global::android.text.util.Rfc822Token._quoteNameIfNecessary8427 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "quoteNameIfNecessary", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.util.Rfc822Token._quoteName8428 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "quoteName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.util.Rfc822Token._quoteComment8429 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "quoteComment", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.util.Rfc822Token._Rfc822Token8430 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
