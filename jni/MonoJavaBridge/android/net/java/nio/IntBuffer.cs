namespace java.nio 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class IntBuffer : java.nio.Buffer, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static IntBuffer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.IntBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected IntBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11244; 
		public abstract int get(); 
		internal static global::net.sf.jni4net.jni.MethodId _get11245; 
		public virtual java.nio.IntBuffer get(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallObjectMethodPtr(this, _get11245, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.IntBuffer.staticClass, _get11245, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11246; 
		public virtual java.nio.IntBuffer get(int[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallObjectMethodPtr(this, _get11246, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.IntBuffer.staticClass, _get11246, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11247; 
		public abstract int get(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put11248; 
		public virtual java.nio.IntBuffer put(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.IntBuffer.staticClass, _put11248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11249; 
		public abstract java.nio.IntBuffer put(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put11250; 
		public abstract java.nio.IntBuffer put(int arg0, int arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _put11251; 
		public virtual java.nio.IntBuffer put(int[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11251, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.IntBuffer.staticClass, _put11251, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11252; 
		public virtual java.nio.IntBuffer put(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11252, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.IntBuffer.staticClass, _put11252, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11253; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return @__env.CallIntMethod(this, _hashCode11253); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.IntBuffer.staticClass, _hashCode11253); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11254; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return @__env.CallBooleanMethod(this, _equals11254, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.IntBuffer.staticClass, _equals11254, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11255; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return @__env.CallIntMethod(this, _compareTo11255, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.IntBuffer.staticClass, _compareTo11255, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11256; 
		public virtual int compareTo(java.nio.IntBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return @__env.CallIntMethod(this, _compareTo11256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.IntBuffer.staticClass, _compareTo11256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11257; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.IntBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11257)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.IntBuffer.staticClass, _toString11257)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDirect11258; 
		public abstract bool isDirect(); 
		internal static global::net.sf.jni4net.jni.MethodId _wrap11259; 
		public static java.nio.IntBuffer wrap(int[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.IntBuffer.staticClass, _wrap11259, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wrap11260; 
		public static java.nio.IntBuffer wrap(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.IntBuffer.staticClass, _wrap11260, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allocate11261; 
		public static java.nio.IntBuffer allocate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.IntBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.IntBuffer.staticClass, _allocate11261, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _duplicate11262; 
		public abstract java.nio.IntBuffer duplicate(); 
		internal static global::net.sf.jni4net.jni.MethodId _slice11263; 
		public abstract java.nio.IntBuffer slice(); 
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer11264; 
		public abstract java.nio.IntBuffer asReadOnlyBuffer(); 
		internal static global::net.sf.jni4net.jni.MethodId _compact11265; 
		public abstract java.nio.IntBuffer compact(); 
		internal static global::net.sf.jni4net.jni.MethodId _order11266; 
		public abstract java.nio.ByteOrder order(); 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.IntBuffer.staticClass = @__class; 
			global::java.nio.IntBuffer._get11244 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "get", "()I"); 
			global::java.nio.IntBuffer._get11245 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "get", "([I)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._get11246 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "get", "([III)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._get11247 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "get", "(I)I"); 
			global::java.nio.IntBuffer._put11248 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "put", "(Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._put11249 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "put", "(I)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._put11250 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "put", "(II)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._put11251 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "put", "([III)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._put11252 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "put", "([I)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._hashCode11253 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "hashCode", "()I"); 
			global::java.nio.IntBuffer._equals11254 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.nio.IntBuffer._compareTo11255 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.nio.IntBuffer._compareTo11256 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "compareTo", "(Ljava/nio/IntBuffer;)I"); 
			global::java.nio.IntBuffer._toString11257 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.nio.IntBuffer._isDirect11258 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "isDirect", "()Z"); 
			global::java.nio.IntBuffer._wrap11259 = @__env.GetStaticMethodID(global::java.nio.IntBuffer.staticClass, "wrap", "([III)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._wrap11260 = @__env.GetStaticMethodID(global::java.nio.IntBuffer.staticClass, "wrap", "([I)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._allocate11261 = @__env.GetStaticMethodID(global::java.nio.IntBuffer.staticClass, "allocate", "(I)Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._duplicate11262 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "duplicate", "()Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._slice11263 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "slice", "()Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._asReadOnlyBuffer11264 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._compact11265 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "compact", "()Ljava/nio/IntBuffer;"); 
			global::java.nio.IntBuffer._order11266 = @__env.GetMethodID(global::java.nio.IntBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;"); 
		} 
	} 
} 
