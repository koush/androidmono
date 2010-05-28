namespace java.nio 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class IntBuffer : java.nio.Buffer, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static IntBuffer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.IntBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected IntBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get12076; 
		public abstract int get(); 
		internal static global::net.sf.jni4net.jni.MethodId _get12077; 
		public virtual global::java.nio.IntBuffer get(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.IntBuffer._get12077, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._get12077, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get12078; 
		public virtual global::java.nio.IntBuffer get(int[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.IntBuffer._get12078, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._get12078, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get12079; 
		public abstract int get(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put12080; 
		public virtual global::java.nio.IntBuffer put(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.IntBuffer._put12080, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put12080, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put12081; 
		public abstract global::java.nio.IntBuffer put(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put12082; 
		public abstract global::java.nio.IntBuffer put(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _put12083; 
		public virtual global::java.nio.IntBuffer put(int[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.IntBuffer._put12083, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put12083, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put12084; 
		public virtual global::java.nio.IntBuffer put(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.IntBuffer._put12084, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._put12084, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12085; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return @__env.CallIntMethod(this, global::java.nio.IntBuffer._hashCode12085); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._hashCode12085); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12086; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return @__env.CallBooleanMethod(this, global::java.nio.IntBuffer._equals12086, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._equals12086, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12087; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return @__env.CallIntMethod(this, global::java.nio.IntBuffer._compareTo12087, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._compareTo12087, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12088; 
		public virtual int compareTo(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return @__env.CallIntMethod(this, global::java.nio.IntBuffer._compareTo12088, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._compareTo12088, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12089; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.IntBuffer._toString12089)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._toString12089)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDirect12090; 
		public abstract bool isDirect(); 
		internal static global::net.sf.jni4net.jni.MethodId _wrap12091; 
		public static global::java.nio.IntBuffer wrap(int[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._wrap12091, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wrap12092; 
		public static global::java.nio.IntBuffer wrap(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._wrap12092, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allocate12093; 
		public static global::java.nio.IntBuffer allocate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.IntBuffer.staticClass, global::java.nio.IntBuffer._allocate12093, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _duplicate12094; 
		public abstract global::java.nio.IntBuffer duplicate(); 
		internal static global::net.sf.jni4net.jni.MethodId _slice12095; 
		public abstract global::java.nio.IntBuffer slice(); 
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer12096; 
		public abstract global::java.nio.IntBuffer asReadOnlyBuffer(); 
		internal static global::net.sf.jni4net.jni.MethodId _compact12097; 
		public abstract global::java.nio.IntBuffer compact(); 
		internal static global::net.sf.jni4net.jni.MethodId _order12098; 
		public abstract global::java.nio.ByteOrder order(); 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.IntBuffer.staticClass = @__class; 
			global::java.nio.IntBuffer._get12076 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "get", "()I"); 
			global::java.nio.IntBuffer._get12077 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "get", "([I)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._get12078 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "get", "([III)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._get12079 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "get", "(I)I"); 
			global::java.nio.IntBuffer._put12080 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "put", "(Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._put12081 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "put", "(I)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._put12082 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "put", "(II)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._put12083 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "put", "([III)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._put12084 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "put", "([I)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._hashCode12085 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "hashCode", "()I"); 
			global::java.nio.IntBuffer._equals12086 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.nio.IntBuffer._compareTo12087 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.nio.IntBuffer._compareTo12088 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/nio/IntBuffer;)I"); 
			global::java.nio.IntBuffer._toString12089 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.nio.IntBuffer._isDirect12090 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "isDirect", "()Z"); 
			global::java.nio.IntBuffer._wrap12091 = @__env.GetStaticMethodID(global::java.nio.IntBuffer.staticClass, "wrap", "([III)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._wrap12092 = @__env.GetStaticMethodID(global::java.nio.IntBuffer.staticClass, "wrap", "([I)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._allocate12093 = @__env.GetStaticMethodID(global::java.nio.IntBuffer.staticClass, "allocate", "(I)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._duplicate12094 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "duplicate", "()Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._slice12095 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "slice", "()Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._asReadOnlyBuffer12096 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._compact12097 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "compact", "()Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._order12098 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;"); 
		} 
	} 
} 
