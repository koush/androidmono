namespace java.math
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class MathContext : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MathContext()
		{
			InitJNI();
		}
		internal MathContext(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals15643;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.math.MathContext._equals15643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.math.MathContext.staticClass, global::java.math.MathContext._equals15643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15644;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.MathContext._toString15644)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.MathContext.staticClass, global::java.math.MathContext._toString15644)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15645;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.MathContext._hashCode15645);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.MathContext.staticClass, global::java.math.MathContext._hashCode15645);
		}
		public new int Precision
		{
			get
			{
				return getPrecision();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrecision15646;
		public int getPrecision() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.math.MathContext._getPrecision15646);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.math.MathContext.staticClass, global::java.math.MathContext._getPrecision15646);
		}
		public new global::java.math.RoundingMode RoundingMode
		{
			get
			{
				return getRoundingMode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRoundingMode15647;
		public global::java.math.RoundingMode getRoundingMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.math.MathContext._getRoundingMode15647)) as java.math.RoundingMode;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.math.MathContext.staticClass, global::java.math.MathContext._getRoundingMode15647)) as java.math.RoundingMode;
		}
		internal static global::MonoJavaBridge.MethodId _MathContext15648;
		public MathContext(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.MathContext.staticClass, global::java.math.MathContext._MathContext15648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MathContext15649;
		public MathContext(int arg0, java.math.RoundingMode arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.MathContext.staticClass, global::java.math.MathContext._MathContext15649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MathContext15650;
		public MathContext(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.math.MathContext.staticClass, global::java.math.MathContext._MathContext15650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _UNLIMITED15651;
		public static global::java.math.MathContext UNLIMITED
		{
			get
			{
				return default(global::java.math.MathContext);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DECIMAL3215652;
		public static global::java.math.MathContext DECIMAL32
		{
			get
			{
				return default(global::java.math.MathContext);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DECIMAL6415653;
		public static global::java.math.MathContext DECIMAL64
		{
			get
			{
				return default(global::java.math.MathContext);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DECIMAL12815654;
		public static global::java.math.MathContext DECIMAL128
		{
			get
			{
				return default(global::java.math.MathContext);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.math.MathContext.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/math/MathContext"));
			global::java.math.MathContext._equals15643 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.math.MathContext._toString15644 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "toString", "()Ljava/lang/String;");
			global::java.math.MathContext._hashCode15645 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "hashCode", "()I");
			global::java.math.MathContext._getPrecision15646 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "getPrecision", "()I");
			global::java.math.MathContext._getRoundingMode15647 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "getRoundingMode", "()Ljava/math/RoundingMode;");
			global::java.math.MathContext._MathContext15648 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "<init>", "(I)V");
			global::java.math.MathContext._MathContext15649 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "<init>", "(ILjava/math/RoundingMode;)V");
			global::java.math.MathContext._MathContext15650 = @__env.GetMethodIDNoThrow(global::java.math.MathContext.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
