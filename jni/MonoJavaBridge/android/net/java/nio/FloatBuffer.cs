namespace java.nio 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class FloatBuffer : java.nio.Buffer, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static FloatBuffer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.FloatBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected FloatBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get12053; 
		public abstract float get(); 
		internal static global::net.sf.jni4net.jni.MethodId _get12054; 
		public virtual global::java.nio.FloatBuffer get(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.FloatBuffer._get12054, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._get12054, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get12055; 
		public virtual global::java.nio.FloatBuffer get(float[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.FloatBuffer._get12055, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._get12055, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get12056; 
		public abstract float get(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put12057; 
		public virtual global::java.nio.FloatBuffer put(java.nio.FloatBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.FloatBuffer._put12057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put12057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put12058; 
		public abstract global::java.nio.FloatBuffer put(float arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put12059; 
		public abstract global::java.nio.FloatBuffer put(int arg0, float arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _put12060; 
		public virtual global::java.nio.FloatBuffer put(float[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.FloatBuffer._put12060, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put12060, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put12061; 
		public virtual global::java.nio.FloatBuffer put(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.FloatBuffer._put12061, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._put12061, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12062; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.nio.FloatBuffer._hashCode12062); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._hashCode12062); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12063; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.nio.FloatBuffer._equals12063, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._equals12063, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12064; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.nio.FloatBuffer._compareTo12064, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._compareTo12064, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12065; 
		public virtual int compareTo(java.nio.FloatBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.nio.FloatBuffer._compareTo12065, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._compareTo12065, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12066; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.FloatBuffer._toString12066)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._toString12066)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDirect12067; 
		public abstract bool isDirect(); 
		internal static global::net.sf.jni4net.jni.MethodId _wrap12068; 
		public static global::java.nio.FloatBuffer wrap(float[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._wrap12068, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wrap12069; 
		public static global::java.nio.FloatBuffer wrap(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._wrap12069, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allocate12070; 
		public static global::java.nio.FloatBuffer allocate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.FloatBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.FloatBuffer.staticClass, global::java.nio.FloatBuffer._allocate12070, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _duplicate12071; 
		public abstract global::java.nio.FloatBuffer duplicate(); 
		internal static global::net.sf.jni4net.jni.MethodId _slice12072; 
		public abstract global::java.nio.FloatBuffer slice(); 
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer12073; 
		public abstract global::java.nio.FloatBuffer asReadOnlyBuffer(); 
		internal static global::net.sf.jni4net.jni.MethodId _compact12074; 
		public abstract global::java.nio.FloatBuffer compact(); 
		internal static global::net.sf.jni4net.jni.MethodId _order12075; 
		public abstract global::java.nio.ByteOrder order(); 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.FloatBuffer.staticClass = @__class; 
			global::java.nio.FloatBuffer._get12053 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "get", "()F"); 
			global::java.nio.FloatBuffer._get12054 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "get", "([F)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._get12055 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "get", "([FII)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._get12056 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "get", "(I)F"); 
			global::java.nio.FloatBuffer._put12057 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "put", "(Ljava/nio/FloatBuffer;)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._put12058 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "put", "(F)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._put12059 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "put", "(IF)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._put12060 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "put", "([FII)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._put12061 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "put", "([F)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._hashCode12062 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "hashCode", "()I"); 
			global::java.nio.FloatBuffer._equals12063 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.nio.FloatBuffer._compareTo12064 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.nio.FloatBuffer._compareTo12065 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "compareTo", "(Ljava/nio/FloatBuffer;)I"); 
			global::java.nio.FloatBuffer._toString12066 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.nio.FloatBuffer._isDirect12067 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "isDirect", "()Z"); 
			global::java.nio.FloatBuffer._wrap12068 = @__env.GetStaticMethodID(global::java.nio.FloatBuffer.staticClass, "wrap", "([FII)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._wrap12069 = @__env.GetStaticMethodID(global::java.nio.FloatBuffer.staticClass, "wrap", "([F)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._allocate12070 = @__env.GetStaticMethodID(global::java.nio.FloatBuffer.staticClass, "allocate", "(I)Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._duplicate12071 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "duplicate", "()Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._slice12072 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "slice", "()Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._asReadOnlyBuffer12073 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._compact12074 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "compact", "()Ljava/nio/FloatBuffer;"); 
			global::java.nio.FloatBuffer._order12075 = @__env.GetMethodID(global::java.nio.FloatBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;"); 
		} 
	} 
} 
