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
		internal static global::MonoJavaBridge.MethodId _toString22678;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.CoderResult._toString22678)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._toString22678)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length22679;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.charset.CoderResult._length22679);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._length22679);
		}
		internal static global::MonoJavaBridge.MethodId _throwException22680;
		public virtual void throwException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.charset.CoderResult._throwException22680);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._throwException22680);
		}
		internal static global::MonoJavaBridge.MethodId _isUnderflow22681;
		public virtual bool isUnderflow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult._isUnderflow22681);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isUnderflow22681);
		}
		internal static global::MonoJavaBridge.MethodId _isError22682;
		public virtual bool isError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult._isError22682);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isError22682);
		}
		internal static global::MonoJavaBridge.MethodId _isOverflow22683;
		public virtual bool isOverflow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult._isOverflow22683);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isOverflow22683);
		}
		internal static global::MonoJavaBridge.MethodId _malformedForLength22684;
		public static global::java.nio.charset.CoderResult malformedForLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._malformedForLength22684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.MethodId _isMalformed22685;
		public virtual bool isMalformed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult._isMalformed22685);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isMalformed22685);
		}
		internal static global::MonoJavaBridge.MethodId _isUnmappable22686;
		public virtual bool isUnmappable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult._isUnmappable22686);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isUnmappable22686);
		}
		internal static global::MonoJavaBridge.MethodId _unmappableForLength22687;
		public static global::java.nio.charset.CoderResult unmappableForLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._unmappableForLength22687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.CoderResult;
		}
		internal static global::MonoJavaBridge.FieldId _UNDERFLOW22688;
		public static global::java.nio.charset.CoderResult UNDERFLOW
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CoderResult.staticClass, _UNDERFLOW22688)) as java.nio.charset.CoderResult;
			}
		}
		internal static global::MonoJavaBridge.FieldId _OVERFLOW22689;
		public static global::java.nio.charset.CoderResult OVERFLOW
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.charset.CoderResult.staticClass, _OVERFLOW22689)) as java.nio.charset.CoderResult;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.CoderResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/CoderResult"));
			global::java.nio.charset.CoderResult._toString22678 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.charset.CoderResult._length22679 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "length", "()I");
			global::java.nio.charset.CoderResult._throwException22680 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "throwException", "()V");
			global::java.nio.charset.CoderResult._isUnderflow22681 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isUnderflow", "()Z");
			global::java.nio.charset.CoderResult._isError22682 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isError", "()Z");
			global::java.nio.charset.CoderResult._isOverflow22683 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isOverflow", "()Z");
			global::java.nio.charset.CoderResult._malformedForLength22684 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "malformedForLength", "(I)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CoderResult._isMalformed22685 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isMalformed", "()Z");
			global::java.nio.charset.CoderResult._isUnmappable22686 = @__env.GetMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "isUnmappable", "()Z");
			global::java.nio.charset.CoderResult._unmappableForLength22687 = @__env.GetStaticMethodIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "unmappableForLength", "(I)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CoderResult._UNDERFLOW22688 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "UNDERFLOW", "Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CoderResult._OVERFLOW22689 = @__env.GetStaticFieldIDNoThrow(global::java.nio.charset.CoderResult.staticClass, "OVERFLOW", "Ljava/nio/charset/CoderResult;");
		}
	}
}
