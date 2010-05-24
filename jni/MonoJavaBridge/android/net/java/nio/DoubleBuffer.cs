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
		internal static global::net.sf.jni4net.jni.MethodId _get12030; 
		public abstract double get(); 
		internal static global::net.sf.jni4net.jni.MethodId _get12031; 
		public virtual java.nio.DoubleBuffer get(double[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallObjectMethodPtr(this, _get12031, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.DoubleBuffer.staticClass, _get12031, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get12032; 
		public virtual java.nio.DoubleBuffer get(double[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallObjectMethodPtr(this, _get12032, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.DoubleBuffer.staticClass, _get12032, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get12033; 
		public abstract double get(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put12034; 
		public virtual java.nio.DoubleBuffer put(java.nio.DoubleBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put12034, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.DoubleBuffer.staticClass, _put12034, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put12035; 
		public abstract java.nio.DoubleBuffer put(double arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _put12036; 
		public abstract java.nio.DoubleBuffer put(int arg0, double arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _put12037; 
		public virtual java.nio.DoubleBuffer put(double[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put12037, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.DoubleBuffer.staticClass, _put12037, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _put12038; 
		public virtual java.nio.DoubleBuffer put(double[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallObjectMethodPtr(this, _put12038, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.DoubleBuffer.staticClass, _put12038, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12039; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return @__env.CallIntMethod(this, _hashCode12039); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.DoubleBuffer.staticClass, _hashCode12039); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12040; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return @__env.CallBooleanMethod(this, _equals12040, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.nio.DoubleBuffer.staticClass, _equals12040, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12041; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return @__env.CallIntMethod(this, _compareTo12041, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.DoubleBuffer.staticClass, _compareTo12041, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12042; 
		public virtual int compareTo(java.nio.DoubleBuffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return @__env.CallIntMethod(this, _compareTo12042, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.nio.DoubleBuffer.staticClass, _compareTo12042, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12043; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.DoubleBuffer)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString12043)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.DoubleBuffer.staticClass, _toString12043)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDirect12044; 
		public abstract bool isDirect(); 
		internal static global::net.sf.jni4net.jni.MethodId _wrap12045; 
		public static java.nio.DoubleBuffer wrap(double[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.DoubleBuffer.staticClass, _wrap12045, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wrap12046; 
		public static java.nio.DoubleBuffer wrap(double[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.DoubleBuffer.staticClass, _wrap12046, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allocate12047; 
		public static java.nio.DoubleBuffer allocate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.DoubleBuffer>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.DoubleBuffer.staticClass, _allocate12047, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _duplicate12048; 
		public abstract java.nio.DoubleBuffer duplicate(); 
		internal static global::net.sf.jni4net.jni.MethodId _slice12049; 
		public abstract java.nio.DoubleBuffer slice(); 
		internal static global::net.sf.jni4net.jni.MethodId _asReadOnlyBuffer12050; 
		public abstract java.nio.DoubleBuffer asReadOnlyBuffer(); 
		internal static global::net.sf.jni4net.jni.MethodId _compact12051; 
		public abstract java.nio.DoubleBuffer compact(); 
		internal static global::net.sf.jni4net.jni.MethodId _order12052; 
		public abstract java.nio.ByteOrder order(); 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.DoubleBuffer.staticClass = @__class; 
			global::java.nio.DoubleBuffer._get12030 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "get", "()D"); 
			global::java.nio.DoubleBuffer._get12031 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "get", "([D)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._get12032 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "get", "([DII)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._get12033 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "get", "(I)D"); 
			global::java.nio.DoubleBuffer._put12034 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "put", "(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._put12035 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "put", "(D)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._put12036 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "put", "(ID)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._put12037 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "put", "([DII)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._put12038 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "put", "([D)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._hashCode12039 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "hashCode", "()I"); 
			global::java.nio.DoubleBuffer._equals12040 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.nio.DoubleBuffer._compareTo12041 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.nio.DoubleBuffer._compareTo12042 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "compareTo", "(Ljava/nio/DoubleBuffer;)I"); 
			global::java.nio.DoubleBuffer._toString12043 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.nio.DoubleBuffer._isDirect12044 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "isDirect", "()Z"); 
			global::java.nio.DoubleBuffer._wrap12045 = @__env.GetStaticMethodID(global::java.nio.DoubleBuffer.staticClass, "wrap", "([DII)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._wrap12046 = @__env.GetStaticMethodID(global::java.nio.DoubleBuffer.staticClass, "wrap", "([D)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._allocate12047 = @__env.GetStaticMethodID(global::java.nio.DoubleBuffer.staticClass, "allocate", "(I)Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._duplicate12048 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "duplicate", "()Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._slice12049 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "slice", "()Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._asReadOnlyBuffer12050 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._compact12051 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "compact", "()Ljava/nio/DoubleBuffer;"); 
			global::java.nio.DoubleBuffer._order12052 = @__env.GetMethodID(global::java.nio.DoubleBuffer.staticClass, "order", "()Ljava/nio/ByteOrder;"); 
		} 
	} 
} 
