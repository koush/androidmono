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
		internal static global::MonoJavaBridge.MethodId _equals8964;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.util.Rfc822Token._equals8964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._equals8964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString8965;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token._toString8965)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._toString8965)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode8966;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.util.Rfc822Token._hashCode8966);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._hashCode8966);
		}
		public new global::java.lang.String Address
		{
			get
			{
				return getAddress();
			}
			set
			{
				setAddress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress8967;
		public virtual global::java.lang.String getAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token._getAddress8967)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._getAddress8967)) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
			set
			{
				setName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName8968;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token._getName8968)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._getName8968)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setName8969;
		public virtual void setName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token._setName8969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._setName8969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setComment8970;
		public virtual void setComment(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token._setComment8970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._setComment8970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Comment
		{
			get
			{
				return getComment();
			}
			set
			{
				setComment(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComment8971;
		public virtual global::java.lang.String getComment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token._getComment8971)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._getComment8971)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setAddress8972;
		public virtual void setAddress(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token._setAddress8972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._setAddress8972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _quoteNameIfNecessary8973;
		public static global::java.lang.String quoteNameIfNecessary(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._quoteNameIfNecessary8973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _quoteName8974;
		public static global::java.lang.String quoteName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._quoteName8974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _quoteComment8975;
		public static global::java.lang.String quoteComment(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._quoteComment8975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Rfc822Token8976;
		public Rfc822Token(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._Rfc822Token8976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.util.Rfc822Token.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/util/Rfc822Token"));
			global::android.text.util.Rfc822Token._equals8964 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.text.util.Rfc822Token._toString8965 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._hashCode8966 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "hashCode", "()I");
			global::android.text.util.Rfc822Token._getAddress8967 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "getAddress", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._getName8968 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "getName", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._setName8969 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "setName", "(Ljava/lang/String;)V");
			global::android.text.util.Rfc822Token._setComment8970 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::android.text.util.Rfc822Token._getComment8971 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "getComment", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._setAddress8972 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "setAddress", "(Ljava/lang/String;)V");
			global::android.text.util.Rfc822Token._quoteNameIfNecessary8973 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "quoteNameIfNecessary", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.util.Rfc822Token._quoteName8974 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "quoteName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.util.Rfc822Token._quoteComment8975 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "quoteComment", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.util.Rfc822Token._Rfc822Token8976 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
