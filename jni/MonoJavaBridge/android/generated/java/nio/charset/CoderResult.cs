namespace java.nio.charset
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class CoderResult : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static CoderResult()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.charset.CoderResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.nio.charset.CoderResult(@__env);
			}
		}
		protected CoderResult(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13134;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.charset.CoderResult._toString13134));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._toString13134));
		}
		internal static global::net.sf.jni4net.jni.MethodId _length13135;
		public virtual int length() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.nio.charset.CoderResult._length13135);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._length13135);
		}
		internal static global::net.sf.jni4net.jni.MethodId _throwException13136;
		public virtual void throwException() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.nio.charset.CoderResult._throwException13136);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._throwException13136);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isUnderflow13137;
		public virtual bool isUnderflow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.CoderResult._isUnderflow13137);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isUnderflow13137);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isError13138;
		public virtual bool isError() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.CoderResult._isError13138);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isError13138);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOverflow13139;
		public virtual bool isOverflow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.CoderResult._isOverflow13139);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isOverflow13139);
		}
		internal static global::net.sf.jni4net.jni.MethodId _malformedForLength13140;
		public static global::java.nio.charset.CoderResult malformedForLength(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._malformedForLength13140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMalformed13141;
		public virtual bool isMalformed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.CoderResult._isMalformed13141);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isMalformed13141);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isUnmappable13142;
		public virtual bool isUnmappable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.nio.charset.CoderResult._isUnmappable13142);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._isUnmappable13142);
		}
		internal static global::net.sf.jni4net.jni.MethodId _unmappableForLength13143;
		public static global::java.nio.charset.CoderResult unmappableForLength(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.charset.CoderResult.staticClass, global::java.nio.charset.CoderResult._unmappableForLength13143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.FieldId _UNDERFLOW13144;
		public static global::java.nio.charset.CoderResult UNDERFLOW
		{
			get
			{
				return default(global::java.nio.charset.CoderResult);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _OVERFLOW13145;
		public static global::java.nio.charset.CoderResult OVERFLOW
		{
			get
			{
				return default(global::java.nio.charset.CoderResult);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.charset.CoderResult.staticClass = @__class;
			global::java.nio.charset.CoderResult._toString13134 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "toString", "()Ljava/lang/String;");
			global::java.nio.charset.CoderResult._length13135 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "length", "()I");
			global::java.nio.charset.CoderResult._throwException13136 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "throwException", "()V");
			global::java.nio.charset.CoderResult._isUnderflow13137 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "isUnderflow", "()Z");
			global::java.nio.charset.CoderResult._isError13138 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "isError", "()Z");
			global::java.nio.charset.CoderResult._isOverflow13139 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "isOverflow", "()Z");
			global::java.nio.charset.CoderResult._malformedForLength13140 = @__env.GetStaticMethodID(global::java.nio.charset.CoderResult.staticClass, "malformedForLength", "(I)Ljava/nio/charset/CoderResult;");
			global::java.nio.charset.CoderResult._isMalformed13141 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "isMalformed", "()Z");
			global::java.nio.charset.CoderResult._isUnmappable13142 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "isUnmappable", "()Z");
			global::java.nio.charset.CoderResult._unmappableForLength13143 = @__env.GetStaticMethodID(global::java.nio.charset.CoderResult.staticClass, "unmappableForLength", "(I)Ljava/nio/charset/CoderResult;");
		}
	}
}
