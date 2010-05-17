namespace java.nio 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class FloatBuffer : java.nio.Buffer, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static FloatBuffer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.FloatBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected FloatBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11221; 
		public abstract float get(); 
		internal static global::net.sf.jni4net.jni.MethodId _get11222; 
		public virtual java.nio.FloatBuffer get(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.FloatBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallObjectMethodPtr(this, _get11222, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.FloatBuffer.staticClass, _get11222, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11223; 
		public virtual java.nio.FloatBuffer get(float[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.FloatBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallObjectMethodPtr(this, _get11223, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.FloatBuffer.staticClass, _get11223, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11224; 
		public abstract float get(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put11225; 
		public virtual java.nio.FloatBuffer put(java.nio.FloatBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.FloatBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.FloatBuffer.staticClass, _put11225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11226; 
		public abstract java.nio.FloatBuffer put(float arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put11227; 
		public abstract java.nio.FloatBuffer put(int arg0, float arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _put11228; 
		public virtual java.nio.FloatBuffer put(float[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.FloatBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11228, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.FloatBuffer.staticClass, _put11228, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11229; 
		public virtual java.nio.FloatBuffer put(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.FloatBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11229, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.FloatBuffer.staticClass, _put11229, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11230; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.FloatBuffer)) 
				return @__env.CallIntMethod(this, _hashCode11230); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.FloatBuffer.staticClass, _hashCode11230); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11231; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.FloatBuffer)) 
				return @__env.CallBooleanMethod(this, _equals11231, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.FloatBuffer.staticClass, _equals11231, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11232; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.FloatBuffer)) 
				return @__env.CallIntMethod(this, _compareTo11232, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.FloatBuffer.staticClass, _compareTo11232, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11233; 
		public virtual int compareTo(java.nio.FloatBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.FloatBuffer)) 
				return @__env.CallIntMethod(this, _compareTo11233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.FloatBuffer.staticClass, _compareTo11233, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11234; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.FloatBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11234)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.FloatBuffer.staticClass, _toString11234)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDirect11235; 
		public abstract bool isDirect(); 
		internal static global::net.sf.jni4net.jni.MethodId _wrap11236; 
		public static java.nio.FloatBuffer wrap(float[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.FloatBuffer.staticClass, _wrap11236, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wrap11237; 
		public static java.nio.FloatBuffer wrap(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.FloatBuffer.staticClass, _wrap11237, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allocate11238; 
		public static java.nio.FloatBuffer allocate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.FloatBuffer.staticClass, _allocate11238, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _duplicate11239; 
		public abstract java.nio.FloatBuffer duplicate(); 
		internal static global::net.sf.jni4net.jni.MethodId _slice11240; 
		public abstract java.nio.FloatBuffer slice(); 
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer11241; 
		public abstract java.nio.FloatBuffer asReadOnlyBuffer(); 
		internal static global::net.sf.jni4net.jni.MethodId _compact11242; 
		public abstract java.nio.FloatBuffer compact(); 
		internal static global::net.sf.jni4net.jni.MethodId _order11243; 
		public abstract java.nio.ByteOrder order(); 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.FloatBuffer.staticClass = @__class; 
			global::java.nio.FloatBuffer._get11221 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "get", "()F"); 
			global::java.nio.FloatBuffer._get11222 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "get", "([F)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._get11223 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "get", "([FII)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._get11224 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "get", "(I)F"); 
			global::java.nio.FloatBuffer._put11225 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "put", "(Ljava/nio/FloatBuffer;)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._put11226 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "put", "(F)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._put11227 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "put", "(IF)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._put11228 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "put", "([FII)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._put11229 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "put", "([F)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._hashCode11230 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "hashCode", "()I"); 
			global::java.nio.FloatBuffer._equals11231 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.nio.FloatBuffer._compareTo11232 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.nio.FloatBuffer._compareTo11233 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/nio/FloatBuffer;)I"); 
			global::java.nio.FloatBuffer._toString11234 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.nio.FloatBuffer._isDirect11235 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "isDirect", "()Z"); 
			global::java.nio.FloatBuffer._wrap11236 = @__env.GetStaticMethodID(global::java.nio.FloatBuffer.staticClass, "wrap", "([FII)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._wrap11237 = @__env.GetStaticMethodID(global::java.nio.FloatBuffer.staticClass, "wrap", "([F)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._allocate11238 = @__env.GetStaticMethodID(global::java.nio.FloatBuffer.staticClass, "allocate", "(I)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._duplicate11239 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "duplicate", "()Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._slice11240 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "slice", "()Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._asReadOnlyBuffer11241 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._compact11242 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "compact", "()Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._order11243 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;"); 
		} 
	} 
} 
