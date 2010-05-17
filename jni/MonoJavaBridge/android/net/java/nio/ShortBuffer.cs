namespace java.nio 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class ShortBuffer : java.nio.Buffer, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static ShortBuffer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.ShortBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected ShortBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11293; 
		public abstract short get(); 
		internal static global::net.sf.jni4net.jni.MethodId _get11294; 
		public virtual java.nio.ShortBuffer get(short[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.ShortBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallObjectMethodPtr(this, _get11294, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.ShortBuffer.staticClass, _get11294, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11295; 
		public virtual java.nio.ShortBuffer get(short[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.ShortBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallObjectMethodPtr(this, _get11295, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.ShortBuffer.staticClass, _get11295, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11296; 
		public abstract short get(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put11297; 
		public virtual java.nio.ShortBuffer put(java.nio.ShortBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.ShortBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11297, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.ShortBuffer.staticClass, _put11297, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11298; 
		public abstract java.nio.ShortBuffer put(short arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put11299; 
		public abstract java.nio.ShortBuffer put(int arg0, short arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _put11300; 
		public virtual java.nio.ShortBuffer put(short[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.ShortBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11300, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.ShortBuffer.staticClass, _put11300, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11301; 
		public virtual java.nio.ShortBuffer put(short[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.ShortBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11301, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.ShortBuffer.staticClass, _put11301, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11302; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.ShortBuffer)) 
				return @__env.CallIntMethod(this, _hashCode11302); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.ShortBuffer.staticClass, _hashCode11302); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11303; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.ShortBuffer)) 
				return @__env.CallBooleanMethod(this, _equals11303, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.ShortBuffer.staticClass, _equals11303, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11304; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.ShortBuffer)) 
				return @__env.CallIntMethod(this, _compareTo11304, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.ShortBuffer.staticClass, _compareTo11304, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11305; 
		public virtual int compareTo(java.nio.ShortBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.ShortBuffer)) 
				return @__env.CallIntMethod(this, _compareTo11305, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.ShortBuffer.staticClass, _compareTo11305, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11306; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.ShortBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11306)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.ShortBuffer.staticClass, _toString11306)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDirect11307; 
		public abstract bool isDirect(); 
		internal static global::net.sf.jni4net.jni.MethodId _wrap11308; 
		public static java.nio.ShortBuffer wrap(short[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.ShortBuffer.staticClass, _wrap11308, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wrap11309; 
		public static java.nio.ShortBuffer wrap(short[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.ShortBuffer.staticClass, _wrap11309, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allocate11310; 
		public static java.nio.ShortBuffer allocate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.ShortBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.ShortBuffer.staticClass, _allocate11310, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _duplicate11311; 
		public abstract java.nio.ShortBuffer duplicate(); 
		internal static global::net.sf.jni4net.jni.MethodId _slice11312; 
		public abstract java.nio.ShortBuffer slice(); 
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer11313; 
		public abstract java.nio.ShortBuffer asReadOnlyBuffer(); 
		internal static global::net.sf.jni4net.jni.MethodId _compact11314; 
		public abstract java.nio.ShortBuffer compact(); 
		internal static global::net.sf.jni4net.jni.MethodId _order11315; 
		public abstract java.nio.ByteOrder order(); 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.ShortBuffer.staticClass = @__class; 
			global::java.nio.ShortBuffer._get11293 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "get", "()S"); 
			global::java.nio.ShortBuffer._get11294 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "get", "([S)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._get11295 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "get", "([SII)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._get11296 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "get", "(I)S"); 
			global::java.nio.ShortBuffer._put11297 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "put", "(Ljava/nio/ShortBuffer;)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._put11298 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "put", "(S)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._put11299 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "put", "(IS)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._put11300 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "put", "([SII)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._put11301 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "put", "([S)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._hashCode11302 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "hashCode", "()I"); 
			global::java.nio.ShortBuffer._equals11303 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.nio.ShortBuffer._compareTo11304 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.nio.ShortBuffer._compareTo11305 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "compareTo", "(Ljava/nio/ShortBuffer;)I"); 
			global::java.nio.ShortBuffer._toString11306 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.nio.ShortBuffer._isDirect11307 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "isDirect", "()Z"); 
			global::java.nio.ShortBuffer._wrap11308 = @__env.GetStaticMethodID(global::java.nio.ShortBuffer.staticClass, "wrap", "([SII)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._wrap11309 = @__env.GetStaticMethodID(global::java.nio.ShortBuffer.staticClass, "wrap", "([S)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._allocate11310 = @__env.GetStaticMethodID(global::java.nio.ShortBuffer.staticClass, "allocate", "(I)Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._duplicate11311 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "duplicate", "()Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._slice11312 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "slice", "()Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._asReadOnlyBuffer11313 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._compact11314 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "compact", "()Ljava/nio/ShortBuffer;"); 
			global::java.nio.ShortBuffer._order11315 = @__env.GetMethodID(global::java.nio.ShortBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;"); 
		} 
	} 
} 
