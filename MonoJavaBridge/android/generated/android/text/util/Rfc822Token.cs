namespace android.text.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Rfc822Token : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Rfc822Token(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.util.Rfc822Token.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.text.util.Rfc822Token._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.util.Rfc822Token.staticClass, "toString", "()Ljava/lang/String;", ref global::android.text.util.Rfc822Token._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.util.Rfc822Token.staticClass, "hashCode", "()I", ref global::android.text.util.Rfc822Token._m2);
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
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.util.Rfc822Token.staticClass, "getAddress", "()Ljava/lang/String;", ref global::android.text.util.Rfc822Token._m3) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.util.Rfc822Token.staticClass, "getName", "()Ljava/lang/String;", ref global::android.text.util.Rfc822Token._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.util.Rfc822Token.staticClass, "setName", "(Ljava/lang/String;)V", ref global::android.text.util.Rfc822Token._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.util.Rfc822Token.staticClass, "setComment", "(Ljava/lang/String;)V", ref global::android.text.util.Rfc822Token._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getComment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.util.Rfc822Token.staticClass, "getComment", "()Ljava/lang/String;", ref global::android.text.util.Rfc822Token._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setAddress(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.util.Rfc822Token.staticClass, "setAddress", "(Ljava/lang/String;)V", ref global::android.text.util.Rfc822Token._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.String quoteNameIfNecessary(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.util.Rfc822Token._m9.native == global::System.IntPtr.Zero)
				global::android.text.util.Rfc822Token._m9 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "quoteNameIfNecessary", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.lang.String quoteName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.util.Rfc822Token._m10.native == global::System.IntPtr.Zero)
				global::android.text.util.Rfc822Token._m10 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "quoteName", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.lang.String quoteComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.util.Rfc822Token._m11.native == global::System.IntPtr.Zero)
				global::android.text.util.Rfc822Token._m11 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "quoteComment", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public Rfc822Token(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.util.Rfc822Token._m12.native == global::System.IntPtr.Zero)
				global::android.text.util.Rfc822Token._m12 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Rfc822Token()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.util.Rfc822Token.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/util/Rfc822Token"));
		}
	}
}
