namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CoderResult : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CoderResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.CoderResult.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.charset.CoderResult._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.charset.CoderResult.staticClass, "length", "()I", ref global::java.nio.charset.CoderResult._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void throwException()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.charset.CoderResult.staticClass, "throwException", "()V", ref global::java.nio.charset.CoderResult._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool isUnderflow()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CoderResult.staticClass, "isUnderflow", "()Z", ref global::java.nio.charset.CoderResult._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isError()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CoderResult.staticClass, "isError", "()Z", ref global::java.nio.charset.CoderResult._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isOverflow()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CoderResult.staticClass, "isOverflow", "()Z", ref global::java.nio.charset.CoderResult._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.nio.charset.CoderResult malformedForLength(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CoderResult._m6.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CoderResult._m6 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "malformedForLength", "(I)Ljava/nio/charset/CoderResult;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isMalformed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CoderResult.staticClass, "isMalformed", "()Z", ref global::java.nio.charset.CoderResult._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isUnmappable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CoderResult.staticClass, "isUnmappable", "()Z", ref global::java.nio.charset.CoderResult._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.nio.charset.CoderResult unmappableForLength(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CoderResult._m9.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CoderResult._m9 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "unmappableForLength", "(I)Ljava/nio/charset/CoderResult;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.FieldId _UNDERFLOW6499;
		public static global::java.nio.charset.CoderResult UNDERFLOW
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CoderResult.staticClass, _UNDERFLOW6499)) as java.nio.charset.CoderResult;
			}
		}
		internal static global::MonoJavaBridge.FieldId _OVERFLOW6500;
		public static global::java.nio.charset.CoderResult OVERFLOW
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CoderResult.staticClass, _OVERFLOW6500)) as java.nio.charset.CoderResult;
			}
		}
		static CoderResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CoderResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CoderResult"));
			global::java.nio.charset.CoderResult._UNDERFLOW6499 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "UNDERFLOW", "Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CoderResult._OVERFLOW6500 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "OVERFLOW", "Ljava/nio/charset/CoderResult;");
		}
	}
}
