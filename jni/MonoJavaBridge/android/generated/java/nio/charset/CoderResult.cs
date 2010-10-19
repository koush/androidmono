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
		internal static global::MonoJavaBridge.MethodId _toString17080;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CoderResult._toString17080)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._toString17080)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length17081;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.charset.CoderResult._length17081);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._length17081);
		}
		internal static global::MonoJavaBridge.MethodId _throwException17082;
		public virtual void throwException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CoderResult._throwException17082);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._throwException17082);
		}
		internal static global::MonoJavaBridge.MethodId _isUnderflow17083;
		public virtual bool isUnderflow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult._isUnderflow17083);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isUnderflow17083);
		}
		internal static global::MonoJavaBridge.MethodId _isError17084;
		public virtual bool isError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult._isError17084);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isError17084);
		}
		internal static global::MonoJavaBridge.MethodId _isOverflow17085;
		public virtual bool isOverflow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult._isOverflow17085);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isOverflow17085);
		}
		internal static global::MonoJavaBridge.MethodId _malformedForLength17086;
		public static global::java.nio.charset.CoderResult malformedForLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._malformedForLength17086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _isMalformed17087;
		public virtual bool isMalformed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult._isMalformed17087);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isMalformed17087);
		}
		internal static global::MonoJavaBridge.MethodId _isUnmappable17088;
		public virtual bool isUnmappable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult._isUnmappable17088);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isUnmappable17088);
		}
		internal static global::MonoJavaBridge.MethodId _unmappableForLength17089;
		public static global::java.nio.charset.CoderResult unmappableForLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._unmappableForLength17089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.FieldId _UNDERFLOW17090;
		public static global::java.nio.charset.CoderResult UNDERFLOW
		{
			get
			{
				return default(global::java.nio.charset.CoderResult);
			}
		}
		internal static global::MonoJavaBridge.FieldId _OVERFLOW17091;
		public static global::java.nio.charset.CoderResult OVERFLOW
		{
			get
			{
				return default(global::java.nio.charset.CoderResult);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CoderResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CoderResult"));
			global::java.nio.charset.CoderResult._toString17080 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.charset.CoderResult._length17081 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "length", "()I");
			global::java.nio.charset.CoderResult._throwException17082 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "throwException", "()V");
			global::java.nio.charset.CoderResult._isUnderflow17083 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isUnderflow", "()Z");
			global::java.nio.charset.CoderResult._isError17084 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isError", "()Z");
			global::java.nio.charset.CoderResult._isOverflow17085 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isOverflow", "()Z");
			global::java.nio.charset.CoderResult._malformedForLength17086 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "malformedForLength", "(I)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CoderResult._isMalformed17087 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isMalformed", "()Z");
			global::java.nio.charset.CoderResult._isUnmappable17088 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isUnmappable", "()Z");
			global::java.nio.charset.CoderResult._unmappableForLength17089 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "unmappableForLength", "(I)Ljava/nio/charset/CoderResult;");
		}
	}
}
