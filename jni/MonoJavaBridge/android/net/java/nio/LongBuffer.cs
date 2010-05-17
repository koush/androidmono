namespace java.nio 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class LongBuffer : java.nio.Buffer, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static LongBuffer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.LongBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected LongBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11267; 
		public abstract long get(); 
		internal static global::net.sf.jni4net.jni.MethodId _get11268; 
		public virtual java.nio.LongBuffer get(long[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.LongBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallObjectMethodPtr(this, _get11268, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.LongBuffer.staticClass, _get11268, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11269; 
		public virtual java.nio.LongBuffer get(long[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.LongBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallObjectMethodPtr(this, _get11269, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.LongBuffer.staticClass, _get11269, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11270; 
		public abstract long get(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put11271; 
		public virtual java.nio.LongBuffer put(java.nio.LongBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.LongBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.LongBuffer.staticClass, _put11271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11272; 
		public abstract java.nio.LongBuffer put(long arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put11273; 
		public abstract java.nio.LongBuffer put(int arg0, long arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _put11274; 
		public virtual java.nio.LongBuffer put(long[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.LongBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11274, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.LongBuffer.staticClass, _put11274, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11275; 
		public virtual java.nio.LongBuffer put(long[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.LongBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11275, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.LongBuffer.staticClass, _put11275, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11276; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.LongBuffer)) 
				return @__env.CallIntMethod(this, _hashCode11276); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.LongBuffer.staticClass, _hashCode11276); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11277; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.LongBuffer)) 
				return @__env.CallBooleanMethod(this, _equals11277, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.LongBuffer.staticClass, _equals11277, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11278; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.LongBuffer)) 
				return @__env.CallIntMethod(this, _compareTo11278, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.LongBuffer.staticClass, _compareTo11278, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11279; 
		public virtual int compareTo(java.nio.LongBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.LongBuffer)) 
				return @__env.CallIntMethod(this, _compareTo11279, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.LongBuffer.staticClass, _compareTo11279, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11280; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.LongBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11280)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.LongBuffer.staticClass, _toString11280)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDirect11281; 
		public abstract bool isDirect(); 
		internal static global::net.sf.jni4net.jni.MethodId _wrap11282; 
		public static java.nio.LongBuffer wrap(long[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.LongBuffer.staticClass, _wrap11282, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wrap11283; 
		public static java.nio.LongBuffer wrap(long[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.LongBuffer.staticClass, _wrap11283, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allocate11284; 
		public static java.nio.LongBuffer allocate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.LongBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.LongBuffer.staticClass, _allocate11284, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _duplicate11285; 
		public abstract java.nio.LongBuffer duplicate(); 
		internal static global::net.sf.jni4net.jni.MethodId _slice11286; 
		public abstract java.nio.LongBuffer slice(); 
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer11287; 
		public abstract java.nio.LongBuffer asReadOnlyBuffer(); 
		internal static global::net.sf.jni4net.jni.MethodId _compact11288; 
		public abstract java.nio.LongBuffer compact(); 
		internal static global::net.sf.jni4net.jni.MethodId _order11289; 
		public abstract java.nio.ByteOrder order(); 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.LongBuffer.staticClass = @__class; 
			global::java.nio.LongBuffer._get11267 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "get", "()J"); 
			global::java.nio.LongBuffer._get11268 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "get", "([J)Ljava/nio/LongBuffer;"); 
			global::java.nio.LongBuffer._get11269 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "get", "([JII)Ljava/nio/LongBuffer;"); 
			global::java.nio.LongBuffer._get11270 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "get", "(I)J"); 
			global::java.nio.LongBuffer._put11271 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "put", "(Ljava/nio/LongBuffer;)Ljava/nio/LongBuffer;"); 
			global::java.nio.LongBuffer._put11272 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "put", "(J)Ljava/nio/LongBuffer;"); 
			global::java.nio.LongBuffer._put11273 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "put", "(IJ)Ljava/nio/LongBuffer;"); 
			global::java.nio.LongBuffer._put11274 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "put", "([JII)Ljava/nio/LongBuffer;"); 
			global::java.nio.LongBuffer._put11275 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "put", "([J)Ljava/nio/LongBuffer;"); 
			global::java.nio.LongBuffer._hashCode11276 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "hashCode", "()I"); 
			global::java.nio.LongBuffer._equals11277 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.nio.LongBuffer._compareTo11278 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.nio.LongBuffer._compareTo11279 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "compareTo", "(Ljava/nio/LongBuffer;)I"); 
			global::java.nio.LongBuffer._toString11280 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.nio.LongBuffer._isDirect11281 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "isDirect", "()Z"); 
			global::java.nio.LongBuffer._wrap11282 = @__env.GetStaticMethodID(global::java.nio.LongBuffer.staticClass, "wrap", "([JII)Ljava/nio/LongBuffer;"); 
			global::java.nio.LongBuffer._wrap11283 = @__env.GetStaticMethodID(global::java.nio.LongBuffer.staticClass, "wrap", "([J)Ljava/nio/LongBuffer;"); 
			global::java.nio.LongBuffer._allocate11284 = @__env.GetStaticMethodID(global::java.nio.LongBuffer.staticClass, "allocate", "(I)Ljava/nio/LongBuffer;"); 
			global::java.nio.LongBuffer._duplicate11285 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "duplicate", "()Ljava/nio/LongBuffer;"); 
			global::java.nio.LongBuffer._slice11286 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "slice", "()Ljava/nio/LongBuffer;"); 
			global::java.nio.LongBuffer._asReadOnlyBuffer11287 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/LongBuffer;"); 
			global::java.nio.LongBuffer._compact11288 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "compact", "()Ljava/nio/LongBuffer;"); 
			global::java.nio.LongBuffer._order11289 = @__env.GetMethodID(global::java.nio.LongBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;"); 
		} 
	} 
} 
