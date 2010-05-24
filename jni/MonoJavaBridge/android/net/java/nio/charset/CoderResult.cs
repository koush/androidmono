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
		internal static global::net.sf.jni4net.jni.MethodId _toString12405; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString12405)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.charset.CoderResult.staticClass, _toString12405)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length12406; 
		public virtual int length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				return @__env.CallIntMethod(this, _length12406); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.charset.CoderResult.staticClass, _length12406); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _throwException12407; 
		public virtual void throwException() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				@__env.CallVoidMethod(this, _throwException12407); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.nio.charset.CoderResult.staticClass, _throwException12407); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isUnderflow12408; 
		public virtual bool isUnderflow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				return @__env.CallBooleanMethod(this, _isUnderflow12408); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.CoderResult.staticClass, _isUnderflow12408); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOverflow12409; 
		public virtual bool isOverflow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				return @__env.CallBooleanMethod(this, _isOverflow12409); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.CoderResult.staticClass, _isOverflow12409); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unmappableForLength12410; 
		public static java.nio.charset.CoderResult unmappableForLength(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.charset.CoderResult.staticClass, _unmappableForLength12410, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isError12411; 
		public virtual bool isError() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				return @__env.CallBooleanMethod(this, _isError12411); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.CoderResult.staticClass, _isError12411); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _malformedForLength12412; 
		public static java.nio.charset.CoderResult malformedForLength(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.charset.CoderResult>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.charset.CoderResult.staticClass, _malformedForLength12412, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMalformed12413; 
		public virtual bool isMalformed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				return @__env.CallBooleanMethod(this, _isMalformed12413); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.CoderResult.staticClass, _isMalformed12413); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isUnmappable12414; 
		public virtual bool isUnmappable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.charset.CoderResult)) 
				return @__env.CallBooleanMethod(this, _isUnmappable12414); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.charset.CoderResult.staticClass, _isUnmappable12414); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _UNDERFLOW12415; 
		public static java.nio.charset.CoderResult UNDERFLOW
		{ 
			get 
			{ 
				return default(java.nio.charset.CoderResult); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _OVERFLOW12416; 
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
			global::java.nio.charset.CoderResult._toString12405 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.nio.charset.CoderResult._length12406 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "length", "()I"); 
			global::java.nio.charset.CoderResult._throwException12407 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "throwException", "()V"); 
			global::java.nio.charset.CoderResult._isUnderflow12408 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "isUnderflow", "()Z"); 
			global::java.nio.charset.CoderResult._isOverflow12409 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "isOverflow", "()Z"); 
			global::java.nio.charset.CoderResult._unmappableForLength12410 = @__env.GetStaticMethodID(global::java.nio.charset.CoderResult.staticClass, "unmappableForLength", "(I)Ljava/nio/charset/CoderResult;"); 
			global::java.nio.charset.CoderResult._isError12411 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "isError", "()Z"); 
			global::java.nio.charset.CoderResult._malformedForLength12412 = @__env.GetStaticMethodID(global::java.nio.charset.CoderResult.staticClass, "malformedForLength", "(I)Ljava/nio/charset/CoderResult;"); 
			global::java.nio.charset.CoderResult._isMalformed12413 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "isMalformed", "()Z"); 
			global::java.nio.charset.CoderResult._isUnmappable12414 = @__env.GetMethodID(global::java.nio.charset.CoderResult.staticClass, "isUnmappable", "()Z"); 
		} 
	} 
} 
