namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CoderResult : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CoderResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString22797;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CoderResult._toString22797.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CoderResult._toString22797 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._toString22797) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length22798;
		public virtual int length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CoderResult._length22798.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CoderResult._length22798 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "length", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._length22798);
		}
		internal static global::MonoJavaBridge.MethodId _throwException22799;
		public virtual void throwException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CoderResult._throwException22799.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CoderResult._throwException22799 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "throwException", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._throwException22799);
		}
		internal static global::MonoJavaBridge.MethodId _isUnderflow22800;
		public virtual bool isUnderflow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CoderResult._isUnderflow22800.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CoderResult._isUnderflow22800 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isUnderflow", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isUnderflow22800);
		}
		internal static global::MonoJavaBridge.MethodId _isError22801;
		public virtual bool isError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CoderResult._isError22801.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CoderResult._isError22801 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isError", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isError22801);
		}
		internal static global::MonoJavaBridge.MethodId _isOverflow22802;
		public virtual bool isOverflow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CoderResult._isOverflow22802.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CoderResult._isOverflow22802 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isOverflow", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isOverflow22802);
		}
		internal static global::MonoJavaBridge.MethodId _malformedForLength22803;
		public static global::java.nio.charset.CoderResult malformedForLength(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CoderResult._malformedForLength22803.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CoderResult._malformedForLength22803 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "malformedForLength", "(I)Ljava/nio/charset/CoderResult;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._malformedForLength22803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _isMalformed22804;
		public virtual bool isMalformed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CoderResult._isMalformed22804.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CoderResult._isMalformed22804 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isMalformed", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isMalformed22804);
		}
		internal static global::MonoJavaBridge.MethodId _isUnmappable22805;
		public virtual bool isUnmappable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CoderResult._isUnmappable22805.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CoderResult._isUnmappable22805 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isUnmappable", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isUnmappable22805);
		}
		internal static global::MonoJavaBridge.MethodId _unmappableForLength22806;
		public static global::java.nio.charset.CoderResult unmappableForLength(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.CoderResult._unmappableForLength22806.native == global::System.IntPtr.Zero)
				global::java.nio.charset.CoderResult._unmappableForLength22806 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "unmappableForLength", "(I)Ljava/nio/charset/CoderResult;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._unmappableForLength22806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.FieldId _UNDERFLOW22807;
		public static global::java.nio.charset.CoderResult UNDERFLOW
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CoderResult.staticClass, _UNDERFLOW22807)) as java.nio.charset.CoderResult;
			}
		}
		internal static global::MonoJavaBridge.FieldId _OVERFLOW22808;
		public static global::java.nio.charset.CoderResult OVERFLOW
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CoderResult.staticClass, _OVERFLOW22808)) as java.nio.charset.CoderResult;
			}
		}
		static CoderResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CoderResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CoderResult"));
			global::java.nio.charset.CoderResult._UNDERFLOW22807 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "UNDERFLOW", "Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CoderResult._OVERFLOW22808 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "OVERFLOW", "Ljava/nio/charset/CoderResult;");
		}
		internal static void InitJNI()
		{
		}
	}
}
