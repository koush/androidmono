namespace java.nio.charset 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class CoderResult : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static CoderResult() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.charset.CoderResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString11541; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11541)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CoderResult.staticClass, _toString11541)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length11542; 
		public virtual int length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				return @__env.CallIntMethod(this, _length11542); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.charset.CoderResult.staticClass, _length11542); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _throwException11543; 
		public virtual void throwException() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				@__env.CallVoidMethod(this, _throwException11543); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.charset.CoderResult.staticClass, _throwException11543); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isUnderflow11544; 
		public virtual bool isUnderflow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				return @__env.CallBooleanMethod(this, _isUnderflow11544); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.CoderResult.staticClass, _isUnderflow11544); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOverflow11545; 
		public virtual bool isOverflow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				return @__env.CallBooleanMethod(this, _isOverflow11545); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.CoderResult.staticClass, _isOverflow11545); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unmappableForLength11546; 
		public static java.nio.charset.CoderResult unmappableForLength(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.charset.CoderResult.staticClass, _unmappableForLength11546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isError11547; 
		public virtual bool isError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				return @__env.CallBooleanMethod(this, _isError11547); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.CoderResult.staticClass, _isError11547); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _malformedForLength11548; 
		public static java.nio.charset.CoderResult malformedForLength(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.charset.CoderResult.staticClass, _malformedForLength11548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMalformed11549; 
		public virtual bool isMalformed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				return @__env.CallBooleanMethod(this, _isMalformed11549); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.CoderResult.staticClass, _isMalformed11549); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isUnmappable11550; 
		public virtual bool isUnmappable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				return @__env.CallBooleanMethod(this, _isUnmappable11550); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.CoderResult.staticClass, _isUnmappable11550); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _UNDERFLOW11551; 
		public static java.nio.charset.CoderResult UNDERFLOW
		{ 
			get 
			{ 
				return default(java.nio.charset.CoderResult); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _OVERFLOW11552; 
		public static java.nio.charset.CoderResult OVERFLOW
		{ 
			get 
			{ 
				return default(java.nio.charset.CoderResult); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.charset.CoderResult.staticClass = @__class; 
			global::java.nio.charset.CoderResult._toString11541 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.nio.charset.CoderResult._length11542 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "length", "()I"); 
			global::java.nio.charset.CoderResult._throwException11543 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "throwException", "()V"); 
			global::java.nio.charset.CoderResult._isUnderflow11544 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "isUnderflow", "()Z"); 
			global::java.nio.charset.CoderResult._isOverflow11545 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "isOverflow", "()Z"); 
			global::java.nio.charset.CoderResult._unmappableForLength11546 = @__env.GetStaticMethodID(global::java.nio.charset.CoderResult.staticClass, "unmappableForLength", "(I)Ljava/nio/charset/CoderResult;"); 
			global::java.nio.charset.CoderResult._isError11547 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "isError", "()Z"); 
			global::java.nio.charset.CoderResult._malformedForLength11548 = @__env.GetStaticMethodID(global::java.nio.charset.CoderResult.staticClass, "malformedForLength", "(I)Ljava/nio/charset/CoderResult;"); 
			global::java.nio.charset.CoderResult._isMalformed11549 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "isMalformed", "()Z"); 
			global::java.nio.charset.CoderResult._isUnmappable11550 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "isUnmappable", "()Z"); 
		} 
	} 
} 
