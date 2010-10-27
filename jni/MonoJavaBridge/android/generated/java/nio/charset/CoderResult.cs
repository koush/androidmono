namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CoderResult : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CoderResult()
		{
			InitJNI();
		}
		protected CoderResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString22796;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CoderResult._toString22796)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._toString22796)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length22797;
		public virtual int length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.charset.CoderResult._length22797);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._length22797);
		}
		internal static global::MonoJavaBridge.MethodId _throwException22798;
		public virtual void throwException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CoderResult._throwException22798);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._throwException22798);
		}
		internal static global::MonoJavaBridge.MethodId _isUnderflow22799;
		public virtual bool isUnderflow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult._isUnderflow22799);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isUnderflow22799);
		}
		internal static global::MonoJavaBridge.MethodId _isError22800;
		public virtual bool isError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult._isError22800);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isError22800);
		}
		internal static global::MonoJavaBridge.MethodId _isOverflow22801;
		public virtual bool isOverflow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult._isOverflow22801);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isOverflow22801);
		}
		internal static global::MonoJavaBridge.MethodId _malformedForLength22802;
		public static global::java.nio.charset.CoderResult malformedForLength(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._malformedForLength22802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _isMalformed22803;
		public virtual bool isMalformed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult._isMalformed22803);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isMalformed22803);
		}
		internal static global::MonoJavaBridge.MethodId _isUnmappable22804;
		public virtual bool isUnmappable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult._isUnmappable22804);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isUnmappable22804);
		}
		internal static global::MonoJavaBridge.MethodId _unmappableForLength22805;
		public static global::java.nio.charset.CoderResult unmappableForLength(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._unmappableForLength22805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.FieldId _UNDERFLOW22806;
		public static global::java.nio.charset.CoderResult UNDERFLOW
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CoderResult.staticClass, _UNDERFLOW22806)) as java.nio.charset.CoderResult;
			}
		}
		internal static global::MonoJavaBridge.FieldId _OVERFLOW22807;
		public static global::java.nio.charset.CoderResult OVERFLOW
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CoderResult.staticClass, _OVERFLOW22807)) as java.nio.charset.CoderResult;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CoderResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CoderResult"));
			global::java.nio.charset.CoderResult._toString22796 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.charset.CoderResult._length22797 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "length", "()I");
			global::java.nio.charset.CoderResult._throwException22798 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "throwException", "()V");
			global::java.nio.charset.CoderResult._isUnderflow22799 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isUnderflow", "()Z");
			global::java.nio.charset.CoderResult._isError22800 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isError", "()Z");
			global::java.nio.charset.CoderResult._isOverflow22801 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isOverflow", "()Z");
			global::java.nio.charset.CoderResult._malformedForLength22802 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "malformedForLength", "(I)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CoderResult._isMalformed22803 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isMalformed", "()Z");
			global::java.nio.charset.CoderResult._isUnmappable22804 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isUnmappable", "()Z");
			global::java.nio.charset.CoderResult._unmappableForLength22805 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "unmappableForLength", "(I)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CoderResult._UNDERFLOW22806 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "UNDERFLOW", "Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CoderResult._OVERFLOW22807 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "OVERFLOW", "Ljava/nio/charset/CoderResult;");
		}
	}
}
