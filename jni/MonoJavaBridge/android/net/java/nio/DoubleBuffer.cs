namespace java.nio 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class DoubleBuffer : java.nio.Buffer, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static DoubleBuffer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.DoubleBuffer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected DoubleBuffer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11198; 
		public abstract double get(); 
		internal static global::net.sf.jni4net.jni.MethodId _get11199; 
		public virtual java.nio.DoubleBuffer get(double[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallObjectMethodPtr(this, _get11199, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.DoubleBuffer.staticClass, _get11199, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11200; 
		public virtual java.nio.DoubleBuffer get(double[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallObjectMethodPtr(this, _get11200, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.DoubleBuffer.staticClass, _get11200, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get11201; 
		public abstract double get(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put11202; 
		public virtual java.nio.DoubleBuffer put(java.nio.DoubleBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.DoubleBuffer.staticClass, _put11202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11203; 
		public abstract java.nio.DoubleBuffer put(double arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put11204; 
		public abstract java.nio.DoubleBuffer put(int arg0, double arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _put11205; 
		public virtual java.nio.DoubleBuffer put(double[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11205, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.DoubleBuffer.staticClass, _put11205, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put11206; 
		public virtual java.nio.DoubleBuffer put(double[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put11206, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.DoubleBuffer.staticClass, _put11206, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11207; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return @__env.CallIntMethod(this, _hashCode11207); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.DoubleBuffer.staticClass, _hashCode11207); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11208; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return @__env.CallBooleanMethod(this, _equals11208, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.DoubleBuffer.staticClass, _equals11208, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11209; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return @__env.CallIntMethod(this, _compareTo11209, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.DoubleBuffer.staticClass, _compareTo11209, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11210; 
		public virtual int compareTo(java.nio.DoubleBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return @__env.CallIntMethod(this, _compareTo11210, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.DoubleBuffer.staticClass, _compareTo11210, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11211; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11211)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.DoubleBuffer.staticClass, _toString11211)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDirect11212; 
		public abstract bool isDirect(); 
		internal static global::net.sf.jni4net.jni.MethodId _wrap11213; 
		public static java.nio.DoubleBuffer wrap(double[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.DoubleBuffer.staticClass, _wrap11213, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wrap11214; 
		public static java.nio.DoubleBuffer wrap(double[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.DoubleBuffer.staticClass, _wrap11214, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allocate11215; 
		public static java.nio.DoubleBuffer allocate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.DoubleBuffer.staticClass, _allocate11215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _duplicate11216; 
		public abstract java.nio.DoubleBuffer duplicate(); 
		internal static global::net.sf.jni4net.jni.MethodId _slice11217; 
		public abstract java.nio.DoubleBuffer slice(); 
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer11218; 
		public abstract java.nio.DoubleBuffer asReadOnlyBuffer(); 
		internal static global::net.sf.jni4net.jni.MethodId _compact11219; 
		public abstract java.nio.DoubleBuffer compact(); 
		internal static global::net.sf.jni4net.jni.MethodId _order11220; 
		public abstract java.nio.ByteOrder order(); 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.DoubleBuffer.staticClass = @__class; 
			global::java.nio.DoubleBuffer._get11198 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "get", "()D"); 
			global::java.nio.DoubleBuffer._get11199 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "get", "([D)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._get11200 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "get", "([DII)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._get11201 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "get", "(I)D"); 
			global::java.nio.DoubleBuffer._put11202 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "put", "(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._put11203 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "put", "(D)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._put11204 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "put", "(ID)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._put11205 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "put", "([DII)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._put11206 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "put", "([D)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._hashCode11207 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "hashCode", "()I"); 
			global::java.nio.DoubleBuffer._equals11208 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.nio.DoubleBuffer._compareTo11209 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.nio.DoubleBuffer._compareTo11210 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/nio/DoubleBuffer;)I"); 
			global::java.nio.DoubleBuffer._toString11211 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.nio.DoubleBuffer._isDirect11212 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "isDirect", "()Z"); 
			global::java.nio.DoubleBuffer._wrap11213 = @__env.GetStaticMethodID(global::java.nio.DoubleBuffer.staticClass, "wrap", "([DII)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._wrap11214 = @__env.GetStaticMethodID(global::java.nio.DoubleBuffer.staticClass, "wrap", "([D)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._allocate11215 = @__env.GetStaticMethodID(global::java.nio.DoubleBuffer.staticClass, "allocate", "(I)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._duplicate11216 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "duplicate", "()Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._slice11217 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "slice", "()Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._asReadOnlyBuffer11218 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._compact11219 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "compact", "()Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._order11220 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;"); 
		} 
	} 
} 
